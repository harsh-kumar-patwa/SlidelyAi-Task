Imports System.Net.Http
Imports Newtonsoft.Json
Imports System.Text
Imports System.Diagnostics

Public Class CreateSubmissions

    Private stopwatch As Stopwatch = New Stopwatch()
    Private isStopwatchRunning As Boolean = False
    Private WithEvents timer As Timer

    Private Sub CreateSubmissions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        timer = New Timer()
        timer.Interval = 50 ' 1000 milliseconds = 1 second
        AddHandler timer.Tick, AddressOf Timer_Tick
        ' Start stopwatch when form loads

        stopwatch.Start()
        isStopwatchRunning = True
        timer.Start()
        UpdateStopwatchLabel()
    End Sub
    Private Sub Timer_Tick(sender As Object, e As EventArgs)
        UpdateStopwatchLabel()
    End Sub

    Private Sub CreateSubmissions_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Stop stopwatch when form is closing
        stopwatch.Stop()
        isStopwatchRunning = False
        timer.Stop()
    End Sub

    Private Sub btnToggleStopwatch_Click(sender As Object, e As EventArgs) Handles btnToggleStopwatch.Click
        If isStopwatchRunning Then
            stopwatch.Stop()
            isStopwatchRunning = False
            timer.Stop()
        Else
            stopwatch.Start()
            isStopwatchRunning = True
            timer.Start()
        End If

        UpdateStopwatchLabel()
    End Sub

    Private Sub UpdateStopwatchLabel()
        labelStopwatchTime.Text = stopwatch.Elapsed.ToString("mm\:ss\:ff")
    End Sub

    Private Async Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim submission = New With {
            .name = textName.Text,
            .email = textEmail.Text,
            .phone = textPhone.Text,
            .github_link = textGithub.Text,
            .stopwatch_time = labelStopwatchTime.Text
        }

        Dim client As New HttpClient()
        client.DefaultRequestHeaders.Accept.Add(New System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"))
        Dim jsonData = JsonConvert.SerializeObject(submission)
        Dim content = New StringContent(jsonData, System.Text.Encoding.UTF8, "application/json")
        Dim response = Await client.PostAsync("http://localhost:3000/submit", content)

        If response.IsSuccessStatusCode Then
            MessageBox.Show("Submission successful!")
        Else
            MessageBox.Show("Submission failed.")
        End If
    End Sub

    Private Sub btnToggleStopwatch_KeyDown(sender As Object, e As KeyEventArgs) Handles btnToggleStopwatch.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.T Then
            btnToggleStopwatch.PerformClick()
        End If
    End Sub

    Private Sub btnSubmit_KeyDown(sender As Object, e As KeyEventArgs) Handles btnSubmit.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.S Then
            btnSubmit.PerformClick()
        End If
    End Sub
End Class
