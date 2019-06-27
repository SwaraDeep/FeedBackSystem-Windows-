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
        Me.BranchList = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupList = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.YearList = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SubmitButton = New System.Windows.Forms.Button()
        Me.ResetButton = New System.Windows.Forms.Button()
        Me.FacultyList = New System.Windows.Forms.ComboBox()
        Me.SubjectList = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.RatingBar = New System.Windows.Forms.TrackBar()
        Me.CommentBox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.RatingBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BranchList
        '
        Me.BranchList.FormattingEnabled = True
        Me.BranchList.Items.AddRange(New Object() {"BBA", "B.Com", "B.Sc"})
        Me.BranchList.Location = New System.Drawing.Point(80, 33)
        Me.BranchList.Name = "BranchList"
        Me.BranchList.Size = New System.Drawing.Size(121, 21)
        Me.BranchList.TabIndex = 0
        Me.BranchList.Text = "Select Branch"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Branch: "
        '
        'GroupList
        '
        Me.GroupList.FormattingEnabled = True
        Me.GroupList.Items.AddRange(New Object() {"BBA", "BBA+", "MPCs", "MPC", "MECs", "MSCs", "ANIMATION"})
        Me.GroupList.Location = New System.Drawing.Point(80, 62)
        Me.GroupList.Name = "GroupList"
        Me.GroupList.Size = New System.Drawing.Size(121, 21)
        Me.GroupList.TabIndex = 0
        Me.GroupList.Text = "Select Group"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Group: "
        '
        'YearList
        '
        Me.YearList.FormattingEnabled = True
        Me.YearList.Items.AddRange(New Object() {"1st Year", "2nd Year", "3rd Year"})
        Me.YearList.Location = New System.Drawing.Point(80, 89)
        Me.YearList.Name = "YearList"
        Me.YearList.Size = New System.Drawing.Size(121, 21)
        Me.YearList.TabIndex = 0
        Me.YearList.Text = "Select Year"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Year: "
        '
        'SubmitButton
        '
        Me.SubmitButton.Location = New System.Drawing.Point(15, 200)
        Me.SubmitButton.Name = "SubmitButton"
        Me.SubmitButton.Size = New System.Drawing.Size(75, 23)
        Me.SubmitButton.TabIndex = 3
        Me.SubmitButton.Text = "Submit"
        Me.SubmitButton.UseVisualStyleBackColor = True
        '
        'ResetButton
        '
        Me.ResetButton.Location = New System.Drawing.Point(126, 200)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Size = New System.Drawing.Size(75, 23)
        Me.ResetButton.TabIndex = 4
        Me.ResetButton.Text = "Reset"
        Me.ResetButton.UseVisualStyleBackColor = True
        '
        'FacultyList
        '
        Me.FacultyList.FormattingEnabled = True
        Me.FacultyList.Items.AddRange(New Object() {"1st Year", "2nd Year", "3rd Year"})
        Me.FacultyList.Location = New System.Drawing.Point(80, 144)
        Me.FacultyList.Name = "FacultyList"
        Me.FacultyList.Size = New System.Drawing.Size(121, 21)
        Me.FacultyList.TabIndex = 0
        Me.FacultyList.Text = "Select Faculty"
        '
        'SubjectList
        '
        Me.SubjectList.FormattingEnabled = True
        Me.SubjectList.Items.AddRange(New Object() {"BBA", "BBA+", "MPCs", "MPC", "MECs", "MSCs", "ANIMATION"})
        Me.SubjectList.Location = New System.Drawing.Point(80, 117)
        Me.SubjectList.Name = "SubjectList"
        Me.SubjectList.Size = New System.Drawing.Size(121, 21)
        Me.SubjectList.TabIndex = 0
        Me.SubjectList.Text = "Select Subject"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 147)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Faculty:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Subject:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(271, 35)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Rating:"
        '
        'RatingBar
        '
        Me.RatingBar.Location = New System.Drawing.Point(274, 60)
        Me.RatingBar.Minimum = 1
        Me.RatingBar.Name = "RatingBar"
        Me.RatingBar.Size = New System.Drawing.Size(218, 45)
        Me.RatingBar.TabIndex = 7
        Me.RatingBar.Value = 1
        '
        'CommentBox
        '
        Me.CommentBox.Location = New System.Drawing.Point(274, 120)
        Me.CommentBox.Multiline = True
        Me.CommentBox.Name = "CommentBox"
        Me.CommentBox.Size = New System.Drawing.Size(307, 103)
        Me.CommentBox.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(274, 101)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Comment:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.CommentBox)
        Me.Controls.Add(Me.RatingBar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ResetButton)
        Me.Controls.Add(Me.SubmitButton)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SubjectList)
        Me.Controls.Add(Me.GroupList)
        Me.Controls.Add(Me.FacultyList)
        Me.Controls.Add(Me.YearList)
        Me.Controls.Add(Me.BranchList)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.RatingBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BranchList As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupList As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents YearList As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents SubmitButton As Button
    Friend WithEvents ResetButton As Button
    Friend WithEvents FacultyList As ComboBox
    Friend WithEvents SubjectList As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents RatingBar As TrackBar
    Friend WithEvents CommentBox As TextBox
    Friend WithEvents Label7 As Label
End Class
