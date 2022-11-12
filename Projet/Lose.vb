Public Class Lose

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        f_lose.Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        f_lose.Visible = False
        f0.ShowDialog()
    End Sub

    Private Sub Lose_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        f_lose.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedDialog
        f_htp.MaximizeBox = False
    End Sub
End Class