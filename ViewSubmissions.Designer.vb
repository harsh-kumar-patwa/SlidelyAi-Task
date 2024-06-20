<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewSubmissions
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
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        textName = New TextBox()
        textEmail = New TextBox()
        TextBox5 = New TextBox()
        textPhone = New TextBox()
        TextBox7 = New TextBox()
        textGithub = New TextBox()
        TextBox9 = New TextBox()
        textStopwatchTime = New TextBox()
        TextBox11 = New TextBox()
        btnPrevious = New Button()
        btnNext = New Button()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = SystemColors.Window
        TextBox1.BorderStyle = BorderStyle.None
        TextBox1.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(12, 12)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(432, 27)
        TextBox1.TabIndex = 3
        TextBox1.Text = "Harsh Kumar , Slidely Task 2 - View Submissions"
        TextBox1.TextAlign = HorizontalAlignment.Center
        ' 
        ' TextBox2
        ' 
        TextBox2.BorderStyle = BorderStyle.None
        TextBox2.Font = New Font("Segoe UI", 12.0F)
        TextBox2.Location = New Point(12, 82)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(139, 27)
        TextBox2.TabIndex = 4
        TextBox2.Text = "Name"
        TextBox2.TextAlign = HorizontalAlignment.Center
        ' 
        ' textName
        ' 
        textName.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        textName.BorderStyle = BorderStyle.FixedSingle
        textName.Location = New Point(157, 86)
        textName.Name = "textName"
        textName.ReadOnly = True
        textName.Size = New Size(262, 27)
        textName.TabIndex = 5
        ' 
        ' textEmail
        ' 
        textEmail.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        textEmail.BorderStyle = BorderStyle.FixedSingle
        textEmail.Location = New Point(157, 148)
        textEmail.Name = "textEmail"
        textEmail.ReadOnly = True
        textEmail.Size = New Size(262, 27)
        textEmail.TabIndex = 7
        ' 
        ' TextBox5
        ' 
        TextBox5.BorderStyle = BorderStyle.None
        TextBox5.Font = New Font("Segoe UI", 12.0F)
        TextBox5.Location = New Point(12, 144)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(139, 27)
        TextBox5.TabIndex = 6
        TextBox5.Text = "Email"
        TextBox5.TextAlign = HorizontalAlignment.Center
        ' 
        ' textPhone
        ' 
        textPhone.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        textPhone.BorderStyle = BorderStyle.FixedSingle
        textPhone.Location = New Point(157, 214)
        textPhone.Name = "textPhone"
        textPhone.ReadOnly = True
        textPhone.Size = New Size(262, 27)
        textPhone.TabIndex = 9
        ' 
        ' TextBox7
        ' 
        TextBox7.BorderStyle = BorderStyle.None
        TextBox7.Font = New Font("Segoe UI", 12.0F)
        TextBox7.Location = New Point(12, 209)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(139, 27)
        TextBox7.TabIndex = 8
        TextBox7.Text = "Phone Num"
        TextBox7.TextAlign = HorizontalAlignment.Center
        ' 
        ' textGithub
        ' 
        textGithub.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        textGithub.BorderStyle = BorderStyle.FixedSingle
        textGithub.Location = New Point(157, 285)
        textGithub.Name = "textGithub"
        textGithub.ReadOnly = True
        textGithub.Size = New Size(262, 27)
        textGithub.TabIndex = 11
        ' 
        ' TextBox9
        ' 
        TextBox9.BorderStyle = BorderStyle.None
        TextBox9.Font = New Font("Segoe UI", 12.0F)
        TextBox9.Location = New Point(12, 272)
        TextBox9.Multiline = True
        TextBox9.Name = "TextBox9"
        TextBox9.Size = New Size(139, 59)
        TextBox9.TabIndex = 10
        TextBox9.Text = "Github Link For Task2 "
        TextBox9.TextAlign = HorizontalAlignment.Center
        ' 
        ' textStopwatchTime
        ' 
        textStopwatchTime.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        textStopwatchTime.BorderStyle = BorderStyle.FixedSingle
        textStopwatchTime.Location = New Point(157, 350)
        textStopwatchTime.Name = "textStopwatchTime"
        textStopwatchTime.ReadOnly = True
        textStopwatchTime.Size = New Size(262, 27)
        textStopwatchTime.TabIndex = 13
        ' 
        ' TextBox11
        ' 
        TextBox11.BorderStyle = BorderStyle.None
        TextBox11.Font = New Font("Segoe UI", 12.0F)
        TextBox11.Location = New Point(12, 346)
        TextBox11.Multiline = True
        TextBox11.Name = "TextBox11"
        TextBox11.Size = New Size(139, 54)
        TextBox11.TabIndex = 12
        TextBox11.Text = "Stopwatch Time"
        TextBox11.TextAlign = HorizontalAlignment.Center
        ' 
        ' btnPrevious
        ' 
        btnPrevious.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        btnPrevious.FlatStyle = FlatStyle.Flat
        btnPrevious.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnPrevious.Location = New Point(12, 457)
        btnPrevious.Name = "btnPrevious"
        btnPrevious.Size = New Size(208, 42)
        btnPrevious.TabIndex = 14
        btnPrevious.Text = "PREVIOUS (CTRL+P)"
        btnPrevious.UseVisualStyleBackColor = False
        ' 
        ' btnNext
        ' 
        btnNext.BackColor = Color.LightSkyBlue
        btnNext.FlatStyle = FlatStyle.Flat
        btnNext.Font = New Font("Segoe UI", 10.5F)
        btnNext.ImageAlign = ContentAlignment.BottomLeft
        btnNext.Location = New Point(226, 457)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(218, 42)
        btnNext.TabIndex = 15
        btnNext.Text = "NEXT (CTRL+N)"
        btnNext.UseVisualStyleBackColor = False
        ' 
        ' ViewSubmissions
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(456, 555)
        Controls.Add(btnNext)
        Controls.Add(btnPrevious)
        Controls.Add(textStopwatchTime)
        Controls.Add(TextBox11)
        Controls.Add(textGithub)
        Controls.Add(TextBox9)
        Controls.Add(textPhone)
        Controls.Add(TextBox7)
        Controls.Add(textEmail)
        Controls.Add(TextBox5)
        Controls.Add(textName)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Name = "ViewSubmissions"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents textName As TextBox
    Friend WithEvents textEmail As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents textPhone As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents textGithub As TextBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents textStopwatchTime As TextBox
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
End Class
