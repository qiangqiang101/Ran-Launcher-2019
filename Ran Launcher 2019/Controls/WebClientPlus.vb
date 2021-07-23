Imports System.Net

Public Class WebClientPlus
    Inherits WebClient

    Private _to As Integer = 5000

    Public Sub New(Optional _timeout As Integer = 5000)
        _to = _timeout
        Headers.Add("user-agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko)")
        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12
    End Sub

    Protected Overrides Function GetWebRequest(address As Uri) As WebRequest
        Dim wr As WebRequest = MyBase.GetWebRequest(address)
        wr.Timeout = _to

        Return wr
    End Function
End Class
