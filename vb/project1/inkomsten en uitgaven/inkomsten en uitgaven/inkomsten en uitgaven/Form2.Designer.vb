<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmadminVieuw
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.UitprintenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TxtToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViatxtFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UitloggenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblAdmin = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(28, 28)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UitprintenToolStripMenuItem, Me.ImportToolStripMenuItem, Me.UitloggenToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1582, 38)
        Me.MenuStrip1.TabIndex = 19
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'UitprintenToolStripMenuItem
        '
        Me.UitprintenToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TxtToolStripMenuItem, Me.WordToolStripMenuItem})
        Me.UitprintenToolStripMenuItem.Name = "UitprintenToolStripMenuItem"
        Me.UitprintenToolStripMenuItem.Size = New System.Drawing.Size(91, 34)
        Me.UitprintenToolStripMenuItem.Text = "&printen"
        '
        'TxtToolStripMenuItem
        '
        Me.TxtToolStripMenuItem.Name = "TxtToolStripMenuItem"
        Me.TxtToolStripMenuItem.Size = New System.Drawing.Size(288, 34)
        Me.TxtToolStripMenuItem.Text = "&txt"
        '
        'WordToolStripMenuItem
        '
        Me.WordToolStripMenuItem.Name = "WordToolStripMenuItem"
        Me.WordToolStripMenuItem.Size = New System.Drawing.Size(288, 34)
        Me.WordToolStripMenuItem.Text = "&word"
        '
        'ImportToolStripMenuItem
        '
        Me.ImportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViatxtFileToolStripMenuItem})
        Me.ImportToolStripMenuItem.Name = "ImportToolStripMenuItem"
        Me.ImportToolStripMenuItem.Size = New System.Drawing.Size(86, 34)
        Me.ImportToolStripMenuItem.Text = "&import"
        '
        'ViatxtFileToolStripMenuItem
        '
        Me.ViatxtFileToolStripMenuItem.Name = "ViatxtFileToolStripMenuItem"
        Me.ViatxtFileToolStripMenuItem.Size = New System.Drawing.Size(194, 34)
        Me.ViatxtFileToolStripMenuItem.Text = "via &txt file"
        '
        'UitloggenToolStripMenuItem
        '
        Me.UitloggenToolStripMenuItem.Name = "UitloggenToolStripMenuItem"
        Me.UitloggenToolStripMenuItem.Size = New System.Drawing.Size(113, 34)
        Me.UitloggenToolStripMenuItem.Text = "&uitloggen"
        '
        'lblAdmin
        '
        Me.lblAdmin.AutoSize = True
        Me.lblAdmin.Location = New System.Drawing.Point(759, 207)
        Me.lblAdmin.Name = "lblAdmin"
        Me.lblAdmin.Size = New System.Drawing.Size(76, 25)
        Me.lblAdmin.TabIndex = 20
        Me.lblAdmin.Text = "ADMIN"
        '
        'frmadminVieuw
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1582, 584)
        Me.Controls.Add(Me.lblAdmin)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "frmadminVieuw"
        Me.Text = "admin"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents UitprintenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TxtToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViatxtFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UitloggenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblAdmin As Label
End Class
