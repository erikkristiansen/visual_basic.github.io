'Program: Digital Downloads 
'Developer: Erik Kristiansen (not really)
'Date: Sept, 29, 2015
'Purpose: This application calculates and displays the total cost 
'           of music downloads          

Option Strict On

Public Class frmDownloads

    'Cost per download - used in multiple procedures
    Const _cdecPricePerDownload As Decimal = 0.99D

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim strNumberOfSongs As String
        Dim intNumberOfSongs As Integer
        Dim decTotalCostOfDownloads As Decimal

        strNumberOfSongs = txtNumberofDownloads.Text
        intNumberOfSongs = Convert.ToInt32(strNumberOfSongs)
        decTotalCostOfDownloads = intNumberOfSongs * _cdecPricePerDownload
        lblTotalCost.Text = decTotalCostOfDownloads.ToString("C")

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'This event handler is executed when the user clicks the Clear button. It clears 
        'the number of songs text box and the Text property of Total Cost of Downloads label, 
        'and sets the focus on the txtNumbeOfDownloads Textbox object

        txtNumberofDownloads.Clear()
        lblCostHeading.Text = ""
        txtNumberofDownloads.Focus()

    End Sub

    Private Sub frmDownloads_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'This event handler is executed when the form is loaded. It displays the cost 
        'heading, clears the Text Property of the Total Cost of Downloads label, and sets the 
        'focus on the txtNumberOfSongs Textbox object.

        lblCostHeading.Text = _cdecPricePerDownload.ToString("C") & " per Download"
        lblTotalCost.Text = ""
        txtNumberofDownloads.Focus()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Close the window and terminate the application

        Close()

    End Sub
End Class
