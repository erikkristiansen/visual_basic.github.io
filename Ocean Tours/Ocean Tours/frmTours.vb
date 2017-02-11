'Program Name:  Ocean Tours Trip Selection
'Author:        Erik Kristiansen
'Date:          Nov 17, 2015
'Purpose:       The Ocean Tours Trip Selection application determines the ocean tours available and calculates
'               the cost of the tour.

Option Strict On


Public Class frmTours

    'Class variables
    Private _intTwoHours As Integer = 2
    Private _intThreeHours As Integer = 3
    Private _intFourHours As Integer = 4
    Private _intEightHours As Integer = 8
    Private _strDeepSeaFishing As String = "Deep Sea Fishing"
    Private _strKayaking As String = "Kayaking"
    Private _strScuba As String = "Scuba"
    Private _strSnorkeking As String = "Snorkeling"
    Private _strGlassBottomBoat As String = "Glass Bottom Boat"
    Private _strParasailing As String = "Parasailing"



    Private Sub cboIsland_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboIsland.SelectedIndexChanged, cboIsland.SelectedIndexChanged

        'This event handler allows the user to enter the island choice and then calls
        'subprocedures to place the island activities in the list

        Dim intIslandChoice As Integer

        intIslandChoice = Me.cboIsland.SelectedIndex
        lstTours.Items.Clear()
        Select Case intIslandChoice
            Case 0
                ArubaTours()
            Case 1
                JamaicaTours()
            Case 2
                KeyWestTours()
        End Select

        ' Make items visible in the window
        lblParty.Visible = True
        txtNumberInParty.Visible = True
        lblSelect.Visible = True
        lstTours.Visible = True
        btnFindCost.Visible = True
        btnClear.Visible = True
        lblTourType.Visible = True
        lblCost.Visible = True
        lblLength.Visible = True
        'Clear the labels
        lblTourType.Text = ""
        lblCost.Text = ""
        lblLength.Text = ""
        'Set focus on number in party text box
        txtNumberInParty.Focus()

    End Sub

    Private Sub ArubaTours()
        ' This procedure fills in the possible ocean tours for Aruba
        lstTours.Items.Add(_strDeepSeaFishing)
        lstTours.Items.Add(_strKayaking)
        lstTours.Items.Add(_strScuba)
        lstTours.Items.Add(_strSnorkeking)
    End Sub
    Private Sub JamaicaTours()
        ' This procedure fills in the possible ocean tours for Jamaica
        lstTours.Items.Add(_strGlassBottomBoat)
        lstTours.Items.Add(_strParasailing)
        lstTours.Items.Add(_strSnorkeking)

    End Sub
    Private Sub KeyWestTours()
        ' This procedure fills in the possible ocean tours for Jamaica
        lstTours.Items.Add(_strDeepSeaFishing)
        lstTours.Items.Add(_strGlassBottomBoat)
        lstTours.Items.Add(_strScuba)
        lstTours.Items.Add(_strSnorkeking)

    End Sub

    Private Sub btnFindCost_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFindCost.Click
        ' This button event handler detemines the cost of the ocean tours 
        'and displays the tour, the cost, and the length

        Dim intGroupSize As Integer
        Dim blnNumberInPartyIsValid As Boolean = False
        Dim blnTourIsSelected As Boolean = False
        Dim intTourChoice As Integer
        Dim strSelectedTour As String = ""
        Dim intIslandChoice As Integer
        Dim intLengthOfTour As Integer = 0
        Dim decTotalCost As Decimal

        'Call a function to ensure the number of people in the party is valid
        blnNumberInPartyIsValid = ValidateNumberInParty()
        'Call a function to ensure a tour was selected
        intTourChoice = ValidateTourSelection(blnTourIsSelected, strSelectedTour)

        'If number of people and the tour selection are valid, calculate the cost 
        If (blnNumberInPartyIsValid And blnTourIsSelected) Then
            intGroupSize = Convert.ToInt32(txtNumberInParty.Text)
            intIslandChoice = cboIsland.SelectedIndex
            Select Case intIslandChoice
                Case 0
                    decTotalCost = ArubaFindCost(intTourChoice, intGroupSize, intLengthOfTour)
                Case 1
                    decTotalCost = JamaicaFindCost(intTourChoice, intGroupSize, intLengthOfTour)
                Case 2
                    decTotalCost = KeyWestFindCost(intTourChoice, intGroupSize, intLengthOfTour)
            End Select
            'Display the cost of the ocean tour
            lblTourType.Text = "Tour: " & strSelectedTour
            lblCost.Text = "Cost: " & decTotalCost.ToString("C")
            lblLength.Text = "Length: " & intLengthOfTour.ToString() & " hours"
        End If

    End Sub

    Private Function ValidateNumberInParty() As Boolean
        ' This procedure validates the value entered for the number in party 

        Dim intPartyNumber As Integer
        Dim blnValidatyCheck As Boolean = False
        Dim strNumberInPartyErrorMessage As String = _
            "Please enter the number of people in your party (1-99)"
        Dim strMessageBoxTitle As String = "Error"

        Try
            intPartyNumber = Convert.ToInt32(txtNumberInParty.Text)
            If intPartyNumber > 0 And intPartyNumber < 100 Then
                blnValidatyCheck = True
            Else
                MsgBox(strNumberInPartyErrorMessage, , strMessageBoxTitle)
                txtNumberInParty.Focus()
                txtNumberInParty.Clear()
            End If
        Catch Exception As FormatException
            MsgBox(strNumberInPartyErrorMessage, , strMessageBoxTitle)
            txtNumberInParty.Focus()
            txtNumberInParty.Clear()
        Catch Exception As OverflowException
            MsgBox(strNumberInPartyErrorMessage, , strMessageBoxTitle)
            txtNumberInParty.Focus()
            txtNumberInParty.Clear()
        End Try

        Return blnValidatyCheck

    End Function

    Private Function ValidateTourSelection(ByRef blnTour As Boolean, ByRef strTour As String) As Integer
        'This function ensures the user selected a tour

        Dim intOceanTour As Integer
        Try
            intOceanTour = Convert.ToInt32(lstTours.SelectedIndex)
            strTour = lstTours.SelectedItem.ToString()
            blnTour = True
        Catch ex As SystemException
            'Detects if tour not selected 
            MsgBox("Selected an Ocean Tour", , "Error")
            blnTour = False
        End Try
        Return intOceanTour
    End Function

    Private Function ArubaFindCost(ByVal intTourSelection As Integer, ByVal intGroupSize As Integer,
                                   ByRef intTourLength As Integer) As Decimal
        'This function calculates the cost of the tours to Aruba

        Dim decTourCost As Decimal
        Dim decFinalCost As Decimal
        Dim decArubaDeepSeaCoast As Decimal = 199D
        Dim decArubaKayakCost As Decimal = 89D
        Dim decArubaScubaCost As Decimal = 119D
        Dim decArubaSnorkelCost As Decimal = 89D

        Select Case intTourSelection
            Case 0
                decTourCost = decArubaDeepSeaCoast
                intTourLength = _intEightHours
            Case 1
                decTourCost = decArubaKayakCost
                intTourLength = _intTwoHours
            Case 2
                decTourCost = decArubaScubaCost
                intTourLength = _intThreeHours
            Case 3
                decTourCost = decArubaSnorkelCost
                intTourLength = _intFourHours
        End Select
        decFinalCost = decTourCost * intGroupSize
        Return decFinalCost

    End Function

    Private Function JamaicaFindCost(ByVal intTourSelection As Integer, ByVal intGroupSize As Integer,
                                     ByRef intTourLength As Integer) As Decimal
        'This function calculates the cost of the tours to Jamaica 

        Dim decTourCost As Decimal
        Dim decFinalCost As Decimal
        Dim decJamaicaGlassBottomCost As Decimal = 39D
        Dim decJamaicaParasailCost As Decimal = 119D
        Dim decJamaicaSnokelCost As Decimal = 59D

        Select Case intTourSelection
            Case 0
                decTourCost = decJamaicaGlassBottomCost
                intTourLength = _intTwoHours
            Case 1
                decTourCost = decJamaicaParasailCost
                intTourLength = _intTwoHours
            Case 2
                decTourCost = decJamaicaSnokelCost
                intTourLength = _intThreeHours
        End Select
        decFinalCost = decTourCost * intGroupSize
        Return decFinalCost
    End Function

    Private Function KeyWestFindCost(ByVal intTourSelection As Integer, ByVal intGroupSize As Integer,
                                     ByRef intTourLength As Integer) As Decimal
        'This function calculates the cost of the tours tto Key West

        Dim decTourCost As Decimal
        Dim decFinalCost As Decimal
        Dim decKeyWestDeepSeaCost As Decimal = 89D
        Dim decKeyWestGlassBottomCost As Decimal = 29D
        Dim decKeyWestScubeCost As Decimal = 119D
        Dim DecKeyWestSnorkelCost As Decimal = 59D

        Select Case intTourSelection
            Case 0
                decTourCost = decKeyWestDeepSeaCost
                intTourLength = _intFourHours
            Case 1
                decTourCost = decKeyWestGlassBottomCost
                intTourLength = _intThreeHours
            Case 2
                decTourCost = decKeyWestScubeCost
                intTourLength = _intThreeHours
            Case 3
                decTourCost = DecKeyWestSnorkelCost
                intTourLength = _intThreeHours
        End Select
        decFinalCost = decTourCost * intGroupSize
        Return decFinalCost
    End Function


    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        'This event handler clears the form and resets the form for 
        'reuse when the user clicks the Clear button

        cboIsland.Text = "Select Island Location"
        txtNumberInParty.Clear()
        lstTours.Items.Clear()
        lblTourType.Text = ""
        lblCost.Text = ""
        lblLength.Text = ""
        lblParty.Visible = False
        txtNumberInParty.Visible = False
        lblSelect.Visible = False
        lstTours.Visible = False
        btnFindCost.Visible = False
        btnClear.Visible = False
        lblTourType.Visible = False
        lblCost.Visible = False
        lblLength.Visible = False

    End Sub

    Private Sub frmTours_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Hold the splash screen for 5 seconds

        Threading.Thread.Sleep(5000)

    End Sub
End Class
