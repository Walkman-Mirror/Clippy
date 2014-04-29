Public Class Form1

    Private Sub QuitClippToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitClippToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub ClearClipboardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearClipboardToolStripMenuItem.Click
        Clipboard.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        Me.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Preferences.ShowDialog()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.CLPY_HideOnStartup = True Then
            Me.Hide()
        End If
    End Sub
End Class
