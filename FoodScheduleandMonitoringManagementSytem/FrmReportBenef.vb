Imports MySql.Data.MySqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Public Class FrmReportBenef
    Dim hacker As New MySqlDataAdapter()
    Dim cracker As New DataSet()
    Sub def()

        Try
            With connect
                If .State = ConnectionState.Open Then .Close()

                connect.Open()
            End With
        Catch ex As MySqlException
            MsgBox(ex.ToString)
        End Try
        Try
            Dim qryExpired As String = "select childIDD,benef,bdate,weight,height,sex,age,bmi,nutstat,hfa from beneficiaries_info"

            hacker.SelectCommand = New MySqlCommand(qryExpired, connect)

            Dim cb As MySqlCommandBuilder = New MySqlCommandBuilder(hacker)

            hacker.Fill(cracker, "tb_product")
            hacker.Dispose()
        Catch ex As MySqlException
            MsgBox(ex.ToString)
        Finally
            connect.Close()
        End Try
        Dim Rpt As New nutstat
        Rpt.SetDataSource(cracker.Tables("beneficiaries_info"))
        CrystalReportViewer1.ReportSource = Rpt
        CrystalReportViewer1.RefreshReport()
        ' GWAPO KAAYU KO KAY KAMAO NAKO MUGAMA OG REPORTS :)
    End Sub

    Private Sub FrmReportBenef_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load

    End Sub
End Class