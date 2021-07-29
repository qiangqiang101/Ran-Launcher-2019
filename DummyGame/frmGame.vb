Public Class frmGame

    Public IntroHtml As String = "<!DOCTYPE html>
<html>
<head>
<title>RAN Online</title>
<meta http-equiv=""X-UA-Compatible"" content=""IE=" & IE_Version() & """ charset=""utf-8"" />
<style>
body {cursor: url('images\\normal.png'), url('images\\normal.cur'), auto !important;}
a {cursor: url('images\\attack.png'), url('images\\attack.cur'), default !important;}

/* Style the video: 100% width and height to cover the entire window */
#myVideo {
	position: fixed;
    top: 50%;
    left: 50%;
    min-width: 100%;
    min-height: 100%;
    width: auto;
    height: auto;
    z-index: -100;
    transform: translateX(-50%) translateY(-50%);
  background-size: cover;
  transition: 1s opacity;
}
</style>
</head>

<body>
<!-- The video -->
<video id=""myVideo"" onended=""repeatvideo()"" autoplay muted>
    <source src=""" & Application.StartupPath & "\data\launcher\videos\bg.mp4"" type=""video/mp4"">
</video>
</body>

<script>
function repeatvideo() {
	var vidElem = document.getElementById('myVideo');
	vidElem.currentTime = 15;
	vidElem.play();
}
</script>
</html>"

    Public Function IsEdgeInstalled() As Boolean
        Using key = Microsoft.Win32.Registry.ClassesRoot.OpenSubKey("Local Settings\Software\Microsoft\Windows\CurrentVersion\AppModel\PackageRepository\Packages\")
            If key IsNot Nothing Then
                For Each subkey In key.GetSubKeyNames()
                    If subkey.StartsWith("Microsoft.MicrosoftEdge_") Then
                        Return True
                        Exit For
                    End If
                Next
            End If
        End Using
        Return False
    End Function

    Public Function IE_Version() As String
        If IsEdgeInstalled() Then
            Return "edge"
        Else
            Return New WebBrowser().Version.Major
        End If
    End Function

    Public Sub RunPage(browser As WebBrowser, html As String)
        Try
            browser.Navigate(Application.StartupPath)
            Dim hdoc As HtmlDocument = browser.Document
            hdoc.Write(String.Empty)
            browser.DocumentText = html
        Catch ex As Exception
            Log(ex.Message, ex.StackTrace)
        End Try
    End Sub

    Private Sub frmGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RunPage(html2, IntroHtml)
    End Sub

    Public Sub Log(message As Object, stack As Object)
        IO.File.AppendAllText($"{My.Application.Info.DirectoryPath}\Launcher.log", $"{Now}:{message}{stack}{Environment.NewLine}")
    End Sub
End Class
