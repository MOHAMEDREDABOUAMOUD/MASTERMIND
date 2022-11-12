Public Class HowToPlay

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        GroupBox3.Visible = False
        GroupBox1.Visible = False
        GroupBox2.Visible = True
    End Sub

    Private Sub HowToPlay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GroupBox1.Visible = False
        GroupBox2.Visible = False
        'GroupBox3.Visible = True
        f_htp.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedDialog
        f_htp.MaximizeBox = False
        Pin_39.BackColor = Drawing.Color.Blue
        Pin3.BackColor = Drawing.Color.Blue
        Pin4.BackColor = Drawing.Color.White
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        GroupBox1.Visible = False
        GroupBox2.Visible = False
        GroupBox3.Visible = True
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        GroupBox1.Visible = True
        GroupBox2.Visible = False
        GroupBox3.Visible = False
    End Sub
End Class