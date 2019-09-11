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
        Me.components = New System.ComponentModel.Container()
        Me.firstNumbertextbox = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Resulttextbox = New System.Windows.Forms.TextBox()
        Me.secondNumbertextbox = New System.Windows.Forms.TextBox()
        Me.Calculate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'firstNumbertextbox
        '
        Me.firstNumbertextbox.Location = New System.Drawing.Point(163, 101)
        Me.firstNumbertextbox.Name = "firstNumbertextbox"
        Me.firstNumbertextbox.Size = New System.Drawing.Size(187, 22)
        Me.firstNumbertextbox.TabIndex = 0
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'Resulttextbox
        '
        Me.Resulttextbox.Location = New System.Drawing.Point(163, 239)
        Me.Resulttextbox.Name = "Resulttextbox"
        Me.Resulttextbox.Size = New System.Drawing.Size(187, 22)
        Me.Resulttextbox.TabIndex = 2
        '
        'secondNumbertextbox
        '
        Me.secondNumbertextbox.Location = New System.Drawing.Point(163, 167)
        Me.secondNumbertextbox.Name = "secondNumbertextbox"
        Me.secondNumbertextbox.Size = New System.Drawing.Size(187, 22)
        Me.secondNumbertextbox.TabIndex = 3
        '
        'Calculate
        '
        Me.Calculate.Location = New System.Drawing.Point(584, 375)
        Me.Calculate.Name = "Calculate"
        Me.Calculate.Size = New System.Drawing.Size(94, 33)
        Me.Calculate.TabIndex = 4
        Me.Calculate.Text = "Calculate"
        Me.Calculate.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Calculate)
        Me.Controls.Add(Me.secondNumbertextbox)
        Me.Controls.Add(Me.Resulttextbox)
        Me.Controls.Add(Me.firstNumbertextbox)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents firstNumbertextbox As TextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents Resulttextbox As TextBox
    Friend WithEvents secondNumbertextbox As TextBox
    Friend WithEvents Calculate As Button
End Class
