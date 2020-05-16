Public Class Form2

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Form1.Hide()
        Label2.Text = CInt(Label2.Text) + 2
        If CInt(Label2.Text) = 100 Then
            Me.Close()
            Form3.Show()
        End If
    End Sub
End Class