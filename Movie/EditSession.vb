Public Class EditSession
    Private sqlinterface As New SQLInterface
    Private session As SessionInfo
    Public Sub New(ByVal session As SessionInfo)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.session = session
        txtPrice.Text = session.price
        dateTimeSession.Value = session.time
    End Sub

    Private Sub btnbooking_Click(sender As Object, e As EventArgs) Handles btnbooking.Click
        If IsNumeric(txtPrice.Text) Then
            If sqlinterface.editSession(New SessionInfo(session.id, dateTimeSession.Value, txtPrice.Text)) > 0 Then
                MessageBox.Show("Successfully edit session")
            End If
        Else
            MessageBox.Show("Please enter valid price!")
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If MessageBox.Show("Are you sure to delete this?", "", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            sqlinterface.deleteSession(session)
        End If
    End Sub
End Class