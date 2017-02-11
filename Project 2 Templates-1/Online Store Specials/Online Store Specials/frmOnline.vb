'Program Name: Online Store Specials
'Developer: Erik Kristiansen
'Date: Sept 22, 2015
'Purpose: This application displays three holiday items for special purchase 
Public Class frmOnline

    Private Sub btnPhone_Click(sender As Object, e As EventArgs) Handles btnPhone.Click
        'This code is executed when the user clicks or taps the Smart Phone button.
        'It displays the Smart Phone picture, hides the other two item pictures, and enables 
        'the Add To Cart button
        picPhone.Visible = True
        piciPod.Visible = False
        picCamera.Visible = False
        lblPhoneRegularPrice.Visible = True
        lblPhoneSalePrice.Visible = True
        lblMP3RegularPrice.Visible = False
        lblMP3SalePrice.Visible = False
        lblCameraRegularPrice.Visible = False
        lblCameraSalePrice.Visible = False
        btnAdd.Enabled = True

    End Sub

    Private Sub btniPod_Click(sender As Object, e As EventArgs) Handles btniPod.Click
        'This code is executed when the user clicks or taps the Tablet button.
        'It displays the Tablet picture, hides the other two item pictures, and enables 
        'the Add To Cart button
        piciPod.Visible = True
        picPhone.Visible = False
        picCamera.Visible = False
        lblMP3RegularPrice.Visible = True
        lblMP3SalePrice.Visible = True
        lblPhoneRegularPrice.Visible = False
        lblPhoneSalePrice.Visible = False
        lblCameraRegularPrice.Visible = False
        lblCameraSalePrice.Visible = False
        btnAdd.Enabled = True

    End Sub

    Private Sub btnCamera_Click(sender As Object, e As EventArgs) Handles btnCamera.Click
        'This code is executed when the user clicks or taps the Digital Camera button.
        'It displays the Digital Camera picture, hides the other two item pictures, and enables 
        'the Add To Cart button
        picCamera.Visible = True
        piciPod.Visible = False
        picPhone.Visible = False
        lblCameraRegularPrice.Visible = True
        lblCameraSalePrice.Visible = True
        lblPhoneRegularPrice.Visible = False
        lblPhoneSalePrice.Visible = False
        lblMP3RegularPrice.Visible = False
        lblMP3SalePrice.Visible = False
        btnCamera.Enabled = True

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'This code executes when the user taps or clicks the Digital Camera button, 
        'the Smart Phone button, or the Tablet button. It then displays the thank you label.
        lblAdd.Visible = False
        lblThankYou.Visible = True


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub
End Class
