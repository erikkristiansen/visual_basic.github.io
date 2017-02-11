'Program Name: Windows 8 Online Shipping Application
'Developer: Erik Kristiansen
'Date: Oct 13, 2015
'Purpose: This Windows application computes the cost of shipping for an online Windows 8 
'         accessories store

Option Strict On

Public Class frmWindowsAppCalc

    Private Sub btnShippingFee_Click(sender As Object, e As EventArgs) Handles btnShippingFee.Click
        'The btnShippingFee event handler calculates the estimated cost of 
        'shipping based on country and weight

        'Declaration Section and variables
        Dim decWeight As Decimal
        Dim decCostPerPound As Decimal
        Dim decCostEstimate As Decimal
        Dim decUSCost As Decimal = 6D
        Dim decCanada As Decimal = 8D
        Dim decLatinAmerican As Decimal = 8D

        'Did user enter a numeric value?
        If IsNumeric(txtWeight.Text) Then
            decWeight = Convert.ToDecimal(txtWeight.Text)

          
            'If weight is less than 5 lbs
            If decWeight > 0 Then
                'Determine cost per foot of shipping
                If radUnitedStates.Checked Then
                    decCostPerPound = decUSCost
                ElseIf radLatinAmerica.Checked Then
                    decCostPerPound = decLatinAmerican
                ElseIf radCanada.Checked Then
                    decCostPerPound = decCanada
                End If
                If decWeight > 5 Then
                    decWeight = CDec(decWeight * 1.25)
                End If
                If decWeight >= 20 Then
                    MsgBox("Weight must be lower than 20lbs", , "Input Error")
                End If
                If radOvernightShip.Checked Then
                    decWeight = decWeight * 2
                End If
                decCostEstimate = decWeight * decCostPerPound
                lblWeightCost.Text = decCostEstimate.ToString("C")
            Else
                'Display error message if user entered a negative value
                MsgBox("You entered " & decWeight & " . Enter a Positive Number", , "Input Error")
                txtWeight.Text = ""
                txtWeight.Focus()
            End If
        Else
            '  Display error message if user entered a non-numeric value
            MsgBox("You must enter a number", , "Input Error")
            txtWeight.Text = ""
            txtWeight.Focus()
        End If

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'This event handler is executed when the user clicks the Clear button. It 
        'clears the Enter Weight text box and the Weight Cost label, resets the radio 
        'buttons with United States selected and sets the focus to the Shipping Weight 
        'text box

        txtWeight.Clear()
        lblWeightCost.Text = ""
        radUnitedStates.Checked = True
        radLatinAmerica.Checked = False
        radCanada.Checked = False
        txtWeight.Focus()
    End Sub

    Private Sub frmWindowsAppCalc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'This event handler is executed when the form is loaded at the start of teh program.
        'It sets the Weight text box and clears the cost estimate label

        txtWeight.Focus()
        lblWeightCost.Text = ""
    End Sub
End Class
