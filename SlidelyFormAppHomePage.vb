Imports System.Windows.Forms


Public Class SlidelyFormAppHomePage

    Private Sub SlidelyFormAppHomePage_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.N Then
            ' Check if ViewSubmissions form is not already open
            If Not IsViewSubmissionFormOpen() Then
                OpenCreateSubmissionForm()
            End If
        End If

        If e.Control AndAlso e.KeyCode = Keys.V Then
            OpenViewSubmissionsForm()
        End If
    End Sub
    Private Sub OpenCreateSubmissionForm()
        Dim createForm As New CreateSubmissions()
        createForm.Show()
    End Sub

    Private Sub OpenViewSubmissionsForm()
        Dim viewForm As New ViewSubmissions()
        viewForm.Show()
    End Sub

    'view submission

    Private Sub btnViewSubmissions_Click(sender As Object, e As EventArgs) Handles btnViewSubmissions.Click
        OpenViewSubmissionsForm()

    End Sub

    'create submission
    Private Sub btnCreateSubmission_Click(sender As Object, e As EventArgs) Handles btnCreateSubmission.Click
        OpenCreateSubmissionForm()
    End Sub



    Private Function IsViewSubmissionFormOpen() As Boolean
        For Each form As Form In Application.OpenForms
            If TypeOf form Is ViewSubmissions Then
                Return True
            End If
        Next
        Return False
    End Function

End Class

