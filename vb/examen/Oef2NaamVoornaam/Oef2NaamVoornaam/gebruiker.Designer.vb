<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class gebruiker
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
        Me.comboProducten = New System.Windows.Forms.ComboBox()
        Me.lblproducten = New System.Windows.Forms.Label()
        Me.btnBestellen = New System.Windows.Forms.Button()
        Me.btnUitloggen = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'comboProducten
        '
        Me.comboProducten.FormattingEnabled = True
        Me.comboProducten.Location = New System.Drawing.Point(124, 43)
        Me.comboProducten.Name = "comboProducten"
        Me.comboProducten.Size = New System.Drawing.Size(126, 32)
        Me.comboProducten.TabIndex = 0
        '
        'lblproducten
        '
        Me.lblproducten.AutoSize = True
        Me.lblproducten.Location = New System.Drawing.Point(12, 43)
        Me.lblproducten.Name = "lblproducten"
        Me.lblproducten.Size = New System.Drawing.Size(93, 25)
        Me.lblproducten.TabIndex = 1
        Me.lblproducten.Text = "product : "
        '
        'btnBestellen
        '
        Me.btnBestellen.Location = New System.Drawing.Point(273, 43)
        Me.btnBestellen.Name = "btnBestellen"
        Me.btnBestellen.Size = New System.Drawing.Size(163, 45)
        Me.btnBestellen.TabIndex = 2
        Me.btnBestellen.Text = "bestellen"
        Me.btnBestellen.UseVisualStyleBackColor = True
        '
        'btnUitloggen
        '
        Me.btnUitloggen.Location = New System.Drawing.Point(275, 8)
        Me.btnUitloggen.Name = "btnUitloggen"
        Me.btnUitloggen.Size = New System.Drawing.Size(160, 35)
        Me.btnUitloggen.TabIndex = 3
        Me.btnUitloggen.Text = "uitloggen"
        Me.btnUitloggen.UseVisualStyleBackColor = True
        '
        'gebruiker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(458, 100)
        Me.Controls.Add(Me.btnUitloggen)
        Me.Controls.Add(Me.btnBestellen)
        Me.Controls.Add(Me.lblproducten)
        Me.Controls.Add(Me.comboProducten)
        Me.Name = "gebruiker"
        Me.Text = "gebruiker"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents comboProducten As ComboBox
    Friend WithEvents lblproducten As Label
    Friend WithEvents btnBestellen As Button
    Friend WithEvents btnUitloggen As Button
End Class
