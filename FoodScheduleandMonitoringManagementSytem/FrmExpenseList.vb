Imports MySql.Data.MySqlClient
Imports System.IO
Public Class FrmExpenseList

    Sub clear()
        aytem.Text = ""
        prays.Text = ""
        quan.Text = ""
        aytem.Focus()
    End Sub

    Sub enableControl()
        aytem.Enabled = True
        prays.Enabled = True
        quan.Enabled = True
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
        itemid.Text = "ItemNo-" & Format(AutoID("expense_info", "itemno"), "0000")
    End Sub

    Private Sub addn_Click(sender As Object, e As EventArgs)
        loadidd()
        registerbtn2.Enabled = True
        aytem.Text = Nothing
        prays.Text = Nothing
        aytem.Focus()
    End Sub

    Private Sub registerbtn2_Click(sender As Object, e As EventArgs) Handles registerbtn2.Click
        If aytem.Text = "" Or prays.Text = "" Or quan.Text = "" Then
            MsgBox("Fill the Missing Data!", MsgBoxStyle.Information, "System Checked")
            Return
        Else
            If MessageBox.Show("Save the changes?", "System Checked", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim s As String = "insert into expense_info(itemno,item,price,quantity,equal) values ('" & itemid.Text & "', '" & aytem.Text & "', '" & prays.Text & "', '" & _
                                            quan.Text & "','" & sum.Text & "')"
                Dim cmd As New MySqlCommand(s, connect)
                connect.Open()
                cmd.ExecuteNonQuery()
                MsgBox("Successfully Recorded!", MsgBoxStyle.Information, "System Checked")
                connect.Close()
                loadidd()
                clear()
            End If
        End If
    End Sub

    Private Sub FrmExpenseList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadidd()
    End Sub

    Private Sub update_Click(sender As Object, e As EventArgs)
        If MessageBox.Show("Save the changes?", "System Checked", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim up As String = "Update expense_info set item='" & aytem.Text & "',price='" & prays.Text & _
            "',quantity='" & quan.Text & "',equal='" & sum.Text & "' WHERE itemno='" & itemid.Text & "'"

            Dim cmd As New MySqlCommand(up, connect)
            connect.Open()
            cmd.ExecuteNonQuery()
            MsgBox("Successfully Updated!", MsgBoxStyle.Information, "System Checked")
            connect.Close()
            loadidd()
        End If
    End Sub

    Private Sub aytem_Leave(sender As Object, e As EventArgs) Handles aytem.Leave
        aytem.Text = StrConv(aytem.Text, VbStrConv.ProperCase)
    End Sub

    Private Sub prays_TextChanged(sender As Object, e As EventArgs) Handles prays.TextChanged
        If IsNumeric(prays.Text) Then
            'do nothing 
        Else
            prays.Text = ""
        End If
    End Sub

    Private Sub quan_TextChanged(sender As Object, e As EventArgs) Handles quan.TextChanged
        If IsNumeric(quan.Text) Then
            'do nothing 
        Else
            quan.Text = ""
        End If
        If Not (quan.Text = Nothing) Then
            Dim p = prays.Text
            Dim q = quan.Text
            Dim equalss = (p * q)
            sum.Text = Math.Round(Val(equalss), 2)
        End If
    End Sub
End Class