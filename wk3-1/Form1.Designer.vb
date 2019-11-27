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
        Me.rngButton = New System.Windows.Forms.Button()
        Me.rngListBox1 = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'rngButton
        '
        Me.rngButton.Location = New System.Drawing.Point(128, 135)
        Me.rngButton.Name = "rngButton"
        Me.rngButton.Size = New System.Drawing.Size(183, 93)
        Me.rngButton.TabIndex = 0
        Me.rngButton.Text = "Random Integers"
        Me.rngButton.UseVisualStyleBackColor = True
        '
        'rngListBox1
        '
        Me.rngListBox1.FormattingEnabled = True
        Me.rngListBox1.ItemHeight = 16
        Me.rngListBox1.Location = New System.Drawing.Point(478, 22)
        Me.rngListBox1.Name = "rngListBox1"
        Me.rngListBox1.Size = New System.Drawing.Size(290, 388)
        Me.rngListBox1.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.rngListBox1)
        Me.Controls.Add(Me.rngButton)
        Me.Name = "Form1"
        Me.Text = "Random Number integers"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents rngButton As Button
    Friend WithEvents rngListBox1 As ListBox
End Class
