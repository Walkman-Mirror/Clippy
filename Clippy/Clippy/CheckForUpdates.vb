Public Class CheckForUpdates

    Private Sub CheckForUpdates_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Check()
    End Sub

    Sub Check()
        WebBrowser1.Navigate("https://deavmi.github.io/Clippy/current_version.txt")
    End Sub

    Private Sub ReadData()
        If WebBrowser1.Document.Body.InnerText > My.Application.Info.Version.ToString Then
            Label1.Text = "An update is available."
            btnGetUpdate.Visible = False
        Else
            Label1.Text = "No updates available"
            btnGetUpdate.Visible = False
        End If
    End Sub
End Class