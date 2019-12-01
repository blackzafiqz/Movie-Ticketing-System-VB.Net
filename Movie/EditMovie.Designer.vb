<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EditMovie
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
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.txtPoster = New System.Windows.Forms.TextBox()
        Me.cmbGenre = New System.Windows.Forms.ComboBox()
        Me.txtDuration = New System.Windows.Forms.TextBox()
        Me.datePublish = New System.Windows.Forms.DateTimePicker()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(260, 85)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 13)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "seconds"
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(179, 242)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 28
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(55, 242)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(75, 23)
        Me.btnSubmit.TabIndex = 27
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(113, 164)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(140, 47)
        Me.txtDescription.TabIndex = 26
        '
        'txtPoster
        '
        Me.txtPoster.Location = New System.Drawing.Point(113, 137)
        Me.txtPoster.Name = "txtPoster"
        Me.txtPoster.Size = New System.Drawing.Size(140, 20)
        Me.txtPoster.TabIndex = 25
        '
        'cmbGenre
        '
        Me.cmbGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGenre.FormattingEnabled = True
        Me.cmbGenre.Location = New System.Drawing.Point(113, 109)
        Me.cmbGenre.Name = "cmbGenre"
        Me.cmbGenre.Size = New System.Drawing.Size(140, 21)
        Me.cmbGenre.TabIndex = 24
        '
        'txtDuration
        '
        Me.txtDuration.Location = New System.Drawing.Point(113, 82)
        Me.txtDuration.Name = "txtDuration"
        Me.txtDuration.Size = New System.Drawing.Size(140, 20)
        Me.txtDuration.TabIndex = 23
        '
        'datePublish
        '
        Me.datePublish.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datePublish.Location = New System.Drawing.Point(113, 56)
        Me.datePublish.Name = "datePublish"
        Me.datePublish.Size = New System.Drawing.Size(140, 20)
        Me.datePublish.TabIndex = 22
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(113, 30)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(140, 20)
        Me.txtTitle.TabIndex = 21
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(32, 140)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 13)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Poster Link"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(32, 167)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Description"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Genre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Duration"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Publish Date"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Title"
        '
        'EditMovie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(333, 293)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.txtPoster)
        Me.Controls.Add(Me.cmbGenre)
        Me.Controls.Add(Me.txtDuration)
        Me.Controls.Add(Me.datePublish)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "EditMovie"
        Me.Text = "Edit Movie"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label7 As Label
    Friend WithEvents btnReset As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents txtPoster As TextBox
    Friend WithEvents cmbGenre As ComboBox
    Friend WithEvents txtDuration As TextBox
    Friend WithEvents datePublish As DateTimePicker
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
