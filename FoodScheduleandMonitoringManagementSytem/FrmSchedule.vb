Imports MySql.Data.MySqlClient
Imports System.IO
Public Class FrmSchedule

    Sub clear()
        loadidd()
        task.Text = ""
        venue.Text = ""
        faci.Text = ""
        schdate.Text = Date.Now
        timesched.Text = ""
        description.Text = ""
        task.Focus()
    End Sub

    Sub enableControl()
        task.Enabled = True
        venue.Enabled = True
        faci.Enabled = True
        schdate.Enabled = True
        timesched.Enabled = True
        description.Enabled = True
    End Sub

    Sub counter()
        Dim count As Integer
        For i As Integer = 0 To dgviewschedule.RowCount - 1
            count += 1
        Next
        tots.Text = count
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

    Sub loadidd()
        cod.Text = "FeedProgNo-" & Format(AutoID("schedule_info", "code"), "0000")
    End Sub

    Sub listrecord()
        Dim s As String = "select code as `Code`,task as `Task`, venue as  `Venue`,facilitator as `Facilitator`,schedate as `Date`,schetime as `Time`,description as `Description` from schedule_info order by task desc"

        Dim da As New MySqlDataAdapter(s, connect)
        connect.Open()
        Dim ds As New DataSet
        da.Fill(ds, "schedule_info")
        da.Dispose()
        dgviewschedule.DataSource = ds.Tables(0)
        connect.Close()
        dgviewschedule.AllowUserToAddRows = False
    End Sub


    Sub retsearch()
        Dim s As String = "select code as `Code`,task as `Task`, venue as  `Venue`,facilitator as `Facilitator`,schedate as `Date`, schetime as `Time`, description as `Description` from schedule_info where facilitator like '" + searchsched.Text + "%'"

        Dim da As New MySqlDataAdapter(s, connect)
        connect.Open()
        Dim ds As New DataSet
        da.Fill(ds, "schedule_info")
        da.Dispose()
        dgviewschedule.DataSource = ds.Tables(0)
        connect.Close()
    End Sub



    Private Sub savesched_Click(sender As Object, e As EventArgs) Handles savesched.Click
        If task.Text = "" Or venue.Text = "" Or faci.Text = "" Or schdate.Text = "" Or timesched.Text = "" Or description.Text = "" Then
            MsgBox("Fill the Missing Data!", MsgBoxStyle.Information, "System Checked")
            Return
        Else
            If MessageBox.Show("Save the changes?", "System Checked", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim s As String = "insert into schedule_info(code,task,venue,facilitator,schedate,schetime,description) values ('" & cod.Text & "','" & task.Text & "','" & venue.Text & "', '" & _
                                           faci.Text & "', '" & schdate.Value.ToString("yyyy/M/dd") & "', '" & timesched.Text & "', '" & description.Text & "')"
                Dim cmd As New MySqlCommand(s, connect)
                connect.Open()
                cmd.ExecuteNonQuery()
                MsgBox("Successfully Save!", MsgBoxStyle.Information, "System Checked")
                connect.Close()
                listrecord()
                counter()
                update.Enabled = False
                clear()
            End If
        End If
    End Sub

    Private Sub clearselectionsched_Click(sender As Object, e As EventArgs) Handles clearselectionsched.Click
        dgviewschedule.ClearSelection()
    End Sub

    Private Sub clr2_Click(sender As Object, e As EventArgs) Handles clr2.Click
        clear()
    End Sub

    Private Sub dgviewschedule_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgviewschedule.CellContentClick
        If dgviewschedule.RowCount = 0 Then
            MsgBox("Invalid Command!", MsgBoxStyle.Information, "System Checked")
            Return
        End If

        FrmBenefSched.code.Text = dgviewschedule.SelectedCells(0).Value
        FrmBenefSched.act.Text = dgviewschedule.SelectedCells(1).Value
        FrmBenefSched.ven.Text = dgviewschedule.SelectedCells(2).Value
        FrmBenefSched.fac.Text = dgviewschedule.SelectedCells(3).Value
        FrmBenefSched.dat.Text = dgviewschedule.SelectedCells(4).Value.ToString
        FrmBenefSched.oras.Text = dgviewschedule.SelectedCells(5).Value.ToString
        FrmBenefSched.desc.Text = dgviewschedule.SelectedCells(6).Value.ToString
        FrmBenefSched.Show()
    End Sub

    Private Sub FrmSchedule_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadidd()
        listrecord()
        counter()
    End Sub

    Private Sub searchsched_TextChanged(sender As Object, e As EventArgs) Handles searchsched.TextChanged
        retsearch()
    End Sub

    Private Sub clos_Click(sender As Object, e As EventArgs) Handles clos.Click
        Me.Close()
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub task_Leave(sender As Object, e As EventArgs) Handles task.Leave
        task.Text = StrConv(task.Text, VbStrConv.ProperCase)
    End Sub

    Private Sub venue_Leave(sender As Object, e As EventArgs) Handles venue.Leave
        venue.Text = StrConv(venue.Text, VbStrConv.ProperCase)
    End Sub

    Private Sub faci_KeyPress(sender As Object, e As KeyPressEventArgs) Handles faci.KeyPress

    End Sub

    Private Sub faci_Leave(sender As Object, e As EventArgs) Handles faci.Leave
        faci.Text = StrConv(faci.Text, VbStrConv.ProperCase)
    End Sub

    Private Sub edit_Click(sender As Object, e As EventArgs) Handles edit.Click
        If dgviewschedule.RowCount() = 0 Then
            MsgBox("Invalid Command!", MsgBoxStyle.Information, "System Checked")
            Return
        End If
        cod.Text = dgviewschedule.SelectedCells(0).Value
        task.Text = dgviewschedule.SelectedCells(1).Value
        venue.Text = dgviewschedule.SelectedCells(2).Value
        faci.Text = dgviewschedule.SelectedCells(3).Value
        schdate.Value = dgviewschedule.SelectedCells(4).Value
        timesched.Text = dgviewschedule.SelectedCells(5).Value
        description.Text = dgviewschedule.SelectedCells(6).Value
        update.Enabled = True
        savesched.Enabled = False
        enableControl()
    End Sub

    Private Sub update_Click(sender As Object, e As EventArgs) Handles update.Click
        If MessageBox.Show("Save the changes?", "System Checked", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim up As String = "Update schedule_info set task='" & task.Text & "',venue='" & venue.Text & _
            "',facilitator='" & faci.Text & "',schedate='" & schdate.Text & _
            "',schetime='" & timesched.Text & "', description='" & description.Text & "' WHERE code='" & cod.Text & "'"
            Dim cmd As New MySqlCommand(up, connect)
            connect.Open()
            cmd.ExecuteNonQuery()
            MsgBox("Successfully Updated!", MsgBoxStyle.Information, "System Checked")
            connect.Close()
            listrecord()
            clear()
        End If
    End Sub

    Private Sub description_TextChanged(sender As Object, e As EventArgs) Handles description.TextChanged

    End Sub
End Class