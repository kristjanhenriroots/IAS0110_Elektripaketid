﻿Imports System.Net.Http
Imports System.IO
Imports System.Text
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Globalization

Public Class MainForm

    Dim chartMaker As New chartMaker()

    Private Async Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ' Create HTTP client and set API key
            Dim client As New HttpClient()
            'client.DefaultRequestHeaders.Add("Authorization", "Bearer YOUR_API_KEY")

            ' Set start and end times for 24-hour period
            Dim startTime As String = DateTime.Now.ToString("yyyy-MM-dd'T'HH:mm:ssZ")
            Dim endTime As String = DateTime.Now.AddDays(1).ToString("yyyy-MM-dd'T'HH:mm:ssZ")

            ' Send GET request to Elering API
            Dim response As HttpResponseMessage = Await client.GetAsync($"https://dashboard.elering.ee/api/nps/price/csv?start={startTime}&end={endTime}&fields=ee")
            Dim content As Stream = Await response.Content.ReadAsStreamAsync()

            ' Parse CSV data and extract price data
            Dim times As New List(Of DateTime)()
            Dim prices As New List(Of Double)()
            Dim csvContent As New StringBuilder()
            Using reader As New StreamReader(content, Encoding.UTF8)
                ' Read header row
                csvContent.AppendLine(reader.ReadLine())

                While Not reader.EndOfStream
                    Dim line As String = reader.ReadLine()
                    csvContent.AppendLine(line)
                    Dim values As String() = line.Split(";"c)

                    Dim dateValue As DateTime = DateTime.ParseExact(values(1).Trim(""""), "dd.MM.yyyy HH:mm", CultureInfo.InvariantCulture)
                    Dim price As Double = Double.Parse(values(2).Trim("""").Replace(",", "."), CultureInfo.InvariantCulture)

                    ' Add dateValue to the times list and price to the prices list
                    times.Add(dateValue)
                    prices.Add(price)
                End While
            End Using



            chartMaker.setChart(MainChart, times.ToArray(), prices.ToArray())

        Catch ex As Exception
            MessageBox.Show("An error occurred while retrieving data from the Elering API: " & ex.Message)
        End Try
    End Sub

    Private Sub Chart_MouseMove(sender As Object, e As MouseEventArgs)
        Dim hit As HitTestResult = MainChart.HitTest(e.X, e.Y)

        If hit.ChartElementType = ChartElementType.DataPoint Then
            Dim point As DataPoint = MainChart.Series(0).Points(hit.PointIndex)
            ' Update tooltip to display date and time properly
            MainChart.Series(0).ToolTip = $"Time: {DateTime.FromOADate(point.XValue):HH:mm}{Environment.NewLine}Price: {point.YValues(0):F2}"
        End If
    End Sub

    Private Sub MainChart_Click(sender As Object, e As EventArgs) Handles MainChart.Click

    End Sub
End Class
