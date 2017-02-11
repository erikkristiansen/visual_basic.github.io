<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOnlineSpecials
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOnlineSpecials))
        Me.lblOnlineSpecials = New System.Windows.Forms.Label()
        Me.btnDailySpecial = New System.Windows.Forms.Button()
        Me.btnWeeklySpecials = New System.Windows.Forms.Button()
        Me.btnHolidaySpecial = New System.Windows.Forms.Button()
        Me.picDailySpecial = New System.Windows.Forms.PictureBox()
        Me.picHolidaySpecial = New System.Windows.Forms.PictureBox()
        Me.picWeeklySpecial = New System.Windows.Forms.PictureBox()
        Me.lblDailyRegPrice = New System.Windows.Forms.Label()
        Me.lblWeeklySpecial = New System.Windows.Forms.Label()
        Me.lblHolidayPrice = New System.Windows.Forms.Label()
        Me.lblDailySalePrice = New System.Windows.Forms.Label()
        Me.lblWeeklySalePrice = New System.Windows.Forms.Label()
        Me.lblHolidaySalePrice = New System.Windows.Forms.Label()
        Me.btnDailyCart = New System.Windows.Forms.Button()
        Me.btnWeeklyCart = New System.Windows.Forms.Button()
        Me.btnHolidayCart = New System.Windows.Forms.Button()
        Me.btnExitWindow = New System.Windows.Forms.Button()
        CType(Me.picDailySpecial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picHolidaySpecial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picWeeklySpecial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblOnlineSpecials
        '
        Me.lblOnlineSpecials.AutoSize = True
        Me.lblOnlineSpecials.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOnlineSpecials.Location = New System.Drawing.Point(77, 13)
        Me.lblOnlineSpecials.Name = "lblOnlineSpecials"
        Me.lblOnlineSpecials.Size = New System.Drawing.Size(311, 17)
        Me.lblOnlineSpecials.TabIndex = 0
        Me.lblOnlineSpecials.Text = "Please choose from one of the following specials"
        '
        'btnDailySpecial
        '
        Me.btnDailySpecial.Location = New System.Drawing.Point(35, 55)
        Me.btnDailySpecial.Name = "btnDailySpecial"
        Me.btnDailySpecial.Size = New System.Drawing.Size(95, 35)
        Me.btnDailySpecial.TabIndex = 1
        Me.btnDailySpecial.Text = "Daily Special"
        Me.btnDailySpecial.UseVisualStyleBackColor = True
        '
        'btnWeeklySpecials
        '
        Me.btnWeeklySpecials.Location = New System.Drawing.Point(193, 55)
        Me.btnWeeklySpecials.Name = "btnWeeklySpecials"
        Me.btnWeeklySpecials.Size = New System.Drawing.Size(95, 35)
        Me.btnWeeklySpecials.TabIndex = 2
        Me.btnWeeklySpecials.Text = "Weekly Special"
        Me.btnWeeklySpecials.UseVisualStyleBackColor = True
        '
        'btnHolidaySpecial
        '
        Me.btnHolidaySpecial.Location = New System.Drawing.Point(351, 55)
        Me.btnHolidaySpecial.Name = "btnHolidaySpecial"
        Me.btnHolidaySpecial.Size = New System.Drawing.Size(95, 35)
        Me.btnHolidaySpecial.TabIndex = 3
        Me.btnHolidaySpecial.Text = "Holiday Special"
        Me.btnHolidaySpecial.UseVisualStyleBackColor = True
        '
        'picDailySpecial
        '
        Me.picDailySpecial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picDailySpecial.Image = CType(resources.GetObject("picDailySpecial.Image"), System.Drawing.Image)
        Me.picDailySpecial.Location = New System.Drawing.Point(23, 106)
        Me.picDailySpecial.Name = "picDailySpecial"
        Me.picDailySpecial.Size = New System.Drawing.Size(128, 112)
        Me.picDailySpecial.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDailySpecial.TabIndex = 4
        Me.picDailySpecial.TabStop = False
        '
        'picHolidaySpecial
        '
        Me.picHolidaySpecial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picHolidaySpecial.Image = CType(resources.GetObject("picHolidaySpecial.Image"), System.Drawing.Image)
        Me.picHolidaySpecial.Location = New System.Drawing.Point(331, 106)
        Me.picHolidaySpecial.Name = "picHolidaySpecial"
        Me.picHolidaySpecial.Size = New System.Drawing.Size(128, 112)
        Me.picHolidaySpecial.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picHolidaySpecial.TabIndex = 6
        Me.picHolidaySpecial.TabStop = False
        '
        'picWeeklySpecial
        '
        Me.picWeeklySpecial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picWeeklySpecial.Image = CType(resources.GetObject("picWeeklySpecial.Image"), System.Drawing.Image)
        Me.picWeeklySpecial.Location = New System.Drawing.Point(177, 106)
        Me.picWeeklySpecial.Name = "picWeeklySpecial"
        Me.picWeeklySpecial.Size = New System.Drawing.Size(128, 112)
        Me.picWeeklySpecial.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picWeeklySpecial.TabIndex = 7
        Me.picWeeklySpecial.TabStop = False
        '
        'lblDailyRegPrice
        '
        Me.lblDailyRegPrice.AutoSize = True
        Me.lblDailyRegPrice.Location = New System.Drawing.Point(36, 234)
        Me.lblDailyRegPrice.Name = "lblDailyRegPrice"
        Me.lblDailyRegPrice.Size = New System.Drawing.Size(107, 13)
        Me.lblDailyRegPrice.TabIndex = 8
        Me.lblDailyRegPrice.Text = "Regular Price $99.95"
        '
        'lblWeeklySpecial
        '
        Me.lblWeeklySpecial.AutoSize = True
        Me.lblWeeklySpecial.Location = New System.Drawing.Point(186, 234)
        Me.lblWeeklySpecial.Name = "lblWeeklySpecial"
        Me.lblWeeklySpecial.Size = New System.Drawing.Size(113, 13)
        Me.lblWeeklySpecial.TabIndex = 9
        Me.lblWeeklySpecial.Text = "Regular Price $239.95"
        '
        'lblHolidayPrice
        '
        Me.lblHolidayPrice.AutoSize = True
        Me.lblHolidayPrice.Location = New System.Drawing.Point(340, 234)
        Me.lblHolidayPrice.Name = "lblHolidayPrice"
        Me.lblHolidayPrice.Size = New System.Drawing.Size(119, 13)
        Me.lblHolidayPrice.TabIndex = 10
        Me.lblHolidayPrice.Text = "Regular Price: $259.95 "
        '
        'lblDailySalePrice
        '
        Me.lblDailySalePrice.AutoSize = True
        Me.lblDailySalePrice.Location = New System.Drawing.Point(36, 260)
        Me.lblDailySalePrice.Name = "lblDailySalePrice"
        Me.lblDailySalePrice.Size = New System.Drawing.Size(94, 13)
        Me.lblDailySalePrice.TabIndex = 11
        Me.lblDailySalePrice.Text = "Sale Price: $84.50"
        '
        'lblWeeklySalePrice
        '
        Me.lblWeeklySalePrice.AutoSize = True
        Me.lblWeeklySalePrice.Location = New System.Drawing.Point(189, 260)
        Me.lblWeeklySalePrice.Name = "lblWeeklySalePrice"
        Me.lblWeeklySalePrice.Size = New System.Drawing.Size(100, 13)
        Me.lblWeeklySalePrice.TabIndex = 12
        Me.lblWeeklySalePrice.Text = "Sale Price: $199.95"
        '
        'lblHolidaySalePrice
        '
        Me.lblHolidaySalePrice.AutoSize = True
        Me.lblHolidaySalePrice.Location = New System.Drawing.Point(348, 260)
        Me.lblHolidaySalePrice.Name = "lblHolidaySalePrice"
        Me.lblHolidaySalePrice.Size = New System.Drawing.Size(100, 13)
        Me.lblHolidaySalePrice.TabIndex = 13
        Me.lblHolidaySalePrice.Text = "Sale Price: $203.19"
        '
        'btnDailyCart
        '
        Me.btnDailyCart.Location = New System.Drawing.Point(45, 293)
        Me.btnDailyCart.Name = "btnDailyCart"
        Me.btnDailyCart.Size = New System.Drawing.Size(75, 23)
        Me.btnDailyCart.TabIndex = 14
        Me.btnDailyCart.Text = "Add to Cart"
        Me.btnDailyCart.UseVisualStyleBackColor = True
        '
        'btnWeeklyCart
        '
        Me.btnWeeklyCart.Location = New System.Drawing.Point(212, 293)
        Me.btnWeeklyCart.Name = "btnWeeklyCart"
        Me.btnWeeklyCart.Size = New System.Drawing.Size(75, 23)
        Me.btnWeeklyCart.TabIndex = 15
        Me.btnWeeklyCart.Text = "Add to Cart"
        Me.btnWeeklyCart.UseVisualStyleBackColor = True
        '
        'btnHolidayCart
        '
        Me.btnHolidayCart.Location = New System.Drawing.Point(361, 293)
        Me.btnHolidayCart.Name = "btnHolidayCart"
        Me.btnHolidayCart.Size = New System.Drawing.Size(75, 23)
        Me.btnHolidayCart.TabIndex = 16
        Me.btnHolidayCart.Text = "Add to Cart"
        Me.btnHolidayCart.UseVisualStyleBackColor = True
        '
        'btnExitWindow
        '
        Me.btnExitWindow.Location = New System.Drawing.Point(198, 382)
        Me.btnExitWindow.Name = "btnExitWindow"
        Me.btnExitWindow.Size = New System.Drawing.Size(75, 23)
        Me.btnExitWindow.TabIndex = 17
        Me.btnExitWindow.Text = "Exit Window"
        Me.btnExitWindow.UseVisualStyleBackColor = True
        '
        'frmOnlineSpecials
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(498, 451)
        Me.Controls.Add(Me.btnExitWindow)
        Me.Controls.Add(Me.btnHolidayCart)
        Me.Controls.Add(Me.btnWeeklyCart)
        Me.Controls.Add(Me.btnDailyCart)
        Me.Controls.Add(Me.lblHolidaySalePrice)
        Me.Controls.Add(Me.lblWeeklySalePrice)
        Me.Controls.Add(Me.lblDailySalePrice)
        Me.Controls.Add(Me.lblHolidayPrice)
        Me.Controls.Add(Me.lblWeeklySpecial)
        Me.Controls.Add(Me.lblDailyRegPrice)
        Me.Controls.Add(Me.picWeeklySpecial)
        Me.Controls.Add(Me.picHolidaySpecial)
        Me.Controls.Add(Me.picDailySpecial)
        Me.Controls.Add(Me.btnHolidaySpecial)
        Me.Controls.Add(Me.btnWeeklySpecials)
        Me.Controls.Add(Me.btnDailySpecial)
        Me.Controls.Add(Me.lblOnlineSpecials)
        Me.Name = "frmOnlineSpecials"
        Me.Text = "Online Store Specials"
        CType(Me.picDailySpecial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picHolidaySpecial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picWeeklySpecial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblOnlineSpecials As System.Windows.Forms.Label
    Friend WithEvents btnDailySpecial As System.Windows.Forms.Button
    Friend WithEvents btnWeeklySpecials As System.Windows.Forms.Button
    Friend WithEvents btnHolidaySpecial As System.Windows.Forms.Button
    Friend WithEvents picDailySpecial As System.Windows.Forms.PictureBox
    Friend WithEvents picHolidaySpecial As System.Windows.Forms.PictureBox
    Friend WithEvents picWeeklySpecial As System.Windows.Forms.PictureBox
    Friend WithEvents lblDailyRegPrice As System.Windows.Forms.Label
    Friend WithEvents lblWeeklySpecial As System.Windows.Forms.Label
    Friend WithEvents lblHolidayPrice As System.Windows.Forms.Label
    Friend WithEvents lblDailySalePrice As System.Windows.Forms.Label
    Friend WithEvents lblWeeklySalePrice As System.Windows.Forms.Label
    Friend WithEvents lblHolidaySalePrice As System.Windows.Forms.Label
    Friend WithEvents btnDailyCart As System.Windows.Forms.Button
    Friend WithEvents btnWeeklyCart As System.Windows.Forms.Button
    Friend WithEvents btnHolidayCart As System.Windows.Forms.Button
    Friend WithEvents btnExitWindow As System.Windows.Forms.Button

End Class
