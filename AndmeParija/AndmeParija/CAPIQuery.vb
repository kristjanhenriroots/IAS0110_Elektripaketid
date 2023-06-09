﻿Imports System.Data.SQLite
Imports System.Net.Http
Imports System.IO
Imports System.Text
Imports System.Globalization
Public Class CAPIQuery
    Implements IAPIQuery

    ' Create HTTP client and set API key
    Private client As New HttpClient()

    'DB stuff
    Private dbName As String = "enpakDB.db" 'Andmebaasi nimi

    Private dbPath As String = "..\..\..\databases\" & dbName 'Tee andmebaasini.
    Private connString As String = "Data Source=" & dbPath & ";Version=3" 'Ühenduse string. 

    Private connection As New SQLiteConnection(connString) 'Muutuja ühenduse loomiseks 
    Private command As New SQLiteCommand("", connection) 'Muutuja päringu saatmiseks

    Private answer As New DataTable 'Muutuja saadud andmete hoidmiseks

    Private commandTxt As String = ""


    Private Async Sub testSub()
        ' Set start and end times for 24-hour period
        Dim startTime As String = DateTime.Today.ToString("yyyy-MM-dd'T'HH:mm:ssZ")
        Dim endTime As String = DateTime.Today.AddDays(1).ToString("yyyy-MM-dd'T'HH:mm:ssZ")

        ' Send GET request to Elering API
        Dim response As HttpResponseMessage = Await client.GetAsync($"https://dashboard.elering.ee/api/nps/price/csv?start={startTime}&end={endTime}&fields=ee")
        Dim content As Stream = Await response.Content.ReadAsStreamAsync()

        Dim index As Integer = 2

        Dim csvContent As New StringBuilder()

        connection.Open() 'Ava ühendus

        Using reader As New StreamReader(content, Encoding.UTF8)
            csvContent.AppendLine(reader.ReadLine())
            While Not reader.EndOfStream
                Dim line As String = reader.ReadLine()
                csvContent.AppendLine(line)
                Dim values As String() = line.Split(";"c)

                Dim timeTemplate As Integer = Integer.Parse(values(0).Trim(""""), CultureInfo.InvariantCulture)
                Dim dateValue As DateTime = DateTime.ParseExact(values(1).Trim(""""), "dd.MM.yyyy HH:mm", CultureInfo.InvariantCulture) 'Siin on AM/PM
                Dim price As Double = Double.Parse(values(2).Trim("""").Replace(",", "."), CultureInfo.InvariantCulture)

                commandTxt = "UPDATE bors SET timeTemplateUTC = '" & timeTemplate & "', dateTime = '" & dateValue.ToString("dd.MM.yyyy HH:mm") & 'Siin on 24h
                "', price = '" & price * 1.2 / 10 & "' WHERE rowid = " & index & ";" 'Päringu teksti lisamine. Rowid peab olema alguses 2, sest esimene row on csv failis stringid :/

                command.Connection = connection 'Andmebaasi ühenduse lisamine
                command.CommandText = commandTxt

                command.ExecuteNonQuery()
                index = index + 1
            End While
        End Using

        connection.Close()
    End Sub

    Public Sub updateTable() Implements IAPIQuery.updateTable
        testSub()
    End Sub

End Class
