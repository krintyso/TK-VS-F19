<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MathContest
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
        Me.NameTextbox = New System.Windows.Forms.TextBox()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.GradeLabel = New System.Windows.Forms.Label()
        Me.AgeLabel = New System.Windows.Forms.Label()
        Me.AddRadioButton = New System.Windows.Forms.RadioButton()
        Me.SubRadioButton = New System.Windows.Forms.RadioButton()
        Me.MultiplyRadioButton = New System.Windows.Forms.RadioButton()
        Me.DivideRadioButton = New System.Windows.Forms.RadioButton()
        Me.AgeMaskTextbox = New System.Windows.Forms.MaskedTextBox()
        Me.GradeMaskTextbox = New System.Windows.Forms.MaskedTextBox()
        Me.firstNumbertextbox = New System.Windows.Forms.TextBox()
        Me.secondNumbertextbox = New System.Windows.Forms.TextBox()
        Me.StudentAnswerTextbox = New System.Windows.Forms.TextBox()
        Me.firstNumberLabel = New System.Windows.Forms.Label()
        Me.secondNumberLabel = New System.Windows.Forms.Label()
        Me.AnswerLabel = New System.Windows.Forms.Label()
        Me.StudentInfoGroupbox = New System.Windows.Forms.GroupBox()
        Me.MathProblemgroupbox = New System.Windows.Forms.GroupBox()
        Me.MathTypeGroupBox = New System.Windows.Forms.GroupBox()
        Me.SubmitButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.SummaryButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.RefreshButton = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.StudentInfoGroupbox.SuspendLayout()
        Me.MathProblemgroupbox.SuspendLayout()
        Me.MathTypeGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'NameTextbox
        '
        Me.NameTextbox.Location = New System.Drawing.Point(9, 56)
        Me.NameTextbox.Name = "NameTextbox"
        Me.NameTextbox.Size = New System.Drawing.Size(138, 22)
        Me.NameTextbox.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.NameTextbox, "Enter Student Name")
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Location = New System.Drawing.Point(6, 36)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(45, 17)
        Me.NameLabel.TabIndex = 3
        Me.NameLabel.Text = "Name"
        '
        'GradeLabel
        '
        Me.GradeLabel.AutoSize = True
        Me.GradeLabel.Location = New System.Drawing.Point(234, 36)
        Me.GradeLabel.Name = "GradeLabel"
        Me.GradeLabel.Size = New System.Drawing.Size(48, 17)
        Me.GradeLabel.TabIndex = 4
        Me.GradeLabel.Text = "Grade"
        '
        'AgeLabel
        '
        Me.AgeLabel.AutoSize = True
        Me.AgeLabel.Location = New System.Drawing.Point(170, 36)
        Me.AgeLabel.Name = "AgeLabel"
        Me.AgeLabel.Size = New System.Drawing.Size(33, 17)
        Me.AgeLabel.TabIndex = 5
        Me.AgeLabel.Text = "Age"
        '
        'AddRadioButton
        '
        Me.AddRadioButton.AutoSize = True
        Me.AddRadioButton.Location = New System.Drawing.Point(38, 58)
        Me.AddRadioButton.Name = "AddRadioButton"
        Me.AddRadioButton.Size = New System.Drawing.Size(80, 21)
        Me.AddRadioButton.TabIndex = 6
        Me.AddRadioButton.TabStop = True
        Me.AddRadioButton.Text = "Addition"
        Me.ToolTip1.SetToolTip(Me.AddRadioButton, "Adds 1st and 2nd number")
        Me.AddRadioButton.UseVisualStyleBackColor = True
        '
        'SubRadioButton
        '
        Me.SubRadioButton.AutoSize = True
        Me.SubRadioButton.Location = New System.Drawing.Point(38, 85)
        Me.SubRadioButton.Name = "SubRadioButton"
        Me.SubRadioButton.Size = New System.Drawing.Size(101, 21)
        Me.SubRadioButton.TabIndex = 7
        Me.SubRadioButton.TabStop = True
        Me.SubRadioButton.Text = "Subtraction"
        Me.ToolTip1.SetToolTip(Me.SubRadioButton, "Subtracts 1st and 2nd number")
        Me.SubRadioButton.UseVisualStyleBackColor = True
        '
        'MultiplyRadioButton
        '
        Me.MultiplyRadioButton.AutoSize = True
        Me.MultiplyRadioButton.Location = New System.Drawing.Point(38, 112)
        Me.MultiplyRadioButton.Name = "MultiplyRadioButton"
        Me.MultiplyRadioButton.Size = New System.Drawing.Size(110, 21)
        Me.MultiplyRadioButton.TabIndex = 8
        Me.MultiplyRadioButton.TabStop = True
        Me.MultiplyRadioButton.Text = "Multiplication"
        Me.ToolTip1.SetToolTip(Me.MultiplyRadioButton, "Multiplies 1st and 2nd number")
        Me.MultiplyRadioButton.UseVisualStyleBackColor = True
        '
        'DivideRadioButton
        '
        Me.DivideRadioButton.AutoSize = True
        Me.DivideRadioButton.Location = New System.Drawing.Point(38, 139)
        Me.DivideRadioButton.Name = "DivideRadioButton"
        Me.DivideRadioButton.Size = New System.Drawing.Size(78, 21)
        Me.DivideRadioButton.TabIndex = 9
        Me.DivideRadioButton.TabStop = True
        Me.DivideRadioButton.Text = "Division"
        Me.ToolTip1.SetToolTip(Me.DivideRadioButton, "Divides 1st and 2nd number")
        Me.DivideRadioButton.UseVisualStyleBackColor = True
        '
        'AgeMaskTextbox
        '
        Me.AgeMaskTextbox.Location = New System.Drawing.Point(173, 56)
        Me.AgeMaskTextbox.Mask = "00"
        Me.AgeMaskTextbox.Name = "AgeMaskTextbox"
        Me.AgeMaskTextbox.Size = New System.Drawing.Size(30, 22)
        Me.AgeMaskTextbox.TabIndex = 10
        Me.ToolTip1.SetToolTip(Me.AgeMaskTextbox, "Enter Student Age")
        '
        'GradeMaskTextbox
        '
        Me.GradeMaskTextbox.Location = New System.Drawing.Point(237, 56)
        Me.GradeMaskTextbox.Mask = "0"
        Me.GradeMaskTextbox.Name = "GradeMaskTextbox"
        Me.GradeMaskTextbox.Size = New System.Drawing.Size(30, 22)
        Me.GradeMaskTextbox.TabIndex = 11
        Me.ToolTip1.SetToolTip(Me.GradeMaskTextbox, "Enter Student Grade")
        '
        'firstNumbertextbox
        '
        Me.firstNumbertextbox.Location = New System.Drawing.Point(21, 38)
        Me.firstNumbertextbox.Name = "firstNumbertextbox"
        Me.firstNumbertextbox.ReadOnly = True
        Me.firstNumbertextbox.Size = New System.Drawing.Size(261, 22)
        Me.firstNumbertextbox.TabIndex = 12
        Me.ToolTip1.SetToolTip(Me.firstNumbertextbox, "First Number")
        '
        'secondNumbertextbox
        '
        Me.secondNumbertextbox.Location = New System.Drawing.Point(21, 99)
        Me.secondNumbertextbox.Name = "secondNumbertextbox"
        Me.secondNumbertextbox.ReadOnly = True
        Me.secondNumbertextbox.Size = New System.Drawing.Size(261, 22)
        Me.secondNumbertextbox.TabIndex = 13
        Me.ToolTip1.SetToolTip(Me.secondNumbertextbox, "Second Number")
        '
        'StudentAnswerTextbox
        '
        Me.StudentAnswerTextbox.Location = New System.Drawing.Point(21, 172)
        Me.StudentAnswerTextbox.Name = "StudentAnswerTextbox"
        Me.StudentAnswerTextbox.Size = New System.Drawing.Size(261, 22)
        Me.StudentAnswerTextbox.TabIndex = 14
        Me.ToolTip1.SetToolTip(Me.StudentAnswerTextbox, "Enter answer")
        '
        'firstNumberLabel
        '
        Me.firstNumberLabel.AutoSize = True
        Me.firstNumberLabel.Location = New System.Drawing.Point(18, 18)
        Me.firstNumberLabel.Name = "firstNumberLabel"
        Me.firstNumberLabel.Size = New System.Drawing.Size(81, 17)
        Me.firstNumberLabel.TabIndex = 15
        Me.firstNumberLabel.Text = "1st Number"
        '
        'secondNumberLabel
        '
        Me.secondNumberLabel.AutoSize = True
        Me.secondNumberLabel.Location = New System.Drawing.Point(18, 79)
        Me.secondNumberLabel.Name = "secondNumberLabel"
        Me.secondNumberLabel.Size = New System.Drawing.Size(86, 17)
        Me.secondNumberLabel.TabIndex = 16
        Me.secondNumberLabel.Text = "2nd Number"
        '
        'AnswerLabel
        '
        Me.AnswerLabel.AutoSize = True
        Me.AnswerLabel.Location = New System.Drawing.Point(18, 148)
        Me.AnswerLabel.Name = "AnswerLabel"
        Me.AnswerLabel.Size = New System.Drawing.Size(107, 17)
        Me.AnswerLabel.TabIndex = 17
        Me.AnswerLabel.Text = "Student Answer"
        '
        'StudentInfoGroupbox
        '
        Me.StudentInfoGroupbox.Controls.Add(Me.NameLabel)
        Me.StudentInfoGroupbox.Controls.Add(Me.NameTextbox)
        Me.StudentInfoGroupbox.Controls.Add(Me.AgeLabel)
        Me.StudentInfoGroupbox.Controls.Add(Me.GradeLabel)
        Me.StudentInfoGroupbox.Controls.Add(Me.AgeMaskTextbox)
        Me.StudentInfoGroupbox.Controls.Add(Me.GradeMaskTextbox)
        Me.StudentInfoGroupbox.Location = New System.Drawing.Point(57, 12)
        Me.StudentInfoGroupbox.Name = "StudentInfoGroupbox"
        Me.StudentInfoGroupbox.Size = New System.Drawing.Size(306, 125)
        Me.StudentInfoGroupbox.TabIndex = 18
        Me.StudentInfoGroupbox.TabStop = False
        Me.StudentInfoGroupbox.Text = "Student Information"
        '
        'MathProblemgroupbox
        '
        Me.MathProblemgroupbox.Controls.Add(Me.firstNumberLabel)
        Me.MathProblemgroupbox.Controls.Add(Me.firstNumbertextbox)
        Me.MathProblemgroupbox.Controls.Add(Me.AnswerLabel)
        Me.MathProblemgroupbox.Controls.Add(Me.secondNumbertextbox)
        Me.MathProblemgroupbox.Controls.Add(Me.secondNumberLabel)
        Me.MathProblemgroupbox.Controls.Add(Me.StudentAnswerTextbox)
        Me.MathProblemgroupbox.Location = New System.Drawing.Point(57, 173)
        Me.MathProblemgroupbox.Name = "MathProblemgroupbox"
        Me.MathProblemgroupbox.Size = New System.Drawing.Size(306, 221)
        Me.MathProblemgroupbox.TabIndex = 19
        Me.MathProblemgroupbox.TabStop = False
        Me.MathProblemgroupbox.Text = "Current Math Problem"
        '
        'MathTypeGroupBox
        '
        Me.MathTypeGroupBox.Controls.Add(Me.AddRadioButton)
        Me.MathTypeGroupBox.Controls.Add(Me.SubRadioButton)
        Me.MathTypeGroupBox.Controls.Add(Me.MultiplyRadioButton)
        Me.MathTypeGroupBox.Controls.Add(Me.DivideRadioButton)
        Me.MathTypeGroupBox.Location = New System.Drawing.Point(369, 73)
        Me.MathTypeGroupBox.Name = "MathTypeGroupBox"
        Me.MathTypeGroupBox.Size = New System.Drawing.Size(200, 221)
        Me.MathTypeGroupBox.TabIndex = 20
        Me.MathTypeGroupBox.TabStop = False
        Me.MathTypeGroupBox.Text = "Math Problem Type"
        '
        'SubmitButton
        '
        Me.SubmitButton.Location = New System.Drawing.Point(575, 48)
        Me.SubmitButton.Name = "SubmitButton"
        Me.SubmitButton.Size = New System.Drawing.Size(213, 73)
        Me.SubmitButton.TabIndex = 21
        Me.SubmitButton.Text = "Submit"
        Me.ToolTip1.SetToolTip(Me.SubmitButton, "Submits information")
        Me.SubmitButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(575, 130)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(213, 70)
        Me.ClearButton.TabIndex = 22
        Me.ClearButton.Text = "Clear"
        Me.ToolTip1.SetToolTip(Me.ClearButton, "Clears Information")
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'SummaryButton
        '
        Me.SummaryButton.Location = New System.Drawing.Point(575, 206)
        Me.SummaryButton.Name = "SummaryButton"
        Me.SummaryButton.Size = New System.Drawing.Size(213, 75)
        Me.SummaryButton.TabIndex = 23
        Me.SummaryButton.Text = "Summary"
        Me.ToolTip1.SetToolTip(Me.SummaryButton, "Gives summary of student answers")
        Me.SummaryButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(575, 287)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(213, 73)
        Me.ExitButton.TabIndex = 24
        Me.ExitButton.Text = "Exit"
        Me.ToolTip1.SetToolTip(Me.ExitButton, "Exits the program")
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'RefreshButton
        '
        Me.RefreshButton.Location = New System.Drawing.Point(575, 366)
        Me.RefreshButton.Name = "RefreshButton"
        Me.RefreshButton.Size = New System.Drawing.Size(213, 72)
        Me.RefreshButton.TabIndex = 25
        Me.RefreshButton.Text = "Refresh Values"
        Me.ToolTip1.SetToolTip(Me.RefreshButton, "Refreshes numbers")
        Me.RefreshButton.UseVisualStyleBackColor = True
        '
        'MathContest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.RefreshButton)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.SummaryButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.SubmitButton)
        Me.Controls.Add(Me.MathTypeGroupBox)
        Me.Controls.Add(Me.MathProblemgroupbox)
        Me.Controls.Add(Me.StudentInfoGroupbox)
        Me.Name = "MathContest"
        Me.Text = "Math Contest "
        Me.StudentInfoGroupbox.ResumeLayout(False)
        Me.StudentInfoGroupbox.PerformLayout()
        Me.MathProblemgroupbox.ResumeLayout(False)
        Me.MathProblemgroupbox.PerformLayout()
        Me.MathTypeGroupBox.ResumeLayout(False)
        Me.MathTypeGroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents NameTextbox As TextBox
    Friend WithEvents NameLabel As Label
    Friend WithEvents GradeLabel As Label
    Friend WithEvents AgeLabel As Label
    Friend WithEvents AddRadioButton As RadioButton
    Friend WithEvents SubRadioButton As RadioButton
    Friend WithEvents MultiplyRadioButton As RadioButton
    Friend WithEvents DivideRadioButton As RadioButton
    Friend WithEvents AgeMaskTextbox As MaskedTextBox
    Friend WithEvents GradeMaskTextbox As MaskedTextBox
    Friend WithEvents firstNumbertextbox As TextBox
    Friend WithEvents secondNumbertextbox As TextBox
    Friend WithEvents StudentAnswerTextbox As TextBox
    Friend WithEvents firstNumberLabel As Label
    Friend WithEvents secondNumberLabel As Label
    Friend WithEvents AnswerLabel As Label
    Friend WithEvents StudentInfoGroupbox As GroupBox
    Friend WithEvents MathProblemgroupbox As GroupBox
    Friend WithEvents MathTypeGroupBox As GroupBox
    Friend WithEvents SubmitButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents SummaryButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents RefreshButton As Button
    Friend WithEvents ToolTip1 As ToolTip
End Class
