Public Class SessionInfo
    Private _id As Integer
    Private _time As Date
    Private _price As Double
    Private _movieId As Integer

    Public Sub New(ByVal id As Integer, ByVal time As Date, ByVal price As Double, ByVal movieId As Integer)
        _id = id
        _time = time
        _price = price
        _movieId = movieId
    End Sub

    Public Sub New(ByVal id As Integer, ByVal time As Date, ByVal price As Double)
        _id = id
        _time = time
        _price = price
    End Sub

    Public Sub New(ByVal time As Date, ByVal price As Double, ByVal movieId As Integer)
        _time = time
        _price = price
        _movieId = movieId
    End Sub
    Public ReadOnly Property id As Integer
        Get
            Return _id
        End Get
    End Property

    Public Property time As Date
        Get
            Return _time
        End Get
        Set(value As Date)
            _time = value
        End Set
    End Property

    Public Property price As Double
        Get
            Return _price
        End Get
        Set(value As Double)
            _price = value
        End Set
    End Property

    Public Property movieId As Integer
        Get
            Return _movieId
        End Get
        Set(value As Integer)
            _movieId = value
        End Set
    End Property
End Class
