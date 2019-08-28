' Program: Beach Bike Rentals
' Author:  Sean Ervin
' Date:    8/27/2019
' Purpose: This application calculates and displays the total
'          cost of renting a bike for a specified number of days.

Public Class frmBeachBikeRental
    Dim decCostPerDay As Decimal = 5.0
    Private Sub BtnCost_Click(sender As Object, e As EventArgs) Handles btnCost.Click
        ' This event handler is executed when the user clicks the
        ' Find Cost button. It calculated and displays the cost
        ' of the bike rented (number of days times the cost per bike).

        Dim strNumberOfDays As String
        Dim intNumberOfDays As Integer
        Dim decTotalCost As Decimal

        strNumberOfDays = txtNumberOfDays.Text
        Try
            intNumberOfDays = Convert.ToInt32(strNumberOfDays)
            decTotalCost = intNumberOfDays * decCostPerDay
            lblTotalCost.Text = decTotalCost.ToString("C")
        Catch
        End Try
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' This event handler is executed when the user clicks the
        ' Clear button. It clears the number of days text box
        ' and the Text property of the total Cost label.
        ' Then, it sets the focus on the txtNumberOfdays Textbox object.

        txtNumberOfDays.Clear()
        lblTotalCost.Text = ""
        txtNumberOfDays.Focus()
    End Sub

    Private Sub FrmBeachBikeRental_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' This event handler is executed when the form is loaded.
        ' It displays the cost heading, clears the Text property of the
        ' Total Cost label, and sets the focus on
        ' the txtNumberOfDays Textbox object.

        lblCostHeading.Text = decCostPerDay.ToString("C") & " per Day"
        lblTotalCost.Text = ""
        txtNumberOfDays.Focus()
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Close the window and terminate the application

        Close()
    End Sub
End Class
