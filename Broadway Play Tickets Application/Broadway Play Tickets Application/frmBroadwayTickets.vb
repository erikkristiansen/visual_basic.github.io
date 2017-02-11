'Program Name: Broadway Play Tickets Application
'Author:       Erik Kristiansen
'Date:         November 24, 2015
'Purpose:      The Broadway Play Tickets Application allows users to select various Broadway 
'              plays, seating locations, and the number of tickets. The total cost with 
'              tax is computed.

Option Strict On


Public Class frmBroadwayTickets
    'Class variables 

    Private Sub cboPlayChoice_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPlayChoice.SelectedIndexChanged
        'This event handler allows the user to enter the play choice and then calls procedures to show the 
        'price sub-total, tax amount, and final price for the tickets

        Dim intPlayChoice As Integer

        intPlayChoice = cboPlayChoice.SelectedIndex()
        Select Case intPlayChoice
            Case 0
                LionKing()
            Case 1
                Wicked()
            Case 2
                PhantomOpera()
        End Select
        'Make items visible in the window
        lblSeats.Visible = True
        txtNumberOfSeats.Visible = True
        radOrchestra.Visible = True
        radMezzanine.Visible = True
        btnCalculateCost.Visible = True
        lblSubTotal.Visible = True
        lblTax.Visible = True
        lblFinalTotal.Visible = True

        'Clear the labels
        lblSubTotalCost.Text = ""
        lblTaxAmount.Text = ""
        lblFinalAmount.Text = ""

        'Set focus on number of seats
        txtNumberOfSeats.Focus()

    End Sub
    Private Sub LionKing()
        'This procedure checks the orchestra radio button
        radOrchestra.Checked = True
    End Sub

    Private Sub Wicked()
        'This procedure checks the orchestra radio button
        radOrchestra.Checked = True
    End Sub

    Private Sub PhantomOpera()
        'This procedure checks the orchestra radio button
        radOrchestra.Checked = True
    End Sub

    Private Sub btnCalculateCost_Click(sender As Object, e As EventArgs) Handles btnCalculateCost.Click
        'This event handler determines the cost of play seats, tax amount, and total price 
        Dim intNumberOfSeats As Integer
        Dim blnNumberOfSeatsIsValid As Boolean = False
        Dim blnPlayIsSelected As Boolean = False
        Dim intPlayChoice As Integer
        Dim intOrchestra As Integer
        Dim intMezzanine As Integer
        Dim decTotalCost As Decimal
        Dim decPlayCost As Decimal

        'call a function to ensure the number of seats is valid
        blnNumberOfSeatsIsValid = ValidateSeats()

        If (blnNumberOfSeatsIsValid And blnPlayIsSelected) Then
            intNumberOfSeats = Convert.ToInt32(txtNumberOfSeats.Text)
            intPlayChoice = cboPlayChoice.SelectedIndex
            Select Case intPlayChoice
                Case 0
                    decTotalCost = LionKingFindCost(intPlayChoice, intNumberOfSeats)
                Case 1
                    decTotalCost = WickedFindCost(intPlayChoice, intNumberOfSeats)
                Case 2
                    decTotalCost = PhantomFindCost(intPlayChoice, intNumberOfSeats)
            End Select
            'Display the subtotal, tax amount, and final amount
            'lblSubTotalCost.Text = strSubtotalAmount
            'lblTaxAmount.Text = strTaxAmount
            'lblFinalAmount.Text = strFinalAmount
            decTotalCost = CDec(lblFinalAmount.ToString())
        End If
    End Sub

    Private Function ValidateSeats() As Boolean
        Dim intNumberOfSeats As Integer
        Dim blnCheckValidity As Boolean = False
        Dim strNumberOfSeatsErrorMessage As String = "Please enter the number of seats (1-9)"
        Dim strMessageTitle As String = "Error"

        Try
            intNumberOfSeats = Convert.ToInt32(txtNumberOfSeats.Text)
            If intNumberOfSeats > 0 And intNumberOfSeats < 10 Then
                blnCheckValidity = True
            Else
                MsgBox(strNumberOfSeatsErrorMessage, , strMessageTitle)
                txtNumberOfSeats.Focus()
                txtNumberOfSeats.Clear()
            End If
        Catch ex As Exception
            MsgBox(strNumberOfSeatsErrorMessage, , strMessageTitle)
            txtNumberOfSeats.Focus()
            txtNumberOfSeats.Clear()

        End Try
        Return blnCheckValidity

    End Function

    Private Function LionKingFindCost(ByRef intPlayChoice As Integer, ByVal intNumberOfSeats As Integer) As Decimal
        Dim decFinalCost As Decimal
        Dim decPlayCost As Decimal
        Dim decLionKingOrchestra As Decimal = 135D
        Dim decLionKingMezzanine As Decimal = 92D
        radOrchestra.Checked = CBool(decLionKingOrchestra)
        Select Case intPlayChoice
            Case 0
                decPlayCost = decLionKingOrchestra
            Case 1
                decPlayCost = decLionKingMezzanine
        End Select

        decFinalCost = intNumberOfSeats * decPlayCost
        Return decFinalCost
    End Function

    Private Function WickedFindCost(ByRef intPlayChoice As Integer, ByVal intNumberOfSeats As Integer) As Decimal
        Dim decFinalCost As Decimal
        Dim decPlayCost As Decimal
        Dim decWickedOrchestra As Decimal = 149D
        Dim decWickedMezzanine As Decimal = 98D

        Select Case intPlayChoice
            Case 0
                decPlayCost = decWickedOrchestra
            Case 1
                decPlayCost = decWickedMezzanine
        End Select

        decFinalCost = intNumberOfSeats * decPlayCost
        Return decFinalCost
    End Function

    Private Function PhantomFindCost(ByRef intPlayChoice As Integer, ByVal intNumberOfSeats As Integer) As Decimal
        Dim decFinalCost As Decimal
        Dim decPlayCost As Decimal
        Dim decPhantomOrchestra As Decimal = 149D
        Dim decPhantomMezzanine As Decimal = 98D

        Select Case intPlayChoice
            Case 0
                decPlayCost = decPhantomOrchestra
            Case 1
                decPlayCost = decPhantomMezzanine
        End Select

        decFinalCost = intNumberOfSeats * decPlayCost
        Return decFinalCost
    End Function
End Class

