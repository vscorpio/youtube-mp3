Imports System.Net.NetworkInformation
Imports System.Threading


' Author: Victor Puiu
' E-mail: victor.puiu01@gmail.com
' Do not assume the credit for the code you just obfuscated :P

Public Class Form1
    Dim var31 As String
    Dim playlistfetchend As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

            If TextBox1.Text.Contains("https://www.youtube.com/watch?v=") Then
                Process.Start("cmd.exe", "/c youtube-dl -o 'output/%(title)s.%(ext)s' --extract-audio --audio-format mp3 " & TextBox1.Text)
                TextBox1.Clear()
            ElseIf TextBox1.Text.Contains("http://www.youtube.com/watch?v=") Then
                Process.Start("cmd.exe", "/c youtube-dl -o 'output/%(title)s.%(ext)s' --extract-audio --audio-format mp3 " & TextBox1.Text)
                TextBox1.Clear()
            Else
                MsgBox("Invalid link!")


        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        SaveFileDialog1.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox1.Text.Contains("https://www.youtube.com/watch?v=") Then
            ListBox1.Items.Add(TextBox1.Text)
            TextBox1.Clear()
        ElseIf TextBox1.Text.Contains("http://www.youtube.com/watch?v=") Then
            ListBox1.Items.Add(TextBox1.Text)
            TextBox1.Clear()
        Else
            MsgBox("Invalid link!")
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MsgBox("The GUI will become un-responsive while the download occurs, please sit tight.")
        ' Dim t As New Thread(AddressOf dodownload)
        ' t.Start()
        For Each i As String In ListBox1.Items
            Dim proc As New Process
            proc.StartInfo.FileName = "cmd.exe"
            proc.StartInfo.Arguments = "/c youtube-dl -o 'output/%(title)s.%(ext)s' --extract-audio --audio-format mp3 " & i & Environment.NewLine & "pause"""
            proc.StartInfo.CreateNoWindow = True
            proc.StartInfo.UseShellExecute = False
            proc.StartInfo.RedirectStandardOutput = True
            proc.Start()
            If RadioButton2.Checked = True Then
                proc.Start()
                proc.WaitForExit()
            Else
                proc.Start()
            End If

        Next

    End Sub

    '  Sub dodownload()
    

    ' Next
    ' End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Label2.Text = "List count: " & ListBox1.Items.Count()

        If ListBox1.Items.Count > 20 Then
            Label10.Visible = True
        End If
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        For Each i As String In TextBox3.Lines
            ListBox1.Items.Add(i)
        Next
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("Warning! Take care when using all-at-once mode at many songs!")
    End Sub


    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Form2.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ListBox1.Items.Clear()
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            Button1.Enabled = True
            Button3.Enabled = True
            Button4.Enabled = True
            Button5.Enabled = True
        Else
            Button1.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
            Button5.Enabled = False

        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

        Label5.Text = DateTime.Now()
        ProgressBar1.Value = pc_CPU.NextValue
        ProgressBar2.Value = pc_RAM.NextValue
        Label9.Text = ProgressBar2.Value & "%"
        Label8.Text = ProgressBar1.Value & "%"
        Dim netu As Integer = pc_NETU.NextValue / 1024
        Dim netd As Integer = pc_NETD.NextValue / 1024
        Label11.Text = netd.ToString & "KB/s"
        Label12.Text = netu.ToString & "KB/s"



    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        MsgBox("The program will become un-responsive while we query the playlist. It might take a few minutes. The speed dependes on your internet and your computer. ~20sec/20songs(~1s/song)")
        Dim proc As New Process
        proc.StartInfo.FileName = "cmd.exe"
        proc.StartInfo.Arguments = "/c youtube-dl.exe --get-id " & TextBox2.Text & " -i"""
        proc.StartInfo.CreateNoWindow = True
        proc.StartInfo.UseShellExecute = False
        proc.StartInfo.RedirectStandardOutput = True
        proc.Start()
        proc.WaitForExit()

        Dim output() As String = proc.StandardOutput.ReadToEnd.Split(CChar(vbLf))
        For Each ln As String In output
            TextBox3.AppendText((ln & vbNewLine))
        Next

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        MsgBox("The program is still in early-alpha development and there might be left-over files left after the conversion. The 'all-at-once' option is not recommended for weak PCs.")
    End Sub

End Class
