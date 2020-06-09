<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addMuntjes
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
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lblAmount = New System.Windows.Forms.Label()
        Me.muntjes = New System.Windows.Forms.ComboBox()
        Me.numAmount = New System.Windows.Forms.NumericUpDown()
        CType(Me.numAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(79, 139)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(138, 57)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "toevoegen"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'lblAmount
        '
        Me.lblAmount.AutoSize = True
        Me.lblAmount.Location = New System.Drawing.Point(24, 96)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(81, 25)
        Me.lblAmount.TabIndex = 1
        Me.lblAmount.Text = "hoeveel"
        '
        'muntjes
        '
        Me.muntjes.FormattingEnabled = True
        Me.muntjes.Location = New System.Drawing.Point(59, 33)
        Me.muntjes.Name = "muntjes"
        Me.muntjes.Size = New System.Drawing.Size(120, 32)
        Me.muntjes.TabIndex = 2
        '
        'numAmount
        '
        Me.numAmount.Location = New System.Drawing.Point(110, 92)
        Me.numAmount.Name = "numAmount"
        Me.numAmount.Size = New System.Drawing.Size(179, 29)
        Me.numAmount.TabIndex = 3
        '
        'addMuntjes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(337, 219)
        Me.Controls.Add(Me.numAmount)
        Me.Controls.Add(Me.muntjes)
        Me.Controls.Add(Me.lblAmount)
        Me.Controls.Add(Me.btnAdd)
        Me.Name = "addMuntjes"
        Me.Text = "addMuntjes"
        CType(Me.numAmount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAdd As Button
    Friend WithEvents lblAmount As Label
    Friend WithEvents muntjes As ComboBox
    Friend WithEvents numAmount As NumericUpDown
End Class
