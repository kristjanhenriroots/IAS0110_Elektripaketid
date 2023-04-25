Imports System.Windows.Forms.DataVisualization.Charting

Public Interface iMakeChart
    Sub setInitialChart(times As DateTime(), prices As Double())
    Sub addRecommendedTime(startTime As DateTime, amount As Integer, avg_price As Double)
    Sub addChart(times As DateTime(), prices As Double(), title As String, type As Boolean)
    Sub removeChart(title As String)

    Sub UpdateMaxColumnWidth()

End Interface
