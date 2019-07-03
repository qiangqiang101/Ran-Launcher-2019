Module Helper

    Public Declare Unicode Function LoadCursorFromFile Lib "user32.dll" Alias "LoadCursorFromFileW" (ByVal filename As String) As IntPtr
    Public normal_Cur As String = $"{My.Application.Info.DirectoryPath}\Data\Editor\normal.cur"

End Module
