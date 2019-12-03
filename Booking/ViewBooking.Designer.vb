<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewBooking
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
        Me.listBooking = New System.Windows.Forms.ListView()
        Me.SuspendLayout()
        '
        'listBooking
        '
        Me.listBooking.HideSelection = False
        Me.listBooking.Location = New System.Drawing.Point(31, 38)
        Me.listBooking.Name = "listBooking"
        Me.listBooking.Size = New System.Drawing.Size(340, 152)
        Me.listBooking.TabIndex = 0
        Me.listBooking.UseCompatibleStateImageBehavior = False
        '
        'ViewBooking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(425, 239)
        Me.Controls.Add(Me.listBooking)
        Me.Name = "ViewBooking"
        Me.Text = "View Booking"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents listBooking As ListView
End Class
