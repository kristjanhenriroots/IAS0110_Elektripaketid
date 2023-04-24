Imports System.Text
Imports AndmeParija.CAPIQuery
Imports AndmeParija.CDatabaseQuery
Public Class formVordlus
    Private comboBoxTable As New DataTable
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

        'Go through each deal in deals dictionary and them to pakettCheckedListBox.
        For Each dealName As String In deals.Keys
            pakettCheckedListBox.Items.Add(dealName)
        Next

        'Sorting options for jarjestamineComboBox
        jarjestamineComboBox.Items.Add("A-Z")
        jarjestamineComboBox.Items.Add("Z-A")
        jarjestamineComboBox.Items.Add("Hind langev")
        jarjestamineComboBox.Items.Add("Hind tõusev")

        'Show clear packageChart on form load.
        packageChart.Series.Clear()

        'Database section
        Dim updateBorsTable As AndmeParija.IAPIQuery
        updateBorsTable = New AndmeParija.CAPIQuery

        Try
            updateBorsTable.updateTable()
        Catch ex As Exception
            MessageBox.Show("Error updating data table.")
        End Try

        Dim loadComboBoxValues As AndmeParija.IDatabaseQuery
        loadComboBoxValues = New AndmeParija.CDatabaseQuery

        comboBoxTable = loadComboBoxValues.queryData("Select dateTime FROM bors WHERE rowid > 1 LIMIT 25")

        Dim dateTimeValues = New List(Of String)
        For Each row As DataRow In comboBoxTable.Rows
            dateTimeValues.Add(row(0))
        Next

        Dim providerValues = New List(Of String)

        loadComboBoxValues = New AndmeParija.CDatabaseQuery
        comboBoxTable = loadComboBoxValues.queryData("Select DISTINCT provider, name FROM borsPakett")
        For Each row As DataRow In comboBoxTable.Rows
            providerValues.Add(row(0))
        Next

        cbProvider.DataSource = providerValues
        cbStartTime.BindingContext = New BindingContext
        cbStartTime.DataSource = dateTimeValues
        cbEndTime.BindingContext = New BindingContext
        cbEndTime.DataSource = dateTimeValues
    End Sub

    Private Sub cbProvider_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbProvider.SelectedValueChanged
        Dim nameValues = New List(Of String)
        Dim nameRow As DataRow()
        Dim filterStr As String = "provider = '" & cbProvider.SelectedValue & "'"
        nameRow = comboBoxTable.Select(filterStr)

        For Each row As DataRow In nameRow
            nameValues.Add(row(1).ToString)
        Next

        cbPackage.DataSource = nameValues
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
            'Set sorting option to false so that it's possible to sort
            pakettCheckedListBox.Sorted = False

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
            'Set sorting option to false so that it's possible to sort
            pakettCheckedListBox.Sorted = False

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

    Private Sub compareButton_Click(sender As Object, e As EventArgs) Handles compareButton.Click
        'Clear previous data.
        packageChart.Series.Clear()

        'Go through checked items in pakettCheckedListBox.
        For Each item In pakettCheckedListBox.CheckedItems
            Dim key As String = DirectCast(item, String)
            Dim value As Double = deals(key)

            'Create a new series in the chart for each checked package.
            Dim series As New DataVisualization.Charting.Series()
            series.Name = key

            'Add data point to series with given value.
            series.Points.AddXY(0, value)

            'Add the series to chart.
            packageChart.Series.Add(series)

            'Add tooltip for data point to display name and price.
            series.Points(0).ToolTip = key & " - " & Math.Round(value, 2).ToString() & " s"
        Next
    End Sub

    Private Sub btnFindPackage_Click(sender As Object, e As EventArgs) Handles btnFindPackage.Click
        Dim sbPakettPriceMargin As StringBuilder = New StringBuilder

        Dim comboBoxSearch As AndmeParija.IDatabaseQuery
        comboBoxSearch = New AndmeParija.CDatabaseQuery

        Dim marginsTable As DataTable = comboBoxSearch.queryData("Select margin FROM borsPakett WHERE name = '" & cbPackage.SelectedValue & "'")
        comboBoxSearch = New AndmeParija.CDatabaseQuery

        Dim resultTable As DataTable = comboBoxSearch.queryData("Select DISTINCT dateTime, price FROM bors WHERE rowid > 1 AND dateTime BETWEEN '" _
                                                                          & cbStartTime.SelectedValue & "' AND '" & cbEndTime.SelectedValue & "'")

        Dim pakettMargin As Object = marginsTable.Rows(0)(0)

        resultTable.Columns.Add("priceMargin", GetType(Double))
        For Each row As DataRow In resultTable.Rows
            row("priceMargin") = row(1) + pakettMargin
        Next

        comboBoxSearch = New AndmeParija.CDatabaseQuery

        marginsTable = comboBoxSearch.queryData("Select name, provider, margin FROM borsPakett ORDER BY margin ASC LIMIT 3")
        sbPakettPriceMargin.AppendLine("3 Kõige väiksemat marginaali: ")
        For Each row As DataRow In marginsTable.Rows
            sbPakettPriceMargin.AppendLine(row(0).ToString & " " & row(1).ToString & " " & row(2).ToString)
        Next
        sbPakettPriceMargin.AppendLine()

        comboBoxSearch = New AndmeParija.CDatabaseQuery
        marginsTable = comboBoxSearch.queryData("Select name, provider, margin FROM borsPakett ORDER BY margin DESC LIMIT 3")
        sbPakettPriceMargin.AppendLine("3 Kõige suuremat marginaali: ")
        For Each row As DataRow In marginsTable.Rows
            sbPakettPriceMargin.AppendLine(row(0).ToString & " " & row(1).ToString & " " & row(2).ToString)
        Next
        sbPakettPriceMargin.AppendLine()

        sbPakettPriceMargin.AppendLine("Valitud paketti ajavahemiku hinnad tunnilõikes, koos hinnaga lõpptarbijale")
        For Each row As DataRow In resultTable.Rows
            sbPakettPriceMargin.AppendLine(row(0) & " " & row(1) & " " & row(2))
        Next



        Dim newForm As New formPriceMargin
        newForm.tbPriceMargins.Text += sbPakettPriceMargin.ToString

        newForm.dgvTimePrice.DataSource = resultTable
        newForm.Show()
    End Sub
End Class