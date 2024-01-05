Imports MySql.Data.MySqlClient
Public Class FrmWelcome

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        progressbar()
    End Sub

    Sub progressbar()
        Timer1.Enabled = True
        ProgressBar1.Increment(1)
        If ProgressBar1.Value = 100 Then
            Me.Close()
            Timer1.Enabled = False
            FrmMain.Show()
            MsgBox("Welcome " + FrmMain.type.Text + "  Have a Nice Day Ahead!")
        ElseIf FrmLogin.combopos.Text = "Health Worker" Then
            FrmMain.adduser.Enabled = False
            FrmMain.btnfinance.Enabled = False
            Me.Close()
            Timer1.Enabled = False
            FrmMain.Show()
            MsgBox("Welcome " + FrmMain.type.Text + "  Have a Nice Day Ahead!")
        ElseIf FrmLogin.combopos.Text = "DayCare Worker" Then
            FrmMain.adduser.Enabled = False
            FrmMain.benefmonitoring.Enabled = False
            FrmMain.btnfinance.Enabled = False
            FrmMain.schedule.Enabled = False
            Me.Close()
            Timer1.Enabled = False
            FrmMain.Show()
            MsgBox("Welcome " + FrmMain.type.Text + "  Have a Nice Day Ahead!")
        End If
    End Sub

End Class