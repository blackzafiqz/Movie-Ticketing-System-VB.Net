Public Class BookingConfirmation
    Private seatsAL As ArrayList
    Private moviesAL As ArrayList
    Private session As SessionInfo
    Private currentUser As UserInfo
    Private sqlinterface As New SQLInterface

    Public Sub New(ByVal user As UserInfo, ByVal session As SessionInfo, ByVal seatsAL As ArrayList)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Me.seatsAL = seatsAL
        Me.moviesAL = sqlinterface.loadMovie()
        Me.session = session
        Me.currentUser = user
        For Each moviesObj In moviesAL
            Dim movie As MovieInfo = moviesObj
            If movie.id = session.movieId Then
                lblTitle.Text = movie.title
                Exit For
            End If
        Next
        lblPrice.Text = session.price * seatsAL.Count
        lblSession.Text = session.time
        lblSeat.Text = seatsAL.Count

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If MessageBox.Show("Are you sure want to continue? ", "", MessageBoxButtons.YesNo) = DialogResult.No Then
            Exit Sub
        End If
        Dim counter As Integer = 0
        For Each seatObj In seatsAL
            Dim seat As SeatButton = seatObj
            counter += sqlinterface.addBooking(New BookingInfo(seat.selectedRow, seat.selectedColumn, currentUser.id, session.id))
        Next
        If counter > 0 Then
            MessageBox.Show("Successfully add booking")
        End If
    End Sub
End Class