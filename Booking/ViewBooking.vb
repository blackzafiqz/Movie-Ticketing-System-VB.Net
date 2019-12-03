Public Class ViewBooking
    Private sqlinterface As New SQLInterface

    Public Sub New(ByVal user As UserInfo)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Dim moviesAL As ArrayList = sqlinterface.loadMovie()
        Dim sessionsAL As ArrayList = sqlinterface.loadSessions()
        Dim bookingsAL As ArrayList = sqlinterface.loadBookings()

        listBooking.View = View.Details
        listBooking.GridLines = True
        listBooking.FullRowSelect = True
        listBooking.Columns.Add("Title").Width = -1
        listBooking.Columns.Add("Row")
        listBooking.Columns.Add("Column")
        listBooking.Columns.Add("Session").Width = -2

        For Each bookingObj In bookingsAL
            Dim booking As BookingInfo = bookingObj

            For Each sessionObj In sessionsAL
                Dim session As SessionInfo = sessionObj

                For Each movieObj In moviesAL
                    Dim movie As MovieInfo = movieObj

                    If user.id = booking.userId And booking.sessionId = session.id And session.movieId = movie.id Then
                        Dim row As New ListViewItem(movie.title)
                        row.SubItems.Add(booking.seatRow)
                        row.SubItems.Add(booking.seatColumn)
                        row.SubItems.Add(session.time)
                        listBooking.Items.Add(row)
                    End If
                Next
            Next
        Next
    End Sub
End Class