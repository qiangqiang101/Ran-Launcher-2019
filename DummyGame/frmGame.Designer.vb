<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGame
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGame))
        Me.html2 = New System.Windows.Forms.WebBrowser()
        Me.SuspendLayout()
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
        Me.html2.TabIndex = 2
        Me.html2.Url = New System.Uri("", System.UriKind.Relative)
        Me.html2.WebBrowserShortcutsEnabled = False
        '
        'frmGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1344, 729)
        Me.Controls.Add(Me.html2)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmGame"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Game"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents html2 As WebBrowser
End Class
