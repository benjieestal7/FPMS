Imports MySql.Data.MySqlClient
Public Class FrmBenefSched

    Private Sub FrmBenefSched_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listattendance()
        listrecord()
        counter()

    End Sub

    Sub counter()
        Dim count As Integer
        For i As Integer = 0 To dgviewbenefschedule.RowCount - 1
            count += 1
        Next
        total.Text = count
    End Sub

    Dim b As Boolean
    Dim t As String
    Private Sub lookrec(l As String)
        b = False
        Dim c As New MySqlCommand(l, connect)
        connect.Open()
        Dim d As MySqlDataReader = c.ExecuteReader
        If d.HasRows Then
            While d.Read
                b = True
            End While
        End If
        connect.Close()
    End Sub

    Private Sub lookrec1(l As String)
        b = False
        Dim c As New MySqlCommand(l, connect)
        connect.Open()
        Dim d As MySqlDataReader = c.ExecuteReader
        If d.HasRows Then
            While d.Read
                t = d(0).ToString
                If Not t = "00:00:00" Then
                    b = True
                End If
            End While
        End If
        connect.Close()
    End Sub


    Sub listrecord()
        Dim s As String = "select childIDD as `ID`,benef as `Name`, bdate as  `Birth Date`,sex as `Sex`,age as `Age` from beneficiaries_info order by benef desc"

        Dim da As New MySqlDataAdapter(s, connect)
        connect.Open()
        Dim ds As New DataSet
        da.Fill(ds, "beneficiaries_info")
        da.Dispose()
        dgviewbenefschedule.DataSource = ds.Tables(0)
        connect.Close()
    End Sub

    Sub listattendance()
        Dim temp As Double = 0
        Dim lt As String = "select attendee_info.attendeeID as `ID`, beneficiaries_info.benef as `Name`,attendee_info.actcode as `Activity Code`,attendee_info.det as `Date`,attendee_info.taymin as `Time Attended` from attendee_info,beneficiaries_info where ((attendee_info.attendeeID = beneficiaries_info.childIDD) and attendee_info.actcode = '" & code.Text & "') and (attendee_info.attendeeID like '%" + searchsched.Text + "%' and beneficiaries_info.childIDD like '%" + searchsched.Text + "%') order by beneficiaries_info.benef "
        Dim da As New MySqlDataAdapter(lt, connect)
        connect.Open()
        Dim ds As New DataSet
        da.Fill(ds, "beneficiaries_info,attendee_info")
        da.Dispose()
        dgviewattend.DataSource = ds.Tables(0)
        'disable the viewing of ID in datagrid
        'dgview.Columns(0).Visible = False
        connect.Close()
    End Sub

    Sub retsearch()
        Dim s As String = "select childIDD as `ID`,benef as `Name`, bdate as  `Birth Date`,sex as `Sex`,age as `Age` from beneficiaries_info where benef like '" + searchsched.Text + "%'"

        Dim da As New MySqlDataAdapter(s, connect)
        connect.Open()
        Dim ds As New DataSet
        da.Fill(ds, "beneficiaries_info")
        da.Dispose()
        dgviewbenefschedule.DataSource = ds.Tables(0)
        connect.Close()
    End Sub


    Private Sub searchsched_TextChanged(sender As Object, e As EventArgs) Handles searchsched.TextChanged
        retsearch()
        listattendance()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)
        listattendance()
    End Sub

    Private Sub dgviewbenefschedule_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgviewbenefschedule.CellMouseClick
        If dgviewbenefschedule.RowCount = 0 Then
            MsgBox("Invalid Command!", MsgBoxStyle.Information, "System Checked")
            Return
        End If
        Try
            If attend.Checked = True Then
                Dim l As String = "select taymin from attendee_info where attendeeID='" & dgviewbenefschedule.SelectedCells(0).Value & "' and actcode='" & code.Text & "'"
                lookrec(l)
                If (b = True) Then
                    MsgBox("Already Attended", MsgBoxStyle.Information, "System Checked")
                    b = False
                    Return
                End If
                Dim s As String = "insert into attendee_info(attendeeID,actcode,det,taymin)values('" & dgviewbenefschedule.SelectedCells(0).Value & "','" & code.Text & _
                "','" & Date.Now.ToString("yyyy/M/dd") & "','" & Date.Now.ToString("hh:mm:ss") & "')"
                cQuery(s)
            End If
            listattendance()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        dit.Text = Date.Now.Date
        tim.Text = TimeOfDay
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        dgviewattend.ClearSelection()
    End Sub

    Private Sub clearselectionsched_Click(sender As Object, e As EventArgs) Handles clearselectionsched.Click
        dgviewbenefschedule.ClearSelection()
    End Sub

    Private Sub del_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub
End Class