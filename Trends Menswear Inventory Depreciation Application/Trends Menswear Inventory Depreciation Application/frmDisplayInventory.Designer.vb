<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDisplayInventory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDisplayInventory))
        Me.picMan2 = New System.Windows.Forms.PictureBox()
        Me.lblTitle2 = New System.Windows.Forms.Label()
        Me.lstDisplay = New System.Windows.Forms.ListBox()
        Me.btnReturn = New System.Windows.Forms.Button()
        CType(Me.picMan2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picMan2
        '
        Me.picMan2.Image = CType(resources.GetObject("picMan2.Image"), System.Drawing.Image)
        Me.picMan2.Location = New System.Drawing.Point(12, 12)
        Me.picMan2.Name = "picMan2"
        Me.picMan2.Size = New System.Drawing.Size(109, 90)
        Me.picMan2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMan2.TabIndex = 0
        Me.picMan2.TabStop = False
        '
        'lblTitle2
        '
        Me.lblTitle2.AutoSize = True
        Me.lblTitle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle2.ForeColor = System.Drawing.Color.Gray
        Me.lblTitle2.Location = New System.Drawing.Point(137, 12)
        Me.lblTitle2.Name = "lblTitle2"
        Me.lblTitle2.Size = New System.Drawing.Size(303, 25)
        Me.lblTitle2.TabIndex = 1
        Me.lblTitle2.Text = "Trends Menswear Inventory"
        '
        'lstDisplay
        '
        Me.lstDisplay.BackColor = System.Drawing.Color.OldLace
        Me.lstDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstDisplay.ForeColor = System.Drawing.Color.Gray
        Me.lstDisplay.FormattingEnabled = True
        Me.lstDisplay.ItemHeight = 20
        Me.lstDisplay.Location = New System.Drawing.Point(167, 73)
        Me.lstDisplay.Name = "lstDisplay"
        Me.lstDisplay.Size = New System.Drawing.Size(197, 184)
        Me.lstDisplay.TabIndex = 2
        '
        'btnReturn
        '
        Me.btnReturn.BackColor = System.Drawing.Color.OldLace
        Me.btnReturn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturn.ForeColor = System.Drawing.Color.Gray
        Me.btnReturn.Location = New System.Drawing.Point(167, 301)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(197, 23)
        Me.btnReturn.TabIndex = 3
        Me.btnReturn.Text = "Return to Application"
        Me.btnReturn.UseVisualStyleBackColor = False
        '
        'frmDisplayInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(476, 380)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.lstDisplay)
        Me.Controls.Add(Me.lblTitle2)
        Me.Controls.Add(Me.picMan2)
        Me.Name = "frmDisplayInventory"
        Me.Text = "Sorted Inventory Listing"
        CType(Me.picMan2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picMan2 As System.Windows.Forms.PictureBox
    Friend WithEvents lblTitle2 As System.Windows.Forms.Label
    Friend WithEvents lstDisplay As System.Windows.Forms.ListBox
    Friend WithEvents btnReturn As System.Windows.Forms.Button
End Class
