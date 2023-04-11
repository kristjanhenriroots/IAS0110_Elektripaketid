Imports System.Net.Http
Imports System.IO
Imports System.Text
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Globalization
Imports AndmeParija.CAPIQuery
Imports AndmeParija.CDatabaseQuery

Public Class MainForm

    Dim chartMaker As New chartMaker()

    Private Async Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
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
            ' Print out the times and prices lists
            For i As Integer = 0 To times.Count - 1
                Console.WriteLine($"Time: {times(i)}, Price: {prices(i)}")
            Next


            chartMaker.setChart(MainChart, times.ToArray(), prices.ToArray())
            AddHandler MainChart.MouseMove, AddressOf Chart_MouseMove

        Catch ex As Exception
            MessageBox.Show("An error occurred while retrieving data from the Elering API: " & ex.Message)
        End Try

        'Andmebaaside osa
        'Comboboxide laadimine
        Dim comboBoxTable As New DataTable

        Dim updateBorsTable As AndmeParija.IAPIQuery
        updateBorsTable = New AndmeParija.CAPIQuery
        Try
            updateBorsTable.updateTable()
        Catch ex As Exception
            MessageBox.Show("Error updating data table.")
        End Try

        Dim loadComboBoxValues As AndmeParija.IDatabaseQuery
        loadComboBoxValues = New AndmeParija.CDatabaseQuery

        comboBoxTable = loadComboBoxValues.queryData("Select dateTime FROM bors WHERE rowid > 1 LIMIT 21")

        Dim dateTimeValues = New List(Of String)
        For Each row As DataRow In comboBoxTable.Rows
            dateTimeValues.Add(row(0))
        Next

        cbStartTime.BindingContext = New BindingContext
        cbStartTime.DataSource = dateTimeValues
        cbEndTime.BindingContext = New BindingContext
        cbEndTime.DataSource = dateTimeValues

    End Sub

    Private Sub Chart_MouseMove(sender As Object, e As MouseEventArgs)
        Dim hit As HitTestResult = MainChart.HitTest(e.X, e.Y)

        If hit.ChartElementType = ChartElementType.DataPoint Then
            Dim point As DataPoint = MainChart.Series(0).Points(hit.PointIndex)
            ' Update tooltip to display date and time properly
            MainChart.Series(0).ToolTip = $"Time: {DateTime.FromOADate(point.XValue).ToString("dd.MM.yyyy HH:mm")}{Environment.NewLine}Price: {point.YValues(0):F2}"
        End If
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

    Private Sub MainChart_Click(sender As Object, e As EventArgs) Handles MainChart.Click

    End Sub
End Class
