Public Class Form1

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        End
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If (RadioButton1.Checked) Then
            f1.ShowDialog()
            RadioButton1.Checked = False
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If (RadioButton2.Checked) Then
            f2.ShowDialog()
            RadioButton2.Checked = False
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If (RadioButton3.Checked) Then
            f3.ShowDialog()
            RadioButton3.Checked = False
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        f0.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedDialog
        f0.MaximizeBox = False
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        f_htp.ShowDialog()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        If (RadioButton4.Checked) Then
            multi.ShowDialog()
            RadioButton4.Checked = False
        End If
    End Sub
End Class