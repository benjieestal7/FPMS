Imports MySql.Data.MySqlClient
Imports System.IO
Public Class FrmExpenseDetails

    Sub counter()
        Dim count As Integer
        For i As Integer = 0 To dgviewexpense.RowCount - 1
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

    Sub expenselist()
        Dim s As String = "select itemno as `Item No`,item as  `Item`,price as `Price`,quantity as `Quantity`,equal as `Total` from expense_info order by item desc"

        Dim da As New MySqlDataAdapter(s, connect)
        connect.Open()
        Dim ds As New DataSet
        da.Fill(ds, "expense_info")
        da.Dispose()
        dgviewexpense.DataSource = ds.Tables(0)
        connect.Close()
    End Sub

    Sub listitems()
        Dim temp As Double = 0
        Dim lt As String = "select itemlist_info.budgID as `Budget ID`,itemlist_info.budmoney as `Budget Money`,itemlist_info.itymno as `Item No`,expense_info.item as `Item`,expense_info.price as `Price`,expense_info.quantity as `Quantity`,expense_info.equal as `Total` from expense_info,itemlist_info where ((itemlist_info.itymno = expense_info.itemno) and itemlist_info.budgID = '" & budid.Text & "' and itemlist_info.budmoney = '" & moni.Text & "') and (itemlist_info.itymno like '%" + searchlist.Text + "%' and expense_info.itemno like '%" + searchlist.Text + "%') order by expense_info.item "
        Dim da As New MySqlDataAdapter(lt, connect)
        connect.Open()
        Dim ds As New DataSet
        da.Fill(ds, "expense_info,itemlist_info")
        da.Dispose()
        dgviewlist.DataSource = ds.Tables(0)
        'disable the viewing of ID in datagrid
        'dgview.Columns(0).Visible = False
        connect.Close()
    End Sub

    Sub retsearch()
        Dim s As String = "select itemno as `Item No`,item as  `Item`,price as `Price`,quantity as `Quantity` from expense_info where item like '" + searchlist.Text + "%'"

        Dim da As New MySqlDataAdapter(s, connect)
        connect.Open()
        Dim ds As New DataSet
        da.Fill(ds, "expense_info")
        da.Dispose()
        dgviewexpense.DataSource = ds.Tables(0)
        connect.Close()
    End Sub

   

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        dit.Text = Date.Now.Date
        tim.Text = TimeOfDay
    End Sub

    Private Sub FrmExpenseDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        expenselist()
        listitems()
        counter()
    End Sub


    Private Sub dgviewexpense_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgviewexpense.CellMouseClick
        If dgviewexpense.RowCount = 0 Then
            MsgBox("Invalid Command!", MsgBoxStyle.Information, "System Checked")
            Return
        End If
        Try
            If ad.Checked = True Then
                Dim l As String = "select budgID from itemlist_info where itymno='" & dgviewexpense.SelectedCells(0).Value & "' and budgID='" & budid.Text & "'"
                lookrec(l)
                If (b = True) Then
                    MsgBox("Already Added", MsgBoxStyle.Information, "System Checked")
                    b = False
                    Return
                End If
                Dim s As String = "insert into itemlist_info(itymno,budgID,budmoney)values('" & dgviewexpense.SelectedCells(0).Value & "','" & budid.Text & "','" & moni.Text & "')"
                cQuery(s)
            End If
            listitems()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub AddListToolStripMenuItem_Click(sender As Object, e As EventArgs)
        FrmExpenseList.Show()
    End Sub

    Private Sub searchlist_TextChanged(sender As Object, e As EventArgs) Handles searchlist.TextChanged
        retsearch()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        dgviewlist.ClearSelection()
    End Sub

    Private Sub clearselectionsched_Click(sender As Object, e As EventArgs) Handles clearselectionsched.Click
        dgviewexpense.ClearSelection()
    End Sub
End Class