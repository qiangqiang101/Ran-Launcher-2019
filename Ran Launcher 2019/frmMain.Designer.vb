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
        Me.html = New System.Windows.Forms.WebBrowser()
        Me.SuspendLayout()
        '
        'html
        '
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
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1344, 729)
        Me.Controls.Add(Me.html)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MinimumSize = New System.Drawing.Size(1024, 768)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "勇Online"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents html As WebBrowser
End Class
