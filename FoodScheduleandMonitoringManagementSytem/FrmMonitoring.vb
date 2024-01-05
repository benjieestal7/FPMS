Imports MySql.Data.MySqlClient
Imports System.IO
Imports CrystalDecisions.CrystalReports.Engine
Public Class FrmMonitoring

    Dim daGEJJ As New MySqlDataAdapter()
    Dim dsGEJJ As New DataSet()

    Dim file As String
    Function GetDirPath(ByVal file As String) As String
        Dim fi As New FileInfo(file)
        Return fi.Directory.ToString
    End Function

    Sub listrecord()
        Dim s As String = "select benef as `Lastname`,benefname as `FirstName`,midinitial as `Middle Initial`,address as `Address`, bdate as  `Birth Date`,weight as `Weight`,height as `Height`,sex as `Sex`,age as `Age`,bmi as `BMI`,nutstat as `Nutritional Status`,hfa as `Height-For-Age`, datescaled as `Date of Weighing` from beneficiaries_info where benef like '" + txtsearch.Text + "%'"

        Dim da As New MySqlDataAdapter(s, connect)
        connect.Open()
        Dim ds As New DataSet
        da.Fill(ds, "beneficiaries_info")
        da.Dispose()
        dgviewmon.DataSource = ds.Tables(0)
        connect.Close()

    End Sub

    Sub retsearch()
        Dim s As String = "select benef as `Lastname`,benefname as `FirstName`,midinitial as `Middle Initial`,address as `Address`, bdate as  `Birth Date`,weight as `Weight`,height as `Height`,sex as `Sex`,age as `Age`,bmi as `BMI`,nutstat as `Nutritional Status`,hfa as `Height-For-Age`, datescaled as `Date of Weighing` from beneficiaries_info where datescaled between '" & Format(dtfrom.Value, "yyyy/M/dd") & "' and '" & Format(dtto.Value, "yyyy/M/dd") & "' and benef  like '%" + txtsearch.Text + "%' or benefname like '%" + txtsearch.Text + "%' order by benef,benefname "

        Dim da As New MySqlDataAdapter(s, connect)
        connect.Open()
        Dim ds As New DataSet
        da.Fill(ds, "beneficiaries_info")
        da.Dispose()
        dgviewmon.DataSource = ds.Tables(0)
        connect.Close()
    End Sub

    Sub daily()
        Dim dt1 As Date = dtto.Text
        Dim dt2 As Date = dtfrom.Text
        Dim dt As New DataTable
        Dim source As New BindingSource
        Dim s As String = "select benef as `Lastname`,benefname as `FirstName`,address as `Address`, bdate as  `Birth Date`,weight as `Weight`,height as `Height`,sex as `Sex`,age as `Age`,bmi as `BMI`,nutstat as `Nutritional Status`,hfa as `Height-For-Age`, datescaled as `Date of Weighing` from beneficiaries_info"
        Dim cmd As New MySqlDataAdapter(s, connect)
        connect.Open()
        Dim ds As New DataSet
        cmd.Fill(ds, "beneficiaries_info")
        cmd.Dispose()
        source.DataSource = dt
        dgviewmon.DataSource = ds.Tables(0)
        connect.Close()
    End Sub

    Private Sub FrmMonitoring_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        retsearch()
    End Sub

    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        retsearch()
    End Sub

    Private Sub prntmon_Click(sender As Object, e As EventArgs) Handles prntmon.Click
        If txtsearch.Text = "" Then
            MsgBox("Please input Type", MsgBoxStyle.Information, "Feeding Program")
        Else
            FrmReportBenef.Show()

            dsGEJJ.Clear()
            Try
                With connect
                    If .State = ConnectionState.Open Then .Close()


                    connect.Open()
                End With
            Catch ex As MySqlException
                MsgBox(ex.ToString)
            End Try
            Try
                Dim qr As String = "select * from beneficiaries_info where datescaled  between '" & Format(dtfrom.Value, "yyyy/M/dd") & "' and '" & Format(dtto.Value, "yyyy/M/dd") & "' and benef  like '" & txtsearch.Text & "' order by datescaled "

                daGEJJ.SelectCommand = New MySqlCommand(qr, connect)

                Dim cb As MySqlCommandBuilder = New MySqlCommandBuilder(daGEJJ)

                daGEJJ.Fill(dsGEJJ, "beneficiaries_info")
                daGEJJ.Dispose()
            Catch ex As MySqlException
                MsgBox(ex.ToString)
            Finally
                connect.Close()
            End Try

            Dim cr As New monreport   'report name'
            cr.SetDataSource(dsGEJJ.Tables("beneficiaries_info"))
            FrmReportBenef.CrystalReportViewer1.ReportSource = cr
            FrmReportBenef.CrystalReportViewer1.Refresh()
            cr.Close()
            cr.Dispose()

        End If
    End Sub

    Private Sub btndaily_Click(sender As Object, e As EventArgs) Handles btndaily.Click
        If txtsearch.Text = "" Then
            MsgBox("Please input Type", MsgBoxStyle.Information, "Feeding Program")
        Else '
            retsearch()
        End If
    End Sub

    Private Sub clos_Click(sender As Object, e As EventArgs) Handles clos.Click
        Me.Close()
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class