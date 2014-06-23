<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.NotifyIcon1.BalloonTipText = "Clippy clipboard manager has started..."
        Me.NotifyIcon1.BalloonTipTitle = "Clippy"
        Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "Clippy"
        Me.NotifyIcon1.Visible = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShowToolStripMenuItem, Me.SettextToolStripMenuItem, Me.ToolStripSeparator2, Me.ClearClipboardToolStripMenuItem, Me.ToolStripSeparator1, Me.CheckForupdtaesToolStripMenuItem, Me.AboutClippyToolStripMenuItem, Me.ToolStripSeparator3, Me.QuitClippToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(171, 154)
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
        Me.ShowtextToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ShowtextToolStripMenuItem.Text = "Show &text"
        '
        'ShowimageToolStripMenuItem
        '
        Me.ShowimageToolStripMenuItem.Name = "ShowimageToolStripMenuItem"
        Me.ShowimageToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
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
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(357, 144)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(141, 159)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 33)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Clippy"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(86, 192)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(214, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Awesome clipboard manager"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 284)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(108, 33)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "&Hide"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(261, 284)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(108, 33)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "&Quit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(128, 238)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(124, 20)
        Me.LinkLabel1.TabIndex = 6
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Configure Clippy"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(381, 329)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clippy"
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
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
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel

End Class
