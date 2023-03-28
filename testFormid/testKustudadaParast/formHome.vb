Public Class formHome
    Private Sub Kalk_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Form4.Show()
    End Sub

    Private Sub btn_home_Click(sender As Object, e As EventArgs) Handles btn_home.Click

        btn_home.Enabled = False

        Form3.Hide()
        Form4.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub
End Class