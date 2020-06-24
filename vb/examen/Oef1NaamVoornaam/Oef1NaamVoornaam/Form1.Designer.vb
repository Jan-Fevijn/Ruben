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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.lblVak = New System.Windows.Forms.Label()
        Me.listVakken = New System.Windows.Forms.ListBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAanpasbaar = New System.Windows.Forms.Button()
        Me.listLeerlingen = New System.Windows.Forms.ListBox()
        Me.lblLeerlingen = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(56, 191)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 31
        Me.DataGridView1.Size = New System.Drawing.Size(1146, 320)
        Me.DataGridView1.TabIndex = 0
        '
        'lblVak
        '
        Me.lblVak.AutoSize = True
        Me.lblVak.Location = New System.Drawing.Point(77, 9)
        Me.lblVak.Name = "lblVak"
        Me.lblVak.Size = New System.Drawing.Size(91, 25)
        Me.lblVak.TabIndex = 1
        Me.lblVak.Text = "vakken : "
        '
        'listVakken
        '
        Me.listVakken.FormattingEnabled = True
        Me.listVakken.ItemHeight = 24
        Me.listVakken.Location = New System.Drawing.Point(65, 37)
        Me.listVakken.Name = "listVakken"
        Me.listVakken.Size = New System.Drawing.Size(114, 148)
        Me.listVakken.TabIndex = 2
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(557, 60)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(310, 32)
        Me.ComboBox1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(425, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 25)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Label1"
        '
        'btnAanpasbaar
        '
        Me.btnAanpasbaar.Location = New System.Drawing.Point(868, 114)
        Me.btnAanpasbaar.Name = "btnAanpasbaar"
        Me.btnAanpasbaar.Size = New System.Drawing.Size(229, 61)
        Me.btnAanpasbaar.TabIndex = 5
        Me.btnAanpasbaar.Text = "aanpasbaar"
        Me.btnAanpasbaar.UseVisualStyleBackColor = True
        '
        'listLeerlingen
        '
        Me.listLeerlingen.FormattingEnabled = True
        Me.listLeerlingen.ItemHeight = 24
        Me.listLeerlingen.Location = New System.Drawing.Point(207, 37)
        Me.listLeerlingen.Name = "listLeerlingen"
        Me.listLeerlingen.Size = New System.Drawing.Size(169, 148)
        Me.listLeerlingen.TabIndex = 7
        '
        'lblLeerlingen
        '
        Me.lblLeerlingen.AutoSize = True
        Me.lblLeerlingen.Location = New System.Drawing.Point(219, 9)
        Me.lblLeerlingen.Name = "lblLeerlingen"
        Me.lblLeerlingen.Size = New System.Drawing.Size(112, 25)
        Me.lblLeerlingen.TabIndex = 6
        Me.lblLeerlingen.Text = "leerlingen : "
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1299, 529)
        Me.Controls.Add(Me.listLeerlingen)
        Me.Controls.Add(Me.lblLeerlingen)
        Me.Controls.Add(Me.btnAanpasbaar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.listVakken)
        Me.Controls.Add(Me.lblVak)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents lblVak As Label
    Friend WithEvents listVakken As ListBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAanpasbaar As Button
    Friend WithEvents listLeerlingen As ListBox
    Friend WithEvents lblLeerlingen As Label
End Class
