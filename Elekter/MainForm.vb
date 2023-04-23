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
    Dim times As New List(Of DateTime)()                                    ' holds the times in DateTime format dd/mm/yyyy HH:mm . Corresponding price held in prices()
    Dim prices As New List(Of Double)()                                     ' holds the price in a double corresponding a time, the indices are the same with the previous list
    Dim chartMaker As iMakeChart = New UCchartMaker()                       ' project chartMaker interface
    Dim comparePackages As iComparePackages = New clPackageData()           ' project packageComparator interface
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

        Try
            ' adding chartMaker instance and setting chartPanel control collection
            CType(chartMaker, Control).Dock = DockStyle.Fill
            chartPanel.Controls.Add(CType(chartMaker, Control))


            Dim client As New HttpClient()                                                      ' set up HTTP client
            Dim currentDate As DateTime = DateTime.Now.AddHours(-3)                             ' get the current time
            Dim startTime As String = currentDate.ToString("yyyy-MM-dd'T'HH:mm:ssZ")            ' set the starting to the correct format Elering API is expecting
            Dim endTime As String = currentDate.AddDays(1).ToString("yyyy-MM-dd'T'HH:mm:ssZ")   ' set the ending time, currently 24H from now
            Dim response As HttpResponseMessage = Await client.GetAsync($"https://dashboard.elering.ee/api/nps/price/csv?start={startTime}&end={endTime}&fields=ee")    ' send GET request
            Dim content As Stream = Await response.Content.ReadAsStreamAsync()                  ' read response, which is a CSV file
            Dim csvContent As New StringBuilder()                                               ' StringBuilder, reads CSV line by line


            Using reader As New StreamReader(content, Encoding.UTF8)                            ' Read all data by line
                ' Read header row
                csvContent.AppendLine(reader.ReadLine())

                While Not reader.EndOfStream
                    Dim line As String = reader.ReadLine()
                    csvContent.AppendLine(line)
                    Dim values As String() = line.Split(";"c)

                    Dim dateValue As DateTime = DateTime.ParseExact(values(1).Trim(""""), "dd.MM.yyyy HH:mm", CultureInfo.InvariantCulture) ' parse CSV into lists
                    Dim price As Double = Double.Parse(values(2).Trim("""").Replace(",", "."), CultureInfo.InvariantCulture) * 1.2 / 10

                    ' Add dateValue to the times list and price to the prices list
                    times.Add(dateValue)
                    prices.Add(price)
                End While
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while retrieving data from the Elering API: " & ex.Message)  ' Catch Elering API errors
        End Try

        ' Print out the times and prices lists just in case
        For i As Integer = 0 To times.Count - 1
            Console.WriteLine($"Time: {times(i)}, Price: {prices(i)}")
        Next
        chartMaker.setChart(times.ToArray(), prices.ToArray())

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

        For Each ctrl As Control In Me.Controls ' Locate all labels and change the font size, Resizer.vb won't handle that
            If TypeOf ctrl Is Label Then
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
            Dim frame As iPriceCalc = New TimeFrameCalc ' PriceCalc interface
            Dim time_frame = frame.CalcTimeFrame(Int(cbTimeFrame.SelectedItem), prices.ToArray(), times.ToArray())  ' get an array of 2 datetime type elements, first the beginning and then the ending time

            ' display the time frame and change colors accordingly
            tbRecTimeFrame.Text = (time_frame(0).ToString("HH:mm") & " - " & time_frame(1).ToString("HH:mm"))


            Dim startingIndex = frame.findTimeFrame(prices.ToArray(), times.ToArray(), time_frame(0))                                       ' what index in the times array is the beginning time
            Dim averageNow = Math.Round(frame.averagePriceBors(Int(cbTimeFrame.SelectedItem), prices.ToArray(), times.ToArray()), 2)        ' calculate averages for now and recommended times
            Dim averageTF = Math.Round(frame.averagePriceTimeFrame(Int(cbTimeFrame.SelectedItem), prices.ToArray(), startingIndex), 2)



            chartMaker.changeColors(time_frame(0), Int(cbTimeFrame.SelectedItem), averageTF)                                                ' indicate the recommended time on the chart

            lblAverageNow.Text = ("Keskmine hind: " & averageNow)
            lblAverageTF.Text = ("Keskmine soovituslik: " & averageTF)                                                                      ' show times and savings to user
            lblSavedPer.Text = ("Säästaksid: " & 100 - Math.Round(averageTF / averageNow * 100, 0) & "%")

        End If
    End Sub

    ' Returns current price for formCalc, might get removed later
    Public Function ReturnCurrentPrice()
        Return prices.First
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
            chartMaker.addComparison(times.ToArray(), title, price, index)  ' make the graph, index will be included to select color
            Console.WriteLine("Selected index: " & index.ToString())        ' debugging
        Next
    End Sub
End Class
