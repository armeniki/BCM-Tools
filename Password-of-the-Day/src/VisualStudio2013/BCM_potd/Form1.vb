''BCM Support Tools
''BCM Password-of-the-Day Generator
''GitHub 2020


Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Security.Cryptography
Imports System.Text
Imports System.Windows.Forms



Public Class Form1

    Public Sub New()
        MyBase.New()
        Dim form11 As Form1 = Me
        AddHandler MyBase.Load, New EventHandler(AddressOf form11.Form1_Load)

        Me.InitializeComponent()
    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
        Me.ComboBox_day.Text = Today.Day
        Me.ComboBox_month.Text = Today.Month
        Me.ComboBox_year.Text = Today.Year

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Me.TextBox_SystemID.Clear()
        Me.TextBox_SystemDate.Clear()
        Me.TextBox_ChallengePhrase.Clear()
        Me.TextBox_Password.Clear()
        Me.ComboBox_SystemRelease.ResetText()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim SHA1_Hash As Object = Nothing
        Dim bytes As Object = Nothing



        ''Here we need to select how the telephone's display their date -- different format displays are hashed/concatenated differently
        If (Me.ComboBox_systemdateformat.SelectedIndex = 0) Then
            Me.TextBox_SystemDate.Text =
                (Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Me.ComboBox_day.SelectedItem, "/"), Me.ComboBox_month.SelectedItem), "/"), Me.ComboBox_year.SelectedItem))
        ElseIf (Me.ComboBox_systemdateformat.SelectedIndex = 1) Then
            Me.TextBox_SystemDate.Text =
                (Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Me.ComboBox_month.SelectedItem, "/"), Me.ComboBox_day.SelectedItem), "/"), Me.ComboBox_year.SelectedItem))
        ElseIf (Me.ComboBox_systemdateformat.SelectedIndex = 2) Then
            Me.TextBox_SystemDate.Text =
                (Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Me.ComboBox_year.SelectedItem, "/"), Me.ComboBox_month.SelectedItem), "/"), Me.ComboBox_day.SelectedItem))
        End If


        ''This is base string
        Dim BCMBaseString As Object = String.Concat("W -- POD ", Me.TextBox_SystemDate.Text, " --- BCM -- C")


        ''See which release the user has.  If the user has Release 1, then "nnsupport" is not part of the concatenation.

        If (Me.ComboBox_SystemRelease.SelectedIndex = 0) Then
            SHA1_Hash = Me.calcSHA(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(BCMBaseString, Me.TextBox_ChallengePhrase.Text), Me.TextBox_SystemID.Text), "nnsupport")))


            ''Even though the options for Release 2 to 6 are given to the user, they are calculated the same way

        ElseIf (Me.ComboBox_SystemRelease.SelectedIndex = 1) Then
            SHA1_Hash = Me.calcSHA(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(String.Concat("nnsupport", Me.TextBox_ChallengePhrase.Text), BCMBaseString), Me.TextBox_SystemID.Text)))
        ElseIf (Me.ComboBox_SystemRelease.SelectedIndex = 2) Then
            SHA1_Hash = Me.calcSHA(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(String.Concat("nnsupport", Me.TextBox_ChallengePhrase.Text), BCMBaseString), Me.TextBox_SystemID.Text)))
        ElseIf (Me.ComboBox_SystemRelease.SelectedIndex = 3) Then
            SHA1_Hash = Me.calcSHA(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(String.Concat("nnsupport", Me.TextBox_ChallengePhrase.Text), BCMBaseString), Me.TextBox_SystemID.Text)))
        ElseIf (Me.ComboBox_SystemRelease.SelectedIndex = 4) Then
            SHA1_Hash = Me.calcSHA(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(String.Concat("nnsupport", Me.TextBox_ChallengePhrase.Text), BCMBaseString), Me.TextBox_SystemID.Text)))
        ElseIf (Me.ComboBox_SystemRelease.SelectedIndex = 5) Then
            SHA1_Hash = Me.calcSHA(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(String.Concat("nnsupport", Me.TextBox_ChallengePhrase.Text), BCMBaseString), Me.TextBox_SystemID.Text)))
        ElseIf (Me.ComboBox_SystemRelease.SelectedIndex = 6) Then
            SHA1_Hash = Me.calcSHA(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(String.Concat("nnsupport", Me.TextBox_ChallengePhrase.Text), BCMBaseString), Me.TextBox_SystemID.Text)))
        End If



        Dim ChunkArray(8) As Object
        Dim ChunkArray1(8) As Object



        ChunkArray(0) = Strings.Mid(Conversions.ToString(SHA1_Hash), 1, 2)
        ChunkArray(1) = Strings.Mid(Conversions.ToString(SHA1_Hash), 5, 2)
        ChunkArray(2) = Strings.Mid(Conversions.ToString(SHA1_Hash), 9, 2)
        ChunkArray(3) = Strings.Mid(Conversions.ToString(SHA1_Hash), 13, 2)
        ChunkArray(4) = Strings.Mid(Conversions.ToString(SHA1_Hash), 17, 2)
        ChunkArray(5) = Strings.Mid(Conversions.ToString(SHA1_Hash), 21, 2)
        ChunkArray(6) = Strings.Mid(Conversions.ToString(SHA1_Hash), 25, 2)
        ChunkArray(7) = Strings.Mid(Conversions.ToString(SHA1_Hash), 29, 2)


        Dim n As Integer = 0


        Do

            ''First chunk
            If (Operators.CompareString(Strings.Mid(Conversions.ToString(ChunkArray(n)), 1, 1), "0", False) = 0) Then
                ChunkArray1(n) = 0
            ElseIf (Operators.CompareString(Strings.Mid(Conversions.ToString(ChunkArray(n)), 1, 1), "1", False) = 0) Then
                ChunkArray1(n) = 10
            ElseIf (Operators.CompareString(Strings.Mid(Conversions.ToString(ChunkArray(n)), 1, 1), "2", False) = 0) Then
                ChunkArray1(n) = 20
            ElseIf (Operators.CompareString(Strings.Mid(Conversions.ToString(ChunkArray(n)), 1, 1), "3", False) = 0) Then
                ChunkArray1(n) = 30
            ElseIf (Operators.CompareString(Strings.Mid(Conversions.ToString(ChunkArray(n)), 1, 1), "3", False) = 0) Then
                ChunkArray1(n) = 30
            ElseIf (Operators.CompareString(Strings.Mid(Conversions.ToString(ChunkArray(n)), 1, 1), "4", False) = 0) Then
                ChunkArray1(n) = 40
            ElseIf (Operators.CompareString(Strings.Mid(Conversions.ToString(ChunkArray(n)), 1, 1), "5", False) = 0) Then
                ChunkArray1(n) = 50
            ElseIf (Operators.CompareString(Strings.Mid(Conversions.ToString(ChunkArray(n)), 1, 1), "6", False) = 0) Then
                ChunkArray1(n) = 60
            ElseIf (Operators.CompareString(Strings.Mid(Conversions.ToString(ChunkArray(n)), 1, 1), "7", False) = 0) Then
                ChunkArray1(n) = 70
            ElseIf (Operators.CompareString(Strings.Mid(Conversions.ToString(ChunkArray(n)), 1, 1), "8", False) = 0) Then
                ChunkArray1(n) = 80
            ElseIf (Operators.CompareString(Strings.Mid(Conversions.ToString(ChunkArray(n)), 1, 1), "9", False) = 0) Then
                ChunkArray1(n) = 90
            ElseIf (Operators.CompareString(Strings.Mid(Conversions.ToString(ChunkArray(n)), 1, 1), "a", False) = 0) Then
                ChunkArray1(n) = 0
            ElseIf (Operators.CompareString(Strings.Mid(Conversions.ToString(ChunkArray(n)), 1, 1), "b", False) = 0) Then
                ChunkArray1(n) = 80
            ElseIf (Operators.CompareString(Strings.Mid(Conversions.ToString(ChunkArray(n)), 1, 1), "c", False) = 0) Then
                ChunkArray1(n) = 70
            ElseIf (Operators.CompareString(Strings.Mid(Conversions.ToString(ChunkArray(n)), 1, 1), "d", False) = 0) Then
                ChunkArray1(n) = 60
            ElseIf (Operators.CompareString(Strings.Mid(Conversions.ToString(ChunkArray(n)), 1, 1), "e", False) = 0) Then
                ChunkArray1(n) = 50
            ElseIf (Operators.CompareString(Strings.Mid(Conversions.ToString(ChunkArray(n)), 1, 1), "f", False) = 0) Then
                ChunkArray1(n) = 40
            End If


            ''Second chunk
            If (Operators.CompareString(Strings.Mid(Conversions.ToString(ChunkArray(n)), 2, 1), "0", False) = 0) Then
                ChunkArray1(n) = Operators.AddObject(ChunkArray1(n), 0)
            ElseIf (Operators.CompareString(Strings.Mid(Conversions.ToString(ChunkArray(n)), 2, 1), "1", False) = 0) Then
                ChunkArray1(n) = Operators.AddObject(ChunkArray1(n), 1)
            ElseIf (Operators.CompareString(Strings.Mid(Conversions.ToString(ChunkArray(n)), 2, 1), "2", False) = 0) Then
                ChunkArray1(n) = Operators.AddObject(ChunkArray1(n), 2)
            ElseIf (Operators.CompareString(Strings.Mid(Conversions.ToString(ChunkArray(n)), 2, 1), "3", False) = 0) Then
                ChunkArray1(n) = Operators.AddObject(ChunkArray1(n), 3)
            ElseIf (Operators.CompareString(Strings.Mid(Conversions.ToString(ChunkArray(n)), 2, 1), "3", False) = 0) Then
                ChunkArray1(n) = Operators.AddObject(ChunkArray1(n), 3)
            ElseIf (Operators.CompareString(Strings.Mid(Conversions.ToString(ChunkArray(n)), 2, 1), "4", False) = 0) Then
                ChunkArray1(n) = Operators.AddObject(ChunkArray1(n), 4)
            ElseIf (Operators.CompareString(Strings.Mid(Conversions.ToString(ChunkArray(n)), 2, 1), "5", False) = 0) Then
                ChunkArray1(n) = Operators.AddObject(ChunkArray1(n), 5)
            ElseIf (Operators.CompareString(Strings.Mid(Conversions.ToString(ChunkArray(n)), 2, 1), "6", False) = 0) Then
                ChunkArray1(n) = Operators.AddObject(ChunkArray1(n), 6)
            ElseIf (Operators.CompareString(Strings.Mid(Conversions.ToString(ChunkArray(n)), 2, 1), "7", False) = 0) Then
                ChunkArray1(n) = Operators.AddObject(ChunkArray1(n), 7)
            ElseIf (Operators.CompareString(Strings.Mid(Conversions.ToString(ChunkArray(n)), 2, 1), "8", False) = 0) Then
                ChunkArray1(n) = Operators.AddObject(ChunkArray1(n), 8)
            ElseIf (Operators.CompareString(Strings.Mid(Conversions.ToString(ChunkArray(n)), 2, 1), "9", False) = 0) Then
                ChunkArray1(n) = Operators.AddObject(ChunkArray1(n), 9)
            ElseIf (Operators.CompareString(Strings.Mid(Conversions.ToString(ChunkArray(n)), 2, 1), "a", False) = 0) Then
                ChunkArray1(n) = Operators.AddObject(ChunkArray1(n), 0)
            ElseIf (Operators.CompareString(Strings.Mid(Conversions.ToString(ChunkArray(n)), 2, 1), "b", False) = 0) Then
                ChunkArray1(n) = Operators.AddObject(ChunkArray1(n), 8)
            ElseIf (Operators.CompareString(Strings.Mid(Conversions.ToString(ChunkArray(n)), 2, 1), "c", False) = 0) Then
                ChunkArray1(n) = Operators.AddObject(ChunkArray1(n), 7)
            ElseIf (Operators.CompareString(Strings.Mid(Conversions.ToString(ChunkArray(n)), 2, 1), "d", False) = 0) Then
                ChunkArray1(n) = Operators.AddObject(ChunkArray1(n), 6)
            ElseIf (Operators.CompareString(Strings.Mid(Conversions.ToString(ChunkArray(n)), 2, 1), "e", False) = 0) Then
                ChunkArray1(n) = Operators.AddObject(ChunkArray1(n), 5)
            ElseIf (Operators.CompareString(Strings.Mid(Conversions.ToString(ChunkArray(n)), 2, 1), "f", False) = 0) Then
                ChunkArray1(n) = Operators.AddObject(ChunkArray1(n), 4)
            End If


            ''The POTD must be a 16-digit number - if there are any single digit values, we need to pad it with a '0' in front:
            If ((RuntimeHelpers.GetObjectValue(ChunkArray1(n))) > 9) Then
                bytes = Operators.ConcatenateObject(bytes, ChunkArray1(n))
            Else
                bytes = Operators.ConcatenateObject(Operators.ConcatenateObject(bytes, "0"), ChunkArray1(n))
            End If


            n = n + 1

            ''Go through each chunk 8 times
        Loop While n <= 7


        ''When done, update the text box with the login password
        Me.TextBox_Password.Text = Conversions.ToString(bytes)
    End Sub


    Public Function calcSHA(ByVal String_to_Hash As String) As String
        Dim sHA1CryptoServiceProvider As System.Security.Cryptography.SHA1CryptoServiceProvider = New System.Security.Cryptography.SHA1CryptoServiceProvider()
        Dim bytes As Byte() = Encoding.ASCII.GetBytes(String_to_Hash)
        bytes = sHA1CryptoServiceProvider.ComputeHash(bytes)
        Dim str As String = ""
        Dim numArray As Byte() = bytes
        Dim n As Integer = 0
        While n < CInt(numArray.Length)
            Dim num1 As Byte = numArray(n)
            str = String.Concat(str, num1.ToString("x2"))
            n = n + 1
        End While
        Return str
    End Function



    Private Sub Form1_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    
End Class
