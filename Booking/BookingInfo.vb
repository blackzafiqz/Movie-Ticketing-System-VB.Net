Public Class BookingInfo
    Private _id As Integer
    Private _seatrow As Integer
    Private _seatcolumn As Integer
    Private _userId As Integer
    Private _sessionId As Integer

    Public Sub New(ByVal id As Integer, ByVal seatrow As Integer, ByVal seatcolumn As Integer, ByVal userId As Integer, ByVal sessionId As Integer)
        _id = id
        _seatrow = seatrow
        _seatcolumn = seatcolumn
        _userId = userId
        _sessionId = sessionId
    End Sub

    Public Sub New(ByVal seatrow As Integer, ByVal seatcolumn As Integer, ByVal userId As Integer, ByVal sessionId As Integer)
        _seatrow = seatrow
        _seatcolumn = seatcolumn
        _userId = userId
        _sessionId = sessionId
    End Sub

    Public ReadOnly Property id As Integer
        Get
            Return _id
        End Get
    End Property

    Public Property seatRow As Integer
        Get
            Return seatRow
        End Get
        Set(value As Integer)
            _seatrow = value
        End Set
    End Property

    Public Property seatColumn As Integer
        Get
            Return _seatcolumn
        End Get
        Set(value As Integer)
            _seatcolumn = value
        End Set
    End Property

    Public Property userId As Integer
        Get
            Return _userId
        End Get
        Set(value As Integer)
            _userId = value
        End Set
    End Property

    Public Property sessionId As Integer
        Get
            Return _sessionId
        End Get
        Set(value As Integer)
            _sessionId = value
        End Set
    End Property
End Class
