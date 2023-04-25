Public Class TimeFrameCalc
    Implements iPriceCalc

    Public Function findTimeFrame(ByRef prices() As Double, ByRef times() As Date, ByRef change As Date) As Integer Implements iPriceCalc.findTimeFrame
        Dim index As Integer
        For i As Integer = 0 To times.Count - 1
            If times(i).Equals(change) Then
                index = i
                Exit For
            End If
        Next
        Return index
    End Function

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



    Private Function iPriceCalc_averagePriceTimeFrame(ByRef intLen As Integer, ByRef prices() As Double, ByRef index As Integer) As Double Implements iPriceCalc.averagePriceTimeFrame
        Dim total As Double = 0
        For i As Integer = index To index + intLen - 1
            total += prices(i)
        Next
        Return total / intLen
    End Function

    Private Function iPriceCalc_averagePriceBors(ByRef intLen As Integer, ByRef prices() As Double, ByRef times() As Date) As Double Implements iPriceCalc.averagePriceBors
        Dim total As Double = 0
        If intLen <> 1 Then
            For i As Integer = 0 To intLen - 1
                total += prices(i)
            Next
        Else
            total = prices(0)
        End If

        Return total / intLen
    End Function

    Private Function averagePriceWeek(ByRef times As DateTime(), ByRef prices As Double()) As Double() Implements iPriceCalc.averagePriceWeek
        Dim hourlyPrices(23) As Double

        For i As Integer = 0 To times.Length - 1
            Dim hourIndex As Integer = times(i).Hour
            hourlyPrices(hourIndex) += prices(i)
        Next

        For i As Integer = 0 To hourlyPrices.Length - 1
            Dim averagePrice As Double = hourlyPrices(i) / 7  ' divide by number of days in the week (7)
            Console.WriteLine($"Average price for hour {i:00}: {averagePrice:F2}")
        Next

        Return hourlyPrices
    End Function



End Class
