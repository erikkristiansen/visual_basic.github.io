'Program Name: Sales Tax Calculator
'Developer: Erik Kristiansen
'Date: Oct 3, 2015
'Purpose: Calculate the sales tax for a purchase

Option Strict On


Public Class frmSalesTaxCalculator

    'Tax Rate amount for purchase
    Const _cdecTaxRate As Decimal = 0.0875D

    Private Sub btnDisplayTotCost_Click(sender As Object, e As EventArgs) Handles btnDisplayTotCost.Click
        'This event handler executes when the user clicks the Display Cost button. It calculates the 
        'sales tax, adds it to the item price, then displays the final cost of the item including tax

        Dim strCostOfItem As String
        Dim intCostOfItem As Integer
        Dim decTaxAmount As Decimal
        Dim decFinalPrice As Decimal

        strCostOfItem = txtCost.Text
        intCostOfItem = Convert.ToInt32(strCostOfItem)
        decTaxAmount = intCostOfItem * _cdecTaxRate
        decFinalPrice = decTaxAmount + intCostOfItem
        lblTaxRate.Text = decTaxAmount.ToString("C")
        lblTotalCost.Text = decFinalPrice.ToString("C")

        lblFinalPrice.Text = "Final Price for " & txtItem.Text & ":"


    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'This event handler is executed when the user clicks the Clear button. 
        'It clears the item name, tax amount, and final price displayed. It then 
        'places the cursor back in the original text box
        txtCost.Clear()
        txtItem.Clear()
        txtCost.Focus()
        txtItem.Focus()
        lblTaxRate.Text = ""
        lblTotalCost.Text = ""

    End Sub

    Private Sub frmSalesTaxCalculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'This event handler is executed when the page is loaded. It clears the item and price text boxes.
        'It then sets the focus on the Item text box
        txtCost.Clear()
        txtItem.Clear()
        txtCost.Focus()
        txtItem.Focus()
        lblTaxRate.Text = ""
        lblTotalCost.Text = ""

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'This event handler closes the the window and will terminate the applcation

        Close()

    End Sub
End Class
