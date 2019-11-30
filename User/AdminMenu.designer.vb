<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.listUser = New System.Windows.Forms.ListBox()
        Me.listMovie = New System.Windows.Forms.ListBox()
        Me.btnAddUser = New System.Windows.Forms.Button()
        Me.btnEditUser = New System.Windows.Forms.Button()
        Me.btnDeleteUser = New System.Windows.Forms.Button()
        Me.btnAddMovie = New System.Windows.Forms.Button()
        Me.btnEditMovie = New System.Windows.Forms.Button()
        Me.btnDeleteMovie = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'listUser
        '
        Me.listUser.FormattingEnabled = True
        Me.listUser.Location = New System.Drawing.Point(452, 67)
        Me.listUser.Name = "listUser"
        Me.listUser.Size = New System.Drawing.Size(232, 134)
        Me.listUser.TabIndex = 0
        '
        'listMovie
        '
        Me.listMovie.FormattingEnabled = True
        Me.listMovie.Location = New System.Drawing.Point(111, 67)
        Me.listMovie.Name = "listMovie"
        Me.listMovie.Size = New System.Drawing.Size(208, 134)
        Me.listMovie.TabIndex = 1
        '
        'btnAddUser
        '
        Me.btnAddUser.Location = New System.Drawing.Point(350, 67)
        Me.btnAddUser.Name = "btnAddUser"
        Me.btnAddUser.Size = New System.Drawing.Size(75, 23)
        Me.btnAddUser.TabIndex = 2
        Me.btnAddUser.Text = "Add User"
        Me.btnAddUser.UseVisualStyleBackColor = True
        '
        'btnEditUser
        '
        Me.btnEditUser.Location = New System.Drawing.Point(350, 102)
        Me.btnEditUser.Name = "btnEditUser"
        Me.btnEditUser.Size = New System.Drawing.Size(75, 23)
        Me.btnEditUser.TabIndex = 3
        Me.btnEditUser.Text = "Edit User"
        Me.btnEditUser.UseVisualStyleBackColor = True
        '
        'btnDeleteUser
        '
        Me.btnDeleteUser.Location = New System.Drawing.Point(350, 139)
        Me.btnDeleteUser.Name = "btnDeleteUser"
        Me.btnDeleteUser.Size = New System.Drawing.Size(75, 23)
        Me.btnDeleteUser.TabIndex = 4
        Me.btnDeleteUser.Text = "Delete User"
        Me.btnDeleteUser.UseVisualStyleBackColor = True
        '
        'btnAddMovie
        '
        Me.btnAddMovie.Location = New System.Drawing.Point(12, 67)
        Me.btnAddMovie.Name = "btnAddMovie"
        Me.btnAddMovie.Size = New System.Drawing.Size(81, 23)
        Me.btnAddMovie.TabIndex = 5
        Me.btnAddMovie.Text = "Add Movie"
        Me.btnAddMovie.UseVisualStyleBackColor = True
        '
        'btnEditMovie
        '
        Me.btnEditMovie.Location = New System.Drawing.Point(12, 101)
        Me.btnEditMovie.Name = "btnEditMovie"
        Me.btnEditMovie.Size = New System.Drawing.Size(81, 23)
        Me.btnEditMovie.TabIndex = 6
        Me.btnEditMovie.Text = "Edit Movie"
        Me.btnEditMovie.UseVisualStyleBackColor = True
        '
        'btnDeleteMovie
        '
        Me.btnDeleteMovie.Location = New System.Drawing.Point(12, 138)
        Me.btnDeleteMovie.Name = "btnDeleteMovie"
        Me.btnDeleteMovie.Size = New System.Drawing.Size(81, 23)
        Me.btnDeleteMovie.TabIndex = 7
        Me.btnDeleteMovie.Text = "Delete Movie"
        Me.btnDeleteMovie.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(212, 257)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(75, 23)
        Me.btnRefresh.TabIndex = 8
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnLogout
        '
        Me.btnLogout.Location = New System.Drawing.Point(373, 257)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(75, 23)
        Me.btnLogout.TabIndex = 9
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'AdminMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(705, 327)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnDeleteMovie)
        Me.Controls.Add(Me.btnEditMovie)
        Me.Controls.Add(Me.btnAddMovie)
        Me.Controls.Add(Me.btnDeleteUser)
        Me.Controls.Add(Me.btnEditUser)
        Me.Controls.Add(Me.btnAddUser)
        Me.Controls.Add(Me.listMovie)
        Me.Controls.Add(Me.listUser)
        Me.Name = "AdminMenu"
        Me.Text = "Admin Menu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents listUser As ListBox
    Friend WithEvents listMovie As ListBox
    Friend WithEvents btnAddUser As Button
    Friend WithEvents btnEditUser As Button
    Friend WithEvents btnDeleteUser As Button
    Friend WithEvents btnAddMovie As Button
    Friend WithEvents btnEditMovie As Button
    Friend WithEvents btnDeleteMovie As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnLogout As Button
End Class
