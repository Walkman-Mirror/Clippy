Public Class Preferences

    Private Sub Reset(sender As Object, e As EventArgs) Handles btnReset.Click
        My.Settings.Reset()
        MsgBox("Setting have been reset!", MsgBoxStyle.Information)
        ApplyChanges()
    End Sub

    Private Sub Preferences_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            chkHideClippyOnStartup.Checked = My.Settings.HideOnStartup
            chkUseTimerCheckers.Checked = My.Settings.UseTimers
            TextBox1.Text = My.Settings.UseTimers_interval
            chkUseTimerCheckers_CheckedChanged(sender:=Nothing, e:=Nothing)
    End Sub

    Private Sub ApplyChanges()
        My.Settings.HideOnStartup = chkHideClippyOnStartup.Checked
        My.Settings.UseTimers = chkUseTimerCheckers.Checked
        My.Settings.UseTimers_interval = TextBox1.Text
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