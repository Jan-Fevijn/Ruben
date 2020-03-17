<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class registreer
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
        Me.lblVoornaam = New System.Windows.Forms.Label()
        Me.lblNaam = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblWachtwoord1 = New System.Windows.Forms.Label()
        Me.lblWachtwoord2 = New System.Windows.Forms.Label()
        Me.txtVoornaam = New System.Windows.Forms.TextBox()
        Me.txtNaam = New System.Windows.Forms.TextBox()
        Me.txtWachtwoord1 = New System.Windows.Forms.TextBox()
        Me.txtWachtwoord2 = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.btnRegistreer = New System.Windows.Forms.Button()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.RadVeganistisch = New System.Windows.Forms.RadioButton()
        Me.Radvegitarisch = New System.Windows.Forms.RadioButton()
        Me.radGeen = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'lblVoornaam
        '
        Me.lblVoornaam.AutoSize = True
        Me.lblVoornaam.Location = New System.Drawing.Point(77, 63)
        Me.lblVoornaam.Name = "lblVoornaam"
        Me.lblVoornaam.Size = New System.Drawing.Size(99, 25)
        Me.lblVoornaam.TabIndex = 0
        Me.lblVoornaam.Text = "voornaam"
        '
        'lblNaam
        '
        Me.lblNaam.AutoSize = True
        Me.lblNaam.Location = New System.Drawing.Point(77, 97)
        Me.lblNaam.Name = "lblNaam"
        Me.lblNaam.Size = New System.Drawing.Size(61, 25)
        Me.lblNaam.TabIndex = 1
        Me.lblNaam.Text = "naam"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Location = New System.Drawing.Point(77, 221)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(152, 25)
        Me.lblUsername.TabIndex = 2
        Me.lblUsername.Text = "gebruikersnaam"
        '
        'lblWachtwoord1
        '
        Me.lblWachtwoord1.AutoSize = True
        Me.lblWachtwoord1.Location = New System.Drawing.Point(77, 133)
        Me.lblWachtwoord1.Name = "lblWachtwoord1"
        Me.lblWachtwoord1.Size = New System.Drawing.Size(116, 25)
        Me.lblWachtwoord1.TabIndex = 3
        Me.lblWachtwoord1.Text = "wachtwoord"
        '
        'lblWachtwoord2
        '
        Me.lblWachtwoord2.AutoSize = True
        Me.lblWachtwoord2.Location = New System.Drawing.Point(77, 176)
        Me.lblWachtwoord2.Name = "lblWachtwoord2"
        Me.lblWachtwoord2.Size = New System.Drawing.Size(202, 25)
        Me.lblWachtwoord2.TabIndex = 4
        Me.lblWachtwoord2.Text = "herhaal u wachtwoord"
        '
        'txtVoornaam
        '
        Me.txtVoornaam.Location = New System.Drawing.Point(358, 60)
        Me.txtVoornaam.Name = "txtVoornaam"
        Me.txtVoornaam.Size = New System.Drawing.Size(357, 29)
        Me.txtVoornaam.TabIndex = 5
        '
        'txtNaam
        '
        Me.txtNaam.Location = New System.Drawing.Point(358, 95)
        Me.txtNaam.Name = "txtNaam"
        Me.txtNaam.Size = New System.Drawing.Size(357, 29)
        Me.txtNaam.TabIndex = 6
        '
        'txtWachtwoord1
        '
        Me.txtWachtwoord1.Location = New System.Drawing.Point(358, 133)
        Me.txtWachtwoord1.Name = "txtWachtwoord1"
        Me.txtWachtwoord1.Size = New System.Drawing.Size(357, 29)
        Me.txtWachtwoord1.TabIndex = 7
        '
        'txtWachtwoord2
        '
        Me.txtWachtwoord2.Location = New System.Drawing.Point(358, 176)
        Me.txtWachtwoord2.Name = "txtWachtwoord2"
        Me.txtWachtwoord2.Size = New System.Drawing.Size(357, 29)
        Me.txtWachtwoord2.TabIndex = 8
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(358, 221)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(357, 29)
        Me.txtUsername.TabIndex = 9
        '
        'btnRegistreer
        '
        Me.btnRegistreer.Location = New System.Drawing.Point(134, 360)
        Me.btnRegistreer.Name = "btnRegistreer"
        Me.btnRegistreer.Size = New System.Drawing.Size(145, 70)
        Me.btnRegistreer.TabIndex = 10
        Me.btnRegistreer.Text = "registreer"
        Me.btnRegistreer.UseVisualStyleBackColor = True
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(417, 360)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(232, 70)
        Me.btnLogin.TabIndex = 11
        Me.btnLogin.Text = "login indien al een account"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'RadVeganistisch
        '
        Me.RadVeganistisch.AutoSize = True
        Me.RadVeganistisch.Location = New System.Drawing.Point(285, 277)
        Me.RadVeganistisch.Name = "RadVeganistisch"
        Me.RadVeganistisch.Size = New System.Drawing.Size(145, 29)
        Me.RadVeganistisch.TabIndex = 12
        Me.RadVeganistisch.TabStop = True
        Me.RadVeganistisch.Text = "veganistisch"
        Me.RadVeganistisch.UseVisualStyleBackColor = True
        '
        'Radvegitarisch
        '
        Me.Radvegitarisch.AutoSize = True
        Me.Radvegitarisch.Location = New System.Drawing.Point(110, 277)
        Me.Radvegitarisch.Name = "Radvegitarisch"
        Me.Radvegitarisch.Size = New System.Drawing.Size(130, 29)
        Me.Radvegitarisch.TabIndex = 13
        Me.Radvegitarisch.TabStop = True
        Me.Radvegitarisch.Text = "vegitarisch"
        Me.Radvegitarisch.UseVisualStyleBackColor = True
        '
        'radGeen
        '
        Me.radGeen.AutoSize = True
        Me.radGeen.Location = New System.Drawing.Point(462, 277)
        Me.radGeen.Name = "radGeen"
        Me.radGeen.Size = New System.Drawing.Size(175, 29)
        Me.radGeen.TabIndex = 14
        Me.radGeen.TabStop = True
        Me.radGeen.Text = "geen van bijden"
        Me.radGeen.UseVisualStyleBackColor = True
        '
        'registreer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(826, 496)
        Me.Controls.Add(Me.radGeen)
        Me.Controls.Add(Me.Radvegitarisch)
        Me.Controls.Add(Me.RadVeganistisch)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.btnRegistreer)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.txtWachtwoord2)
        Me.Controls.Add(Me.txtWachtwoord1)
        Me.Controls.Add(Me.txtNaam)
        Me.Controls.Add(Me.txtVoornaam)
        Me.Controls.Add(Me.lblWachtwoord2)
        Me.Controls.Add(Me.lblWachtwoord1)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.lblNaam)
        Me.Controls.Add(Me.lblVoornaam)
        Me.Name = "registreer"
        Me.Text = "registreer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblVoornaam As Label
    Friend WithEvents lblNaam As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblWachtwoord1 As Label
    Friend WithEvents lblWachtwoord2 As Label
    Friend WithEvents txtVoornaam As TextBox
    Friend WithEvents txtNaam As TextBox
    Friend WithEvents txtWachtwoord1 As TextBox
    Friend WithEvents txtWachtwoord2 As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents btnRegistreer As Button
    Friend WithEvents btnLogin As Button
    Friend WithEvents RadVeganistisch As RadioButton
    Friend WithEvents Radvegitarisch As RadioButton
    Friend WithEvents radGeen As RadioButton
End Class
