Imports System.Windows.Forms
Imports System.Drawing.Drawing2D
Imports System.Drawing

Public Class PIN
    Inherits Button
    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        Dim graph As GraphicsPath = New GraphicsPath()
        graph.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height)
        Me.Region = New Region(graph)
        MyBase.OnPaint(e)
    End Sub
End Class
