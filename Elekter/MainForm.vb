Imports System.Net.Http
Imports System.IO
Imports System.Text
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Globalization
Imports classCheap_calculator
Imports chartMaker
Imports System.Security.Cryptography
Imports packageComparator
Imports API_Handler
Imports AndmeParija
Imports System.ComponentModel

Public Class MainForm
    Dim times As New List(Of DateTime)()                                    ' holds the times in DateTime format dd/mm/yyyy HH:mm . Corresponding price held in prices()
    Dim prices As New List(Of Double)()                                     ' holds the price in a double corresponding a time, the indices are the same with the previous list
    Dim chartMaker As iMakeChart = New UCchartMaker()                       ' project chartMaker interface
    Dim comparePackages As iComparePackages = New clPackageData()           ' project packageComparator interface
    Dim apiHandler As IhandleAPI = New ApiHandler()
    Dim frame As iPriceCalc = New TimeFrameCalc                             ' PriceCalc interface
    Dim rs As New Resizer                                                   ' calls the custom class for dynamic form resizing, see Resizer.vb
    Dim initialFormSize As SizeF                                            ' saves the initial form size, used to calculate the size factor when resizing fonts
    Dim initialFontSize As Single                                           ' saves the initial font size, used to calculate new font size dynamically


    Private databaseQuery As AndmeParija.IDatabaseQuery = New CDatabaseQuery()
    Private dictionaryTable As New DataTable 'Datatableid universaal pakettide jaoks
    Private comboBoxTable As New DataTable 'Esimene on vajalik pakettide võrdlemiseks, teine pakettide valimiseks
    Private footprintVar As New Double ' globaalne muutuja valitud paketti co2 jalajälje jaoks

    Dim universalPackages As DataTable
    Dim fixedPackages As DataTable
    Dim borsPackages As DataTable

    ' Main form load, currently
    '   1. Calls API and gets 24h pricing, will be changed to database
    '   2. 
    '
    '
    Private Async Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' calls custom resizer class, used for dynamic resizing
        rs.FindAllControls(Me)

        ' Setting a minimum size for the window to shrink to
        Me.MinimumSize = New Size(1000, 600)

        'Get package data as datatable from database
        dictionaryTable = databaseQuery.queryData("Select provider, name, avgPricePerKW FROM universaalPakett")

        ' Get all package data from prj packageComparator, call function PackageData() for all names and prices
        Dim packagePrices = comparePackages.PackageData(dictionaryTable)

        ' Populate the listbox with the packages
        updateListBox(packagePrices)

        ' adding chartMaker instance and setting chartPanel control collection
        CType(chartMaker, Control).Dock = DockStyle.Fill
        chartPanel.Controls.Add(CType(chartMaker, Control))

        databaseQuery = New CDatabaseQuery()
        Dim priceTimeTable As New DataTable

        Try
            Dim currentDate As DateTime = DateTime.Now.Date.AddHours(-3)
            Dim pricesAndTimes = Await apiHandler.GetPriceData(currentDate.AddDays(-7), currentDate.AddDays(1))
            priceTimeTable = databaseQuery.queryData("Select dateTime, price FROM bors WHERE dateTime BETWEEN '" &
                                                DateTime.Now.Date.ToString("yyyy.MM.dd HH:mm") &
                                                "' AND '" & DateTime.Now.Date.AddDays(1).ToString("yyyy.MM.dd HH:mm") & "'")
            'times = pricesAndTimes.Item1
            'prices = pricesAndTimes.Item2
            databaseQuery.updateTable(pricesAndTimes)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Dim a As DateTime
        For Each row As DataRow In priceTimeTable.Rows
            a = DateTime.ParseExact(row("dateTime"), "yyyy.MM.dd HH:mm", CultureInfo.InvariantCulture)
            times.Add(a)
            prices.Add(row("price"))
        Next

        ' Print out the times and prices lists just in case
        For i As Integer = 0 To times.Count - 1
            Console.WriteLine($"Time: {times(i)}, Price: {prices(i)}")
        Next
        chartMaker.setInitialChart(times.ToArray(), prices.ToArray()) ' make the chart for current market price
        Dim currentIndex = GetCurrentPrice()
        chartMaker.addCurrentTimeScatter(times(currentIndex), prices(currentIndex) / 2)

        initialFormSize = New SizeF(Me.Width, Me.Height)    ' Capture starting form and font size
        initialFontSize = calcButton.Font.Size

        'Database section
        'Comboboxi andmed
        databaseQuery = New AndmeParija.CDatabaseQuery
        Dim providerValues = New List(Of String)

        comboBoxTable = databaseQuery.queryData("Select DISTINCT provider, name, footprint FROM universaalPakett") 'Valitakse unikaalsed pakettid koos nende jalajälgedega

        Dim tempVar As String 'Ainult korraks vaja
        'Vajalik loop pakkujate filtreerimiseks
        For Each row As DataRow In comboBoxTable.Rows
            tempVar = row(0).ToString
            If Not providerValues.Contains(tempVar) Then 'Kontrollib, kas pakkuja on juba olemas
                providerValues.Add(row(0))
            End If
        Next

        cbProvider.DataSource = providerValues           'Täidab comboboxi pakkujatega

        'Pakettide pask. Parent kontroll 
        dgvPackages.Hide()
        dgvPackages.Parent = Me
        dgvPackages.Left = chartPanel.Left
        dgvPackages.Top = chartPanel.Top

        databaseQuery = New AndmeParija.CDatabaseQuery
        universalPackages = databaseQuery.queryData("SELECT name, provider, baseHourPrice, margin,
                                                            avgPricePerKW, averageMonthPrice, monthTax, source, 
                                                            footprint FROM universaalPakett")

        universalPackages.Columns("name").ColumnName = "Nimi"
        universalPackages.Columns("provider").ColumnName = "Pakkuja"
        universalPackages.Columns("baseHourPrice").ColumnName = "Tunnihind"
        universalPackages.Columns("avgPricePerKW").ColumnName = "Keskmine KW hind"
        universalPackages.Columns("margin").ColumnName = "Marginaal"
        universalPackages.Columns("averageMonthPrice").ColumnName = "Kuuhind"
        universalPackages.Columns("monthTax").ColumnName = "Kuumaks"
        universalPackages.Columns("footprint").ColumnName = "CO2 jalajälg"
        universalPackages.Columns("source").ColumnName = "Allikas"

        dgvPackages.DataSource = universalPackages

        databaseQuery = New AndmeParija.CDatabaseQuery
        fixedPackages = databaseQuery.queryData("SELECT name, provider,
                                                            avgPricePerKW, averageMonthPrice, monthTax, 
                                                            durationMonths, dayPrice,
                                                            nightPrice, ""24HPrice"",
                                                            source, footprint
                                                            FROM fikseeritudPakett")

        fixedPackages.Columns("name").ColumnName = "Nimi"
        fixedPackages.Columns("provider").ColumnName = "Pakkuja"
        fixedPackages.Columns("avgPricePerKW").ColumnName = "Keskmine KW hind"
        fixedPackages.Columns("averageMonthPrice").ColumnName = "Kuuhind"
        fixedPackages.Columns("monthTax").ColumnName = "Kuumaks"
        fixedPackages.Columns("durationMonths").ColumnName = "Paketi kestvus"
        fixedPackages.Columns("dayPrice").ColumnName = "Päeva hind"
        fixedPackages.Columns("nightPrice").ColumnName = "Öö hind"
        fixedPackages.Columns("24hPrice").ColumnName = "Ööpäeva hind"
        fixedPackages.Columns("footprint").ColumnName = "CO2 jalajälg"
        fixedPackages.Columns("source").ColumnName = "Allikas"


        databaseQuery = New AndmeParija.CDatabaseQuery
        borsPackages = databaseQuery.queryData("SELECT name, provider, margin,
                                                            averageMonthPrice, monthTax,
                                                            source, footprint
                                                            FROM borsPakett")

        borsPackages.Columns("name").ColumnName = "Nimi"
        borsPackages.Columns("provider").ColumnName = "Pakkuja"
        borsPackages.Columns("margin").ColumnName = "Marginaal"
        borsPackages.Columns("averageMonthPrice").ColumnName = "Kuuhind"
        borsPackages.Columns("monthTax").ColumnName = "Kuumaks"
        borsPackages.Columns("footprint").ColumnName = "CO2 jalajälg"
        borsPackages.Columns("source").ColumnName = "Allikas"

        'dadsad
        Dim packageInfo As New List(Of String)
        For Each col As DataColumn In universalPackages.Columns
            tempVar = col.ToString
            If Not packageInfo.Contains(tempVar) Then
                Console.WriteLine(tempVar)
                packageInfo.Add(col.ToString)
            End If
        Next
        For Each col As DataColumn In fixedPackages.Columns
            tempVar = col.ToString

            If Not packageInfo.Contains(tempVar) Then
                Console.WriteLine(tempVar)
                packageInfo.Add(col.ToString)
            End If
        Next
        For Each col As DataColumn In borsPackages.Columns
            tempVar = col.ToString

            If Not packageInfo.Contains(tempVar) Then
                Console.WriteLine(tempVar)
                packageInfo.Add(col.ToString)
            End If
        Next

        cbPackageFilter.DataSource = packageInfo
        cbPackageFilter.Hide()
        cbPackageType.Hide()

        dgvPackages.CurrentRow.Selected = False

        Dim packageTypes As String() = {"Universaalne", "Fikseeritud", "Börs"}
        cbPackageType.DataSource = packageTypes
    End Sub

    ' Handles dynamic form and font resizing when the user drags the window larger or smaller
    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        rs.ResizeAllControls(Me)                                                                                        ' Call the resizer class Resizer.vb
        Dim scaleFactor As Single = Math.Min(Me.Width / initialFormSize.Width, Me.Height / initialFormSize.Height)      ' Calculate new scalefactor for font sizing
        Dim newFontSize As Single = initialFontSize * scaleFactor                                                       ' New font size

        ' Check if scaleFactor is valid (i.e., not NaN or Infinity), problem with slower computers
        If Single.IsNaN(scaleFactor) OrElse Single.IsInfinity(scaleFactor) Then
            ' Skip resizing if scaleFactor is not valid
            Return
        End If

        For Each ctrl As Control In Me.Controls ' Locate all labels and checkboxes and change the font size, Resizer.vb won't handle that
            If TypeOf ctrl Is Label OrElse TypeOf ctrl Is CheckBox Then
                ctrl.Font = New Font(ctrl.Font.FontFamily, newFontSize, ctrl.Font.Style)
            End If
        Next
        chartMaker.UpdateMaxColumnWidth()   ' call the chartMaker class, column sizing will be recalculated as well
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

    ' Calculates the cheapest time to use electricity based on the amount of hours
    Private Sub btnCalcTimeFrame_Click(sender As Object, e As EventArgs) Handles btnCalcTimeFrame.Click

        ' combobox needs to have a value selected, and if there are enough hours in current data
        If cbTimeFrame.SelectedItem And Int(cbTimeFrame.SelectedItem) <= times.Count Then

            ' get the best time frame
            Dim time_frame = frame.CalcTimeFrame(Int(cbTimeFrame.SelectedItem), prices.ToArray(), times.ToArray())  ' get an array of 2 datetime type elements, first the beginning and then the ending time

            ' display the time frame and change colors accordingly
            tbRecTimeFrame.Text = (time_frame(0).ToString("HH:mm") & " - " & time_frame(1).ToString("HH:mm"))


            Dim startingIndex = frame.findTimeFrame(prices.ToArray(), times.ToArray(), time_frame(0))                                       ' what index in the times array is the beginning time
            Dim averageNow = Math.Round(frame.averagePriceBors(Int(cbTimeFrame.SelectedItem), prices.ToArray(), times.ToArray()), 2)        ' calculate averages for now and recommended times
            Dim averageTF = Math.Round(frame.averagePriceTimeFrame(Int(cbTimeFrame.SelectedItem), prices.ToArray(), startingIndex), 2)



            chartMaker.addRecommendedTime(time_frame(0), Int(cbTimeFrame.SelectedItem), averageTF)                                                ' indicate the recommended time on the chart

            lblAverageNow.Text = ("Keskmine hind: " & averageNow)
            lblAverageTF.Text = ("Keskmine soovituslik: " & averageTF)                                                                      ' show times and savings to user
            lblSavedPer.Text = ("Säästaksid: " & 100 - Math.Round(averageTF / averageNow * 100, 0) & "%")

        End If
    End Sub

    ' Returns current price for formCalc, might get removed later
    Public Function ReturnCurrentPrice()
        Return prices(GetCurrentPrice())
    End Function

    Private Function GetCurrentPrice() As Double
        Dim currentTime As DateTime = DateTime.Now
        Dim currentHour As Integer = currentTime.Hour
        Dim currentHourTime As DateTime = New DateTime(currentTime.Year, currentTime.Month, currentTime.Day, currentHour, 0, 0)

        Console.WriteLine(currentHourTime)

        Dim index As Integer = times.IndexOf(currentHourTime)

        If index >= 0 AndAlso index < prices.Count Then
            Return index
        Else
            Return -1 ' Return -1 or throw an exception if the price cannot be determined
        End If
    End Function


    ' Will update the listbox showing all electricity packages
    Private Sub updateListBox(data As Dictionary(Of String, Double))
        pakettCheckedListBox.Items.Clear()
        ' Populate the listbox with the packages
        For Each package As String In data.Keys
            pakettCheckedListBox.Items.Add(package)
        Next
    End Sub

    ' Update the sorting of the electricity packages when the user clicks
    Private Sub jarjestamineComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles jarjestamineComboBox.SelectedIndexChanged
        ' Get the option chosen
        Dim selectedSortOption As String = jarjestamineComboBox.SelectedItem.ToString()

        ' Get the new order and Update listbox
        updateListBox(comparePackages.PackageSorter(selectedSortOption))
    End Sub

    ' Handles comparing different electricity packages
    Private Sub compareButton_Click(sender As Object, e As EventArgs) Handles compareButton.Click
        Dim selected = comparePackages.GetSelectedIndices(pakettCheckedListBox)
        Dim price As New Double
        Dim title As String = ""

        ' If the user unchecked something then we need to make sure the graph has been removed for that package, loop through and look if they are active
        For i As Integer = 0 To 7
            If Not selected.Contains(i) Then
                chartMaker.removeChart(pakettCheckedListBox.Items(i).ToString())
            End If
        Next

        ' For each package the user has selected draw a graph
        For Each index As Integer In selected
            title = pakettCheckedListBox.Items(index).ToString()    ' Give a title
            price = comparePackages.PriceReturn(title)              ' Give a price
            chartMaker.addChart(times.ToArray(), New Double() {price}, title, False)  ' make the graph, price is typecast to array, only one value needed for linechart
            Console.WriteLine("Selected index: " & index.ToString())        ' debugging
        Next
    End Sub

    Private Sub btn7Davg_Click(sender As Object, e As EventArgs) Handles cbWeekAVG.CheckedChanged
        If cbWeekAVG.Checked Then
            Dim weekTimes As New List(Of DateTime)()
            Dim weekPrices As New List(Of Double)()

            databaseQuery = New CDatabaseQuery()
            Dim weekPriceTimeTable As New DataTable


            Try
                'Dim currentDate As DateTime = DateTime.Now.Date.AddHours(-3)
                'Dim weekPricesAndTimes = Await apiHandler.GetPriceData(currentDate.AddDays(-7), currentDate.AddDays(1))
                weekPriceTimeTable = databaseQuery.queryData("Select dateTime, price FROM bors WHERE dateTime BETWEEN '" &
                                               DateTime.Now.Date.AddDays(-7).ToString("yyyy.MM.dd HH:mm") &
                                               "' AND '" & DateTime.Now.Date.ToString("yyyy.MM.dd HH:mm") & "'")

                'weekTimes = weekPricesAndTimes.Item1
                'weekPrices = weekPricesAndTimes.Item2
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

            Dim a As DateTime
            For Each row As DataRow In weekPriceTimeTable.Rows
                a = DateTime.ParseExact(row("dateTime"), "yyyy.MM.dd HH:mm", CultureInfo.InvariantCulture)
                weekTimes.Add(a)
                weekPrices.Add(row("price"))
            Next

            Dim avg_prices = frame.averagePriceWeek(weekTimes.ToArray(), weekPrices.ToArray())
            Dim todayStart As DateTime = DateTime.Now.Date
            Dim hoursOfDay(23) As DateTime
            For i As Integer = 0 To 23
                hoursOfDay(i) = todayStart.AddHours(i)
            Next

            chartMaker.addChart(hoursOfDay, avg_prices, "Nädala keskmine", False)
        Else
            chartMaker.removeChart("Nädala keskmine")
        End If


    End Sub

    'Täidab pakettide valiku ainult antud pakkuja pakettidega
    Private Sub cbProvider_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbProvider.SelectedValueChanged
        Dim nameValues = New List(Of String)
        Dim nameRow As DataRow()
        Dim filterStr As String = "provider = '" & cbProvider.SelectedValue & "'" 'Filter pakkuja jaoks
        nameRow = comboBoxTable.Select(filterStr) 'Filtreerib datatablei ja paneb tulemuse datarowsse

        For Each row As DataRow In nameRow
            nameValues.Add(row(1).ToString) 'Lisab rows olevate pakettide nimed listi
        Next

        cbPackage.DataSource = nameValues 'Täidab comboboxi
    End Sub

    'Kuvab jalajälje muutumist pakettide vahel
    Private Sub cbPackage_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbPackage.SelectedValueChanged
        'Esimesel käivitusel on tühi, seega täida esimese ettejuhtuva paketti CO2 jalajäljega
        If String.IsNullOrEmpty(tbCO2.Text) Then
            For Each row As DataRow In comboBoxTable.Rows
                If row(0) = cbProvider.SelectedValue And row(1) = cbPackage.SelectedValue Then
                    tbCO2.Text = row(2)
                    footprintVar = row(2)
                End If
            Next
        Else
            'Kui on juba, siis võtab olemasoleva jalajälje ning näitab paketi vahetuse uut jalajälge
            For Each row As DataRow In comboBoxTable.Rows
                If row(0) = cbProvider.SelectedValue And row(1) = cbPackage.SelectedValue Then
                    tbCO2.Text = footprintVar & "->" & row(2)
                End If
            Next
        End If
    End Sub

    'Kinnitab paketti ja paneb CO2 jalajälje lahtrisse
    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        For Each row As DataRow In comboBoxTable.Rows
            If row(0) = cbProvider.SelectedValue And row(1) = cbPackage.SelectedValue Then
                tbCO2.Text = row(2)
                footprintVar = row(2)
            End If
        Next

        Console.WriteLine(dgvPackages.CurrentRow.Cells("Nimi").Value)

    End Sub

    Private Sub otsingButton_Click(sender As Object, e As EventArgs) Handles otsingButton.Click
        chartPanel.Hide()
        cbWeekAVG.Hide()
        cbTimeFrame.Hide()
        tbRecTimeFrame.Hide()
        btnCalcTimeFrame.Hide()

        lblValik.Hide()
        lblAverageTF.Hide()
        lblAverageNow.Hide()
        lblSavedPer.Hide()
        lblTarbimisaeg.Hide()

        dgvPackages.Show()
        cbPackageType.Show()
        cbPackageFilter.Show()

    End Sub

    Private Sub homeButton_Click(sender As Object, e As EventArgs) Handles homeButton.Click

        chartPanel.Show()
        cbWeekAVG.Show()
        cbTimeFrame.Show()
        tbRecTimeFrame.Show()
        btnCalcTimeFrame.Show()

        lblValik.Show()
        lblAverageTF.Show()
        lblAverageNow.Show()
        lblSavedPer.Show()
        lblTarbimisaeg.Show()

        dgvPackages.Hide()
        cbPackageType.Hide()
        cbPackageFilter.Hide()

    End Sub


    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click

        If dgvPackages.Columns.Contains(cbPackageFilter.SelectedItem) Then
            dgvPackages.Sort(dgvPackages.Columns(cbPackageFilter.SelectedItem), ListSortDirection.Ascending)
        End If

    End Sub

    Private Sub cbPackageType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPackageType.SelectedIndexChanged
        If cbPackageType.SelectedValue = "Universaalne" Then
            dgvPackages.DataSource = universalPackages
        ElseIf cbPackageType.SelectedValue = "Fikseeritud" Then
            dgvPackages.DataSource = fixedPackages
        ElseIf cbPackageType.SelectedValue = "Börs" Then
            dgvPackages.DataSource = borsPackages
        End If
    End Sub
End Class
