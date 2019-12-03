Imports System.Data

Imports Mysql.Data
Imports Mysql.Data.MySqlClient

Public Class Login
    Private sqlinterface As New SQLInterface
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim usersAL As ArrayList = sqlinterface.loadUsers()
        If txtUsername.Text.Length > 0 And txtPassword.Text.Length > 0 Then
            Dim correct As Boolean
            For Each userObj In usersAL
                Dim user As UserInfo = userObj

                If user.username = txtUsername.Text And user.password = txtPassword.Text Then
                    correct = True
                    If user.permission = "admin" Then
                        Dim adminMenu As New AdminMenu()
                        adminMenu.Show()
                        Me.Hide()
                    Else
                        Dim userMenu As New UserMenu(user)
                        userMenu.Show()
                        Me.Hide()
                    End If
                    Exit Sub
                End If
            Next
            MessageBox.Show("Wrong username or password")
        Else
            MessageBox.Show("Username or password is empty!")
        End If
    End Sub

    Private Sub txtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassword.KeyPress
        If e.KeyChar = ChrW(Keys.Return) Then
            btnLogin.PerformClick()
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtUsername.Clear()
        txtPassword.Clear()
    End Sub
End Class