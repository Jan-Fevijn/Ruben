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
        Me.btnHTML = New System.Windows.Forms.Button()
        Me.btnCSS = New System.Windows.Forms.Button()
        Me.btnJS = New System.Windows.Forms.Button()
        Me.btnPHP = New System.Windows.Forms.Button()
        Me.btnVB = New System.Windows.Forms.Button()
        Me.btnMySQL = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnHTML
        '
        Me.btnHTML.Location = New System.Drawing.Point(12, 12)
        Me.btnHTML.Name = "btnHTML"
        Me.btnHTML.Size = New System.Drawing.Size(143, 59)
        Me.btnHTML.TabIndex = 0
        Me.btnHTML.Text = "HTML"
        Me.btnHTML.UseVisualStyleBackColor = True
        '
        'btnCSS
        '
        Me.btnCSS.Location = New System.Drawing.Point(176, 12)
        Me.btnCSS.Name = "btnCSS"
        Me.btnCSS.Size = New System.Drawing.Size(143, 59)
        Me.btnCSS.TabIndex = 1
        Me.btnCSS.Text = "CSS"
        Me.btnCSS.UseVisualStyleBackColor = True
        '
        'btnJS
        '
        Me.btnJS.Location = New System.Drawing.Point(337, 12)
        Me.btnJS.Name = "btnJS"
        Me.btnJS.Size = New System.Drawing.Size(143, 59)
        Me.btnJS.TabIndex = 2
        Me.btnJS.Text = "JS"
        Me.btnJS.UseVisualStyleBackColor = True
        '
        'btnPHP
        '
        Me.btnPHP.Location = New System.Drawing.Point(502, 15)
        Me.btnPHP.Name = "btnPHP"
        Me.btnPHP.Size = New System.Drawing.Size(143, 59)
        Me.btnPHP.TabIndex = 3
        Me.btnPHP.Text = "PHP"
        Me.btnPHP.UseVisualStyleBackColor = True
        '
        'btnVB
        '
        Me.btnVB.Location = New System.Drawing.Point(675, 15)
        Me.btnVB.Name = "btnVB"
        Me.btnVB.Size = New System.Drawing.Size(117, 55)
        Me.btnVB.TabIndex = 4
        Me.btnVB.Text = "VB.NET"
        Me.btnVB.UseVisualStyleBackColor = True
        '
        'btnMySQL
        '
        Me.btnMySQL.Location = New System.Drawing.Point(815, 12)
        Me.btnMySQL.Name = "btnMySQL"
        Me.btnMySQL.Size = New System.Drawing.Size(106, 58)
        Me.btnMySQL.TabIndex = 5
        Me.btnMySQL.Text = "MySQL"
        Me.btnMySQL.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(940, 95)
        Me.Controls.Add(Me.btnMySQL)
        Me.Controls.Add(Me.btnVB)
        Me.Controls.Add(Me.btnPHP)
        Me.Controls.Add(Me.btnJS)
        Me.Controls.Add(Me.btnCSS)
        Me.Controls.Add(Me.btnHTML)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnHTML As Button
    Friend WithEvents btnCSS As Button
    Friend WithEvents btnJS As Button
    Friend WithEvents btnPHP As Button
    Friend WithEvents btnVB As Button
    Friend WithEvents btnMySQL As Button
End Class
