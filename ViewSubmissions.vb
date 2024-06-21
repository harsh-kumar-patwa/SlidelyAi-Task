Imports System.Net.Http
Imports Newtonsoft.Json

Public Class ViewSubmissions
    Inherits System.Windows.Forms.Form
    Private submissions As List(Of Submission)
    Private currentIndex As Integer

    Public Sub New()
        InitializeComponent()
        submissions = New List(Of Submission)()
        currentIndex = 0
        LoadSubmissions()
    End Sub

    Private Async Sub LoadSubmissions()
        Dim client As New HttpClient()
        Dim index As Integer = 0

        Try
            While True
                Dim response = Await client.GetAsync($"http://localhost:3000/read?index={index}")
                If response.StatusCode = Net.HttpStatusCode.NotFound Then
                    Exit While
                End If
                Dim submission = JsonConvert.DeserializeObject(Of Submission)(Await response.Content.ReadAsStringAsync())
                submissions.Add(submission)
                index += 1
            End While

            If submissions.Count > 0 Then
                DisplaySubmission(0)
            End If

        Catch ex As Exception
            ' Handle any unexpected exceptions
            MessageBox.Show($"An error occurred while loading submissions: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub DisplaySubmission(index As Integer)
        If index >= 0 AndAlso index < submissions.Count Then
            textName.Text = submissions(index).Name
            textEmail.Text = submissions(index).Email
            textPhone.Text = submissions(index).Phone
            textGithub.Text = submissions(index).GithubLink
            textStopwatchTime.Text = submissions(index).StopwatchTime
            currentIndex = index
        End If
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If currentIndex > 0 Then
            DisplaySubmission(currentIndex - 1)
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If currentIndex < submissions.Count - 1 Then
            DisplaySubmission(currentIndex + 1)
        End If
    End Sub
    Private Sub ViewSubmissions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True


    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles TextBox9.TextChanged

    End Sub

    Private Sub btnViewSubmissions_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click

    End Sub

    Private Sub btnPrevious_KeyDown(sender As Object, e As KeyEventArgs) Handles btnPrevious.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.P Then
            btnPrevious.PerformClick()

        End If
    End Sub

    Private Sub btnNext_KeyDown(sender As Object, e As KeyEventArgs) Handles btnNext.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.N Then
            btnNext.PerformClick()

        End If
    End Sub
End Class
