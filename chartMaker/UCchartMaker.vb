Imports LiveCharts
Imports LiveCharts.Configurations
Imports LiveCharts.Defaults
Imports LiveCharts.Definitions.Charts
Imports LiveCharts.WinForms
Imports LiveCharts.Wpf


Public Class UCchartMaker
    Implements iMakeChart

    Public Sub New()
        InitializeComponent()
        Me.Controls.Add(CartesianChart)
        CartesianChart.Dock = DockStyle.Fill
        CartesianChart.Zoom = ZoomingOptions.X
        'CartesianChart.DisableAnimations = True
        'CartesianChart.Pan = PanningOptions.Y
    End Sub

    Public Sub setChart(times As DateTime(), prices As Double()) Implements iMakeChart.setChart
        Dim chartValues As New ChartValues(Of ObservablePoint)()

        For i As Integer = 0 To times.Length - 1
            chartValues.Add(New ObservablePoint(times(i).ToOADate(), prices(i)))
        Next

        Dim columnSeries As New ColumnSeries With {
            .Title = "börsihind",
            .Values = chartValues,
            .Stroke = System.Windows.Media.Brushes.MediumSlateBlue,
            .Fill = System.Windows.Media.Brushes.MediumSlateBlue,
            .ColumnPadding = 1,
            .MaxColumnWidth = 20,
            .LabelPoint = Function(point) String.Format("{0:dd/MM/yyyy HH:mm} - {1:N2} s/kWh", DateTime.FromOADate(point.X), point.Y)
        }

        CartesianChart.Series.Add(columnSeries)

        AddLineSeries("Average", prices.Average(), System.Windows.Media.Brushes.Red)

        CartesianChart.AxisX.Add(New Axis With {
            .LabelFormatter = Function(value) DateTime.FromOADate(value).AddHours(-3).ToString("HH:00"),
            .MinValue = times(0).AddHours(11).ToOADate(),
            .MaxValue = times(times.Length - 1).AddHours(15).ToOADate(),
            .Separator = New LiveCharts.Wpf.Separator With {
                .Step = New TimeSpan(4, 0, 0).TotalDays
            }
        })

        CartesianChart.AxisY.Add(New Axis With {
            .Title = "Price",
            .Separator = New LiveCharts.Wpf.Separator With {
                .Step = 1
            }
        })
    End Sub

    Private Sub AddLineSeries(title As String, value As Double, color As System.Windows.Media.Brush)
        Dim times = New DateTime() {DateTime.Now, DateTime.Now.AddDays(1)} ' Set some arbitrary dates for the line chart
        Dim prices = New Double() {value, value} ' Create an array with the given price value

        Dim lineSeries As New LineSeries With {
            .Title = title,
            .Values = New ChartValues(Of ObservablePoint)(New List(Of ObservablePoint) From {
                New ObservablePoint(times(0).ToOADate(), prices(0)),
                New ObservablePoint(times(1).ToOADate(), prices(1))
            }),
            .Stroke = color,
            .Fill = System.Windows.Media.Brushes.Transparent,
            .PointGeometry = Nothing,
            .DataLabels = True,
            .LabelPoint = Function(point) String.Format("{0:N2} s/kWh", point.Y)
        }

        CartesianChart.Series.Add(lineSeries)
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



    Public Sub colorReset() Implements iMakeChart.colorReset
        For i As Integer = 0 To CartesianChart.Series.Count - 1
            Dim columnSeries As ColumnSeries = CType(CartesianChart.Series(i), ColumnSeries)
            columnSeries.Fill = System.Windows.Media.Brushes.MediumSlateBlue
            columnSeries.Stroke = System.Windows.Media.Brushes.MediumSlateBlue
        Next
    End Sub

    Public Sub changeColors(startIndex As Integer, amount As Integer) Implements iMakeChart.changeColors

        colorReset()

        For i As Integer = startIndex To startIndex + amount - 1
            If i < CartesianChart.Series.Count Then
                Dim columnSeries As ColumnSeries = CType(CartesianChart.Series(i), ColumnSeries)
                columnSeries.Fill = System.Windows.Media.Brushes.Red
                columnSeries.Stroke = System.Windows.Media.Brushes.Red
            End If
        Next

    End Sub

End Class
