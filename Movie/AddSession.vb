Public Class AddSession
    Dim sqlinterface As New SQLInterface
    Dim movie As MovieInfo
    Public Sub New(ByVal movie As MovieInfo)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.movie = movie
    End Sub

    Private Sub btnbooking_Click(sender As Object, e As EventArgs) Handles btnbooking.Click
        If IsNumeric(txtPrice.Text) Then
            If sqlinterface.addSession(New SessionInfo(dateTimeSession.Value, CDbl(txtPrice.Text), movie.id)) > 0 Then
                MessageBox.Show("Successfully add session")
            End If
        Else
            MessageBox.Show("Please enter a valid input")

        End If
    End Sub
End Class