Imports System.Windows.Forms


Public Class SlidelyFormAppHomePage
        Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnViewSubmissions.Click

        End Sub

        Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnCreateSubmission.Click

        End Sub

        Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        End Sub

        Private Sub btnViewSubmissions_KeyDown(sender As Object, e As KeyEventArgs) Handles btnViewSubmissions.KeyDown
            If e.Control AndAlso e.KeyCode = Keys.V Then

                btnViewSubmissions.PerformClick()
            End If
        End Sub

        Private Sub btnViewSubmissions_Click(sender As Object, e As EventArgs) Handles btnViewSubmissions.Click
        ' Code to open View Submissions form
        Dim viewForm As New ViewSubmissions()
        viewForm.Show()
        End Sub

        Private Sub btnCreateSubmission_Click(sender As Object, e As EventArgs) Handles btnCreateSubmission.Click
        ' Code to open Create Submission form
        Dim createForm As New CreateSubmissions()
        createForm.Show()
        End Sub

        Private Sub btnCreateSubmission_KeyDown(sender As Object, e As KeyEventArgs) Handles btnCreateSubmission.KeyDown
            If e.Control AndAlso e.KeyCode = Keys.N Then
                btnCreateSubmission.PerformClick()
            End If
        End Sub

        Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

        End Sub
    End Class

