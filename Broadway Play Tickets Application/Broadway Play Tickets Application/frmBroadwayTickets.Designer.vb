<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBroadwayTickets
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBroadwayTickets))
        Me.picBroadway = New System.Windows.Forms.PictureBox()
        Me.lblBroadwayHeading = New System.Windows.Forms.Label()
        Me.cboPlayChoice = New System.Windows.Forms.ComboBox()
        Me.lblSeats = New System.Windows.Forms.Label()
        Me.txtNumberOfSeats = New System.Windows.Forms.TextBox()
        Me.btnCalculateCost = New System.Windows.Forms.Button()
        Me.lblSubTotal = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblFinalTotal = New System.Windows.Forms.Label()
        Me.lblSubTotalCost = New System.Windows.Forms.Label()
        Me.lblTaxAmount = New System.Windows.Forms.Label()
        Me.lblFinalAmount = New System.Windows.Forms.Label()
        Me.radOrchestra = New System.Windows.Forms.RadioButton()
        Me.radMezzanine = New System.Windows.Forms.RadioButton()
        CType(Me.picBroadway, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picBroadway
        '
        Me.picBroadway.BackgroundImage = CType(resources.GetObject("picBroadway.BackgroundImage"), System.Drawing.Image)
        Me.picBroadway.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picBroadway.Location = New System.Drawing.Point(21, 12)
        Me.picBroadway.Name = "picBroadway"
        Me.picBroadway.Size = New System.Drawing.Size(242, 211)
        Me.picBroadway.TabIndex = 0
        Me.picBroadway.TabStop = False
        '
        'lblBroadwayHeading
        '
        Me.lblBroadwayHeading.AutoSize = True
        Me.lblBroadwayHeading.BackColor = System.Drawing.Color.Maroon
        Me.lblBroadwayHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBroadwayHeading.ForeColor = System.Drawing.Color.White
        Me.lblBroadwayHeading.Location = New System.Drawing.Point(308, 28)
        Me.lblBroadwayHeading.Name = "lblBroadwayHeading"
        Me.lblBroadwayHeading.Size = New System.Drawing.Size(187, 20)
        Me.lblBroadwayHeading.TabIndex = 1
        Me.lblBroadwayHeading.Text = "Broadway Play Tickets"
        '
        'cboPlayChoice
        '
        Me.cboPlayChoice.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPlayChoice.FormattingEnabled = True
        Me.cboPlayChoice.Items.AddRange(New Object() {"Lion King", "Wicked", "Phantom Of The Opera"})
        Me.cboPlayChoice.Location = New System.Drawing.Point(300, 70)
        Me.cboPlayChoice.Name = "cboPlayChoice"
        Me.cboPlayChoice.Size = New System.Drawing.Size(204, 21)
        Me.cboPlayChoice.TabIndex = 2
        Me.cboPlayChoice.Text = "Play Selection"
        '
        'lblSeats
        '
        Me.lblSeats.AutoSize = True
        Me.lblSeats.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeats.Location = New System.Drawing.Point(312, 112)
        Me.lblSeats.Name = "lblSeats"
        Me.lblSeats.Size = New System.Drawing.Size(173, 16)
        Me.lblSeats.TabIndex = 3
        Me.lblSeats.Text = "Enter Number Of Seats: "
        Me.lblSeats.Visible = False
        '
        'txtNumberOfSeats
        '
        Me.txtNumberOfSeats.Location = New System.Drawing.Point(367, 140)
        Me.txtNumberOfSeats.Name = "txtNumberOfSeats"
        Me.txtNumberOfSeats.Size = New System.Drawing.Size(60, 20)
        Me.txtNumberOfSeats.TabIndex = 4
        Me.txtNumberOfSeats.Visible = False
        '
        'btnCalculateCost
        '
        Me.btnCalculateCost.BackColor = System.Drawing.Color.Maroon
        Me.btnCalculateCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculateCost.ForeColor = System.Drawing.Color.White
        Me.btnCalculateCost.Location = New System.Drawing.Point(438, 194)
        Me.btnCalculateCost.Name = "btnCalculateCost"
        Me.btnCalculateCost.Size = New System.Drawing.Size(75, 46)
        Me.btnCalculateCost.TabIndex = 7
        Me.btnCalculateCost.Text = "Calculate " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Cost"
        Me.btnCalculateCost.UseVisualStyleBackColor = False
        Me.btnCalculateCost.Visible = False
        '
        'lblSubTotal
        '
        Me.lblSubTotal.AutoSize = True
        Me.lblSubTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubTotal.Location = New System.Drawing.Point(300, 271)
        Me.lblSubTotal.Name = "lblSubTotal"
        Me.lblSubTotal.Size = New System.Drawing.Size(79, 16)
        Me.lblSubTotal.TabIndex = 8
        Me.lblSubTotal.Text = "Sub Total:"
        Me.lblSubTotal.Visible = False
        '
        'lblTax
        '
        Me.lblTax.AutoSize = True
        Me.lblTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTax.Location = New System.Drawing.Point(300, 301)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(38, 16)
        Me.lblTax.TabIndex = 9
        Me.lblTax.Text = "Tax:"
        Me.lblTax.Visible = False
        '
        'lblFinalTotal
        '
        Me.lblFinalTotal.AutoSize = True
        Me.lblFinalTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFinalTotal.Location = New System.Drawing.Point(300, 331)
        Me.lblFinalTotal.Name = "lblFinalTotal"
        Me.lblFinalTotal.Size = New System.Drawing.Size(90, 16)
        Me.lblFinalTotal.TabIndex = 10
        Me.lblFinalTotal.Text = "Final Total: "
        Me.lblFinalTotal.Visible = False
        '
        'lblSubTotalCost
        '
        Me.lblSubTotalCost.AutoSize = True
        Me.lblSubTotalCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubTotalCost.Location = New System.Drawing.Point(456, 274)
        Me.lblSubTotalCost.Name = "lblSubTotalCost"
        Me.lblSubTotalCost.Size = New System.Drawing.Size(71, 16)
        Me.lblSubTotalCost.TabIndex = 11
        Me.lblSubTotalCost.Text = "XXXXXXX"
        Me.lblSubTotalCost.Visible = False
        '
        'lblTaxAmount
        '
        Me.lblTaxAmount.AutoSize = True
        Me.lblTaxAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTaxAmount.Location = New System.Drawing.Point(456, 302)
        Me.lblTaxAmount.Name = "lblTaxAmount"
        Me.lblTaxAmount.Size = New System.Drawing.Size(71, 16)
        Me.lblTaxAmount.TabIndex = 12
        Me.lblTaxAmount.Text = "XXXXXXX"
        Me.lblTaxAmount.Visible = False
        '
        'lblFinalAmount
        '
        Me.lblFinalAmount.AutoSize = True
        Me.lblFinalAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFinalAmount.Location = New System.Drawing.Point(456, 330)
        Me.lblFinalAmount.Name = "lblFinalAmount"
        Me.lblFinalAmount.Size = New System.Drawing.Size(71, 16)
        Me.lblFinalAmount.TabIndex = 13
        Me.lblFinalAmount.Text = "XXXXXXX"
        Me.lblFinalAmount.Visible = False
        '
        'radOrchestra
        '
        Me.radOrchestra.AutoSize = True
        Me.radOrchestra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radOrchestra.Location = New System.Drawing.Point(297, 194)
        Me.radOrchestra.Name = "radOrchestra"
        Me.radOrchestra.Size = New System.Drawing.Size(93, 20)
        Me.radOrchestra.TabIndex = 15
        Me.radOrchestra.TabStop = True
        Me.radOrchestra.Text = "Orchestra"
        Me.radOrchestra.UseVisualStyleBackColor = True
        Me.radOrchestra.Visible = False
        '
        'radMezzanine
        '
        Me.radMezzanine.AutoSize = True
        Me.radMezzanine.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radMezzanine.Location = New System.Drawing.Point(297, 220)
        Me.radMezzanine.Name = "radMezzanine"
        Me.radMezzanine.Size = New System.Drawing.Size(99, 20)
        Me.radMezzanine.TabIndex = 16
        Me.radMezzanine.TabStop = True
        Me.radMezzanine.Text = "Mezzanine"
        Me.radMezzanine.UseVisualStyleBackColor = True
        Me.radMezzanine.Visible = False
        '
        'frmBroadwayTickets
        '
        Me.AcceptButton = Me.btnCalculateCost
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(554, 389)
        Me.Controls.Add(Me.radMezzanine)
        Me.Controls.Add(Me.radOrchestra)
        Me.Controls.Add(Me.lblFinalAmount)
        Me.Controls.Add(Me.lblTaxAmount)
        Me.Controls.Add(Me.lblSubTotalCost)
        Me.Controls.Add(Me.lblFinalTotal)
        Me.Controls.Add(Me.lblTax)
        Me.Controls.Add(Me.lblSubTotal)
        Me.Controls.Add(Me.btnCalculateCost)
        Me.Controls.Add(Me.txtNumberOfSeats)
        Me.Controls.Add(Me.lblSeats)
        Me.Controls.Add(Me.cboPlayChoice)
        Me.Controls.Add(Me.lblBroadwayHeading)
        Me.Controls.Add(Me.picBroadway)
        Me.Name = "frmBroadwayTickets"
        Me.Text = "Broadway Theatre Tickets"
        CType(Me.picBroadway, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picBroadway As System.Windows.Forms.PictureBox
    Friend WithEvents lblBroadwayHeading As System.Windows.Forms.Label
    Friend WithEvents cboPlayChoice As System.Windows.Forms.ComboBox
    Friend WithEvents lblSeats As System.Windows.Forms.Label
    Friend WithEvents txtNumberOfSeats As System.Windows.Forms.TextBox
    Friend WithEvents btnCalculateCost As System.Windows.Forms.Button
    Friend WithEvents lblSubTotal As System.Windows.Forms.Label
    Friend WithEvents lblTax As System.Windows.Forms.Label
    Friend WithEvents lblFinalTotal As System.Windows.Forms.Label
    Friend WithEvents lblSubTotalCost As System.Windows.Forms.Label
    Friend WithEvents lblTaxAmount As System.Windows.Forms.Label
    Friend WithEvents lblFinalAmount As System.Windows.Forms.Label
    Friend WithEvents radOrchestra As System.Windows.Forms.RadioButton
    Friend WithEvents radMezzanine As System.Windows.Forms.RadioButton

End Class
