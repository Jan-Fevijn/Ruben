<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class userHome
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
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblNaam = New System.Windows.Forms.Label()
        Me.eventen = New System.Windows.Forms.ListView()
        Me.lblEventen = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Location = New System.Drawing.Point(67, 29)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(99, 25)
        Me.lblUsername.TabIndex = 0
        Me.lblUsername.Text = "username"
        '
        'lblNaam
        '
        Me.lblNaam.AutoSize = True
        Me.lblNaam.Location = New System.Drawing.Point(482, 29)
        Me.lblNaam.Name = "lblNaam"
        Me.lblNaam.Size = New System.Drawing.Size(158, 25)
        Me.lblNaam.TabIndex = 1
        Me.lblNaam.Text = "voornaam  naam"
        '
        'eventen
        '
        Me.eventen.HideSelection = False
        Me.eventen.Location = New System.Drawing.Point(26, 118)
        Me.eventen.Name = "eventen"
        Me.eventen.Size = New System.Drawing.Size(251, 169)
        Me.eventen.TabIndex = 2
        Me.eventen.UseCompatibleStateImageBehavior = False
        '
        'lblEventen
        '
        Me.lblEventen.AutoSize = True
        Me.lblEventen.Location = New System.Drawing.Point(81, 78)
        Me.lblEventen.Name = "lblEventen"
        Me.lblEventen.Size = New System.Drawing.Size(82, 25)
        Me.lblEventen.TabIndex = 3
        Me.lblEventen.Text = "eventen"
        '
        'userHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1066, 569)
        Me.Controls.Add(Me.lblEventen)
        Me.Controls.Add(Me.eventen)
        Me.Controls.Add(Me.lblNaam)
        Me.Controls.Add(Me.lblUsername)
        Me.Name = "userHome"
        Me.Text = "userHome"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblUsername As Label
    Friend WithEvents lblNaam As Label
    Friend WithEvents eventen As ListView
    Friend WithEvents lblEventen As Label
End Class
