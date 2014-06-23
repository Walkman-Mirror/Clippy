Public Class Form1

    Private Sub Quit(sender As Object, e As EventArgs) Handles QuitClippToolStripMenuItem.Click, Button2.Click
        Application.Exit()
    End Sub

    Private Sub ClearClipboard(sender As Object, e As EventArgs) Handles ClearClipboardToolStripMenuItem.Click
        Clipboard.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        Me.Show()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Preferences.ShowDialog()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.HideOnStartup = True Then Me.Hide()
    End Sub

    Private Sub ShowText(sender As Object, e As EventArgs) Handles ShowtextToolStripMenuItem.Click
        GetText.Show()
    End Sub

    Private Sub ShowimageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowimageToolStripMenuItem.Click
        GetImage.Show()
    End Sub

    Private Sub CheckForupdtaesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheckForupdtaesToolStripMenuItem.Click
        CheckForUpdates.ShowDialog()
    End Sub

    Private Sub AboutClippyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutClippyToolStripMenuItem.Click
        About.ShowDialog()
    End Sub
End Class
