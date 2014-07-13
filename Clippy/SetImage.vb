Imports System.IO
Public Class SetImage

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SelectImage.FileOk
        TextBox1.Text = SelectImage.FileName
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If File.Exists(TextBox1.Text) Then
            PictureBox1.ImageLocation = TextBox1.Text
            Clipboard.SetImage(PictureBox1.Image)
        Else
            MsgBox("'" & TextBox1.Text & "' could not be found!", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        SelectImage.ShowDialog()
    End Sub
End Class