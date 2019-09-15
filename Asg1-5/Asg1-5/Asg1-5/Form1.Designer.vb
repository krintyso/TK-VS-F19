<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Specials
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
        Me.DinerName = New System.Windows.Forms.Label()
        Me.FoodDisplay = New System.Windows.Forms.Label()
        Me.DisplaySoup = New System.Windows.Forms.Button()
        Me.DisplayChef = New System.Windows.Forms.Button()
        Me.DisplayFish = New System.Windows.Forms.Button()
        Me.Exitbutton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'DinerName
        '
        Me.DinerName.Location = New System.Drawing.Point(26, 28)
        Me.DinerName.Name = "DinerName"
        Me.DinerName.Size = New System.Drawing.Size(128, 47)
        Me.DinerName.TabIndex = 0
        Me.DinerName.Text = "Tyson's Diner for Dining Purposes"
        '
        'FoodDisplay
        '
        Me.FoodDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FoodDisplay.ForeColor = System.Drawing.Color.Cornsilk
        Me.FoodDisplay.Image = Global.Asg1_5.My.Resources.Resources.thing
        Me.FoodDisplay.Location = New System.Drawing.Point(192, -4)
        Me.FoodDisplay.Name = "FoodDisplay"
        Me.FoodDisplay.Size = New System.Drawing.Size(393, 324)
        Me.FoodDisplay.TabIndex = 1
        Me.FoodDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DisplaySoup
        '
        Me.DisplaySoup.Location = New System.Drawing.Point(412, 312)
        Me.DisplaySoup.Name = "DisplaySoup"
        Me.DisplaySoup.Size = New System.Drawing.Size(108, 54)
        Me.DisplaySoup.TabIndex = 2
        Me.DisplaySoup.Text = "Soup of the Day"
        Me.DisplaySoup.UseVisualStyleBackColor = True
        '
        'DisplayChef
        '
        Me.DisplayChef.Location = New System.Drawing.Point(543, 312)
        Me.DisplayChef.Name = "DisplayChef"
        Me.DisplayChef.Size = New System.Drawing.Size(104, 54)
        Me.DisplayChef.TabIndex = 3
        Me.DisplayChef.Text = "Chef's Special"
        Me.DisplayChef.UseVisualStyleBackColor = True
        '
        'DisplayFish
        '
        Me.DisplayFish.Location = New System.Drawing.Point(667, 312)
        Me.DisplayFish.Name = "DisplayFish"
        Me.DisplayFish.Size = New System.Drawing.Size(106, 54)
        Me.DisplayFish.TabIndex = 4
        Me.DisplayFish.Text = "Daily Fish"
        Me.DisplayFish.UseVisualStyleBackColor = True
        '
        'Exitbutton
        '
        Me.Exitbutton.Location = New System.Drawing.Point(681, 400)
        Me.Exitbutton.Name = "Exitbutton"
        Me.Exitbutton.Size = New System.Drawing.Size(92, 38)
        Me.Exitbutton.TabIndex = 5
        Me.Exitbutton.Text = "Exit"
        Me.Exitbutton.UseVisualStyleBackColor = True
        '
        'Specials
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Exitbutton)
        Me.Controls.Add(Me.DisplayFish)
        Me.Controls.Add(Me.DisplayChef)
        Me.Controls.Add(Me.DisplaySoup)
        Me.Controls.Add(Me.FoodDisplay)
        Me.Controls.Add(Me.DinerName)
        Me.Name = "Specials"
        Me.Text = "Specials"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DinerName As Label
    Friend WithEvents FoodDisplay As Label
    Friend WithEvents DisplaySoup As Button
    Friend WithEvents DisplayChef As Button
    Friend WithEvents DisplayFish As Button
    Friend WithEvents Exitbutton As Button
End Class
