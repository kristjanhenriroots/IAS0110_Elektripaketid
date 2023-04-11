Public Interface iPriceCalc

    Function CalcTimeFrame(ByRef intLen As Integer, ByRef prices As Double(), ByRef times As DateTime()) As List(Of DateTime)
End Interface
