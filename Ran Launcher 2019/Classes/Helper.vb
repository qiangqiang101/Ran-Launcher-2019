Imports System.IO

Module Helper

    Public Declare Function GetAsyncKeyState Lib "user32" (ByVal vKey As Integer) As Integer
    Public Declare Function SetParent Lib "user32.dll" (ByVal hWndChild As IntPtr, ByVal hWndNewParent As IntPtr) As Integer
    Public Declare Function SendMessage Lib "user32.dll" (ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    Public Declare Function EnableWindow Lib "user32.dll" (ByVal hWnd As IntPtr, ByVal bEnable As Boolean) As Boolean

    Public Sub processStart(ByVal filename As String, ByVal arg As String, form As Form)
        Try
            Dim proc As Process
            Dim psi = New ProcessStartInfo With {.FileName = filename, .Arguments = arg, .WorkingDirectory = Application.StartupPath, .UseShellExecute = True, .CreateNoWindow = False, .WindowStyle = ProcessWindowStyle.Normal}
            proc = Process.Start(psi)
        Catch ex As Exception
            Logger.Log(ex.Message, ex.StackTrace)
        End Try
    End Sub

    Public Sub Wait(ByVal interval As Integer)
        Dim stopW As New Stopwatch
        stopW.Start()
        Do While stopW.ElapsedMilliseconds < interval
            ' Allows your UI to remain responsive
            If Application.OpenForms.Count = 0 Then End
            Application.DoEvents()
        Loop
        stopW.Stop()
    End Sub

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

    Public Function GetFileSize(bite As ULong) As String
        Dim DoubleBytes As Double

        Try
            Select Case bite
                Case Is >= 1099511627776
                    DoubleBytes = CDbl(bite / 1099511627776) 'TB
                    Return FormatNumber(DoubleBytes, 2) & " TB"
                Case 1073741824 To 1099511627775
                    DoubleBytes = CDbl(bite / 1073741824) 'GB
                    Return FormatNumber(DoubleBytes, 2) & " GB"
                Case 1048576 To 1073741823
                    DoubleBytes = CDbl(bite / 1048576) 'MB
                    Return FormatNumber(DoubleBytes, 2) & " MB"
                Case 1024 To 1048575
                    DoubleBytes = CDbl(bite / 1024) 'KB
                    Return FormatNumber(DoubleBytes, 2) & " KB"
                Case 0 To 1023
                    DoubleBytes = bite ' bytes
                    Return FormatNumber(DoubleBytes, 2) & " bytes"
                Case Else
                    Return ""
            End Select
        Catch
            Return ""
        End Try
    End Function

    Public Function GetDownloadSpeed(bite As ULong) As String
        Dim DoubleBytes As Double

        Try
            Select Case bite
                Case Is >= 1099511627776
                    DoubleBytes = CDbl(bite / 1099511627776) 'TB
                    Return FormatNumber(DoubleBytes, 2) & " TB/s"
                Case 1073741824 To 1099511627775
                    DoubleBytes = CDbl(bite / 1073741824) 'GB
                    Return FormatNumber(DoubleBytes, 2) & " GB/s"
                Case 1048576 To 1073741823
                    DoubleBytes = CDbl(bite / 1048576) 'MB
                    Return FormatNumber(DoubleBytes, 2) & " MB/s"
                Case 1024 To 1048575
                    DoubleBytes = CDbl(bite / 1024) 'KB
                    Return FormatNumber(DoubleBytes, 2) & " KB/s"
                Case 0 To 1023
                    DoubleBytes = bite ' bytes
                    Return FormatNumber(DoubleBytes, 2) & " bytes/s"
                Case Else
                    Return ""
            End Select
        Catch
            Return ""
        End Try
    End Function

    Public Function GetPercentage(count As Integer, total As Integer) As String
        Return $"{Math.Floor((count / total) * 100)}%"
    End Function

End Module
