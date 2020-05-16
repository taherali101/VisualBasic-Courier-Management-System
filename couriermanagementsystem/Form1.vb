Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Module1.connect()

    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text <> "" And TextBox2.Text <> "" Then
            Module1.singlevaluequery("Select count(*) from admin where uname='" & TextBox1.Text & "' and upass='" & TextBox2.Text & "'")
            If Module1.nval = 1 Then
                Form2.ShowDialog()
            Else
                MsgBox("Please Enter a Correct Username or Password", MsgBoxStyle.Critical, "Wrong Input")
            End If

        Else
            MsgBox("Please Enter Username or Password", MsgBoxStyle.Critical, "Wrong Input")
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        
        Dim ds As New DataSet
        Dim dr As DataRow

        If TextBox1.Text <> "" Then
            Module1.singlevaluequery("select count(*) from admin where uname='" & TextBox1.Text & " '")
            If nval = 1 Then
                da = New OleDb.OleDbDataAdapter("Select sques from admin where uname='" & TextBox1.Text & "'", con)
                da.Fill(ds)
                If ds.Tables(0).Rows.Count > 0 Then
                    dr = ds.Tables(0).Rows(0)
                    Form4.Label3.Text = dr(0)
                    Form4.ShowDialog()

                End If
            Else
                MsgBox("Username Not Valid", MsgBoxStyle.Exclamation, "Error")
            End If
        Else
            MsgBox("Fields Should Not be Empty", MsgBoxStyle.Exclamation, "Error")
        End If
    End Sub
End Class
