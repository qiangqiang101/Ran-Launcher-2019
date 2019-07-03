Module Helper

    Public Sub processStart(ByVal filename As String, ByVal arg As String)
        Try
            Dim proc As Process
            proc = Process.Start(filename, arg)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

End Module
