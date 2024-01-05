Imports MySql.Data.MySqlClient

Public Class FrmLogin

    Dim b As Boolean = False
    Sub scan()
        Dim benj As String = "123"
        Dim sc As String = "select * from user where Username='" & user.Text & "' and Password='" & pass.Text & "' and Position='" & combopos.Text & "'"
            Dim cmd As New MySqlCommand(sc, connect)
            connect.Open()
            Dim dr As MySqlDataReader = cmd.ExecuteReader
            If dr.HasRows Then
                While dr.Read
                    b = True
                End While
            End If
            connect.Close()
    End Sub

    Sub luser()
        Dim s As String = "select * from user where Username='" & user.Text & "' and Password='" & pass.Text & "'"
        Dim t As New MySqlCommand(s, connect)
        connect.Open()
        Dim d As MySqlDataReader = t.ExecuteReader
        If d.HasRows Then
            While d.Read
            End While
        End If
        connect.Close()
    End Sub

    Function AutoID(ByVal Tablename As String, ByVal Fieldname As String) As Int32
        Dim cmd As New MySqlCommand
        Dim dr1 As MySqlDataReader
        cmd.Connection = connect
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select " & Fieldname & " from " & Tablename & " Order by 1 Desc Limit 1 "
        If connect.State = ConnectionState.Closed Then connect.Open()
        dr1 = cmd.ExecuteReader
        If dr1.Read = True Then
            AutoID = Microsoft.VisualBasic.Right(dr1(0), 4) + 1
        Else
            AutoID = 1
        End If
        dr1.Close()
        connect.Close()
    End Function

    Sub incremid()
        myid.Text = Format(AutoID("log_info", "iddd"), "0000")
    End Sub

    Private Sub AUTOCOMPLETE()
        Dim benest As New DataTable
        Dim bench As New DataSet
        bench.Tables.Add(benest)
        Dim estal As New MySqlDataAdapter("Select Name from user", connect)
        estal.Fill(benest)
        Dim r As DataRow
        user.AutoCompleteCustomSource.Clear()
        For Each r In benest.Rows
            user.AutoCompleteCustomSource.Add(r.Item(0).ToString)
            'PARA NI SA PAG SEARCH BISAN WAKAY DGVIEW NGA GETAN AWAN FILTER NI SYA'
        Next
        connect.Close()
    End Sub

    Sub logins()
        Dim s As String = "insert into log_info(iddd,sd,fnme,intim,indat,user)values('" & myid.Text & "','" & combopos.Text & "','" & fanme.Text & "','" & tim.Text & "','" & dat.Text & "','" & user.Text & "')"
        Dim cmd As New MySqlCommand(s, connect)
        connect.Open()
        cmd.ExecuteNonQuery()
        connect.Close()
    End Sub

    Private Sub loginbtn_Click_1(sender As Object, e As EventArgs) Handles loginbtn.Click
        If combopos.Text = Nothing Or user.Text = Nothing Or pass.Text = Nothing Then
            MsgBox("Please fill out missing form", MsgBoxStyle.Exclamation, "Security")
            Return
        End If
        b = False
        scan()
        If b = True Then
            logins()
            Me.Hide()
            FrmWelcome.Show()
        Else
            MsgBox(" Account Doesnt Exist", MsgBoxStyle.Information, "System Checked")
            pass.Text = Nothing
            pass.Focus()
            Return
        End If
    End Sub

    Sub changepic()
        If b = True Then
            Picturebox1.Show()
        End If
    End Sub

    Sub pictures()
        Dim arrImage() As Byte
        Try
            Dim sql As String = "SELECT Name,Image FROM user WHERE Username= '" & user.Text & "'"
            Dim cmd As New MySqlCommand(sql, connect)
            connect.Open()
            Dim dr As MySqlDataReader = cmd.ExecuteReader
            If dr.HasRows Then
                While dr.Read
                    arrImage = dr.Item("Image")
                    Dim mstream As New System.IO.MemoryStream(arrImage)
                    Picturebox1.Image = Image.FromStream(mstream)

                End While
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try
        connect.Close()
    End Sub

    Sub searchname()
        Dim da As New MySqlDataAdapter("Select Name from user where Username = '" & user.Text & "';", connect)
        Dim benest As New DataSet
        da.Fill(benest)
        If benest.Tables(0).DefaultView.Count > 0 Then
            fanme.Text = benest.Tables(0).DefaultView.Item(0).Item(0)
        End If
    End Sub

    Sub searlog()
        Dim da As New MySqlDataAdapter("Select EmployeeID from user where Name = '" & user.Text & "' order by Name;", connect)
        Dim jink As New DataSet
        da.Fill(jink)
        If jink.Tables(0).DefaultView.Count > 0 Then
            frmMain.idemp.Text = jink.Tables(0).DefaultView.Item(0).Item(0)
        End If
    End Sub

    Private Sub user_TextChanged(sender As Object, e As EventArgs) Handles user.TextChanged
        pictures()
        searchname()
        AUTOCOMPLETE()
        searlog()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        dat.Text = Date.Now.Date
        tim.Text = TimeOfDay
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AUTOCOMPLETE()
        incremid()
        clr()
    End Sub
    Sub clr()
        user.Text = ""
        pass.Text = ""
    End Sub

End Class
