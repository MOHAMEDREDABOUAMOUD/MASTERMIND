Imports System.Drawing
Imports System.Windows.Forms
Public Class Multi_Player

    Dim i As Integer
    Dim sec As Integer = 30
    Dim min As Integer = 0
    Dim timeEND As Boolean


    Private Sub pclick(pin As PIN)
        pin.BackColor = Color.Black
    End Sub

    Private Sub pin1_Click(sender As Object, e As EventArgs) Handles Pin1.Click
        pclick(Pin1)
    End Sub

    Private Sub pin2_Click(sender As Object, e As EventArgs) Handles Pin2.Click
        pclick(Pin2)
    End Sub

    Private Sub Pin4_Click(sender As Object, e As EventArgs) Handles Pin4.Click
        pclick(Pin4)
    End Sub

    Private Sub Pin3_Click(sender As Object, e As EventArgs) Handles Pin3.Click
        pclick(Pin3)
    End Sub


    Private Sub Pin8_Click(sender As Object, e As EventArgs) Handles Pin8.Click
        pclick(Pin8)
    End Sub

    Private Sub Pin7_Click(sender As Object, e As EventArgs) Handles Pin7.Click
        pclick(Pin7)
    End Sub

    Private Sub Pin6_Click(sender As Object, e As EventArgs) Handles Pin6.Click
        pclick(Pin6)
    End Sub

    Private Sub Pin5_Click(sender As Object, e As EventArgs) Handles Pin5.Click
        pclick(Pin5)
    End Sub

    Private Sub Pin9_Click(sender As Object, e As EventArgs) Handles Pin9.Click
        pclick(Pin9)
    End Sub

    Private Sub Pin10_Click(sender As Object, e As EventArgs) Handles Pin10.Click
        pclick(Pin10)
    End Sub

    Private Sub Pin11_Click(sender As Object, e As EventArgs) Handles Pin11.Click
        pclick(Pin11)
    End Sub

    Private Sub Pin12_Click(sender As Object, e As EventArgs) Handles Pin12.Click
        pclick(Pin12)
    End Sub

    Private Sub Pin13_Click(sender As Object, e As EventArgs) Handles Pin13.Click
        pclick(Pin13)
    End Sub

    Private Sub Pin14_Click(sender As Object, e As EventArgs) Handles Pin14.Click
        pclick(Pin14)
    End Sub

    Private Sub Pin15_Click(sender As Object, e As EventArgs) Handles Pin15.Click
        pclick(Pin15)
    End Sub

    Private Sub Pin16_Click(sender As Object, e As EventArgs) Handles Pin16.Click
        pclick(Pin16)
    End Sub

    Private Sub Pin17_Click(sender As Object, e As EventArgs) Handles Pin17.Click
        pclick(Pin17)
    End Sub

    Private Sub Pin18_Click(sender As Object, e As EventArgs) Handles Pin18.Click
        pclick(Pin18)
    End Sub

    Private Sub Pin19_Click(sender As Object, e As EventArgs) Handles Pin19.Click
        pclick(Pin19)
    End Sub

    Private Sub Pin20_Click(sender As Object, e As EventArgs) Handles Pin20.Click
        pclick(Pin20)
    End Sub

    Private Sub Pin21_Click(sender As Object, e As EventArgs) Handles Pin21.Click
        pclick(Pin21)
    End Sub

    Private Sub Pin22_Click(sender As Object, e As EventArgs) Handles Pin22.Click
        pclick(Pin22)
    End Sub

    Private Sub Pin23_Click(sender As Object, e As EventArgs) Handles Pin23.Click
        pclick(Pin23)
    End Sub

    Private Sub Pin24_Click(sender As Object, e As EventArgs) Handles Pin24.Click
        pclick(Pin24)
    End Sub

    Private Sub Pin25_Click(sender As Object, e As EventArgs) Handles Pin25.Click
        pclick(Pin25)
    End Sub

    Private Sub Pin26_Click(sender As Object, e As EventArgs) Handles Pin26.Click
        pclick(Pin26)
    End Sub

    Private Sub Pin27_Click(sender As Object, e As EventArgs) Handles Pin27.Click
        pclick(Pin27)
    End Sub

    Private Sub Pin28_Click(sender As Object, e As EventArgs) Handles Pin28.Click
        pclick(Pin28)
    End Sub

    Private Sub Pin29_Click(sender As Object, e As EventArgs) Handles Pin29.Click
        pclick(Pin29)
    End Sub

    Private Sub Pin30_Click(sender As Object, e As EventArgs) Handles Pin30.Click
        pclick(Pin30)
    End Sub

    Private Sub Pin31_Click(sender As Object, e As EventArgs) Handles Pin31.Click
        pclick(Pin31)
    End Sub

    Private Sub Pin32_Click(sender As Object, e As EventArgs) Handles Pin32.Click
        pclick(Pin32)
    End Sub

    Private Sub Pin33_Click(sender As Object, e As EventArgs) Handles Pin33.Click
        pclick(Pin33)
    End Sub

    Private Sub Pin34_Click(sender As Object, e As EventArgs) Handles Pin34.Click
        pclick(Pin34)
    End Sub

    Private Sub Pin35_Click(sender As Object, e As EventArgs) Handles Pin35.Click
        pclick(Pin35)
    End Sub

    Private Sub Pin36_Click(sender As Object, e As EventArgs) Handles Pin36.Click
        pclick(Pin36)
    End Sub

    Private Sub Pin37_Click(sender As Object, e As EventArgs) Handles Pin37.Click
        pclick(Pin37)
    End Sub

    Private Sub Pin38_Click(sender As Object, e As EventArgs) Handles Pin38.Click
        pclick(Pin38)
    End Sub

    Private Sub Pin39_Click(sender As Object, e As EventArgs) Handles Pin39.Click
        pclick(Pin39)
    End Sub

    Private Sub Pin40_Click(sender As Object, e As EventArgs) Handles Pin40.Click
        pclick(Pin40)
    End Sub
    
    ''''''''''''''''''''''''''''''''''''''
    Private Sub choice(pinn As PIN)
        If GroupBox10.Visible = True Then
            If Pin37.BackColor = Color.Black Then
                Pin37.BackColor = pinn.BackColor
            ElseIf Pin38.BackColor = Color.Black Then
                Pin38.BackColor = pinn.BackColor
            ElseIf Pin39.BackColor = Color.Black Then
                Pin39.BackColor = pinn.BackColor
            ElseIf Pin40.BackColor = Color.Black Then
                Pin40.BackColor = pinn.BackColor
            End If
        ElseIf GroupBox9.Visible = True Then
            If Pin33.BackColor = Color.Black Then
                Pin33.BackColor = pinn.BackColor
            ElseIf Pin34.BackColor = Color.Black Then
                Pin34.BackColor = pinn.BackColor
            ElseIf Pin35.BackColor = Color.Black Then
                Pin35.BackColor = pinn.BackColor
            ElseIf Pin36.BackColor = Color.Black Then
                Pin36.BackColor = pinn.BackColor
            End If
        ElseIf GroupBox8.Visible = True Then
            If Pin29.BackColor = Color.Black Then
                Pin29.BackColor = pinn.BackColor
            ElseIf Pin30.BackColor = Color.Black Then
                Pin30.BackColor = pinn.BackColor
            ElseIf Pin31.BackColor = Color.Black Then
                Pin31.BackColor = pinn.BackColor
            ElseIf Pin32.BackColor = Color.Black Then
                Pin32.BackColor = pinn.BackColor
            End If
        ElseIf GroupBox7.Visible = True Then
            If Pin25.BackColor = Color.Black Then
                Pin25.BackColor = pinn.BackColor
            ElseIf Pin26.BackColor = Color.Black Then
                Pin26.BackColor = pinn.BackColor
            ElseIf Pin27.BackColor = Color.Black Then
                Pin27.BackColor = pinn.BackColor
            ElseIf Pin28.BackColor = Color.Black Then
                Pin28.BackColor = pinn.BackColor
            End If
        ElseIf GroupBox6.Visible = True Then
            If Pin21.BackColor = Color.Black Then
                Pin21.BackColor = pinn.BackColor
            ElseIf Pin22.BackColor = Color.Black Then
                Pin22.BackColor = pinn.BackColor
            ElseIf Pin23.BackColor = Color.Black Then
                Pin23.BackColor = pinn.BackColor
            ElseIf Pin24.BackColor = Color.Black Then
                Pin24.BackColor = pinn.BackColor
            End If
        ElseIf GroupBox5.Visible = True Then
            If Pin17.BackColor = Color.Black Then
                Pin17.BackColor = pinn.BackColor
            ElseIf Pin18.BackColor = Color.Black Then
                Pin18.BackColor = pinn.BackColor
            ElseIf Pin19.BackColor = Color.Black Then
                Pin19.BackColor = pinn.BackColor
            ElseIf Pin20.BackColor = Color.Black Then
                Pin20.BackColor = pinn.BackColor
            End If
        ElseIf GroupBox4.Visible = True Then
            If Pin13.BackColor = Color.Black Then
                Pin13.BackColor = pinn.BackColor
            ElseIf Pin14.BackColor = Color.Black Then
                Pin14.BackColor = pinn.BackColor
            ElseIf Pin15.BackColor = Color.Black Then
                Pin15.BackColor = pinn.BackColor
            ElseIf Pin16.BackColor = Color.Black Then
                Pin16.BackColor = pinn.BackColor
            End If
        ElseIf GroupBox3.Visible = True Then
            If Pin9.BackColor = Color.Black Then
                Pin9.BackColor = pinn.BackColor
            ElseIf Pin10.BackColor = Color.Black Then
                Pin10.BackColor = pinn.BackColor
            ElseIf Pin11.BackColor = Color.Black Then
                Pin11.BackColor = pinn.BackColor
            ElseIf Pin12.BackColor = Color.Black Then
                Pin12.BackColor = pinn.BackColor
            End If
        ElseIf GroupBox2.Visible = True Then
            If Pin5.BackColor = Color.Black Then
                Pin5.BackColor = pinn.BackColor
            ElseIf Pin6.BackColor = Color.Black Then
                Pin6.BackColor = pinn.BackColor
            ElseIf Pin7.BackColor = Color.Black Then
                Pin7.BackColor = pinn.BackColor
            ElseIf Pin8.BackColor = Color.Black Then
                Pin8.BackColor = pinn.BackColor
            End If
        ElseIf GroupBox1.Visible = True Then
            If Pin1.BackColor = Color.Black Then
                Pin1.BackColor = pinn.BackColor
            ElseIf Pin2.BackColor = Color.Black Then
                Pin2.BackColor = pinn.BackColor
            ElseIf Pin3.BackColor = Color.Black Then
                Pin3.BackColor = pinn.BackColor
            ElseIf Pin4.BackColor = Color.Black Then
                Pin4.BackColor = pinn.BackColor
            End If
        End If
    End Sub

    Private Sub Pinchoice1_Click(sender As Object, e As EventArgs) Handles Pinchoice1.Click
        choice(Pinchoice1)
    End Sub

    Private Sub Pinchoice2_Click(sender As Object, e As EventArgs) Handles Pinchoice2.Click
        choice(Pinchoice2)
    End Sub

    Private Sub Pinchoice3_Click(sender As Object, e As EventArgs) Handles Pinchoice3.Click
        choice(Pinchoice3)
    End Sub

    Private Sub Pinchoice4_Click(sender As Object, e As EventArgs) Handles Pinchoice4.Click
        choice(Pinchoice4)
    End Sub

    Private Sub Pinchoice5_Click(sender As Object, e As EventArgs) Handles Pinchoice5.Click
        choice(Pinchoice5)
    End Sub

    Private Sub Pinchoice6_Click(sender As Object, e As EventArgs) Handles Pinchoice6.Click
        choice(Pinchoice6)
    End Sub

    Private Sub Pinchoice7_Click(sender As Object, e As EventArgs) Handles Pinchoice7.Click
        choice(Pinchoice7)
    End Sub

    Private Sub Pinchoice8_Click(sender As Object, e As EventArgs) Handles Pinchoice8.Click
        choice(Pinchoice8)
    End Sub
    ''''''''''''''''''''''''''''''''''''''
    Private Sub bclick(but2 As Button, grp1 As GroupBox, grp2 As GroupBox, pinn1 As PIN, pinn2 As PIN, pinn3 As PIN, pinn4 As PIN, pinn_res1 As PIN, pinn_res2 As PIN, pinn_res3 As PIN, pinn_res4 As PIN, pinn_1 As PIN, pinn_2 As PIN, pinn_3 As PIN, pinn_4 As PIN)
        If pinn_res1.BackColor = pinn1.BackColor Then
            pinn_1.BackColor = Color.Blue
        ElseIf pinn_res1.BackColor = pinn2.BackColor Or pinn_res1.BackColor = pinn3.BackColor Or pinn_res1.BackColor = pinn4.BackColor Then
            pinn_1.BackColor = Color.White
        End If

        If pinn_res2.BackColor = pinn2.BackColor Then
            pinn_2.BackColor = Color.Blue
        ElseIf pinn_res2.BackColor = pinn1.BackColor Or pinn_res2.BackColor = pinn3.BackColor Or pinn_res2.BackColor = pinn4.BackColor Then
            pinn_2.BackColor = Color.White
        End If

        If pinn_res3.BackColor = pinn3.BackColor Then
            pinn_3.BackColor = Color.Blue
        ElseIf pinn_res3.BackColor = pinn1.BackColor Or pinn_res3.BackColor = pinn2.BackColor Or pinn_res3.BackColor = pinn4.BackColor Then
            pinn_3.BackColor = Color.White
        End If

        If pinn_res4.BackColor = pinn4.BackColor Then
            pinn_4.BackColor = Color.Blue
        ElseIf pinn_res4.BackColor = pinn1.BackColor Or pinn_res4.BackColor = pinn2.BackColor Or pinn_res4.BackColor = pinn3.BackColor Then
            pinn_4.BackColor = Color.White
        End If
        If pinn_1.BackColor = Color.Blue And pinn_2.BackColor = Color.Blue And pinn_3.BackColor = Color.Blue And pinn_4.BackColor = Color.Blue Then
            If rounds Mod 2 = 0 Then
                f_multi_win.Label3.Text = "1 player win "
            Else
                f_multi_win.Label3.Text = "2 player win "
            End If
            f_multi_win.Show()
            Timer1.Enabled = False
        ElseIf but2.Enabled Then
            sec = 30
            grp2.Visible = True
            grp2.Enabled = True
            grp1.Enabled = False
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        rounds = 1
        If (Pin1.BackColor <> Color.Black And Pin2.BackColor <> Color.Black And Pin3.BackColor <> Color.Black And Pin4.BackColor <> Color.Black) Then
            bclick(Button1, GroupBox1, GroupBox2, Pin1, Pin2, Pin3, Pin4, Pin_res1, Pin_res2, Pin_res3, Pin_res4, Pin_1, Pin_2, Pin_3, Pin_4)
        Else
            MsgBox(" Put All 4 Guesses First !")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        rounds = 2
        If (Pin1.BackColor = Pin5.BackColor And Pin2.BackColor = Pin6.BackColor And Pin3.BackColor = Pin7.BackColor And Pin4.BackColor = Pin8.BackColor) Then
            MsgBox(" same Guess as previous Round ")
        ElseIf (Pin5.BackColor <> Color.Black And Pin6.BackColor <> Color.Black And Pin7.BackColor <> Color.Black And Pin8.BackColor <> Color.Black) Then
            bclick(Button2, GroupBox2, GroupBox3, Pin5, Pin6, Pin7, Pin8, Pin_res1, Pin_res2, Pin_res3, Pin_res4, Pin_5, Pin_6, Pin_7, Pin_8)
        Else
            MsgBox(" Put All 4 Guesses First !")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        rounds = 3
        If (Pin9.BackColor = Pin5.BackColor And Pin10.BackColor = Pin6.BackColor And Pin11.BackColor = Pin7.BackColor And Pin12.BackColor = Pin8.BackColor) Then
            MsgBox(" same Guess as previous Round ")
        ElseIf (Pin9.BackColor <> Color.Black And Pin10.BackColor <> Color.Black And Pin11.BackColor <> Color.Black And Pin12.BackColor <> Color.Black) Then
            bclick(Button3, GroupBox3, GroupBox4, Pin9, Pin10, Pin11, Pin12, Pin_res1, Pin_res2, Pin_res3, Pin_res4, Pin_9, Pin_10, Pin_11, Pin_12)
        Else
            MsgBox(" Put All 4 Guesses First !")
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        rounds = 4
        If (Pin9.BackColor = Pin13.BackColor And Pin10.BackColor = Pin14.BackColor And Pin11.BackColor = Pin15.BackColor And Pin12.BackColor = Pin16.BackColor) Then
            MsgBox(" same Guess as previous Round ")
        ElseIf (Pin13.BackColor <> Color.Black And Pin14.BackColor <> Color.Black And Pin15.BackColor <> Color.Black And Pin16.BackColor <> Color.Black) Then
            bclick(Button4, GroupBox4, GroupBox5, Pin13, Pin14, Pin15, Pin16, Pin_res1, Pin_res2, Pin_res3, Pin_res4, Pin_13, Pin_14, Pin_15, Pin_16)
        Else
            MsgBox(" Put All 4 Guesses First !")
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        rounds = 5
        If (Pin17.BackColor = Pin13.BackColor And Pin18.BackColor = Pin14.BackColor And Pin19.BackColor = Pin15.BackColor And Pin20.BackColor = Pin16.BackColor) Then
            MsgBox(" same Guess as previous Round ")
        ElseIf (Pin17.BackColor <> Color.Black And Pin18.BackColor <> Color.Black And Pin19.BackColor <> Color.Black And Pin20.BackColor <> Color.Black) Then
            bclick(Button5, GroupBox5, GroupBox6, Pin17, Pin18, Pin19, Pin20, Pin_res1, Pin_res2, Pin_res3, Pin_res4, Pin_17, Pin_18, Pin_19, Pin_20)
        Else
            MsgBox(" Put All 4 Guesses First !")
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        rounds = 6
        If (Pin17.BackColor = Pin21.BackColor And Pin18.BackColor = Pin22.BackColor And Pin19.BackColor = Pin23.BackColor And Pin20.BackColor = Pin24.BackColor) Then
            MsgBox(" same Guess as previous Round ")
        ElseIf (Pin21.BackColor <> Color.Black And Pin22.BackColor <> Color.Black And Pin23.BackColor <> Color.Black And Pin24.BackColor <> Color.Black) Then
            bclick(Button6, GroupBox6, GroupBox7, Pin21, Pin22, Pin23, Pin24, Pin_res1, Pin_res2, Pin_res3, Pin_res4, Pin_21, Pin_22, Pin_23, Pin_24)
        Else
            MsgBox(" Put All 4 Guesses First !")
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        rounds = 7
        If (Pin25.BackColor = Pin21.BackColor And Pin26.BackColor = Pin22.BackColor And Pin27.BackColor = Pin23.BackColor And Pin28.BackColor = Pin24.BackColor) Then
            MsgBox(" same Guess as previous Round ")
        ElseIf (Pin25.BackColor <> Color.Black And Pin26.BackColor <> Color.Black And Pin27.BackColor <> Color.Black And Pin28.BackColor <> Color.Black) Then
            bclick(Button7, GroupBox7, GroupBox8, Pin25, Pin26, Pin27, Pin28, Pin_res1, Pin_res2, Pin_res3, Pin_res4, Pin_25, Pin_26, Pin_27, Pin_28)
        Else
            MsgBox(" Put All 4 Guesses First !")
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        rounds = 8
        If (Pin25.BackColor = Pin29.BackColor And Pin26.BackColor = Pin30.BackColor And Pin27.BackColor = Pin31.BackColor And Pin28.BackColor = Pin32.BackColor) Then
            MsgBox(" same Guess as previous Round ")
        ElseIf (Pin29.BackColor <> Color.Black And Pin30.BackColor <> Color.Black And Pin31.BackColor <> Color.Black And Pin32.BackColor <> Color.Black) Then
            bclick(Button8, GroupBox8, GroupBox9, Pin29, Pin30, Pin31, Pin32, Pin_res1, Pin_res2, Pin_res3, Pin_res4, Pin_29, Pin_30, Pin_31, Pin_32)
        Else
            MsgBox(" Put All 4 Guesses First !")
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        rounds = 9
        If (Pin33.BackColor = Pin29.BackColor And Pin34.BackColor = Pin30.BackColor And Pin35.BackColor = Pin31.BackColor And Pin36.BackColor = Pin32.BackColor) Then
            MsgBox(" same Guess as previous Round ")
        ElseIf (Pin33.BackColor <> Color.Black And Pin34.BackColor <> Color.Black And Pin35.BackColor <> Color.Black And Pin36.BackColor <> Color.Black) Then
            bclick(Button9, GroupBox9, GroupBox10, Pin33, Pin34, Pin35, Pin36, Pin_res1, Pin_res2, Pin_res3, Pin_res4, Pin_33, Pin_34, Pin_35, Pin_36)
        Else
            MsgBox(" Put All 4 Guesses First !")
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        rounds = 10
        If (Pin33.BackColor = Pin37.BackColor And Pin34.BackColor = Pin38.BackColor And Pin35.BackColor = Pin39.BackColor And Pin36.BackColor = Pin40.BackColor) Then
            MsgBox(" same Guess as previous Round ")
        End If
        If (Pin37.BackColor <> Color.Black And Pin38.BackColor <> Color.Black And Pin39.BackColor <> Color.Black And Pin40.BackColor <> Color.Black) Then
            If Pin_res1.BackColor = Pin37.BackColor Then
                Pin_37.BackColor = Color.Blue
            ElseIf Pin_res1.BackColor = Pin38.BackColor Or Pin_res1.BackColor = Pin39.BackColor Or Pin_res1.BackColor = Pin40.BackColor Then
                Pin_37.BackColor = Color.White
            End If

            If Pin_res2.BackColor = Pin38.BackColor Then
                Pin_38.BackColor = Color.Blue
            ElseIf Pin_res2.BackColor = Pin37.BackColor Or Pin_res2.BackColor = Pin39.BackColor Or Pin_res2.BackColor = Pin40.BackColor Then
                Pin_38.BackColor = Color.White
            End If

            If Pin_res3.BackColor = Pin39.BackColor Then
                Pin_39.BackColor = Color.Blue
            ElseIf Pin_res3.BackColor = Pin37.BackColor Or Pin_res3.BackColor = Pin38.BackColor Or Pin_res3.BackColor = Pin40.BackColor Then
                Pin_39.BackColor = Color.White
            End If

            If Pin_res4.BackColor = Pin40.BackColor Then
                Pin_40.BackColor = Color.Blue
            ElseIf Pin_res4.BackColor = Pin37.BackColor Or Pin_res4.BackColor = Pin38.BackColor Or Pin_res4.BackColor = Pin39.BackColor Then
                Pin_40.BackColor = Color.White
            End If

            If Pin_37.BackColor = Color.Blue And Pin_38.BackColor = Color.Blue And Pin_39.BackColor = Color.Blue And Pin_40.BackColor = Color.Blue Then
                f_multi_win.Label1.Text = " DRAW "
                f_multi_win.Show()
                GroupBoxSHOW.Visible = False
            Else
                f_lose.ShowDialog()
                GroupBoxSHOW.Visible = False
            End If
        Else
            MsgBox(" Put All 4 Guesses First !")
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        Pin41.Enabled = False
        GroupBoxSHOW.Visible = False
        Pinchoice1.BackColor = Color.Red
        Pinchoice2.BackColor = Color.Blue
        Pinchoice3.BackColor = Color.White
        Pinchoice4.BackColor = Color.Yellow
        Pinchoice5.BackColor = Color.Green
        Pinchoice6.BackColor = Color.Gray
        Pinchoice7.BackColor = Color.Purple
        Pinchoice8.BackColor = Color.Brown
        GroupBox2.Enabled = False
        GroupBox2.Visible = False
        GroupBox3.Visible = False
        GroupBox4.Visible = False
        GroupBox5.Visible = False
        GroupBox6.Visible = False
        GroupBox7.Visible = False
        GroupBox8.Visible = False
        GroupBox9.Visible = False
        GroupBox10.Visible = False

        Pin1.BackColor = Color.Black
        Pin2.BackColor = Color.Black
        Pin3.BackColor = Color.Black
        Pin4.BackColor = Color.Black
        Pin_1.BackColor = Color.Black
        Pin_2.BackColor = Color.Black
        Pin_3.BackColor = Color.Black
        Pin_4.BackColor = Color.Black
        Pin5.BackColor = Color.Black
        Pin6.BackColor = Color.Black
        Pin7.BackColor = Color.Black
        Pin8.BackColor = Color.Black
        Pin_5.BackColor = Color.Black
        Pin_6.BackColor = Color.Black
        Pin_7.BackColor = Color.Black
        Pin_8.BackColor = Color.Black
        Pin9.BackColor = Color.Black
        Pin10.BackColor = Color.Black
        Pin11.BackColor = Color.Black
        Pin12.BackColor = Color.Black
        Pin_9.BackColor = Color.Black
        Pin_10.BackColor = Color.Black
        Pin_11.BackColor = Color.Black
        Pin_12.BackColor = Color.Black
        Pin13.BackColor = Color.Black
        Pin14.BackColor = Color.Black
        Pin15.BackColor = Color.Black
        Pin16.BackColor = Color.Black
        Pin_13.BackColor = Color.Black
        Pin_14.BackColor = Color.Black
        Pin_15.BackColor = Color.Black
        Pin_16.BackColor = Color.Black
        Pin17.BackColor = Color.Black
        Pin18.BackColor = Color.Black
        Pin19.BackColor = Color.Black
        Pin20.BackColor = Color.Black
        Pin_17.BackColor = Color.Black
        Pin_18.BackColor = Color.Black
        Pin_19.BackColor = Color.Black
        Pin_20.BackColor = Color.Black
        Pin21.BackColor = Color.Black
        Pin22.BackColor = Color.Black
        Pin23.BackColor = Color.Black
        Pin24.BackColor = Color.Black
        Pin_21.BackColor = Color.Black
        Pin_22.BackColor = Color.Black
        Pin_23.BackColor = Color.Black
        Pin_24.BackColor = Color.Black
        Pin25.BackColor = Color.Black
        Pin26.BackColor = Color.Black
        Pin27.BackColor = Color.Black
        Pin28.BackColor = Color.Black
        Pin_25.BackColor = Color.Black
        Pin_26.BackColor = Color.Black
        Pin_27.BackColor = Color.Black
        Pin_28.BackColor = Color.Black
        Pin29.BackColor = Color.Black
        Pin30.BackColor = Color.Black
        Pin31.BackColor = Color.Black
        Pin32.BackColor = Color.Black
        Pin_29.BackColor = Color.Black
        Pin_30.BackColor = Color.Black
        Pin_31.BackColor = Color.Black
        Pin_32.BackColor = Color.Black
        Pin33.BackColor = Color.Black
        Pin34.BackColor = Color.Black
        Pin35.BackColor = Color.Black
        Pin36.BackColor = Color.Black
        Pin_33.BackColor = Color.Black
        Pin_34.BackColor = Color.Black
        Pin_35.BackColor = Color.Black
        Pin_36.BackColor = Color.Black
        Pin37.BackColor = Color.Black
        Pin38.BackColor = Color.Black
        Pin39.BackColor = Color.Black
        Pin40.BackColor = Color.Black
        Pin_37.BackColor = Color.Black
        Pin_38.BackColor = Color.Black
        Pin_39.BackColor = Color.Black
        Pin_40.BackColor = Color.Black

        Pin1.AllowDrop = True
        Pin2.AllowDrop = True
        Pin3.AllowDrop = True
        Pin4.AllowDrop = True
        Pin5.AllowDrop = True
        Pin6.AllowDrop = True
        Pin7.AllowDrop = True
        Pin8.AllowDrop = True
        Pin9.AllowDrop = True
        Pin10.AllowDrop = True
        Pin11.AllowDrop = True
        Pin12.AllowDrop = True
        Pin13.AllowDrop = True
        Pin14.AllowDrop = True
        Pin15.AllowDrop = True
        Pin16.AllowDrop = True
        Pin17.AllowDrop = True
        Pin18.AllowDrop = True
        Pin19.AllowDrop = True
        Pin20.AllowDrop = True
        Pin21.AllowDrop = True
        Pin22.AllowDrop = True
        Pin23.AllowDrop = True
        Pin24.AllowDrop = True
        Pin25.AllowDrop = True
        Pin26.AllowDrop = True
        Pin27.AllowDrop = True
        Pin28.AllowDrop = True
        Pin29.AllowDrop = True
        Pin30.AllowDrop = True
        Pin31.AllowDrop = True
        Pin32.AllowDrop = True
        Pin33.AllowDrop = True
        Pin34.AllowDrop = True
        Pin35.AllowDrop = True
        Pin36.AllowDrop = True
        Pin37.AllowDrop = True
        Pin38.AllowDrop = True
        Pin39.AllowDrop = True
        Pin40.AllowDrop = True
        '''''

        Dim gess1, gess2, gess3, gess4 As Integer
        Dim value As New Random
        gess1 = value.Next(1, 9)
        gess2 = value.Next(1, 9)
        gess3 = value.Next(1, 9)
        gess4 = value.Next(1, 9)
        While gess2 = gess1
            gess2 = value.Next(1, 9)
        End While
        While gess3 = gess1 Or gess3 = gess2
            gess3 = value.Next(1, 9)
        End While
        While gess4 = gess1 Or gess4 = gess2 Or gess4 = gess3
            gess4 = value.Next(1, 9)
        End While
        If gess1 = 1 Then
            Pin_res1.BackColor = Color.Green
        ElseIf gess1 = 2 Then
            Pin_res1.BackColor = Color.Gray
        ElseIf gess1 = 3 Then
            Pin_res1.BackColor = Color.Purple
        ElseIf gess1 = 4 Then
            Pin_res1.BackColor = Color.Brown
        ElseIf gess1 = 5 Then
            Pin_res1.BackColor = Color.Blue
        ElseIf gess1 = 6 Then
            Pin_res1.BackColor = Color.Red
        ElseIf gess1 = 7 Then
            Pin_res1.BackColor = Color.Yellow
        ElseIf gess1 = 8 Then
            Pin_res1.BackColor = Color.White
        End If

        If gess2 = 1 Then
            Pin_res2.BackColor = Color.Green
        ElseIf gess2 = 2 Then
            Pin_res2.BackColor = Color.Gray
        ElseIf gess2 = 3 Then
            Pin_res2.BackColor = Color.Purple
        ElseIf gess2 = 4 Then
            Pin_res2.BackColor = Color.Brown
        ElseIf gess2 = 5 Then
            Pin_res2.BackColor = Color.Blue
        ElseIf gess2 = 6 Then
            Pin_res2.BackColor = Color.Red
        ElseIf gess2 = 7 Then
            Pin_res2.BackColor = Color.Yellow
        ElseIf gess2 = 8 Then
            Pin_res2.BackColor = Color.White
        End If

        If gess3 = 1 Then
            Pin_res3.BackColor = Color.Green
        ElseIf gess3 = 2 Then
            Pin_res3.BackColor = Color.Gray
        ElseIf gess3 = 3 Then
            Pin_res3.BackColor = Color.Purple
        ElseIf gess3 = 4 Then
            Pin_res3.BackColor = Color.Brown
        ElseIf gess3 = 5 Then
            Pin_res3.BackColor = Color.Blue
        ElseIf gess3 = 6 Then
            Pin_res3.BackColor = Color.Red
        ElseIf gess3 = 7 Then
            Pin_res3.BackColor = Color.Yellow
        ElseIf gess3 = 8 Then
            Pin_res3.BackColor = Color.White
        End If

        If gess4 = 1 Then
            Pin_res4.BackColor = Color.Green
        ElseIf gess4 = 2 Then
            Pin_res4.BackColor = Color.Gray
        ElseIf gess4 = 3 Then
            Pin_res4.BackColor = Color.Purple
        ElseIf gess4 = 4 Then
            Pin_res4.BackColor = Color.Brown
        ElseIf gess4 = 5 Then
            Pin_res4.BackColor = Color.Blue
        ElseIf gess4 = 6 Then
            Pin_res4.BackColor = Color.Red
        ElseIf gess4 = 7 Then
            Pin_res4.BackColor = Color.Yellow
        ElseIf gess4 = 8 Then
            Pin_res4.BackColor = Color.White
        End If
        multi.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedDialog
        multi.MaximizeBox = False
    End Sub

    Private Sub BTN_NEWGAME_Click(sender As Object, e As EventArgs) Handles BTN_NEWGAME.Click
        Timer1.Start()
        GroupBox2.Visible = False
        GroupBox3.Visible = False
        GroupBox4.Visible = False
        GroupBox5.Visible = False
        GroupBox6.Visible = False
        GroupBox7.Visible = False
        GroupBox8.Visible = False
        GroupBox9.Visible = False
        GroupBox10.Visible = False
        GroupBox1.Enabled = True
        '    initialisation dyal l board
        Dim gess1, gess2, gess3, gess4 As Integer
        Dim value As New Random
        gess1 = value.Next(1, 9)
        gess2 = value.Next(1, 9)
        gess3 = value.Next(1, 9)
        gess4 = value.Next(1, 9)
        While gess2 = gess1
            gess2 = value.Next(1, 9)
        End While
        While gess3 = gess1 Or gess3 = gess2
            gess3 = value.Next(1, 9)
        End While
        While gess4 = gess1 Or gess4 = gess2 Or gess4 = gess3
            gess4 = value.Next(1, 9)
        End While
        If gess1 = 1 Then
            Pin_res1.BackColor = Color.Green
        ElseIf gess1 = 2 Then
            Pin_res1.BackColor = Color.Gray
        ElseIf gess1 = 3 Then
            Pin_res1.BackColor = Color.Purple
        ElseIf gess1 = 4 Then
            Pin_res1.BackColor = Color.Brown
        ElseIf gess1 = 5 Then
            Pin_res1.BackColor = Color.Blue
        ElseIf gess1 = 6 Then
            Pin_res1.BackColor = Color.Red
        ElseIf gess1 = 7 Then
            Pin_res1.BackColor = Color.Yellow
        ElseIf gess1 = 8 Then
            Pin_res1.BackColor = Color.White
        End If

        If gess2 = 1 Then
            Pin_res2.BackColor = Color.Green
        ElseIf gess2 = 2 Then
            Pin_res2.BackColor = Color.Gray
        ElseIf gess2 = 3 Then
            Pin_res2.BackColor = Color.Purple
        ElseIf gess2 = 4 Then
            Pin_res2.BackColor = Color.Brown
        ElseIf gess2 = 5 Then
            Pin_res2.BackColor = Color.Blue
        ElseIf gess2 = 6 Then
            Pin_res2.BackColor = Color.Red
        ElseIf gess2 = 7 Then
            Pin_res2.BackColor = Color.Yellow
        ElseIf gess2 = 8 Then
            Pin_res2.BackColor = Color.White
        End If

        If gess3 = 1 Then
            Pin_res3.BackColor = Color.Green
        ElseIf gess3 = 2 Then
            Pin_res3.BackColor = Color.Gray
        ElseIf gess3 = 3 Then
            Pin_res3.BackColor = Color.Purple
        ElseIf gess3 = 4 Then
            Pin_res3.BackColor = Color.Brown
        ElseIf gess3 = 5 Then
            Pin_res3.BackColor = Color.Blue
        ElseIf gess3 = 6 Then
            Pin_res3.BackColor = Color.Red
        ElseIf gess3 = 7 Then
            Pin_res3.BackColor = Color.Yellow
        ElseIf gess3 = 8 Then
            Pin_res3.BackColor = Color.White
        End If

        If gess4 = 1 Then
            Pin_res4.BackColor = Color.Green
        ElseIf gess4 = 2 Then
            Pin_res4.BackColor = Color.Gray
        ElseIf gess4 = 3 Then
            Pin_res4.BackColor = Color.Purple
        ElseIf gess4 = 4 Then
            Pin_res4.BackColor = Color.Brown
        ElseIf gess4 = 5 Then
            Pin_res4.BackColor = Color.Blue
        ElseIf gess4 = 6 Then
            Pin_res4.BackColor = Color.Red
        ElseIf gess4 = 7 Then
            Pin_res4.BackColor = Color.Yellow
        ElseIf gess4 = 8 Then
            Pin_res4.BackColor = Color.White
        End If

        Pin1.BackColor = Color.Black
        Pin2.BackColor = Color.Black
        Pin3.BackColor = Color.Black
        Pin4.BackColor = Color.Black
        Pin_1.BackColor = Color.Black
        Pin_2.BackColor = Color.Black
        Pin_3.BackColor = Color.Black
        Pin_4.BackColor = Color.Black
        Pin5.BackColor = Color.Black
        Pin6.BackColor = Color.Black
        Pin7.BackColor = Color.Black
        Pin8.BackColor = Color.Black
        Pin_5.BackColor = Color.Black
        Pin_6.BackColor = Color.Black
        Pin_7.BackColor = Color.Black
        Pin_8.BackColor = Color.Black
        Pin9.BackColor = Color.Black
        Pin10.BackColor = Color.Black
        Pin11.BackColor = Color.Black
        Pin12.BackColor = Color.Black
        Pin_9.BackColor = Color.Black
        Pin_10.BackColor = Color.Black
        Pin_11.BackColor = Color.Black
        Pin_12.BackColor = Color.Black
        Pin13.BackColor = Color.Black
        Pin14.BackColor = Color.Black
        Pin15.BackColor = Color.Black
        Pin16.BackColor = Color.Black
        Pin_13.BackColor = Color.Black
        Pin_14.BackColor = Color.Black
        Pin_15.BackColor = Color.Black
        Pin_16.BackColor = Color.Black
        Pin17.BackColor = Color.Black
        Pin18.BackColor = Color.Black
        Pin19.BackColor = Color.Black
        Pin20.BackColor = Color.Black
        Pin_17.BackColor = Color.Black
        Pin_18.BackColor = Color.Black
        Pin_19.BackColor = Color.Black
        Pin_20.BackColor = Color.Black
        Pin21.BackColor = Color.Black
        Pin22.BackColor = Color.Black
        Pin23.BackColor = Color.Black
        Pin24.BackColor = Color.Black
        Pin_21.BackColor = Color.Black
        Pin_22.BackColor = Color.Black
        Pin_23.BackColor = Color.Black
        Pin_24.BackColor = Color.Black
        Pin25.BackColor = Color.Black
        Pin26.BackColor = Color.Black
        Pin27.BackColor = Color.Black
        Pin28.BackColor = Color.Black
        Pin_25.BackColor = Color.Black
        Pin_26.BackColor = Color.Black
        Pin_27.BackColor = Color.Black
        Pin_28.BackColor = Color.Black
        Pin29.BackColor = Color.Black
        Pin30.BackColor = Color.Black
        Pin31.BackColor = Color.Black
        Pin32.BackColor = Color.Black
        Pin_29.BackColor = Color.Black
        Pin_30.BackColor = Color.Black
        Pin_31.BackColor = Color.Black
        Pin_32.BackColor = Color.Black
        Pin33.BackColor = Color.Black
        Pin34.BackColor = Color.Black
        Pin35.BackColor = Color.Black
        Pin36.BackColor = Color.Black
        Pin_33.BackColor = Color.Black
        Pin_34.BackColor = Color.Black
        Pin_35.BackColor = Color.Black
        Pin_36.BackColor = Color.Black
        Pin37.BackColor = Color.Black
        Pin38.BackColor = Color.Black
        Pin39.BackColor = Color.Black
        Pin40.BackColor = Color.Black
        Pin_37.BackColor = Color.Black
        Pin_38.BackColor = Color.Black
        Pin_39.BackColor = Color.Black
        Pin_40.BackColor = Color.Black
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        timeEND = False
        sec = sec - 1
        Label1.Text = sec
        If sec = 0 Then
            Timer1.Enabled = False
            next_try()
            sec = 30
            Timer1.Enabled = True
        End If
    End Sub

    Private Sub rndm_color(cnt As Integer, but As Button)
        Select Case cnt
            Case 1
                but.BackColor = Pinchoice1.BackColor
            Case 2
                but.BackColor = Pinchoice2.BackColor
            Case 3
                but.BackColor = Pinchoice3.BackColor
            Case 4
                but.BackColor = Pinchoice4.BackColor
            Case 5
                but.BackColor = Pinchoice5.BackColor
            Case 6
                but.BackColor = Pinchoice6.BackColor
            Case 7
                but.BackColor = Pinchoice7.BackColor
            Case 8
                but.BackColor = Pinchoice8.BackColor
            Case Else
        End Select
    End Sub

    Private Sub next_try()
        If GroupBox9.Visible = True Then
            GroupBox10.Visible = True
            GroupBox10.Enabled = True
            GroupBox9.Enabled = False
        ElseIf GroupBox8.Visible = True Then
            GroupBox9.Visible = True
            GroupBox9.Enabled = True
            GroupBox8.Enabled = False
        ElseIf GroupBox7.Visible = True Then
            GroupBox8.Visible = True
            GroupBox8.Enabled = True
            GroupBox7.Enabled = False
        ElseIf GroupBox6.Visible = True Then
            GroupBox7.Visible = True
            GroupBox7.Enabled = True
            GroupBox6.Enabled = False
        ElseIf GroupBox5.Visible = True Then
            GroupBox6.Visible = True
            GroupBox6.Enabled = True
            GroupBox5.Enabled = False
        ElseIf GroupBox4.Visible = True Then
            GroupBox5.Visible = True
            GroupBox5.Enabled = True
            GroupBox4.Enabled = False
        ElseIf GroupBox3.Visible = True Then
            GroupBox4.Visible = True
            GroupBox4.Enabled = True
            GroupBox3.Enabled = False
        ElseIf GroupBox2.Visible = True Then
            GroupBox3.Visible = True
            GroupBox3.Enabled = True
            GroupBox2.Enabled = False
        ElseIf GroupBox1.Visible = True Then
            GroupBox2.Visible = True
            GroupBox2.Enabled = True
            GroupBox1.Enabled = False
        End If
    End Sub
    '----------------------   pin 1  ------------------------

    Private Sub Pin27_DragDrop(sender As Object, e As DragEventArgs) Handles Pin9.DragDrop, Pin8.DragDrop, Pin7.DragDrop, Pin6.DragDrop, Pin5.DragDrop, Pin40.DragDrop, Pin4.DragDrop, Pin39.DragDrop, Pin38.DragDrop, Pin37.DragDrop, Pin36.DragDrop, Pin35.DragDrop, Pin34.DragDrop, Pin33.DragDrop, Pin32.DragDrop, Pin31.DragDrop, Pin30.DragDrop, Pin3.DragDrop, Pin29.DragDrop, Pin28.DragDrop, Pin27.DragDrop, Pin26.DragDrop, Pin25.DragDrop, Pin24.DragDrop, Pin23.DragDrop, Pin22.DragDrop, Pin21.DragDrop, Pin20.DragDrop, Pin2.DragDrop, Pin19.DragDrop, Pin18.DragDrop, Pin17.DragDrop, Pin16.DragDrop, Pin15.DragDrop, Pin14.DragDrop, Pin13.DragDrop, Pin12.DragDrop, Pin11.DragDrop, Pin10.DragDrop, Pin1.DragDrop, GroupBox2.DragDrop
        Dim but1 As Button = DirectCast(e.Data.GetData(GetType(Button)), Button)
        Dim pan1 As Panel = DirectCast(sender, Panel)
    End Sub


    Private Sub Pinchoice5_MouseDown(sender As Object, e As MouseEventArgs) Handles Pinchoice5.MouseDown
        cnt = 5
        Pinchoice5.DoDragDrop(Pinchoice5, DragDropEffects.Copy)
    End Sub

    '---------------------------------------------------------
    ' mouse move of button choice
    Private Sub Pinchoice1_MouseDown(sender As Object, e As MouseEventArgs) Handles Pinchoice1.MouseDown
        cnt = 1
        Pinchoice1.DoDragDrop(Pinchoice1, DragDropEffects.Copy)
    End Sub

    Private Sub Pinchoice2_MouseDown(sender As Object, e As MouseEventArgs) Handles Pinchoice2.MouseDown
        cnt = 2
        Pinchoice2.DoDragDrop(Pinchoice2, DragDropEffects.Copy)
    End Sub

    Private Sub Pinchoice3_MouseDown(sender As Object, e As MouseEventArgs) Handles Pinchoice3.MouseDown
        cnt = 3
        Pinchoice3.DoDragDrop(Pinchoice3, DragDropEffects.Copy)
    End Sub

    Private Sub Pinchoice4_MouseDown(sender As Object, e As MouseEventArgs) Handles Pinchoice4.MouseDown
        cnt = 4
        Pinchoice4.DoDragDrop(Pinchoice4, DragDropEffects.Copy)
    End Sub
    Private Sub Pinchoice6_MouseDown(sender As Object, e As MouseEventArgs) Handles Pinchoice6.MouseDown
        cnt = 6
        Pinchoice6.DoDragDrop(Pinchoice6, DragDropEffects.Copy)
    End Sub

    Private Sub Pinchoice7_MouseDown(sender As Object, e As MouseEventArgs) Handles Pinchoice7.MouseDown
        cnt = 7
        Pinchoice7.DoDragDrop(Pinchoice7, DragDropEffects.Copy)
    End Sub

    Private Sub Pinchoice8_MouseDown(sender As Object, e As MouseEventArgs) Handles Pinchoice8.MouseDown
        cnt = 8
        Pinchoice8.DoDragDrop(Pinchoice8, DragDropEffects.Copy)
    End Sub
    '-------------------------------------------------------------------
    Private Sub Pin1_DragEnter(sender As Object, e As DragEventArgs) Handles Pin1.DragEnter
        e.Effect = DragDropEffects.Move
        rndm_color(cnt, Pin1)
    End Sub
    Private Sub Pin2_DragEnter(sender As Object, e As DragEventArgs) Handles Pin2.DragEnter
        e.Effect = DragDropEffects.Move
        rndm_color(cnt, Pin2)
    End Sub
    Private Sub Pin3_DragEnter(sender As Object, e As DragEventArgs) Handles Pin3.DragEnter
        e.Effect = DragDropEffects.Move
        rndm_color(cnt, Pin3)
    End Sub
    Private Sub Pin4_DragEnter(sender As Object, e As DragEventArgs) Handles Pin4.DragEnter
        e.Effect = DragDropEffects.Move
        rndm_color(cnt, Pin4)
    End Sub
    Private Sub Pin5_DragEnter(sender As Object, e As DragEventArgs) Handles Pin5.DragEnter
        e.Effect = DragDropEffects.Move
        rndm_color(cnt, Pin5)
    End Sub
    Private Sub Pin6_DragEnter(sender As Object, e As DragEventArgs) Handles Pin6.DragEnter
        e.Effect = DragDropEffects.Move
        rndm_color(cnt, Pin6)
    End Sub
    Private Sub Pin7_DragEnter(sender As Object, e As DragEventArgs) Handles Pin7.DragEnter
        e.Effect = DragDropEffects.Move
        rndm_color(cnt, Pin7)
    End Sub
    Private Sub Pin8_DragEnter(sender As Object, e As DragEventArgs) Handles Pin8.DragEnter
        e.Effect = DragDropEffects.Move
        rndm_color(cnt, Pin8)
    End Sub
    Private Sub Pin9_DragEnter(sender As Object, e As DragEventArgs) Handles Pin9.DragEnter
        e.Effect = DragDropEffects.Move
        rndm_color(cnt, Pin9)
    End Sub
    Private Sub Pin10_DragEnter(sender As Object, e As DragEventArgs) Handles Pin10.DragEnter
        e.Effect = DragDropEffects.Move
        rndm_color(cnt, Pin10)
    End Sub
    Private Sub Pin11_DragEnter(sender As Object, e As DragEventArgs) Handles Pin11.DragEnter
        e.Effect = DragDropEffects.Move
        rndm_color(cnt, Pin11)
    End Sub
    Private Sub Pin12_DragEnter(sender As Object, e As DragEventArgs) Handles Pin12.DragEnter
        e.Effect = DragDropEffects.Move
        rndm_color(cnt, Pin12)
    End Sub
    Private Sub Pin13_DragEnter(sender As Object, e As DragEventArgs) Handles Pin13.DragEnter
        e.Effect = DragDropEffects.Move
        rndm_color(cnt, Pin13)
    End Sub
    Private Sub Pin14_DragEnter(sender As Object, e As DragEventArgs) Handles Pin14.DragEnter
        e.Effect = DragDropEffects.Move
        rndm_color(cnt, Pin14)
    End Sub
    Private Sub Pin15_DragEnter(sender As Object, e As DragEventArgs) Handles Pin15.DragEnter
        e.Effect = DragDropEffects.Move
        rndm_color(cnt, Pin15)
    End Sub
    Private Sub Pin16_DragEnter(sender As Object, e As DragEventArgs) Handles Pin16.DragEnter
        e.Effect = DragDropEffects.Move
        rndm_color(cnt, Pin16)
    End Sub
    Private Sub Pin17_DragEnter(sender As Object, e As DragEventArgs) Handles Pin17.DragEnter
        e.Effect = DragDropEffects.Move
        rndm_color(cnt, Pin17)
    End Sub
    Private Sub Pin18_DragEnter(sender As Object, e As DragEventArgs) Handles Pin18.DragEnter
        e.Effect = DragDropEffects.Move
        rndm_color(cnt, Pin18)
    End Sub
    Private Sub Pin19_DragEnter(sender As Object, e As DragEventArgs) Handles Pin19.DragEnter
        e.Effect = DragDropEffects.Move
        rndm_color(cnt, Pin19)
    End Sub
    Private Sub Pin20_DragEnter(sender As Object, e As DragEventArgs) Handles Pin20.DragEnter
        e.Effect = DragDropEffects.Move
        rndm_color(cnt, Pin20)
    End Sub
    Private Sub Pin21_DragEnter(sender As Object, e As DragEventArgs) Handles Pin21.DragEnter
        e.Effect = DragDropEffects.Move
        rndm_color(cnt, Pin21)
    End Sub
    Private Sub Pin22_DragEnter(sender As Object, e As DragEventArgs) Handles Pin22.DragEnter
        e.Effect = DragDropEffects.Move
        rndm_color(cnt, Pin22)
    End Sub
    Private Sub Pin23_DragEnter(sender As Object, e As DragEventArgs) Handles Pin23.DragEnter
        e.Effect = DragDropEffects.Move
        rndm_color(cnt, Pin23)
    End Sub
    Private Sub Pin24_DragEnter(sender As Object, e As DragEventArgs) Handles Pin24.DragEnter
        e.Effect = DragDropEffects.Move
        rndm_color(cnt, Pin24)
    End Sub
    Private Sub Pin25_DragEnter(sender As Object, e As DragEventArgs) Handles Pin25.DragEnter
        e.Effect = DragDropEffects.Move
        rndm_color(cnt, Pin25)
    End Sub
    Private Sub Pin26_DragEnter(sender As Object, e As DragEventArgs) Handles Pin26.DragEnter
        e.Effect = DragDropEffects.Move
        rndm_color(cnt, Pin26)
    End Sub
    Private Sub Pin27_DragEnter(sender As Object, e As DragEventArgs) Handles Pin27.DragEnter
        e.Effect = DragDropEffects.Move
        rndm_color(cnt, Pin27)
    End Sub
    Private Sub Pin28_DragEnter(sender As Object, e As DragEventArgs) Handles Pin28.DragEnter
        e.Effect = DragDropEffects.Move
        rndm_color(cnt, Pin28)
    End Sub
    Private Sub Pin29_DragEnter(sender As Object, e As DragEventArgs) Handles Pin29.DragEnter
        e.Effect = DragDropEffects.Move
        rndm_color(cnt, Pin29)
    End Sub
    Private Sub Pin30_DragEnter(sender As Object, e As DragEventArgs) Handles Pin30.DragEnter
        e.Effect = DragDropEffects.Move
        rndm_color(cnt, Pin30)
    End Sub
    Private Sub Pin31_DragEnter(sender As Object, e As DragEventArgs) Handles Pin31.DragEnter
        e.Effect = DragDropEffects.Move
        rndm_color(cnt, Pin31)
    End Sub
    Private Sub Pin32_DragEnter(sender As Object, e As DragEventArgs) Handles Pin32.DragEnter
        e.Effect = DragDropEffects.Move
        rndm_color(cnt, Pin32)
    End Sub
    Private Sub Pin33_DragEnter(sender As Object, e As DragEventArgs) Handles Pin33.DragEnter
        e.Effect = DragDropEffects.Move
        rndm_color(cnt, Pin33)
    End Sub
    Private Sub Pin34_DragEnter(sender As Object, e As DragEventArgs) Handles Pin34.DragEnter
        e.Effect = DragDropEffects.Move
        rndm_color(cnt, Pin34)
    End Sub
    Private Sub Pin35_DragEnter(sender As Object, e As DragEventArgs) Handles Pin35.DragEnter
        e.Effect = DragDropEffects.Move
        rndm_color(cnt, Pin35)
    End Sub
    Private Sub Pin36_DragEnter(sender As Object, e As DragEventArgs) Handles Pin36.DragEnter
        e.Effect = DragDropEffects.Move
        rndm_color(cnt, Pin36)
    End Sub
    Private Sub Pin37_DragEnter(sender As Object, e As DragEventArgs) Handles Pin37.DragEnter
        e.Effect = DragDropEffects.Move
        rndm_color(cnt, Pin37)
    End Sub
    Private Sub Pin38_DragEnter(sender As Object, e As DragEventArgs) Handles Pin38.DragEnter
        e.Effect = DragDropEffects.Move
        rndm_color(cnt, Pin38)
    End Sub
    Private Sub Pin39_DragEnter(sender As Object, e As DragEventArgs) Handles Pin39.DragEnter
        e.Effect = DragDropEffects.Move
        rndm_color(cnt, Pin39)
    End Sub
    Private Sub Pin40_DragEnter(sender As Object, e As DragEventArgs) Handles Pin40.DragEnter
        e.Effect = DragDropEffects.Move
        rndm_color(cnt, Pin40)
    End Sub
    Private Sub Button11_Click_1(sender As Object, e As EventArgs) Handles Button11.Click
        Hide()
    End Sub
End Class