Public Class UserInfo
    Private _id As Integer
    Private _name As String
    Private _email As String
    Private _username As String
    Private _password As String
    Private _permission As String

    Public Sub New(ByVal id As Integer, ByVal name As String, ByVal email As String, ByVal username As String, ByVal password As String, ByVal permission As String)
        _id = id
        _name = name
        _username = username
        _email = email
        _password = password
        _permission = permission
    End Sub
    Public Sub New(ByVal name As String, ByVal email As String, ByVal username As String, ByVal password As String, ByVal permission As String)
        _name = name
        _username = username
        _email = email
        _password = password
        _permission = permission
    End Sub
    Public ReadOnly Property id() As Integer
        Get
            Return _id
        End Get
    End Property

    Public Property name() As String
        Get
            Return _name
        End Get
        Set(value As String)
            _name = value
        End Set
    End Property

    Public Property email() As String
        Get
            Return _email
        End Get
        Set(value As String)
            _email = value
        End Set
    End Property

    Public Property username() As String
        Get
            Return _username
        End Get
        Set(value As String)
            _username = value
        End Set
    End Property

    Public Property password() As String
        Get
            Return _password
        End Get
        Set(value As String)
            _password = value
        End Set
    End Property

    Public Property permission() As String
        Get
            Return _permission
        End Get
        Set(value As String)
            _permission = value
        End Set
    End Property
End Class
