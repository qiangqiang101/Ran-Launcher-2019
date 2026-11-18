Imports System.IO
Imports System.Xml.Serialization

Public Structure PatchList

    Public ReadOnly Property Instance As PatchList
        Get
            Return ReadFromFile()
        End Get
    End Property

    <XmlIgnore>
    Public Property FileName() As String

    Public FileList As List(Of PatchFile)

    Public Sub New(fn As String)
        FileName = fn
    End Sub

    Public Sub Save()
        Dim ser = New XmlSerializer(GetType(PatchList))
        Dim writer As TextWriter = New StreamWriter(FileName)
        ser.Serialize(writer, Me)
        writer.Close()
    End Sub

    Public Function ReadFromFile() As PatchList
        If Not File.Exists(FileName) Then
            Return New PatchList(FileName)
        End If

        Try
            Dim ser = New XmlSerializer(GetType(PatchList))
            Dim reader As TextReader = New StreamReader(FileName)
            Dim instance = CType(ser.Deserialize(reader), PatchList)
            reader.Close()
            Return instance
        Catch ex As Exception
            Logger.Log(ex.Message, ex.StackTrace)
            Return New PatchList(FileName)
        End Try
    End Function

End Structure

Public Structure PatchFile

    Public Sub New(_file As String)
        File = Path.GetFileName(_file)
        Directory = ""
    End Sub

    Public Directory As String
    Public File As String
    Public Md5 As String

End Structure