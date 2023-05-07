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
Imports CSVExporterDNF
Imports CSVexport

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
    Dim exporter As IExporter = New CExporter                               ' CSV exporter component

    Private databaseQuery As AndmeParija.IDatabaseQuery = New CDatabaseQuery()
    Private dictionaryTable As New DataTable 'Datatableid universaal pakettide jaoks
    Private comboBoxTable As New DataTable 'Esimene on vajalik pakettide võrdlemiseks, teine pakettide valimiseks
    Private footprintVar As New Double ' globaalne muutuja valitud paketti co2 jalajälje jaoks

    Private priceTimeTable As DataTable
    Private universalPackages As DataTable
    Private fixedPackages As DataTable
    Private borsPackages As DataTable

    Private selectedPackage As String
    Private selectedPackageText As String = "Hetkel valitud pakett: "

    Private appliances As Dictionary(Of String, Double)

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

        Try
            Dim currentDate As DateTime = DateTime.Now.Date.AddHours(-3)
            Dim pricesAndTimes = Await apiHandler.GetPriceData(currentDate.AddDays(-7), currentDate.AddDays(1))
            priceTimeTable = databaseQuery.queryData("Select dateTime, price FROM bors WHERE dateTime BETWEEN '" &
                                                DateTime.Now.AddDays(-7).Date.ToString("yyyy.MM.dd HH:mm") &
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

        'cbProvider.DataSource = providerValues           'Täidab comboboxi pakkujatega

        'Pakettide pask. Parent kontroll 

        dgvPackages.Parent = Me
        dgvPackages.Left = chartPanel.Left
        dgvPackages.Top = chartPanel.Top

        applianceComboBox.Parent = Me
        applianceComboBox.Top = chartPanel.Top + 50
        applianceComboBox.Left = chartPanel.Left + 100
        powerRatingTextBox.Parent = Me
        powerRatingTextBox.Top = applianceComboBox.Top + 30
        powerRatingTextBox.Left = applianceComboBox.Left
        timeUsedTextBox.Parent = Me
        timeUsedTextBox.Top = powerRatingTextBox.Top + 30
        timeUsedTextBox.Left = applianceComboBox.Left
        electricityRateTextBox.Parent = Me
        electricityRateTextBox.Top = timeUsedTextBox.Top + 30
        electricityRateTextBox.Left = applianceComboBox.Left
        costTextBox.Parent = Me
        costTextBox.Top = electricityRateTextBox.Top + 30
        costTextBox.Left = applianceComboBox.Left
        calculateButton.Parent = Me
        calculateButton.Top = costTextBox.Top + 30
        calculateButton.Left = applianceComboBox.Left

        applianceLabel.Parent = Me
        applianceLabel.Top = applianceComboBox.Top
        applianceLabel.Left = applianceComboBox.Left - 100
        powerRatingLabel.Parent = Me
        powerRatingLabel.Top = powerRatingTextBox.Top
        powerRatingLabel.Left = powerRatingTextBox.Left - 105
        timeUsedLabel.Parent = Me
        timeUsedLabel.Top = timeUsedTextBox.Top
        timeUsedLabel.Left = timeUsedTextBox.Left - 97
        electricityRateLabel.Parent = Me
        electricityRateLabel.Top = electricityRateTextBox.Top
        electricityRateLabel.Left = electricityRateTextBox.Left - 90
        costLabel.Parent = Me
        costLabel.Top = costTextBox.Top
        costLabel.Left = costTextBox.Left - 87




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
                                                durationMonths, dayPrice, nightPrice, ""24HPrice"",
                                                source, footprint FROM fikseeritudPakett")

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
        borsPackages.Columns.Add("Hind Marginaaliga", GetType(Double))
        borsPackages.Columns("Hind Marginaaliga").SetOrdinal(1)
        Dim index = 0
        For Each row As DataRow In borsPackages.Rows
            row("Hind Marginaaliga") = Math.Round(prices(index) + row("Marginaal"), 2)
            index = index + 1
        Next

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

        dgvPackages.Hide()
        cbPackageFilter.Hide()
        cbPackageType.Hide()
        btnFilter.Hide()
        btnConfirm.Hide()
        btnMargins.Hide()
        cbStartTime.Hide()
        cbEndTime.Hide()
        tbMargins.Hide()
        lblCO2.Hide()
        tbCO2.Hide()

        dgvPackages.CurrentRow.Selected = False

        Dim packageTypes As String() = {"Universaalne", "Fikseeritud", "Börs"}
        Dim filterOrder As String() = {"Kasvav", "Kahanev"}
        cbPackageType.DataSource = packageTypes
        cbOrder.DataSource = filterOrder

        selectedPackage = dgvPackages.CurrentRow.Cells("Pakkuja").Value + " " + dgvPackages.CurrentRow.Cells("Nimi").Value
        lblSelectedPackage.Text = selectedPackageText + selectedPackage

        Dim borsTimes As New List(Of String)
        For Each t In times
            borsTimes.Add(t.ToString("yyyy.MM.dd HH:mm"))
            Console.WriteLine(t.ToString("yyyy.MM.dd HH:mm"))
        Next

        cbStartTime.BindingContext = New BindingContext
        cbStartTime.DataSource = borsTimes
        cbEndTime.BindingContext = New BindingContext
        cbEndTime.DataSource = borsTimes

        'Kalkulaator

        'Set combobox dropdown style so user can't write'
        applianceComboBox.DropDownStyle = ComboBoxStyle.DropDownList

        'Disable calculateButton until all required entries are filled'
        calculateButton.Enabled = False

        'Set costTextBox to read-only'
        costTextBox.ReadOnly = True

        'Fill appliances dictionary'
        'Data from: https://rohe.geenius.ee/rubriik/uudis/millised-su-kodumasinad-kulutavad-aastas-enim-elektrit-ei-see-pole-pesumasin-voi-elektripliit/'
        appliances = New Dictionary(Of String, Double) From {
            {"Mikrolaineahi [1000W]", 1000},
            {"Kohvimasin [1000 W]", 1000},
            {"Veekeetja [1500 W]", 1500},
            {"Keraamiline pliit [2000 W]", 2000},
            {"Induktsioonpliit [2500 W]", 2500},
            {"Elektripliit [2500 W]", 2500},
            {"Elektriahi [3000 W]", 3000},
            {"Triikraud [2000 W]", 2000},
            {"Tolmuimeja [800 W]", 800},
            {"Mängukonsool [90 W]", 90},
            {"Digiboks [60 W]", 60},
            {"Wifi ruuter [20 W]", 20},
            {"Kell-raadio [10 W]", 10},
            {"Elektriboiler 100 l [2200 W]", 2200},
            {"Elektriradiaator [2000 W]", 2000},
            {"Valgusti Halogeen [60 W]", 60},
            {"Valgusti LED [10 W]", 10},
            {"Laptop [50 W]", 50},
            {"Arvuti [250 W]", 250},
            {"Televisioon [100 W]", 100}
        }

        For Each applianceName As String In appliances.Keys
            applianceComboBox.Items.Add(applianceName)
        Next
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
    ' Calculates the cheapest time to use electricity based on the amount of hours
    Private Sub btnCalcTimeFrame_Click(sender As Object, e As EventArgs) Handles btnCalcTimeFrame.Click
        ' combobox needs to have a value selected
        If cbTimeFrame.SelectedItem Then
            Dim currentIndex As Integer = GetCurrentPrice()

            If currentIndex >= 0 AndAlso Int(cbTimeFrame.SelectedItem) <= times.Count - currentIndex Then

                Dim remainingPrices As Double() = prices.GetRange(currentIndex, prices.Count - currentIndex).ToArray()
                Dim remainingTimes As DateTime() = times.GetRange(currentIndex, times.Count - currentIndex).ToArray()

                ' get the best time frame
                Dim time_frame = frame.CalcTimeFrame(Int(cbTimeFrame.SelectedItem), remainingPrices, remainingTimes)  ' get an array of 2 datetime type elements, first the beginning and then the ending time

                ' display the time frame and change colors accordingly
                tbRecTimeFrame.Text = (time_frame(0).ToString("HH:mm") & " - " & time_frame(1).ToString("HH:mm"))

                Dim startingIndex = frame.findTimeFrame(remainingPrices, remainingTimes, time_frame(0))                                       ' what index in the times array is the beginning time
                Dim averageNow = Math.Round(frame.averagePriceBors(Int(cbTimeFrame.SelectedItem), remainingPrices, remainingTimes), 2)        ' calculate averages for now and recommended times
                Dim averageTF = Math.Round(frame.averagePriceTimeFrame(Int(cbTimeFrame.SelectedItem), remainingPrices, startingIndex), 2)

                chartMaker.addRecommendedTime(time_frame(0), Int(cbTimeFrame.SelectedItem), averageTF)                                                ' indicate the recommended time on the chart

                lblAverageNow.Text = ("Keskmine hind: " & averageNow)
                lblAverageTF.Text = ("Keskmine soovituslik: " & averageTF)                                                                      ' show times and savings to user
                lblSavedPer.Text = ("Säästaksid: " & 100 - Math.Round(averageTF / averageNow * 100, 0) & "%")

            End If
        End If
    End Sub







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

    Private Sub dgvPackages_Click(sender As Object, e As EventArgs) Handles dgvPackages.Click

        If String.IsNullOrEmpty(tbCO2.Text) Then
            tbCO2.Text = dgvPackages.CurrentRow.Cells("CO2 jalajälg").Value.ToString
            footprintVar = dgvPackages.CurrentRow.Cells("CO2 jalajälg").Value
        Else
            tbCO2.Text = footprintVar & "->" & dgvPackages.CurrentRow.Cells("CO2 jalajälg").Value.ToString
        End If

    End Sub

    'Kinnitab paketti ja paneb CO2 jalajälje lahtrisse
    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click

        tbCO2.Text = dgvPackages.CurrentRow.Cells("CO2 jalajälg").Value.ToString
        footprintVar = dgvPackages.CurrentRow.Cells("CO2 jalajälg").Value


        selectedPackage = dgvPackages.CurrentRow.Cells("Pakkuja").Value + " " + dgvPackages.CurrentRow.Cells("Nimi").Value
        lblSelectedPackage.Text = selectedPackageText + selectedPackage

        If cbPackageType.SelectedItem = "Börs" Then
            electricityRateTextBox.Text = dgvPackages.CurrentRow.Cells("Hind Marginaaliga").Value
        Else
            electricityRateTextBox.Text = dgvPackages.CurrentRow.Cells("Keskmine KW hind").Value

        End If

    End Sub

    'Button tabs'
    Private Sub otsingButton_Click(sender As Object, e As EventArgs) Handles otsingButton.Click

        chartPanel.Hide()
        cbWeekAVG.Hide()
        cbTimeFrame.Hide()
        tbRecTimeFrame.Hide()
        btnCalcTimeFrame.Hide()
        pakettCheckedListBox.Hide()
        lblValik.Hide()
        lblAverageTF.Hide()
        lblAverageNow.Hide()
        lblSavedPer.Hide()
        lblTarbimisaeg.Hide()
        lblPackageList.Hide()

        dgvPackages.Show()
        cbPackageType.Show()
        cbPackageFilter.Show()
        btnFilter.Show()
        cbOrder.Show()
        btnConfirm.Show()
        btnMargins.Show()
        cbStartTime.Show()
        cbEndTime.Show()
        tbMargins.Show()
        lblCO2.Show()
        tbCO2.Show()

        applianceComboBox.Hide()
        costTextBox.Hide()
        electricityRateTextBox.Hide()
        powerRatingTextBox.Hide()
        timeUsedTextBox.Hide()
        applianceLabel.Hide()
        costLabel.Hide()
        electricityRateLabel.Hide()
        powerRatingLabel.Hide()
        timeUsedLabel.Hide()

    End Sub

    Private Sub homeButton_Click(sender As Object, e As EventArgs) Handles homeButton.Click

        chartPanel.Show()
        cbWeekAVG.Show()
        cbTimeFrame.Show()
        tbRecTimeFrame.Show()
        btnCalcTimeFrame.Show()
        pakettCheckedListBox.Show()

        lblValik.Show()
        lblAverageTF.Show()
        lblAverageNow.Show()
        lblSavedPer.Show()
        lblTarbimisaeg.Show()
        lblPackageList.Show()

        dgvPackages.Hide()
        cbPackageType.Hide()
        cbPackageFilter.Hide()
        btnFilter.Hide()
        cbOrder.Hide()
        btnConfirm.Hide()
        btnMargins.Hide()
        cbStartTime.Hide()
        cbEndTime.Hide()
        tbMargins.Hide()
        lblCO2.Hide()
        tbCO2.Hide()

        applianceComboBox.Hide()
        costTextBox.Hide()
        electricityRateTextBox.Hide()
        powerRatingTextBox.Hide()
        timeUsedTextBox.Hide()
        applianceLabel.Hide()
        costLabel.Hide()
        electricityRateLabel.Hide()
        powerRatingLabel.Hide()
        timeUsedLabel.Hide()

    End Sub

    Private Sub calcButton_Click(sender As Object, e As EventArgs) Handles calcButton.Click

        chartPanel.Hide()
        cbWeekAVG.Hide()
        cbTimeFrame.Hide()
        tbRecTimeFrame.Hide()
        btnCalcTimeFrame.Hide()
        pakettCheckedListBox.Hide()

        lblValik.Hide()
        lblAverageTF.Hide()
        lblAverageNow.Hide()
        lblSavedPer.Hide()
        lblTarbimisaeg.Hide()
        lblPackageList.Hide()

        dgvPackages.Hide()
        cbPackageType.Hide()
        cbPackageFilter.Hide()
        btnFilter.Hide()
        cbOrder.Hide()
        btnConfirm.Hide()
        btnMargins.Hide()
        cbStartTime.Hide()
        cbEndTime.Hide()
        tbMargins.Hide()
        lblCO2.Hide()
        tbCO2.Hide()

        applianceComboBox.Show()
        costTextBox.Show()
        electricityRateTextBox.Show()
        powerRatingTextBox.Show()
        timeUsedTextBox.Show()
        calculateButton.Show()
        applianceLabel.Show()
        costLabel.Show()
        electricityRateLabel.Show()
        powerRatingLabel.Show()
        timeUsedLabel.Show()

    End Sub

    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click

        If dgvPackages.Columns.Contains(cbPackageFilter.SelectedItem) Then
            If cbOrder.SelectedValue = "Kasvav" Then
                dgvPackages.Sort(dgvPackages.Columns(cbPackageFilter.SelectedItem), ListSortDirection.Ascending)
            ElseIf cbOrder.SelectedValue = "Kahanev" Then
                dgvPackages.Sort(dgvPackages.Columns(cbPackageFilter.SelectedItem), ListSortDirection.Descending)
            End If

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

    Private Sub btnMargins_Click(sender As Object, e As EventArgs) Handles btnMargins.Click
        Dim tempTable = priceTimeTable
        Dim sbPackagePriceMargin As New StringBuilder
        sbPackagePriceMargin.AppendLine("Valitud ajavahemiku börsi hinnad ilma ja koos marginaalita")
        If cbPackageType.SelectedValue = "Börs" Then

            Dim packageMargin = dgvPackages.CurrentRow.Cells("Marginaal")
            If Not tempTable.Columns.Contains("priceMargin") Then
                tempTable.Columns.Add("priceMargin", GetType(Double))
            End If
            Dim i = 0
            For Each row In tempTable.Rows
                row("priceMargin") = Math.Round(row("price") + dgvPackages.CurrentRow.Cells("Marginaal").Value, 2)
            Next

            For Each row As DataRow In tempTable.Rows
                If row("dateTime") >= cbStartTime.SelectedItem And row("dateTime") <= cbEndTime.SelectedItem Then
                    sbPackagePriceMargin.AppendLine(row("dateTime") & " " & row("price") & " " & row("priceMargin"))
                    Console.WriteLine(row("dateTime") & " " & row("price") & " " & row("priceMargin"))
                End If
            Next
        Else
            MessageBox.Show("Marginaale saab vaadata ainult börsi paketil. Palun valige börsi pakett.")
        End If

        tbMargins.Text = sbPackagePriceMargin.ToString
    End Sub

    'Kalkulaator osa
    Private Sub applianceComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles applianceComboBox.SelectedIndexChanged
        ' When the user selects an appliance from the ComboBox, update the powerRatingTextBox with its power rating.
        Dim selectedAppliance As String = applianceComboBox.SelectedItem.ToString()
        Dim powerRating As Double = appliances(selectedAppliance)
        powerRatingTextBox.Text = powerRating.ToString()
    End Sub

    Private Sub anyTextBox_TextChanged(sender As Object, e As EventArgs) Handles powerRatingTextBox.TextChanged, electricityRateTextBox.TextChanged, timeUsedTextBox.TextChanged
        ' Enable the calculateButton if all inputs are entered.
        If Not String.IsNullOrEmpty(powerRatingTextBox.Text) And Not String.IsNullOrEmpty(timeUsedTextBox.Text) And Not String.IsNullOrEmpty(electricityRateTextBox.Text) Then
            calculateButton.Enabled = True
        Else
            calculateButton.Enabled = False
        End If
    End Sub

    Private Sub calculateButton_Click(sender As Object, e As EventArgs) Handles calculateButton.Click
        Dim powerRating As Double
        Dim timeUsed As Double
        Dim electricityRate As Double
        Dim cost As Double

        powerRating = Double.Parse(powerRatingTextBox.Text)
        timeUsed = Double.Parse(timeUsedTextBox.Text)
        electricityRate = Double.Parse(electricityRateTextBox.Text)

        cost = ((powerRating * timeUsed) / 1000) * electricityRate

        'Convert cost to Eur if over 100 cents
        If cost < 100.0 Then
            costTextBox.Text = cost.ToString() + " s"
        Else
            'Round to 2 digits after separator
            costTextBox.Text = Math.Round(cost / 100, 2).ToString() + " €"
        End If

    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        Dim exportForm As New formExport With {
        .Times = times,
        .Prices = prices,
        .Exporter = exporter
    }

        exportForm.ShowDialog()
    End Sub
End Class
