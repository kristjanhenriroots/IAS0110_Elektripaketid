Imports System.Security.Cryptography

Public Class clPackageData
    Implements iComparePackages

    Public Function PackageData() As Dictionary(Of String, Double) Implements iComparePackages.PackageData
        Dim deals = New Dictionary(Of String, Double) From {
            {"Kasulik Klõps", 16.73}, 'https://elektrihind.ee/paketid/
            {"Kindel", 13.57},
            {"Kindel 36", 17.5},
            {"Kindel 6", 15.89},
            {"Kindel Pluss", 14.49},
            {"Tähtajaline fikseeritud hind + ühisarve", 13.96},
            {"Tähtajaline fiseeritud", 13.5},
            {"Universaal", 19.95}   'https://www.energia.ee/et/era/elekter/elektrileping-ja-paketid?customers=home-customer&packages=fixPlus
        }

        Return deals
    End Function

    Public Function PackageSorter(ByRef sortMode As String) As Dictionary(Of String, Double) Implements iComparePackages.PackageSorter
        Dim temp = PackageData()

        'Sort the items in CheckedListBox based on selected sorting option
        If sortMode = "A - Z" Then
            Return temp

        ElseIf sortMode = "Z - A" Then
            Dim rev_ans As New Dictionary(Of String, Double)

            For i As Integer = temp.Count - 1 To 0 Step -1
                Dim kvp As KeyValuePair(Of String, Double) = temp.ElementAt(i)
                rev_ans.Add(kvp.Key, kvp.Value)
            Next


            Return rev_ans

        ElseIf sortMode = "Hind kasvav" Then

            'List to hold dictionary entries.
            Dim dicList As List(Of KeyValuePair(Of String, Double)) = temp.ToList
            Dim ans As New Dictionary(Of String, Double)
            'Sort the list by double value in ascending order.
            dicList.Sort(Function(x, y) x.Value.CompareTo(y.Value))

            ' Add the correct values back and return it
            For Each kvp As KeyValuePair(Of String, Double) In dicList
                ans.Add(kvp.Key, kvp.Value)
            Next

            Return ans

        ElseIf sortMode = "Hind kahanev" Then

            'List to hold dictionary entries.
            Dim dicList As List(Of KeyValuePair(Of String, Double)) = temp.ToList
            Dim ans As New Dictionary(Of String, Double)


            'Sort the list by double value in ascending order.
            dicList.Sort(Function(x, y) y.Value.CompareTo(x.Value))


            ' Add the correct values back and return it
            For Each kvp As KeyValuePair(Of String, Double) In dicList
                ans.Add(kvp.Key, kvp.Value)
            Next

            Return ans

        End If

        Return New Dictionary(Of String, Double)
    End Function

    Public Function PriceReturn(ByRef package As String) As Double Implements iComparePackages.PriceReturn
        Throw New NotImplementedException()
    End Function
End Class
