Public Class ViewSession
    Private movie As MovieInfo
    Private sqlinterface As New SQLInterface
    Private sessionsAL As ArrayList
    Public Sub New(ByVal movie As MovieInfo)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.movie = movie
        listSession.View = View.Details
        listSession.GridLines = True
        listSession.FullRowSelect = True
        listSession.Columns.Add("Time").Width = -1
        listSession.Columns.Add("Price").Width = -2
        refreshData()
    End Sub

    Private Sub btnAddSession_Click(sender As Object, e As EventArgs) Handles btnAddSession.Click
        Dim addSession As New AddSession(movie)
        addSession.ShowDialog()
        refreshData()
    End Sub

    Private Sub refreshData()
        listSession.Items.Clear()

        sessionsAL = sqlinterface.loadSessions()

        For Each sessionObj In sessionsAL
            Dim session As SessionInfo = sessionObj
            If session.movieId = movie.id Then
                Dim row As New ListViewItem(session.time.ToString("hh:mm tt dd-mm-yyyy"))
                row.Tag = session.id
                row.SubItems.Add(session.price)
                listSession.Items.Add(row)
            End If
        Next
    End Sub

    Private Sub btnEditSession_Click(sender As Object, e As EventArgs) Handles btnEditSession.Click
        For Each sessionObj In sessionsAL
            Dim session As SessionInfo = sessionObj
            If listSession.SelectedItems(0).Tag = session.id Then
                Dim editSession As New EditSession(session)
                editSession.ShowDialog()
                refreshData()
                Exit Sub
            End If
        Next
    End Sub

    Private Sub btnDeleteSession_Click(sender As Object, e As EventArgs) Handles btnDeleteSession.Click
        For Each sessionObj In sessionsAL
            Dim session As SessionInfo = sessionObj
            If listSession.SelectedItems(0).Tag = session.id Then
                If MessageBox.Show("Are you sure want to delete this session?", "", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                    If sqlinterface.deleteSession(session) > 0 Then
                        MessageBox.Show("Successfully delete session")
                        refreshData()
                        Exit For
                    End If
                End If

            End If
        Next
    End Sub
End Class