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

        ' Get all package data from prj packageComparator, call function PackageData() for all names and prices
        Dim packagePrices = comparePackages.PackageData()

        ' Populate the listbox with the packages
        updateListBox(packagePrices)

        ' adding chartMaker instance and setting chartPanel control collection
        CType(chartMaker, Control).Dock = DockStyle.Fill
        chartPanel.Controls.Add(CType(chartMaker, Control))

        Try
            Dim currentDate As DateTime = DateTime.Now.Date.AddHours(-3)
            Dim pricesAndTimes = Await apiHandler.GetPriceData(currentDate, currentDate.AddDays(1))
            times = pricesAndTimes.Item1
            prices = pricesAndTimes.Item2
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


        ' Print out the times and prices lists just in case
        For i As Integer = 0 To times.Count - 1
            Console.WriteLine($"Time: {times(i)}, Price: {prices(i)}")
        Next
        chartMaker.setInitialChart(times.ToArray(), prices.ToArray()) ' make the chart for current market price
        Dim currentIndex = GetCurrentPrice()
        chartMaker.addCurrentTimeScatter(times(currentIndex), prices(currentIndex) / 2)

        initialFormSize = New SizeF(Me.Width, Me.Height)    ' Capture starting form and font size
        initialFontSize = calcButton.Font.Size
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

    Private Async Sub btn7Davg_Click(sender As Object, e As EventArgs) Handles cbWeekAVG.CheckedChanged
        If cbWeekAVG.Checked Then
            Dim weekTimes As New List(Of DateTime)()
            Dim weekPrices As New List(Of Double)()


            Try
                Dim currentDate As DateTime = DateTime.Now.Date.AddHours(-3)
                Dim weekPricesAndTimes = Await apiHandler.GetPriceData(currentDate.AddDays(-7), currentDate)
                weekTimes = weekPricesAndTimes.Item1
                weekPrices = weekPricesAndTimes.Item2
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

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


End Class
