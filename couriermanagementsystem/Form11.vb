Public Class Form11
    Private Sub Form11_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Left = 231
        Me.Top = 0
        Me.Size = New Point(Form3.Panel3.Size)
    End Sub
    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Me.Close()
    End Sub
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Module1.singlevaluequery("Select max(sid)+1 from Shipment ")
        TextBox1.Text = nval
        TextBox1.Enabled = False
        Button2.Enabled = True
        Call clearcontent()
    End Sub
    Private Sub clearcontent()
        CheckBox4.Enabled = True
        RadioButton3.Enabled = True
        RadioButton4.Enabled = True
        RadioButton5.Enabled = True

        TextBox3.Enabled = True
        TextBox5.Enabled = True
        TextBox6.Enabled = True
        TextBox7.Enabled = True
        TextBox8.Enabled = True
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox2.Clear()
        TextBox8.Clear()
        TextBox7.Clear()
        TextBox9.Clear()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        TextBox6.Enabled = True
        TextBox8.Enabled = True

        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox2.Clear()
        TextBox8.Clear()
        TextBox7.Clear()
        TextBox9.Clear()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim amt As Integer
        Dim c As Integer
        c = TextBox3.Text
        amt = amt + 100
        If RadioButton5.Checked = True Then
            amt = amt + 100
        ElseIf RadioButton4.Checked = True Then
            amt = amt + 50
        ElseIf RadioButton3.Checked = True Then
            amt = amt + 20
        End If
        If CheckBox4.Checked = True Then
            amt = amt + 60
        Else
            amt = amt + 20
        End If
        c = c * amt
        If CheckBox4.Checked = True Then
            TextBox4.Text = CheckBox4.Text
        Else
            TextBox4.Clear()
        End If
        If RadioButton5.Checked = True Then
            TextBox2.Text = RadioButton5.Text
        ElseIf RadioButton4.Checked = True Then
            TextBox2.Text = RadioButton4.Text
        Else
            TextBox2.Text = RadioButton3.Text
        End If
        TextBox9.Text = c
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If TextBox1.Text <> "" And TextBox7.Text <> "" And TextBox3.Text <> "" And TextBox4.Text <> "" And TextBox5.Text <> "" And TextBox6.Text <> "" And TextBox2.Text <> "" And TextBox8.Text <> "" And TextBox9.Text <> "" Then
            Module1.insertupdate("insert into Shipment values  (" & CInt(TextBox1.Text) & ",'" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "','" & TextBox8.Text & "','" & TextBox9.Text & "','" & TextBox4.Text & "' )")
        End If
        Me.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Module1.singlevaluequery("Select max(cust_senid) from cust_sender ")
        TextBox6.Text = nval
        TextBox6.Enabled = False
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Module1.singlevaluequery("Select max(custrecid) from Cust_reciever ")
        TextBox8.Text = nval
        TextBox8.Enabled = False
    End Sub

    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub TextBox5_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox5.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox5.TextChanged

    End Sub
End Class