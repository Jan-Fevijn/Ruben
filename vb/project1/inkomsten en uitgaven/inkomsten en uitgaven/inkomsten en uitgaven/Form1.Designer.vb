<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInKomstUitgave
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
        Me.list = New System.Windows.Forms.ListView()
        Me.lblLijst = New System.Windows.Forms.Label()
        Me.lblAdd = New System.Windows.Forms.Label()
        Me.lblBuget = New System.Windows.Forms.Label()
        Me.lblCode = New System.Windows.Forms.Label()
        Me.lblInkomstUitgave = New System.Windows.Forms.Label()
        Me.lblBedrag = New System.Windows.Forms.Label()
        Me.lblBeschrijving = New System.Windows.Forms.Label()
        Me.numCode = New System.Windows.Forms.NumericUpDown()
        Me.numBedrag = New System.Windows.Forms.NumericUpDown()
        Me.txtBeschrijving = New System.Windows.Forms.TextBox()
        Me.radInkomst = New System.Windows.Forms.RadioButton()
        Me.radUitgave = New System.Windows.Forms.RadioButton()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.UitprintenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TxtToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViatxtFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UitloggenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.btnLogin = New System.Windows.Forms.Button()
        CType(Me.numCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numBedrag, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'list
        '
        Me.list.HideSelection = False
        Me.list.Location = New System.Drawing.Point(27, 90)
        Me.list.Name = "list"
        Me.list.Size = New System.Drawing.Size(878, 343)
        Me.list.TabIndex = 3
        Me.list.UseCompatibleStateImageBehavior = False
        '
        'lblLijst
        '
        Me.lblLijst.AutoSize = True
        Me.lblLijst.Location = New System.Drawing.Point(393, 26)
        Me.lblLijst.Name = "lblLijst"
        Me.lblLijst.Size = New System.Drawing.Size(202, 25)
        Me.lblLijst.TabIndex = 5
        Me.lblLijst.Text = "lijst van in en uitgaven"
        '
        'lblAdd
        '
        Me.lblAdd.AutoSize = True
        Me.lblAdd.Location = New System.Drawing.Point(1078, 59)
        Me.lblAdd.Name = "lblAdd"
        Me.lblAdd.Size = New System.Drawing.Size(276, 25)
        Me.lblAdd.TabIndex = 6
        Me.lblAdd.Text = "voeg een inkomst / uitgave toe"
        '
        'lblBuget
        '
        Me.lblBuget.AutoSize = True
        Me.lblBuget.Location = New System.Drawing.Point(319, 452)
        Me.lblBuget.Name = "lblBuget"
        Me.lblBuget.Size = New System.Drawing.Size(276, 25)
        Me.lblBuget.TabIndex = 7
        Me.lblBuget.Text = "voeg een inkomst / uitgave toe"
        '
        'lblCode
        '
        Me.lblCode.AutoSize = True
        Me.lblCode.Location = New System.Drawing.Point(983, 106)
        Me.lblCode.Name = "lblCode"
        Me.lblCode.Size = New System.Drawing.Size(55, 25)
        Me.lblCode.TabIndex = 8
        Me.lblCode.Text = "code"
        '
        'lblInkomstUitgave
        '
        Me.lblInkomstUitgave.AutoSize = True
        Me.lblInkomstUitgave.Location = New System.Drawing.Point(983, 165)
        Me.lblInkomstUitgave.Name = "lblInkomstUitgave"
        Me.lblInkomstUitgave.Size = New System.Drawing.Size(158, 25)
        Me.lblInkomstUitgave.TabIndex = 9
        Me.lblInkomstUitgave.Text = "inkomst / uitgave"
        '
        'lblBedrag
        '
        Me.lblBedrag.AutoSize = True
        Me.lblBedrag.Location = New System.Drawing.Point(984, 222)
        Me.lblBedrag.Name = "lblBedrag"
        Me.lblBedrag.Size = New System.Drawing.Size(73, 25)
        Me.lblBedrag.TabIndex = 10
        Me.lblBedrag.Text = "bedrag"
        '
        'lblBeschrijving
        '
        Me.lblBeschrijving.AutoSize = True
        Me.lblBeschrijving.Location = New System.Drawing.Point(983, 272)
        Me.lblBeschrijving.Name = "lblBeschrijving"
        Me.lblBeschrijving.Size = New System.Drawing.Size(115, 25)
        Me.lblBeschrijving.TabIndex = 11
        Me.lblBeschrijving.Text = "beschrijving"
        '
        'numCode
        '
        Me.numCode.Location = New System.Drawing.Point(1172, 102)
        Me.numCode.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.numCode.Name = "numCode"
        Me.numCode.Size = New System.Drawing.Size(136, 29)
        Me.numCode.TabIndex = 12
        '
        'numBedrag
        '
        Me.numBedrag.Location = New System.Drawing.Point(1172, 220)
        Me.numBedrag.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.numBedrag.Name = "numBedrag"
        Me.numBedrag.Size = New System.Drawing.Size(136, 29)
        Me.numBedrag.TabIndex = 13
        '
        'txtBeschrijving
        '
        Me.txtBeschrijving.Location = New System.Drawing.Point(1172, 272)
        Me.txtBeschrijving.Multiline = True
        Me.txtBeschrijving.Name = "txtBeschrijving"
        Me.txtBeschrijving.Size = New System.Drawing.Size(346, 115)
        Me.txtBeschrijving.TabIndex = 14
        '
        'radInkomst
        '
        Me.radInkomst.AutoSize = True
        Me.radInkomst.Location = New System.Drawing.Point(1164, 146)
        Me.radInkomst.Name = "radInkomst"
        Me.radInkomst.Size = New System.Drawing.Size(104, 29)
        Me.radInkomst.TabIndex = 15
        Me.radInkomst.TabStop = True
        Me.radInkomst.Text = "inkomst"
        Me.radInkomst.UseVisualStyleBackColor = True
        '
        'radUitgave
        '
        Me.radUitgave.AutoSize = True
        Me.radUitgave.Location = New System.Drawing.Point(1164, 185)
        Me.radUitgave.Name = "radUitgave"
        Me.radUitgave.Size = New System.Drawing.Size(100, 29)
        Me.radUitgave.TabIndex = 16
        Me.radUitgave.TabStop = True
        Me.radUitgave.Text = "uitgave"
        Me.radUitgave.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(1114, 408)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(240, 56)
        Me.btnAdd.TabIndex = 17
        Me.btnAdd.Text = "add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(28, 28)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UitprintenToolStripMenuItem, Me.ImportToolStripMenuItem, Me.UitloggenToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1587, 38)
        Me.MenuStrip1.TabIndex = 18
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
        Me.TxtToolStripMenuItem.Size = New System.Drawing.Size(150, 34)
        Me.TxtToolStripMenuItem.Text = "&txt"
        '
        'WordToolStripMenuItem
        '
        Me.WordToolStripMenuItem.Name = "WordToolStripMenuItem"
        Me.WordToolStripMenuItem.Size = New System.Drawing.Size(150, 34)
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
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(17, 122)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(220, 29)
        Me.txtPassword.TabIndex = 22
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(12, 64)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(220, 29)
        Me.txtUsername.TabIndex = 20
        '
        'lblPassword
        '
        Me.lblPassword.Location = New System.Drawing.Point(12, 96)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(220, 23)
        Me.lblPassword.TabIndex = 21
        Me.lblPassword.Text = "&Password"
        Me.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblUsername
        '
        Me.lblUsername.Location = New System.Drawing.Point(19, 38)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(220, 23)
        Me.lblUsername.TabIndex = 19
        Me.lblUsername.Text = "&User name"
        Me.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(52, 165)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(109, 86)
        Me.btnLogin.TabIndex = 23
        Me.btnLogin.Text = "ok"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'frmInKomstUitgave
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1587, 486)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.radUitgave)
        Me.Controls.Add(Me.radInkomst)
        Me.Controls.Add(Me.txtBeschrijving)
        Me.Controls.Add(Me.numBedrag)
        Me.Controls.Add(Me.numCode)
        Me.Controls.Add(Me.lblBeschrijving)
        Me.Controls.Add(Me.lblBedrag)
        Me.Controls.Add(Me.lblInkomstUitgave)
        Me.Controls.Add(Me.lblCode)
        Me.Controls.Add(Me.lblBuget)
        Me.Controls.Add(Me.lblAdd)
        Me.Controls.Add(Me.lblLijst)
        Me.Controls.Add(Me.list)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "frmInKomstUitgave"
        Me.Text = "inkomsten en uitgaven"
        CType(Me.numCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numBedrag, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents list As ListView
    Friend WithEvents lblLijst As Label
    Friend WithEvents lblAdd As Label
    Friend WithEvents lblBuget As Label
    Friend WithEvents lblCode As Label
    Friend WithEvents lblInkomstUitgave As Label
    Friend WithEvents lblBedrag As Label
    Friend WithEvents lblBeschrijving As Label
    Friend WithEvents numCode As NumericUpDown
    Friend WithEvents numBedrag As NumericUpDown
    Friend WithEvents txtBeschrijving As TextBox
    Friend WithEvents radInkomst As RadioButton
    Friend WithEvents radUitgave As RadioButton
    Friend WithEvents btnAdd As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents UitprintenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TxtToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents ImportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViatxtFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents UitloggenToolStripMenuItem As ToolStripMenuItem
End Class
