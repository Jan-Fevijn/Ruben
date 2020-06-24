<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lblGabruikersnaam = New System.Windows.Forms.Label()
        Me.lblWachtwoord = New System.Windows.Forms.Label()
        Me.txtGebruikersnaam = New System.Windows.Forms.TextBox()
        Me.txtWachtwoord = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblGabruikersnaam
        '
        Me.lblGabruikersnaam.AutoSize = True
        Me.lblGabruikersnaam.Location = New System.Drawing.Point(25, 30)
        Me.lblGabruikersnaam.Name = "lblGabruikersnaam"
        Me.lblGabruikersnaam.Size = New System.Drawing.Size(152, 25)
        Me.lblGabruikersnaam.TabIndex = 0
        Me.lblGabruikersnaam.Text = "gabruikersnaam"
        '
        'lblWachtwoord
        '
        Me.lblWachtwoord.AutoSize = True
        Me.lblWachtwoord.Location = New System.Drawing.Point(25, 89)
        Me.lblWachtwoord.Name = "lblWachtwoord"
        Me.lblWachtwoord.Size = New System.Drawing.Size(116, 25)
        Me.lblWachtwoord.TabIndex = 1
        Me.lblWachtwoord.Text = "wachtwoord"
        '
        'txtGebruikersnaam
        '
        Me.txtGebruikersnaam.Location = New System.Drawing.Point(197, 30)
        Me.txtGebruikersnaam.Name = "txtGebruikersnaam"
        Me.txtGebruikersnaam.Size = New System.Drawing.Size(157, 29)
        Me.txtGebruikersnaam.TabIndex = 2
        '
        'txtWachtwoord
        '
        Me.txtWachtwoord.Location = New System.Drawing.Point(197, 85)
        Me.txtWachtwoord.Name = "txtWachtwoord"
        Me.txtWachtwoord.Size = New System.Drawing.Size(157, 29)
        Me.txtWachtwoord.TabIndex = 3
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(81, 132)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(172, 107)
        Me.btnLogin.TabIndex = 4
        Me.btnLogin.Text = "Button1"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(366, 266)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.txtWachtwoord)
        Me.Controls.Add(Me.txtGebruikersnaam)
        Me.Controls.Add(Me.lblWachtwoord)
        Me.Controls.Add(Me.lblGabruikersnaam)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblGabruikersnaam As Label
    Friend WithEvents lblWachtwoord As Label
    Friend WithEvents txtGebruikersnaam As TextBox
    Friend WithEvents txtWachtwoord As TextBox
    Friend WithEvents btnLogin As Button
End Class
