'DogeCoin-Live is a simple DogeCoin read-only wallet with other features too.
'   FGOSS from DeavmiOSS.

'   This program is free software: you can redistribute it and/or modify
'   it under the terms of the GNU General Public License as published by
'   the Free Software Foundation, either version 3 of the License, or
'   (at your option) any later version.

'   This program is distributed in the hope that it will be useful,
'   but WITHOUT ANY WARRANTY; without even the implied warranty of
'   MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
'   GNU General Public License for more details.

'   You should have received a copy of the GNU General Public License
'   along with this program.  If not, see <http://www.gnu.org/licenses/>.
'
'   Contact the DeavmiOSS orginization by electronic mail: mailto:tristankildaire@gmail.com or mailto:walkman100@gmail.com
'   Contact the DeavmiOSS orginization by paper mail: <no info>

Public Class About
    Private Sub About_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label4.Text = Label4.Text = My.Application.Info.Version.ToString & " (nightly)"
        WebBrowser1.Navigate("http://deavmi.github.io/Clippy/changelog.txt")
        WebBrowser2.Navigate("http://deavmi.github.io/Clippy/credits.txt")
        WebBrowser3.Navigate("http://deavmi.github.io/Clippy/licenses.txt")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Process.Start("http://deavmi.github.io/Clippy")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Process.Start("http://github.com/deavmi/Clippy")
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        changelog_text.Text = WebBrowser1.Document.Body.InnerText
    End Sub

    Private Sub WebBrowser2_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser2.DocumentCompleted
        credits_text.Text = WebBrowser2.Document.Body.InnerText
    End Sub

    Private Sub WebBrowser3_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser3.DocumentCompleted
        licenses_text.Text = WebBrowser3.Document.Body.InnerText
    End Sub
End Class