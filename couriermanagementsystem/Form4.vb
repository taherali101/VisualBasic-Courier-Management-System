Public Class Form4

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim da As New OleDb.OleDbDataAdapter
        Dim ds As New DataSet
        ' Dim dr As DataRow
        If RichTextBox1.Text <> "" Then
            Module1.singlevaluequery("select count(*) from admin where uname='" & Form1.TextBox1.Text & "' and sans='" & RichTextBox1.Text & "'")
            If nval = 1 Then
                Timer1.Enabled = True

            Else
                MsgBox("Wrong Answere", MsgBoxStyle.Exclamation, "Incomplete Process")
            End If
        Else
            MsgBox("Give Answere", MsgBoxStyle.Exclamation, "Incomplete Process")
        End If
    End Sub
    Private Sub PictureBox8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox8.Click
        Form1.Show()
        Me.Dispose()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        GroupBox2.Width = GroupBox2.Width + 30
        GroupBox2.Height = GroupBox2.Height + 30

        If GroupBox2.Width >= 420 And GroupBox2.Height >= 420 Then
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text <> "" And TextBox2.Text = TextBox1.Text Then
            Module1.insertupdate("UPDATE Admin SET upass='" & TextBox1.Text & "' where uname='" & Form1.TextBox1.Text & "'")
        Else
            MsgBox("Password Does not Match", MsgBoxStyle.Critical, "Error")
            TextBox2.Select()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form1.Show()
    End Sub

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class