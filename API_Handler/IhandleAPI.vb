Public Interface IhandleAPI
    Function GetPriceData(startTime As DateTime, endtime As DateTime) As Task(Of Tuple(Of List(Of DateTime), List(Of Double)))
End Interface
