Public Class GetText

    Private Sub GetTextFromClipboard_Tick(sender As Object, e As EventArgs) Handles GetTextFromClipboard.Tick
        GetClipboardTextContents()
    End Sub

    Private Sub GetText_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.UseTimers = True Then
            GetTextFromClipboard.Start()
        Else
            GetClipboardTextContents()
        End If
    End Sub

    Private Sub GetClipboardTextContents()
        RichTextBox1.Text = Clipboard.GetText()
    End Sub
End Class