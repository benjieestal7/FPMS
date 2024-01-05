Imports MySql.Data.MySqlClient
Imports System.IO
Public Class FrmUserLog

    Private Sub AUTOCOMPLETE()
        Dim ramjink As New DataTable
        Dim ramos As New DataSet
        ramos.Tables.Add(ramjink)
        Dim ortega As New MySqlDataAdapter("Select fnme from log_info", connect)
        ortega.Fill(ramjink)
        Dim r As DataRow
        txtsearch.AutoCompleteCustomSource.Clear()
        For Each r In ramjink.Rows
            txtsearch.AutoCompleteCustomSource.Add(r.Item(0).ToString)
            'PARA NI SA PAG SEARCH BISAN WAKAY DGVIEW NGA GETAN AWAN FILTER NI SYA'
        Next
        connect.Close()
    End Sub
    Sub retrev()
        Dim s As String = "select iddd as `ID`, fnme as  `NAME`,intim as `LOG TIME`,indat as `LOG DATE`,outtim as `LOG OUT TIME` from log_info order by intim desc"

        Dim da As New MySqlDataAdapter(s, connect)
        connect.Open()
        Dim ds As New DataSet
        da.Fill(ds, "log_info")
        da.Dispose()
        logdg.DataSource = ds.Tables(0)
        connect.Close()
    End Sub

    Sub retsearch()
        Dim s As String = "select iddd as `ID`, fnme as  `NAME`,intim as `LOG TIME`,indat as `LOG DATE`,outtim as `LOG OUT TIME` from log_info where fnme like '" + txtsearch.Text + "%'"

        Dim da As New MySqlDataAdapter(s, connect)
        connect.Open()
        Dim ds As New DataSet
        da.Fill(ds, "log_info")
        da.Dispose()
        logdg.DataSource = ds.Tables(0)
        connect.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim s As String = "Delete from log_info "
        qry(s)
        retrev()
        MsgBox("Log is cleared !!")
    End Sub

    Private Sub FrmUserLog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        retrev()
        AUTOCOMPLETE()
    End Sub

    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        retsearch()
    End Sub

    Private Sub logdg_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles logdg.CellContentClick
        txtsearch.Text = logdg.SelectedCells(1).Value
    End Sub
End Class