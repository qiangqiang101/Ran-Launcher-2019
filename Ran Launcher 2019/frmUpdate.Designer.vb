<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpdate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUpdate))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.bgworker = New System.ComponentModel.BackgroundWorker()
        Me.html = New System.Windows.Forms.WebBrowser()
        Me.pbOverall = New Ran_Launcher_2019.RanProgressBar()
        Me.pbCurrent = New Ran_Launcher_2019.RanProgressBar()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(7, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "更新"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label2.Font = New System.Drawing.Font("Marlett", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(676, 2)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 14)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "r"
        '
        'lblStatus
        '
        Me.lblStatus.BackColor = System.Drawing.Color.Transparent
        Me.lblStatus.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblStatus.Location = New System.Drawing.Point(12, 257)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(676, 19)
        Me.lblStatus.TabIndex = 4
        Me.lblStatus.Text = "正在查詢更新..."
        '
        'bgworker
        '
        Me.bgworker.WorkerReportsProgress = True
        Me.bgworker.WorkerSupportsCancellation = True
        '
        'html
        '
        Me.html.AllowWebBrowserDrop = False
        Me.html.IsWebBrowserContextMenuEnabled = False
        Me.html.Location = New System.Drawing.Point(12, 23)
        Me.html.MinimumSize = New System.Drawing.Size(23, 23)
        Me.html.Name = "html"
        Me.html.ScriptErrorsSuppressed = True
        Me.html.ScrollBarsEnabled = False
        Me.html.Size = New System.Drawing.Size(676, 199)
        Me.html.TabIndex = 5
        Me.html.Url = New System.Uri("", System.UriKind.Relative)
        Me.html.WebBrowserShortcutsEnabled = False
        '
        'pbOverall
        '
        Me.pbOverall.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.pbOverall.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.pbOverall.ForegroundColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.pbOverall.Location = New System.Drawing.Point(12, 244)
        Me.pbOverall.MarqueeAnimationSpeed = 5.0!
        Me.pbOverall.Maximum = 100
        Me.pbOverall.Minimum = 0
        Me.pbOverall.Name = "pbOverall"
        Me.pbOverall.Size = New System.Drawing.Size(676, 10)
        Me.pbOverall.Style = Ran_Launcher_2019.RanProgressBar.PBStyle.Continuous
        Me.pbOverall.TabIndex = 3
        Me.pbOverall.Text = "RanProgressBar2"
        Me.pbOverall.Value = 0
        '
        'pbCurrent
        '
        Me.pbCurrent.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.pbCurrent.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.pbCurrent.ForegroundColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.pbCurrent.Location = New System.Drawing.Point(12, 228)
        Me.pbCurrent.MarqueeAnimationSpeed = 5.0!
        Me.pbCurrent.Maximum = 100
        Me.pbCurrent.Minimum = 0
        Me.pbCurrent.Name = "pbCurrent"
        Me.pbCurrent.Size = New System.Drawing.Size(676, 10)
        Me.pbCurrent.Style = Ran_Launcher_2019.RanProgressBar.PBStyle.Continuous
        Me.pbCurrent.TabIndex = 2
        Me.pbCurrent.Text = "RanProgressBar1"
        Me.pbCurrent.Value = 0
        '
        'frmUpdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = Global.Ran_Launcher_2019.My.Resources.Resources.top_title
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(700, 288)
        Me.Controls.Add(Me.html)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.pbOverall)
        Me.Controls.Add(Me.pbCurrent)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmUpdate"
        Me.Opacity = 0.8R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmUpdate"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents pbCurrent As RanProgressBar
    Friend WithEvents pbOverall As RanProgressBar
    Friend WithEvents lblStatus As Label
    Friend WithEvents bgworker As System.ComponentModel.BackgroundWorker
    Friend WithEvents html As WebBrowser
End Class
