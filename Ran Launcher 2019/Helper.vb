Module Helper

    Public Declare Unicode Function LoadCursorFromFile Lib "user32.dll" Alias "LoadCursorFromFileW" (ByVal filename As String) As IntPtr
    Public normal_Cur As String = $"{My.Application.Info.DirectoryPath}\Data\Editor\normal.cur"

    Public Sub processStart(ByVal filename As String, ByVal arg As String)
        Try
            Dim proc As Process
            proc = Process.Start(filename, arg)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

End Module
