Public Class MovieInfo
    Private _id As Integer
    Private _title As String
    Private _publish_date As Date
    Private _duration As Integer
    Private _genre As String
    Private _poster_link As String
    Private _description As String

    Public Sub New(ByVal id As Integer, ByVal title As String, ByVal publish_date As Date, ByVal duration As Integer, ByVal genre As String, ByVal poster_link As String, ByVal description As String)
        _id = id
        _title = title
        _publish_date = publish_date
        _duration = duration
        _genre = genre
        _poster_link = poster_link
        _description = description
    End Sub

    Public Sub New(ByVal title As String, ByVal publish_date As Date, ByVal duration As Integer, ByVal genre As String, ByVal poster_link As String, ByVal description As String)
        _title = title
        _publish_date = publish_date
        _duration = duration
        _genre = genre
        _poster_link = poster_link
        _description = description
    End Sub

    Public ReadOnly Property id() As Integer
        Get
            Return _id
        End Get
    End Property

    Public Property title() As String
        Get
            Return _title
        End Get
        Set(value As String)
            _title = value
        End Set
    End Property

    Public Property publish_date() As Date
        Get
            Return _publish_date
        End Get
        Set(value As Date)
            _publish_date = value
        End Set
    End Property

    Public Property duration() As Integer
        Get
            Return _duration
        End Get
        Set(value As Integer)
            _duration = value
        End Set
    End Property

    Public Property genre() As String
        Get
            Return _genre
        End Get
        Set(value As String)
            _genre = value
        End Set
    End Property
    Public Property poster_link() As String
        Get
            Return _poster_link
        End Get
        Set(value As String)
            _poster_link = value
        End Set
    End Property
    Public Property description() As String
        Get
            Return _description
        End Get
        Set(value As String)
            _description = value
        End Set
    End Property
End Class
