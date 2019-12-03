Public Class SeatButton
    Inherits Button
    Private selected As Boolean = False
    Private row As Integer
    Private column As Integer
    Public Sub New(ByVal x As Integer, ByVal y As Integer, ByVal r As Integer, ByVal c As Integer)
        Me.Text = ""
        Me.Height = 25
        Me.Width = 25
        Me.Location = New Point(y, x)
        Me.row = r
        Me.column = c
    End Sub

    Private Sub SeatButton_Click(sender As Object, e As EventArgs) Handles Me.Click
        If selected Then
            Me.BackColor = Color.White
            selected = False
        Else
            selected = True
            Me.BackColor = Color.Aqua
        End If
    End Sub

    Public ReadOnly Property selectedSeat As Boolean
        Get
            Return selected
        End Get
    End Property

    Public ReadOnly Property selectedRow As Integer
        Get
            Return row
        End Get
    End Property
    Public ReadOnly Property selectedColumn As Integer
        Get
            Return column
        End Get
    End Property

    Public Sub unavailable()
        Me.Enabled = False
        Me.BackColor = Color.Red
    End Sub
End Class
