Public Class Seat
    Dim seat(5, 11) As SeatButton
    Dim session As SessionInfo
    Dim user As UserInfo
    Private sqlinterface As New SQLInterface()
    Public Sub New(ByVal session As SessionInfo, ByVal user As UserInfo)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.session = session
        Me.user = user
        Dim xStarting As Integer = 100
        Dim yStarting As Integer = 100
        Dim multiplier As Integer = 30

        For y As Integer = 0 To 10
            Dim tempX As Integer = xStarting
            If y = 3 Or y = 8 Then
                yStarting += 50
            End If
            For x As Integer = 0 To 4
                seat(x, y) = New SeatButton(tempX, yStarting, x + 1, y + 1)
                Me.Controls.Add(seat(x, y))
                tempX += multiplier
            Next
            yStarting = yStarting + multiplier
        Next
        checkAvailability()

    End Sub

    Private Sub Seat_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Dim blackpen As New Pen(Color.Black, 3)
        e.Graphics.DrawLine(blackpen, 205, 55, 405, 55)
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim counter As Integer = 0
        Dim seatsAL As New ArrayList
        For y As Integer = 0 To 10
            For x As Integer = 0 To 4
                If seat(x, y).selectedSeat Then
                    counter += 1
                    seatsAL.Add(seat(x, y))
                End If

            Next
        Next
        If counter = 0 Then
            MessageBox.Show("Select at least a seat!")
            Exit Sub
        End If
        If MessageBox.Show("Are you sure you want to book " & counter & "seat(s)?", "", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Dim bookingConfirmation As New BookingConfirmation(user, session, seatsAL)
            bookingConfirmation.ShowDialog()
        End If
    End Sub

    Public Sub checkAvailability()
        Dim bookingAL As ArrayList = sqlinterface.loadBookings()
        For Each bookingObj In bookingAL
            Dim booking As BookingInfo = bookingObj
            If booking.sessionId = session.id Then
                seat(booking.seatRow - 1, booking.seatColumn - 1).unavailable()
            End If
        Next
    End Sub
End Class