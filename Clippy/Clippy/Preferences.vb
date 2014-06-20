Public Class Preferences

    Private Sub Reset(sender As Object, e As EventArgs) Handles btnReset.Click
        My.Settings.Reset()
        MsgBox("Setting have been reset!", MsgBoxStyle.Information)
        ApplyChanges()
    End Sub

    Private Sub Preferences_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.HideOnStartup = True Then
            chkHideClippyOnStartup.CheckState = CheckState.Checked
        Else
            chkHideClippyOnStartup.CheckState = CheckState.Unchecked
        End If
        If My.Settings.CheckForUpdatesOnStartup = True Then
            chkCheckForUpdatesOnStartup.CheckState = CheckState.Checked
        Else
            chkCheckForUpdatesOnStartup.CheckState = CheckState.Unchecked
        End If
        If My.Settings.UseTimers = True Then
            chkUseTimerCheckers.Checked = True
        Else
            chkUseTimerCheckers.Checked = False
        End If
        TextBox1.Text = My.Settings.UseTimers_interval
        chkUseTimerCheckers_CheckedChanged(sender:=Nothing, e:=Nothing)
    End Sub

    Private Sub ApplyChanges()
        If chkHideClippyOnStartup.CheckState = CheckState.Checked = True Then
            My.Settings.HideOnStartup = True
        Else
            My.Settings.HideOnStartup = False
        End If
        If chkCheckForUpdatesOnStartup.CheckState = CheckState.Checked = True Then
            My.Settings.CheckForUpdatesOnStartup = True
        Else
            My.Settings.CheckForUpdatesOnStartup = False
        End If
        If chkUseTimerCheckers.Checked = True Then
            My.Settings.UseTimers = True
            My.Settings.UseTimers_interval = TextBox1.Text
        Else
            My.Settings.UseTimers = False
        End If
        My.Settings.Save()
    End Sub

    Private Sub Done(sender As Object, e As EventArgs) Handles btnDone.Click
        ApplyChanges()
        Me.Close()
    End Sub

    Private Sub chkUseTimerCheckers_CheckedChanged(sender As Object, e As EventArgs) Handles chkUseTimerCheckers.CheckedChanged
        If chkUseTimerCheckers.Checked = True Then
            Label3.Enabled = True
            TextBox1.Enabled = True
        Else
            Label3.Enabled = False
            TextBox1.Enabled = False
        End If
    End Sub
End Class