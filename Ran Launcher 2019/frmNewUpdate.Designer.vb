<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmNewUpdate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNewUpdate))
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblClose = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.bgworker = New System.ComponentModel.BackgroundWorker()
        Me.lblStatus2 = New System.Windows.Forms.Label()
        Me.html = New System.Windows.Forms.WebBrowser()
        Me.pbOverall = New Ran_Launcher_2019.RanProgressBar()
        Me.pbCurrent = New Ran_Launcher_2019.RanProgressBar()
        Me.SuspendLayout()
        '
        'lblStatus
        '
        Me.lblStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblStatus.BackColor = System.Drawing.Color.Transparent
        Me.lblStatus.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblStatus.Location = New System.Drawing.Point(59, 274)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(583, 19)
        Me.lblStatus.TabIndex = 11
        Me.lblStatus.Text = "正在查詢更新..."
        '
        'lblClose
        '
        Me.lblClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblClose.AutoSize = True
        Me.lblClose.BackColor = System.Drawing.Color.Transparent
        Me.lblClose.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblClose.Font = New System.Drawing.Font("Marlett", 10.0!)
        Me.lblClose.Location = New System.Drawing.Point(676, 2)
        Me.lblClose.Name = "lblClose"
        Me.lblClose.Size = New System.Drawing.Size(21, 14)
        Me.lblClose.TabIndex = 8
        Me.lblClose.Text = "r"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblTitle.Location = New System.Drawing.Point(7, 1)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(37, 19)
        Me.lblTitle.TabIndex = 7
        Me.lblTitle.Text = "更新"
        '
        'bgworker
        '
        Me.bgworker.WorkerReportsProgress = True
        Me.bgworker.WorkerSupportsCancellation = True
        '
        'lblStatus2
        '
        Me.lblStatus2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblStatus2.BackColor = System.Drawing.Color.Transparent
        Me.lblStatus2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblStatus2.Location = New System.Drawing.Point(59, 223)
        Me.lblStatus2.Name = "lblStatus2"
        Me.lblStatus2.Size = New System.Drawing.Size(583, 19)
        Me.lblStatus2.TabIndex = 13
        Me.lblStatus2.Text = "正在下載"""""
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
        Me.html.Size = New System.Drawing.Size(676, 196)
        Me.html.TabIndex = 12
        Me.html.Url = New System.Uri("", System.UriKind.Relative)
        Me.html.WebBrowserShortcutsEnabled = False
        '
        'pbOverall
        '
        Me.pbOverall.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pbOverall.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.pbOverall.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.pbOverall.ForegroundColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.pbOverall.Location = New System.Drawing.Point(59, 261)
        Me.pbOverall.MarqueeAnimationSpeed = 5.0!
        Me.pbOverall.Maximum = 100
        Me.pbOverall.Minimum = 0
        Me.pbOverall.Name = "pbOverall"
        Me.pbOverall.Size = New System.Drawing.Size(583, 10)
        Me.pbOverall.Style = Ran_Launcher_2019.RanProgressBar.PBStyle.Continuous
        Me.pbOverall.TabIndex = 10
        Me.pbOverall.Text = "RanProgressBar2"
        Me.pbOverall.Value = 0
        '
        'pbCurrent
        '
        Me.pbCurrent.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pbCurrent.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.pbCurrent.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.pbCurrent.ForegroundColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.pbCurrent.Location = New System.Drawing.Point(59, 245)
        Me.pbCurrent.MarqueeAnimationSpeed = 5.0!
        Me.pbCurrent.Maximum = 100
        Me.pbCurrent.Minimum = 0
        Me.pbCurrent.Name = "pbCurrent"
        Me.pbCurrent.Size = New System.Drawing.Size(583, 10)
        Me.pbCurrent.Style = Ran_Launcher_2019.RanProgressBar.PBStyle.Continuous
        Me.pbCurrent.TabIndex = 9
        Me.pbCurrent.Text = "RanProgressBar1"
        Me.pbCurrent.Value = 0
        '
        'frmNewUpdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(700, 302)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.lblClose)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblStatus2)
        Me.Controls.Add(Me.html)
        Me.Controls.Add(Me.pbOverall)
        Me.Controls.Add(Me.pbCurrent)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmNewUpdate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Update 2.0"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblStatus As Label
    Friend WithEvents lblClose As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents bgworker As System.ComponentModel.BackgroundWorker
    Friend WithEvents lblStatus2 As Label
    Friend WithEvents html As WebBrowser
    Friend WithEvents pbOverall As RanProgressBar
    Friend WithEvents pbCurrent As RanProgressBar
End Class
