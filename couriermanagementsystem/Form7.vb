Public Class Form7
    Dim da As New OleDb.OleDbDataAdapter
    Dim ds As New DataSet
    Dim dad As New OleDb.OleDbDataAdapter
    Dim dss As New DataSet

    Private Sub Form7_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Left = 239
        Me.Top = 0
        Me.Size = New Point(Form3.Panel3.Size)
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If RadioButton1.Checked = True Then
            GroupBox1.Width = GroupBox1.Width + 30
            GroupBox1.Height = GroupBox1.Height + 30
            If GroupBox1.Width >= 450 And GroupBox1.Height >= 450 Then
                Timer1.Enabled = False
            End If
        End If
    End Sub
    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If RadioButton2.Checked = True Then
            GroupBox2.Width = GroupBox2.Width + 30
            GroupBox2.Height = GroupBox2.Height + 30
            If GroupBox2.Width >= 450 And GroupBox2.Height >= 450 Then
                Timer2.Enabled = False
            End If
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        DataGridView1.Visible = True
        da = New OleDb.OleDbDataAdapter("select * from consi where con_id='" & TextBox1.Text & "' ", con)
        ds.Clear()
        da.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Text = " "
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form3.Show()
        Me.Dispose()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Form3.Show()
        Me.Dispose()

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        TextBox2.Text = " "
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        DataGridView2.Visible = True
        DataGridView2.Visible = True
        dad = New OleDb.OleDbDataAdapter("select * from shipment where sid='" & TextBox2.Text & "' ", con)
        dss.Clear()
        dad.Fill(dss)
        DataGridView2.DataSource = dss.Tables(0)

    End Sub

    Private Sub PictureBox9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox9.Click
        Me.Close()
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged

    End Sub
End Class