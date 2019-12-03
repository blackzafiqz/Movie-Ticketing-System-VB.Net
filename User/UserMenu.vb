Public Class UserMenu
    Private usersAL As ArrayList
    Private moviesAL As ArrayList
    Private sessionsAL As ArrayList
    Private bookingsAL As ArrayList
    Private sqlinterface As New SQLInterface
    Private currentUser As UserInfo
    Dim lblDescription As New Label()
    Public Sub New(ByVal user As UserInfo)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.currentUser = user
        lblWelcome.Text = "Welcome " & currentUser.name
        refreshData()
        For Each movieObj In moviesAL
            Dim movie As MovieInfo = movieObj
            cmbMovieTitle.Items.Add(movie.title)
        Next
        panelDescription.Controls.Add(lblDescription)
        lblDescription.AutoSize = True
        lblDescription.Location = New Point(0, 0)
        lblDescription.MaximumSize = New Size(panelDescription.Width - 18, 0)
    End Sub

    Private Sub refreshData()
        usersAL = sqlinterface.loadUsers()
        moviesAL = sqlinterface.loadMovie()
        sessionsAL = sqlinterface.loadSessions()
        bookingsAL = sqlinterface.loadBookings()

    End Sub

    Private Sub cmbMovieTitle_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbMovieTitle.SelectedValueChanged
        cmbSession.Items.Clear()
        For Each movieObj In moviesAL
            Dim movie As MovieInfo = movieObj
            If cmbMovieTitle.SelectedItem = movie.title Then
                picPoster.ImageLocation = movie.poster_link
                lblDescription.Text = movie.description

                For Each sessionObj In sessionsAL

                    Dim session As SessionInfo = sessionObj
                    If session.movieId = movie.id Then
                        cmbSession.Items.Add(session.time)
                    End If
                Next
            End If
        Next
    End Sub


    Private Sub cmbSession_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbSession.SelectedValueChanged
        For Each movieObj In moviesAL
            Dim movie As MovieInfo = movieObj
            If cmbMovieTitle.SelectedItem = movie.title Then
                picPoster.ImageLocation = movie.poster_link
                lblDescription.Text = movie.description

                For Each sessionObj In sessionsAL

                    Dim session As SessionInfo = sessionObj
                    If session.movieId = movie.id And session.time = cmbSession.SelectedItem Then
                        lblPrice.Text = session.price
                        Dim counter As Integer = 0
                        For Each bookingObj In bookingsAL
                            Dim booking As BookingInfo = bookingObj
                            If booking.sessionId = session.id Then
                                counter += 1
                            End If
                        Next
                        lblAvailability.Text = 55 - counter
                        Exit Sub
                    End If
                Next
            End If
        Next
    End Sub

    Private Sub btnChooseSeat_Click(sender As Object, e As EventArgs) Handles btnChooseSeat.Click
        If cmbMovieTitle.SelectedIndex < 0 And cmbSession.SelectedIndex < 0 Then
            MessageBox.Show("You need to select a title and session")
            Exit Sub
        End If

        For Each movieObj In moviesAL
            Dim movie As MovieInfo = movieObj
            If cmbMovieTitle.SelectedItem = movie.title Then
                For Each sessionObj In sessionsAL

                    Dim session As SessionInfo = sessionObj
                    If session.movieId = movie.id And session.time = cmbSession.SelectedItem Then
                        Dim seat As New Seat(session, currentUser)
                        seat.ShowDialog()
                        Exit Sub
                    End If
                Next
            End If
        Next
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Login.Show()
        Login.btnReset.PerformClick()
        Me.Close()
    End Sub

    Private Sub btnViewBooking_Click(sender As Object, e As EventArgs) Handles btnViewBooking.Click
        Dim viewBooking As New ViewBooking(currentUser)
        viewBooking.ShowDialog()
    End Sub
End Class