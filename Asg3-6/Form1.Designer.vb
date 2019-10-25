<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ShippingCostCalculatorForm
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
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.lbTextbox = New System.Windows.Forms.TextBox()
        Me.IDLabel = New System.Windows.Forms.Label()
        Me.Weightlabel = New System.Windows.Forms.Label()
        Me.ShippingChargeLabel = New System.Windows.Forms.Label()
        Me.ShippingChargeTextBox = New System.Windows.Forms.TextBox()
        Me.CalculateButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.Oztextbox = New System.Windows.Forms.TextBox()
        Me.lbLabel = New System.Windows.Forms.Label()
        Me.ozlabel = New System.Windows.Forms.Label()
        Me.InputsGroupBox = New System.Windows.Forms.GroupBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.OutputGroupBox = New System.Windows.Forms.GroupBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.InputsGroupBox.SuspendLayout()
        Me.OutputGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'IDTextBox
        '
        Me.IDTextBox.Location = New System.Drawing.Point(20, 53)
        Me.IDTextBox.MaxLength = 6
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(111, 22)
        Me.IDTextBox.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.IDTextBox, "Enter ID from package")
        '
        'lbTextbox
        '
        Me.lbTextbox.Location = New System.Drawing.Point(21, 144)
        Me.lbTextbox.Name = "lbTextbox"
        Me.lbTextbox.Size = New System.Drawing.Size(111, 22)
        Me.lbTextbox.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.lbTextbox, "Weight (Pounds)")
        '
        'IDLabel
        '
        Me.IDLabel.AutoSize = True
        Me.IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDLabel.Location = New System.Drawing.Point(7, 33)
        Me.IDLabel.Name = "IDLabel"
        Me.IDLabel.Size = New System.Drawing.Size(151, 17)
        Me.IDLabel.TabIndex = 2
        Me.IDLabel.Text = "6 character ID code"
        '
        'Weightlabel
        '
        Me.Weightlabel.AutoSize = True
        Me.Weightlabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Weightlabel.Location = New System.Drawing.Point(7, 121)
        Me.Weightlabel.Name = "Weightlabel"
        Me.Weightlabel.Size = New System.Drawing.Size(125, 17)
        Me.Weightlabel.TabIndex = 3
        Me.Weightlabel.Text = "Package Weight"
        '
        'ShippingChargeLabel
        '
        Me.ShippingChargeLabel.AutoSize = True
        Me.ShippingChargeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShippingChargeLabel.Location = New System.Drawing.Point(36, 115)
        Me.ShippingChargeLabel.Name = "ShippingChargeLabel"
        Me.ShippingChargeLabel.Size = New System.Drawing.Size(128, 17)
        Me.ShippingChargeLabel.TabIndex = 5
        Me.ShippingChargeLabel.Text = "Shipping Charge"
        '
        'ShippingChargeTextBox
        '
        Me.ShippingChargeTextBox.Location = New System.Drawing.Point(52, 135)
        Me.ShippingChargeTextBox.Name = "ShippingChargeTextBox"
        Me.ShippingChargeTextBox.ReadOnly = True
        Me.ShippingChargeTextBox.Size = New System.Drawing.Size(153, 22)
        Me.ShippingChargeTextBox.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.ShippingChargeTextBox, "Shipping Charge")
        '
        'CalculateButton
        '
        Me.CalculateButton.Location = New System.Drawing.Point(12, 291)
        Me.CalculateButton.Name = "CalculateButton"
        Me.CalculateButton.Size = New System.Drawing.Size(568, 147)
        Me.CalculateButton.TabIndex = 4
        Me.CalculateButton.Text = "&Calculate "
        Me.ToolTip1.SetToolTip(Me.CalculateButton, "Calculate Shipping Cost")
        Me.CalculateButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(612, 366)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(146, 72)
        Me.ExitButton.TabIndex = 6
        Me.ExitButton.Text = "E&xit"
        Me.ToolTip1.SetToolTip(Me.ExitButton, "Exit Program")
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(612, 291)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(146, 69)
        Me.ClearButton.TabIndex = 5
        Me.ClearButton.Text = "C&lear"
        Me.ToolTip1.SetToolTip(Me.ClearButton, "Clear text boxes")
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'Oztextbox
        '
        Me.Oztextbox.Location = New System.Drawing.Point(185, 144)
        Me.Oztextbox.Name = "Oztextbox"
        Me.Oztextbox.Size = New System.Drawing.Size(111, 22)
        Me.Oztextbox.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.Oztextbox, "Weight (Ounces)")
        '
        'lbLabel
        '
        Me.lbLabel.AutoSize = True
        Me.lbLabel.Location = New System.Drawing.Point(138, 147)
        Me.lbLabel.Name = "lbLabel"
        Me.lbLabel.Size = New System.Drawing.Size(30, 17)
        Me.lbLabel.TabIndex = 10
        Me.lbLabel.Text = ".lbs"
        '
        'ozlabel
        '
        Me.ozlabel.AutoSize = True
        Me.ozlabel.Location = New System.Drawing.Point(302, 149)
        Me.ozlabel.Name = "ozlabel"
        Me.ozlabel.Size = New System.Drawing.Size(27, 17)
        Me.ozlabel.TabIndex = 11
        Me.ozlabel.Text = ".oz"
        '
        'InputsGroupBox
        '
        Me.InputsGroupBox.Controls.Add(Me.IDLabel)
        Me.InputsGroupBox.Controls.Add(Me.ozlabel)
        Me.InputsGroupBox.Controls.Add(Me.IDTextBox)
        Me.InputsGroupBox.Controls.Add(Me.Oztextbox)
        Me.InputsGroupBox.Controls.Add(Me.lbLabel)
        Me.InputsGroupBox.Controls.Add(Me.Weightlabel)
        Me.InputsGroupBox.Controls.Add(Me.lbTextbox)
        Me.InputsGroupBox.Location = New System.Drawing.Point(26, 42)
        Me.InputsGroupBox.Name = "InputsGroupBox"
        Me.InputsGroupBox.Size = New System.Drawing.Size(390, 243)
        Me.InputsGroupBox.TabIndex = 12
        Me.InputsGroupBox.TabStop = False
        '
        'OutputGroupBox
        '
        Me.OutputGroupBox.Controls.Add(Me.ShippingChargeLabel)
        Me.OutputGroupBox.Controls.Add(Me.ShippingChargeTextBox)
        Me.OutputGroupBox.Location = New System.Drawing.Point(458, 42)
        Me.OutputGroupBox.Name = "OutputGroupBox"
        Me.OutputGroupBox.Size = New System.Drawing.Size(313, 243)
        Me.OutputGroupBox.TabIndex = 13
        Me.OutputGroupBox.TabStop = False
        '
        'ShippingCostCalculatorForm
        '
        Me.AcceptButton = Me.CalculateButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ClearButton
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.OutputGroupBox)
        Me.Controls.Add(Me.InputsGroupBox)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.CalculateButton)
        Me.Name = "ShippingCostCalculatorForm"
        Me.Text = "Shipping Cost Calculator"
        Me.InputsGroupBox.ResumeLayout(False)
        Me.InputsGroupBox.PerformLayout()
        Me.OutputGroupBox.ResumeLayout(False)
        Me.OutputGroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents lbTextbox As TextBox
    Friend WithEvents IDLabel As Label
    Friend WithEvents Weightlabel As Label
    Friend WithEvents ShippingChargeLabel As Label
    Friend WithEvents ShippingChargeTextBox As TextBox
    Friend WithEvents CalculateButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents Oztextbox As TextBox
    Friend WithEvents lbLabel As Label
    Friend WithEvents ozlabel As Label
    Friend WithEvents InputsGroupBox As GroupBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents OutputGroupBox As GroupBox
    Friend WithEvents ToolTip1 As ToolTip
End Class
