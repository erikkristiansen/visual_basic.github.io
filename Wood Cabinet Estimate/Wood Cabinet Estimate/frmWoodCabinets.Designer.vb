<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWoodCabinets
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWoodCabinets))
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.lblLinearFeet = New System.Windows.Forms.Label()
        Me.txtFeet = New System.Windows.Forms.TextBox()
        Me.grpWoodType = New System.Windows.Forms.GroupBox()
        Me.radCherry = New System.Windows.Forms.RadioButton()
        Me.radOak = New System.Windows.Forms.RadioButton()
        Me.radPine = New System.Windows.Forms.RadioButton()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.lblCostEstimate = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.picCabinets = New System.Windows.Forms.PictureBox()
        Me.grpWoodType.SuspendLayout()
        CType(Me.picCabinets, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Georgia", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(28, 23)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(278, 31)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Wood Cabinet Cost"
        '
        'lblLinearFeet
        '
        Me.lblLinearFeet.AutoSize = True
        Me.lblLinearFeet.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLinearFeet.Location = New System.Drawing.Point(58, 79)
        Me.lblLinearFeet.Name = "lblLinearFeet"
        Me.lblLinearFeet.Size = New System.Drawing.Size(130, 23)
        Me.lblLinearFeet.TabIndex = 1
        Me.lblLinearFeet.Text = "Linear Feet:"
        '
        'txtFeet
        '
        Me.txtFeet.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFeet.Location = New System.Drawing.Point(203, 79)
        Me.txtFeet.Name = "txtFeet"
        Me.txtFeet.Size = New System.Drawing.Size(73, 29)
        Me.txtFeet.TabIndex = 2
        Me.txtFeet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'grpWoodType
        '
        Me.grpWoodType.BackColor = System.Drawing.Color.White
        Me.grpWoodType.Controls.Add(Me.radCherry)
        Me.grpWoodType.Controls.Add(Me.radOak)
        Me.grpWoodType.Controls.Add(Me.radPine)
        Me.grpWoodType.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpWoodType.Location = New System.Drawing.Point(83, 114)
        Me.grpWoodType.Name = "grpWoodType"
        Me.grpWoodType.Size = New System.Drawing.Size(160, 100)
        Me.grpWoodType.TabIndex = 3
        Me.grpWoodType.TabStop = False
        Me.grpWoodType.Text = "Wood Type"
        '
        'radCherry
        '
        Me.radCherry.AutoSize = True
        Me.radCherry.Location = New System.Drawing.Point(25, 77)
        Me.radCherry.Name = "radCherry"
        Me.radCherry.Size = New System.Drawing.Size(85, 27)
        Me.radCherry.TabIndex = 2
        Me.radCherry.Text = "Cherry"
        Me.radCherry.UseVisualStyleBackColor = True
        '
        'radOak
        '
        Me.radOak.AutoSize = True
        Me.radOak.Location = New System.Drawing.Point(25, 54)
        Me.radOak.Name = "radOak"
        Me.radOak.Size = New System.Drawing.Size(62, 27)
        Me.radOak.TabIndex = 1
        Me.radOak.Text = "Oak"
        Me.radOak.UseVisualStyleBackColor = True
        '
        'radPine
        '
        Me.radPine.AutoSize = True
        Me.radPine.Checked = True
        Me.radPine.Location = New System.Drawing.Point(25, 29)
        Me.radPine.Name = "radPine"
        Me.radPine.Size = New System.Drawing.Size(66, 27)
        Me.radPine.TabIndex = 0
        Me.radPine.TabStop = True
        Me.radPine.Text = "Pine"
        Me.radPine.UseVisualStyleBackColor = True
        '
        'lblCost
        '
        Me.lblCost.AutoSize = True
        Me.lblCost.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCost.Location = New System.Drawing.Point(39, 234)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(154, 23)
        Me.lblCost.TabIndex = 4
        Me.lblCost.Text = "Cost Estimate:"
        '
        'lblCostEstimate
        '
        Me.lblCostEstimate.AutoSize = True
        Me.lblCostEstimate.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCostEstimate.Location = New System.Drawing.Point(200, 234)
        Me.lblCostEstimate.Name = "lblCostEstimate"
        Me.lblCostEstimate.Size = New System.Drawing.Size(106, 23)
        Me.lblCostEstimate.TabIndex = 5
        Me.lblCostEstimate.Text = "$0000.00"
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(34, 282)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(100, 30)
        Me.btnCalculate.TabIndex = 6
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(204, 282)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(100, 30)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'picCabinets
        '
        Me.picCabinets.Image = CType(resources.GetObject("picCabinets.Image"), System.Drawing.Image)
        Me.picCabinets.Location = New System.Drawing.Point(2, 318)
        Me.picCabinets.Name = "picCabinets"
        Me.picCabinets.Size = New System.Drawing.Size(330, 115)
        Me.picCabinets.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCabinets.TabIndex = 8
        Me.picCabinets.TabStop = False
        '
        'frmWoodCabinets
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Moccasin
        Me.ClientSize = New System.Drawing.Size(334, 432)
        Me.Controls.Add(Me.picCabinets)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblCostEstimate)
        Me.Controls.Add(Me.lblCost)
        Me.Controls.Add(Me.grpWoodType)
        Me.Controls.Add(Me.txtFeet)
        Me.Controls.Add(Me.lblLinearFeet)
        Me.Controls.Add(Me.lblHeading)
        Me.Name = "frmWoodCabinets"
        Me.Text = "Wood Cabinet Estimate"
        Me.grpWoodType.ResumeLayout(False)
        Me.grpWoodType.PerformLayout()
        CType(Me.picCabinets, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblHeading As System.Windows.Forms.Label
    Friend WithEvents lblLinearFeet As System.Windows.Forms.Label
    Friend WithEvents txtFeet As System.Windows.Forms.TextBox
    Friend WithEvents grpWoodType As System.Windows.Forms.GroupBox
    Friend WithEvents radCherry As System.Windows.Forms.RadioButton
    Friend WithEvents radOak As System.Windows.Forms.RadioButton
    Friend WithEvents radPine As System.Windows.Forms.RadioButton
    Friend WithEvents lblCost As System.Windows.Forms.Label
    Friend WithEvents lblCostEstimate As System.Windows.Forms.Label
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents picCabinets As System.Windows.Forms.PictureBox

End Class
