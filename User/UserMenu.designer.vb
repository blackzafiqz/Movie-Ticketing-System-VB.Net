<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbMovieTitle = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbSession = New System.Windows.Forms.ComboBox()
        Me.picPoster = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.panelDescription = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblAvailability = New System.Windows.Forms.Label()
        Me.btnChooseSeat = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnViewBooking = New System.Windows.Forms.Button()
        CType(Me.picPoster, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Location = New System.Drawing.Point(40, 25)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(49, 13)
        Me.lblWelcome.TabIndex = 0
        Me.lblWelcome.Text = "welcome"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Movie Title "
        '
        'cmbMovieTitle
        '
        Me.cmbMovieTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMovieTitle.FormattingEnabled = True
        Me.cmbMovieTitle.Location = New System.Drawing.Point(111, 75)
        Me.cmbMovieTitle.Name = "cmbMovieTitle"
        Me.cmbMovieTitle.Size = New System.Drawing.Size(121, 21)
        Me.cmbMovieTitle.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(43, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Session"
        '
        'cmbSession
        '
        Me.cmbSession.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSession.FormattingEnabled = True
        Me.cmbSession.Location = New System.Drawing.Point(111, 106)
        Me.cmbSession.Name = "cmbSession"
        Me.cmbSession.Size = New System.Drawing.Size(121, 21)
        Me.cmbSession.TabIndex = 5
        '
        'picPoster
        '
        Me.picPoster.Location = New System.Drawing.Point(395, 25)
        Me.picPoster.Name = "picPoster"
        Me.picPoster.Size = New System.Drawing.Size(100, 109)
        Me.picPoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPoster.TabIndex = 6
        Me.picPoster.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(43, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Price"
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Location = New System.Drawing.Point(111, 140)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(0, 13)
        Me.lblPrice.TabIndex = 9
        '
        'panelDescription
        '
        Me.panelDescription.AutoScroll = True
        Me.panelDescription.Location = New System.Drawing.Point(348, 173)
        Me.panelDescription.Name = "panelDescription"
        Me.panelDescription.Size = New System.Drawing.Size(200, 100)
        Me.panelDescription.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(43, 173)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Availability"
        '
        'lblAvailability
        '
        Me.lblAvailability.AutoSize = True
        Me.lblAvailability.Location = New System.Drawing.Point(114, 173)
        Me.lblAvailability.Name = "lblAvailability"
        Me.lblAvailability.Size = New System.Drawing.Size(0, 13)
        Me.lblAvailability.TabIndex = 12
        '
        'btnChooseSeat
        '
        Me.btnChooseSeat.Location = New System.Drawing.Point(30, 244)
        Me.btnChooseSeat.Name = "btnChooseSeat"
        Me.btnChooseSeat.Size = New System.Drawing.Size(75, 23)
        Me.btnChooseSeat.TabIndex = 13
        Me.btnChooseSeat.Text = "Choose seat"
        Me.btnChooseSeat.UseVisualStyleBackColor = True
        '
        'btnLogout
        '
        Me.btnLogout.Location = New System.Drawing.Point(235, 244)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(75, 23)
        Me.btnLogout.TabIndex = 14
        Me.btnLogout.Text = "Log Out"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'btnViewBooking
        '
        Me.btnViewBooking.Location = New System.Drawing.Point(127, 244)
        Me.btnViewBooking.Name = "btnViewBooking"
        Me.btnViewBooking.Size = New System.Drawing.Size(86, 23)
        Me.btnViewBooking.TabIndex = 15
        Me.btnViewBooking.Text = "View Booking"
        Me.btnViewBooking.UseVisualStyleBackColor = True
        '
        'UserMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(619, 299)
        Me.Controls.Add(Me.btnViewBooking)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnChooseSeat)
        Me.Controls.Add(Me.lblAvailability)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.panelDescription)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.picPoster)
        Me.Controls.Add(Me.cmbSession)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbMovieTitle)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblWelcome)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "UserMenu"
        Me.Text = "User Menu"
        CType(Me.picPoster, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblWelcome As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbMovieTitle As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbSession As ComboBox
    Friend WithEvents picPoster As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents panelDescription As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents lblAvailability As Label
    Friend WithEvents btnChooseSeat As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnViewBooking As Button
End Class
