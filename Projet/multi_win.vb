Public Class multi_win

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        multi.Hide()
        f_multi_win.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        f_multi_win.Hide()
    End Sub

    Private Sub multi_win_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        f_multi_win.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedDialog
        f_multi_win.MaximizeBox = False
    End Sub
End Class