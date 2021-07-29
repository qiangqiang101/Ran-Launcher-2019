<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPatchMaker
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPatchInputDir = New System.Windows.Forms.TextBox()
        Me.btnBrowsePID = New System.Windows.Forms.Button()
        Me.btnBrowsePOD = New System.Windows.Forms.Button()
        Me.txtPatchOutputDir = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pbSingleTask = New System.Windows.Forms.ProgressBar()
        Me.pbTotalTask = New System.Windows.Forms.ProgressBar()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.btnStartTask = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Patch Input Directory"
        '
        'txtPatchInputDir
        '
        Me.txtPatchInputDir.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPatchInputDir.Location = New System.Drawing.Point(147, 12)
        Me.txtPatchInputDir.Name = "txtPatchInputDir"
        Me.txtPatchInputDir.Size = New System.Drawing.Size(426, 23)
        Me.txtPatchInputDir.TabIndex = 1
        '
        'btnBrowsePID
        '
        Me.btnBrowsePID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBrowsePID.Location = New System.Drawing.Point(579, 12)
        Me.btnBrowsePID.Name = "btnBrowsePID"
        Me.btnBrowsePID.Size = New System.Drawing.Size(33, 23)
        Me.btnBrowsePID.TabIndex = 2
        Me.btnBrowsePID.Text = "..."
        Me.btnBrowsePID.UseVisualStyleBackColor = True
        '
        'btnBrowsePOD
        '
        Me.btnBrowsePOD.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBrowsePOD.Location = New System.Drawing.Point(579, 41)
        Me.btnBrowsePOD.Name = "btnBrowsePOD"
        Me.btnBrowsePOD.Size = New System.Drawing.Size(33, 23)
        Me.btnBrowsePOD.TabIndex = 4
        Me.btnBrowsePOD.Text = "..."
        Me.btnBrowsePOD.UseVisualStyleBackColor = True
        '
        'txtPatchOutputDir
        '
        Me.txtPatchOutputDir.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPatchOutputDir.Location = New System.Drawing.Point(147, 41)
        Me.txtPatchOutputDir.Name = "txtPatchOutputDir"
        Me.txtPatchOutputDir.Size = New System.Drawing.Size(426, 23)
        Me.txtPatchOutputDir.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Patch Output Directory"
        '
        'pbSingleTask
        '
        Me.pbSingleTask.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbSingleTask.Location = New System.Drawing.Point(12, 110)
        Me.pbSingleTask.Name = "pbSingleTask"
        Me.pbSingleTask.Size = New System.Drawing.Size(600, 19)
        Me.pbSingleTask.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.pbSingleTask.TabIndex = 6
        '
        'pbTotalTask
        '
        Me.pbTotalTask.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbTotalTask.Location = New System.Drawing.Point(12, 135)
        Me.pbTotalTask.Name = "pbTotalTask"
        Me.pbTotalTask.Size = New System.Drawing.Size(600, 19)
        Me.pbTotalTask.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.pbTotalTask.TabIndex = 7
        '
        'lblStatus
        '
        Me.lblStatus.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblStatus.Location = New System.Drawing.Point(12, 157)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(600, 35)
        Me.lblStatus.TabIndex = 8
        Me.lblStatus.Text = "Idle."
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnStartTask
        '
        Me.btnStartTask.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnStartTask.Location = New System.Drawing.Point(12, 79)
        Me.btnStartTask.Name = "btnStartTask"
        Me.btnStartTask.Size = New System.Drawing.Size(80, 25)
        Me.btnStartTask.TabIndex = 5
        Me.btnStartTask.Text = "Start Zip"
        Me.btnStartTask.UseVisualStyleBackColor = True
        '
        'btnStop
        '
        Me.btnStop.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnStop.Location = New System.Drawing.Point(532, 79)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(80, 25)
        Me.btnStop.TabIndex = 6
        Me.btnStop.Text = "Stop"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'frmPatchMaker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 201)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnStartTask)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.pbTotalTask)
        Me.Controls.Add(Me.pbSingleTask)
        Me.Controls.Add(Me.btnBrowsePOD)
        Me.Controls.Add(Me.txtPatchOutputDir)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnBrowsePID)
        Me.Controls.Add(Me.txtPatchInputDir)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Name = "frmPatchMaker"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Patch Maker"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtPatchInputDir As TextBox
    Friend WithEvents btnBrowsePID As Button
    Friend WithEvents btnBrowsePOD As Button
    Friend WithEvents txtPatchOutputDir As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents pbSingleTask As ProgressBar
    Friend WithEvents pbTotalTask As ProgressBar
    Friend WithEvents lblStatus As Label
    Friend WithEvents btnStartTask As Button
    Friend WithEvents btnStop As Button
End Class
