Public Class Form1

    Dim aA As Color
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim a As Integer = NumericUpDown1.Value
        Dim b As Integer = NumericUpDown2.Value
        Dim c As Integer = NumericUpDown3.Value

        Label1.ForeColor = cc(a, b, c)
        Label1.BackColor = cc(255 - a, 255 - b, 255 - c)


    End Sub
    Function cc(ByRef a As Integer, ByRef b As Integer, ByRef c As Integer)

        aA = Color.FromArgb(a, b, c)
        Return aA
    End Function


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        NumericUpDown2.Maximum = 255
        NumericUpDown3.Maximum = 255
        Me.BackColor = Color.BlueViolet

    End Sub

    Private Sub Form1_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.SizeChanged
        Me.Width = 300
        Me.Height = 300

    End Sub
End Class
