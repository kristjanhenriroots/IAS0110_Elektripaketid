﻿Imports System.Drawing
Imports System.Windows.Forms.DataVisualization.Charting

Public Class chartMaker
    Public Sub setChart(mainChart As Chart, times As DateTime(), prices As Double())

        ' Clear any existing series and data points from the chart
        mainChart.Series.Clear()
        mainChart.ChartAreas.Clear()
        mainChart.ChartAreas.Add("MainChartArea")

        ' Create a new series and add data points to it
        Dim series1 As Series = New Series()
        series1.Name = "Prices"
        series1.ChartType = SeriesChartType.Column

        For i As Integer = 0 To times.Length - 1
            series1.Points.AddXY(times(i), prices(i))
        Next

        ' Add the series to the chart
        mainChart.Series.Add(series1)

        ' Set some basic chart properties
        mainChart.Titles.Add("Price Chart")
        mainChart.ChartAreas(0).AxisX.LabelStyle.Format = "HH:mm"
        mainChart.ChartAreas(0).AxisX.Interval = 1
        mainChart.ChartAreas(0).AxisY.Title = "Price"

        ' Set the interval to 30 minutes
        mainChart.ChartAreas(0).AxisX.Interval = New TimeSpan(0, 120, 0).TotalDays

        ' Remove chart legend
        mainChart.Legends.Clear()


    End Sub
End Class