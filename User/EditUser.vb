Public Class EditUser
    Private user As UserInfo
    Private sqlinterface As New SQLInterface
    Public Sub New(ByVal user As UserInfo)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.user = user
        txtName.Text = user.name
        txtEmail.Text = user.email
        txtPassword.Text = user.password
        txtUsername.Text = user.username

        cmbPermission.Items.Add("admin")
        cmbPermission.Items.Add("user")
        cmbPermission.SelectedIndex = cmbPermission.FindString(user.permission)
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        user.name = txtName.Text
        user.email = txtEmail.Text
        user.password = txtPassword.Text
        user.username = txtUsername.Text
        user.permission = cmbPermission.Text
        sqlinterface.editUser(user)
        MessageBox.Show("Successfully edit user")


    End Sub
End Class