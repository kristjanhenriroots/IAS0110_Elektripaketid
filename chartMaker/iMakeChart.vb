Imports System.Windows.Forms.DataVisualization.Charting

Public Interface iMakeChart
    Sub setChart(times As DateTime(), prices As Double())
    Sub changeColors(startTime As DateTime, amount As Integer, avg_price As Double)
    Sub addComparison(times As DateTime(), title As String, value As Double, index As Integer)
    Sub removeChart(title As String)

    Sub UpdateMaxColumnWidth()

End Interface
