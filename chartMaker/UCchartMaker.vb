Imports System.Reflection
Imports System.Threading
Imports System.Windows.Media
Imports LiveCharts
Imports LiveCharts.Configurations
Imports LiveCharts.Defaults
Imports LiveCharts.Definitions.Charts
Imports LiveCharts.Events
Imports LiveCharts.WinForms
Imports LiveCharts.Wpf
Imports System.Linq



Public Class UCchartMaker
    Implements iMakeChart

    Dim initialControlSize As SizeF
    Dim initialAxisXFontSize As Single
    Dim initialAxisYFontSize As Single
    Private maxYValue As Double



    Public Sub New()
        InitializeComponent()
        Me.Controls.Add(CartesianChart)
        CartesianChart.Dock = DockStyle.Fill
        CartesianChart.Zoom = ZoomingOptions.X
        CartesianChart.AnimationsSpeed = TimeSpan.FromMilliseconds(100) ' Set the animation speed to 100 milliseconds
        'CartesianChart.DisableAnimations = True
        'CartesianChart.Pan = PanningOptions.Y
        initialControlSize = New SizeF(Me.Width, Me.Height)

    End Sub

    Private Sub UpdateMaxColumnWidth() Implements iMakeChart.UpdateMaxColumnWidth
        Dim scaleFactor As Single = Me.Width / initialControlSize.Width * 0.5
        Dim newMaxColumnWidth As Single = 20 * scaleFactor ' Change 20 to the desired initial max column width


        For Each series As Series In CartesianChart.Series
            If TypeOf series Is ColumnSeries Then
                Dim columnSeries As ColumnSeries = CType(series, ColumnSeries)
                columnSeries.MaxColumnWidth = newMaxColumnWidth
            End If
        Next
        For Each axis As Axis In CartesianChart.AxisX
            axis.FontSize = initialAxisXFontSize * scaleFactor ' Use the initial font size
            axis.LabelFormatter = Function(value) DateTime.FromOADate(value).AddHours(-3).ToString("HH:00")
        Next

        For Each axis As Axis In CartesianChart.AxisY
            axis.FontSize = initialAxisYFontSize * scaleFactor ' Use the initial font size
            axis.LabelFormatter = Function(value) String.Format("{0:N2}", Math.Round(value, 2))
        Next
    End Sub

    Public Sub setChart(times As DateTime(), prices As Double()) Implements iMakeChart.setChart
        Dim chartValues As New ChartValues(Of ObservablePoint)()
        For i As Integer = 0 To times.Length - 1
            chartValues.Add(New ObservablePoint(times(i).ToOADate(), prices(i)))
        Next

        Dim columnSeries As New ColumnSeries With {
            .Title = "Börsihind",
            .Values = chartValues,
            .Stroke = System.Windows.Media.Brushes.MediumSlateBlue,
            .Fill = System.Windows.Media.Brushes.MediumSlateBlue,
            .ColumnPadding = 1,
            .MaxColumnWidth = 20,
            .LabelPoint = Function(point) String.Format("{0:dd/MM/yyyy HH:mm} - {1:N2} s/kWh", DateTime.FromOADate(point.X), point.Y)
        }

        CartesianChart.Series.Add(columnSeries)


        CartesianChart.AxisX.Add(New Axis With {
            .LabelFormatter = Function(value) DateTime.FromOADate(value).AddHours(-3).ToString("HH:00"),
            .MinValue = times(0).AddHours(11).ToOADate(),
            .MaxValue = times(times.Length - 1).AddHours(15).ToOADate(),
            .Separator = New LiveCharts.Wpf.Separator With {
                .Step = New TimeSpan(4, 0, 0).TotalDays
            }
        })

        maxYValue = prices.Max()

        CartesianChart.AxisY.Add(New Axis With {
            .Title = "Price",
            .MinValue = 0,
            .MaxValue = maxYValue,
            .Separator = New LiveCharts.Wpf.Separator With {
                .Step = 1
            }
        })


        initialAxisXFontSize = CartesianChart.AxisX(0).FontSize
        initialAxisYFontSize = CartesianChart.AxisY(0).FontSize

        UpdateYAxisMaxValue()

    End Sub

    Private Function seriesFinder(title As String) As LineSeries
        Dim foundSeries As LineSeries = Nothing

        For Each series As Series In CartesianChart.Series
            If series.Title = title AndAlso TypeOf series Is LineSeries Then
                foundSeries = series
                Exit For
            End If
        Next
        Return foundSeries

    End Function

    Private Sub removeChart(title As String) Implements iMakeChart.removeChart
        Dim seriesToRemove = seriesFinder(title)

        ' Remove the LineSeries if found
        If seriesFinder(title) IsNot Nothing Then
            CartesianChart.Series.Remove(seriesToRemove)
        End If

        maxYValue = 0
        For Each series As Series In CartesianChart.Series
            If TypeOf series Is LineSeries Then
                For Each point As ObservablePoint In CType(series, LineSeries).Values
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

    Private Sub UpdateYAxisMaxValue()
        If CartesianChart.AxisY.Count > 0 Then
            CartesianChart.AxisY(0).MaxValue = maxYValue
        End If
    End Sub



    Private Sub addComparison(times As DateTime(), title As String, value As Double, index As Integer) Implements iMakeChart.addComparison

        If seriesFinder(title) IsNot Nothing Then
            Console.WriteLine("seriesFinder result with " & title)

            Exit Sub
        End If

        Dim prices = New Double() {value, value}        ' Create an array with the given price value

        Dim colors() As System.Windows.Media.Brush = {  ' Colors for all different packages
            System.Windows.Media.Brushes.Firebrick,
            System.Windows.Media.Brushes.Green,
            System.Windows.Media.Brushes.Cyan,
            System.Windows.Media.Brushes.Yellow,
            System.Windows.Media.Brushes.Orange,
            System.Windows.Media.Brushes.Purple,
            System.Windows.Media.Brushes.Pink,
            System.Windows.Media.Brushes.Black
        }

        Dim lineSeries As New LineSeries With {
            .Title = title,
            .Values = New ChartValues(Of ObservablePoint)(New List(Of ObservablePoint) From {
                New ObservablePoint(times.First.ToOADate(), prices(0)),
                New ObservablePoint(times.Last.ToOADate(), prices(1))
            }),
            .Stroke = colors(index),
            .Fill = System.Windows.Media.Brushes.Transparent,
            .PointGeometry = Nothing,
            .DataLabels = True,
            .LabelPoint = Function(point) FormatLabelPoint(point, title)
        }

        CartesianChart.Series.Add(lineSeries)

        If value > maxYValue Then
            maxYValue = value
            UpdateYAxisMaxValue()
        End If
    End Sub






    ' coloring code
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

    Public Sub changeColors(startTime As DateTime, amount As Integer, avg_price As Double) Implements iMakeChart.changeColors
        removeChart("Soovitatud")

        Dim lineSeries As New LineSeries With {
            .Title = "Soovitatud",
            .Values = New ChartValues(Of ObservablePoint)(),
            .Stroke = System.Windows.Media.Brushes.Red,
            .Fill = System.Windows.Media.Brushes.Transparent,
            .PointGeometry = Nothing,
            .DataLabels = True,
            .LabelPoint = Function(point) FormatLabelPoint(point, "Soovitatud")
         }
        '.LabelPoint = Function(point) String.Format("{0:dd/MM/yyyy HH:mm} - {1:N2} s/kWh", DateTime.FromOADate(point.X), point.Y)

        ' Add an ObservablePoint for every hour between startTime and startTime + amount
        For i As Integer = 0 To amount - 1
            Dim currentDateTime As DateTime = startTime.AddHours(i)
            lineSeries.Values.Add(New ObservablePoint(currentDateTime.ToOADate(), avg_price))
        Next

        CartesianChart.Series.Add(lineSeries)
    End Sub

    Private Function FormatLabelPoint(chartPoint As ChartPoint, title As String) As String
        Dim lineSeries As LineSeries = CartesianChart.Series.OfType(Of LineSeries).FirstOrDefault(Function(s) s.Title = title)

        If lineSeries IsNot Nothing AndAlso lineSeries.Values(0).X = chartPoint.X AndAlso lineSeries.Values(0).Y = chartPoint.Y Then
            Return String.Format("{0}: {1:N2} s/kWh", title, chartPoint.Y)
        Else
            Return ""
        End If
    End Function

End Class
