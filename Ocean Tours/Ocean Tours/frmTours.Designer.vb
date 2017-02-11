<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTours
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTours))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblLength = New System.Windows.Forms.Label()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.lblTourType = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnFindCost = New System.Windows.Forms.Button()
        Me.lstTours = New System.Windows.Forms.ListBox()
        Me.lblSelect = New System.Windows.Forms.Label()
        Me.txtNumberInParty = New System.Windows.Forms.TextBox()
        Me.lblParty = New System.Windows.Forms.Label()
        Me.cboIsland = New System.Windows.Forms.ComboBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.lblLength)
        Me.Panel1.Controls.Add(Me.lblCost)
        Me.Panel1.Controls.Add(Me.lblTourType)
        Me.Panel1.Controls.Add(Me.btnClear)
        Me.Panel1.Controls.Add(Me.btnFindCost)
        Me.Panel1.Controls.Add(Me.lstTours)
        Me.Panel1.Controls.Add(Me.lblSelect)
        Me.Panel1.Controls.Add(Me.txtNumberInParty)
        Me.Panel1.Controls.Add(Me.lblParty)
        Me.Panel1.Controls.Add(Me.cboIsland)
        Me.Panel1.Controls.Add(Me.lblTitle)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(301, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(382, 448)
        Me.Panel1.TabIndex = 0
        '
        'lblLength
        '
        Me.lblLength.AutoSize = True
        Me.lblLength.Location = New System.Drawing.Point(115, 393)
        Me.lblLength.Name = "lblLength"
        Me.lblLength.Size = New System.Drawing.Size(108, 18)
        Me.lblLength.TabIndex = 10
        Me.lblLength.Text = "XXXXXXXXXX"
        Me.lblLength.Visible = False
        '
        'lblCost
        '
        Me.lblCost.AutoSize = True
        Me.lblCost.Location = New System.Drawing.Point(115, 370)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(108, 18)
        Me.lblCost.TabIndex = 9
        Me.lblCost.Text = "XXXXXXXXXX"
        Me.lblCost.Visible = False
        '
        'lblTourType
        '
        Me.lblTourType.AutoSize = True
        Me.lblTourType.Location = New System.Drawing.Point(115, 346)
        Me.lblTourType.Name = "lblTourType"
        Me.lblTourType.Size = New System.Drawing.Size(108, 18)
        Me.lblTourType.TabIndex = 8
        Me.lblTourType.Text = "XXXXXXXXXX"
        Me.lblTourType.Visible = False
        '
        'btnClear
        '
        Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClear.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(197, 292)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(146, 33)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear Form"
        Me.btnClear.UseVisualStyleBackColor = True
        Me.btnClear.Visible = False
        '
        'btnFindCost
        '
        Me.btnFindCost.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFindCost.Location = New System.Drawing.Point(20, 292)
        Me.btnFindCost.Name = "btnFindCost"
        Me.btnFindCost.Size = New System.Drawing.Size(146, 33)
        Me.btnFindCost.TabIndex = 6
        Me.btnFindCost.Text = "Find Cost of Tour"
        Me.btnFindCost.UseVisualStyleBackColor = True
        Me.btnFindCost.Visible = False
        '
        'lstTours
        '
        Me.lstTours.FormattingEnabled = True
        Me.lstTours.ItemHeight = 18
        Me.lstTours.Location = New System.Drawing.Point(121, 185)
        Me.lstTours.Name = "lstTours"
        Me.lstTours.Size = New System.Drawing.Size(120, 94)
        Me.lstTours.TabIndex = 5
        Me.lstTours.Visible = False
        '
        'lblSelect
        '
        Me.lblSelect.AutoSize = True
        Me.lblSelect.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelect.Location = New System.Drawing.Point(118, 160)
        Me.lblSelect.Name = "lblSelect"
        Me.lblSelect.Size = New System.Drawing.Size(125, 17)
        Me.lblSelect.TabIndex = 4
        Me.lblSelect.Text = "Select Ocean Tour: "
        Me.lblSelect.Visible = False
        '
        'txtNumberInParty
        '
        Me.txtNumberInParty.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumberInParty.Location = New System.Drawing.Point(266, 115)
        Me.txtNumberInParty.Name = "txtNumberInParty"
        Me.txtNumberInParty.Size = New System.Drawing.Size(44, 25)
        Me.txtNumberInParty.TabIndex = 3
        Me.txtNumberInParty.Visible = False
        '
        'lblParty
        '
        Me.lblParty.AutoSize = True
        Me.lblParty.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblParty.Location = New System.Drawing.Point(90, 119)
        Me.lblParty.Name = "lblParty"
        Me.lblParty.Size = New System.Drawing.Size(109, 17)
        Me.lblParty.TabIndex = 2
        Me.lblParty.Text = "Number in Party:"
        Me.lblParty.Visible = False
        '
        'cboIsland
        '
        Me.cboIsland.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboIsland.FormattingEnabled = True
        Me.cboIsland.Items.AddRange(New Object() {"Aruba ", "Jamaica", "Key West"})
        Me.cboIsland.Location = New System.Drawing.Point(70, 70)
        Me.cboIsland.Name = "cboIsland"
        Me.cboIsland.Size = New System.Drawing.Size(240, 25)
        Me.cboIsland.TabIndex = 1
        Me.cboIsland.Text = "Select Island Location"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.LightGray
        Me.lblTitle.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(15, 14)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(281, 23)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Ocean Tours Information"
        '
        'frmTours
        '
        Me.AcceptButton = Me.btnFindCost
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.CancelButton = Me.btnClear
        Me.ClientSize = New System.Drawing.Size(684, 451)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmTours"
        Me.Text = "Information on Available Tours"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblLength As System.Windows.Forms.Label
    Friend WithEvents lblCost As System.Windows.Forms.Label
    Friend WithEvents lblTourType As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnFindCost As System.Windows.Forms.Button
    Friend WithEvents lstTours As System.Windows.Forms.ListBox
    Friend WithEvents lblSelect As System.Windows.Forms.Label
    Friend WithEvents txtNumberInParty As System.Windows.Forms.TextBox
    Friend WithEvents lblParty As System.Windows.Forms.Label
    Friend WithEvents cboIsland As System.Windows.Forms.ComboBox
    Friend WithEvents lblTitle As System.Windows.Forms.Label

End Class
