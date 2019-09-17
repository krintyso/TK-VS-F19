<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Information
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
        Me.Firstname = New System.Windows.Forms.TextBox()
        Me.Lastname = New System.Windows.Forms.TextBox()
        Me.Address = New System.Windows.Forms.TextBox()
        Me.State = New System.Windows.Forms.TextBox()
        Me.City = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Line2 = New System.Windows.Forms.Label()
        Me.Line3 = New System.Windows.Forms.Label()
        Me.Line1 = New System.Windows.Forms.Label()
        Me.DisplaysInfo = New System.Windows.Forms.Button()
        Me.Clearsinfo = New System.Windows.Forms.Button()
        Me.Exitprog = New System.Windows.Forms.Button()
        Me.ZIPcode = New System.Windows.Forms.MaskedTextBox()
        Me.SuspendLayout()
        '
        'Firstname
        '
        Me.Firstname.Location = New System.Drawing.Point(140, 31)
        Me.Firstname.Name = "Firstname"
        Me.Firstname.Size = New System.Drawing.Size(100, 22)
        Me.Firstname.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.Firstname, "Enter first name")
        '
        'Lastname
        '
        Me.Lastname.Location = New System.Drawing.Point(140, 80)
        Me.Lastname.Name = "Lastname"
        Me.Lastname.Size = New System.Drawing.Size(100, 22)
        Me.Lastname.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.Lastname, "Enter last name")
        '
        'Address
        '
        Me.Address.Location = New System.Drawing.Point(140, 133)
        Me.Address.Name = "Address"
        Me.Address.Size = New System.Drawing.Size(100, 22)
        Me.Address.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.Address, "Enter street address")
        '
        'State
        '
        Me.State.Location = New System.Drawing.Point(140, 245)
        Me.State.Name = "State"
        Me.State.Size = New System.Drawing.Size(100, 22)
        Me.State.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.State, "Enter state")
        '
        'City
        '
        Me.City.Location = New System.Drawing.Point(140, 191)
        Me.City.Name = "City"
        Me.City.Size = New System.Drawing.Size(100, 22)
        Me.City.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.City, "Enter city")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(83, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 17)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "First "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(83, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 17)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Last"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(74, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Address"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(83, 196)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 17)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "City"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(83, 250)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 17)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "State"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(74, 302)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 17)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "ZIP code"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(454, 30)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 17)
        Me.Label7.TabIndex = 12
        '
        'Line2
        '
        Me.Line2.AutoSize = True
        Me.Line2.Location = New System.Drawing.Point(454, 78)
        Me.Line2.Name = "Line2"
        Me.Line2.Size = New System.Drawing.Size(0, 17)
        Me.Line2.TabIndex = 13
        '
        'Line3
        '
        Me.Line3.AutoSize = True
        Me.Line3.Location = New System.Drawing.Point(454, 105)
        Me.Line3.Name = "Line3"
        Me.Line3.Size = New System.Drawing.Size(0, 17)
        Me.Line3.TabIndex = 14
        '
        'Line1
        '
        Me.Line1.AutoSize = True
        Me.Line1.Location = New System.Drawing.Point(454, 47)
        Me.Line1.Name = "Line1"
        Me.Line1.Size = New System.Drawing.Size(0, 17)
        Me.Line1.TabIndex = 15
        '
        'DisplaysInfo
        '
        Me.DisplaysInfo.Location = New System.Drawing.Point(77, 366)
        Me.DisplaysInfo.Name = "DisplaysInfo"
        Me.DisplaysInfo.Size = New System.Drawing.Size(92, 37)
        Me.DisplaysInfo.TabIndex = 16
        Me.DisplaysInfo.Text = "Accept"
        Me.DisplaysInfo.UseVisualStyleBackColor = True
        '
        'Clearsinfo
        '
        Me.Clearsinfo.Location = New System.Drawing.Point(201, 366)
        Me.Clearsinfo.Name = "Clearsinfo"
        Me.Clearsinfo.Size = New System.Drawing.Size(92, 37)
        Me.Clearsinfo.TabIndex = 17
        Me.Clearsinfo.Text = "Clear"
        Me.Clearsinfo.UseVisualStyleBackColor = True
        '
        'Exitprog
        '
        Me.Exitprog.Location = New System.Drawing.Point(696, 401)
        Me.Exitprog.Name = "Exitprog"
        Me.Exitprog.Size = New System.Drawing.Size(92, 37)
        Me.Exitprog.TabIndex = 18
        Me.Exitprog.Text = "Exit"
        Me.Exitprog.UseVisualStyleBackColor = True
        '
        'ZIPcode
        '
        Me.ZIPcode.Location = New System.Drawing.Point(144, 297)
        Me.ZIPcode.Mask = "00000-9999"
        Me.ZIPcode.Name = "ZIPcode"
        Me.ZIPcode.Size = New System.Drawing.Size(100, 22)
        Me.ZIPcode.TabIndex = 19
        Me.ToolTip1.SetToolTip(Me.ZIPcode, "Enter ZIP code")
        '
        'Information
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ZIPcode)
        Me.Controls.Add(Me.Exitprog)
        Me.Controls.Add(Me.Clearsinfo)
        Me.Controls.Add(Me.DisplaysInfo)
        Me.Controls.Add(Me.Line1)
        Me.Controls.Add(Me.Line3)
        Me.Controls.Add(Me.Line2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.City)
        Me.Controls.Add(Me.State)
        Me.Controls.Add(Me.Address)
        Me.Controls.Add(Me.Lastname)
        Me.Controls.Add(Me.Firstname)
        Me.Name = "Information"
        Me.Text = "Personal Information"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Firstname As TextBox
    Friend WithEvents Lastname As TextBox
    Friend WithEvents Address As TextBox
    Friend WithEvents State As TextBox
    Friend WithEvents City As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Label7 As Label
    Friend WithEvents Line2 As Label
    Friend WithEvents Line3 As Label
    Friend WithEvents Line1 As Label
    Friend WithEvents DisplaysInfo As Button
    Friend WithEvents Clearsinfo As Button
    Friend WithEvents Exitprog As Button
    Friend WithEvents ZIPcode As MaskedTextBox
End Class
