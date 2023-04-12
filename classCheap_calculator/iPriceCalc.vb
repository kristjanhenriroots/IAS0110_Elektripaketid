Public Interface iPriceCalc

    Function CalcTimeFrame(ByRef intLen As Integer, ByRef prices As Double(), ByRef times As DateTime()) As List(Of DateTime)
    Function findTimeFrame(ByRef prices As Double(), ByRef times As DateTime(), ByRef change As DateTime) As Integer
    Function averagePriceTimeFrame(ByRef intLen As Integer, ByRef prices As Double(), ByRef index As Integer) As Double
    Function averagePriceBors(ByRef intLen As Integer, ByRef prices As Double(), ByRef times As DateTime()) As Double
End Interface
