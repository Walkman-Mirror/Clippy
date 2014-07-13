﻿Public Class Updates

    Private Sub CheckForUpdates_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Check()
    End Sub

    Sub Check()
        Label1.Text = "Checking for updates..."
        prgbrCheckForUpdates.Visible = True
        btnGetUpdate.Visible = False
        WebBrowser1.Navigate("https://deavmi.github.io/Clippy/current_version.txt")
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        'This is probably bad
        WebBrowser1.Refresh(WebBrowserRefreshOption.Completely)
        prgbrCheckForUpdates.Visible = False
        ReadData()
    End Sub

    Private Sub ReadData()
        Try
            If WebBrowser1.Document.Body.InnerText > My.Application.Info.Version.ToString Then
                Label1.Text = "An update is available!"
                btnGetUpdate.Visible = True
            Else
                Label1.Text = "No updates available."
                btnGetUpdate.Visible = False
            End If
        Catch ex As Exception
            Label1.Text = "No updates available."
            btnGetUpdate.Visible = False
            MsgBox("Could not check for updates!", MsgBoxStyle.Critical)
        End Try 
    End Sub

    Private Sub btnGetUpdate_Click(sender As Object, e As EventArgs) Handles btnGetUpdate.Click
        Process.Start("https://github.com/deavmi/Clippy/releases")
    End Sub
End Class