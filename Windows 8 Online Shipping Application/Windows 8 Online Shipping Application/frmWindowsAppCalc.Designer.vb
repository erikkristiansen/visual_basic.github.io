<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWindowsAppCalc
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWindowsAppCalc))
        Me.lblWeight = New System.Windows.Forms.Label()
        Me.picShipping = New System.Windows.Forms.PictureBox()
        Me.txtWeight = New System.Windows.Forms.TextBox()
        Me.grpCountry = New System.Windows.Forms.GroupBox()
        Me.radCanada = New System.Windows.Forms.RadioButton()
        Me.radLatinAmerica = New System.Windows.Forms.RadioButton()
        Me.radUnitedStates = New System.Windows.Forms.RadioButton()
        Me.radOvernightShip = New System.Windows.Forms.RadioButton()
        Me.lblShippingFee = New System.Windows.Forms.Label()
        Me.lblWeightCost = New System.Windows.Forms.Label()
        Me.btnShippingFee = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        CType(Me.picShipping, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCountry.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblWeight
        '
        Me.lblWeight.AutoSize = True
        Me.lblWeight.Font = New System.Drawing.Font("Buxton Sketch", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeight.Location = New System.Drawing.Point(196, 52)
        Me.lblWeight.Name = "lblWeight"
        Me.lblWeight.Size = New System.Drawing.Size(154, 23)
        Me.lblWeight.TabIndex = 0
        Me.lblWeight.Text = "Enter Item Weight:"
        '
        'picShipping
        '
        Me.picShipping.Image = CType(resources.GetObject("picShipping.Image"), System.Drawing.Image)
        Me.picShipping.Location = New System.Drawing.Point(12, 12)
        Me.picShipping.Name = "picShipping"
        Me.picShipping.Size = New System.Drawing.Size(155, 191)
        Me.picShipping.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picShipping.TabIndex = 1
        Me.picShipping.TabStop = False
        '
        'txtWeight
        '
        Me.txtWeight.Font = New System.Drawing.Font("Buxton Sketch", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWeight.Location = New System.Drawing.Point(356, 55)
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.Size = New System.Drawing.Size(100, 21)
        Me.txtWeight.TabIndex = 2
        Me.txtWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'grpCountry
        '
        Me.grpCountry.Controls.Add(Me.radCanada)
        Me.grpCountry.Controls.Add(Me.radLatinAmerica)
        Me.grpCountry.Controls.Add(Me.radUnitedStates)
        Me.grpCountry.Location = New System.Drawing.Point(217, 103)
        Me.grpCountry.Name = "grpCountry"
        Me.grpCountry.Size = New System.Drawing.Size(200, 100)
        Me.grpCountry.TabIndex = 3
        Me.grpCountry.TabStop = False
        '
        'radCanada
        '
        Me.radCanada.AutoSize = True
        Me.radCanada.Font = New System.Drawing.Font("Buxton Sketch", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radCanada.Location = New System.Drawing.Point(19, 71)
        Me.radCanada.Name = "radCanada"
        Me.radCanada.Size = New System.Drawing.Size(71, 24)
        Me.radCanada.TabIndex = 2
        Me.radCanada.TabStop = True
        Me.radCanada.Text = "Canada"
        Me.radCanada.UseVisualStyleBackColor = True
        '
        'radLatinAmerica
        '
        Me.radLatinAmerica.AutoSize = True
        Me.radLatinAmerica.Font = New System.Drawing.Font("Buxton Sketch", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radLatinAmerica.Location = New System.Drawing.Point(19, 44)
        Me.radLatinAmerica.Name = "radLatinAmerica"
        Me.radLatinAmerica.Size = New System.Drawing.Size(115, 24)
        Me.radLatinAmerica.TabIndex = 1
        Me.radLatinAmerica.TabStop = True
        Me.radLatinAmerica.Text = "Latin America"
        Me.radLatinAmerica.UseVisualStyleBackColor = True
        '
        'radUnitedStates
        '
        Me.radUnitedStates.AutoSize = True
        Me.radUnitedStates.Font = New System.Drawing.Font("Buxton Sketch", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radUnitedStates.Location = New System.Drawing.Point(19, 20)
        Me.radUnitedStates.Name = "radUnitedStates"
        Me.radUnitedStates.Size = New System.Drawing.Size(120, 24)
        Me.radUnitedStates.TabIndex = 0
        Me.radUnitedStates.TabStop = True
        Me.radUnitedStates.Text = "United States"
        Me.radUnitedStates.UseVisualStyleBackColor = True
        '
        'radOvernightShip
        '
        Me.radOvernightShip.AutoSize = True
        Me.radOvernightShip.Font = New System.Drawing.Font("Buxton Sketch", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radOvernightShip.Location = New System.Drawing.Point(178, 232)
        Me.radOvernightShip.Name = "radOvernightShip"
        Me.radOvernightShip.Size = New System.Drawing.Size(226, 24)
        Me.radOvernightShip.TabIndex = 4
        Me.radOvernightShip.TabStop = True
        Me.radOvernightShip.Text = "Overnight Shipping Requested"
        Me.radOvernightShip.UseVisualStyleBackColor = True
        '
        'lblShippingFee
        '
        Me.lblShippingFee.AutoSize = True
        Me.lblShippingFee.Font = New System.Drawing.Font("Buxton Sketch", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShippingFee.Location = New System.Drawing.Point(81, 276)
        Me.lblShippingFee.Name = "lblShippingFee"
        Me.lblShippingFee.Size = New System.Drawing.Size(143, 29)
        Me.lblShippingFee.TabIndex = 5
        Me.lblShippingFee.Text = "Shipping Fee:"
        '
        'lblWeightCost
        '
        Me.lblWeightCost.AutoSize = True
        Me.lblWeightCost.Font = New System.Drawing.Font("Buxton Sketch", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeightCost.Location = New System.Drawing.Point(305, 276)
        Me.lblWeightCost.Name = "lblWeightCost"
        Me.lblWeightCost.Size = New System.Drawing.Size(111, 29)
        Me.lblWeightCost.TabIndex = 6
        Me.lblWeightCost.Text = "$0000.00"
        '
        'btnShippingFee
        '
        Me.btnShippingFee.Font = New System.Drawing.Font("Buxton Sketch", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShippingFee.Location = New System.Drawing.Point(68, 323)
        Me.btnShippingFee.Name = "btnShippingFee"
        Me.btnShippingFee.Size = New System.Drawing.Size(156, 38)
        Me.btnShippingFee.TabIndex = 7
        Me.btnShippingFee.Text = "Shipping Fee"
        Me.btnShippingFee.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Buxton Sketch", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(300, 323)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(156, 38)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'frmWindowsAppCalc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Goldenrod
        Me.ClientSize = New System.Drawing.Size(513, 388)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnShippingFee)
        Me.Controls.Add(Me.lblWeightCost)
        Me.Controls.Add(Me.lblShippingFee)
        Me.Controls.Add(Me.radOvernightShip)
        Me.Controls.Add(Me.grpCountry)
        Me.Controls.Add(Me.txtWeight)
        Me.Controls.Add(Me.picShipping)
        Me.Controls.Add(Me.lblWeight)
        Me.Name = "frmWindowsAppCalc"
        Me.Text = "Windows 8 Accessories Shipping Calculator"
        CType(Me.picShipping, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCountry.ResumeLayout(False)
        Me.grpCountry.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblWeight As System.Windows.Forms.Label
    Friend WithEvents picShipping As System.Windows.Forms.PictureBox
    Friend WithEvents txtWeight As System.Windows.Forms.TextBox
    Friend WithEvents grpCountry As System.Windows.Forms.GroupBox
    Friend WithEvents radLatinAmerica As System.Windows.Forms.RadioButton
    Friend WithEvents radUnitedStates As System.Windows.Forms.RadioButton
    Friend WithEvents radCanada As System.Windows.Forms.RadioButton
    Friend WithEvents radOvernightShip As System.Windows.Forms.RadioButton
    Friend WithEvents lblShippingFee As System.Windows.Forms.Label
    Friend WithEvents lblWeightCost As System.Windows.Forms.Label
    Friend WithEvents btnShippingFee As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button

End Class
