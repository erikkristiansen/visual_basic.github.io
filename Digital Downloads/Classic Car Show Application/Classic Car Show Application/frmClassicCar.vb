'Program Name:  Classic Car Show Application
'Author:        Erik Kristiansen
'Date:          December 7, 2015
'Purpose:       The Classic Car Show Application determines the total estimated
'               value of classic cars in a car show for insurance purposes

Option Strict On

Public Class frmClassicCar
    'Class variables
    Private _intCarValue As Integer
    Public Shared _intSizeOfArray As Integer = 11
    Private _strCars(_intSizeOfArray) As String
    Private _decCarPrice(_intSizeOfArray) As Decimal


    Private Sub frmClassicCar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'The frmClassicCAr load event reads the inventory text file and fills 
        'the Combobox object with the inventory items

        'Initialize as instance of the StreamReader object and declare variables
        Dim objReader As IO.StreamReader
        Dim strLocationAndNameOfFile As String = "J:\Classic Car Show Application.cars.txt"
        Dim intCount As Integer = 0
        Dim intFill As Integer
        Dim strFileError As String = "The file is not available. Restart when the file is available."

        'Verify the file exists
        If IO.File.Exists(strLocationAndNameOfFile) Then
            objReader = IO.File.OpenText(strLocationAndNameOfFile)
            'Read the file line by line until the file is completed 
            Do While (objReader.Peek() > -1)
                _strCars(intCount) = objReader.ReadLine()
                _decCarPrice(intCount) = Convert.ToDecimal(objReader.ReadLine())

                intCount += 1
            Loop
            objReader.Close()

            'The Listbox object is filled with the Inventory IDs
            For intFill = 0 To (_strCars.Length - 1)
                If Not (_strCars(intFill) Is Nothing) Then
                    lstCars.Items.Add(_strCars(intFill))
                End If
            Next
            MsgBox(strFileError, , "Error")
            Close()
        End If
    End Sub

    Private Sub btnComputeInventory_Click(sender As Object, e As EventArgs) Handles btnComputeInventory.Click
        'The btnComputeInventory click event adds the total all the car value 
        'Declare variables 

        Dim decAddCars As Decimal = 0
        Dim intCarTotal As Integer

        MakeObjectsVisible()

        For intCarTotal = 0 To (_decCarPrice.Length - 1)
            decAddCars += _decCarPrice(intCarTotal)

            lblTotalCarValue.Text = decAddCars.ToString("C")
            lblTotalCars.Text = _intSizeOfArray.ToString()
            lstCars.Items.Add(decAddCars.ToString())

        Next

    End Sub

    Private Sub MakeObjectsVisible()
        'This procedure displays the objects showing the results
        lstCars.Visible = True
        lblCarInventory.Visible = True
        lblTotalCarsInShowHeading.Visible = True
        lblTotalCars.Visible = True
        lblTotalCarValHeading.Visible = True
        lblTotalCarValue.Visible = True
        picCar.Visible = True
    End Sub

    Private Sub mnuClear_Click(sender As Object, e As EventArgs) Handles mnuClear.Click
        'The mnuClear click event clears and resets the form 
        lstCars.Visible = False
        lblCarInventory.Visible = False
        lblTotalCarsInShowHeading.Visible = False
        lblTotalCars.Visible = False
        lblTotalCarValHeading.Visible = False
        lblTotalCarValue.Visible = False
        picCar.Visible = False

    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        'The mnuExit click event closes the application
        Application.Exit()

    End Sub
End Class
