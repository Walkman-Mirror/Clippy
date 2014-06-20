Public Class Preferences

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Reset(sender As Object, e As EventArgs) Handles btnReset.Click
        My.Settings.Reset()
        MsgBox("Clippy will now restart! Please click Ok.")
        Application.Restart()
    End Sub
End Class