Imports System.Reflection
Imports LiveCharts
Imports LiveCharts.Defaults
Imports LiveCharts.Events
Imports LiveCharts.WinForms
Imports LiveCharts.Wpf

' Project used to display cartesian and line charts for electricity packages using liveCharts in an user controlwindow

Public Class UCchartMaker
    Implements iMakeChart

    Dim initialControlSize As SizeF     ' Keep track of initial sizes for dynamic resizing
    Dim initialAxisXFontSize As Single
    Dim initialAxisYFontSize As Single
    Private maxYValue As Double         ' Will be used to calculate the max value for the graph y axis
    Private random As New Random()      ' Creating an instance for Random(), otherwise successively made charts will have the same color



    ' Graph initialization things
    Public Sub New()
        InitializeComponent()
        Me.Controls.Add(mainChart)                                     ' Add a chart
        mainChart.Dock = DockStyle.Fill                                ' Fill the space given
        mainChart.Zoom = ZoomingOptions.X                              ' Enable zoom, might be disabled later or given an option to disable
        mainChart.AnimationsSpeed = TimeSpan.FromMilliseconds(100)     ' Set the animation speed to 100 milliseconds, full animations are slow
        'CartesianChart.DisableAnimations = True                            ' option to completely disable animations
        'CartesianChart.Pan = PanningOptions.Y                              ' Panning option letting user pan the y axis, now superseeded by y axis calculation using maxYValue
        initialControlSize = New SizeF(Me.Width, Me.Height)                 ' Log initial form size
    End Sub


    ' Called when the form gets resized. Will recalculate the max column width based on the new size as well as font size on the labels
    Private Sub UpdateMaxColumnWidth() Implements iMakeChart.UpdateMaxColumnWidth
        Dim scaleFactor As Single = Me.Width / initialControlSize.Width * 0.5   ' Calculate scale factor, 0.5 is added because 1 is too large
        Dim newMaxColumnWidth As Single = 20 * scaleFactor                      ' Change 20 to the desired initial max column width

        If newMaxColumnWidth < 50 Then
            ' Find the cartesian chart and change the max column / bar width
            For Each series As Series In mainChart.Series
                If TypeOf series Is ColumnSeries Then
                    Dim columnSeries As ColumnSeries = CType(series, ColumnSeries)
                    columnSeries.MaxColumnWidth = newMaxColumnWidth
                End If
            Next
        End If


        ' change the font size and labels for all charts, cartesian and linecharts need to be typecast individually using CType
        For Each axis As Axis In mainChart.AxisX
            axis.FontSize = initialAxisXFontSize * scaleFactor ' Use the initial font size
            axis.LabelFormatter = Function(value) DateTime.FromOADate(value).AddHours(-3).ToString("HH:00")
        Next

        For Each axis As Axis In mainChart.AxisY
            axis.FontSize = initialAxisYFontSize * scaleFactor ' Use the initial font size
            axis.LabelFormatter = Function(value) Math.Round(value).ToString()
        Next
    End Sub


    ' main function that makes the cartesian chart with börsihind, gets the times and prices lists
    Public Sub setInitialChart(times As DateTime(), prices As Double()) Implements iMakeChart.setInitialChart


        ' Set up the x axis
        mainChart.AxisX.Add(New Axis With {
            .LabelFormatter = Function(value) DateTime.FromOADate(value).AddHours(-3).ToString("HH:00"), ' Change formatting for labels, leave only the rounded hour and account for the time zone difference
            .MinValue = times(0).AddHours(11).ToOADate(),                           ' Chart starting location is broken without the addHours although it makes no sense, solution not found
            .MaxValue = times(times.Length - 1).AddHours(15).ToOADate(),            ' Set the range of the chart, starting and ending location, will be first and last element in the times array
            .Separator = New LiveCharts.Wpf.Separator With {
                .Step = New TimeSpan(2, 0, 0).TotalDays                             ' labels on the x axis bottom should appear every 2 hours, but still pretty broken
            }
        })



        maxYValue = prices.Max()                                                    ' Set the limit of the y axis, if maximum price is 19.95 the y axis max will be 20 and will not change with zoom

        ' Set up the y axis
        mainChart.AxisY.Add(New Axis With {
            .Title = "Price",   ' Title
            .MinValue = 0,      ' Miminum value will be zero, might consider changing because sometimes pricing can be negative, but it will break with zoom
            .MaxValue = maxYValue,
            .Separator = New LiveCharts.Wpf.Separator With {
                .Step = 1       ' Stepping of 1 cent
            }
        })

        addChart(times, prices, "Börsihind", True)


        initialAxisXFontSize = mainChart.AxisX(0).FontSize ' Set initial font sizes for the x and y axis for dynamic font resizing
        initialAxisYFontSize = mainChart.AxisY(0).FontSize

        UpdateYAxisMaxValue()

    End Sub


    Private Function GetRandomColor() As System.Windows.Media.Brush
        Dim r As Byte = CByte(random.Next(0, 256))
        Dim g As Byte = CByte(random.Next(0, 256))
        Dim b As Byte = CByte(random.Next(0, 256))
        Return New System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(r, g, b))
    End Function


    ' Objective is to find the series, or graph, based on the title. Used for the comparator
    ' Function will check if a graph by that name already exist and returns it, when none are found nothing is returned
    Private Function seriesFinder(title As String) As Series
        Dim foundSeries As Series = Nothing

        For Each series As Series In mainChart.Series
            If series.Title = title Then    ' Search for the title
                foundSeries = series
                Exit For
            End If
        Next
        Return foundSeries

    End Function

    ' Used for removing a chart when the user deselects it on the comparator, gets the title and check whether it exists using seriesFinder()
    Private Sub removeChart(title As String) Implements iMakeChart.removeChart
        Dim seriesToRemove = seriesFinder(title)

        ' Remove the LineSeries if found
        If seriesFinder(title) IsNot Nothing Then
            mainChart.Series.Remove(seriesToRemove)
        End If

        ' Refind the highest priced point and update the max y axis value, if a package costing 20 cents is removed the y axis will be rescaled to the next maximum point
        maxYValue = 0
        For Each series As Series In mainChart.Series
            If TypeOf series Is LineSeries Then
                For Each point As ObservablePoint In CType(series, LineSeries).Values   ' linecharts and the cartesian chart need to be checked separately for some reason, typecasting with CType()
                    If point.Y > maxYValue Then
                        maxYValue = point.Y
                    End If
                Next
            ElseIf TypeOf series Is ColumnSeries Then
                For Each point As ObservablePoint In CType(series, ColumnSeries).Values
                    If point.Y > maxYValue Then
                        maxYValue = point.Y
                    End If
                Next
            End If
        Next

        UpdateYAxisMaxValue()
    End Sub

    ' Updates maximum y axis value, changing the value will automatically rescale the chart
    Private Sub UpdateYAxisMaxValue()
        If mainChart.AxisY.Count > 0 Then
            mainChart.AxisY(0).MaxValue = Math.Ceiling(maxYValue)
        End If
    End Sub


    ' Purpose is to add a chart, inputs:
    ' times() - DateTime format array for the x axis
    ' prices() - double type array containing the prices for the y axis, same indices as the times array
    ' title - title for the chart as a string, eg "Börsihind"
    ' type - boolean value implying whether a line or cartesian chart will be made.
    ' True for cartesian, False for linechart
    Private Sub addChart(times As DateTime(), prices As Double(), title As String, type As Boolean) Implements iMakeChart.addChart

        If seriesFinder(title) IsNot Nothing Then   ' check if the chart added is already there, no need to add it twice
            Console.WriteLine("seriesFinder result with " & title)  ' debugging

            Exit Sub
        End If

        If type Then    ' We are making a cartesian chart
            Dim chartValues As New ChartValues(Of ObservablePoint)()
            For i As Integer = 0 To times.Length - 1
                chartValues.Add(New ObservablePoint(times(i).ToOADate(), prices(i)))    ' Add the individual lists to chartvalues, now contain x and y axis values
            Next

            Dim fillColor As System.Windows.Media.Brush
            If title = "Börsihind" Then
                fillColor = System.Windows.Media.Brushes.MediumSlateBlue ' MediumSlateBlue color, fixed for simplicity for current market place
            Else
                fillColor = GetRandomColor()    ' random color otherwise
            End If

            Dim columnSeries As New ColumnSeries With { ' Set rules for the series / bar chart
                .Title = title,         ' Title
                .Values = chartValues,  ' Add values
                .ColumnPadding = 1,     ' Set padding and initial column width
                .MaxColumnWidth = 20,
                .LabelPoint = Function(point) String.Format("{0:dd/MM/yyyy HH:mm} - {1:N2} s/kWh", DateTime.FromOADate(point.X), point.Y)   ' Formatting for the label when hovering with mouse
            }

            mainChart.Series.Add(columnSeries) ' Add the graph

        Else            ' We are making a line chart


            ' Set rules for the new graph
            Dim lineSeries As New LineSeries With {
                .Title = title, ' title is given
                .Values = New ChartValues(Of ObservablePoint)(New List(Of ObservablePoint) From {
                    New ObservablePoint(times.First.ToOADate(), prices(0)), ' linecharts only have 2 points, the beginning of times array and the end, currently the 24H window
                    New ObservablePoint(times.Last.ToOADate(), prices.Last())
                }),
                .Stroke = GetRandomColor(),    ' Get the color
                .Fill = System.Windows.Media.Brushes.Transparent,
                .PointGeometry = Nothing,
                .DataLabels = True,
                .LabelPoint = Function(point) FormatLabelPoint(point, title)    ' Enable tooltips
            }
            mainChart.Series.Add(lineSeries)   ' Add the chart

        End If




        If prices.Max() > maxYValue Then   ' If the package is higher priced that the previous max then rescale the y axis
            maxYValue = prices.Max()
            UpdateYAxisMaxValue()
        End If
    End Sub

    ' coloring code, allows for independently colored bars on the cartesianchart, slow and will probably be removed
    'For i As Integer = 0 To times.Length - 1
    '       chartValues = New ChartValues(Of ObservablePoint)()
    '        chartValues.Add(New ObservablePoint(times(i).ToOADate(), prices(i)))
    '
    'Dim columnSeries As New ColumnSeries With {
    '.Values = ChartValues,
    '.Stroke = System.Windows.Media.Brushes.MediumSlateBlue,
    '.Fill = System.Windows.Media.Brushes.MediumSlateBlue,
    '.ColumnPadding = 1,
    '.MaxColumnWidth = 20,
    '.LabelPoint = Function(point) String.Format("{0:dd/MM/yyyy} - {1:N2} s/kWh", DateTime.FromOADate(point.X), point.Y)
    '       }
    '      CartesianChart.Series.Add(columnSeries)
    'Next

    ' Originally used for changing colors of the bars but not feasible with livecharts, now creates a new linechart for the recommended time to use electricity
    ' inputs are starting time, the amount of hours and the average price for the timeframe
    Public Sub addRecommendedTime(startTime As DateTime, amount As Integer, avg_price As Double) Implements iMakeChart.addRecommendedTime
        removeChart("Soovitatud")   ' Remove the chart if another time was previously shown

        ' Set rules for new chart
        Dim lineSeries As New LineSeries With {
            .Title = "Soovitatud",  ' set title
            .Values = New ChartValues(Of ObservablePoint)(),
            .Stroke = System.Windows.Media.Brushes.Red,
            .Fill = System.Windows.Media.Brushes.Transparent,
            .PointGeometry = Nothing,
            .DataLabels = True,
            .LabelPoint = Function(point) FormatLabelPoint(point, "Soovitatud") ' enable tooltips
         }
        '.LabelPoint = Function(point) String.Format("{0:dd/MM/yyyy HH:mm} - {1:N2} s/kWh", DateTime.FromOADate(point.X), point.Y)

        ' Add an ObservablePoint for every hour between startTime and startTime + amount
        ' Only line chart to currently have more than 2 points
        For i As Integer = 0 To amount - 1
            Dim currentDateTime As DateTime = startTime.AddHours(i)
            lineSeries.Values.Add(New ObservablePoint(currentDateTime.ToOADate(), avg_price))
        Next

        mainChart.Series.Add(lineSeries)
    End Sub

    ' Function that enables unified custom label formatting on linecharts
    Private Function FormatLabelPoint(chartPoint As ChartPoint, title As String) As String
        Dim lineSeries As LineSeries = mainChart.Series.OfType(Of LineSeries).FirstOrDefault(Function(s) s.Title = title)

        If lineSeries IsNot Nothing AndAlso lineSeries.Values(0).X = chartPoint.X AndAlso lineSeries.Values(0).Y = chartPoint.Y Then
            Return String.Format("{0}: {1:N2} s/kWh", title, chartPoint.Y)
        Else
            Return ""
        End If
    End Function

End Class
