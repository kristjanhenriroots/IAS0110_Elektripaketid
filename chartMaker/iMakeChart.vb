Imports System.Windows.Forms.DataVisualization.Charting

Public Interface iMakeChart
    Sub setChart(times As DateTime(), prices As Double())
    Sub colorReset(times As DateTime())
    Sub changeColors(times As DateTime(), len As Integer, index As Integer)

End Interface
