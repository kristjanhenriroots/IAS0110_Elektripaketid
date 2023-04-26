Imports System.Windows.Forms

Public Interface iComparePackages
    Function PackageData(ByRef dictDT As DataTable) As Dictionary(Of String, Double)
    Function PackageSorter(ByRef sortMode As String) As Dictionary(Of String, Double)
    Function PriceReturn(ByRef package As String) As Double
    Function GetSelectedIndices(listBox As CheckedListBox) As List(Of Integer)
End Interface
