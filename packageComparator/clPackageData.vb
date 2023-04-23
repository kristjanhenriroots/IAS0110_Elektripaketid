Imports System.Security.Cryptography
Imports System.Windows.Forms

' Project that compares electricity packages other than b�rs
Public Class clPackageData
    Implements iComparePackages

    ' Current list and pricing for all electricity packages
    Public Function PackageData() As Dictionary(Of String, Double) Implements iComparePackages.PackageData
        Dim deals = New Dictionary(Of String, Double) From {
            {"Kasulik Kl�ps", 16.73}, 'https://elektrihind.ee/paketid/
            {"Kindel", 13.57},
            {"Kindel 36", 17.5},
            {"Kindel 6", 15.89},
            {"Kindel Pluss", 14.49},
            {"T�htajaline fikseeritud hind + �hisarve", 13.96},
            {"T�htajaline fiseeritud", 13.5},
            {"Universaal", 19.95}   'https://www.energia.ee/et/era/elekter/elektrileping-ja-paketid?customers=home-customer&packages=fixPlus
        }

        Return deals
    End Function

    ' Function that gets called when the user changes the order of the packages, input is sorting mode, function will return the formatted list
    Public Function PackageSorter(ByRef sortMode As String) As Dictionary(Of String, Double) Implements iComparePackages.PackageSorter
        Dim temp = PackageData()

        'Sort the items in CheckedListBox based on selected sorting option
        If sortMode = "A - Z" Then
            Return temp ' because packages are always kept at an alphabetic order

        ElseIf sortMode = "Z - A" Then  ' reverse it
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

    ' Function if asking for a specific package price
    Public Function PriceReturn(ByRef package As String) As Double Implements iComparePackages.PriceReturn
        Dim deals = PackageData()
        For Each kvp As KeyValuePair(Of String, Double) In deals
            If kvp.Key = package Then
                Return kvp.Value
            End If
        Next

        Return 0
    End Function

    ' Returns ALL of the indices of selected packages from the listbox, 
    Private Function getSelectedIndices(listBox As CheckedListBox) As List(Of Integer) Implements iComparePackages.GetSelectedIndices
        Dim selectedIndexList As New List(Of Integer)

        ' Loop through the SelectedIndices collection and add each index to the list
        For Each index As Integer In listBox.CheckedIndices
            selectedIndexList.Add(index)
        Next

        Return selectedIndexList
    End Function
End Class
