Public Class frmMain

    Private hlp As New frmHelp

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        html.Url = New Uri($"{My.Application.Info.DirectoryPath}\Launcher\Background\background.html")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Public Sub ShowButtons()
        btnExit.Show()
        btnHelp.Show()
        btnNews.Show()
        btnPlay.Show()
        btnReg.Show()
        btnWeb.Show()
    End Sub

    Public Sub HideButtons()
        btnExit.Hide()
        btnHelp.Hide()
        btnNews.Hide()
        btnPlay.Hide()
        btnReg.Hide()
        btnWeb.Hide()
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        hlp = New frmHelp
        hlp.TopLevel = False
        hlp.Parent = html
        html.Controls.Add(hlp)
        hlp.Show()
        hlp.TopMost = True
        hlp.Location = New Point(Width / 2 - hlp.Width / 2, Height / 2 - hlp.Height / 2)
        HideButtons()
    End Sub

    Protected Overrides Sub OnResizeEnd(e As EventArgs)
        MyBase.OnResizeEnd(e)

        hlp.Location = New Point(Width / 2 - hlp.Width / 2, Height / 2 - hlp.Height / 2)
    End Sub
End Class
