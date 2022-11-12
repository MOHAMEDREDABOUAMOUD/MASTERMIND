<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HowToPlay
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HowToPlay))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Pin1 = New Projet.PIN()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Pin2 = New Projet.PIN()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Pin_39 = New Projet.PIN()
        Me.Pin3 = New Projet.PIN()
        Me.Pin4 = New Projet.PIN()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Forte", 18.2!)
        Me.Label1.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label1.Location = New System.Drawing.Point(155, 148)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(185, 34)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "How to Play"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Open Sans", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(6, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(376, 230)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = resources.GetString("Label2.Text")
        '
        'Pin1
        '
        Me.Pin1.BackColor = System.Drawing.Color.White
        Me.Pin1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Pin1.FlatAppearance.BorderSize = 0
        Me.Pin1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Pin1.Location = New System.Drawing.Point(44, 268)
        Me.Pin1.Name = "Pin1"
        Me.Pin1.Size = New System.Drawing.Size(22, 23)
        Me.Pin1.TabIndex = 2
        Me.Pin1.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Open Sans", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(87, 259)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(224, 161)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "One of your guess pegs..." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Has the correct color But " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "is in the wrong position" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & _
    "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "One of your guess pegs..." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Has the correct color and" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "is in the correct positi" & _
    "on" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Pin2
        '
        Me.Pin2.BackColor = System.Drawing.Color.Blue
        Me.Pin2.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Pin2.FlatAppearance.BorderSize = 0
        Me.Pin2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Pin2.Location = New System.Drawing.Point(44, 367)
        Me.Pin2.Name = "Pin2"
        Me.Pin2.Size = New System.Drawing.Size(22, 23)
        Me.Pin2.TabIndex = 4
        Me.Pin2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Orange
        Me.Button1.Location = New System.Drawing.Point(203, 609)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 36)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "2"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Orange
        Me.Button2.Location = New System.Drawing.Point(122, 609)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 36)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "1"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Open Sans", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Location = New System.Drawing.Point(6, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(399, 207)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = resources.GetString("Label4.Text")
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.Image = Global.Projet.My.Resources.Resources.WhatsApp_Image_2022_03_28_at_01_30_07
        Me.Button3.Location = New System.Drawing.Point(13, 60)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(375, 126)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Pin4)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Pin3)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Pin_39)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 172)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(419, 403)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Open Sans", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label6.Location = New System.Drawing.Point(9, 206)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(379, 184)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = resources.GetString("Label6.Text")
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Open Sans", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label5.Location = New System.Drawing.Point(9, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(232, 23)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Now let's see an example :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(18, 185)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(437, 239)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Pin1)
        Me.GroupBox3.Controls.Add(Me.Pin2)
        Me.GroupBox3.Location = New System.Drawing.Point(18, 172)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(437, 429)
        Me.GroupBox3.TabIndex = 12
        Me.GroupBox3.TabStop = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Orange
        Me.Button4.Location = New System.Drawing.Point(284, 609)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 36)
        Me.Button4.TabIndex = 13
        Me.Button4.Text = "3"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Pin_39
        '
        Me.Pin_39.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Pin_39.FlatAppearance.BorderSize = 0
        Me.Pin_39.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Pin_39.Location = New System.Drawing.Point(282, 113)
        Me.Pin_39.Margin = New System.Windows.Forms.Padding(4)
        Me.Pin_39.Name = "Pin_39"
        Me.Pin_39.Size = New System.Drawing.Size(22, 19)
        Me.Pin_39.TabIndex = 190
        Me.Pin_39.UseVisualStyleBackColor = False
        '
        'Pin3
        '
        Me.Pin3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Pin3.FlatAppearance.BorderSize = 0
        Me.Pin3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Pin3.Location = New System.Drawing.Point(300, 131)
        Me.Pin3.Margin = New System.Windows.Forms.Padding(4)
        Me.Pin3.Name = "Pin3"
        Me.Pin3.Size = New System.Drawing.Size(22, 19)
        Me.Pin3.TabIndex = 191
        Me.Pin3.UseVisualStyleBackColor = False
        '
        'Pin4
        '
        Me.Pin4.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Pin4.FlatAppearance.BorderSize = 0
        Me.Pin4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Pin4.Location = New System.Drawing.Point(312, 113)
        Me.Pin4.Margin = New System.Windows.Forms.Padding(4)
        Me.Pin4.Name = "Pin4"
        Me.Pin4.Size = New System.Drawing.Size(22, 19)
        Me.Pin4.TabIndex = 192
        Me.Pin4.UseVisualStyleBackColor = False
        '
        'HowToPlay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = Global.Projet.My.Resources.Resources.pec51
        Me.ClientSize = New System.Drawing.Size(464, 649)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "HowToPlay"
        Me.Text = "HowToPlay"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Pin1 As Projet.PIN
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Pin2 As Projet.PIN
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Pin_39 As Projet.PIN
    Friend WithEvents Pin3 As Projet.PIN
    Friend WithEvents Pin4 As Projet.PIN
End Class
