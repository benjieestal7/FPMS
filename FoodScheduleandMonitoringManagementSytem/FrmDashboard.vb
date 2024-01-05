Imports MySql.Data.MySqlClient
Imports System.IO
Public Class FrmDashboard

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        FrmInformation.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        FrmSchedule.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        FrmFinance.Show()
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs)
        FrmAccount.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        FrmReport.Show()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        dat.Text = Date.Now.Date
        tim.Text = TimeOfDay
    End Sub

    Private Sub FrmDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer3.Start()
        'Dim con As New MySqlConnection
        Dim beneficiary_cmd, schedule_cmd, budget_cmd, employee_cmd, log_cmd As New MySqlCommand
        ' con.ConnectionString = "Server=localhost;password=;user=root;database=fpms;"
        connect.Open()

        Try
            Dim beneficary_query As String = "SELECT count(*) FROM beneficiaries_info"
            beneficiary_cmd = New MySqlCommand(beneficary_query, connect)
            Dim beneficiary_count As String
            beneficiary_count = beneficiary_cmd.ExecuteScalar()

            Dim schedule_query As String = "SELECT count(*) FROM schedule_info"
            schedule_cmd = New MySqlCommand(schedule_query, connect)
            Dim schedule_count As String
            schedule_count = schedule_cmd.ExecuteScalar()

            Dim budget_query As String = "SELECT count(*) FROM budget_info"
            budget_cmd = New MySqlCommand(budget_query, connect)
            Dim budget_count As String
            budget_count = budget_cmd.ExecuteScalar()

            Dim employee_query As String = "SELECT count(*) FROM user"
            employee_cmd = New MySqlCommand(employee_query, connect)
            Dim employee_count As String
            employee_count = employee_cmd.ExecuteScalar()

            Dim log_query As String = "SELECT count(*) FROM log_info"
            log_cmd = New MySqlCommand(log_query, connect)
            Dim log_count As String
            log_count = log_cmd.ExecuteScalar()

            bene.Text = beneficiary_count
            sched.Text = schedule_count
            bud.Text = budget_count
            emp.Text = employee_count
            log.Text = log_count

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        connect.Close()
        type.Text = (FrmLogin.combopos.Text)
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        If pic1.Visible = True Then
            pic1.Visible = False
            pic2.Visible = True
        ElseIf pic2.Visible = True Then
            pic2.Visible = False
            pic3.Visible = True
        ElseIf pic3.Visible = True Then
            pic3.Visible = False
            pic1.Visible = True
        End If
    End Sub

    Private Sub Panel8_Paint(sender As Object, e As PaintEventArgs) Handles Panel8.Paint

    End Sub
End Class