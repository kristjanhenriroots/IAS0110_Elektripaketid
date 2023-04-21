Public Interface iComparePackages
    Function PackageData() As Dictionary(Of String, Double)
    Function PackageSorter(ByRef sortMode As String) As Dictionary(Of String, Double)
    Function PriceReturn(ByRef package As String) As Double
End Interface
