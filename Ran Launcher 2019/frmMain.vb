Public Class frmMain

    Dim WithEvents doc As HtmlDocument
    Private upd As New frmUpdate

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        html.Url = New Uri($"{Application.StartupPath}\Data\Launcher\background.html")
        Cursor = New Cursor(LoadCursorFromFile(normal_Cur))
    End Sub

    Private Sub html_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles html.DocumentCompleted
        doc = CType(sender, WebBrowser).Document
        Text = html.DocumentTitle
    End Sub

    Private Sub doc_Click(sender As Object, e As HtmlElementEventArgs) Handles doc.Click
        Dim ce = doc.DomDocument.parentWindow.event.srcElement

        Select Case ce.id
            Case "window"
                If FormBorderStyle = BorderStyle.None Then
                    FormBorderStyle = FormBorderStyle.Sizable
                    WindowState = FormWindowState.Normal
                Else
                    FormBorderStyle = FormBorderStyle.None
                    WindowState = FormWindowState.Maximized
                End If
            Case "exitok"
                Close()
            Case "play"
                upd = New frmUpdate
                upd.TopLevel = False
                upd.Parent = html
                html.Controls.Add(upd)
                upd.TopMost = True
                upd.Location = New Point(Width / 2 - upd.Width / 2, Height / 2 - upd.Height / 2)
                upd.Show()
        End Select
    End Sub

    Protected Overrides Sub OnSizeChanged(e As EventArgs)
        MyBase.OnSizeChanged(e)

        upd.Location = New Point(Width / 2 - upd.Width / 2, Height / 2 - upd.Height / 2)
    End Sub
End Class
