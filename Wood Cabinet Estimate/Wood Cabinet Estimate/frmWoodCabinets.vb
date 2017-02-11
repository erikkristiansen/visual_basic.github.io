'Program Name:  Wood Cabinet Estimate
'Author:        Corinne Hoisington(Erik Kristiansen)
'Date:          October 12, 2015
'Purpose:       This application computes the estimates cost of wood cabinets based on the number of linear feet
'               of cabinets and the following cost per linear foot; Pine - $300.00 per linear foot 
'               Oak - $500.00 per linear foot; Cherry - $650.00 per 
'               linear foot



Public Class frmWoodCabinets

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'The btnCalculate event handler calculates the estimated cost of 
        'cabintets based on the linear feet and the wood type.

        'Declaration Section
        Dim decFeet As Decimal
        Dim decCostPerFoot As Decimal
        Dim decCostEstimate As Decimal
        Dim decPineCost As Decimal = 300D
        Dim decOakCost As Decimal = 500D
        Dim decCherryCost As Decimal = 650D

        'Did user enter a numeric value?
        If IsNumeric(txtFeet.Text) Then
            decFeet = Convert.ToDecimal(txtFeet.Text)

            'Is Linear Feet greater than zero
            If decFeet > 0 Then
                'Determine cost per foot of wood
                If radPine.Checked Then
                    decCostPerFoot = decPineCost
                ElseIf radOak.Checked Then
                    decCostPerFoot = decOakCost
                ElseIf radCherry.Checked Then
                    decCostPerFoot = decCherryCost
                End If

                'Calculate and display the cost estimate
                decCostEstimate = decFeet * decCostPerFoot
                lblCostEstimate.Text = decCostEstimate.ToString("C")
            Else
                'Display error message if user entered a negative value
                MsgBox("You entered " & decFeet.ToString() & " . Enter a Positve Number", , "Input Error")
                txtFeet.Text = ""
                txtFeet.Focus()
            End If
        Else
            'Display error message if user entered a nonnumeric value
            MsgBox("Enter the Linear Feet of the Cabinets", , "Input Error")
            txtFeet.Text = ""
            txtFeet.Focus()
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' This event handler is executed when the user clicks the Clear button. It 
        'clears the Linear Feet text box and the cost estimate label, resets the radio 
        'buttons with Pine selected, and sets the focus to the Linear Feet text box.

        txtFeet.Clear()
        lblCostEstimate.Text = ""
        radPine.Checked = True
        radOak.Checked = False
        radCherry.Checked = False
        txtFeet.Focus()

    End Sub

    Private Sub frmWoodCabinets_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'This event handler is executed when the form is loaded at the start of the program.
        'It sets the focus to the Linear Feet text box and clears the cost estimate label

        txtFeet.Focus()
        lblCostEstimate.Text = ""
    End Sub
End Class
