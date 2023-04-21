Imports System.Net.Http
Imports System.IO
Imports System.Text
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Globalization
Imports classCheap_calculator
Imports chartMaker
Imports System.Security.Cryptography
Imports packageComparator

Public Class MainForm
    Dim times As New List(Of DateTime)()
    Dim prices As New List(Of Double)()
    Dim chartMaker As iMakeChart = New UCchartMaker()
    Dim comparePackages As iComparePackages = New clPackageData()


    Private Async Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Get all package data from prj packageComparator, call function PackageData() for all names and prices
        Dim packagePrices = comparePackages.PackageData()

        ' Populate the listbox with the packages
        updateListBox(packagePrices)

        Try
            ' adding chartMaker instance and setting chartPanel control collection
            CType(chartMaker, Control).Dock = DockStyle.Fill
            chartPanel.Controls.Add(CType(chartMaker, Control))

            ' Create HTTP client and set API key
            Dim client As New HttpClient()
            'client.DefaultRequestHeaders.Add("Authorization", "Bearer YOUR_API_KEY")

            ' Set start and end times for 24-hour period
            Dim currentDate As DateTime = DateTime.Now.Date.AddHours(-3)
            Dim startTime As String = currentDate.ToString("yyyy-MM-dd'T'HH:mm:ssZ")
            Dim endTime As String = currentDate.AddDays(1).ToString("yyyy-MM-dd'T'HH:mm:ssZ")


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



            chartMaker.changeColors(startingIndex, Int(cbTimeFrame.SelectedItem))

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

    Private Sub updateListBox(data As Dictionary(Of String, Double))
        pakettCheckedListBox.Items.Clear()
        ' Populate the listbox with the packages
        For Each package As String In data.Keys
            pakettCheckedListBox.Items.Add(package)
        Next
    End Sub

    Private Sub jarjestamineComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles jarjestamineComboBox.SelectedIndexChanged
        ' Get the option chosen
        Dim selectedSortOption As String = jarjestamineComboBox.SelectedItem.ToString()

        ' Get the new order and Update listbox
        updateListBox(comparePackages.PackageSorter(selectedSortOption))
    End Sub

    Private Sub compareButton_Click(sender As Object, e As EventArgs) Handles compareButton.Click
        Dim selected = comparePackages.GetSelectedIndices(pakettCheckedListBox)
        Dim price As New Double
        Dim title As String = ""

        For Each index As Integer In selected
            title = pakettCheckedListBox.Items(index).ToString()
            price = comparePackages.PriceReturn(title)
            chartMaker.addComparison(times.ToArray(), title, price, index)
            Console.WriteLine("Selected index: " & index.ToString())
        Next
    End Sub
End Class
'=======
'﻿Imports System.Net.Http
'Imports System.IO
'Imports System.Text
'Imports System.Windows.Forms.DataVisualization.Charting
'Imports System.Globalization
'Imports AndmeParija.CAPIQuery
'Imports AndmeParija.CDatabaseQuery

'Public Class MainForm

'    Dim chartMaker As New chartMaker()
'    'combobox andmebaasi jaoks
'    Private comboBoxTable As New DataTable

'    Private Async Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
'        Try
'            ' Create HTTP client and set API key
'            Dim client As New HttpClient()
'            'client.DefaultRequestHeaders.Add("Authorization", "Bearer YOUR_API_KEY")

'            ' Set start and end times for 24-hour period
'            Dim startTime As String = DateTime.Now.AddHours(-4).ToString("yyyy-MM-dd'T'HH:mm:ssZ")
'            Dim endTime As String = DateTime.Now.AddDays(1).ToString("yyyy-MM-dd'T'HH:mm:ssZ")

'            ' Send GET request to Elering API
'            Dim response As HttpResponseMessage = Await client.GetAsync($"https://dashboard.elering.ee/api/nps/price/csv?start={startTime}&end={endTime}&fields=ee")
'            Dim content As Stream = Await response.Content.ReadAsStreamAsync()

'            ' Parse CSV data and extract price data
'            Dim times As New List(Of DateTime)()
'            Dim prices As New List(Of Double)()
'            Dim csvContent As New StringBuilder()
'            Using reader As New StreamReader(content, Encoding.UTF8)
'                ' Read header row
'                csvContent.AppendLine(reader.ReadLine())

'                While Not reader.EndOfStream
'                    Dim line As String = reader.ReadLine()
'                    csvContent.AppendLine(line)
'                    Dim values As String() = line.Split(";"c)

'                    Dim dateValue As DateTime = DateTime.ParseExact(values(1).Trim(""""), "dd.MM.yyyy HH:mm", CultureInfo.InvariantCulture)
'                    Dim price As Double = Double.Parse(values(2).Trim("""").Replace(",", "."), CultureInfo.InvariantCulture)

'                    ' Add dateValue to the times list and price to the prices list
'                    times.Add(dateValue)
'                    prices.Add(price)
'                End While
'            End Using
'            ' Print out the times and prices lists
'            For i As Integer = 0 To times.Count - 1
'                Console.WriteLine($"Time: {times(i)}, Price: {prices(i)}")
'            Next


'            chartMaker.setChart(MainChart, times.ToArray(), prices.ToArray())
'            AddHandler MainChart.MouseMove, AddressOf Chart_MouseMove

'        Catch ex As Exception
'            MessageBox.Show("An error occurred while retrieving data from the Elering API: " & ex.Message)
'        End Try

'        'Andmebaaside osa
'        'Tabelite laadimine


'        Dim updateBorsTable As AndmeParija.IAPIQuery
'        updateBorsTable = New AndmeParija.CAPIQuery
'        Try
'            updateBorsTable.updateTable()
'        Catch ex As Exception
'            MessageBox.Show("Error updating data table.")
'        End Try

'        Dim loadComboBoxValues As AndmeParija.IDatabaseQuery
'        loadComboBoxValues = New AndmeParija.CDatabaseQuery

'        comboBoxTable = loadComboBoxValues.queryData("Select dateTime FROM bors WHERE rowid > 1 LIMIT 25")

'        Dim dateTimeValues = New List(Of String)
'        For Each row As DataRow In comboBoxTable.Rows
'            dateTimeValues.Add(row(0))
'        Next

'        Dim providerValues = New List(Of String)

'        loadComboBoxValues = New AndmeParija.CDatabaseQuery
'        comboBoxTable = loadComboBoxValues.queryData("Select DISTINCT provider, name FROM borsPakett")
'        For Each row As DataRow In comboBoxTable.Rows
'            providerValues.Add(row(0))
'        Next

'        cbProvider.DataSource = providerValues
'        cbStartTime.BindingContext = New BindingContext
'        cbStartTime.DataSource = dateTimeValues
'        cbEndTime.BindingContext = New BindingContext
'        cbEndTime.DataSource = dateTimeValues

'    End Sub

'    Private Sub Chart_MouseMove(sender As Object, e As MouseEventArgs)
'        Dim hit As HitTestResult = MainChart.HitTest(e.X, e.Y)

'        If hit.ChartElementType = ChartElementType.DataPoint Then
'            Dim point As DataPoint = MainChart.Series(0).Points(hit.PointIndex)
'            ' Update tooltip to display date and time properly
'            MainChart.Series(0).ToolTip = $"Time: {DateTime.FromOADate(point.XValue).ToString("dd.MM.yyyy HH:mm")}{Environment.NewLine}Price: {point.YValues(0):F2}"
'        End If
'    End Sub


'    'Button tabs'
'    Private Sub calcButton_Click(sender As Object, e As EventArgs) Handles calcButton.Click
'        formCalc.Show()
'        Me.Hide()
'    End Sub

'    Private Sub vordlusButton_Click(sender As Object, e As EventArgs) Handles vordlusButton.Click
'        formVordlus.Show()
'        Me.Hide()
'    End Sub

'    'Size buttons
'    Private Sub enlargeButton_Click(sender As Object, e As EventArgs) Handles enlargeButton.Click
'        'Increase the size of the form and all its elements by 5%
'        Me.Width *= 1.05
'        Me.Height *= 1.05

'        For Each ctrl As Control In Me.Controls
'            ctrl.Width *= 1.05
'            ctrl.Height *= 1.05
'            ctrl.Left *= 1.05
'            ctrl.Top *= 1.05
'        Next
'    End Sub

'    Private Sub shrink_Click(sender As Object, e As EventArgs) Handles shrinkButton.Click
'        'Decrease the size of the form and all its elements by 5%
'        Me.Width *= 0.95
'        Me.Height *= 0.95

'        For Each ctrl As Control In Me.Controls
'            ctrl.Width *= 0.95
'            ctrl.Height *= 0.95
'            ctrl.Left *= 0.95
'            ctrl.Top *= 0.95
'        Next
'    End Sub

'    Private Sub MainChart_Click(sender As Object, e As EventArgs) Handles MainChart.Click

'    End Sub

'    Private Sub btnFindPackage_Click(sender As Object, e As EventArgs) Handles btnFindPackage.Click
'        Dim sbPakettPriceMargin As StringBuilder = New StringBuilder

'        Dim comboBoxSearch As AndmeParija.IDatabaseQuery
'        comboBoxSearch = New AndmeParija.CDatabaseQuery

'        Dim marginsTable As DataTable = comboBoxSearch.queryData("Select margin FROM borsPakett WHERE name = '" & cbPakett.SelectedValue & "'")
'        comboBoxSearch = New AndmeParija.CDatabaseQuery

'        Dim resultTable As DataTable = comboBoxSearch.queryData("Select DISTINCT dateTime, price/10 FROM bors WHERE rowid > 1 AND dateTime BETWEEN '" _
'                                                                  & cbStartTime.SelectedValue & "' AND '" & cbEndTime.SelectedValue & "'")

'        Dim pakettMargin As Object = marginsTable.Rows(0)(0)

'        resultTable.Columns.Add("priceMargin", GetType(Double))
'        For Each row As DataRow In resultTable.Rows
'            row("priceMargin") = row(1) + pakettMargin
'            Console.WriteLine(row(0) & " " & row(1) & " " & row(2))
'        Next

'        comboBoxSearch = New AndmeParija.CDatabaseQuery

'        marginsTable = comboBoxSearch.queryData("Select name, provider, margin FROM borsPakett ORDER BY margin ASC LIMIT 3")
'        sbPakettPriceMargin.AppendLine("3 Kõige väiksemat marginaali: ")
'        For Each row As DataRow In marginsTable.Rows
'            sbPakettPriceMargin.AppendLine(row(0).ToString & " " & row(1).ToString & " " & row(2).ToString)
'        Next
'        sbPakettPriceMargin.AppendLine()

'        comboBoxSearch = New AndmeParija.CDatabaseQuery
'        marginsTable = comboBoxSearch.queryData("Select name, provider, margin FROM borsPakett ORDER BY margin DESC LIMIT 3")
'        sbPakettPriceMargin.AppendLine("3 Kõige suuremat marginaali: ")
'        For Each row As DataRow In marginsTable.Rows
'            sbPakettPriceMargin.AppendLine(row(0).ToString & " " & row(1).ToString & " " & row(2).ToString)
'        Next
'        sbPakettPriceMargin.AppendLine()

'        sbPakettPriceMargin.AppendLine("Valitud paketti ajavahemiku hinnad tunnilõikes, koos hinnaga lõpptarbijale")
'        For Each row As DataRow In resultTable.Rows
'            sbPakettPriceMargin.AppendLine(row(0) & " " & row(1) & " " & row(2))
'        Next



'        Dim newForm As New formPriceMargin
'        newForm.tbPriceMargins.Text += sbPakettPriceMargin.ToString

'        newForm.dgvTimePrice.DataSource = resultTable
'        newForm.Show()

'    End Sub

'    Private Sub cbProvider_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbProvider.SelectedValueChanged
'        Dim nameValues = New List(Of String)
'        Dim nameRow As DataRow()
'        Dim filterStr As String = "provider = '" & cbProvider.SelectedValue & "'"
'        nameRow = comboBoxTable.Select(filterStr)

'        For Each row As DataRow In nameRow
'            nameValues.Add(row(1).ToString)
'        Next

'        cbPakett.DataSource = nameValues
'    End Sub
'End Class
'>>>>>>> Temp form for testing. Added solution to tempform.
