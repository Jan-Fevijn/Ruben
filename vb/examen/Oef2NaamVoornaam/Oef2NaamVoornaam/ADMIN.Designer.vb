<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ADMIN
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
        Me.lblProduct = New System.Windows.Forms.Label()
        Me.lblNaamProduct = New System.Windows.Forms.Label()
        Me.txtNaamProduct = New System.Windows.Forms.TextBox()
        Me.lblHoeveelheid = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.producten = New System.Windows.Forms.ListView()
        Me.numHoeveelheid = New System.Windows.Forms.NumericUpDown()
        Me.btnUitloggen = New System.Windows.Forms.Button()
        CType(Me.numHoeveelheid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblProduct
        '
        Me.lblProduct.AutoSize = True
        Me.lblProduct.Location = New System.Drawing.Point(113, 38)
        Me.lblProduct.Name = "lblProduct"
        Me.lblProduct.Size = New System.Drawing.Size(77, 25)
        Me.lblProduct.TabIndex = 0
        Me.lblProduct.Text = "product"
        '
        'lblNaamProduct
        '
        Me.lblNaamProduct.AutoSize = True
        Me.lblNaamProduct.Location = New System.Drawing.Point(15, 86)
        Me.lblNaamProduct.Name = "lblNaamProduct"
        Me.lblNaamProduct.Size = New System.Drawing.Size(147, 25)
        Me.lblNaamProduct.TabIndex = 1
        Me.lblNaamProduct.Text = "naam product : "
        '
        'txtNaamProduct
        '
        Me.txtNaamProduct.Location = New System.Drawing.Point(168, 83)
        Me.txtNaamProduct.Name = "txtNaamProduct"
        Me.txtNaamProduct.Size = New System.Drawing.Size(174, 29)
        Me.txtNaamProduct.TabIndex = 2
        '
        'lblHoeveelheid
        '
        Me.lblHoeveelheid.AutoSize = True
        Me.lblHoeveelheid.Location = New System.Drawing.Point(26, 139)
        Me.lblHoeveelheid.Name = "lblHoeveelheid"
        Me.lblHoeveelheid.Size = New System.Drawing.Size(118, 25)
        Me.lblHoeveelheid.TabIndex = 3
        Me.lblHoeveelheid.Text = "hoeveelheid"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(68, 185)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(187, 79)
        Me.btnAdd.TabIndex = 5
        Me.btnAdd.Text = "product toevoegen"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'producten
        '
        Me.producten.HideSelection = False
        Me.producten.Location = New System.Drawing.Point(376, 86)
        Me.producten.Name = "producten"
        Me.producten.Size = New System.Drawing.Size(1215, 237)
        Me.producten.TabIndex = 6
        Me.producten.UseCompatibleStateImageBehavior = False
        '
        'numHoeveelheid
        '
        Me.numHoeveelheid.Location = New System.Drawing.Point(169, 137)
        Me.numHoeveelheid.Name = "numHoeveelheid"
        Me.numHoeveelheid.Size = New System.Drawing.Size(172, 29)
        Me.numHoeveelheid.TabIndex = 7
        '
        'btnUitloggen
        '
        Me.btnUitloggen.Location = New System.Drawing.Point(1270, 21)
        Me.btnUitloggen.Name = "btnUitloggen"
        Me.btnUitloggen.Size = New System.Drawing.Size(177, 41)
        Me.btnUitloggen.TabIndex = 8
        Me.btnUitloggen.Text = "uitloggen"
        Me.btnUitloggen.UseVisualStyleBackColor = True
        '
        'ADMIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1663, 450)
        Me.Controls.Add(Me.btnUitloggen)
        Me.Controls.Add(Me.numHoeveelheid)
        Me.Controls.Add(Me.producten)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lblHoeveelheid)
        Me.Controls.Add(Me.txtNaamProduct)
        Me.Controls.Add(Me.lblNaamProduct)
        Me.Controls.Add(Me.lblProduct)
        Me.Name = "ADMIN"
        Me.Text = "ADMIN"
        CType(Me.numHoeveelheid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblProduct As Label
    Friend WithEvents lblNaamProduct As Label
    Friend WithEvents txtNaamProduct As TextBox
    Friend WithEvents lblHoeveelheid As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents producten As ListView
    Friend WithEvents numHoeveelheid As NumericUpDown
    Friend WithEvents btnUitloggen As Button
End Class
