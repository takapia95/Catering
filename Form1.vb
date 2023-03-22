Option Strict On
Option Explicit On
Public Class Catering
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.btnClear.PerformClick()
    End Sub

    Private Sub RadioButton7_CheckedChanged(sender As Object, e As EventArgs) Handles radPick.CheckedChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCal.Click
        Dim decCost As Decimal
        Dim decFinal As Decimal
        Dim cdecDiscount As Decimal = 5D
        Dim decPoints As Decimal
        Dim strOrder As String = ""
        Dim strPay As String = ""
        Dim strPoints As String = ""
        Dim intPoints As Integer

        If IsNumeric(txtPoints.Text) Then
            intPoints = Convert.ToInt32(txtPoints.Text)
            strPoints = "after discount of " & intPoints.ToString() & " loyalty points."
            'MsgBox(intPoints)
            If radC.Checked Then
                decCost = 49.99D
                strOrder = "Cheese"
            ElseIf radW.Checked Then
                decCost = 59.99D
                strOrder = "Wrap"
            ElseIf radV.Checked Then
                decCost = 29.99D
                strOrder = "Veggie"
            ElseIf radS.Checked Then
                decCost = 49.99D
                strOrder = "Sausage and Cheese"
            ElseIf radF.Checked Then
                decCost = 29.99D
                strOrder = "Fruit"
            End If
            If radPre.Checked Then
                strPay = "using Pre-Pay"
            ElseIf radPick.Checked Then
                strPay = " using with Pay upon Pickup "
            End If

            intPoints = Convert.ToInt32(intPoints / 10I)
            MsgBox(intPoints)
            decPoints = (intPoints * cdecDiscount) / 100
            MsgBox(decPoints)

            If decPoints > 1 Then
                decPoints = 1
            End If
            MsgBox(decPoints)
            decFinal = decCost * (1 - decPoints)
            MsgBox(decFinal)

            lblOutput.Text = "Your order " & strOrder & " platter costs " & decFinal.ToString("C") & strPay & strPoints
        Else
            MsgBox("Please enter a valid number of points.", , "Input ERROR")
            Me.btnClear.PerformClick()
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtPoints.Text = ""
        txtPoints.Focus()
        lblOutput.Text = ""
        radC.Checked = True
        radV.Checked = False
        radS.Checked = False
        radF.Checked = False
        radPre.Checked = True
        radPick.Checked = False

    End Sub
End Class
