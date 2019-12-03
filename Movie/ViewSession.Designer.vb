<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewSession
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
        Me.btnAddSession = New System.Windows.Forms.Button()
        Me.btnEditSession = New System.Windows.Forms.Button()
        Me.btnDeleteSession = New System.Windows.Forms.Button()
        Me.listSession = New System.Windows.Forms.ListView()
        Me.SuspendLayout()
        '
        'btnAddSession
        '
        Me.btnAddSession.Location = New System.Drawing.Point(237, 44)
        Me.btnAddSession.Name = "btnAddSession"
        Me.btnAddSession.Size = New System.Drawing.Size(89, 23)
        Me.btnAddSession.TabIndex = 1
        Me.btnAddSession.Text = "Add Session"
        Me.btnAddSession.UseVisualStyleBackColor = True
        '
        'btnEditSession
        '
        Me.btnEditSession.Location = New System.Drawing.Point(237, 90)
        Me.btnEditSession.Name = "btnEditSession"
        Me.btnEditSession.Size = New System.Drawing.Size(89, 23)
        Me.btnEditSession.TabIndex = 2
        Me.btnEditSession.Text = "Edit Session"
        Me.btnEditSession.UseVisualStyleBackColor = True
        '
        'btnDeleteSession
        '
        Me.btnDeleteSession.Location = New System.Drawing.Point(237, 137)
        Me.btnDeleteSession.Name = "btnDeleteSession"
        Me.btnDeleteSession.Size = New System.Drawing.Size(89, 23)
        Me.btnDeleteSession.TabIndex = 3
        Me.btnDeleteSession.Text = "Delete Session"
        Me.btnDeleteSession.UseVisualStyleBackColor = True
        '
        'listSession
        '
        Me.listSession.HideSelection = False
        Me.listSession.Location = New System.Drawing.Point(43, 35)
        Me.listSession.Name = "listSession"
        Me.listSession.Size = New System.Drawing.Size(165, 126)
        Me.listSession.TabIndex = 0
        Me.listSession.UseCompatibleStateImageBehavior = False
        '
        'ViewSession
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(398, 203)
        Me.Controls.Add(Me.btnDeleteSession)
        Me.Controls.Add(Me.btnEditSession)
        Me.Controls.Add(Me.btnAddSession)
        Me.Controls.Add(Me.listSession)
        Me.Name = "ViewSession"
        Me.Text = "View Session"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnAddSession As Button
    Friend WithEvents btnEditSession As Button
    Friend WithEvents btnDeleteSession As Button
    Friend WithEvents listSession As ListView
End Class
