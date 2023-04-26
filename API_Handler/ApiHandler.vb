Imports System.Globalization
Imports System.IO
Imports System.Net.Http
Imports System.Text

Public Class ApiHandler
    Implements IhandleAPI

    Public Async Function GetPriceData(startTime As DateTime, endtime As DateTime) As Task(Of Tuple(Of List(Of DateTime), List(Of Double))) Implements IhandleAPI.GetPriceData
        Dim times As New List(Of DateTime)()
        Dim prices As New List(Of Double)()

        Try
            Dim client As New HttpClient()
            Dim startTimeFormat As String = startTime.ToString("yyyy-MM-dd'T'HH:mm:ssZ")
            Dim endTimeFormat As String = endtime.ToString("yyyy-MM-dd'T'HH:mm:ssZ")
            Dim response As HttpResponseMessage = Await client.GetAsync($"https://dashboard.elering.ee/api/nps/price/csv?start={startTimeFormat}&end={endTimeFormat}&fields=ee")
            Dim content As Stream = Await response.Content.ReadAsStreamAsync()
            Dim csvContent As New StringBuilder()

            Using reader As New StreamReader(content, Encoding.UTF8)
                csvContent.AppendLine(reader.ReadLine())

                While Not reader.EndOfStream
                    Dim line As String = reader.ReadLine()
                    csvContent.AppendLine(line)
                    Dim values As String() = line.Split(";"c)

                    Dim dateValue As DateTime = DateTime.ParseExact(values(1).Trim(""""), "dd.MM.yyyy HH:mm", CultureInfo.InvariantCulture) ' .AddHours(-3)
                    Dim price As Double = Double.Parse(values(2).Trim("""").Replace(",", "."), CultureInfo.InvariantCulture) * 1.2 / 10

                    times.Add(dateValue)
                    prices.Add(price)
                End While
            End Using
        Catch ex As Exception
            Throw New ApplicationException("An error occurred while retrieving data from the Elering API: " & ex.Message)
        End Try
        Console.WriteLine("API handler end")

        Return Tuple.Create(times, prices)
    End Function
End Class
