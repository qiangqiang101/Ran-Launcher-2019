Public NotInheritable Class Logger

    Public Shared Sub Log(message As Object, stack As Object)
        IO.File.AppendAllText($"{My.Application.Info.DirectoryPath}\Launcher.log", $"{Now}:{message}{stack}{Environment.NewLine}")
    End Sub
End Class