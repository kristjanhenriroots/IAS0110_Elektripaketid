Public Class formVordlus

    Private deals As Dictionary(Of String, Double)
    Private Sub formVordlus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        deals = New Dictionary(Of String, Double) From {
            {"Börss", MainForm.ReturnCurrentPrice},
            {"Universaal", 19.95}, 'https://www.energia.ee/et/era/elekter/elektrileping-ja-paketid?customers=home-customer&packages=fixPlus
            {"Kindel 6", 15.89},
            {"Kindel 36", 17.5},
            {"Kindel Pluss", 14.49},
            {"Kasulik Klõps", 16.73}, 'https://elektrihind.ee/paketid/
            {"Tähtajaline fiseeritud", 13.5},
            {"Kindel", 13.57},
            {"Tähtajaline fikseeritud hind + ühisarve", 13.96}
        }

        For Each dealName As String In deals.Keys
            pakettCheckedListBox.Items.Add(dealName)
        Next

        'Sorting options for jarjestamineComboBox
        jarjestamineComboBox.Items.Add("A-Z")
        jarjestamineComboBox.Items.Add("Z-A")
        jarjestamineComboBox.Items.Add("Hind langev")
        jarjestamineComboBox.Items.Add("Hind tõusev")
    End Sub

    Private Sub jarjestamineComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles jarjestamineComboBox.SelectedIndexChanged
        'Get selected sorting option from ComboBox
        Dim selectedSortOption As String = jarjestamineComboBox.SelectedItem.ToString()

        'Sort the items in CheckedListBox based on selected sorting option
        If selectedSortOption = "A-Z" Then
            'Sort pakettCheckedListBox
            pakettCheckedListBox.Sorted = True

        ElseIf selectedSortOption = "Z-A" Then
            'Set sorting option to false so that it's possible to reverse sort
            pakettCheckedListBox.Sorted = False

            'Make new list of strings
            Dim items As New List(Of String)

            'Add all items in pakettCheckedListBox to newly created list of strings
            For Each item As Object In pakettCheckedListBox.Items
                items.Add(item.ToString())
            Next

            'Sort all items in list, then reverse the list
            items.Sort()
            items.Reverse()

            'Clear all items in pakettCheckedListBox and then add the items back in in reverse order
            pakettCheckedListBox.Items.Clear()
            For Each item As String In items
                pakettCheckedListBox.Items.Add(item)
            Next

        ElseIf selectedSortOption = "Hind tõusev" Then
            'List to hold dictionary entries.
            Dim dicList As List(Of KeyValuePair(Of String, Double)) = deals.ToList

            'Sort the list by double value in ascending order.
            dicList.Sort(Function(x, y) x.Value.CompareTo(y.Value))

            'Clear pakettCheckedListBox.
            pakettCheckedListBox.Items.Clear()

            'Add sorted keys to pakettCheckedListBox.
            For Each kvp As KeyValuePair(Of String, Double) In dicList
                pakettCheckedListBox.Items.Add(kvp.Key)
            Next

        ElseIf selectedSortOption = "Hind langev" Then
            'List to hold dictionary entries.
            Dim dicList As List(Of KeyValuePair(Of String, Double)) = deals.ToList

            'Sort the list by double value in ascending order.
            dicList.Sort(Function(x, y) y.Value.CompareTo(x.Value))

            'Clear pakettCheckedListBox.
            pakettCheckedListBox.Items.Clear()

            'Add sorted keys to pakettCheckedListBox.
            For Each kvp As KeyValuePair(Of String, Double) In dicList
                pakettCheckedListBox.Items.Add(kvp.Key)
            Next
        End If
    End Sub

    'form Buttons'
    Private Sub calcButton_Click(sender As Object, e As EventArgs) Handles calcButton.Click
        formCalc.Show()
        Me.Hide()
    End Sub

    Private Sub homeButton_Click(sender As Object, e As EventArgs) Handles homeButton.Click
        MainForm.Show()
        Me.Hide()
    End Sub

End Class