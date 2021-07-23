Imports System.IO
Imports System.Xml.Serialization

Public Structure Lang

    Public ReadOnly Property Instance As Lang
        Get
            Return ReadFromFile()
        End Get
    End Property

    <XmlIgnore>
    Public Property FileName() As String

    Public ServerName As String
    Public Copyright As String
    Public ExitMsg As String
    Public NewsTitle As String
    Public HelpTitle As String
    Public WebsiteTitle As String
    Public RegisterTitle As String
    Public NoNewUpdate As String
    Public UpdateCancel As String
    Public UpdateError As String
    Public DownloadComplete As String
    Public DownloadRemaining As String
    Public OfFileSize As String
    Public File As String
    Public Unpacking As String
    Public OfFile As String
    Public UnpackComplete As String
    Public CheckingForUpdate As String
    Public UpdateTitle As String

    Public Sub New(fn As String)
        FileName = fn
    End Sub

    Public Sub Save()
        Dim ser = New XmlSerializer(GetType(Lang))
        Dim writer As TextWriter = New StreamWriter(FileName)
        ser.Serialize(writer, Me)
        writer.Close()
    End Sub

    Public Function ReadFromFile() As Lang
        If Not IO.File.Exists(FileName) Then
            Return New Lang(FileName) With {.ServerName = "ServerName", .Copyright = "Copyright", .ExitMsg = "ExitMsg", .NewsTitle = "NewsTitle", .HelpTitle = "HelpTitle", .WebsiteTitle = "WebsiteTitle", .RegisterTitle = "RegisterTitle", .NoNewUpdate = "NoNewUpdate",
                .UpdateCancel = "UpdateCancel", .UpdateError = "UpdateError", .DownloadComplete = "DownloadComplete", .DownloadRemaining = "DownloadRemaining", .Unpacking = "Unpacking", .UnpackComplete = "UnpackComplete", .CheckingForUpdate = "CheckingForUpdate",
                .UpdateTitle = "UpdateTitle", .OfFileSize = "OfFileSize", .OfFile = "OfFile", .File = "File"}
        End If

        Try
            Dim ser = New XmlSerializer(GetType(Lang))
            Dim reader As TextReader = New StreamReader(FileName)
            Dim instance = CType(ser.Deserialize(reader), Lang)
            reader.Close()
            Return instance
        Catch ex As Exception
            Logger.Log(ex.Message, ex.StackTrace)
            Return New Lang(FileName) With {.ServerName = "ServerName", .Copyright = "Copyright", .ExitMsg = "ExitMsg", .NewsTitle = "NewsTitle", .HelpTitle = "HelpTitle", .WebsiteTitle = "WebsiteTitle", .RegisterTitle = "RegisterTitle", .NoNewUpdate = "NoNewUpdate",
                .UpdateCancel = "UpdateCancel", .UpdateError = "UpdateError", .DownloadComplete = "DownloadComplete", .DownloadRemaining = "DownloadRemaining", .Unpacking = "Unpacking", .UnpackComplete = "UnpackComplete", .CheckingForUpdate = "CheckingForUpdate",
                .UpdateTitle = "UpdateTitle", .OfFileSize = "OfFileSize", .OfFile = "OfFile", .File = "File"}
        End Try
    End Function

End Structure