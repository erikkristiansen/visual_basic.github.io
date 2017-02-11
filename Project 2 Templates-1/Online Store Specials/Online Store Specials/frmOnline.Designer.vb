<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOnline
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOnline))
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblThankYou = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lblAdd = New System.Windows.Forms.Label()
        Me.btnCamera = New System.Windows.Forms.Button()
        Me.btniPod = New System.Windows.Forms.Button()
        Me.btnPhone = New System.Windows.Forms.Button()
        Me.lblCameraSalePrice = New System.Windows.Forms.Label()
        Me.lblCameraRegularPrice = New System.Windows.Forms.Label()
        Me.lblMP3SalePrice = New System.Windows.Forms.Label()
        Me.lblMP3RegularPrice = New System.Windows.Forms.Label()
        Me.lblPhoneSalePrice = New System.Windows.Forms.Label()
        Me.lblPhoneRegularPrice = New System.Windows.Forms.Label()
        Me.picCamera = New System.Windows.Forms.PictureBox()
        Me.piciPod = New System.Windows.Forms.PictureBox()
        Me.picPhone = New System.Windows.Forms.PictureBox()
        Me.lblOnlineStoreSpecials = New System.Windows.Forms.Label()
        CType(Me.picCamera, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.piciPod, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPhone, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Wheat
        Me.btnExit.Location = New System.Drawing.Point(291, 546)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(89, 23)
        Me.btnExit.TabIndex = 33
        Me.btnExit.Text = "Exit Window"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lblThankYou
        '
        Me.lblThankYou.AutoSize = True
        Me.lblThankYou.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblThankYou.Location = New System.Drawing.Point(239, 502)
        Me.lblThankYou.Name = "lblThankYou"
        Me.lblThankYou.Size = New System.Drawing.Size(193, 19)
        Me.lblThankYou.TabIndex = 32
        Me.lblThankYou.Text = "Thank you for your patronage."
        Me.lblThankYou.Visible = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Wheat
        Me.btnAdd.Enabled = False
        Me.btnAdd.Location = New System.Drawing.Point(291, 453)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(89, 23)
        Me.btnAdd.TabIndex = 31
        Me.btnAdd.Text = "Add to Cart"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'lblAdd
        '
        Me.lblAdd.AutoSize = True
        Me.lblAdd.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdd.Location = New System.Drawing.Point(64, 412)
        Me.lblAdd.Name = "lblAdd"
        Me.lblAdd.Size = New System.Drawing.Size(542, 19)
        Me.lblAdd.TabIndex = 30
        Me.lblAdd.Text = "If you would like to add the selected item to the shopping cart, please click: Ad" & _
    "d to Cart."
        '
        'btnCamera
        '
        Me.btnCamera.BackColor = System.Drawing.Color.Wheat
        Me.btnCamera.Location = New System.Drawing.Point(491, 351)
        Me.btnCamera.Name = "btnCamera"
        Me.btnCamera.Size = New System.Drawing.Size(89, 23)
        Me.btnCamera.TabIndex = 29
        Me.btnCamera.Text = "Digital Camera"
        Me.btnCamera.UseVisualStyleBackColor = False
        '
        'btniPod
        '
        Me.btniPod.BackColor = System.Drawing.Color.Wheat
        Me.btniPod.Location = New System.Drawing.Point(291, 351)
        Me.btniPod.Name = "btniPod"
        Me.btniPod.Size = New System.Drawing.Size(89, 23)
        Me.btniPod.TabIndex = 28
        Me.btniPod.Text = "Tablet"
        Me.btniPod.UseVisualStyleBackColor = False
        '
        'btnPhone
        '
        Me.btnPhone.BackColor = System.Drawing.Color.Wheat
        Me.btnPhone.Location = New System.Drawing.Point(91, 352)
        Me.btnPhone.Name = "btnPhone"
        Me.btnPhone.Size = New System.Drawing.Size(89, 23)
        Me.btnPhone.TabIndex = 27
        Me.btnPhone.Text = "SmartPhone"
        Me.btnPhone.UseVisualStyleBackColor = False
        '
        'lblCameraSalePrice
        '
        Me.lblCameraSalePrice.AutoSize = True
        Me.lblCameraSalePrice.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCameraSalePrice.Location = New System.Drawing.Point(471, 313)
        Me.lblCameraSalePrice.Name = "lblCameraSalePrice"
        Me.lblCameraSalePrice.Size = New System.Drawing.Size(129, 19)
        Me.lblCameraSalePrice.TabIndex = 26
        Me.lblCameraSalePrice.Text = "Sale Price: $203.19"
        Me.lblCameraSalePrice.Visible = False
        '
        'lblCameraRegularPrice
        '
        Me.lblCameraRegularPrice.AutoSize = True
        Me.lblCameraRegularPrice.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCameraRegularPrice.Location = New System.Drawing.Point(461, 281)
        Me.lblCameraRegularPrice.Name = "lblCameraRegularPrice"
        Me.lblCameraRegularPrice.Size = New System.Drawing.Size(149, 19)
        Me.lblCameraRegularPrice.TabIndex = 25
        Me.lblCameraRegularPrice.Text = "Regular Price: $259.95"
        Me.lblCameraRegularPrice.Visible = False
        '
        'lblMP3SalePrice
        '
        Me.lblMP3SalePrice.AutoSize = True
        Me.lblMP3SalePrice.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMP3SalePrice.Location = New System.Drawing.Point(271, 313)
        Me.lblMP3SalePrice.Name = "lblMP3SalePrice"
        Me.lblMP3SalePrice.Size = New System.Drawing.Size(129, 19)
        Me.lblMP3SalePrice.TabIndex = 24
        Me.lblMP3SalePrice.Text = "Sale Price: $199.95"
        Me.lblMP3SalePrice.Visible = False
        '
        'lblMP3RegularPrice
        '
        Me.lblMP3RegularPrice.AutoSize = True
        Me.lblMP3RegularPrice.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMP3RegularPrice.Location = New System.Drawing.Point(261, 280)
        Me.lblMP3RegularPrice.Name = "lblMP3RegularPrice"
        Me.lblMP3RegularPrice.Size = New System.Drawing.Size(149, 19)
        Me.lblMP3RegularPrice.TabIndex = 23
        Me.lblMP3RegularPrice.Text = "Regular Price: $239.95"
        Me.lblMP3RegularPrice.Visible = False
        '
        'lblPhoneSalePrice
        '
        Me.lblPhoneSalePrice.AutoSize = True
        Me.lblPhoneSalePrice.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhoneSalePrice.Location = New System.Drawing.Point(75, 313)
        Me.lblPhoneSalePrice.Name = "lblPhoneSalePrice"
        Me.lblPhoneSalePrice.Size = New System.Drawing.Size(121, 19)
        Me.lblPhoneSalePrice.TabIndex = 22
        Me.lblPhoneSalePrice.Text = "Sale Price: $84.50"
        Me.lblPhoneSalePrice.Visible = False
        '
        'lblPhoneRegularPrice
        '
        Me.lblPhoneRegularPrice.AutoSize = True
        Me.lblPhoneRegularPrice.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhoneRegularPrice.Location = New System.Drawing.Point(65, 280)
        Me.lblPhoneRegularPrice.Name = "lblPhoneRegularPrice"
        Me.lblPhoneRegularPrice.Size = New System.Drawing.Size(141, 19)
        Me.lblPhoneRegularPrice.TabIndex = 21
        Me.lblPhoneRegularPrice.Text = "Regular Price: $99.95"
        Me.lblPhoneRegularPrice.Visible = False
        '
        'picCamera
        '
        Me.picCamera.Image = CType(resources.GetObject("picCamera.Image"), System.Drawing.Image)
        Me.picCamera.Location = New System.Drawing.Point(470, 113)
        Me.picCamera.Name = "picCamera"
        Me.picCamera.Size = New System.Drawing.Size(130, 150)
        Me.picCamera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCamera.TabIndex = 20
        Me.picCamera.TabStop = False
        Me.picCamera.Visible = False
        '
        'piciPod
        '
        Me.piciPod.Image = CType(resources.GetObject("piciPod.Image"), System.Drawing.Image)
        Me.piciPod.Location = New System.Drawing.Point(270, 113)
        Me.piciPod.Name = "piciPod"
        Me.piciPod.Size = New System.Drawing.Size(130, 150)
        Me.piciPod.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.piciPod.TabIndex = 19
        Me.piciPod.TabStop = False
        Me.piciPod.Visible = False
        '
        'picPhone
        '
        Me.picPhone.Image = CType(resources.GetObject("picPhone.Image"), System.Drawing.Image)
        Me.picPhone.Location = New System.Drawing.Point(70, 113)
        Me.picPhone.Name = "picPhone"
        Me.picPhone.Size = New System.Drawing.Size(130, 150)
        Me.picPhone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPhone.TabIndex = 18
        Me.picPhone.TabStop = False
        Me.picPhone.Visible = False
        '
        'lblOnlineStoreSpecials
        '
        Me.lblOnlineStoreSpecials.AutoSize = True
        Me.lblOnlineStoreSpecials.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOnlineStoreSpecials.Location = New System.Drawing.Point(206, 63)
        Me.lblOnlineStoreSpecials.Name = "lblOnlineStoreSpecials"
        Me.lblOnlineStoreSpecials.Size = New System.Drawing.Size(295, 31)
        Me.lblOnlineStoreSpecials.TabIndex = 17
        Me.lblOnlineStoreSpecials.Text = "Online Store Specials"
        '
        'frmOnline
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(674, 633)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblThankYou)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lblAdd)
        Me.Controls.Add(Me.btnCamera)
        Me.Controls.Add(Me.btniPod)
        Me.Controls.Add(Me.btnPhone)
        Me.Controls.Add(Me.lblCameraSalePrice)
        Me.Controls.Add(Me.lblCameraRegularPrice)
        Me.Controls.Add(Me.lblMP3SalePrice)
        Me.Controls.Add(Me.lblMP3RegularPrice)
        Me.Controls.Add(Me.lblPhoneSalePrice)
        Me.Controls.Add(Me.lblPhoneRegularPrice)
        Me.Controls.Add(Me.picCamera)
        Me.Controls.Add(Me.piciPod)
        Me.Controls.Add(Me.picPhone)
        Me.Controls.Add(Me.lblOnlineStoreSpecials)
        Me.Name = "frmOnline"
        Me.Text = "Shop Today"
        CType(Me.picCamera, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.piciPod, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPhone, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblThankYou As System.Windows.Forms.Label
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents lblAdd As System.Windows.Forms.Label
    Friend WithEvents btnCamera As System.Windows.Forms.Button
    Friend WithEvents btniPod As System.Windows.Forms.Button
    Friend WithEvents btnPhone As System.Windows.Forms.Button
    Friend WithEvents lblCameraSalePrice As System.Windows.Forms.Label
    Friend WithEvents lblCameraRegularPrice As System.Windows.Forms.Label
    Friend WithEvents lblMP3SalePrice As System.Windows.Forms.Label
    Friend WithEvents lblMP3RegularPrice As System.Windows.Forms.Label
    Friend WithEvents lblPhoneSalePrice As System.Windows.Forms.Label
    Friend WithEvents lblPhoneRegularPrice As System.Windows.Forms.Label
    Friend WithEvents picCamera As System.Windows.Forms.PictureBox
    Friend WithEvents piciPod As System.Windows.Forms.PictureBox
    Friend WithEvents picPhone As System.Windows.Forms.PictureBox
    Friend WithEvents lblOnlineStoreSpecials As System.Windows.Forms.Label

End Class
