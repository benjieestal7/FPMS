Imports MySql.Data.MySqlClient
Imports System.IO
Public Class FrmFinance

    Sub clear()
        loadidd()
        activ.Text = ""
        money.Text = ""
        expense.Text = ""
        sum.Text = "0"
        dtdate.Text = Date.Now
        activ.Focus()
    End Sub

    Sub enableControl()
        money.Enabled = True
        dtdate.Enabled = True
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
        budid.Text = "BudFGNo-" & Format(AutoID("budget_info", "budgetID"), "0000")
    End Sub

    Sub retsearch()
        Dim s As String = "select budgetID as `Budget ID`, actvity as  `Activity`,money as `Budget Money`,expense as `Expense Amount`, sum as `Remaining Budget`, transacDet as `Transaction Date` from budget_info where actvity like '" + searchmon.Text + "%'"

        Dim da As New MySqlDataAdapter(s, connect)
        connect.Open()
        Dim ds As New DataSet
        da.Fill(ds, "budget_info")
        da.Dispose()
        dgviewbudget.DataSource = ds.Tables(0)
        connect.Close()
    End Sub


    Sub listrecord()
        Dim s As String = "select budgetID as `Budget ID`, actvity as  `Activity`,money as `Budget Money`,expense as `Expense Amount`, sum as `Remaining Budget`, transacDet as `Transaction Date` from budget_info order by actvity desc"

        Dim da As New MySqlDataAdapter(s, connect)
        connect.Open()
        Dim ds As New DataSet
        da.Fill(ds, "budget_info")
        da.Dispose()
        dgviewbudget.DataSource = ds.Tables(0)
        connect.Close()

    End Sub

    Private Sub registerbtn2_Click(sender As Object, e As EventArgs) Handles registerbtn2.Click
        If activ.Text = "" Or money.Text = "" Or expense.Text = "" Or sum.Text = "" Or dtdate.Text = "" Then
            MsgBox("Fill the Missing Data!", MsgBoxStyle.Information, "System Checked")
            Return
        Else
            If MessageBox.Show("Save the changes?", "System Checked", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim s As String = "insert into budget_info(budgetID,actvity,money,expense,sum,transacDet) values ('" & budid.Text & "', '" & activ.Text & "', '" & money.Text & "', '" & expense.Text & "', '" & sum.Text & "', '" & _
                                            dtdate.Value.ToString("yyyy/M/dd") & "')"
                Dim cmd As New MySqlCommand(s, connect)
                connect.Open()
                cmd.ExecuteNonQuery()
                MsgBox("Successfully Recorded!", MsgBoxStyle.Information, "System Checked")
                connect.Close()
                listrecord()
                update.Enabled = False
                clear()
            End If
        End If
    End Sub

    Private Sub clearselection_Click(sender As Object, e As EventArgs) Handles clearselection.Click
        dgviewbudget.ClearSelection()
    End Sub

    Private Sub calcu_Click(sender As Object, e As EventArgs)
        FrmExpenseList.Show()
    End Sub

    Private Sub clr_Click(sender As Object, e As EventArgs) Handles clr.Click
        clear()
    End Sub

    Private Sub update_Click(sender As Object, e As EventArgs) Handles update.Click
        If MessageBox.Show("Save the changes?", "System Checked", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim up As String = "Update budget_info set actvity='" & activ.Text & "',money='" & money.Text & "',expense='" & expense.Text & "',sum='" & sum.Text &
            "',transacDet='" & dtdate.Text & "' WHERE budgetID='" & budid.Text & "'"

            Dim cmd As New MySqlCommand(up, connect)
            connect.Open()
            cmd.ExecuteNonQuery()
            MsgBox("Successfully Updated!", MsgBoxStyle.Information, "System Checked")
            connect.Close()
            listrecord()
            clear()
        End If
    End Sub

    Private Sub det_Click(sender As Object, e As EventArgs) Handles det.Click
        If dgviewbudget.RowCount() = 0 Then
            MsgBox("Invalid Command!", MsgBoxStyle.Information, "System Checked")
            Return
        End If
        budid.Text = dgviewbudget.SelectedCells(0).Value
        activ.Text = dgviewbudget.SelectedCells(1).Value
        money.Text = dgviewbudget.SelectedCells(2).Value
        expense.Text = dgviewbudget.SelectedCells(3).Value
        sum.Text = dgviewbudget.SelectedCells(4).Value
        dtdate.Value = dgviewbudget.SelectedCells(5).Value
        registerbtn2.Enabled = False
        update.Enabled = True
        enableControl()
    End Sub

    Private Sub FrmFinance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadidd()
        listrecord()
    End Sub

    Private Sub searchmon_TextChanged(sender As Object, e As EventArgs) Handles searchmon.TextChanged
        retsearch()
    End Sub

    Private Sub addn_Click(sender As Object, e As EventArgs) Handles addn.Click
        loadidd()
        registerbtn2.Enabled = True
        update.Enabled = False
        activ.Text = Nothing
        money.Text = Nothing
        expense.Text = Nothing
        sum.Text = "0"
        dtdate.Text = Date.Now
        activ.Focus()
    End Sub

    Private Sub dgviewbudget_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgviewbudget.CellContentClick
       
    End Sub

    Private Sub activ_Leave(sender As Object, e As EventArgs) Handles activ.Leave
        activ.Text = StrConv(activ.Text, VbStrConv.ProperCase)
    End Sub

    Private Sub money_TextChanged(sender As Object, e As EventArgs) Handles money.TextChanged
        If IsNumeric(money.Text) Then
            'do nothing 
        Else
            money.Text = ""
        End If
    End Sub

    Private Sub clos_Click(sender As Object, e As EventArgs) Handles clos.Click
        Me.Close()
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub expense_TextChanged(sender As Object, e As EventArgs) Handles expense.TextChanged
        If IsNumeric(expense.Text) Then
            'do nothing 
        Else
            expense.Text = ""
        End If
       
    End Sub

    Private Sub expense_Leave(sender As Object, e As EventArgs) Handles expense.Leave
        If Not (expense.Text = Nothing) Then
            Dim p = money.Text
            Dim q = expense.Text

            Dim equalss = CDbl(p - q)
            equalss = (Math.Round(Val(equalss), 2))
            sum.Text = Format(equalss, "###,###.00")


        End If
        If expense.TextLength > 0 Then
            pesign.Visible = True
            'ElseIf expense.TextLength > 0 Then
            '    sum.Visible = True
        End If
    End Sub

End Class