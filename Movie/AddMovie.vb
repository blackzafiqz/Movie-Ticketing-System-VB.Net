Public Class AddMovie
    Dim sqlinterface As New SQLInterface
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If validate() Then
            If sqlinterface.addMovie(New MovieInfo(txtTitle.Text, datePublish.Value, txtDuration.Text, cmbGenre.Text, txtPoster.Text, txtDescription.Text)) > 0 Then
                MessageBox.Show("Successfully add movie")
            End If
        Else
            MessageBox.Show("Please enter all form")
        End If
    End Sub

#Disable Warning BC40003 ' Member shadows an overloadable member declared in the base type
    Private Function validate()
#Enable Warning BC40003 ' Member shadows an overloadable member declared in the base type
        If txtTitle.Text.Length = 0 Or txtDuration.Text.Length = 0 Or txtPoster.Text.Length = 0 Or txtDescription.Text.Length = 0 Or cmbGenre.Text.Length = 0 Then
            Return False
        End If
        Return True
    End Function
    Private Sub AddMovie_Load(sender As Object, e As EventArgs) Handles Me.Load
        cmbGenre.Items.Add("Action")
        cmbGenre.Items.Add("Adventure")
        cmbGenre.Items.Add("Comedy")
        cmbGenre.Items.Add("Drama")
        cmbGenre.Items.Add("Fantasy")
        cmbGenre.Items.Add("Historical")
        cmbGenre.Items.Add("Mystery")
        cmbGenre.Items.Add("Romance")
        cmbGenre.Items.Add("Social")
        cmbGenre.Items.Add("Thriller")
        cmbGenre.Items.Add("Western")
        datePublish.Value = Date.Today
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtTitle.Clear()
        txtDuration.Clear()
        txtDescription.Clear()
        txtPoster.Clear()
        cmbGenre.SelectedIndex = -1
    End Sub
End Class