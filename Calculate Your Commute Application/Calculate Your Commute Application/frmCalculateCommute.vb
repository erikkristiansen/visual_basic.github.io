'Program Name:  Calculate Your Commute Applicaiton
'Author:        Erik Kristiansen
'Date:          November 30, 2015
'Purpose:       The Calculate Your Commute Application computes the yearly cost of commuting to 
'               work via car, bus, or train

Option Strict On

Public Class frmCalculateCommute
    'Class Variables
    Private _strTripDistance As String = "How far do you travel per day?"
    Private _strDaysWorked As String = "How many days a week do you work?"
    Private _strCarMilage As String = "What is your car's MPG?"
    Private _strGasPerGallon As String = "What is the average you pay for gas per gallon?"
    Private _strMonthlyMaintIns As String = "How much do you pay for car insurance and maintenance?"
    Private _strParkingCost As String = "How much do you pay in parking per month?"
    Private _strTransitFare As String = "How much is a round trip fare?"


    Private Sub cboTransportaionChoice_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTransportationChoice.SelectedIndexChanged
        'This event handler allows the user to enter the transportation choice and then calls 
        'subprocedures to place the tranportation questions in the list 

        Dim intTransportationChoice As Integer
        intTransportationChoice = cboTransportationChoice.SelectedIndex

        Select Case intTransportationChoice
            Case 0
                Car()
            Case 1
                Train()
            Case 2
                Bus()
        End Select
        'Make items visible
        lblFinalMonthlyCost.Visible = True
        lstTransportationQuestions.Visible = True
        btnCalculateCommute.Visible = True
    End Sub

    'Add to list box

    Private Sub Car()
        lstTransportationQuestions.Items.Add(_strTripDistance)
        lstTransportationQuestions.Items.Add(_strDaysWorked)
        lstTransportationQuestions.Items.Add(_strCarMilage)
        lstTransportationQuestions.Items.Add(_strGasPerGallon)
        lstTransportationQuestions.Items.Add(_strMonthlyMaintIns)
        lstTransportationQuestions.Items.Add(_strParkingCost)

    End Sub

    Private Sub Train()
        lstTransportationQuestions.Items.Add(_strTransitFare)
        lstTransportationQuestions.Items.Add(_strDaysWorked)

    End Sub

    Private Sub Bus()
        lstTransportationQuestions.Items.Add(_strTransitFare)
        lstTransportationQuestions.Items.Add(_strDaysWorked)

    End Sub

    Private Sub btnCalculateCommute_Click(sender As Object, e As EventArgs) Handles btnCalculateCommute.Click
        Dim intTranspoChoice As Integer
        Dim intCarTripDistance As Integer
        Dim intDaysWorked As Integer
        Dim intCarDaysWorked As Integer
        Dim intCarMilage As Integer
        Dim intCarPerGallon As Integer
        Dim intMonthlyMaintIns As Integer
        Dim decParkingRate As Decimal
        Dim decTransitFare As Decimal
        Dim blnValidateTranspoChoice As Boolean = False
        Dim blnValidateTranspoSelection As Boolean = False

        'Call a function to ensure a mode of transportation is chosen
        blnValidateTranspoChoice = ValidateTransportation()
        'Call a function to ensure an input was made 
        blnValidateTranspoSelection = ValidateSelection()
        intTranspoChoice = cboTransportationChoice.SelectedIndex

        Select Case intTranspoChoice
            Case 0
                decTransportationCost = CarCostFind()
            Case 1
                decTransportationCost = BusCostFind()
            Case 2
                decTransportationCost = TrainCostFind()
        End Select

        'Display the total cost amount
        lblFinalMonthlyCost.Text = decTransportationCost
        'intCarTripDistance = CInt(InputBox("Enter how many miles you drive per year", , "Driving Distance"))

    End Sub

    Private Function ValidateTransportation()

    End Function

    Private Function ValidateSelection(ByRef blnTranspo As Boolean, ByRef strTranspo As String) As Integer
        'This function ensures the user selscted a mode of transportation
        Dim intTranspo As Integer
        Try
            intTranspo = Convert.ToInt32(lstTransportationQuestions.SelectedIndex)
            strTranspo = lstTransportationQuestions.SelectedItem.ToString()
            blnTranspo = True

        Catch ex As SystemException
            'Detects if mode of transportation isn't selected 
            MsgBox("Select a mode of transportation", , "Error")
            blnTranspo = False
        End Try
        Return intTranspo
    End Function

    Private Function CarCostFind(ByVal intTranspoSelection As Integer, ByVal 
End Class
