Module Helper

    Public Sub processStart(ByVal filename As String, ByVal arg As String)
        Try
            Dim proc As Process
            proc = Process.Start(filename, arg)
        Catch ex As Exception
            Logger.Log(ex.Message, ex.StackTrace)
        End Try
    End Sub

    Public Sub processStart2(ByVal filename As String, ByVal arg As String)
        Try
            Dim psi = New ProcessStartInfo With {.FileName = "CMD", .Arguments = String.Format("/C start """" ""{0}"" ""{1}""", filename, arg), .WorkingDirectory = Application.StartupPath, .UseShellExecute = True, .CreateNoWindow = False, .WindowStyle = ProcessWindowStyle.Normal}
            Process.Start(psi)
        Catch ex As Exception
            Logger.Log(ex.Message, ex.StackTrace)
            MsgBox(ex.Message, MsgBoxStyle.Critical, "出錯了")
        End Try
    End Sub

End Module
