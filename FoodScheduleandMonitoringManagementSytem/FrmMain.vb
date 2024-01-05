Imports MySql.Data.MySqlClient
Imports System.IO
Public Class FrmMain


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles adduser.Click
        ' panelview.Controls.Clear()
        '  FrmAccount.TopLevel = False
        FrmAccount.Show()
        ' panelview.Controls.Add(FrmAccount)
        FrmAccount.update.Enabled = False

    End Sub
    Sub mypicture()
        Dim arrImage() As Byte
        Try
            Dim sql As String = "SELECT Name,Image FROM user WHERE Username= '" & FrmLogin.user.Text & "'"
            Dim cmd As New MySqlCommand(sql, connect)
            connect.Open()
            Dim dr As MySqlDataReader = cmd.ExecuteReader
            If dr.HasRows Then
                While dr.Read
                    arrImage = dr.Item("Image")
                    Dim mstream As New System.IO.MemoryStream(arrImage)
                    userpicture.Image = Image.FromStream(mstream)
                End While
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try
        connect.Close()
    End Sub

    Private Sub logout_Click(sender As Object, e As EventArgs) Handles logout.Click
        If MessageBox.Show("Do you want to log out session?", "Feeding Program Management", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            updtlog()
        Else
            MsgBox("Operation Cancelled !!")
        End If
    End Sub

    Sub myname()
        Dim da As New MySqlDataAdapter("Select Name from user where Username = '" & FrmLogin.user.Text & "';", connect)
        Dim benest As New DataSet
        da.Fill(benest)
        If benest.Tables(0).DefaultView.Count > 0 Then
            username.Text = benest.Tables(0).DefaultView.Item(0).Item(0)
        End If
    End Sub

    Sub updtlog()
        Dim s As String = "update log_info set outtim='" & tim.Text & "',outdat='" & dat.Text & "' where iddd='" & idemp.Text & "'"
        Dim cmd As New MySqlCommand(s, connect)
        connect.Open()
        cmd.ExecuteNonQuery()
        connect.Close()
        Me.Close()
        frmLogIn.Show()
        FrmLogin.user.Text = ""
        FrmLogin.pass.Text = ""
    End Sub

    Private Sub schedule_Click(sender As Object, e As EventArgs) Handles schedule.Click
        FrmSchedule.Show()
        FrmSchedule.update.Enabled = False
    End Sub

    Private Sub btnfinance_Click(sender As Object, e As EventArgs) Handles btnfinance.Click
        FrmFinance.Show()
        FrmFinance.update.Enabled = False
    End Sub

    Private Sub addinfo_Click(sender As Object, e As EventArgs) Handles addinfo.Click
        FrmInformation.Show()
        FrmInformation.updinfo.Enabled = False
    End Sub

    Private Sub dashb_Click(sender As Object, e As EventArgs) Handles dashb.Click
        panelview.Controls.Clear()
        FrmDashboard.TopLevel = False
        FrmDashboard.Show()
        panelview.Controls.Add(FrmDashboard)
    End Sub

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        idemp.Text = (FrmLogin.myid.Text)
        mypicture()
        myname()
        type.Text = (FrmLogin.combopos.Text)
        panelview.Controls.Clear()
        FrmDashboard.TopLevel = False
        FrmDashboard.Show()
        panelview.Controls.Add(FrmDashboard)
    End Sub

    Private Sub clos_Click(sender As Object, e As EventArgs) Handles clos.Click
        Me.Close()
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnreport_Click(sender As Object, e As EventArgs) Handles btnreport.Click
        panelview.Controls.Clear()
        FrmReport.TopLevel = False
        FrmReport.Show()
        panelview.Controls.Add(FrmReport)
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        panelview.Controls.Clear()
        FrmReport.TopLevel = False
        FrmReport.Show()
        panelview.Controls.Add(FrmReport)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FrmSchedule.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        FrmFinance.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        FrmAccount.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        dat.Text = Date.Now.Date
        tim.Text = TimeOfDay
    End Sub

    Private Sub log_Click(sender As Object, e As EventArgs) Handles log.Click
        panelview.Controls.Clear()
        FrmUserLog.TopLevel = False
        FrmUserLog.Show()
        panelview.Controls.Add(FrmUserLog)
    End Sub

    Private Sub benefmonitoring_Click(sender As Object, e As EventArgs) Handles benefmonitoring.Click
        FrmMonitoring.Show()
    End Sub
End Class