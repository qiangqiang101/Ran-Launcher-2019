Imports System.ComponentModel
Imports System.IO
Imports System.Net
Imports System.Threading
Imports Ionic.Zip

Public Class frmUpdate

    Private WithEvents wc As New WebClient()
    Private cl As Client
    Private clFile As String = $"{Application.StartupPath}\Cver.xml"

    Private Sub frmUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False

        html.RunPage(UpdHtml)

        cl = New Client(clFile).Instance
        Dim cfu As Integer = CheckForUpdate()

        If cl.CurrentVersion < cfu Then
            DownloadUpdate()
            pbOverall.Maximum = cfu
        Else
            lblStatus.Text = "暫無更新。"
            processStart2($"{Application.StartupPath}\{Htmls.conf.GameExe}", Htmls.conf.Argument)
            frmMain.Close()
        End If
    End Sub

    Private Sub DownloadUpdate()
        Dim patchAddress As String = $"{Htmls.conf.PatchAddress}patch{cl.CurrentVersion + 1}.zip"
        Dim patchFile As String = $"{Application.StartupPath}\patch.zip"
        wc.DownloadFileAsync(New Uri(patchAddress), patchFile)
    End Sub

    Private Function CheckForUpdate() As Integer
        Dim client As WebClient = New WebClient()

        Dim reader As StreamReader = New StreamReader(client.OpenRead(Htmls.conf.ServerVersion))
        Return CInt(reader.ReadToEnd)
    End Function

#Region "WebClient"

    Private Sub wc_DownloadFileCompleted(sender As Object, e As AsyncCompletedEventArgs) Handles wc.DownloadFileCompleted
        If e.Cancelled Then
            lblStatus.Text = "更新被終止。"
        ElseIf Not e.Error Is Nothing Then
            lblStatus.Text = "出現錯誤。"
        Else
            lblStatus.Text = "下載完成，正在為您解壓資源包（過程不消耗流量）"
            pbCurrent.Value = pbCurrent.Minimum
            bgworker.RunWorkerAsync()
        End If
    End Sub

    Private Sub wc_DownloadProgressChanged(sender As Object, e As DownloadProgressChangedEventArgs) Handles wc.DownloadProgressChanged
        pbCurrent.Value = e.ProgressPercentage
        lblStatus.Text = $"剩餘總下載量：{Math.Round(e.TotalBytesToReceive / 1024 - e.BytesReceived / 1024)} KB ({pbCurrent.Value}%)"
    End Sub

#End Region

    Private Sub BgWorker_DoWork(sender As Object, e As DoWorkEventArgs) Handles bgworker.DoWork
        Dim zipToUnpack As String = $"{Application.StartupPath}\patch.zip"
        Dim extractDir As String = Application.StartupPath

        Try
            Using zip As ZipFile = ZipFile.Read(zipToUnpack)
                pbCurrent.Maximum = zip.Entries.Count
                For Each entry As ZipEntry In zip
                    entry.Extract(extractDir, ExtractExistingFileAction.OverwriteSilently)
                    lblStatus.Text = $"正在為您解壓資源包（過程不消耗流量）（{pbCurrent.Value}/{pbCurrent.Maximum}）"
                    pbCurrent.Value += 1
                    Thread.Sleep(50)
                Next
            End Using
        Catch ex As Exception
            MsgBox($"{ex.Message}{ex.StackTrace}", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub BgWorker_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bgworker.RunWorkerCompleted
        If e.Cancelled Then
            lblStatus.Text = "更新被終止。"
        ElseIf Not e.Error Is Nothing Then
            lblStatus.Text = "出現錯誤。"
        Else
            lblStatus.Text = "解壓完畢。"
            pbCurrent.Value = pbCurrent.Minimum
            pbCurrent.Maximum = 100
            pbOverall.Value += 1
            cl.CurrentVersion = cl.CurrentVersion + 1
            cl.FileName = clFile
            cl.Save()
            If File.Exists($"{Application.StartupPath}\patch.zip") Then File.Delete($"{Application.StartupPath}\patch.zip")

            If cl.CurrentVersion < CheckForUpdate() Then
                lblStatus.Text = "正在查詢更新..."
                DownloadUpdate()
            Else
                lblStatus.Text = "暫無更新"
                processStart2($"{Application.StartupPath}\{Htmls.conf.GameExe}", Htmls.conf.Argument)
                frmMain.Close()
            End If
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Close()
    End Sub

End Class