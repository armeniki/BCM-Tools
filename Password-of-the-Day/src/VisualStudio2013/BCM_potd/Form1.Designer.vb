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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox_SystemID = New System.Windows.Forms.TextBox()
        Me.TextBox_ChallengePhrase = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox_Login = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox_Password = New System.Windows.Forms.TextBox()
        Me.ComboBox_SystemRelease = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ComboBox_day = New System.Windows.Forms.ComboBox()
        Me.ComboBox_month = New System.Windows.Forms.ComboBox()
        Me.ComboBox_year = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox_SystemDate = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ComboBox_systemdateformat = New System.Windows.Forms.ComboBox()
        Me.GroupBox1_generatedcreds = New System.Windows.Forms.GroupBox()
        Me.GroupBox1_generatedcreds.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(210, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "All fields must be completed."
        '
        'TextBox_SystemID
        '
        Me.TextBox_SystemID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox_SystemID.Location = New System.Drawing.Point(147, 116)
        Me.TextBox_SystemID.MaxLength = 12
        Me.TextBox_SystemID.Name = "TextBox_SystemID"
        Me.TextBox_SystemID.Size = New System.Drawing.Size(121, 20)
        Me.TextBox_SystemID.TabIndex = 2
        '
        'TextBox_ChallengePhrase
        '
        Me.TextBox_ChallengePhrase.Location = New System.Drawing.Point(147, 249)
        Me.TextBox_ChallengePhrase.MaxLength = 200
        Me.TextBox_ChallengePhrase.Name = "TextBox_ChallengePhrase"
        Me.TextBox_ChallengePhrase.Size = New System.Drawing.Size(329, 20)
        Me.TextBox_ChallengePhrase.TabIndex = 7
        Me.TextBox_ChallengePhrase.Text = "trust no one"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(25, 298)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(451, 40)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "OK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "System ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 170)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "System Date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 252)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Challenge Phrase"
        '
        'TextBox_Login
        '
        Me.TextBox_Login.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Login.ForeColor = System.Drawing.Color.Blue
        Me.TextBox_Login.Location = New System.Drawing.Point(135, 26)
        Me.TextBox_Login.Name = "TextBox_Login"
        Me.TextBox_Login.Size = New System.Drawing.Size(329, 26)
        Me.TextBox_Login.TabIndex = 9
        Me.TextBox_Login.Text = "nnsupport"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 34)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Login"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 68)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Password"
        '
        'TextBox_Password
        '
        Me.TextBox_Password.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Password.ForeColor = System.Drawing.Color.Blue
        Me.TextBox_Password.Location = New System.Drawing.Point(135, 65)
        Me.TextBox_Password.Name = "TextBox_Password"
        Me.TextBox_Password.Size = New System.Drawing.Size(329, 26)
        Me.TextBox_Password.TabIndex = 12
        '
        'ComboBox_SystemRelease
        '
        Me.ComboBox_SystemRelease.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_SystemRelease.FormattingEnabled = True
        Me.ComboBox_SystemRelease.Items.AddRange(New Object() {"Release 1", "Release 2", "Release 3", "Release 4", "Release 5", "Release 6"})
        Me.ComboBox_SystemRelease.Location = New System.Drawing.Point(147, 73)
        Me.ComboBox_SystemRelease.Name = "ComboBox_SystemRelease"
        Me.ComboBox_SystemRelease.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox_SystemRelease.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(22, 76)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "System Release"
        '
        'ComboBox_day
        '
        Me.ComboBox_day.BackColor = System.Drawing.SystemColors.Window
        Me.ComboBox_day.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_day.FormattingEnabled = True
        Me.ComboBox_day.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"})
        Me.ComboBox_day.Location = New System.Drawing.Point(147, 167)
        Me.ComboBox_day.MaxDropDownItems = 40
        Me.ComboBox_day.Name = "ComboBox_day"
        Me.ComboBox_day.Size = New System.Drawing.Size(50, 21)
        Me.ComboBox_day.TabIndex = 3
        '
        'ComboBox_month
        '
        Me.ComboBox_month.BackColor = System.Drawing.SystemColors.Window
        Me.ComboBox_month.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_month.FormattingEnabled = True
        Me.ComboBox_month.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.ComboBox_month.Location = New System.Drawing.Point(218, 167)
        Me.ComboBox_month.MaxDropDownItems = 40
        Me.ComboBox_month.Name = "ComboBox_month"
        Me.ComboBox_month.Size = New System.Drawing.Size(50, 21)
        Me.ComboBox_month.TabIndex = 4
        '
        'ComboBox_year
        '
        Me.ComboBox_year.BackColor = System.Drawing.SystemColors.Window
        Me.ComboBox_year.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_year.FormattingEnabled = True
        Me.ComboBox_year.Items.AddRange(New Object() {"1980", "1981", "1982", "1983", "1984", "1985", "1986", "1987", "1988", "1989", "1990", "1991", "1992", "1993", "1994", "1995", "1996", "1997", "1998", "1999", "2000", "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030", "2031", "2032", "2033", "2034", "2035", "2036", "2037", "2038", "2039", "2040", "2041", "2042", "2043", "2044", "2045", "2046", "2047", "2048", "2049", "2050"})
        Me.ComboBox_year.Location = New System.Drawing.Point(286, 167)
        Me.ComboBox_year.MaxDropDownItems = 40
        Me.ComboBox_year.Name = "ComboBox_year"
        Me.ComboBox_year.Size = New System.Drawing.Size(70, 21)
        Me.ComboBox_year.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(159, 149)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(24, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "day"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(224, 149)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(36, 13)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "month"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(306, 149)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(27, 13)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "year"
        '
        'TextBox_SystemDate
        '
        Me.TextBox_SystemDate.Location = New System.Drawing.Point(33, 512)
        Me.TextBox_SystemDate.Name = "TextBox_SystemDate"
        Me.TextBox_SystemDate.Size = New System.Drawing.Size(329, 20)
        Me.TextBox_SystemDate.TabIndex = 2
        Me.TextBox_SystemDate.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(22, 212)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(102, 13)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "System Date Format"
        '
        'ComboBox_systemdateformat
        '
        Me.ComboBox_systemdateformat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_systemdateformat.FormattingEnabled = True
        Me.ComboBox_systemdateformat.Items.AddRange(New Object() {"dd/mm/yyyy", "mm/dd/yyyy", "yyyy/mm/dd"})
        Me.ComboBox_systemdateformat.Location = New System.Drawing.Point(147, 209)
        Me.ComboBox_systemdateformat.Name = "ComboBox_systemdateformat"
        Me.ComboBox_systemdateformat.Size = New System.Drawing.Size(209, 21)
        Me.ComboBox_systemdateformat.TabIndex = 6
        '
        'GroupBox1_generatedcreds
        '
        Me.GroupBox1_generatedcreds.Controls.Add(Me.TextBox_Password)
        Me.GroupBox1_generatedcreds.Controls.Add(Me.Label6)
        Me.GroupBox1_generatedcreds.Controls.Add(Me.Label5)
        Me.GroupBox1_generatedcreds.Controls.Add(Me.TextBox_Login)
        Me.GroupBox1_generatedcreds.Location = New System.Drawing.Point(12, 357)
        Me.GroupBox1_generatedcreds.Name = "GroupBox1_generatedcreds"
        Me.GroupBox1_generatedcreds.Size = New System.Drawing.Size(485, 108)
        Me.GroupBox1_generatedcreds.TabIndex = 22
        Me.GroupBox1_generatedcreds.TabStop = False
        Me.GroupBox1_generatedcreds.Text = "Generated Credentials"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(512, 485)
        Me.Controls.Add(Me.GroupBox1_generatedcreds)
        Me.Controls.Add(Me.ComboBox_systemdateformat)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ComboBox_year)
        Me.Controls.Add(Me.ComboBox_month)
        Me.Controls.Add(Me.ComboBox_day)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ComboBox_SystemRelease)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox_ChallengePhrase)
        Me.Controls.Add(Me.TextBox_SystemDate)
        Me.Controls.Add(Me.TextBox_SystemID)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.Text = "BCM Password-of-the-Day Utility"
        Me.GroupBox1_generatedcreds.ResumeLayout(False)
        Me.GroupBox1_generatedcreds.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox_SystemID As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_ChallengePhrase As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox_Login As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox_Password As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox_SystemRelease As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ComboBox_day As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox_month As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox_year As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TextBox_SystemDate As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents ComboBox_systemdateformat As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1_generatedcreds As System.Windows.Forms.GroupBox





End Class
