Public Interface IDatabaseQuery
    Function queryData(ByVal command As String) As DataTable 'Rohkem pole vaja
    Sub updateTable(ByVal tuple As Tuple(Of List(Of Date), List(Of Double)))
End Interface
