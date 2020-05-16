

Public Class Form5
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim amt As Integer
        Dim c As Integer
        c = TextBox2.Text
        amt = amt + 100
        If RadioButton1.Checked = True Then
            amt = amt + 100
        ElseIf RadioButton2.Checked = True Then
            amt = amt + 50
        ElseIf RadioButton3.Checked = True Then
            amt = amt + 20
        End If
        If CheckBox4.Checked = True Then
            amt = amt + 60
        End If
        c = c * amt
        MsgBox("YOUR POSTAGE CHARGES WOULD BE:" & c, vbInformation, "TOTAL AMOUNT")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Text = " "
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        CheckBox4.Checked = False
        TextBox2.Text = " "
    End Sub

    Private Sub Form5_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Left = 231
        Me.Top = 0
        Me.Size = New Point(Form3.Panel3.Size)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Dispose()
    End Sub

    Private Sub Panel3_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
