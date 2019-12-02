<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.fileMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalculateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SummaryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.nameTextBox = New System.Windows.Forms.TextBox()
        Me.nameLabel = New System.Windows.Forms.Label()
        Me.monPriceTextBox = New System.Windows.Forms.TextBox()
        Me.mondayLabel = New System.Windows.Forms.Label()
        Me.tuesdayLabel = New System.Windows.Forms.Label()
        Me.tuesPriceTextBox = New System.Windows.Forms.TextBox()
        Me.wedLabel = New System.Windows.Forms.Label()
        Me.wedPriceTextBox = New System.Windows.Forms.TextBox()
        Me.buysellholdLabel = New System.Windows.Forms.Label()
        Me.buySellHoldTextbox = New System.Windows.Forms.TextBox()
        Me.fileMenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'fileMenuStrip
        '
        Me.fileMenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.fileMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.fileMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.fileMenuStrip.Name = "fileMenuStrip"
        Me.fileMenuStrip.Size = New System.Drawing.Size(800, 28)
        Me.fileMenuStrip.TabIndex = 0
        Me.fileMenuStrip.Text = "File"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(46, 24)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalculateToolStripMenuItem, Me.ClearToolStripMenuItem, Me.SummaryToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(49, 24)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'CalculateToolStripMenuItem
        '
        Me.CalculateToolStripMenuItem.Name = "CalculateToolStripMenuItem"
        Me.CalculateToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.CalculateToolStripMenuItem.Text = "&Calculate"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.ClearToolStripMenuItem.Text = "C&lear"
        '
        'SummaryToolStripMenuItem
        '
        Me.SummaryToolStripMenuItem.Name = "SummaryToolStripMenuItem"
        Me.SummaryToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.SummaryToolStripMenuItem.Text = "&Summary"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(55, 26)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(133, 26)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'nameTextBox
        '
        Me.nameTextBox.Location = New System.Drawing.Point(42, 145)
        Me.nameTextBox.Name = "nameTextBox"
        Me.nameTextBox.Size = New System.Drawing.Size(100, 22)
        Me.nameTextBox.TabIndex = 3
        '
        'nameLabel
        '
        Me.nameLabel.AutoSize = True
        Me.nameLabel.Location = New System.Drawing.Point(12, 125)
        Me.nameLabel.Name = "nameLabel"
        Me.nameLabel.Size = New System.Drawing.Size(84, 17)
        Me.nameLabel.TabIndex = 4
        Me.nameLabel.Text = "Stock Name"
        '
        'monPriceTextBox
        '
        Me.monPriceTextBox.Location = New System.Drawing.Point(42, 236)
        Me.monPriceTextBox.Name = "monPriceTextBox"
        Me.monPriceTextBox.Size = New System.Drawing.Size(100, 22)
        Me.monPriceTextBox.TabIndex = 5
        '
        'mondayLabel
        '
        Me.mondayLabel.AutoSize = True
        Me.mondayLabel.Location = New System.Drawing.Point(11, 216)
        Me.mondayLabel.Name = "mondayLabel"
        Me.mondayLabel.Size = New System.Drawing.Size(58, 17)
        Me.mondayLabel.TabIndex = 6
        Me.mondayLabel.Text = "Monday"
        '
        'tuesdayLabel
        '
        Me.tuesdayLabel.AutoSize = True
        Me.tuesdayLabel.Location = New System.Drawing.Point(202, 216)
        Me.tuesdayLabel.Name = "tuesdayLabel"
        Me.tuesdayLabel.Size = New System.Drawing.Size(63, 17)
        Me.tuesdayLabel.TabIndex = 8
        Me.tuesdayLabel.Text = "Tuesday"
        '
        'tuesPriceTextBox
        '
        Me.tuesPriceTextBox.Location = New System.Drawing.Point(233, 236)
        Me.tuesPriceTextBox.Name = "tuesPriceTextBox"
        Me.tuesPriceTextBox.Size = New System.Drawing.Size(100, 22)
        Me.tuesPriceTextBox.TabIndex = 7
        '
        'wedLabel
        '
        Me.wedLabel.AutoSize = True
        Me.wedLabel.Location = New System.Drawing.Point(376, 216)
        Me.wedLabel.Name = "wedLabel"
        Me.wedLabel.Size = New System.Drawing.Size(83, 17)
        Me.wedLabel.TabIndex = 10
        Me.wedLabel.Text = "Wednesday"
        '
        'wedPriceTextBox
        '
        Me.wedPriceTextBox.Location = New System.Drawing.Point(407, 236)
        Me.wedPriceTextBox.Name = "wedPriceTextBox"
        Me.wedPriceTextBox.Size = New System.Drawing.Size(100, 22)
        Me.wedPriceTextBox.TabIndex = 9
        '
        'buysellholdLabel
        '
        Me.buysellholdLabel.AutoSize = True
        Me.buysellholdLabel.Location = New System.Drawing.Point(12, 311)
        Me.buysellholdLabel.Name = "buysellholdLabel"
        Me.buysellholdLabel.Size = New System.Drawing.Size(92, 17)
        Me.buysellholdLabel.TabIndex = 11
        Me.buysellholdLabel.Text = "Buy/Sell/Hold"
        '
        'buySellHoldTextbox
        '
        Me.buySellHoldTextbox.Location = New System.Drawing.Point(42, 331)
        Me.buySellHoldTextbox.Name = "buySellHoldTextbox"
        Me.buySellHoldTextbox.ReadOnly = True
        Me.buySellHoldTextbox.Size = New System.Drawing.Size(100, 22)
        Me.buySellHoldTextbox.TabIndex = 12
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.buySellHoldTextbox)
        Me.Controls.Add(Me.buysellholdLabel)
        Me.Controls.Add(Me.wedLabel)
        Me.Controls.Add(Me.wedPriceTextBox)
        Me.Controls.Add(Me.tuesdayLabel)
        Me.Controls.Add(Me.tuesPriceTextBox)
        Me.Controls.Add(Me.mondayLabel)
        Me.Controls.Add(Me.monPriceTextBox)
        Me.Controls.Add(Me.nameLabel)
        Me.Controls.Add(Me.nameTextBox)
        Me.Controls.Add(Me.fileMenuStrip)
        Me.MainMenuStrip = Me.fileMenuStrip
        Me.Name = "Form1"
        Me.Text = "StockCalculator"
        Me.fileMenuStrip.ResumeLayout(False)
        Me.fileMenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents fileMenuStrip As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents nameTextBox As TextBox
    Friend WithEvents nameLabel As Label
    Friend WithEvents monPriceTextBox As TextBox
    Friend WithEvents mondayLabel As Label
    Friend WithEvents tuesdayLabel As Label
    Friend WithEvents tuesPriceTextBox As TextBox
    Friend WithEvents wedLabel As Label
    Friend WithEvents wedPriceTextBox As TextBox
    Friend WithEvents buysellholdLabel As Label
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CalculateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SummaryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents buySellHoldTextbox As TextBox
End Class
