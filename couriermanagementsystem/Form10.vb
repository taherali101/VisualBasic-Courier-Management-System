Imports CrystalDecisions.CrystalReports.Engine

Public Class Form10

    Private Sub Form10_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Left = 231
        Me.Top = 0
        Me.Size = New Point(Form3.Panel3.Size)
    End Sub

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load
        Dim cryRpt As New ReportDocument

        cryRpt.Load("C:\Users\taher\OneDrive\Documents\Project\Visual Studio 2008\Projects\couriermanagementsystem\couriermanagementsystem\CrystalReport1.rpt")
        CrystalReportViewer1.ReportSource = cryRpt
        CrystalReportViewer1.Refresh()
    End Sub
    

    Private Sub CrystalReportViewer1_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load

    End Sub
End Class