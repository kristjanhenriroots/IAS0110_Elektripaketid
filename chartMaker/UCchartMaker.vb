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
        'CartesianChart.Pan = PanningOptions.Y
    End Sub

    Public Sub setChart(times As DateTime(), prices As Double()) Implements iMakeChart.setChart
        For i As Integer = 0 To times.Length - 1
            Dim chartValues As New ChartValues(Of ObservablePoint)()
            chartValues.Add(New ObservablePoint(times(i).ToOADate(), prices(i)))

            Dim columnSeries As New ColumnSeries With {
                .Values = chartValues,
                .Stroke = System.Windows.Media.Brushes.MediumSlateBlue,
                .Fill = System.Windows.Media.Brushes.MediumSlateBlue,
                .ColumnPadding = 1,
                .MaxColumnWidth = 20
            }
            CartesianChart.Series.Add(columnSeries)
        Next

        CartesianChart.AxisX.Add(New Axis With {
            .LabelFormatter = Function(value) DateTime.FromOADate(value).ToString("HH:mm"),
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
        updateChartColors(3, 5)
    End Sub

    Public Sub updateChartColors(startIndex As Integer, amount As Integer)
        For i As Integer = startIndex To startIndex + amount - 1
            If i < CartesianChart.Series.Count Then
                Dim columnSeries As ColumnSeries = CType(CartesianChart.Series(i), ColumnSeries)
                columnSeries.Fill = System.Windows.Media.Brushes.Red
                columnSeries.Stroke = System.Windows.Media.Brushes.Red
            End If
        Next
    End Sub




    Public Sub colorReset(times As DateTime()) Implements iMakeChart.colorReset
        For i As Integer = 0 To times.Count - 1
            CType(CartesianChart.Series(0), ColumnSeries).Fill = System.Windows.Media.Brushes.MediumSlateBlue
        Next
    End Sub

    Public Sub changeColors(times As DateTime(), len As Integer, index As Integer) Implements iMakeChart.changeColors

        colorReset(times)

        For i As Integer = 0 To len - 1
            CType(CartesianChart.Series(0), ColumnSeries).Fill = System.Windows.Media.Brushes.Red
        Next

    End Sub
End Class
