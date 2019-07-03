Imports System.IO
Imports System.Xml.Serialization

Public Structure Client

    Public ReadOnly Property Instance As Client
        Get
            Return ReadFromFile()
        End Get
    End Property

    <XmlIgnore>
    Public Property FileName() As String

    Public CurrentVersion As Integer

    Public Sub New(fn As String)
        FileName = fn
    End Sub

    Public Sub Save()
        Dim ser = New XmlSerializer(GetType(Client))
        Dim writer As TextWriter = New StreamWriter(FileName)
        ser.Serialize(writer, Me)
        writer.Close()
    End Sub

    Public Function ReadFromFile() As Client
        If Not File.Exists(FileName) Then
            Return New Client(FileName)
        End If

        Try
            Dim ser = New XmlSerializer(GetType(Client))
            Dim reader As TextReader = New StreamReader(FileName)
            Dim instance = CType(ser.Deserialize(reader), Client)
            reader.Close()
            Return instance
        Catch ex As Exception
            Return New Client(FileName)
        End Try
    End Function

End Structure
