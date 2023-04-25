Public Interface IhandleAPI
    Function Get24hData() As Task(Of Tuple(Of List(Of DateTime), List(Of Double)))
End Interface
