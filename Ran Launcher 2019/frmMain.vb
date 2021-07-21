Public Class frmMain

    Dim WithEvents doc As HtmlDocument
    Private upd As New frmUpdate

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Text = Htmls.lang.ServerName

        If Htmls.conf.FullScreen Then
            FormBorderStyle = FormBorderStyle.None
            WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub html_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles html.DocumentCompleted
        doc = CType(sender, WebBrowser).Document
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

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If FormBorderStyle = BorderStyle.None Then
            Htmls.conf.FileName = cfFile
            Htmls.conf.FullScreen = True
            Htmls.conf.Save()
        Else
            Htmls.conf.FileName = cfFile
            Htmls.conf.FullScreen = False
            Htmls.conf.Save()
        End If
    End Sub

    Private Sub frmMain_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Select Case Htmls.conf.DisplayMethod
            Case DisplayMethod.BuildIn
                html2.RunPage(IntroHtml)
                Wait(Htmls.conf.IntroWaitDuration)
                If html2.Visible Then
                    html2.Hide()
                    html.RunPage(MainHtml)
                End If
            Case DisplayMethod.Local
                Try
                    html2.Url = New Uri($".\data\launcher\{Htmls.conf.IntroHtmlPath}")
                    Wait(Htmls.conf.IntroWaitDuration * 2)
                    If html2.Visible Then
                        html2.Hide()
                        html.Url = New Uri($".\data\launcher\{Htmls.conf.HtmlPath}")
                    End If
                Catch ex As Exception
                    Logger.Log(ex.Message, ex.StackTrace)
                    ErrorFix(1)
                End Try
            Case DisplayMethod.Remote
                Try
                    html2.Url = New Uri($"{Htmls.conf.IntroHtmlPath}")
                    Wait(Htmls.conf.IntroWaitDuration * 2)
                    If html2.Visible Then
                        html2.Hide()
                        html.Url = New Uri($"{Htmls.conf.HtmlPath}")
                    End If
                Catch ex As Exception
                    Logger.Log(ex.Message, ex.StackTrace)
                    ErrorFix(1)
                End Try
        End Select
    End Sub

    Private Sub tKey_Tick(sender As Object, e As EventArgs) Handles tKey.Tick
        If (GetAsyncKeyState(Keys.Escape) OrElse GetAsyncKeyState(Keys.Enter) OrElse GetAsyncKeyState(Keys.Space)) AndAlso html2.Visible Then
            html2.Hide()
            Select Case Htmls.conf.DisplayMethod
                Case DisplayMethod.BuildIn
                    html.RunPage(MainHtml)
                Case DisplayMethod.Local
                    Try
                        html.Url = New Uri($".\data\launcher\{Htmls.conf.HtmlPath}")
                    Catch ex As Exception
                        Logger.Log(ex.Message, ex.StackTrace)
                        ErrorFix(2)
                    End Try
                Case DisplayMethod.Remote
                    Try
                        html.Url = New Uri($"{Htmls.conf.HtmlPath}")
                    Catch ex As Exception
                        Logger.Log(ex.Message, ex.StackTrace)
                        ErrorFix(2)
                    End Try
            End Select
        End If
    End Sub

    Private Sub ErrorFix(data As Integer)
        If data = 1 Then
            html2.RunPage(IntroHtml)
            Wait(Htmls.conf.IntroWaitDuration)
            If html2.Visible Then
                html2.Hide()
                html.RunPage(MainHtml)
            End If
        Else
            html.RunPage(MainHtml)
        End If
    End Sub

End Class
