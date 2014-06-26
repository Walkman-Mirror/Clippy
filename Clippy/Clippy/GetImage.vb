Public Class GetImage

    Private Sub GetImageFromClipboard_Tick(sender As Object, e As EventArgs) Handles GetImageFromClipboard.Tick
        GetClipboardImageContents()
    End Sub

    Private Sub GetImage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.UseTimers = True Then
            GetImageFromClipboard.Interval = My.Settings.UseTimers_interval
            GetImageFromClipboard.Start()
        Else
            GetClipboardImageContents()
        End If
    End Sub

    Private Sub GetClipboardImageContents()
        imgClipboardImage.Image = Clipboard.GetImage
    End Sub
End Class