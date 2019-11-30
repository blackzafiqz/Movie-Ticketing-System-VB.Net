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
        Dim al As New ArrayList
        Try
            cmd.CommandText = "SELECT title FROM movie"
            checkConn()
            Dim sqlreader As MySqlDataReader = cmd.ExecuteReader()

            While sqlreader.Read()
                al.Add(sqlreader("title"))
            End While
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try
        Return al
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


End Class
