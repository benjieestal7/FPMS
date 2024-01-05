Public Class FrmConversion
    Dim Kilo, Liter, Mililiter, Gram, Centimeter As Double
    Dim Kilometer, Meter, Inches, Feet As Double

    Dim ioperation As String
    Private Sub FrmConversion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
    End Sub


    Private Sub kilog_CheckedChanged(sender As Object, e As EventArgs) Handles kilog.CheckedChanged
        ioperation = "KG"
    End Sub

    Private Sub gra_CheckedChanged(sender As Object, e As EventArgs) Handles gra.CheckedChanged
        ioperation = "GK"
    End Sub

    Private Sub li_CheckedChanged(sender As Object, e As EventArgs) Handles li.CheckedChanged
        ioperation = "LM"
    End Sub

    Private Sub mil_CheckedChanged(sender As Object, e As EventArgs) Handles mil.CheckedChanged
        ioperation = "ML"
    End Sub

    Private Sub kil_CheckedChanged(sender As Object, e As EventArgs) Handles kil.CheckedChanged
        ioperation = "IM"
    End Sub

    Private Sub met_CheckedChanged(sender As Object, e As EventArgs) Handles met.CheckedChanged
        ioperation = "CM"
    End Sub

    Private Sub mete_CheckedChanged(sender As Object, e As EventArgs) Handles mete.CheckedChanged
        ioperation = "MF"
    End Sub

    Private Sub fee_CheckedChanged(sender As Object, e As EventArgs) Handles fee.CheckedChanged
        ioperation = "FI"
    End Sub

    Private Sub metr_CheckedChanged(sender As Object, e As EventArgs) Handles metr.CheckedChanged
        ioperation = "MC"
    End Sub

    Private Sub btnconvert_Click(sender As Object, e As EventArgs) Handles btnconvert.Click
        Select Case (ioperation)

            Case "IM"
                'Inches to Meter
                Inches = Double.Parse(convert.Text)
                lblconvert.Text = ((Inches * 0.0254).ToString())

            Case "CM"
                'Centimeter to Meter
                Centimeter = Double.Parse(convert.Text)
                lblconvert.Text = ((Centimeter / 100).ToString())

            Case "MF"
                'Meter to Feet
                Inches = Double.Parse(convert.Text)
                lblconvert.Text = ((3 * Inches).ToString())

            Case "FI"
                'Feet to Inches
                Feet = Double.Parse(convert.Text)
                lblconvert.Text = ((Feet * 12).ToString())

            Case "KG"
                'Kilogram to Gram
                Kilo = Double.Parse(convert.Text)
                lblconvert.Text = ((1000 * Kilo).ToString())

            Case "GK"
                'Gram to Kilogram
                Gram = Double.Parse(convert.Text)
                lblconvert.Text = ((Gram / 1000).ToString())

            Case "LM"
                'Liter to Mililiter
                Liter = Double.Parse(convert.Text)
                lblconvert.Text = ((1000 * Liter).ToString())

            Case "ML"
                'Mililiter  to Liter
                Mililiter = Double.Parse(convert.Text)
                lblconvert.Text = ((Mililiter / 1000).ToString())

            Case "MC"
                'Meter to Centimeter
                Meter = Double.Parse(convert.Text)
                lblconvert.Text = ((Meter * 100).ToString())
        End Select
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        convert.Clear()
        lblconvert.Text = ""
        kilog.Checked = False
        gra.Checked = False
        li.Checked = False
        mil.Checked = False
        kil.Checked = False
        met.Checked = False
        mete.Checked = False
        fee.Checked = False
        metr.Checked = False
    End Sub

    Private Sub clos_Click(sender As Object, e As EventArgs) Handles clos.Click
        Me.Close()
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class