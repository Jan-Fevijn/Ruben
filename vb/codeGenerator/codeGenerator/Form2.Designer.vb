<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMySQL
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
        Me.btnCreateDB = New System.Windows.Forms.Button()
        Me.txtDBnaam = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnCreateTable = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCreateDB
        '
        Me.btnCreateDB.Location = New System.Drawing.Point(223, 12)
        Me.btnCreateDB.Name = "btnCreateDB"
        Me.btnCreateDB.Size = New System.Drawing.Size(193, 45)
        Me.btnCreateDB.TabIndex = 0
        Me.btnCreateDB.Text = "create database"
        Me.btnCreateDB.UseVisualStyleBackColor = True
        '
        'txtDBnaam
        '
        Me.txtDBnaam.Location = New System.Drawing.Point(18, 22)
        Me.txtDBnaam.Name = "txtDBnaam"
        Me.txtDBnaam.Size = New System.Drawing.Size(187, 29)
        Me.txtDBnaam.TabIndex = 1
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(18, 91)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(187, 29)
        Me.TextBox1.TabIndex = 3
        '
        'btnCreateTable
        '
        Me.btnCreateTable.Location = New System.Drawing.Point(223, 91)
        Me.btnCreateTable.Name = "btnCreateTable"
        Me.btnCreateTable.Size = New System.Drawing.Size(193, 45)
        Me.btnCreateTable.TabIndex = 2
        Me.btnCreateTable.Text = "create table"
        Me.btnCreateTable.UseVisualStyleBackColor = True
        '
        'FormMySQL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnCreateTable)
        Me.Controls.Add(Me.txtDBnaam)
        Me.Controls.Add(Me.btnCreateDB)
        Me.Name = "FormMySQL"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCreateDB As Button
    Friend WithEvents txtDBnaam As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnCreateTable As Button
End Class
