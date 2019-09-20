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
        Me.IdahoFlagButton = New System.Windows.Forms.Button()
        Me.RhodeIslandFlag = New System.Windows.Forms.Button()
        Me.OregonFlag = New System.Windows.Forms.Button()
        Me.TexasFlag = New System.Windows.Forms.Button()
        Me.FlagDisplay = New System.Windows.Forms.PictureBox()
        Me.exitbutton = New System.Windows.Forms.Button()
        CType(Me.FlagDisplay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdahoFlagButton
        '
        Me.IdahoFlagButton.Location = New System.Drawing.Point(12, 279)
        Me.IdahoFlagButton.Name = "IdahoFlagButton"
        Me.IdahoFlagButton.Size = New System.Drawing.Size(105, 64)
        Me.IdahoFlagButton.TabIndex = 0
        Me.IdahoFlagButton.Text = "Idaho"
        Me.IdahoFlagButton.UseVisualStyleBackColor = True
        '
        'RhodeIslandFlag
        '
        Me.RhodeIslandFlag.Location = New System.Drawing.Point(235, 279)
        Me.RhodeIslandFlag.Name = "RhodeIslandFlag"
        Me.RhodeIslandFlag.Size = New System.Drawing.Size(111, 64)
        Me.RhodeIslandFlag.TabIndex = 1
        Me.RhodeIslandFlag.Text = "Rhode Island"
        Me.RhodeIslandFlag.UseVisualStyleBackColor = True
        '
        'OregonFlag
        '
        Me.OregonFlag.Location = New System.Drawing.Point(451, 279)
        Me.OregonFlag.Name = "OregonFlag"
        Me.OregonFlag.Size = New System.Drawing.Size(115, 64)
        Me.OregonFlag.TabIndex = 2
        Me.OregonFlag.Text = "Oregon"
        Me.OregonFlag.UseVisualStyleBackColor = True
        '
        'TexasFlag
        '
        Me.TexasFlag.Location = New System.Drawing.Point(678, 279)
        Me.TexasFlag.Name = "TexasFlag"
        Me.TexasFlag.Size = New System.Drawing.Size(110, 64)
        Me.TexasFlag.TabIndex = 3
        Me.TexasFlag.Text = "Texas"
        Me.TexasFlag.UseVisualStyleBackColor = True
        '
        'FlagDisplay
        '
        Me.FlagDisplay.Location = New System.Drawing.Point(94, 12)
        Me.FlagDisplay.Name = "FlagDisplay"
        Me.FlagDisplay.Size = New System.Drawing.Size(597, 261)
        Me.FlagDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.FlagDisplay.TabIndex = 4
        Me.FlagDisplay.TabStop = False
        '
        'exitbutton
        '
        Me.exitbutton.Location = New System.Drawing.Point(12, 363)
        Me.exitbutton.Name = "exitbutton"
        Me.exitbutton.Size = New System.Drawing.Size(776, 64)
        Me.exitbutton.TabIndex = 5
        Me.exitbutton.Text = "Exit"
        Me.exitbutton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.exitbutton)
        Me.Controls.Add(Me.FlagDisplay)
        Me.Controls.Add(Me.TexasFlag)
        Me.Controls.Add(Me.OregonFlag)
        Me.Controls.Add(Me.RhodeIslandFlag)
        Me.Controls.Add(Me.IdahoFlagButton)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.FlagDisplay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents IdahoFlagButton As Button
    Friend WithEvents RhodeIslandFlag As Button
    Friend WithEvents OregonFlag As Button
    Friend WithEvents TexasFlag As Button
    Friend WithEvents FlagDisplay As PictureBox
    Friend WithEvents exitbutton As Button
End Class
