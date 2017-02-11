<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class taxifareapplication
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(taxifareapplication))
        Me.pictaxipic = New System.Windows.Forms.PictureBox()
        Me.lblTaxiHeading = New System.Windows.Forms.Label()
        Me.lblsubHeading = New System.Windows.Forms.Label()
        Me.lblmilesTraveled = New System.Windows.Forms.Label()
        Me.lblTotalFare = New System.Windows.Forms.Label()
        Me.txtNumberOfMiles = New System.Windows.Forms.TextBox()
        Me.lblTotalMiles = New System.Windows.Forms.Label()
        Me.btnDisplayFare = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        CType(Me.pictaxipic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pictaxipic
        '
        Me.pictaxipic.Image = CType(resources.GetObject("pictaxipic.Image"), System.Drawing.Image)
        Me.pictaxipic.Location = New System.Drawing.Point(12, 12)
        Me.pictaxipic.Name = "pictaxipic"
        Me.pictaxipic.Size = New System.Drawing.Size(142, 164)
        Me.pictaxipic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictaxipic.TabIndex = 0
        Me.pictaxipic.TabStop = False
        '
        'lblTaxiHeading
        '
        Me.lblTaxiHeading.AutoSize = True
        Me.lblTaxiHeading.Font = New System.Drawing.Font("Sitka Small", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTaxiHeading.Location = New System.Drawing.Point(162, 31)
        Me.lblTaxiHeading.Name = "lblTaxiHeading"
        Me.lblTaxiHeading.Size = New System.Drawing.Size(206, 54)
        Me.lblTaxiHeading.TabIndex = 1
        Me.lblTaxiHeading.Text = "Taxi Fare"
        '
        'lblsubHeading
        '
        Me.lblsubHeading.AutoSize = True
        Me.lblsubHeading.Font = New System.Drawing.Font("Sitka Small", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsubHeading.Location = New System.Drawing.Point(167, 85)
        Me.lblsubHeading.Name = "lblsubHeading"
        Me.lblsubHeading.Size = New System.Drawing.Size(176, 19)
        Me.lblsubHeading.TabIndex = 2
        Me.lblsubHeading.Text = "Only $2.25 plus mileage"
        '
        'lblmilesTraveled
        '
        Me.lblmilesTraveled.AutoSize = True
        Me.lblmilesTraveled.Font = New System.Drawing.Font("Sitka Small", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmilesTraveled.Location = New System.Drawing.Point(61, 179)
        Me.lblmilesTraveled.Name = "lblmilesTraveled"
        Me.lblmilesTraveled.Size = New System.Drawing.Size(118, 19)
        Me.lblmilesTraveled.TabIndex = 3
        Me.lblmilesTraveled.Text = "Miles Traveled:"
        '
        'lblTotalFare
        '
        Me.lblTotalFare.AutoSize = True
        Me.lblTotalFare.Font = New System.Drawing.Font("Sitka Small", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalFare.Location = New System.Drawing.Point(65, 220)
        Me.lblTotalFare.Name = "lblTotalFare"
        Me.lblTotalFare.Size = New System.Drawing.Size(89, 19)
        Me.lblTotalFare.TabIndex = 4
        Me.lblTotalFare.Text = "Total Fare: "
        '
        'txtNumberOfMiles
        '
        Me.txtNumberOfMiles.Font = New System.Drawing.Font("Sitka Banner", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumberOfMiles.Location = New System.Drawing.Point(250, 179)
        Me.txtNumberOfMiles.Name = "txtNumberOfMiles"
        Me.txtNumberOfMiles.Size = New System.Drawing.Size(59, 24)
        Me.txtNumberOfMiles.TabIndex = 5
        Me.txtNumberOfMiles.Text = "888"
        '
        'lblTotalMiles
        '
        Me.lblTotalMiles.AutoSize = True
        Me.lblTotalMiles.Font = New System.Drawing.Font("Sitka Heading", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalMiles.Location = New System.Drawing.Point(256, 220)
        Me.lblTotalMiles.Name = "lblTotalMiles"
        Me.lblTotalMiles.Size = New System.Drawing.Size(53, 19)
        Me.lblTotalMiles.TabIndex = 6
        Me.lblTotalMiles.Text = "$888.88"
        '
        'btnDisplayFare
        '
        Me.btnDisplayFare.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisplayFare.Location = New System.Drawing.Point(15, 257)
        Me.btnDisplayFare.Name = "btnDisplayFare"
        Me.btnDisplayFare.Size = New System.Drawing.Size(95, 23)
        Me.btnDisplayFare.TabIndex = 7
        Me.btnDisplayFare.Text = "Display Fare"
        Me.btnDisplayFare.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(269, 257)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(95, 23)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(144, 257)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(95, 23)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'taxifareapplication
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gold
        Me.ClientSize = New System.Drawing.Size(380, 327)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDisplayFare)
        Me.Controls.Add(Me.lblTotalMiles)
        Me.Controls.Add(Me.txtNumberOfMiles)
        Me.Controls.Add(Me.lblTotalFare)
        Me.Controls.Add(Me.lblmilesTraveled)
        Me.Controls.Add(Me.lblsubHeading)
        Me.Controls.Add(Me.lblTaxiHeading)
        Me.Controls.Add(Me.pictaxipic)
        Me.Name = "taxifareapplication"
        Me.Text = "Taxi Meter Fare"
        CType(Me.pictaxipic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pictaxipic As System.Windows.Forms.PictureBox
    Friend WithEvents lblTaxiHeading As System.Windows.Forms.Label
    Friend WithEvents lblsubHeading As System.Windows.Forms.Label
    Friend WithEvents lblmilesTraveled As System.Windows.Forms.Label
    Friend WithEvents lblTotalFare As System.Windows.Forms.Label
    Friend WithEvents txtNumberOfMiles As System.Windows.Forms.TextBox
    Friend WithEvents lblTotalMiles As System.Windows.Forms.Label
    Friend WithEvents btnDisplayFare As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button

End Class
