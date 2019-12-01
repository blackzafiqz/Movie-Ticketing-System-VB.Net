Imports System.Data

Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class SQLInterface

    Private conn As New MySqlConnection
    Private cmd As New MySqlCommand()
    Private usersAL As New ArrayList
    Private moviesAL As New ArrayList

    Public Sub New()
        Dim sqlInfo As String = "server=blackzafiqz.com;uid=movieuser;pwd=ezgame;database=movie"
        conn.ConnectionString = sqlInfo
        cmd.Connection = conn
        cmd.CommandType = CommandType.Text
    End Sub
    Public Sub checkConn()
        If conn.State = ConnectionState.Closed Then
            Try
                conn.Open()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message)
            End Try

        End If
    End Sub
    Public Function loadUsers()
        usersAL.Clear()
        Try
            cmd.CommandText = "SELECT id,name,email,username,password,permission FROM user"
            checkConn()
            Dim sqlreader As MySqlDataReader = cmd.ExecuteReader()

            While sqlreader.Read()
                Dim user As New UserInfo(CInt(sqlreader("id")), sqlreader("name").ToString(), sqlreader("email").ToString(), sqlreader("username").ToString(), sqlreader("password").ToString(), sqlreader("permission").ToString())
                usersAL.Add(user)
            End While
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try
        Return usersAL
    End Function

    Public Function getUsers()
        Return usersAL
    End Function

    Public Function loadMovie()
        Try
            cmd.CommandText = "SELECT id,title,publish_date,duration,genre,poster_link,description FROM movie"
            checkConn()
            Dim sqlreader As MySqlDataReader = cmd.ExecuteReader()

            While sqlreader.Read()
                moviesAL.Add(New MovieInfo(CInt(sqlreader("id")), New Date(sqlreader("publish_date")), CInt(sqlreader("duration")), sqlreader("genre"), sqlreader("poster_link"), sqlreader("description")))
            End While
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try
        Return moviesAL
    End Function

    Public Function getMovies()
        Return moviesAL
    End Function
    Public Function addUser(ByVal user As UserInfo)
        Dim affected_rows As Integer
        Try
            checkConn()

            cmd.CommandText = "INSERT INTO user(name,email,username,password,permission) VALUES(@name,@email,@username,@password,@permission)"
            cmd.Parameters.AddWithValue("@name", user.name())
            cmd.Parameters.AddWithValue("@email", user.email())
            cmd.Parameters.AddWithValue("@username", user.username())
            cmd.Parameters.AddWithValue("@password", user.password())
            cmd.Parameters.AddWithValue("@permission", user.permission())
            affected_rows = cmd.ExecuteNonQuery()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try
        Return affected_rows
    End Function

    Public Function editUser(ByVal user As UserInfo)
        Dim affected_rows As Integer
        Try
            checkConn()

            cmd.CommandText = "UPDATE user SET name=@name,email=@email,username=@username,password=@password,permission=@permission WHERE id=@id"
            cmd.Parameters.AddWithValue("@id", user.id)
            cmd.Parameters.AddWithValue("@name", user.name)
            cmd.Parameters.AddWithValue("@email", user.email)
            cmd.Parameters.AddWithValue("@username", user.username)
            cmd.Parameters.AddWithValue("@password", user.password)
            cmd.Parameters.AddWithValue("@permission", user.permission)
            affected_rows = cmd.ExecuteNonQuery()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try
        Return affected_rows
    End Function
    Public Function deleteUser(ByVal user As UserInfo)
        Dim affected_rows As Integer
        Try
            checkConn()

            cmd.CommandText = "DELETE FROM user WHERE id=@id"
            cmd.Parameters.AddWithValue("@id", user.id)
            affected_rows = cmd.ExecuteNonQuery()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try
        Return affected_rows
    End Function

    Public Function addMovie(ByVal movie As MovieInfo)
        Dim affected_rows As Integer
        Try
            checkConn()

            cmd.CommandText = "INSERT INTO movie(title,publish_date,duration,genre,poster_link,description) VALUES(@title,@publish_date,@duration,@genre,@poster_link,@description)"
            cmd.Parameters.AddWithValue("@title", movie.title)
            cmd.Parameters.AddWithValue("@publish_date", movie.publish_date.ToString("yyyy-MM-dd"))
            cmd.Parameters.AddWithValue("@duration", movie.duration)
            cmd.Parameters.AddWithValue("@genre", movie.genre)
            cmd.Parameters.AddWithValue("@poster_link", movie.poster_link)
            cmd.Parameters.AddWithValue("@description", movie.description)
            affected_rows = cmd.ExecuteNonQuery()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try
        Return affected_rows
    End Function

    Public Function editMovie(ByVal movie As MovieInfo)
        Dim affected_rows As Integer
        Try
            checkConn()

            cmd.CommandText = "UPDATE movie SET title=@title,publish_date=@publish_date,duration=@duration,genre=@genre,poster_link=@poster_link,description=@description WHERE id=@id)"
            cmd.Parameters.AddWithValue("@title", movie.title)
            cmd.Parameters.AddWithValue("@publish_date", movie.publish_date.ToString("yyyy-MM-dd"))
            cmd.Parameters.AddWithValue("@duration", movie.duration)
            cmd.Parameters.AddWithValue("@genre", movie.genre)
            cmd.Parameters.AddWithValue("@poster_link", movie.poster_link)
            cmd.Parameters.AddWithValue("@description", movie.description)
            cmd.Parameters.AddWithValue("@id", movie.id)
            affected_rows = cmd.ExecuteNonQuery()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try
        Return affected_rows
    End Function

    Public Function deleteMovie(ByVal movie As MovieInfo)
        Dim affected_rows As Integer
        Try
            checkConn()

            cmd.CommandText = "DELETE FROM movie WHERE id=@id"
            cmd.Parameters.AddWithValue("@id", movie.id)
            affected_rows = cmd.ExecuteNonQuery()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try
        Return affected_rows
    End Function
End Class
