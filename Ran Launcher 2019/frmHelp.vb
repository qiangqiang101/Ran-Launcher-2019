Public Class frmHelp
    Private Sub frmHelp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        html.Navigate($"{My.Application.Info.DirectoryPath}\Launcher\Help\help.htm")
    End Sub

    Private Sub lblEnd_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblEnd.LinkClicked
        Close()
        frmMain.ShowButtons()
    End Sub
End Class