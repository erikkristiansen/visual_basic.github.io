<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSalesTaxCalculator
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSalesTaxCalculator))
        Me.picMainPic = New System.Windows.Forms.PictureBox()
        Me.lblStoreName = New System.Windows.Forms.Label()
        Me.lblItemName = New System.Windows.Forms.Label()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.lblTaxAmount = New System.Windows.Forms.Label()
        Me.lblFinalPrice = New System.Windows.Forms.Label()
        Me.txtItem = New System.Windows.Forms.TextBox()
        Me.txtCost = New System.Windows.Forms.TextBox()
        Me.btnDisplayTotCost = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblTaxRate = New System.Windows.Forms.Label()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        CType(Me.picMainPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picMainPic
        '
        Me.picMainPic.Image = CType(resources.GetObject("picMainPic.Image"), System.Drawing.Image)
        Me.picMainPic.Location = New System.Drawing.Point(12, 12)
        Me.picMainPic.Name = "picMainPic"
        Me.picMainPic.Size = New System.Drawing.Size(176, 203)
        Me.picMainPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMainPic.TabIndex = 0
        Me.picMainPic.TabStop = False
        '
        'lblStoreName
        '
        Me.lblStoreName.AutoSize = True
        Me.lblStoreName.Font = New System.Drawing.Font("Candara", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStoreName.Location = New System.Drawing.Point(281, 53)
        Me.lblStoreName.Name = "lblStoreName"
        Me.lblStoreName.Size = New System.Drawing.Size(119, 26)
        Me.lblStoreName.TabIndex = 1
        Me.lblStoreName.Text = "Store Name"
        '
        'lblItemName
        '
        Me.lblItemName.AutoSize = True
        Me.lblItemName.Font = New System.Drawing.Font("Candara", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemName.Location = New System.Drawing.Point(225, 165)
        Me.lblItemName.Name = "lblItemName"
        Me.lblItemName.Size = New System.Drawing.Size(54, 26)
        Me.lblItemName.TabIndex = 2
        Me.lblItemName.Text = "Item"
        '
        'lblCost
        '
        Me.lblCost.AutoSize = True
        Me.lblCost.Font = New System.Drawing.Font("Candara", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCost.Location = New System.Drawing.Point(228, 201)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(53, 26)
        Me.lblCost.TabIndex = 3
        Me.lblCost.Text = "Cost"
        '
        'lblTaxAmount
        '
        Me.lblTaxAmount.AutoSize = True
        Me.lblTaxAmount.Font = New System.Drawing.Font("Candara", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTaxAmount.Location = New System.Drawing.Point(90, 253)
        Me.lblTaxAmount.Name = "lblTaxAmount"
        Me.lblTaxAmount.Size = New System.Drawing.Size(48, 26)
        Me.lblTaxAmount.TabIndex = 4
        Me.lblTaxAmount.Text = "Tax:"
        '
        'lblFinalPrice
        '
        Me.lblFinalPrice.AutoSize = True
        Me.lblFinalPrice.Font = New System.Drawing.Font("Candara", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFinalPrice.Location = New System.Drawing.Point(75, 290)
        Me.lblFinalPrice.Name = "lblFinalPrice"
        Me.lblFinalPrice.Size = New System.Drawing.Size(105, 26)
        Me.lblFinalPrice.TabIndex = 5
        Me.lblFinalPrice.Text = "Final Cost:"
        '
        'txtItem
        '
        Me.txtItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtItem.Location = New System.Drawing.Point(280, 167)
        Me.txtItem.Name = "txtItem"
        Me.txtItem.Size = New System.Drawing.Size(100, 20)
        Me.txtItem.TabIndex = 6
        '
        'txtCost
        '
        Me.txtCost.Location = New System.Drawing.Point(280, 203)
        Me.txtCost.Name = "txtCost"
        Me.txtCost.Size = New System.Drawing.Size(100, 20)
        Me.txtCost.TabIndex = 7
        '
        'btnDisplayTotCost
        '
        Me.btnDisplayTotCost.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisplayTotCost.Location = New System.Drawing.Point(44, 342)
        Me.btnDisplayTotCost.Name = "btnDisplayTotCost"
        Me.btnDisplayTotCost.Size = New System.Drawing.Size(96, 23)
        Me.btnDisplayTotCost.TabIndex = 8
        Me.btnDisplayTotCost.Text = "Display Cost"
        Me.btnDisplayTotCost.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(178, 342)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(96, 23)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(312, 341)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(96, 23)
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblTaxRate
        '
        Me.lblTaxRate.AutoSize = True
        Me.lblTaxRate.Font = New System.Drawing.Font("Candara", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTaxRate.Location = New System.Drawing.Point(336, 253)
        Me.lblTaxRate.Name = "lblTaxRate"
        Me.lblTaxRate.Size = New System.Drawing.Size(81, 26)
        Me.lblTaxRate.TabIndex = 11
        Me.lblTaxRate.Text = "$888.88"
        '
        'lblTotalCost
        '
        Me.lblTotalCost.AutoSize = True
        Me.lblTotalCost.Font = New System.Drawing.Font("Candara", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCost.Location = New System.Drawing.Point(336, 290)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(81, 26)
        Me.lblTotalCost.TabIndex = 12
        Me.lblTotalCost.Text = "$888.88"
        '
        'frmSalesTaxCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(453, 390)
        Me.Controls.Add(Me.lblTotalCost)
        Me.Controls.Add(Me.lblTaxRate)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDisplayTotCost)
        Me.Controls.Add(Me.txtCost)
        Me.Controls.Add(Me.txtItem)
        Me.Controls.Add(Me.lblFinalPrice)
        Me.Controls.Add(Me.lblTaxAmount)
        Me.Controls.Add(Me.lblCost)
        Me.Controls.Add(Me.lblItemName)
        Me.Controls.Add(Me.lblStoreName)
        Me.Controls.Add(Me.picMainPic)
        Me.Name = "frmSalesTaxCalculator"
        Me.Text = "Sales Tax Calculator"
        CType(Me.picMainPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picMainPic As System.Windows.Forms.PictureBox
    Friend WithEvents lblStoreName As System.Windows.Forms.Label
    Friend WithEvents lblItemName As System.Windows.Forms.Label
    Friend WithEvents lblCost As System.Windows.Forms.Label
    Friend WithEvents lblTaxAmount As System.Windows.Forms.Label
    Friend WithEvents lblFinalPrice As System.Windows.Forms.Label
    Friend WithEvents txtItem As System.Windows.Forms.TextBox
    Friend WithEvents txtCost As System.Windows.Forms.TextBox
    Friend WithEvents btnDisplayTotCost As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblTaxRate As System.Windows.Forms.Label
    Friend WithEvents lblTotalCost As System.Windows.Forms.Label

End Class
