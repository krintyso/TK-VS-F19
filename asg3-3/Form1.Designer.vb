<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InventoryCalculator
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
        Me.components = New System.ComponentModel.Container()
        Me.EndingInvlabel = New System.Windows.Forms.Label()
        Me.BeginningInvLabel = New System.Windows.Forms.Label()
        Me.CostsOfGoodslabel = New System.Windows.Forms.Label()
        Me.AverageInvtextbox = New System.Windows.Forms.TextBox()
        Me.AverageinvLabel = New System.Windows.Forms.Label()
        Me.TurnoverLabel = New System.Windows.Forms.Label()
        Me.Turnovertextbox = New System.Windows.Forms.TextBox()
        Me.CalculateButton = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.BeginInvTextBox = New System.Windows.Forms.TextBox()
        Me.EndInvTextBox = New System.Windows.Forms.TextBox()
        Me.Costofgoodstextbox = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'EndingInvlabel
        '
        Me.EndingInvlabel.AutoSize = True
        Me.EndingInvlabel.Location = New System.Drawing.Point(113, 150)
        Me.EndingInvlabel.Name = "EndingInvlabel"
        Me.EndingInvlabel.Size = New System.Drawing.Size(118, 17)
        Me.EndingInvlabel.TabIndex = 2
        Me.EndingInvlabel.Text = "Ending inventory "
        '
        'BeginningInvLabel
        '
        Me.BeginningInvLabel.AutoSize = True
        Me.BeginningInvLabel.Location = New System.Drawing.Point(113, 54)
        Me.BeginningInvLabel.Name = "BeginningInvLabel"
        Me.BeginningInvLabel.Size = New System.Drawing.Size(133, 17)
        Me.BeginningInvLabel.TabIndex = 3
        Me.BeginningInvLabel.Text = "Beginning Inventory"
        '
        'CostsOfGoodslabel
        '
        Me.CostsOfGoodslabel.AutoSize = True
        Me.CostsOfGoodslabel.Location = New System.Drawing.Point(113, 237)
        Me.CostsOfGoodslabel.Name = "CostsOfGoodslabel"
        Me.CostsOfGoodslabel.Size = New System.Drawing.Size(98, 17)
        Me.CostsOfGoodslabel.TabIndex = 5
        Me.CostsOfGoodslabel.Text = "Cost of Goods"
        '
        'AverageInvtextbox
        '
        Me.AverageInvtextbox.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.AverageInvtextbox.Location = New System.Drawing.Point(469, 85)
        Me.AverageInvtextbox.Name = "AverageInvtextbox"
        Me.AverageInvtextbox.ReadOnly = True
        Me.AverageInvtextbox.Size = New System.Drawing.Size(143, 22)
        Me.AverageInvtextbox.TabIndex = 6
        Me.AverageInvtextbox.TabStop = False
        Me.ToolTip1.SetToolTip(Me.AverageInvtextbox, "Average Inventory in Dollar amount")
        '
        'AverageinvLabel
        '
        Me.AverageinvLabel.AutoSize = True
        Me.AverageinvLabel.Location = New System.Drawing.Point(466, 54)
        Me.AverageinvLabel.Name = "AverageinvLabel"
        Me.AverageinvLabel.Size = New System.Drawing.Size(123, 17)
        Me.AverageinvLabel.TabIndex = 7
        Me.AverageinvLabel.Text = "Average Inventory"
        '
        'TurnoverLabel
        '
        Me.TurnoverLabel.AutoSize = True
        Me.TurnoverLabel.Location = New System.Drawing.Point(466, 150)
        Me.TurnoverLabel.Name = "TurnoverLabel"
        Me.TurnoverLabel.Size = New System.Drawing.Size(66, 17)
        Me.TurnoverLabel.TabIndex = 9
        Me.TurnoverLabel.Text = "Turnover"
        '
        'Turnovertextbox
        '
        Me.Turnovertextbox.Cursor = System.Windows.Forms.Cursors.Default
        Me.Turnovertextbox.Location = New System.Drawing.Point(469, 181)
        Me.Turnovertextbox.Name = "Turnovertextbox"
        Me.Turnovertextbox.ReadOnly = True
        Me.Turnovertextbox.Size = New System.Drawing.Size(143, 22)
        Me.Turnovertextbox.TabIndex = 8
        Me.Turnovertextbox.TabStop = False
        Me.ToolTip1.SetToolTip(Me.Turnovertextbox, "Turnover ")
        '
        'CalculateButton
        '
        Me.CalculateButton.Location = New System.Drawing.Point(34, 330)
        Me.CalculateButton.Name = "CalculateButton"
        Me.CalculateButton.Size = New System.Drawing.Size(521, 108)
        Me.CalculateButton.TabIndex = 4
        Me.CalculateButton.Text = "Calculate "
        Me.ToolTip1.SetToolTip(Me.CalculateButton, "Calcuate the Average inventory and Turnover")
        Me.CalculateButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(594, 330)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(154, 51)
        Me.ClearButton.TabIndex = 5
        Me.ClearButton.Text = "Clear"
        Me.ToolTip1.SetToolTip(Me.ClearButton, "Clear the information")
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(594, 387)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(154, 51)
        Me.ExitButton.TabIndex = 6
        Me.ExitButton.Text = "Exit"
        Me.ToolTip1.SetToolTip(Me.ExitButton, "Exit the program")
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'BeginInvTextBox
        '
        Me.BeginInvTextBox.Location = New System.Drawing.Point(116, 85)
        Me.BeginInvTextBox.Name = "BeginInvTextBox"
        Me.BeginInvTextBox.Size = New System.Drawing.Size(137, 22)
        Me.BeginInvTextBox.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.BeginInvTextBox, "Enter numeric value")
        '
        'EndInvTextBox
        '
        Me.EndInvTextBox.Location = New System.Drawing.Point(116, 181)
        Me.EndInvTextBox.Name = "EndInvTextBox"
        Me.EndInvTextBox.Size = New System.Drawing.Size(137, 22)
        Me.EndInvTextBox.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.EndInvTextBox, "Enter numeric value")
        '
        'Costofgoodstextbox
        '
        Me.Costofgoodstextbox.Location = New System.Drawing.Point(116, 273)
        Me.Costofgoodstextbox.Name = "Costofgoodstextbox"
        Me.Costofgoodstextbox.Size = New System.Drawing.Size(137, 22)
        Me.Costofgoodstextbox.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.Costofgoodstextbox, "Enter numeric value")
        '
        'InventoryCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Costofgoodstextbox)
        Me.Controls.Add(Me.EndInvTextBox)
        Me.Controls.Add(Me.BeginInvTextBox)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.CalculateButton)
        Me.Controls.Add(Me.TurnoverLabel)
        Me.Controls.Add(Me.Turnovertextbox)
        Me.Controls.Add(Me.AverageinvLabel)
        Me.Controls.Add(Me.AverageInvtextbox)
        Me.Controls.Add(Me.CostsOfGoodslabel)
        Me.Controls.Add(Me.BeginningInvLabel)
        Me.Controls.Add(Me.EndingInvlabel)
        Me.Name = "InventoryCalculator"
        Me.Text = "Inventory Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents EndingInvlabel As Label
    Friend WithEvents BeginningInvLabel As Label
    Friend WithEvents CostsOfGoodslabel As Label
    Friend WithEvents AverageInvtextbox As TextBox
    Friend WithEvents AverageinvLabel As Label
    Friend WithEvents TurnoverLabel As Label
    Friend WithEvents Turnovertextbox As TextBox
    Friend WithEvents CalculateButton As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents ClearButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents BeginInvTextBox As TextBox
    Friend WithEvents EndInvTextBox As TextBox
    Friend WithEvents Costofgoodstextbox As TextBox
    Friend WithEvents ToolTip1 As ToolTip
End Class
