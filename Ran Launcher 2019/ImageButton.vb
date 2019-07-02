Public Class ImageButton
    Inherits Button

    Public Sub New()
        FlatStyle = FlatStyle.Flat
    End Sub

    Private _normImg As Image = New Bitmap(1, 1)
    Public Property NormalImage() As Image
        Get
            Return _normImg
        End Get
        Set(value As Image)
            _normImg = value
        End Set
    End Property

    Private _presImg As Image = New Bitmap(1, 1)
    Public Property PressedImage() As Image
        Get
            Return _presImg
        End Get
        Set(value As Image)
            _presImg = value
        End Set
    End Property

    Protected Overrides Sub OnPaint(pevent As PaintEventArgs)
        MyBase.OnPaint(pevent)

        Dim g As Graphics = pevent.Graphics

        If _md Then
            g.DrawImage(_presImg, ClientRectangle)
        Else
            g.DrawImage(_normImg, ClientRectangle)
        End If
    End Sub

    Private _md As Boolean = False
    Protected Overrides Sub OnMouseDown(mevent As MouseEventArgs)
        MyBase.OnMouseDown(mevent)

        _md = True
        Invalidate()
    End Sub

    Protected Overrides Sub OnMouseUp(mevent As MouseEventArgs)
        MyBase.OnMouseUp(mevent)

        _md = False
        Invalidate()
    End Sub

End Class
