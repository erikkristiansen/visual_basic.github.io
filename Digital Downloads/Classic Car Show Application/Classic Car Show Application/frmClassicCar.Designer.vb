<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClassicCar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmClassicCar))
        Me.mnuFile = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClear = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblClassicCarHeading = New System.Windows.Forms.Label()
        Me.lblTotalValIns = New System.Windows.Forms.Label()
        Me.btnComputeInventory = New System.Windows.Forms.Button()
        Me.lblCarInventory = New System.Windows.Forms.Label()
        Me.lblTotalCarsInShowHeading = New System.Windows.Forms.Label()
        Me.lblTotalCars = New System.Windows.Forms.Label()
        Me.lblTotalCarValHeading = New System.Windows.Forms.Label()
        Me.lblTotalCarValue = New System.Windows.Forms.Label()
        Me.lstCars = New System.Windows.Forms.ListBox()
        Me.picCar = New System.Windows.Forms.PictureBox()
        Me.mnuFile.SuspendLayout()
        CType(Me.picCar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mnuFile
        '
        Me.mnuFile.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.mnuFile.Location = New System.Drawing.Point(0, 0)
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(474, 24)
        Me.mnuFile.TabIndex = 0
        Me.mnuFile.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClear, Me.mnuExit})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'mnuClear
        '
        Me.mnuClear.Name = "mnuClear"
        Me.mnuClear.Size = New System.Drawing.Size(152, 22)
        Me.mnuClear.Text = "Clear"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(152, 22)
        Me.mnuExit.Text = "Exit"
        '
        'lblClassicCarHeading
        '
        Me.lblClassicCarHeading.AutoSize = True
        Me.lblClassicCarHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClassicCarHeading.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblClassicCarHeading.Location = New System.Drawing.Point(12, 38)
        Me.lblClassicCarHeading.Name = "lblClassicCarHeading"
        Me.lblClassicCarHeading.Size = New System.Drawing.Size(245, 31)
        Me.lblClassicCarHeading.TabIndex = 1
        Me.lblClassicCarHeading.Text = "Classic Car Show"
        '
        'lblTotalValIns
        '
        Me.lblTotalValIns.AutoSize = True
        Me.lblTotalValIns.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalValIns.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblTotalValIns.Location = New System.Drawing.Point(25, 69)
        Me.lblTotalValIns.Name = "lblTotalValIns"
        Me.lblTotalValIns.Size = New System.Drawing.Size(196, 18)
        Me.lblTotalValIns.TabIndex = 2
        Me.lblTotalValIns.Text = "Total Value for Insurance"
        '
        'btnComputeInventory
        '
        Me.btnComputeInventory.BackColor = System.Drawing.Color.SteelBlue
        Me.btnComputeInventory.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnComputeInventory.ForeColor = System.Drawing.Color.White
        Me.btnComputeInventory.Location = New System.Drawing.Point(286, 48)
        Me.btnComputeInventory.Name = "btnComputeInventory"
        Me.btnComputeInventory.Size = New System.Drawing.Size(158, 39)
        Me.btnComputeInventory.TabIndex = 3
        Me.btnComputeInventory.Text = "Compute Inventory"
        Me.btnComputeInventory.UseVisualStyleBackColor = False
        '
        'lblCarInventory
        '
        Me.lblCarInventory.AutoSize = True
        Me.lblCarInventory.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCarInventory.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblCarInventory.Location = New System.Drawing.Point(147, 103)
        Me.lblCarInventory.Name = "lblCarInventory"
        Me.lblCarInventory.Size = New System.Drawing.Size(178, 20)
        Me.lblCarInventory.TabIndex = 4
        Me.lblCarInventory.Text = "Classic Car Inventory"
        '
        'lblTotalCarsInShowHeading
        '
        Me.lblTotalCarsInShowHeading.AutoSize = True
        Me.lblTotalCarsInShowHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCarsInShowHeading.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblTotalCarsInShowHeading.Location = New System.Drawing.Point(15, 140)
        Me.lblTotalCarsInShowHeading.Name = "lblTotalCarsInShowHeading"
        Me.lblTotalCarsInShowHeading.Size = New System.Drawing.Size(137, 16)
        Me.lblTotalCarsInShowHeading.TabIndex = 5
        Me.lblTotalCarsInShowHeading.Text = "Total Cars In Show"
        Me.lblTotalCarsInShowHeading.Visible = False
        '
        'lblTotalCars
        '
        Me.lblTotalCars.AutoSize = True
        Me.lblTotalCars.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCars.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblTotalCars.Location = New System.Drawing.Point(158, 140)
        Me.lblTotalCars.Name = "lblTotalCars"
        Me.lblTotalCars.Size = New System.Drawing.Size(53, 16)
        Me.lblTotalCars.TabIndex = 6
        Me.lblTotalCars.Text = "XXXXX"
        Me.lblTotalCars.Visible = False
        '
        'lblTotalCarValHeading
        '
        Me.lblTotalCarValHeading.AutoSize = True
        Me.lblTotalCarValHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCarValHeading.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblTotalCarValHeading.Location = New System.Drawing.Point(229, 140)
        Me.lblTotalCarValHeading.Name = "lblTotalCarValHeading"
        Me.lblTotalCarValHeading.Size = New System.Drawing.Size(141, 16)
        Me.lblTotalCarValHeading.TabIndex = 7
        Me.lblTotalCarValHeading.Text = "Total Value of Cars"
        Me.lblTotalCarValHeading.Visible = False
        '
        'lblTotalCarValue
        '
        Me.lblTotalCarValue.AutoSize = True
        Me.lblTotalCarValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCarValue.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblTotalCarValue.Location = New System.Drawing.Point(376, 140)
        Me.lblTotalCarValue.Name = "lblTotalCarValue"
        Me.lblTotalCarValue.Size = New System.Drawing.Size(80, 16)
        Me.lblTotalCarValue.TabIndex = 8
        Me.lblTotalCarValue.Text = "XXXXXXXX"
        Me.lblTotalCarValue.Visible = False
        '
        'lstCars
        '
        Me.lstCars.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstCars.ForeColor = System.Drawing.Color.SteelBlue
        Me.lstCars.FormattingEnabled = True
        Me.lstCars.ItemHeight = 16
        Me.lstCars.Location = New System.Drawing.Point(28, 159)
        Me.lstCars.Name = "lstCars"
        Me.lstCars.Size = New System.Drawing.Size(183, 212)
        Me.lstCars.TabIndex = 9
        Me.lstCars.Visible = False
        '
        'picCar
        '
        Me.picCar.Image = CType(resources.GetObject("picCar.Image"), System.Drawing.Image)
        Me.picCar.Location = New System.Drawing.Point(232, 159)
        Me.picCar.Name = "picCar"
        Me.picCar.Size = New System.Drawing.Size(230, 212)
        Me.picCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCar.TabIndex = 10
        Me.picCar.TabStop = False
        Me.picCar.Visible = False
        '
        'frmClassicCar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(474, 387)
        Me.Controls.Add(Me.picCar)
        Me.Controls.Add(Me.lstCars)
        Me.Controls.Add(Me.lblTotalCarValue)
        Me.Controls.Add(Me.lblTotalCarValHeading)
        Me.Controls.Add(Me.lblTotalCars)
        Me.Controls.Add(Me.lblTotalCarsInShowHeading)
        Me.Controls.Add(Me.lblCarInventory)
        Me.Controls.Add(Me.btnComputeInventory)
        Me.Controls.Add(Me.lblTotalValIns)
        Me.Controls.Add(Me.lblClassicCarHeading)
        Me.Controls.Add(Me.mnuFile)
        Me.MainMenuStrip = Me.mnuFile
        Me.Name = "frmClassicCar"
        Me.Text = "Classic Car Show"
        Me.mnuFile.ResumeLayout(False)
        Me.mnuFile.PerformLayout()
        CType(Me.picCar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mnuFile As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuClear As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblClassicCarHeading As System.Windows.Forms.Label
    Friend WithEvents lblTotalValIns As System.Windows.Forms.Label
    Friend WithEvents btnComputeInventory As System.Windows.Forms.Button
    Friend WithEvents lblCarInventory As System.Windows.Forms.Label
    Friend WithEvents lblTotalCarsInShowHeading As System.Windows.Forms.Label
    Friend WithEvents lblTotalCars As System.Windows.Forms.Label
    Friend WithEvents lblTotalCarValHeading As System.Windows.Forms.Label
    Friend WithEvents lblTotalCarValue As System.Windows.Forms.Label
    Friend WithEvents lstCars As System.Windows.Forms.ListBox
    Friend WithEvents picCar As System.Windows.Forms.PictureBox

End Class
