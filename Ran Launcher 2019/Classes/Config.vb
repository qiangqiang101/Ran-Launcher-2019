Imports System.IO
Imports System.Xml.Serialization

Public Structure Conf

    Public ReadOnly Property Instance As Conf
        Get
            Return ReadFromFile()
        End Get
    End Property

    <XmlIgnore>
    Public Property FileName() As String

    Public ServerName As String
    Public Copyright As String
    Public NewsLink As String
    Public WebsiteLink As String
    Public RegisterLink As String
    Public GameExe As String
    Public Argument As String
    Public PatchAddress As String
    Public ServerVersion As String
    Public UseRemoteHtml As Boolean
    Public RemoteHtml As String
    Public UseRemoteIntroHtml As Boolean
    Public RemoteIntroHtml As String
    Public IntroWaitDuration As Integer
    Public FullScreen As Boolean

    Public Sub New(fn As String)
        FileName = fn
    End Sub

    Public Sub Save()
        Dim ser = New XmlSerializer(GetType(Conf))
        Dim writer As TextWriter = New StreamWriter(FileName)
        ser.Serialize(writer, Me)
        writer.Close()
    End Sub

    Public Function ReadFromFile() As Conf
        If Not File.Exists(FileName) Then
            Return New Conf(FileName)
        End If

        Try
            Dim ser = New XmlSerializer(GetType(Conf))
            Dim reader As TextReader = New StreamReader(FileName)
            Dim instance = CType(ser.Deserialize(reader), Conf)
            reader.Close()
            Return instance
        Catch ex As Exception
            Logger.Log(ex.Message, ex.StackTrace)
            Return New Conf(FileName)
        End Try
    End Function

End Structure
