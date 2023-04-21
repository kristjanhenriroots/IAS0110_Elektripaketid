Imports AndmeParija.CDatabaseQuery
Imports System.Data.SQLite

Public Class CDatabaseQuery
    Implements IDatabaseQuery


    Private dbName As String = "enpakDB.db" 'Andmebaasi nimi

    Private dbPath As String = "..\..\..\databases\" & dbName 'Tee andmebaasini. Ideaalis saaks relatiivselt, aga hetkel see ei toimi "C:\Users\Sander\dataDB\enpakDB.db"
    Private connString As String = "Data Source=" & dbPath & ";Version=3" 'Ühenduse string. 

    Private connection As New SQLiteConnection(connString) 'Muutuja ühenduse loomiseks 
    Private command As New SQLiteCommand("", connection) 'Muutuja päringu saatmiseks

    Private answer As New DataTable 'Muutuja saadud andmete hoidmiseks

    'Funktsioon võtab käsu teksti parameetriks
    Private Sub retrieveData(commandTxt As String)
        connection.Open() 'Ava ühendus

        command.Connection = connection 'Andmebaasi ühenduse lisamine
        command.CommandText = commandTxt 'Päringu teksti lisamine

        'Console.WriteLine("here " & dbPath) debugimiseks. Igno

        Dim rdr As SQLiteDataReader = command.ExecuteReader 'Päringu teostus
        answer.Load(rdr) 'Päringu sisestamine lokaalsesse muutujasse

        connection.Close() 'Sulge ühendus
    End Sub

    Private Function IDatabaseQuery_queryData(command As String) As DataTable Implements IDatabaseQuery.queryData
        retrieveData(command) 'Päringu funktsiooni väljakutsumine
        Return answer 'Tulemuse tagastus
    End Function
End Class
