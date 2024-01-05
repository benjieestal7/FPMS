Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Drawing.Imaging
Imports System.Security.Cryptography

Public Class FrmAccount

    Sub clear()
        nicnum.Text = Nothing
        fullname.Text = Nothing
        cmbgender.Text = Nothing
        position.Text = Nothing
        user.Text = Nothing
        pass.Text = Nothing
        nicnum.Focus()
    End Sub

    Sub enableControl()
        nicnum.Enabled = True
        fullname.Enabled = True
        cmbgender.Enabled = True
        position.Enabled = True
        user.Enabled = True
        pass.Enabled = True
    End Sub

    Sub counter()
        Dim count As Integer
        For i As Integer = 0 To dgview.RowCount - 1
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
        nicnum.Text = "EmployeeNo-" & Format(AutoID("user", "EmployeeID"), "0000")
    End Sub
   Sub listrecord()
        Dim s As String = "select EmployeeID as `Employee ID`, Name as  `Name`,Gender as `Gender`,Position as `Position`,Username as `Username`,Password as `Password` from user order by Name desc"

        Dim da As New MySqlDataAdapter(s, connect)
        connect.Open()
        Dim ds As New DataSet
        da.Fill(ds, "user")
        da.Dispose()
        dgview.DataSource = ds.Tables(0)
        connect.Close()
    End Sub

    Sub retsearch()
        Dim s As String = "select EmployeeID as `Employee ID`, Name as  `Name`,Gender as `Gender`,Position as `Position`,Username as `Username`,Password as `Password` from user where Name like '" + search.Text + "%'"

        Dim da As New MySqlDataAdapter(s, connect)
        connect.Open()
        Dim ds As New DataSet
        da.Fill(ds, "schedule_info")
        da.Dispose()
        dgview.DataSource = ds.Tables(0)
        connect.Close()
    End Sub

    Sub updateimage()
        Dim FileSize As UInt64
        Dim mstream As New System.IO.MemoryStream()
        pic.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
        Dim arrImage() As Byte = mstream.GetBuffer()
        FileSize = mstream.Length
        mstream.Close()
        Dim u As String = "Update user set Image= @image_data where EmployeeID='" & nicnum.Text & "'"
        Dim cmd As New MySqlCommand(u, connect)
        connect.Open()
        cmd.Parameters.AddWithValue("@image_data", arrImage)
        cmd.ExecuteNonQuery()
        connect.Close()
    End Sub

    Private Sub registerbtn2_Click(sender As Object, e As EventArgs) Handles registerbtn2.Click
        If nicnum.Text = "" Or fullname.Text = "" Or cmbgender.Text = "" Or position.Text = "" Or user.Text = "" Or pass.Text = "" Then
            MsgBox("Fill the Missing Data!", MsgBoxStyle.Information, "System Checked")
            Return
        Else
            If MessageBox.Show("Save the changes?", "System Checked", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim s As String = "insert into user(EmployeeID,Name,Gender,Position,Username,Password) values ('" & nicnum.Text & "','" & fullname.Text & "', '" & _
                                           cmbgender.Text & "', '" & position.Text & "', '" & user.Text & "', '" & pass.Text & "')"
                Dim cmd As New MySqlCommand(s, connect)
                connect.Open()
                cmd.ExecuteNonQuery()
                MsgBox("Successfully Registered!", MsgBoxStyle.Information, "System Checked")
                connect.Close()
                listrecord()
                counter()
                updateimage()
                update.Enabled = False
                clear()
            End If
        End If
    End Sub


    Private Sub clearselection_Click(sender As Object, e As EventArgs) Handles clearselection.Click
        dgview.ClearSelection()
    End Sub

    Private Sub search_TextChanged(sender As Object, e As EventArgs) Handles search.TextChanged
        retsearch()
    End Sub

    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click
        If dgview.RowCount() = 0 Then
            MsgBox("Invalid Command!", MsgBoxStyle.Information, "System Checked")
            Return
        End If

        nicnum.Text = dgview.SelectedCells(0).Value
        fullname.Text = dgview.SelectedCells(1).Value
        cmbgender.Text = dgview.SelectedCells(2).Value
        position.Text = dgview.SelectedCells(3).Value
        user.Text = dgview.SelectedCells(4).Value
        pass.Text = dgview.SelectedCells(5).Value
        registerbtn2.Enabled = False
        update.Enabled = True
        enableControl()
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click

        If dgview.RowCount() = 0 Then
            MsgBox("Invalid Command!", MsgBoxStyle.Information, "System Checked")
            Return
        End If
        If MessageBox.Show("Delete the record?", "System Checked", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim d As String = "Delete from user where EmployeeID = '" & dgview.SelectedCells(0).Value & "'"
            Dim cmd As New MySqlCommand(d, connect)
            connect.Open()
            cmd.ExecuteNonQuery()
            MsgBox("Successfully Deleted!", MsgBoxStyle.Information, "System Checked")
            connect.Close()
            listrecord()
        End If
    End Sub


    Private Sub showpass_CheckedChanged(sender As Object, e As EventArgs) Handles showpass.CheckedChanged
        If showpass.Checked = True Then
            pass.PasswordChar = ""
        Else
            pass.PasswordChar = "*"
        End If
    End Sub


    Private Sub fullname_Leave(sender As Object, e As EventArgs) Handles fullname.Leave
        fullname.Text = StrConv(fullname.Text, VbStrConv.ProperCase)
    End Sub



    Private Function resizeImage(ByVal img As Image, ByVal w As Integer, ByVal h As Integer) As Image
        Try
            Dim newImageSize As New Bitmap(w, h)
            Using g As Graphics = Graphics.FromImage(newImageSize)
                g.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
                g.DrawImage(img, New Rectangle(0, 0, w, h))
            End Using
            Return newImageSize
        Catch ex As Exception
            MsgBox(ex.ToString)
            Return Nothing
        End Try
        Return Nothing
    End Function

    Private Sub FrmAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadidd()
        listrecord()
        counter()
    End Sub


    Private Sub edit_Click(sender As Object, e As EventArgs) Handles edit.Click
        If dgview.RowCount() = 0 Then
            MsgBox("Invalid Command!", MsgBoxStyle.Information, "System Checked")
            Return
        End If

        nicnum.Text = dgview.SelectedCells(0).Value
        fullname.Text = dgview.SelectedCells(1).Value
        cmbgender.Text = dgview.SelectedCells(2).Value
        position.Text = dgview.SelectedCells(3).Value
        user.Text = dgview.SelectedCells(4).Value
        pass.Text = dgview.SelectedCells(5).Value
        registerbtn2.Enabled = False
        update.Enabled = True
        enableControl()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If dgview.RowCount() = 0 Then
            MsgBox("Invalid Command!", MsgBoxStyle.Information, "System Checked")
            Return
        End If
        If MessageBox.Show("Delete the record?", "System Checked", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim d As String = "Delete from user where EmployeeID = '" & dgview.SelectedCells(0).Value & "'"
            Dim cmd As New MySqlCommand(d, connect)
            connect.Open()
            cmd.ExecuteNonQuery()
            MsgBox("Successfully Deleted!", MsgBoxStyle.Information, "System Checked")
            connect.Close()
            listrecord()
            counter()
        End If
    End Sub

    Private Sub pic_Click(sender As Object, e As EventArgs) Handles pic.Click
        Try
            Dim fopen As New OpenFileDialog
            fopen.FileName = ""
            fopen.Filter = "Image Files (*.jpg)|*.jpg|(*.jpeg)|*.JPEG|(*.gif)|*.gif|(*.png)|*.png|All Files (*.*)|*.*"
            fopen.ShowDialog()
            pic.Image = System.Drawing.Bitmap.FromFile(fopen.FileName)
            pic.Text = fopen.FileName
        Catch ex As Exception

        End Try
    End Sub

    Private Sub update_Click(sender As Object, e As EventArgs) Handles update.Click
        If MessageBox.Show("Save the changes?", "System Checked", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim up As String = "Update user set Name='" & fullname.Text & "',Gender='" & cmbgender.Text & _
            "',Position='" & position.Text & "',Username='" & user.Text & _
            "',Password='" & pass.Text & "' WHERE EmployeeID='" & nicnum.Text & "'"
            Dim cmd As New MySqlCommand(up, connect)
            connect.Open()
            cmd.ExecuteNonQuery()
            MsgBox("Successfully Updated!", MsgBoxStyle.Information, "System Checked")
            connect.Close()
            updateimage()
            listrecord()
        End If
    End Sub

    Private Sub clr_Click(sender As Object, e As EventArgs) Handles clr.Click
        fullname.Text = Nothing
        cmbgender.Text = Nothing
        position.Text = Nothing
        user.Text = Nothing
        pass.Text = Nothing
    End Sub

    Private Sub addnew_Click(sender As Object, e As EventArgs) Handles addnew.Click
        loadidd()
        registerbtn2.Enabled = True
        update.Enabled = False
        fullname.Text = Nothing
        cmbgender.Text = Nothing
        position.Text = Nothing
        user.Text = Nothing
        pass.Text = Nothing
        fullname.Focus()
    End Sub



    Private Sub dgview_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgview.CellFormatting
        If e.ColumnIndex = 5 Then
            If e.Value IsNot Nothing Then
                e.Value = New String("*", e.Value.ToString().Length)
            End If
        End If
    End Sub

    Private Sub clos_Click(sender As Object, e As EventArgs) Handles clos.Click
        Me.Close()
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

End Class