Public Class Preferences

    Private Sub Reset(sender As Object, e As EventArgs) Handles btnReset.Click
        My.Settings.Reset()
        MsgBox("Setting have been reset!", MsgBoxStyle.Information)
        ApplyChanges()
    End Sub

    Private Sub Preferences_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.HideOnStartup = True Then
            CheckBox1.CheckState = CheckState.Checked
        Else
            CheckBox1.CheckState = CheckState.Unchecked
        End If
        If My.Settings.CheckForUpdatesOnStartup = True Then
            CheckBox2.CheckState = CheckState.Checked
        Else
            CheckBox2.CheckState = CheckState.Unchecked
        End If
    End Sub

    Private Sub ApplyChanges()
        If CheckBox1.CheckState = CheckState.Checked = True Then
            My.Settings.HideOnStartup = True
        Else
            My.Settings.HideOnStartup = False
        End If
        If CheckBox2.CheckState = CheckState.Checked = True Then
            My.Settings.CheckForUpdatesOnStartup = True
        Else
            My.Settings.CheckForUpdatesOnStartup = False
        End If
        My.Settings.Save()
    End Sub

    Private Sub Done(sender As Object, e As EventArgs) Handles btnDone.Click
        ApplyChanges()
        Me.Close()
    End Sub
End Class