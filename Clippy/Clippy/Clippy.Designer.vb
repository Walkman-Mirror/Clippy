<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Clippy
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Clippy))
        Me.NotificationIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.NTrayMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ShowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowtextToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowimageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettextToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettextToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetimageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ClearClipboardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CheckForupdtaesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutClippyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.QuitClippToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.imgLogo = New System.Windows.Forms.PictureBox()
        Me.txtClippy = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.Label()
        Me.btnHide = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.txtConfig = New System.Windows.Forms.LinkLabel()
        Me.txtUpdates = New System.Windows.Forms.LinkLabel()
        Me.txtAbout = New System.Windows.Forms.LinkLabel()
        Me.NTrayMenu.SuspendLayout()
        CType(Me.imgLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NotificationIcon
        '
        Me.NotificationIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.NotificationIcon.BalloonTipText = "Clippy clipboard manager has started..."
        Me.NotificationIcon.BalloonTipTitle = "Clippy"
        Me.NotificationIcon.ContextMenuStrip = Me.NTrayMenu
        Me.NotificationIcon.Icon = CType(resources.GetObject("NotificationIcon.Icon"), System.Drawing.Icon)
        Me.NotificationIcon.Text = "Clippy"
        Me.NotificationIcon.Visible = True
        '
        'NTrayMenu
        '
        Me.NTrayMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShowToolStripMenuItem, Me.SettextToolStripMenuItem, Me.ToolStripSeparator2, Me.ClearClipboardToolStripMenuItem, Me.ToolStripSeparator1, Me.CheckForupdtaesToolStripMenuItem, Me.AboutClippyToolStripMenuItem, Me.ToolStripSeparator3, Me.QuitClippToolStripMenuItem})
        Me.NTrayMenu.Name = "ContextMenuStrip1"
        Me.NTrayMenu.Size = New System.Drawing.Size(171, 154)
        '
        'ShowToolStripMenuItem
        '
        Me.ShowToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShowtextToolStripMenuItem, Me.ShowimageToolStripMenuItem})
        Me.ShowToolStripMenuItem.Name = "ShowToolStripMenuItem"
        Me.ShowToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.ShowToolStripMenuItem.Text = "&Get content"
        '
        'ShowtextToolStripMenuItem
        '
        Me.ShowtextToolStripMenuItem.Name = "ShowtextToolStripMenuItem"
        Me.ShowtextToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.ShowtextToolStripMenuItem.Text = "Show &text"
        '
        'ShowimageToolStripMenuItem
        '
        Me.ShowimageToolStripMenuItem.Name = "ShowimageToolStripMenuItem"
        Me.ShowimageToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.ShowimageToolStripMenuItem.Text = "Show &image"
        '
        'SettextToolStripMenuItem
        '
        Me.SettextToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SettextToolStripMenuItem1, Me.SetimageToolStripMenuItem})
        Me.SettextToolStripMenuItem.Name = "SettextToolStripMenuItem"
        Me.SettextToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.SettextToolStripMenuItem.Text = "S&et content"
        '
        'SettextToolStripMenuItem1
        '
        Me.SettextToolStripMenuItem1.Name = "SettextToolStripMenuItem1"
        Me.SettextToolStripMenuItem1.Size = New System.Drawing.Size(126, 22)
        Me.SettextToolStripMenuItem1.Text = "Set &text"
        '
        'SetimageToolStripMenuItem
        '
        Me.SetimageToolStripMenuItem.Name = "SetimageToolStripMenuItem"
        Me.SetimageToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.SetimageToolStripMenuItem.Text = "Set &image"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(167, 6)
        '
        'ClearClipboardToolStripMenuItem
        '
        Me.ClearClipboardToolStripMenuItem.Name = "ClearClipboardToolStripMenuItem"
        Me.ClearClipboardToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.ClearClipboardToolStripMenuItem.Text = "&Clear clipboard"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(167, 6)
        '
        'CheckForupdtaesToolStripMenuItem
        '
        Me.CheckForupdtaesToolStripMenuItem.Name = "CheckForupdtaesToolStripMenuItem"
        Me.CheckForupdtaesToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.CheckForupdtaesToolStripMenuItem.Text = "Check for &updates"
        '
        'AboutClippyToolStripMenuItem
        '
        Me.AboutClippyToolStripMenuItem.Name = "AboutClippyToolStripMenuItem"
        Me.AboutClippyToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.AboutClippyToolStripMenuItem.Text = "&About Clippy"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(167, 6)
        '
        'QuitClippToolStripMenuItem
        '
        Me.QuitClippToolStripMenuItem.Name = "QuitClippToolStripMenuItem"
        Me.QuitClippToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.QuitClippToolStripMenuItem.Text = "&Quit Clippy"
        '
        'imgLogo
        '
        Me.imgLogo.Image = CType(resources.GetObject("imgLogo.Image"), System.Drawing.Image)
        Me.imgLogo.Location = New System.Drawing.Point(12, 12)
        Me.imgLogo.Name = "imgLogo"
        Me.imgLogo.Size = New System.Drawing.Size(357, 144)
        Me.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.imgLogo.TabIndex = 1
        Me.imgLogo.TabStop = False
        '
        'txtClippy
        '
        Me.txtClippy.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClippy.Location = New System.Drawing.Point(12, 159)
        Me.txtClippy.Name = "txtClippy"
        Me.txtClippy.Size = New System.Drawing.Size(357, 33)
        Me.txtClippy.TabIndex = 2
        Me.txtClippy.Text = "Clippy"
        Me.txtClippy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtDescription
        '
        Me.txtDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.Location = New System.Drawing.Point(12, 192)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(357, 20)
        Me.txtDescription.TabIndex = 5
        Me.txtDescription.Text = "An awesome clipboard manager"
        Me.txtDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnHide
        '
        Me.btnHide.Location = New System.Drawing.Point(12, 284)
        Me.btnHide.Name = "btnHide"
        Me.btnHide.Size = New System.Drawing.Size(108, 33)
        Me.btnHide.TabIndex = 0
        Me.btnHide.Text = "&Hide"
        Me.btnHide.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(261, 284)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(108, 33)
        Me.btnQuit.TabIndex = 4
        Me.btnQuit.Text = "&Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'txtConfig
        '
        Me.txtConfig.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConfig.Location = New System.Drawing.Point(128, 222)
        Me.txtConfig.Name = "txtConfig"
        Me.txtConfig.Size = New System.Drawing.Size(124, 20)
        Me.txtConfig.TabIndex = 1
        Me.txtConfig.TabStop = True
        Me.txtConfig.Text = "Configure Clippy"
        Me.txtConfig.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtUpdates
        '
        Me.txtUpdates.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUpdates.Location = New System.Drawing.Point(128, 242)
        Me.txtUpdates.Name = "txtUpdates"
        Me.txtUpdates.Size = New System.Drawing.Size(124, 20)
        Me.txtUpdates.TabIndex = 2
        Me.txtUpdates.TabStop = True
        Me.txtUpdates.Text = "Updates"
        Me.txtUpdates.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtAbout
        '
        Me.txtAbout.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAbout.Location = New System.Drawing.Point(128, 262)
        Me.txtAbout.Name = "txtAbout"
        Me.txtAbout.Size = New System.Drawing.Size(124, 20)
        Me.txtAbout.TabIndex = 3
        Me.txtAbout.TabStop = True
        Me.txtAbout.Text = "About"
        Me.txtAbout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Clippy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(381, 329)
        Me.Controls.Add(Me.txtAbout)
        Me.Controls.Add(Me.txtUpdates)
        Me.Controls.Add(Me.txtConfig)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnHide)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.txtClippy)
        Me.Controls.Add(Me.imgLogo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Clippy"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clippy"
        Me.NTrayMenu.ResumeLayout(False)
        CType(Me.imgLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents NotificationIcon As System.Windows.Forms.NotifyIcon
    Friend WithEvents NTrayMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents QuitClippToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ClearClipboardToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SettextToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShowtextToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShowimageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SettextToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SetimageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CheckForupdtaesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutClippyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents imgLogo As System.Windows.Forms.PictureBox
    Friend WithEvents txtClippy As System.Windows.Forms.Label
    Friend WithEvents txtDescription As System.Windows.Forms.Label
    Friend WithEvents btnHide As System.Windows.Forms.Button
    Friend WithEvents btnQuit As System.Windows.Forms.Button
    Friend WithEvents txtConfig As System.Windows.Forms.LinkLabel
    Friend WithEvents txtUpdates As System.Windows.Forms.LinkLabel
    Friend WithEvents txtAbout As System.Windows.Forms.LinkLabel

End Class
