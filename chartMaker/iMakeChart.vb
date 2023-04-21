Imports System.Windows.Forms.DataVisualization.Charting

Public Interface iMakeChart
    Sub setChart(times As DateTime(), prices As Double())
    Sub colorReset()
    Sub changeColors(startIndex As Integer, amount As Integer)

End Interface
