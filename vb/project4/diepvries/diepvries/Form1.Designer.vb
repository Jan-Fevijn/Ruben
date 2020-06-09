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
        Me.lade1 = New System.Windows.Forms.ListView()
        Me.lade2 = New System.Windows.Forms.ListView()
        Me.lade3 = New System.Windows.Forms.ListView()
        Me.lade4 = New System.Windows.Forms.ListView()
        Me.lade5 = New System.Windows.Forms.ListView()
        Me.lade6 = New System.Windows.Forms.ListView()
        Me.SuspendLayout()
        '
        'lade1
        '
        Me.lade1.HideSelection = False
        Me.lade1.Location = New System.Drawing.Point(45, 12)
        Me.lade1.Name = "lade1"
        Me.lade1.Size = New System.Drawing.Size(1746, 155)
        Me.lade1.TabIndex = 47
        Me.lade1.UseCompatibleStateImageBehavior = False
        '
        'lade2
        '
        Me.lade2.HideSelection = False
        Me.lade2.Location = New System.Drawing.Point(45, 180)
        Me.lade2.Name = "lade2"
        Me.lade2.Size = New System.Drawing.Size(1746, 155)
        Me.lade2.TabIndex = 48
        Me.lade2.UseCompatibleStateImageBehavior = False
        '
        'lade3
        '
        Me.lade3.HideSelection = False
        Me.lade3.Location = New System.Drawing.Point(45, 341)
        Me.lade3.Name = "lade3"
        Me.lade3.Size = New System.Drawing.Size(1746, 155)
        Me.lade3.TabIndex = 49
        Me.lade3.UseCompatibleStateImageBehavior = False
        '
        'lade4
        '
        Me.lade4.HideSelection = False
        Me.lade4.Location = New System.Drawing.Point(45, 511)
        Me.lade4.Name = "lade4"
        Me.lade4.Size = New System.Drawing.Size(1746, 155)
        Me.lade4.TabIndex = 50
        Me.lade4.UseCompatibleStateImageBehavior = False
        '
        'lade5
        '
        Me.lade5.HideSelection = False
        Me.lade5.Location = New System.Drawing.Point(45, 681)
        Me.lade5.Name = "lade5"
        Me.lade5.Size = New System.Drawing.Size(1746, 163)
        Me.lade5.TabIndex = 51
        Me.lade5.UseCompatibleStateImageBehavior = False
        '
        'lade6
        '
        Me.lade6.HideSelection = False
        Me.lade6.Location = New System.Drawing.Point(45, 850)
        Me.lade6.Name = "lade6"
        Me.lade6.Size = New System.Drawing.Size(1746, 182)
        Me.lade6.TabIndex = 52
        Me.lade6.UseCompatibleStateImageBehavior = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1924, 1044)
        Me.Controls.Add(Me.lade6)
        Me.Controls.Add(Me.lade5)
        Me.Controls.Add(Me.lade4)
        Me.Controls.Add(Me.lade3)
        Me.Controls.Add(Me.lade2)
        Me.Controls.Add(Me.lade1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lade1 As ListView
    Friend WithEvents lade2 As ListView
    Friend WithEvents lade3 As ListView
    Friend WithEvents lade4 As ListView
    Friend WithEvents lade5 As ListView
    Friend WithEvents lade6 As ListView
End Class
