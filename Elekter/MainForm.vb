Imports System.Net.Http
Imports System.IO
Imports System.Text
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Globalization
Imports classCheap_calculator
Imports chartMaker

Public Class MainForm
    Dim times As New List(Of DateTime)()
    Dim prices As New List(Of Double)()
    Dim chartMaker As iMakeChart = New UCchartMaker()

    Private Async Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            CType(chartMaker, Control).Dock = DockStyle.Fill
            chartPanel.Controls.Add(CType(chartMaker, Control))

            ' Create HTTP client and set API key
            Dim client As New HttpClient()
            'client.DefaultRequestHeaders.Add("Authorization", "Bearer YOUR_API_KEY")

            ' Set start and end times for 24-hour period
            Dim startTime As String = DateTime.Now.AddHours(-4).ToString("yyyy-MM-dd'T'HH:mm:ssZ")
            Dim endTime As String = DateTime.Now.AddDays(1).ToString("yyyy-MM-dd'T'HH:mm:ssZ")

            ' Send GET request to Elering API
            Dim response As HttpResponseMessage = Await client.GetAsync($"https://dashboard.elering.ee/api/nps/price/csv?start={startTime}&end={endTime}&fields=ee")
            Dim content As Stream = Await response.Content.ReadAsStreamAsync()

            ' Parse CSV data and extract price data

            Dim csvContent As New StringBuilder()
            Using reader As New StreamReader(content, Encoding.UTF8)
                ' Read header row
                csvContent.AppendLine(reader.ReadLine())

                While Not reader.EndOfStream
                    Dim line As String = reader.ReadLine()
                    csvContent.AppendLine(line)
                    Dim values As String() = line.Split(";"c)

                    Dim dateValue As DateTime = DateTime.ParseExact(values(1).Trim(""""), "dd.MM.yyyy HH:mm", CultureInfo.InvariantCulture)
                    Dim price As Double = Double.Parse(values(2).Trim("""").Replace(",", "."), CultureInfo.InvariantCulture) * 1.2 / 10

                    ' Add dateValue to the times list and price to the prices list
                    times.Add(dateValue)
                    prices.Add(price)
                End While
            End Using
            ' Print out the times and prices lists
            For i As Integer = 0 To times.Count - 1
                Console.WriteLine($"Time: {times(i)}, Price: {prices(i)}")
            Next


            chartMaker.setChart(times.ToArray(), prices.ToArray())


        Catch ex As Exception
            MessageBox.Show("An error occurred while retrieving data from the Elering API: " & ex.Message)
        End Try
    End Sub

    'Button tabs'
    Private Sub calcButton_Click(sender As Object, e As EventArgs) Handles calcButton.Click
        formCalc.Show()
        Me.Hide()
    End Sub

    Private Sub vordlusButton_Click(sender As Object, e As EventArgs) Handles vordlusButton.Click
        formVordlus.Show()
        Me.Hide()
    End Sub

    'Size buttons
    Private Sub enlargeButton_Click(sender As Object, e As EventArgs) Handles enlargeButton.Click
        'Increase the size of the form and all its elements by 5%
        Me.Width *= 1.05
        Me.Height *= 1.05

        For Each ctrl As Control In Me.Controls
            ctrl.Width *= 1.05
            ctrl.Height *= 1.05
            ctrl.Left *= 1.05
            ctrl.Top *= 1.05
        Next
    End Sub

    Private Sub shrink_Click(sender As Object, e As EventArgs) Handles shrinkButton.Click
        'Decrease the size of the form and all its elements by 5%
        Me.Width *= 0.95
        Me.Height *= 0.95

        For Each ctrl As Control In Me.Controls
            ctrl.Width *= 0.95
            ctrl.Height *= 0.95
            ctrl.Left *= 0.95
            ctrl.Top *= 0.95
        Next
    End Sub

    ' Calculates the cheapest time to use electricity based on the amount of hours
    Private Sub btnCalcTimeFrame_Click(sender As Object, e As EventArgs) Handles btnCalcTimeFrame.Click

        ' combobox needs to have a value selected
        If cbTimeFrame.SelectedItem Then ' And Int(cbTimeFrame.SelectedItem) <= MainChart.Series(0).Points.Count - 1 Then

            ' get the best time frame
            Dim frame As iPriceCalc = New TimeFrameCalc
            Dim time_frame = frame.CalcTimeFrame(Int(cbTimeFrame.SelectedItem), prices.ToArray(), times.ToArray())


            'MessageBox.Show("the selected value is " & Int(ComboBox2.SelectedItem))
            ' display the time frame and change colors accordingly
            tbRecTimeFrame.Text = (time_frame(0).ToString("HH:mm") & " - " & time_frame(1).ToString("HH:mm"))
            Dim startingIndex = frame.findTimeFrame(prices.ToArray(), times.ToArray(), time_frame(0))
            Dim averageNow = Math.Round(frame.averagePriceBors(Int(cbTimeFrame.SelectedItem), prices.ToArray(), times.ToArray()), 2)
            Dim averageTF = Math.Round(frame.averagePriceTimeFrame(Int(cbTimeFrame.SelectedItem), prices.ToArray(), startingIndex), 2)



            chartMaker.changeColors(times.ToArray(), Int(cbTimeFrame.SelectedItem), startingIndex)

            lblAverageNow.Text = ("Keskmine hind: " & averageNow)
            'MessageBox.Show("Sending values: " & startingIndex.ToString())
            lblAverageTF.Text = ("Keskmine soovituslik: " & averageTF)
            lblSavedPer.Text = ("Säästaksid: " & 100 - Math.Round(averageTF / averageNow * 100, 0) & "%")

        End If
    End Sub

    Public Function ReturnCurrentPrice()
        Return prices.First
    End Function

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles lblAverageTF.Click

    End Sub
End Class
