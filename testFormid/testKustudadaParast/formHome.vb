Public Class formHome

    'Button tabs'
    Private Sub calcButton_Click(sender As Object, e As EventArgs) Handles calcButton.Click
        formCalc.Show()
        Me.Hide()
    End Sub

    Private Sub vordlusButton_Click(sender As Object, e As EventArgs) Handles vordlusButton.Click
        formVordlus.Show()
        Me.Hide()
    End Sub

    'Size buttons
    Private Sub enlargeButton_Click(sender As Object, e As EventArgs) Handles enlargeButton.Click
        'Increase the size of the form and all its elements by 5%
        Me.Width *= 1.05
        Me.Height *= 1.05

        For Each ctrl As Control In Me.Controls
            ctrl.Width *= 1.05
            ctrl.Height *= 1.05
            ctrl.Left *= 1.05
            ctrl.Top *= 1.05
        Next
    End Sub

    Private Sub shrink_Click(sender As Object, e As EventArgs) Handles shrinkButton.Click
        'Decrease the size of the form and all its elements by 5%
        Me.Width *= 0.95
        Me.Height *= 0.95

        For Each ctrl As Control In Me.Controls
            ctrl.Width *= 0.95
            ctrl.Height *= 0.95
            ctrl.Left *= 0.95
            ctrl.Top *= 0.95
        Next
    End Sub

End Class