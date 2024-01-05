Imports MySql.Data.MySqlClient
Imports System.IO
Public Class FrmInformation

    Sub clear()
        loadidd()
        benef.Text = ""
        frstnem.Text = ""
        midint.Text = ""
        address.Text = ""
        birtd.Text = Date.Now
        weight.Text = ""
        height.Text = ""
        sex.Text = ""
        ag.Text = "0"
        bmi.Text = ""
        nutstat.Text = "N/A"
        hfa.Text = "N/A"
        dtscaled.Text = Date.Now
        benef.Focus()
    End Sub

    Sub enableControl()
        benef.Enabled = True
        frstnem.Enabled = True
        midint.Enabled = True
        address.Enabled = True
        birtd.Enabled = True
        weight.Enabled = True
        height.Enabled = True
        sex.Enabled = True
        bmi.Enabled = True
        nutstat.Enabled = True
        hfa.Enabled = True
        dtscaled.Enabled = True
    End Sub

    Sub counter()
        Dim count As Integer
        For i As Integer = 0 To dgviewinfo.RowCount - 1
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
        childid.Text = "ChildFPNo-" & Format(AutoID("beneficiaries_info", "childIDD"), "0000")
    End Sub

    Sub listrecord()
        Dim s As String = "select childIDD as `ID`, benef as `Lastname`,benefname as `FirstName`,midinitial as `Middle Initial`,address as `Address`, bdate as  `Birth Date`,weight as `Weight`,height as `Height`,sex as `Sex`,age as `Age`,bmi as `BMI`,nutstat as `Nutritional Status`,hfa as `Height-For-Age`, datescaled as `Date of Weighing` from beneficiaries_info order by benef desc"

        Dim da As New MySqlDataAdapter(s, connect)
        connect.Open()
        Dim ds As New DataSet
        da.Fill(ds, "beneficiaries_info")
        da.Dispose()
        dgviewinfo.DataSource = ds.Tables(0)
        connect.Close()

    End Sub

    Sub retsearch()
        Dim s As String = "select childIDD as `ID`, benef as `Lastname`,benefname as `FirstName`,midinitial as `Middle Initial`,address as `Address`, bdate as  `Birth Date`,weight as `Weight`,height as `Height`,sex as `Sex`,age as `Age`,bmi as `BMI`,nutstat as `Nutritional Status`,hfa as `Height-For-Age`, datescaled as `Date of Weighing` from beneficiaries_info where benef like '" + searchinfo.Text + "%'"

        Dim da As New MySqlDataAdapter(s, connect)
        connect.Open()
        Dim ds As New DataSet
        da.Fill(ds, "beneficiaries_info")
        da.Dispose()
        dgviewinfo.DataSource = ds.Tables(0)
        connect.Close()
    End Sub

    Sub calage()
        With birtd.Value
            Dim edad As DateTime = New DateTime(Now.Year, .Month, .Day)
            Dim age As Integer = Now.Year - .Year
            If edad > Now Then age -= 1
            ag.Text = CStr(age)
        End With
    End Sub

    Private Sub FrmInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listrecord()
        loadidd()
        counter()
    End Sub

    Private Sub saveinfo_Click(sender As Object, e As EventArgs) Handles saveinfo.Click
        If benef.Text = "" Or frstnem.Text = "" Or midint.Text = "" Or birtd.Text = "" Or weight.Text = "" Or height.Text = "" Or sex.Text = "" Then
            MsgBox("Fill the Missing Data!", MsgBoxStyle.Information, "System Checked")
            Return
        Else
            If MessageBox.Show("Save the changes?", "System Checked", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim s As String = "insert into beneficiaries_info(childIDD,benef,benefname,midinitial,address,bdate,weight,height,sex,age,bmi,nutstat,hfa,datescaled) values ('" & childid.Text & "','" & benef.Text & "','" & frstnem.Text & "','" & midint.Text & "','" & address.Text & "','" & birtd.Value.ToString("yyyy/M/dd") & "', '" & _
                                           weight.Text & "', '" & height.Text & "', '" & sex.Text & "', '" & ag.Text & "', '" & bmi.Text & "', '" & nutstat.Text & "', '" & hfa.Text & "', '" & dtscaled.Value.ToString("yyyy/M/dd") & "')"
                Dim cmd As New MySqlCommand(s, connect)
                connect.Open()
                cmd.ExecuteNonQuery()
                MsgBox("Successfully Added!", MsgBoxStyle.Information, "System Checked")
                connect.Close()
                listrecord()
                loadidd()
                counter()
                updinfo.Enabled = False
                clear()
            End If
        End If
    End Sub

    Private Sub birtd_ValueChanged(sender As Object, e As EventArgs) Handles birtd.ValueChanged
        calage()
    End Sub

    Private Sub updinfo_Click(sender As Object, e As EventArgs) Handles updinfo.Click
        If MessageBox.Show("Save the changes?", "System Checked", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim up As String = "Update beneficiaries_info set benef='" & benef.Text & "',benefname='" & frstnem.Text & "',midinitial='" & midint.Text & "',address='" & address.Text & "',bdate='" & birtd.Text & _
            "',weight='" & weight.Text & "',height='" & height.Text & _
            "',age='" & ag.Text & "',bmi='" & bmi.Text & "',nutstat='" & nutstat.Text & "',hfa='" & hfa.Text & "',datescaled='" & dtscaled.Text & "' WHERE childIDD='" & childid.Text & "'"
            Dim cmd As New MySqlCommand(up, connect)
            connect.Open()
            cmd.ExecuteNonQuery()
            MsgBox("Successfully Updated!", MsgBoxStyle.Information, "System Checked")
            connect.Close()
            listrecord()
            clear()
        End If
    End Sub

    Private Sub searchinfo_TextChanged(sender As Object, e As EventArgs) Handles searchinfo.TextChanged
        loadidd()
        retsearch()
    End Sub

    Private Sub dgviewinfo_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgviewinfo.CellContentClick
        loadidd()
        listrecord()
    End Sub

    Private Sub bmi_TextChanged(sender As Object, e As EventArgs) Handles bmi.TextChanged
        If Val(bmi.Text) <= 9 Then
            nutstat.Text = "Severely Wasted"

        ElseIf Val(bmi.Text) <= 13 Then
            nutstat.Text = "Wasted"

        ElseIf Val(bmi.Text) <= 20 Then
            nutstat.Text = " Normal"

        ElseIf Val(bmi.Text) <= 25 Then
            nutstat.Text = "Overweight"

        ElseIf Val(bmi.Text) >= 26 Then
            nutstat.Text = "Obese"
        End If
    End Sub

    Private Sub clrininfo_Click(sender As Object, e As EventArgs) Handles clrininfo.Click
        clear()
    End Sub

    Private Sub editinfo_Click(sender As Object, e As EventArgs) Handles editinfo.Click
        If dgviewinfo.RowCount() = 0 Then
            MsgBox("Invalid Command!", MsgBoxStyle.Information, "System Checked")
            Return
        End If
        childid.Text = dgviewinfo.SelectedCells(0).Value
        benef.Text = dgviewinfo.SelectedCells(1).Value
        frstnem.Text = dgviewinfo.SelectedCells(2).Value
        midint.Text = dgviewinfo.SelectedCells(3).Value
        address.Text = dgviewinfo.SelectedCells(4).Value
        birtd.Text = dgviewinfo.SelectedCells(5).Value
        weight.Text = dgviewinfo.SelectedCells(6).Value
        height.Text = dgviewinfo.SelectedCells(7).Value
        sex.Text = dgviewinfo.SelectedCells(8).Value
        ag.Text = dgviewinfo.SelectedCells(9).Value
        bmi.Text = dgviewinfo.SelectedCells(10).Value
        nutstat.Text = dgviewinfo.SelectedCells(11).Value
        hfa.Text = dgviewinfo.SelectedCells(12).Value
        dtscaled.Text = dgviewinfo.SelectedCells(13).Value
        saveinfo.Enabled = False
        updinfo.Enabled = True
        enableControl()
    End Sub

    Private Sub clearselection_Click(sender As Object, e As EventArgs) Handles clearselection.Click
        dgviewinfo.ClearSelection()
    End Sub

    Private Sub addnew_Click(sender As Object, e As EventArgs) Handles addnew.Click
        saveinfo.Enabled = True
        loadidd()
        updinfo.Enabled = False
        benef.Text = Nothing
        frstnem.Text = Nothing
        midint.Text = Nothing
        address.Text = Nothing
        birtd.Text = Date.Now
        weight.Text = Nothing
        height.Text = Nothing
        sex.Text = Nothing
        ag.Text = "0"
        bmi.Text = "0"
        nutstat.Text = "N/A"
        hfa.Text = "N/A"
        dtscaled.Text = Date.Now
        benef.Focus()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles unit.Click
        FrmConversion.Show()
    End Sub

    Private Sub sex_SelectedIndexChanged(sender As Object, e As EventArgs) Handles sex.SelectedIndexChanged
        If Not (height.Text = Nothing) Then
            Dim w = weight.Text
            Dim h = height.Text
            Dim bm = w / (h * h)
            bmi.Text = Math.Round(Val(bm), 2)
        End If

    End Sub 
    Private Sub height_TextChanged(sender As Object, e As EventArgs) Handles height.TextChanged
        If Val(height.Text) <= 0.72 Then
            hfa.Text = "Severely Stunted"

        ElseIf Val(height.Text) <= 0.91 Then
            hfa.Text = "Stunted"

        ElseIf Val(height.Text) <= 1.11 Then
            hfa.Text = "Normal"

        ElseIf Val(height.Text) <= 1.12 Then
            hfa.Text = "Tall"
        End If
    End Sub

    Private Sub benef_Leave(sender As Object, e As EventArgs) Handles benef.Leave
        benef.Text = StrConv(benef.Text, VbStrConv.ProperCase)
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub clos_Click(sender As Object, e As EventArgs) Handles clos.Click
        Me.Close()
    End Sub

    Private Sub frstnem_Leave(sender As Object, e As EventArgs) Handles frstnem.Leave
        frstnem.Text = StrConv(frstnem.Text, VbStrConv.ProperCase)
    End Sub

    Private Sub address_Leave(sender As Object, e As EventArgs) Handles address.Leave
        address.Text = StrConv(address.Text, VbStrConv.ProperCase)
    End Sub

    Private Sub midint_Leave(sender As Object, e As EventArgs) Handles midint.Leave
        midint.Text = StrConv(midint.Text, VbStrConv.ProperCase)
    End Sub
End Class