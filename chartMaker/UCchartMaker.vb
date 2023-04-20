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


        Dim chartValues As New ChartValues(Of ObservablePoint)()
        For i As Integer = 0 To times.Length - 1
            chartValues.Add(New ObservablePoint(times(i).ToOADate(), prices(i)))
        Next

        Dim columnSeries As New ColumnSeries With {
            .Values = chartValues,
            .Stroke = System.Windows.Media.Brushes.MediumSlateBlue,
            .Fill = System.Windows.Media.Brushes.MediumSlateBlue,
            .ColumnPadding = 1,
            .MaxColumnWidth = 20
        }
        CartesianChart.Series.Add(columnSeries)

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

    End Sub

    Public Sub colorReset(times As DateTime()) Implements iMakeChart.colorReset
        For i As Integer = 0 To times.Count - 1
            CType(cartesianChart.Series(0), ColumnSeries).Fill = System.Windows.Media.Brushes.MediumSlateBlue
        Next
    End Sub

    Public Sub changeColors(times As DateTime(), len As Integer, index As Integer) Implements iMakeChart.changeColors

        colorReset(times)

        For i As Integer = 0 To len - 1
            CType(cartesianChart.Series(0), ColumnSeries).Fill = System.Windows.Media.Brushes.Red
        Next

    End Sub
End Class
