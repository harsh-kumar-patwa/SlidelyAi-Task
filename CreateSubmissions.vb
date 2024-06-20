Imports System.Net.Http
Imports Newtonsoft.Json
Imports System.Text
Imports System.Diagnostics


Public Class CreateSubmissions

        Private stopwatch As Stopwatch = New Stopwatch()
        Private isStopwatchRunning As Boolean = False
    Private WithEvents timer As Timer

    Private Sub btnToggleStopwatch_Click(sender As Object, e As EventArgs) Handles btnToggleStopwatch.Click
        If isStopwatchRunning Then
            stopwatch.Stop()
            isStopwatchRunning = False
            UpdateStopwatchLabel()

        Else
            stopwatch.Start()
            isStopwatchRunning = True
            UpdateStopwatchLabel()

        End If

    End Sub

        Private Sub UpdateStopwatchLabel()
            labelStopwatchTime.Text = stopwatch.Elapsed.ToString("hh\:mm\:ss")
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



        Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

        End Sub

        Private Sub labelStopwatchTime_Click(sender As Object, e As EventArgs) Handles labelStopwatchTime.Click

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

