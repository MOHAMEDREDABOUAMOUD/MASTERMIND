Public Class win

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        f_win.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        f_win.Hide()
        f1.Hide()
    End Sub

    Private Sub win_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        f_win.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedDialog
        f_win.MaximizeBox = False
    End Sub
End Class