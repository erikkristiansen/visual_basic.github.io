<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCalculateCommute
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
        Me.lblCalculateHeading = New System.Windows.Forms.Label()
        Me.cboTransportationChoice = New System.Windows.Forms.ComboBox()
        Me.btnCalculateCommute = New System.Windows.Forms.Button()
        Me.lstTransportationQuestions = New System.Windows.Forms.ListBox()
        Me.lblMonthlyCost = New System.Windows.Forms.Label()
        Me.lblFinalMonthlyCost = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblCalculateHeading
        '
        Me.lblCalculateHeading.AutoSize = True
        Me.lblCalculateHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCalculateHeading.Location = New System.Drawing.Point(228, 38)
        Me.lblCalculateHeading.Name = "lblCalculateHeading"
        Me.lblCalculateHeading.Size = New System.Drawing.Size(213, 20)
        Me.lblCalculateHeading.TabIndex = 0
        Me.lblCalculateHeading.Text = "Calculate Your Commute:"
        '
        'cboTransportationChoice
        '
        Me.cboTransportationChoice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTransportationChoice.FormattingEnabled = True
        Me.cboTransportationChoice.Items.AddRange(New Object() {"Car", "Bus", "Train"})
        Me.cboTransportationChoice.Location = New System.Drawing.Point(256, 80)
        Me.cboTransportationChoice.Name = "cboTransportationChoice"
        Me.cboTransportationChoice.Size = New System.Drawing.Size(156, 24)
        Me.cboTransportationChoice.TabIndex = 1
        Me.cboTransportationChoice.Text = "Choose Your Ride:"
        '
        'btnCalculateCommute
        '
        Me.btnCalculateCommute.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculateCommute.Location = New System.Drawing.Point(256, 370)
        Me.btnCalculateCommute.Name = "btnCalculateCommute"
        Me.btnCalculateCommute.Size = New System.Drawing.Size(156, 23)
        Me.btnCalculateCommute.TabIndex = 2
        Me.btnCalculateCommute.Text = "Calculate Commute"
        Me.btnCalculateCommute.UseVisualStyleBackColor = True
        Me.btnCalculateCommute.Visible = False
        '
        'lstTransportationQuestions
        '
        Me.lstTransportationQuestions.FormattingEnabled = True
        Me.lstTransportationQuestions.Location = New System.Drawing.Point(94, 123)
        Me.lstTransportationQuestions.Name = "lstTransportationQuestions"
        Me.lstTransportationQuestions.Size = New System.Drawing.Size(469, 225)
        Me.lstTransportationQuestions.TabIndex = 3
        Me.lstTransportationQuestions.Visible = False
        '
        'lblMonthlyCost
        '
        Me.lblMonthlyCost.AutoSize = True
        Me.lblMonthlyCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonthlyCost.Location = New System.Drawing.Point(51, 423)
        Me.lblMonthlyCost.Name = "lblMonthlyCost"
        Me.lblMonthlyCost.Size = New System.Drawing.Size(261, 16)
        Me.lblMonthlyCost.TabIndex = 4
        Me.lblMonthlyCost.Text = "Your Monthly Transportation Cost is: "
        Me.lblMonthlyCost.Visible = False
        '
        'lblFinalMonthlyCost
        '
        Me.lblFinalMonthlyCost.AutoSize = True
        Me.lblFinalMonthlyCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFinalMonthlyCost.Location = New System.Drawing.Point(465, 423)
        Me.lblFinalMonthlyCost.Name = "lblFinalMonthlyCost"
        Me.lblFinalMonthlyCost.Size = New System.Drawing.Size(98, 16)
        Me.lblFinalMonthlyCost.TabIndex = 5
        Me.lblFinalMonthlyCost.Text = "XXXXXXXXXX"
        Me.lblFinalMonthlyCost.Visible = False
        '
        'frmCalculateCommute
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(668, 503)
        Me.Controls.Add(Me.lblFinalMonthlyCost)
        Me.Controls.Add(Me.lblMonthlyCost)
        Me.Controls.Add(Me.lstTransportationQuestions)
        Me.Controls.Add(Me.btnCalculateCommute)
        Me.Controls.Add(Me.cboTransportationChoice)
        Me.Controls.Add(Me.lblCalculateHeading)
        Me.Name = "frmCalculateCommute"
        Me.Text = "Calculate Your Commute"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCalculateHeading As System.Windows.Forms.Label
    Friend WithEvents cboTransportationChoice As System.Windows.Forms.ComboBox
    Friend WithEvents btnCalculateCommute As System.Windows.Forms.Button
    Friend WithEvents lstTransportationQuestions As System.Windows.Forms.ListBox
    Friend WithEvents lblMonthlyCost As System.Windows.Forms.Label
    Friend WithEvents lblFinalMonthlyCost As System.Windows.Forms.Label

End Class
