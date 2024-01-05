Imports MySql.Data.MySqlClient
Public Class serverconnection

    Dim Stat As Boolean = False

    Private Sub clos_Click(sender As Object, e As EventArgs) Handles clos.Click
        Me.Close()
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub loginbtn_Click(sender As Object, e As EventArgs) Handles loginbtn.Click
        Try
            connect = New MySqlConnection
            connect.ConnectionString = "Server=" & server.Text & ";Database=" & database.Text & ";User ID=" & userid.Text & ";Password=" & password.Text & ""
            connect.Open()
            MessageBox.Show("Successfully Connected to Server!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)
            connect.Close()
            Stat = True
            My.Settings.host = server.Text
            My.Settings.dbname = database.Text
            My.Settings.usid = userid.Text
            My.Settings.pwd = password.Text

            Call setconnection()
            Me.Hide()
            FrmLogin.Show()
            Exit Sub
        Catch ex As Exception
            ex.ToString()
        End Try
        Stat = False
        MessageBox.Show("Connection Failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class