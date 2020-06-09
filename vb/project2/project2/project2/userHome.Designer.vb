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
        Me.lblGerechten = New System.Windows.Forms.Label()
        Me.Gerechten = New System.Windows.Forms.ListView()
        Me.lblEventNaam = New System.Windows.Forms.Label()
        Me.lblEventPer = New System.Windows.Forms.Label()
        Me.lblGerechtNaam = New System.Windows.Forms.Label()
        Me.lblGerechtVegan = New System.Windows.Forms.Label()
        Me.lblGerechtProducten = New System.Windows.Forms.Label()
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
        Me.eventen.Size = New System.Drawing.Size(969, 223)
        Me.eventen.TabIndex = 2
        Me.eventen.UseCompatibleStateImageBehavior = False
        '
        'lblEventen
        '
        Me.lblEventen.AutoSize = True
        Me.lblEventen.Location = New System.Drawing.Point(366, 81)
        Me.lblEventen.Name = "lblEventen"
        Me.lblEventen.Size = New System.Drawing.Size(82, 25)
        Me.lblEventen.TabIndex = 3
        Me.lblEventen.Text = "eventen"
        '
        'lblGerechten
        '
        Me.lblGerechten.AutoSize = True
        Me.lblGerechten.Location = New System.Drawing.Point(366, 365)
        Me.lblGerechten.Name = "lblGerechten"
        Me.lblGerechten.Size = New System.Drawing.Size(105, 25)
        Me.lblGerechten.TabIndex = 5
        Me.lblGerechten.Text = "gerechten:"
        '
        'Gerechten
        '
        Me.Gerechten.HideSelection = False
        Me.Gerechten.Location = New System.Drawing.Point(26, 402)
        Me.Gerechten.Name = "Gerechten"
        Me.Gerechten.Size = New System.Drawing.Size(969, 223)
        Me.Gerechten.TabIndex = 4
        Me.Gerechten.UseCompatibleStateImageBehavior = False
        '
        'lblEventNaam
        '
        Me.lblEventNaam.AutoSize = True
        Me.lblEventNaam.Location = New System.Drawing.Point(1065, 132)
        Me.lblEventNaam.Name = "lblEventNaam"
        Me.lblEventNaam.Size = New System.Drawing.Size(0, 25)
        Me.lblEventNaam.TabIndex = 6
        '
        'lblEventPer
        '
        Me.lblEventPer.AutoSize = True
        Me.lblEventPer.Location = New System.Drawing.Point(1065, 176)
        Me.lblEventPer.Name = "lblEventPer"
        Me.lblEventPer.Size = New System.Drawing.Size(0, 25)
        Me.lblEventPer.TabIndex = 7
        '
        'lblGerechtNaam
        '
        Me.lblGerechtNaam.AutoSize = True
        Me.lblGerechtNaam.Location = New System.Drawing.Point(1046, 425)
        Me.lblGerechtNaam.Name = "lblGerechtNaam"
        Me.lblGerechtNaam.Size = New System.Drawing.Size(71, 25)
        Me.lblGerechtNaam.TabIndex = 8
        Me.lblGerechtNaam.Text = "Label3"
        '
        'lblGerechtVegan
        '
        Me.lblGerechtVegan.AutoSize = True
        Me.lblGerechtVegan.Location = New System.Drawing.Point(1046, 467)
        Me.lblGerechtVegan.Name = "lblGerechtVegan"
        Me.lblGerechtVegan.Size = New System.Drawing.Size(71, 25)
        Me.lblGerechtVegan.TabIndex = 9
        Me.lblGerechtVegan.Text = "Label4"
        '
        'lblGerechtProducten
        '
        Me.lblGerechtProducten.AutoSize = True
        Me.lblGerechtProducten.Location = New System.Drawing.Point(1046, 511)
        Me.lblGerechtProducten.Name = "lblGerechtProducten"
        Me.lblGerechtProducten.Size = New System.Drawing.Size(71, 25)
        Me.lblGerechtProducten.TabIndex = 10
        Me.lblGerechtProducten.Text = "Label4"
        '
        'userHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1572, 646)
        Me.Controls.Add(Me.lblGerechtProducten)
        Me.Controls.Add(Me.lblGerechtVegan)
        Me.Controls.Add(Me.lblGerechtNaam)
        Me.Controls.Add(Me.lblEventPer)
        Me.Controls.Add(Me.lblEventNaam)
        Me.Controls.Add(Me.lblGerechten)
        Me.Controls.Add(Me.Gerechten)
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
    Friend WithEvents lblGerechten As Label
    Friend WithEvents Gerechten As ListView
    Friend WithEvents lblEventNaam As Label
    Friend WithEvents lblEventPer As Label
    Friend WithEvents lblGerechtNaam As Label
    Friend WithEvents lblGerechtVegan As Label
    Friend WithEvents lblGerechtProducten As Label
End Class
