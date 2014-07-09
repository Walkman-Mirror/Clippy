<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GetImage
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
        Me.GetImageFromClipboard = New System.Windows.Forms.Timer(Me.components)
        Me.imgClipboardImage = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.imgClipboardImage, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.TabIndex = 1
        '
        'txtTitle
        '
        Me.txtTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitle.Location = New System.Drawing.Point(12, 11)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(343, 25)
        Me.txtTitle.TabIndex = 1
        Me.txtTitle.Text = "Current clipboard image"
        Me.txtTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GetImageFromClipboard
        '
        '
        'imgClipboardImage
        '
        Me.imgClipboardImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.imgClipboardImage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.imgClipboardImage.Location = New System.Drawing.Point(0, 47)
        Me.imgClipboardImage.Name = "imgClipboardImage"
        Me.imgClipboardImage.Size = New System.Drawing.Size(367, 267)
        Me.imgClipboardImage.TabIndex = 2
        Me.imgClipboardImage.TabStop = False
        '
        'GetImage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(367, 314)
        Me.Controls.Add(Me.imgClipboardImage)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "GetImage"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Current clipboard image"
        Me.Panel1.ResumeLayout(False)
        CType(Me.imgClipboardImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtTitle As System.Windows.Forms.Label
    Friend WithEvents GetImageFromClipboard As System.Windows.Forms.Timer
    Friend WithEvents imgClipboardImage As System.Windows.Forms.PictureBox
End Class
