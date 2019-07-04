Public NotInheritable Class Logger

    Public Shared Sub Log(message As Object, stack As Object)
        IO.File.AppendAllText(".\Launcher.log", $"{DateTime.Now}:{message}{stack}{Environment.NewLine}")
    End Sub
End Class