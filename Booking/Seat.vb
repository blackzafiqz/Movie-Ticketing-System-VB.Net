Public Class Seat
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Dim seat(5, 11) As SeatButton
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


    End Sub

    Private Sub Seat_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Dim blackpen As New Pen(Color.Black, 3)
        e.Graphics.DrawLine(blackpen, 205, 55, 405, 55)
    End Sub
End Class