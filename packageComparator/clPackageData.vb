Imports System.Security.Cryptography
Imports System.Windows.Forms

Public Class clPackageData
    Implements iComparePackages
    Private deals As New Dictionary(Of String, Double)

    Public Function PackageData(ByRef dictDT As DataTable) As Dictionary(Of String, Double) Implements iComparePackages.PackageData
        For Each row As DataRow In dictDT.Rows
            If Not deals.ContainsKey(row("name")) Then
                Console.Write(row("name").ToString())
                Console.WriteLine(row("avgPricePerKW"))
                deals.Add(row("provider") & " " & row("name"), row("avgPricePerKW"))
            End If
        Next

        Return deals
    End Function

    Public Function PackageSorter(ByRef sortMode As String) As Dictionary(Of String, Double) Implements iComparePackages.PackageSorter
        Dim temp = deals

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
        'Dim deals = PackageData()
        For Each kvp As KeyValuePair(Of String, Double) In deals
            If kvp.Key = package Then
                Return kvp.Value
            End If
        Next

        Return 0
    End Function

    ' Returns the indices of selected packages from the listbox
    Private Function getSelectedIndices(listBox As CheckedListBox) As List(Of Integer) Implements iComparePackages.GetSelectedIndices
        Dim selectedIndexList As New List(Of Integer)

        ' Loop through the SelectedIndices collection and add each index to the list
        For Each index As Integer In listBox.CheckedIndices
            selectedIndexList.Add(index)
        Next

        Return selectedIndexList
    End Function
End Class
