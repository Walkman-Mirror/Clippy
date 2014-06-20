Public Class GetText

    Private Sub GetTextFromClipboard_Tick(sender As Object, e As EventArgs) Handles GetTextFromClipboard.Tick
        RichTextBox1.Text = Clipboard.GetText()
    End Sub
End Class