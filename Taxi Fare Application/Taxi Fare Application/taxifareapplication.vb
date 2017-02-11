Public Class taxifareapplication

    'Cost per mile 
    Const _cdecPricePerMile As Decimal = 2.25D

    Private Sub btnDisplayFare_Click(sender As Object, e As EventArgs) Handles btnDisplayFare.Click
        'This event handler is executed when the user clicks the 
        'Display Fare button. It calculates and displays the cost of 
        'fare for a taxi trip 

        Dim strNumberOfMiles As String
        Dim intNumberOfMiles As Integer
        Dim decTotalCostOfTrip As Decimal

        strNumberOfMiles = txtNumberOfMiles.Text
        intNumberOfMiles = Convert.ToInt32(strNumberOfMiles)
        decTotalCostOfTrip = intNumberOfMiles * _cdecPricePerMile
        lblTotalMiles.Text = decTotalCostOfTrip.ToString("C")


    End Sub

   
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'This event handler is executed when the user clicks the 
        'Clear button. It clears the Miles Traveled text box and 
        'the Text property of the Total Fare text. It then sets the 
        'focus on the txtNumberofMiles Textbox object

        txtNumberOfMiles.Clear()
        lblTotalMiles.Text = ""
        txtNumberOfMiles.Focus()

    End Sub

    Private Sub taxifareapplication_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'This event handler is executed when the form is loaded. 
        'It displays the cost heading, clears the Text property of Total Fare 
        'label, and sets the focus on the txtNumberOfMiles Textbox object

        lblTotalMiles.Text = ""
        txtNumberOfMiles.Clear()
        txtNumberOfMiles.Focus()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Closes the window and terminates the applicaiton

        Close()

    End Sub
End Class
