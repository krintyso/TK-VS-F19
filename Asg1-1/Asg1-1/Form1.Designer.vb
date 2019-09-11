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
        Me.UpdateLabelHighValyrian = New System.Windows.Forms.Button()
        Me.UpdateLabelKlingon = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.UpdateLabelEnglish = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'UpdateLabelHighValyrian
        '
        Me.UpdateLabelHighValyrian.Location = New System.Drawing.Point(220, 328)
        Me.UpdateLabelHighValyrian.Name = "UpdateLabelHighValyrian"
        Me.UpdateLabelHighValyrian.Size = New System.Drawing.Size(75, 46)
        Me.UpdateLabelHighValyrian.TabIndex = 0
        Me.UpdateLabelHighValyrian.Text = "High Valyrian"
        Me.UpdateLabelHighValyrian.UseVisualStyleBackColor = True
        '
        'UpdateLabelKlingon
        '
        Me.UpdateLabelKlingon.Location = New System.Drawing.Point(527, 328)
        Me.UpdateLabelKlingon.Name = "UpdateLabelKlingon"
        Me.UpdateLabelKlingon.Size = New System.Drawing.Size(75, 46)
        Me.UpdateLabelKlingon.TabIndex = 1
        Me.UpdateLabelKlingon.Text = "Klingon"
        Me.UpdateLabelKlingon.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(385, 210)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 17)
        Me.Label1.TabIndex = 2
        '
        'UpdateLabelEnglish
        '
        Me.UpdateLabelEnglish.Location = New System.Drawing.Point(368, 328)
        Me.UpdateLabelEnglish.Name = "UpdateLabelEnglish"
        Me.UpdateLabelEnglish.Size = New System.Drawing.Size(75, 46)
        Me.UpdateLabelEnglish.TabIndex = 3
        Me.UpdateLabelEnglish.Text = "English"
        Me.UpdateLabelEnglish.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(681, 403)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 35)
        Me.ExitButton.TabIndex = 4
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.UpdateLabelEnglish)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.UpdateLabelKlingon)
        Me.Controls.Add(Me.UpdateLabelHighValyrian)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UpdateLabelHighValyrian As Button
    Friend WithEvents UpdateLabelKlingon As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents UpdateLabelEnglish As Button
    Friend WithEvents ExitButton As Button
End Class
