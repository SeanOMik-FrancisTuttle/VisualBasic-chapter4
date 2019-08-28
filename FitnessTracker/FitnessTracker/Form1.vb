Public Class Form1
    Dim decWeeklyExercise As Decimal = 2.5
    Dim decDailyExercise As Decimal = decWeeklyExercise / 7
    Private Sub BtnTrack_Click(sender As Object, e As EventArgs) Handles btnTrack.Click
        ' This event handler is executed when the user clicks the
        ' Track button. It calculates and displays the amount
        ' of exercise the user has exercised in their life time.

        Dim dateBirth As Date = mtxtBirthDate.Text
        Dim dateCurrent As Date = mtxtCurrentDate.Text
        Dim intNumberOfDays As Integer
        Dim intHoursExercised As Decimal

        intNumberOfDays = dateCurrent.Subtract(dateBirth).Days
        Try
            intHoursExercised = intNumberOfDays / decDailyExercise
            lblAmountOfTimeExer.Text = Math.Round(intHoursExercised, 2) & " hrs"
        Catch
        End Try
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' This event handler is executed when the user clicks the
        ' Clear button. It clears the number of days text box
        ' and the Text property of the total Cost label.
        ' Then, it sets the focus on the txtNumberOfdays Textbox object.

        txtName.Clear()
        mtxtBirthDate.Clear()
        mtxtCurrentDate.Clear()
        lblAmountOfTimeExer.Text = ""
        mtxtBirthDate.Focus()
    End Sub

    Private Sub FrmBeachBikeRental_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' This event handler is executed when the form is loaded.
        ' It displays the cost heading, clears the Text property of the
        ' Total Cost label, and sets the focus on
        ' the txtNumberOfDays Textbox object.

        txtName.Clear()
        mtxtBirthDate.Clear()
        mtxtCurrentDate.Clear()
        lblAmountOfTimeExer.Text = ""
        mtxtBirthDate.Focus()
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Close the window and terminate the application

        Close()
    End Sub
End Class
