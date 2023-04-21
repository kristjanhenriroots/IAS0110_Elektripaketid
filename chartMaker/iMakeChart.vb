Imports System.Windows.Forms.DataVisualization.Charting

Public Interface iMakeChart
    Sub setChart(times As DateTime(), prices As Double())
    Sub colorReset()
    Sub changeColors(startIndex As Integer, amount As Integer)
    Sub addComparison(times As DateTime(), title As String, value As Double, index As Integer)


End Interface
