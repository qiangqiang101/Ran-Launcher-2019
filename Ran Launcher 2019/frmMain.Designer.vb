<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.html = New System.Windows.Forms.WebBrowser()
        Me.html2 = New System.Windows.Forms.WebBrowser()
        Me.tKey = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'html
        '
        Me.html.AllowWebBrowserDrop = False
        Me.html.Dock = System.Windows.Forms.DockStyle.Fill
        Me.html.IsWebBrowserContextMenuEnabled = False
        Me.html.Location = New System.Drawing.Point(0, 0)
        Me.html.MinimumSize = New System.Drawing.Size(23, 23)
        Me.html.Name = "html"
        Me.html.ScriptErrorsSuppressed = True
        Me.html.ScrollBarsEnabled = False
        Me.html.Size = New System.Drawing.Size(1344, 729)
        Me.html.TabIndex = 0
        Me.html.Url = New System.Uri("", System.UriKind.Relative)
        Me.html.WebBrowserShortcutsEnabled = False
        '
        'html2
        '
        Me.html2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.html2.IsWebBrowserContextMenuEnabled = False
        Me.html2.Location = New System.Drawing.Point(0, 0)
        Me.html2.MinimumSize = New System.Drawing.Size(23, 23)
        Me.html2.Name = "html2"
        Me.html2.ScriptErrorsSuppressed = True
        Me.html2.ScrollBarsEnabled = False
        Me.html2.Size = New System.Drawing.Size(1344, 729)
        Me.html2.TabIndex = 1
        Me.html2.Url = New System.Uri("", System.UriKind.Relative)
        Me.html2.WebBrowserShortcutsEnabled = False
        '
        'tKey
        '
        Me.tKey.Enabled = True
        Me.tKey.Interval = 30
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1344, 729)
        Me.Controls.Add(Me.html2)
        Me.Controls.Add(Me.html)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(1024, 768)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "勇Online"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents html As WebBrowser
    Friend WithEvents html2 As WebBrowser
    Friend WithEvents tKey As Timer
End Class
