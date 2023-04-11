Public Class TimeFrameCalc
    Implements iPriceCalc

    Private Function CalcTimeFrame(ByRef intLen As Integer, ByRef prices() As Double, ByRef times() As Date) As List(Of DateTime) Implements iPriceCalc.CalcTimeFrame
        Dim cheapestStart As DateTime = times(0)
        Dim cheapestEnd As DateTime = times(intLen - 1)
        Dim minCost As Double = Double.MaxValue

        For i As Integer = 0 To prices.Length - intLen
            Dim currentCost As Double = 0

            For j As Integer = i To i + intLen - 1
                currentCost += prices(j)
            Next

            If currentCost < minCost Then
                minCost = currentCost
                cheapestStart = times(i)
                cheapestEnd = times(i + intLen - 1)
            End If
        Next

        Dim result As New List(Of DateTime)({cheapestStart, cheapestEnd.AddHours(1)})
        Return result
    End Function
End Class
