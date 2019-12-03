<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditSession
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
        Me.btnbooking = New System.Windows.Forms.Button()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.dateTimeSession = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnbooking
        '
        Me.btnbooking.Location = New System.Drawing.Point(59, 117)
        Me.btnbooking.Name = "btnbooking"
        Me.btnbooking.Size = New System.Drawing.Size(75, 23)
        Me.btnbooking.TabIndex = 9
        Me.btnbooking.Text = "Submit"
        Me.btnbooking.UseVisualStyleBackColor = True
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(92, 72)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(99, 20)
        Me.txtPrice.TabIndex = 8
        '
        'dateTimeSession
        '
        Me.dateTimeSession.CustomFormat = "dd-mm-yyyy hh:mm tt"
        Me.dateTimeSession.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dateTimeSession.Location = New System.Drawing.Point(92, 39)
        Me.dateTimeSession.Name = "dateTimeSession"
        Me.dateTimeSession.Size = New System.Drawing.Size(183, 20)
        Me.dateTimeSession.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(56, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Price"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(56, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Time"
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(172, 117)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 10
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'EditSession
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(328, 164)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnbooking)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.dateTimeSession)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "EditSession"
        Me.Text = "Edit Session"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnbooking As Button
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents dateTimeSession As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnDelete As Button
End Class
