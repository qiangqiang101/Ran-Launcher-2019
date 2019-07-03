Public Class frmMain

    Dim WithEvents doc As HtmlDocument

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        html.Url = New Uri($"{My.Application.Info.DirectoryPath}\Data\Launcher\background.html")
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

        End Select
    End Sub
End Class
