Imports System.Drawing
Imports System.Windows.Forms.DataVisualization.Charting

Public Class chartMaker
    Public Sub setChart(mainChart As Chart, times As DateTime(), prices As Double())

        ' Set anchor property
        mainChart.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right

        ' Set margin for the chart
        mainChart.Margin = New Padding(10)

        ' Add chart area
        Dim chartArea As New ChartArea()
        mainChart.ChartAreas.Add(chartArea)

        ' Set X-axis label format to HH:mm
        chartArea.AxisX.LabelStyle.Format = "HH:mm"

        ' Add series
        Dim series As New Series()
        series.ChartType = SeriesChartType.Line
        mainChart.Series.Add(series)

        ' Add data points
        For i As Integer = 0 To times.Length - 1
            series.Points.AddXY(times(i), prices(i))
        Next

        'Remove chart legend
        mainChart.Legends.Clear()
    End Sub
End Class
