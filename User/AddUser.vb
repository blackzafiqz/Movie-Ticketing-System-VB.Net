Imports System.Data

Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class AddUser
    Private sqlinterface As New SQLInterface
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If validate() Then
            If sqlinterface.addUser(New UserInfo(txtName.Text, txtEmail.Text, txtUsername.Text, txtPassword.Text, cmbPermission.Text)) Then
                MessageBox.Show("Successfully adding user")
            End If

        End If
    End Sub

#Disable Warning BC40003 ' Member shadows an overloadable member declared in the base type
    Private Function validate() As Boolean
#Enable Warning BC40003 ' Member shadows an overloadable member declared in the base type
        If (txtName.Text.Length > 0 And txtEmail.Text.Length > 0 And txtUsername.Text.Length > 0 And txtPassword.Text.Length > 0) Then
            Return True
        End If
        Return False
    End Function

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtEmail.Clear()
        txtName.Clear()
        txtPassword.Clear()
        txtUsername.Clear()
        cmbPermission.ResetText()
    End Sub

    Private Sub AddUser_Load(sender As Object, e As EventArgs) Handles Me.Load
        cmbPermission.Items.Add("admin")
        cmbPermission.Items.Add("user")
    End Sub
End Class