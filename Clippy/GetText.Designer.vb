<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GetText
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtTitle = New System.Windows.Forms.Label()
        Me.GetTextFromClipboard = New System.Windows.Forms.Timer(Me.components)
        Me.rtxbxClipboardText = New System.Windows.Forms.RichTextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.txtTitle)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(367, 47)
        Me.Panel1.TabIndex = 0
        '
        'txtTitle
        '
        Me.txtTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitle.Location = New System.Drawing.Point(12, 9)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(343, 25)
        Me.txtTitle.TabIndex = 0
        Me.txtTitle.Text = "Current clipboard text"
        Me.txtTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GetTextFromClipboard
        '
        '
        'rtxbxClipboardText
        '
        Me.rtxbxClipboardText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtxbxClipboardText.Location = New System.Drawing.Point(0, 47)
        Me.rtxbxClipboardText.Name = "rtxbxClipboardText"
        Me.rtxbxClipboardText.ReadOnly = True
        Me.rtxbxClipboardText.Size = New System.Drawing.Size(367, 267)
        Me.rtxbxClipboardText.TabIndex = 0
        Me.rtxbxClipboardText.Text = ""
        '
        'GetText
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(367, 314)
        Me.Controls.Add(Me.rtxbxClipboardText)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "GetText"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Current clipboard text"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtTitle As System.Windows.Forms.Label
    Friend WithEvents GetTextFromClipboard As System.Windows.Forms.Timer
    Friend WithEvents rtxbxClipboardText As System.Windows.Forms.RichTextBox
End Class
