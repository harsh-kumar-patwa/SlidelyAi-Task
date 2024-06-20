<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateSubmissions
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
        btnSubmit = New Button()
        btnToggleStopwatch = New Button()
        textGithub = New TextBox()
        TextBox9 = New TextBox()
        textPhone = New TextBox()
        TextBox7 = New TextBox()
        textEmail = New TextBox()
        TextBox5 = New TextBox()
        textName = New TextBox()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        labelStopwatchTime = New Label()
        SuspendLayout()
        ' 
        ' btnSubmit
        ' 
        btnSubmit.BackColor = Color.LightSkyBlue
        btnSubmit.FlatStyle = FlatStyle.Flat
        btnSubmit.Font = New Font("Segoe UI", 10.5F)
        btnSubmit.ImageAlign = ContentAlignment.BottomLeft
        btnSubmit.Location = New Point(23, 479)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(408, 42)
        btnSubmit.TabIndex = 28
        btnSubmit.Text = "SUBMIT (CTRL+S)"
        btnSubmit.UseVisualStyleBackColor = False
        ' 
        ' btnToggleStopwatch
        ' 
        btnToggleStopwatch.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        btnToggleStopwatch.FlatStyle = FlatStyle.Flat
        btnToggleStopwatch.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnToggleStopwatch.Location = New Point(12, 403)
        btnToggleStopwatch.Name = "btnToggleStopwatch"
        btnToggleStopwatch.Size = New Size(277, 35)
        btnToggleStopwatch.TabIndex = 27
        btnToggleStopwatch.Text = "TOGGLE STOPWATCH (CTRL+T)"
        btnToggleStopwatch.UseVisualStyleBackColor = False
        ' 
        ' textGithub
        ' 
        textGithub.BackColor = Color.White
        textGithub.BorderStyle = BorderStyle.FixedSingle
        textGithub.Location = New Point(157, 307)
        textGithub.Name = "textGithub"
        textGithub.Size = New Size(262, 27)
        textGithub.TabIndex = 24
        ' 
        ' TextBox9
        ' 
        TextBox9.BorderStyle = BorderStyle.None
        TextBox9.Font = New Font("Segoe UI", 12F)
        TextBox9.Location = New Point(12, 294)
        TextBox9.Multiline = True
        TextBox9.Name = "TextBox9"
        TextBox9.Size = New Size(139, 59)
        TextBox9.TabIndex = 23
        TextBox9.Text = "Github Link For Task2 "
        TextBox9.TextAlign = HorizontalAlignment.Center
        ' 
        ' textPhone
        ' 
        textPhone.BackColor = Color.White
        textPhone.BorderStyle = BorderStyle.FixedSingle
        textPhone.Location = New Point(157, 236)
        textPhone.Name = "textPhone"
        textPhone.Size = New Size(262, 27)
        textPhone.TabIndex = 22
        ' 
        ' TextBox7
        ' 
        TextBox7.BorderStyle = BorderStyle.None
        TextBox7.Font = New Font("Segoe UI", 12F)
        TextBox7.Location = New Point(12, 231)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(139, 27)
        TextBox7.TabIndex = 21
        TextBox7.Text = "Phone Num"
        TextBox7.TextAlign = HorizontalAlignment.Center
        ' 
        ' textEmail
        ' 
        textEmail.BackColor = Color.White
        textEmail.BorderStyle = BorderStyle.FixedSingle
        textEmail.Location = New Point(157, 170)
        textEmail.Name = "textEmail"
        textEmail.Size = New Size(262, 27)
        textEmail.TabIndex = 20
        ' 
        ' TextBox5
        ' 
        TextBox5.BorderStyle = BorderStyle.None
        TextBox5.Font = New Font("Segoe UI", 12F)
        TextBox5.Location = New Point(12, 166)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(139, 27)
        TextBox5.TabIndex = 19
        TextBox5.Text = "Email"
        TextBox5.TextAlign = HorizontalAlignment.Center
        ' 
        ' textName
        ' 
        textName.BackColor = Color.White
        textName.BorderStyle = BorderStyle.FixedSingle
        textName.Location = New Point(157, 108)
        textName.Name = "textName"
        textName.Size = New Size(262, 27)
        textName.TabIndex = 18
        ' 
        ' TextBox2
        ' 
        TextBox2.BorderStyle = BorderStyle.None
        TextBox2.Font = New Font("Segoe UI", 12F)
        TextBox2.Location = New Point(12, 104)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(139, 27)
        TextBox2.TabIndex = 17
        TextBox2.Text = "Name"
        TextBox2.TextAlign = HorizontalAlignment.Center
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = SystemColors.Window
        TextBox1.BorderStyle = BorderStyle.None
        TextBox1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(12, 34)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(432, 27)
        TextBox1.TabIndex = 16
        TextBox1.Text = "Harsh Kumar , Slidely Task 2 - Create Submissions"
        TextBox1.TextAlign = HorizontalAlignment.Center
        ' 
        ' labelStopwatchTime
        ' 
        labelStopwatchTime.AutoSize = True
        labelStopwatchTime.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        labelStopwatchTime.BorderStyle = BorderStyle.FixedSingle
        labelStopwatchTime.FlatStyle = FlatStyle.Flat
        labelStopwatchTime.Font = New Font("Segoe UI", 10.5F)
        labelStopwatchTime.Location = New Point(325, 405)
        labelStopwatchTime.Name = "labelStopwatchTime"
        labelStopwatchTime.Size = New Size(82, 27)
        labelStopwatchTime.TabIndex = 29
        labelStopwatchTime.Text = "00:00:00"
        ' 
        ' CreateSubmissions
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(456, 555)
        Controls.Add(labelStopwatchTime)
        Controls.Add(btnSubmit)
        Controls.Add(btnToggleStopwatch)
        Controls.Add(textGithub)
        Controls.Add(TextBox9)
        Controls.Add(textPhone)
        Controls.Add(TextBox7)
        Controls.Add(textEmail)
        Controls.Add(TextBox5)
        Controls.Add(textName)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Name = "CreateSubmissions"
        Text = "CreateSubmissions"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnToggleStopwatch As Button
    Friend WithEvents textGithub As TextBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents textPhone As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents textEmail As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents textName As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents labelStopwatchTime As Label
End Class
