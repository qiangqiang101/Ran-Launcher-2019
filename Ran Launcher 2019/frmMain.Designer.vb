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
        Me.btnHelp = New Ran_Launcher_2019.ImageButton()
        Me.btnNews = New Ran_Launcher_2019.ImageButton()
        Me.btnWeb = New Ran_Launcher_2019.ImageButton()
        Me.btnReg = New Ran_Launcher_2019.ImageButton()
        Me.btnPlay = New Ran_Launcher_2019.ImageButton()
        Me.btnExit = New Ran_Launcher_2019.ImageButton()
        Me.SuspendLayout()
        '
        'html
        '
        Me.html.Dock = System.Windows.Forms.DockStyle.Fill
        Me.html.IsWebBrowserContextMenuEnabled = False
        Me.html.Location = New System.Drawing.Point(0, 0)
        Me.html.MinimumSize = New System.Drawing.Size(23, 23)
        Me.html.Name = "html"
        Me.html.Size = New System.Drawing.Size(1344, 729)
        Me.html.TabIndex = 0
        Me.html.Url = New System.Uri("", System.UriKind.Relative)
        '
        'btnHelp
        '
        Me.btnHelp.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnHelp.BackColor = System.Drawing.Color.Transparent
        Me.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHelp.Location = New System.Drawing.Point(626, 425)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.NormalImage = Global.Ran_Launcher_2019.My.Resources.Resources.Help_btn
        Me.btnHelp.PressedImage = Global.Ran_Launcher_2019.My.Resources.Resources.Help_btn_pressed
        Me.btnHelp.Size = New System.Drawing.Size(102, 20)
        Me.btnHelp.TabIndex = 6
        Me.btnHelp.Text = "ImageButton6"
        Me.btnHelp.UseVisualStyleBackColor = False
        '
        'btnNews
        '
        Me.btnNews.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnNews.BackColor = System.Drawing.Color.Transparent
        Me.btnNews.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNews.Location = New System.Drawing.Point(626, 399)
        Me.btnNews.Name = "btnNews"
        Me.btnNews.NormalImage = Global.Ran_Launcher_2019.My.Resources.Resources.News_btn
        Me.btnNews.PressedImage = Global.Ran_Launcher_2019.My.Resources.Resources.News_btn_pressed
        Me.btnNews.Size = New System.Drawing.Size(102, 20)
        Me.btnNews.TabIndex = 5
        Me.btnNews.Text = "ImageButton5"
        Me.btnNews.UseVisualStyleBackColor = False
        '
        'btnWeb
        '
        Me.btnWeb.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnWeb.BackColor = System.Drawing.Color.Transparent
        Me.btnWeb.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnWeb.Location = New System.Drawing.Point(626, 373)
        Me.btnWeb.Name = "btnWeb"
        Me.btnWeb.NormalImage = Global.Ran_Launcher_2019.My.Resources.Resources.Website_btn
        Me.btnWeb.PressedImage = Global.Ran_Launcher_2019.My.Resources.Resources.Website_btn_pressed
        Me.btnWeb.Size = New System.Drawing.Size(102, 20)
        Me.btnWeb.TabIndex = 4
        Me.btnWeb.Text = "ImageButton4"
        Me.btnWeb.UseVisualStyleBackColor = False
        '
        'btnReg
        '
        Me.btnReg.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnReg.BackColor = System.Drawing.Color.Transparent
        Me.btnReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReg.Location = New System.Drawing.Point(626, 347)
        Me.btnReg.Name = "btnReg"
        Me.btnReg.NormalImage = Global.Ran_Launcher_2019.My.Resources.Resources.Register_btn
        Me.btnReg.PressedImage = Global.Ran_Launcher_2019.My.Resources.Resources.Register_btn_pressed
        Me.btnReg.Size = New System.Drawing.Size(102, 20)
        Me.btnReg.TabIndex = 3
        Me.btnReg.Text = "ImageButton3"
        Me.btnReg.UseVisualStyleBackColor = False
        '
        'btnPlay
        '
        Me.btnPlay.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnPlay.BackColor = System.Drawing.Color.Transparent
        Me.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPlay.Location = New System.Drawing.Point(626, 321)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.NormalImage = Global.Ran_Launcher_2019.My.Resources.Resources.Play_btn
        Me.btnPlay.PressedImage = Global.Ran_Launcher_2019.My.Resources.Resources.Play_btn_pressed
        Me.btnPlay.Size = New System.Drawing.Size(102, 20)
        Me.btnPlay.TabIndex = 2
        Me.btnPlay.Text = "ImageButton2"
        Me.btnPlay.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnExit.BackColor = System.Drawing.Color.Transparent
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Location = New System.Drawing.Point(698, 469)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.NormalImage = Global.Ran_Launcher_2019.My.Resources.Resources.Exit_btn
        Me.btnExit.PressedImage = Global.Ran_Launcher_2019.My.Resources.Resources.Exit_btn_pressed
        Me.btnExit.Size = New System.Drawing.Size(71, 17)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "ImageButton1"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1344, 729)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.btnNews)
        Me.Controls.Add(Me.btnWeb)
        Me.Controls.Add(Me.btnReg)
        Me.Controls.Add(Me.btnPlay)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.html)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MinimumSize = New System.Drawing.Size(1024, 768)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents html As WebBrowser
    Friend WithEvents btnExit As ImageButton
    Friend WithEvents btnPlay As ImageButton
    Friend WithEvents btnReg As ImageButton
    Friend WithEvents btnWeb As ImageButton
    Friend WithEvents btnNews As ImageButton
    Friend WithEvents btnHelp As ImageButton
End Class
