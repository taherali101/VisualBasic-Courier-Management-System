Public Class Form8
    Dim da As New OleDb.OleDbDataAdapter
    Dim ds As New DataSet
    Dim dr As DataRow
    Dim indx As New Integer
    Dim dad As New OleDb.OleDbDataAdapter
    Dim dss As New DataSet
    Dim drr As DataRow
    Dim indx1 As New Integer
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Panel2.Visible = True Then
            Panel2.Visible = False
            DataGridView2.Visible = False
            Panel1.Visible = True
        Else
            Panel1.Visible = True
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Panel1.Visible = True Then
            Panel1.Visible = False
            DataGridView1.Visible = False
            Panel2.Visible = True
        Else
            Panel2.Visible = True
        End If
    End Sub

    Private Sub Form8_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Left = 239
        Me.Top = 0
        Me.Size = New Point(Form3.Panel3.Size)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If TextBox1.Text <> "" Then
            ds.Clear()
            da = New OleDb.OleDbDataAdapter("Select * from shipment where sid='" & TextBox1.Text & " '", con)
            da.Fill(ds)
            If ds.Tables(0).Rows.Count > 0 Then
                DataGridView1.Visible = True
                DataGridView1.DataSource = ds.Tables(0)
                indx = 0
                dr = ds.Tables(0).Rows(0)
                Call loaddata()
            End If
        End If
    End Sub
    Private Sub loaddata()
        TextBox2.Text = dr(1)
        TextBox3.Text = dr(2)
        TextBox4.Text = dr(3)
        TextBox5.Text = dr(4)
        TextBox6.Text = dr(5)
        TextBox7.Text = dr(6)
        TextBox8.Text = dr(7)

    End Sub
    Private Sub loaddata1()
        TextBox1.Text = dr(0)
        TextBox2.Text = dr(1)
        TextBox3.Text = dr(2)
        TextBox4.Text = dr(3)
        TextBox5.Text = dr(4)
        TextBox6.Text = dr(5)
        TextBox7.Text = dr(6)
        TextBox8.Text = dr(7)

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        indx = indx + 1
        If ds.Tables(0).Rows.Count > indx Then
            dr = ds.Tables(0).Rows(indx)

            Call loaddata1()
        Else
            MsgBox("This is The last Record", MsgBoxStyle.Critical, "Finished")
            indx = indx - 1

        End If
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        indx = indx - 1
        If indx >= 0 Then
            dr = ds.Tables(0).Rows(indx)

            Call loaddata1()
        Else
            MsgBox("This is The First Record", MsgBoxStyle.Critical, "Finished")
            indx = indx + 1

        End If
    End Sub

    Private Sub PictureBox8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox8.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If TextBox6.Text <> "" Then
            Module1.insertupdate("update shipment set currentstatus='" & TextBox6.Text & "' where sid='" & TextBox1.Text & "'")
            da = New OleDb.OleDbDataAdapter("select * from shipment", con)
            ds.Clear()
            da.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0)
        Else
            MsgBox("Fields should not be emply", MsgBoxStyle.Critical, "Finished")
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If TextBox16.Text <> "" Then
            dss.Clear()
            dad = New OleDb.OleDbDataAdapter("Select * from consi where con_id='" & TextBox16.Text & " '", con)
            dad.Fill(dss)
            If dss.Tables(0).Rows.Count > 0 Then
                DataGridView2.Visible = True
                DataGridView2.DataSource = dss.Tables(0)
                indx1 = 0
                drr = dss.Tables(0).Rows(0)
                Call loaddata2()
            End If
        End If
    End Sub
    Private Sub loaddata2()
        TextBox15.Text = drr(1)
        TextBox14.Text = drr(2)
        TextBox13.Text = drr(3)
        TextBox12.Text = drr(4)
        TextBox11.Text = drr(5)
    End Sub
    Private Sub loaddata3()
        TextBox16.Text = drr(0)
        TextBox15.Text = drr(1)
        TextBox14.Text = drr(2)
        TextBox13.Text = drr(3)
        TextBox12.Text = drr(4)
        TextBox11.Text = drr(5)

    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        indx1 = indx1 + 1
        If dss.Tables(0).Rows.Count > indx1 Then
            drr = dss.Tables(0).Rows(indx1)
            Call loaddata3()
        Else
            MsgBox("This is The last Record", MsgBoxStyle.Critical, "Finished")
            indx1 = indx1 - 1
        End If
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        indx1 = indx1 - 1
        If indx1 >= 0 Then
            drr = dss.Tables(0).Rows(indx1)
            Call loaddata3()
        Else
            MsgBox("This is The First Record", MsgBoxStyle.Critical, "Finished")
            indx1 = indx1 + 1
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If TextBox11.Text <> "" Then
            Module1.insertupdate("update consi set currentstatus='" & TextBox11.Text & "' where con_id='" & TextBox16.Text & "'")
            dad = New OleDb.OleDbDataAdapter("select * from consi", con)
            dss.Clear()
            dad.Fill(ds)
            DataGridView2.DataSource = dss.Tables(0)
        Else
            MsgBox("Fields should not be emply", MsgBoxStyle.Critical, "Finished")
        End If
    End Sub

    Private Sub DataGridView2_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub
End Class