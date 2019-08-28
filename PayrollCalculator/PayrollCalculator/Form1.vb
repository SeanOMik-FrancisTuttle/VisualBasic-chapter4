Public Class frmPayrollCalc
    Dim decFICATax As Decimal = 0.0765
    Dim decFederalTax As Decimal = 0.22
    Dim decStateIncomeTax As Decimal = 0.04

    Private Sub btnCalculatePay_Click(sender As Object, e As EventArgs) Handles btnCalculatePay.Click
        ' This event handler is executed when the user clicks the
        ' Calculate pay button. It calculated and displays the tax
        ' that was removed from pay, and then the netpay.

        Dim strPay As String
        Dim decPay As Decimal
        Dim decNetPay As Decimal

        Dim decTotalTax As Decimal

        strPay = txtBiWeeklyIncome.Text
        Try
            decPay = Convert.ToDecimal(strPay)

            decTotalTax += decPay * decFICATax
            decTotalTax += decPay * decFederalTax
            decTotalTax += decPay * decStateIncomeTax

            decNetPay = decPay - decTotalTax

            lblFICATax.Text = "-" & (decPay * decFICATax).ToString("C")
            lblFederalTax.Text = "-" & (decPay * decFederalTax).ToString("C")
            lblStateIncomeTax.Text = "-" & (decPay * decStateIncomeTax).ToString("C")

            lblNetPay.Text = decNetPay.ToString("C")
        Catch
        End Try
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' This event handler is executed when the user clicks the
        ' Clear button. It clears the BiWeekly Income text box
        ' and the Text property of lblFederalTax, lblFICATax, lblStateIncomeTax, lblNetPay.
        ' Then, it sets the focus on the txtBiWeeklyIncome Textbox object.

        txtBiWeeklyIncome.Clear()
        lblFederalTax.Text = ""
        lblFICATax.Text = ""
        lblStateIncomeTax.Text = ""
        lblNetPay.Text = ""
    End Sub

    Private Sub FrmBeachBikeRental_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' This event handler is executed when the form is loaded.
        ' It displays the cost heading, clears the Text property of the
        ' Total Cost label, FICA tax label, state income tax label, net pay label, and sets the focus on
        ' the txtBiWeeklyIncome Textbox object.

        txtBiWeeklyIncome.Clear()
        lblFederalTax.Text = ""
        lblFICATax.Text = ""
        lblStateIncomeTax.Text = ""
        lblNetPay.Text = ""
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Close the window and terminate the application

        Close()
    End Sub
End Class
