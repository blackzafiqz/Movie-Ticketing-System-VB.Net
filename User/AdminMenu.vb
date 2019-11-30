Imports System.Data

Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class AdminMenu
    Private sqlInterface As New SQLInterface()
    Private Sub AdminMenu_Load(sender As Object, e As EventArgs) Handles Me.Load
        btnRefresh.PerformClick()
    End Sub

    Private Sub loadUser()
        Dim usersAL As ArrayList = sqlInterface.loadUsers()
        listUser.Items.Clear()
        For Each userObj In usersAL
            Dim user As UserInfo = userObj
            listUser.Items.Add(user.name)
        Next
    End Sub

    Private Sub loadMovie()
        Dim temp As ArrayList = sqlInterface.loadMovie()
        listMovie.Items.Clear()
        For Each movie In temp
            listMovie.Items.Add(movie)
        Next
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        loadUser()
        loadMovie()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Hide()
        Login.Show()
        Login.btnReset.PerformClick()
    End Sub

    Private Sub btnAddUser_Click(sender As Object, e As EventArgs) Handles btnAddUser.Click
        AddUser.btnReset.PerformClick()
        AddUser.ShowDialog()
        btnRefresh.PerformClick()
    End Sub

    Private Sub btnEditUser_Click(sender As Object, e As EventArgs) Handles btnEditUser.Click
        Dim usersAL As ArrayList = sqlInterface.getUsers()

        For Each userObj In usersAL
            Dim user As UserInfo = userObj

            If listUser.SelectedItem = user.name Then
                Dim editForm As New EditUser(user)
                editForm.ShowDialog()
                btnRefresh.PerformClick()
                Exit For
            End If
        Next
    End Sub


    Private Sub listUser_DoubleClick(sender As Object, e As EventArgs) Handles listUser.DoubleClick
        btnEditUser.PerformClick()
    End Sub

    Private Sub btnDeleteUser_Click(sender As Object, e As EventArgs) Handles btnDeleteUser.Click
        Dim usersAL As ArrayList = sqlInterface.getUsers()

        For Each userObj In usersAL
            Dim user As UserInfo = userObj

            If listUser.SelectedItem = user.name Then
                If sqlInterface.deleteUser(user) > 0 Then
                    MessageBox.Show("Successfully delete user")
                End If
                btnRefresh.PerformClick()
                Exit For
            End If
        Next
    End Sub
End Class