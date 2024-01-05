Imports MySql.Data.MySqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Public Class FrmReport

    Private Sub expirationBtn_Click(sender As Object, e As EventArgs) Handles expirationBtn.Click
        FrmReportBenef.Show()
        'Dim connect As New MySqlConnection("Server=localhost;User=root;password=;database=fpms;")
        'connect.Open()
        Dim dt As New DataTable
        Dim cmd As New MySqlCommand("select * from beneficiaries_info  ", connect)
        'Dim cmd As New MySqlCommand("select * from sells where id  like '%" & pid.Text & "%'  order by description ", con)
        Dim sda As New MySqlDataAdapter(cmd)
        sda.Fill(dt)

        Dim cr As New nutgraph
        cr.SetDataSource(dt)
        'cr.SetParameterValue("tp", tp.Text)
        'cr.SetParameterValue("rc", rc.Text)
        'cr.SetParameterValue("change", change.Text)
        FrmReportBenef.CrystalReportViewer1.ReportSource = cr
        FrmReportBenef.CrystalReportViewer1.Refresh()
        cr.Close()
        cr.Dispose()
    End Sub


    Private Sub stockinreportsBtn_Click(sender As Object, e As EventArgs) Handles stockinreportsBtn.Click
        FrmReportBenef.Show()
        'Dim connect As New MySqlConnection("Server=localhost;User=root;password=;database=fpms;")
        'connect.Open()
        Dim dt As New DataTable
        Dim cmd As New MySqlCommand("select * from beneficiaries_info ", connect)
        'Dim cmd As New MySqlCommand("select * from sells where id  like '%" & pid.Text & "%'  order by description ", con)
        Dim sda As New MySqlDataAdapter(cmd)
        sda.Fill(dt)

        Dim cr As New beneflist
        cr.SetDataSource(dt)
        'cr.SetParameterValue("tp", tp.Text)
        'cr.SetParameterValue("rc", rc.Text)
        'cr.SetParameterValue("change", change.Text)
        FrmReportBenef.CrystalReportViewer1.ReportSource = cr
        FrmReportBenef.CrystalReportViewer1.Refresh()
        cr.Close()
        cr.Dispose()
    End Sub

    Private Sub salesreportBtnn_Click(sender As Object, e As EventArgs) Handles nutstatrep.Click
        FrmReportBenef.Show()
        'Dim connect As New MySqlConnection("Server=localhost;User=root;password=;database=fpms;")
        'connect.Open()
        Dim dt As New DataTable
        Dim cmd As New MySqlCommand("select * from beneficiaries_info ", connect)
        'Dim cmd As New MySqlCommand("select * from sells where id  like '%" & pid.Text & "%'  order by description ", con)
        Dim sda As New MySqlDataAdapter(cmd)
        sda.Fill(dt)

        Dim cr As New nutstat
        cr.SetDataSource(dt)
        'cr.SetParameterValue("tp", tp.Text)
        'cr.SetParameterValue("rc", rc.Text)
        'cr.SetParameterValue("change", change.Text)
        FrmReportBenef.CrystalReportViewer1.ReportSource = cr
        FrmReportBenef.CrystalReportViewer1.Refresh()
        cr.Close()
        cr.Dispose()
    End Sub

    Private Sub productsReportBtn_Click(sender As Object, e As EventArgs) Handles productsReportBtn.Click
        FrmReportBenef.Show()
        'Dim connect As New MySqlConnection("Server=localhost;User=root;password=;database=fpms;")
        'connect.Open()
        Dim dt As New DataTable
        Dim cmd As New MySqlCommand("select * from beneficiaries_info  ", connect)
        'Dim cmd As New MySqlCommand("select * from sells where id  like '%" & pid.Text & "%'  order by description ", con)
        Dim sda As New MySqlDataAdapter(cmd)
        sda.Fill(dt)

        Dim cr As New hfareport
        cr.SetDataSource(dt)
        'cr.SetParameterValue("tp", tp.Text)
        'cr.SetParameterValue("rc", rc.Text)
        'cr.SetParameterValue("change", change.Text)
        FrmReportBenef.CrystalReportViewer1.ReportSource = cr
        FrmReportBenef.CrystalReportViewer1.Refresh()
        cr.Close()
        cr.Dispose()
    End Sub
  
    Private Sub defectivereportsBtn_Click(sender As Object, e As EventArgs) Handles defectivereportsBtn.Click
        FrmReportBenef.Show()
        'Dim connect As New MySqlConnection("Server=localhost;User=root;password=;database=fpms;")
        'connect.Open()
        Dim dt As New DataTable
        Dim cmd As New MySqlCommand("select * from schedule_info ", connect)
        'Dim cmd As New MySqlCommand("select * from sells where id  like '%" & pid.Text & "%'  order by description ", con)
        Dim sda As New MySqlDataAdapter(cmd)
        sda.Fill(dt)

        Dim cr As New schedreport
        cr.SetDataSource(dt)
        'cr.SetParameterValue("tp", tp.Text)
        'cr.SetParameterValue("rc", rc.Text)
        'cr.SetParameterValue("change", change.Text)
        FrmReportBenef.CrystalReportViewer1.ReportSource = cr
        FrmReportBenef.CrystalReportViewer1.Refresh()
        cr.Close()
        cr.Dispose()
    End Sub

    Private Sub stockoutreportBtn_Click(sender As Object, e As EventArgs) Handles stockoutreportBtn.Click
        FrmReportBenef.Show()
        ' Dim connect As New MySqlConnection("server=localhost;user=root;password=;database=fpms;")
        'connect.Open()
        Dim dt As New DataTable
        Dim cmd As New MySqlCommand("select * from budget_info ", connect)
        'dim cmd as new mysqlcommand("select * from sells where id  like '%" & pid.text & "%'  order by description ", con)
        Dim sda As New MySqlDataAdapter(cmd)
        sda.Fill(dt)

        Dim cr As New budgetreport
        cr.SetDataSource(dt)
        'cr.setparametervalue("tp", tp.text)
        'cr.setparametervalue("rc", rc.text)
        'cr.setparametervalue("change", change.text)
        FrmReportBenef.CrystalReportViewer1.ReportSource = cr
        FrmReportBenef.CrystalReportViewer1.Refresh()
        cr.Close()
        cr.Dispose()

      
    End Sub

    Private Sub monreport_Click(sender As Object, e As EventArgs) Handles monreport.Click
        FrmReportBenef.Show()
        'Dim connect As New MySqlConnection("Server=localhost;User=root;password=;database=fpms;")
        'connect.Open()
        Dim dt As New DataTable
        Dim cmd As New MySqlCommand("select * from beneficiaries_info ", connect)
        'Dim cmd As New MySqlCommand("select * from sells where id  like '%" & pid.Text & "%'  order by description ", con)
        Dim sda As New MySqlDataAdapter(cmd)
        sda.Fill(dt)

        Dim cr As New monlistreport
        cr.SetDataSource(dt)
        'cr.SetParameterValue("tp", tp.Text)
        'cr.SetParameterValue("rc", rc.Text)
        'cr.SetParameterValue("change", change.Text)
        FrmReportBenef.CrystalReportViewer1.ReportSource = cr
        FrmReportBenef.CrystalReportViewer1.Refresh()
        cr.Close()
        cr.Dispose()
    End Sub
End Class
