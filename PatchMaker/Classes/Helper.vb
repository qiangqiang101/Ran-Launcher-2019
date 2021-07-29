Imports System.IO
Imports System.Security.Cryptography

Module Helper

    Public Function MD5Checksum(filename As String) As String
        Using md5 As MD5 = MD5.Create()
            Using stream = File.OpenRead(filename)
                Return BitConverter.ToString(md5.ComputeHash(stream)).Replace("-", String.Empty)
            End Using
        End Using
    End Function

    Public Function GetDirectoryNameWithoutDriveLetter(filename As String, root As String) As String
        Dim defaultMethod As String = Path.GetDirectoryName(filename)

    End Function

End Module
