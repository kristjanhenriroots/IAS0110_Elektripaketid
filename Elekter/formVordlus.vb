Public Class formVordlus
    Private Sub formVordlus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Items for pakettCheckedListBox
        pakettCheckedListBox.Items.Add("Pakett 1")
        pakettCheckedListBox.Items.Add("Pakett 2")
        pakettCheckedListBox.Items.Add("Börss")

        'Sorting options for jarjestamineComboBox
        jarjestamineComboBox.Items.Add("A-Z")
        jarjestamineComboBox.Items.Add("Hind langev")
        jarjestamineComboBox.Items.Add("Hind tõusev")
    End Sub

    Private Sub jarjestamineComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles jarjestamineComboBox.SelectedIndexChanged
        'Get selected sorting option from ComboBox
        Dim selectedSortOption As String = jarjestamineComboBox.SelectedItem.ToString()

        'Sort the items in CheckedListBox based on selected sorting option
        If selectedSortOption = "A-Z" Then
            pakettCheckedListBox.Sorted = True
        ElseIf selectedSortOption = "Hind langev" Then

        ElseIf selectedSortOption = "Hind tõusev" Then

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

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub vordlusButton_Click(sender As Object, e As EventArgs) Handles vordlusButton.Click

    End Sub

    Private Sub otsingButton_Click(sender As Object, e As EventArgs) Handles otsingButton.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub CheckedListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckedListBox2.SelectedIndexChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub pakettCheckedListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles pakettCheckedListBox.SelectedIndexChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class