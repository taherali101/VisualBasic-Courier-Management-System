Imports CrystalDecisions.CrystalReports.Engine
Public Class Form43

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load
        Dim cryRpt As New ReportDocument
        cryRpt.Load("C:\Users\taher\OneDrive\Documents\Project\Visual Studio 2008\Projects\couriermanagementsystem\couriermanagementsystem\CrystalReport5.rpt")
        CrystalReportViewer1.ReportSource = cryRpt
        CrystalReportViewer1.Refresh()
    End Sub

    Private Sub Form43_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Left = 231
        Me.Top = 0
        Me.Size = New Point(Form3.Panel3.Size)
    End Sub

    Private Sub PictureBox8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox8.Click
        Me.Close()

    End Sub
End Class