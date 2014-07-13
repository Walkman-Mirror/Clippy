Imports System.IO
Public Class SetText

    Private Sub SetText_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Thanks to DotNetPerls for this below code of reading from a text file.
        Dim textfile As String = Nothing
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog.FileOk
        TextBox1.Text = OpenFileDialog.FileName
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        rtxbxSetClipboardText.Text = File.ReadAllText(TextBox1.Text)
    End Sub

    Private Sub rtxbxSetClipboardText_TextChanged(sender As Object, e As EventArgs) Handles rtxbxSetClipboardText.TextChanged
        Clipboard.SetText(rtxbxSetClipboardText.Text)
    End Sub
End Class
