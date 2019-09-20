<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserInput
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
        Me.Getinputbutton = New System.Windows.Forms.Button()
        Me.NumberTextBox = New System.Windows.Forms.TextBox()
        Me.NumberLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Getinputbutton
        '
        Me.Getinputbutton.Location = New System.Drawing.Point(414, 233)
        Me.Getinputbutton.Name = "Getinputbutton"
        Me.Getinputbutton.Size = New System.Drawing.Size(132, 79)
        Me.Getinputbutton.TabIndex = 0
        Me.Getinputbutton.Text = "Get Input"
        Me.Getinputbutton.UseVisualStyleBackColor = True
        '
        'NumberTextBox
        '
        Me.NumberTextBox.Location = New System.Drawing.Point(328, 161)
        Me.NumberTextBox.Name = "NumberTextBox"
        Me.NumberTextBox.Size = New System.Drawing.Size(228, 22)
        Me.NumberTextBox.TabIndex = 1
        '
        'NumberLabel
        '
        Me.NumberLabel.AutoSize = True
        Me.NumberLabel.Location = New System.Drawing.Point(212, 166)
        Me.NumberLabel.Name = "NumberLabel"
        Me.NumberLabel.Size = New System.Drawing.Size(110, 17)
        Me.NumberLabel.TabIndex = 2
        Me.NumberLabel.Text = "Enter a number "
        '
        'UserInput
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.NumberLabel)
        Me.Controls.Add(Me.NumberTextBox)
        Me.Controls.Add(Me.Getinputbutton)
        Me.Name = "UserInput"
        Me.Text = "Numbers"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Getinputbutton As Button
    Friend WithEvents NumberTextBox As TextBox
    Friend WithEvents NumberLabel As Label
End Class
