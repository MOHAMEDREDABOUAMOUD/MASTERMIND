Public Class win2

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        f2.Hide()
        f_win2.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        f_win2.Hide()
    End Sub

    Private Sub win2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        f_win2.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedDialog
        f_win2.MaximizeBox = False
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class