Public Class frmWalkingTour
    Dim costOfTicket As Decimal = 14.99
    Dim costOfBooking As Decimal = 1.99
    Private Sub BtnDisplayCost_Click(sender As Object, e As EventArgs) Handles btnDisplayCost.Click
        ' This event handler is executed when the user clicks the Display Cost Button.'
        ' It calculates the cost of the tour using how many tickets they need, and the
        ' cost of the tickets.

        Dim strNeededTickets As String
        Dim intNumberOfTickets As Integer
        Dim decTotalCost As Decimal

        strNeededTickets = txtNeededTickets.Text
        Try
            intNumberOfTickets = Convert.ToInt32(strNeededTickets)
            decTotalCost = (intNumberOfTickets * costOfTicket) + costOfBooking
            lblTotalCost.Text = decTotalCost.ToString("C")
        Catch
        End Try
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' This event handler is executed when the user clicks the
        ' Clear button. It clears the number of days text box
        ' and the Text property of the total Cost label.
        ' Then, it sets the focus on the txtNeededTickets Textbox object.

        txtNeededTickets.Clear()
        lblTotalCost.Text = ""
        txtNeededTickets.Focus()
    End Sub

    Private Sub FrmBeachBikeRental_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' This event handler is executed when the form is loaded.
        ' It displays the cost heading, clears the Text property of the
        ' Total Cost label, and sets the focus on
        ' the txtNeededTickets Textbox object.

        lblTotalCost.Text = ""
        txtNeededTickets.Focus()
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Close the window and terminate the application

        Close()
    End Sub
End Class
