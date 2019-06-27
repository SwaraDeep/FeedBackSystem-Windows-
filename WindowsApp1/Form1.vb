Public Class Form1
    Private Sub BranchList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles BranchList.SelectedIndexChanged
        GroupList.Items.Clear()
        YearList.Items.Clear()
        SubjectList.Items.Clear()
        FacultyList.Items.Clear()
        GroupList.Text = "Select Group"
        YearList.Text = "Select Year"
        SubjectList.Text = "Select Subject"
        FacultyList.Text = "Select Faculty"
        Dim branch As String
        branch = BranchList.Text
        If branch.Equals("BBA") Then
            GroupList.Items.Add("BBA")
            GroupList.Items.Add("BBA+")
        ElseIf branch.Equals("B.Sc") Then
            GroupList.Items.Add("MPC")
            GroupList.Items.Add("MPCs")
            GroupList.Items.Add("MSCs")
            GroupList.Items.Add("MECs")
            GroupList.Items.Add("Animation")
        ElseIf branch.Equals("B.Com") Then
            GroupList.Items.Add("General")
            GroupList.Items.Add("Computers")
        End If
    End Sub

    Private Sub GroupList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GroupList.SelectedIndexChanged
        YearList.Items.Clear()
        SubjectList.Items.Clear()
        FacultyList.Items.Clear()
        YearList.Text = "Select Year"
        SubjectList.Text = "Select Subject"
        FacultyList.Text = "Select Faculty"
        YearList.Items.Add("1st Year")
        YearList.Items.Add("2nd Year")
        YearList.Items.Add("3rd Year")
    End Sub

    Private Sub YearList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles YearList.SelectedIndexChanged
        SubjectList.Items.Clear()
        FacultyList.Items.Clear()
        SubjectList.Text = "Select Subject"
        FacultyList.Text = "Select Faculty"
        Dim year As String
        Dim group As String
        year = YearList.Text
        group = GroupList.Text
        If year.Equals("1st Year") Then
            If group.Equals("BBA") Then

            ElseIf group.Equals("BBA+") Then

            ElseIf group.Equals("MPC") Then
                SubjectList.Items.Add("Maths")
                SubjectList.Items.Add("Physics")
                SubjectList.Items.Add("Chemistry")
                SubjectList.Items.Add("Telugu")
                SubjectList.Items.Add("Sanskrit")
                SubjectList.Items.Add("English")
                SubjectList.Items.Add("E.S.")
                SubjectList.Items.Add("ICT")
                SubjectList.Items.Add("CRT")
            ElseIf group.Equals("MPCs") Then
                SubjectList.Items.Add("Maths")
                SubjectList.Items.Add("Physics")
                SubjectList.Items.Add("Computer Science")
                SubjectList.Items.Add("Telugu")
                SubjectList.Items.Add("Sanskrit")
                SubjectList.Items.Add("English")
                SubjectList.Items.Add("E.S.")
                SubjectList.Items.Add("ICT")
                SubjectList.Items.Add("CRT")
            ElseIf group.Equals("MECs") Then
                SubjectList.Items.Add("Maths")
                SubjectList.Items.Add("Electronics")
                SubjectList.Items.Add("Computer Science")
                SubjectList.Items.Add("Telugu")
                SubjectList.Items.Add("Sanskrit")
                SubjectList.Items.Add("English")
                SubjectList.Items.Add("E.S.")
                SubjectList.Items.Add("ICT")
                SubjectList.Items.Add("CRT")
            ElseIf group.Equals("MSCs") Then
                SubjectList.Items.Add("Maths")
                SubjectList.Items.Add("Statistics")
                SubjectList.Items.Add("Computer Science")
                SubjectList.Items.Add("Telugu")
                SubjectList.Items.Add("Sanskrit")
                SubjectList.Items.Add("English")
                SubjectList.Items.Add("E.S.")
                SubjectList.Items.Add("ICT")
                SubjectList.Items.Add("CRT")
            ElseIf group.Equals("Animation") Then
                SubjectList.Items.Add("Maths")
                SubjectList.Items.Add("Physics")
                SubjectList.Items.Add("Computer Science")
                SubjectList.Items.Add("Telugu")
                SubjectList.Items.Add("Sanskrit")
                SubjectList.Items.Add("English")
                SubjectList.Items.Add("E.S.")
                SubjectList.Items.Add("ICT")
                SubjectList.Items.Add("CRT")
            ElseIf group.Equals("General") Then

            ElseIf group.Equals("Computers") Then

            End If
        ElseIf year.Equals("2nd Year") Then
            If group.Equals("BBA") Then

            ElseIf group.Equals("BBA+") Then

            ElseIf group.Equals("MPC") Then
                SubjectList.Items.Add("Maths")
                SubjectList.Items.Add("Physics")
                SubjectList.Items.Add("Chemistry")
                SubjectList.Items.Add("Telugu")
                SubjectList.Items.Add("Sanskrit")
                SubjectList.Items.Add("English")
                SubjectList.Items.Add("Ethics and Values")
                SubjectList.Items.Add("ICT-II")
                SubjectList.Items.Add("CRT-II")
            ElseIf group.Equals("MPCs") Then
                SubjectList.Items.Add("Maths")
                SubjectList.Items.Add("Physics")
                SubjectList.Items.Add("Computer Science")
                SubjectList.Items.Add("Telugu")
                SubjectList.Items.Add("Sanskrit")
                SubjectList.Items.Add("English")
                SubjectList.Items.Add("Ethics and Values")
                SubjectList.Items.Add("ICT-II")
                SubjectList.Items.Add("CRT-II")
            ElseIf group.Equals("MECs") Then
                SubjectList.Items.Add("Maths")
                SubjectList.Items.Add("Electronics")
                SubjectList.Items.Add("Computer Science")
                SubjectList.Items.Add("Telugu")
                SubjectList.Items.Add("Sanskrit")
                SubjectList.Items.Add("English")
                SubjectList.Items.Add("Ethics and Values")
                SubjectList.Items.Add("ICT-II")
                SubjectList.Items.Add("CRT-II")
            ElseIf group.Equals("MSCs") Then
                SubjectList.Items.Add("Maths")
                SubjectList.Items.Add("Statistics")
                SubjectList.Items.Add("Computer Science")
                SubjectList.Items.Add("Telugu")
                SubjectList.Items.Add("Sanskrit")
                SubjectList.Items.Add("English")
                SubjectList.Items.Add("Ethics and Values")
                SubjectList.Items.Add("ICT-II")
                SubjectList.Items.Add("CRT-II")
            ElseIf group.Equals("Animation") Then
                SubjectList.Items.Add("Maths")
                SubjectList.Items.Add("Physics")
                SubjectList.Items.Add("Computer Science")
                SubjectList.Items.Add("Telugu")
                SubjectList.Items.Add("Sanskrit")
                SubjectList.Items.Add("English")
                SubjectList.Items.Add("Ethics and Values")
                SubjectList.Items.Add("ICT-II")
                SubjectList.Items.Add("CRT-II")

            ElseIf group.Equals("Animation") Then

            ElseIf group.Equals("General") Then

            ElseIf group.Equals("Computers") Then

            End If
        ElseIf year.Equals("3rd Year") Then
            If group.Equals("BBA") Then

            ElseIf group.Equals("BBA+") Then

            ElseIf group.Equals("MPC") Then
                SubjectList.Items.Add("Maths")
                SubjectList.Items.Add("Physics")
                SubjectList.Items.Add("Chemistry")
                SubjectList.Items.Add("Telugu")
                SubjectList.Items.Add("Sanskrit")
                SubjectList.Items.Add("English")
                SubjectList.Items.Add("Ethics and Values")
                SubjectList.Items.Add("ICT-II")
                SubjectList.Items.Add("CRT-II")
            ElseIf group.Equals("MPCs") Then
                SubjectList.Items.Add("Maths")
                SubjectList.Items.Add("Physics")
                SubjectList.Items.Add("Computer Science")
                SubjectList.Items.Add("Telugu")
                SubjectList.Items.Add("Sanskrit")
                SubjectList.Items.Add("English")
                SubjectList.Items.Add("Ethics and Values")
                SubjectList.Items.Add("ICT-II")
                SubjectList.Items.Add("CRT-II")
            ElseIf group.Equals("MECs") Then
                SubjectList.Items.Add("Maths")
                SubjectList.Items.Add("Electronics")
                SubjectList.Items.Add("Computer Science")
                SubjectList.Items.Add("Telugu")
                SubjectList.Items.Add("Sanskrit")
                SubjectList.Items.Add("English")
                SubjectList.Items.Add("Ethics and Values")
                SubjectList.Items.Add("ICT-II")
                SubjectList.Items.Add("CRT-II")
            ElseIf group.Equals("MSCs") Then
                SubjectList.Items.Add("Maths")
                SubjectList.Items.Add("Statistics")
                SubjectList.Items.Add("Computer Science")
                SubjectList.Items.Add("Telugu")
                SubjectList.Items.Add("Sanskrit")
                SubjectList.Items.Add("English")
                SubjectList.Items.Add("Ethics and Values")
                SubjectList.Items.Add("ICT-III")
                SubjectList.Items.Add("CRT-III")
            ElseIf group.Equals("Animation") Then
                SubjectList.Items.Add("Maths")
                SubjectList.Items.Add("Physics")
                SubjectList.Items.Add("Computer Science")
                SubjectList.Items.Add("Telugu")
                SubjectList.Items.Add("Sanskrit")
                SubjectList.Items.Add("English")
                SubjectList.Items.Add("Ethics and Values")
                SubjectList.Items.Add("ICT-III")
                SubjectList.Items.Add("CRT-III")
            ElseIf group.Equals("Animation") Then

            ElseIf group.Equals("General") Then

            ElseIf group.Equals("Computers") Then

            End If
        End If
    End Sub

    Private Sub SubjectList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SubjectList.SelectedIndexChanged
        FacultyList.Items.Clear()
        FacultyList.Text = "Select Faculty"

    End Sub

    Private Sub FacultyList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FacultyList.SelectedIndexChanged

    End Sub

    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click

    End Sub

    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        GroupList.Items.Clear()
        YearList.Items.Clear()
        SubjectList.Items.Clear()
        FacultyList.Items.Clear()
        GroupList.Text = "Select Group"
        BranchList.Text = "Select Branch"
        YearList.Text = "Select Year"
        SubjectList.Text = "Select Subject"
        FacultyList.Text = "Select Faculty"
        MessageBox.Show("Reset completed!", "Reset")
    End Sub

    Private Sub RatingBar_Scroll(sender As Object, e As EventArgs) Handles RatingBar.Scroll

    End Sub

    Private Sub CommentBox_TextChanged(sender As Object, e As EventArgs) Handles CommentBox.TextChanged

    End Sub
End Class
