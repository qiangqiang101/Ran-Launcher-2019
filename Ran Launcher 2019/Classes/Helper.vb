Imports System.IO

Module Helper

    Public Declare Function GetAsyncKeyState Lib "user32" (ByVal vKey As Integer) As Integer
    Public Declare Function SetParent Lib "user32.dll" (ByVal hWndChild As IntPtr, ByVal hWndNewParent As IntPtr) As Integer
    Public Declare Function SendMessage Lib "user32.dll" (ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer

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

End Module
