Imports AndmeParija.CDatabaseQuery
Imports System.Data.SQLite
Imports System.Diagnostics.Eventing
Imports System.Globalization
Imports System.Reflection

Public Class CDatabaseQuery
    Implements IDatabaseQuery


    Private dbName As String = "enpakDB.db" 'Andmebaasi nimi

    Private dbPath As String = "..\..\..\databases\" & dbName 'Tee andmebaasini.
    Private connString As String = "Data Source=" & dbPath & ";Version=3" 'Ühenduse string. 

    Private connection As New SQLiteConnection(connString) 'Muutuja ühenduse loomiseks 
    Private command As New SQLiteCommand("", connection) 'Muutuja päringu saatmiseks

    Private answer As New DataTable 'Muutuja saadud andmete hoidmiseks


    'Funktsioon võtab käsu teksti parameetriks
    Private Sub retrieveData(commandTxt As String)
        connection.Open() 'Ava ühendus

        command.Connection = connection 'Andmebaasi ühenduse lisamine
        command.CommandText = commandTxt 'Päringu teksti lisamine

        Dim rdr As SQLiteDataReader = command.ExecuteReader 'Päringu teostus
        answer.Load(rdr) 'Päringu sisestamine lokaalsesse muutujasse

        connection.Close() 'Sulge ühendus
        Console.WriteLine("Retrieved")
    End Sub

    Private Sub processUpdate(timeAndPrice As Tuple(Of List(Of Date), List(Of Double)))
        Dim commandTxt As String

        Dim times = timeAndPrice.Item1.ToArray
        Dim prices = timeAndPrice.Item2.ToArray
        connection.Open()

        Dim index = 0
        For Each t In times
            Dim dateValue As DateTime = t
            Dim price As Double = prices(index)

            commandTxt = "UPDATE bors SET dateTime = '" & t.ToString("yyyy.MM.dd HH:mm") & 'Siin on 24h
            "', price = '" & price & "' WHERE rowid = " & index & ";"

            command.Connection = connection 'Andmebaasi ühenduse lisamine
            command.CommandText = commandTxt

            command.ExecuteNonQuery()
            index = index + 1
        Next

        connection.Close()
    End Sub

    Public Sub updateTable(tuple As Tuple(Of List(Of Date), List(Of Double))) Implements IDatabaseQuery.updateTable
        processUpdate(tuple)
    End Sub

    Private Function IDatabaseQuery_queryData(command As String) As DataTable Implements IDatabaseQuery.queryData
        retrieveData(command) 'Päringu funktsiooni väljakutsumine
        Return answer 'Tulemuse tagastus
    End Function
End Class
