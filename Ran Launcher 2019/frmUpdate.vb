Imports System.ComponentModel
Imports System.IO
Imports System.IO.Compression
Imports System.Net
Imports System.Threading

'note https://stackoverflow.com/questions/8236150/reading-an-online-xml-file-with-vb-net

Public Class frmUpdate

    Private WithEvents wc As New WebClientPlus()
    Private cl As Client
    Private clFile As String = $"{Application.StartupPath}\Cver.xml"

    Private IsFormBeingDragged As Boolean = False
    Private MouseDownX As Integer
    Private MouseDownY As Integer

    Private Sub frmUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False

        Dim topTitle As String = $"{Application.StartupPath}\data\launcher\images\top_title.png"
        BackgroundImage = ImageFromFile(topTitle, My.Resources.top_title)

        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12
        html.RunPage(UpdHtml)
        Label1.Text = Htmls.lang.UpdateTitle
        lblStatus.Text = Htmls.lang.CheckingForUpdate
        lblStatus2.Text = ""

        cl = New Client(clFile).Instance
        Dim cfu As Integer = CheckForUpdate()

        If cl.CurrentVersion < cfu Then
            DownloadUpdate()
            pbOverall.Maximum = cfu * 2
        Else
            lblStatus2.Text = ""
            lblStatus.Text = Htmls.lang.NoNewUpdate
            Wait(500)
            processStart($"{Application.StartupPath}\{Htmls.conf.GameExe}", Htmls.conf.Argument, frmMain)
            Close()
            frmMain.Close()
        End If
    End Sub

    Private Sub DownloadUpdate()
        Dim patchAddress As String = $"{Htmls.conf.PatchAddress}patch{cl.CurrentVersion + 1}.zip"
        Dim patchFile As String = $"{Application.StartupPath}\patch{cl.CurrentVersion + 1}.zip"
        wc.DownloadFileAsync(New Uri(patchAddress), patchFile, Stopwatch.StartNew)
    End Sub

    Private Function CheckForUpdate() As Integer
        Try
            Application.DoEvents()
            Using nwc As New WebClientPlus(3000)
                Using sr = New StreamReader(nwc.OpenRead(Htmls.conf.ServerVersion))
                    Return CInt(sr.ReadToEnd)
                End Using
            End Using
        Catch ex As Exception
            Logger.Log(ex.Message, ex.StackTrace)
            Return 0
        End Try
    End Function

#Region "WebClient"

    Private Sub wc_DownloadFileCompleted(sender As Object, e As AsyncCompletedEventArgs) Handles wc.DownloadFileCompleted
        If e.Cancelled Then
            lblStatus.Text = Htmls.lang.UpdateCancel
        ElseIf Not e.Error Is Nothing Then
            lblStatus.Text = Htmls.lang.UpdateError
        Else
            lblStatus2.Text = ""
            lblStatus.Text = Htmls.lang.DownloadComplete
            pbCurrent.Value = pbCurrent.Minimum
            pbOverall.Value += 1
            bgworker.RunWorkerAsync()
        End If
    End Sub

    Private Sub wc_DownloadProgressChanged(sender As Object, e As DownloadProgressChangedEventArgs) Handles wc.DownloadProgressChanged
        pbCurrent.Value = e.ProgressPercentage
        Dim ds = (e.BytesReceived / (DirectCast(e.UserState, Stopwatch).ElapsedMilliseconds / 1000.0#))
        lblStatus2.Text = $"{Htmls.lang.DownloadRemaining}""patch{cl.CurrentVersion + 1}"" ({pbCurrent.Value}%)"
        lblStatus.Text = $"{GetFileSize(Math.Round(e.BytesReceived))}{Htmls.lang.OfFileSize}{GetFileSize(Math.Round(e.TotalBytesToReceive))} - {GetDownloadSpeed(ds)}"
    End Sub

#End Region

    Private Sub BgWorker_DoWork(sender As Object, e As DoWorkEventArgs) Handles bgworker.DoWork
        Dim zipToUnpack As String = $"{Application.StartupPath}\patch{cl.CurrentVersion + 1}.zip"
        Dim extractDir As String = Application.StartupPath

        Try
            If Not extractDir.EndsWith(Path.DirectorySeparatorChar.ToString(), StringComparison.Ordinal) Then extractDir &= Path.DirectorySeparatorChar
            Using zip As ZipArchive = ZipFile.OpenRead(zipToUnpack)
                pbCurrent.Maximum = zip.Entries.Count
                Dim di As DirectoryInfo = Directory.CreateDirectory(extractDir)
                Dim destinationDirectoryFullPath As String = di.FullName

                For Each file As ZipArchiveEntry In zip.Entries
                    Dim completeFileName As String = Path.GetFullPath(Path.Combine(destinationDirectoryFullPath, file.FullName))

                    If Not completeFileName.StartsWith(destinationDirectoryFullPath, StringComparison.OrdinalIgnoreCase) Then
                        Logger.Log("Trying to extract file outside of destination directory.", "")
                    End If

                    If file.Name = "" Then
                        Directory.CreateDirectory(Path.GetDirectoryName(completeFileName))
                        Continue For
                    End If

                    file.ExtractToFile(completeFileName, True)

                    lblStatus2.Text = $"{Htmls.lang.Unpacking} ({GetPercentage(pbCurrent.Value, pbCurrent.Maximum)})"
                    lblStatus.Text = $"{pbCurrent.Value}{Htmls.lang.OfFile}{pbCurrent.Maximum}{Htmls.lang.File} {file.FullName}"
                    pbCurrent.Value += 1
                    Thread.Sleep(1)
                Next
            End Using
        Catch ex As Exception
            Logger.Log(ex.Message, ex.StackTrace)
        End Try
    End Sub

    Private Sub BgWorker_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bgworker.RunWorkerCompleted
        If e.Cancelled Then
            lblStatus.Text = Htmls.lang.UpdateCancel
        ElseIf Not e.Error Is Nothing Then
            lblStatus.Text = Htmls.lang.UpdateError
        Else
            lblStatus.Text = Htmls.lang.UnpackComplete
            pbCurrent.Value = pbCurrent.Minimum
            pbCurrent.Maximum = 100
            pbOverall.Value += 1
            cl.CurrentVersion = cl.CurrentVersion + 1
            cl.FileName = clFile
            cl.Save()
            If File.Exists($"{Application.StartupPath}\patch{cl.CurrentVersion}.zip") Then File.Delete($"{Application.StartupPath}\patch{cl.CurrentVersion}.zip")

            If cl.CurrentVersion < CheckForUpdate() Then
                lblStatus2.Text = ""
                lblStatus.Text = Htmls.lang.CheckingForUpdate
                DownloadUpdate()
            Else
                lblStatus2.Text = ""
                lblStatus.Text = Htmls.lang.NoNewUpdate
                Wait(500)
                processStart($"{Application.StartupPath}\{Htmls.conf.GameExe}", Htmls.conf.Argument, frmMain)
                Close()
                frmMain.Close()
            End If
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Close()
    End Sub

    Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
        MyBase.OnMouseDown(e)

        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = True
            MouseDownX = e.X
            MouseDownY = e.Y
        End If
    End Sub

    Protected Overrides Sub OnMouseUp(e As MouseEventArgs)
        MyBase.OnMouseUp(e)

        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = False
        End If
    End Sub

    Protected Overrides Sub OnMouseMove(e As MouseEventArgs)
        MyBase.OnMouseMove(e)

        If IsFormBeingDragged Then
            Dim temp As Point = New Point()

            temp.X = Me.Location.X + (e.X - MouseDownX)
            temp.Y = Me.Location.Y + (e.Y - MouseDownY)
            Me.Location = temp
            temp = Nothing
        End If
    End Sub
End Class