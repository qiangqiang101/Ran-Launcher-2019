<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHelp
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
        Me.lblEnd = New System.Windows.Forms.LinkLabel()
        Me.html = New System.Windows.Forms.WebBrowser()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblEnd
        '
        Me.lblEnd.ActiveLinkColor = System.Drawing.Color.White
        Me.lblEnd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEnd.AutoSize = True
        Me.lblEnd.BackColor = System.Drawing.Color.Transparent
        Me.lblEnd.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.lblEnd.ForeColor = System.Drawing.Color.Silver
        Me.lblEnd.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.lblEnd.LinkColor = System.Drawing.Color.Silver
        Me.lblEnd.Location = New System.Drawing.Point(679, -8)
        Me.lblEnd.Name = "lblEnd"
        Me.lblEnd.Size = New System.Drawing.Size(23, 35)
        Me.lblEnd.TabIndex = 98
        Me.lblEnd.TabStop = True
        Me.lblEnd.Text = "×"
        Me.lblEnd.UseCompatibleTextRendering = True
        Me.lblEnd.VisitedLinkColor = System.Drawing.Color.Silver
        '
        'html
        '
        Me.html.Location = New System.Drawing.Point(5, 25)
        Me.html.MinimumSize = New System.Drawing.Size(20, 20)
        Me.html.Name = "html"
        Me.html.Size = New System.Drawing.Size(690, 400)
        Me.html.TabIndex = 104
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(12, 4)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(32, 15)
        Me.lblTitle.TabIndex = 105
        Me.lblTitle.Text = "Help"
        '
        'frmHelp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = Global.Ran_Launcher_2019.My.Resources.Resources.top_title
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(700, 430)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.html)
        Me.Controls.Add(Me.lblEnd)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmHelp"
        Me.Opacity = 0.8R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmHelp"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblEnd As LinkLabel
    Friend WithEvents html As WebBrowser
    Friend WithEvents lblTitle As Label
End Class
