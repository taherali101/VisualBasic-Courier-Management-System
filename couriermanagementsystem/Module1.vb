Imports System.Data.OleDb

Module Module1
    Public con As New OleDb.OleDbConnection
    Public da As New OleDbDataAdapter
    Public cmd As New OleDb.OleDbCommand
    Public nval As Integer
    Public Sub connect()
        con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\taher\OneDrive\Documents\Project\Database1.mdb"
        con.Open()
        MsgBox("Database Connected", MsgBoxStyle.Information, "Welcome")
    End Sub
    Public Sub singlevaluequery(ByVal q As String)
        cmd = New OleDbCommand(q, con)
        nval = cmd.ExecuteScalar()
    End Sub
    Public Sub insertupdate(ByVal q As String)
        Dim x As Integer
        cmd = New OleDbCommand(q, con)
        x = cmd.ExecuteNonQuery()
        If x Then
            MsgBox("Operation Complete", MsgBoxStyle.Information, "Complete")
        Else
            MsgBox("Operation Unsuccesfull", MsgBoxStyle.Critical, "Error")
        End If
    End Sub
End Module
