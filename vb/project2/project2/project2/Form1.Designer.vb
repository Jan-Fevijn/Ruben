<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.lblGebtuikersnaam = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.btnRegistreer = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblGebtuikersnaam
        '
        Me.lblGebtuikersnaam.AutoSize = True
        Me.lblGebtuikersnaam.Location = New System.Drawing.Point(12, 30)
        Me.lblGebtuikersnaam.Name = "lblGebtuikersnaam"
        Me.lblGebtuikersnaam.Size = New System.Drawing.Size(158, 25)
        Me.lblGebtuikersnaam.TabIndex = 0
        Me.lblGebtuikersnaam.Text = "gebruikersnaam:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "wachtwoord"
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(176, 30)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(223, 29)
        Me.txtUsername.TabIndex = 2
        '
        'txtPassword
        '
        Me.txtPassword.AcceptsReturn = True
        Me.txtPassword.Location = New System.Drawing.Point(176, 70)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(223, 29)
        Me.txtPassword.TabIndex = 3
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(47, 122)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(156, 52)
        Me.btnLogin.TabIndex = 4
        Me.btnLogin.Text = "inloggen"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'btnRegistreer
        '
        Me.btnRegistreer.Location = New System.Drawing.Point(243, 122)
        Me.btnRegistreer.Name = "btnRegistreer"
        Me.btnRegistreer.Size = New System.Drawing.Size(156, 52)
        Me.btnRegistreer.TabIndex = 5
        Me.btnRegistreer.Text = "registreer"
        Me.btnRegistreer.UseVisualStyleBackColor = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(447, 206)
        Me.Controls.Add(Me.btnRegistreer)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblGebtuikersnaam)
        Me.Name = "Login"
        Me.Text = "inloggen"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblGebtuikersnaam As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnRegistreer As Button
End Class
