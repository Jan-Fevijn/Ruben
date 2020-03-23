<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addGerecht
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
        Me.lblNaam = New System.Windows.Forms.Label()
        Me.lblusername = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblImg = New System.Windows.Forms.Label()
        Me.txtNaam = New System.Windows.Forms.TextBox()
        Me.txtUrl = New System.Windows.Forms.TextBox()
        Me.radVegan = New System.Windows.Forms.RadioButton()
        Me.radVeganistisch = New System.Windows.Forms.RadioButton()
        Me.radGeen = New System.Windows.Forms.RadioButton()
        Me.btnAddGerecht = New System.Windows.Forms.Button()
        Me.producten = New System.Windows.Forms.ListView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.EventToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToevoegenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerwijderenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WijzigenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GerechtToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WijzigenToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.WijzigenToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.WijzigenToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToevoegenToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerwijderenToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.WijzigenToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LijstenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KoppelingenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblNaam
        '
        Me.lblNaam.AutoSize = True
        Me.lblNaam.Location = New System.Drawing.Point(448, 71)
        Me.lblNaam.Name = "lblNaam"
        Me.lblNaam.Size = New System.Drawing.Size(158, 25)
        Me.lblNaam.TabIndex = 28
        Me.lblNaam.Text = "voornaam  naam"
        '
        'lblusername
        '
        Me.lblusername.AutoSize = True
        Me.lblusername.Location = New System.Drawing.Point(93, 71)
        Me.lblusername.Name = "lblusername"
        Me.lblusername.Size = New System.Drawing.Size(99, 25)
        Me.lblusername.TabIndex = 27
        Me.lblusername.Text = "username"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(862, 114)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(61, 25)
        Me.lblName.TabIndex = 29
        Me.lblName.Text = "naam"
        '
        'lblImg
        '
        Me.lblImg.AutoSize = True
        Me.lblImg.Location = New System.Drawing.Point(839, 170)
        Me.lblImg.Name = "lblImg"
        Me.lblImg.Size = New System.Drawing.Size(128, 25)
        Me.lblImg.TabIndex = 30
        Me.lblImg.Text = "afbeelding url"
        '
        'txtNaam
        '
        Me.txtNaam.Location = New System.Drawing.Point(1023, 114)
        Me.txtNaam.Name = "txtNaam"
        Me.txtNaam.Size = New System.Drawing.Size(197, 29)
        Me.txtNaam.TabIndex = 31
        '
        'txtUrl
        '
        Me.txtUrl.Location = New System.Drawing.Point(1022, 170)
        Me.txtUrl.Name = "txtUrl"
        Me.txtUrl.Size = New System.Drawing.Size(198, 29)
        Me.txtUrl.TabIndex = 32
        '
        'radVegan
        '
        Me.radVegan.AutoSize = True
        Me.radVegan.Location = New System.Drawing.Point(793, 255)
        Me.radVegan.Name = "radVegan"
        Me.radVegan.Size = New System.Drawing.Size(130, 29)
        Me.radVegan.TabIndex = 33
        Me.radVegan.TabStop = True
        Me.radVegan.Text = "vegitarisch"
        Me.radVegan.UseVisualStyleBackColor = True
        '
        'radVeganistisch
        '
        Me.radVeganistisch.AutoSize = True
        Me.radVeganistisch.Location = New System.Drawing.Point(969, 255)
        Me.radVeganistisch.Name = "radVeganistisch"
        Me.radVeganistisch.Size = New System.Drawing.Size(145, 29)
        Me.radVeganistisch.TabIndex = 34
        Me.radVeganistisch.TabStop = True
        Me.radVeganistisch.Text = "veganistisch"
        Me.radVeganistisch.UseVisualStyleBackColor = True
        '
        'radGeen
        '
        Me.radGeen.AutoSize = True
        Me.radGeen.Location = New System.Drawing.Point(1150, 255)
        Me.radGeen.Name = "radGeen"
        Me.radGeen.Size = New System.Drawing.Size(175, 29)
        Me.radGeen.TabIndex = 35
        Me.radGeen.TabStop = True
        Me.radGeen.Text = "geen van bijden"
        Me.radGeen.UseVisualStyleBackColor = True
        '
        'btnAddGerecht
        '
        Me.btnAddGerecht.Location = New System.Drawing.Point(935, 310)
        Me.btnAddGerecht.Name = "btnAddGerecht"
        Me.btnAddGerecht.Size = New System.Drawing.Size(179, 90)
        Me.btnAddGerecht.TabIndex = 36
        Me.btnAddGerecht.Text = "add gerecht"
        Me.btnAddGerecht.UseVisualStyleBackColor = True
        '
        'producten
        '
        Me.producten.HideSelection = False
        Me.producten.Location = New System.Drawing.Point(25, 114)
        Me.producten.Name = "producten"
        Me.producten.Size = New System.Drawing.Size(743, 264)
        Me.producten.TabIndex = 37
        Me.producten.UseCompatibleStateImageBehavior = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(28, 28)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EventToolStripMenuItem, Me.GerechtToolStripMenuItem, Me.ProductToolStripMenuItem, Me.LijstenToolStripMenuItem, Me.KoppelingenToolStripMenuItem, Me.HomeToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1333, 38)
        Me.MenuStrip1.TabIndex = 38
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'EventToolStripMenuItem
        '
        Me.EventToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToevoegenToolStripMenuItem, Me.VerwijderenToolStripMenuItem, Me.WijzigenToolStripMenuItem})
        Me.EventToolStripMenuItem.Name = "EventToolStripMenuItem"
        Me.EventToolStripMenuItem.Size = New System.Drawing.Size(76, 34)
        Me.EventToolStripMenuItem.Text = "&event"
        '
        'ToevoegenToolStripMenuItem
        '
        Me.ToevoegenToolStripMenuItem.Name = "ToevoegenToolStripMenuItem"
        Me.ToevoegenToolStripMenuItem.Size = New System.Drawing.Size(210, 34)
        Me.ToevoegenToolStripMenuItem.Text = "&toevoegen"
        '
        'VerwijderenToolStripMenuItem
        '
        Me.VerwijderenToolStripMenuItem.Name = "VerwijderenToolStripMenuItem"
        Me.VerwijderenToolStripMenuItem.Size = New System.Drawing.Size(210, 34)
        Me.VerwijderenToolStripMenuItem.Text = "&verwijderen"
        '
        'WijzigenToolStripMenuItem
        '
        Me.WijzigenToolStripMenuItem.Name = "WijzigenToolStripMenuItem"
        Me.WijzigenToolStripMenuItem.Size = New System.Drawing.Size(210, 34)
        Me.WijzigenToolStripMenuItem.Text = "&wijzigen"
        '
        'GerechtToolStripMenuItem
        '
        Me.GerechtToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.WijzigenToolStripMenuItem1, Me.WijzigenToolStripMenuItem2, Me.WijzigenToolStripMenuItem4})
        Me.GerechtToolStripMenuItem.Name = "GerechtToolStripMenuItem"
        Me.GerechtToolStripMenuItem.Size = New System.Drawing.Size(95, 34)
        Me.GerechtToolStripMenuItem.Text = "&gerecht"
        '
        'WijzigenToolStripMenuItem1
        '
        Me.WijzigenToolStripMenuItem1.Name = "WijzigenToolStripMenuItem1"
        Me.WijzigenToolStripMenuItem1.Size = New System.Drawing.Size(210, 34)
        Me.WijzigenToolStripMenuItem1.Text = "&toevoegen"
        '
        'WijzigenToolStripMenuItem2
        '
        Me.WijzigenToolStripMenuItem2.Name = "WijzigenToolStripMenuItem2"
        Me.WijzigenToolStripMenuItem2.Size = New System.Drawing.Size(210, 34)
        Me.WijzigenToolStripMenuItem2.Text = "&verwijderen"
        '
        'WijzigenToolStripMenuItem4
        '
        Me.WijzigenToolStripMenuItem4.Name = "WijzigenToolStripMenuItem4"
        Me.WijzigenToolStripMenuItem4.Size = New System.Drawing.Size(210, 34)
        Me.WijzigenToolStripMenuItem4.Text = "&wijzigen"
        '
        'ProductToolStripMenuItem
        '
        Me.ProductToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToevoegenToolStripMenuItem1, Me.VerwijderenToolStripMenuItem1, Me.WijzigenToolStripMenuItem3})
        Me.ProductToolStripMenuItem.Name = "ProductToolStripMenuItem"
        Me.ProductToolStripMenuItem.Size = New System.Drawing.Size(97, 34)
        Me.ProductToolStripMenuItem.Text = "&product"
        '
        'ToevoegenToolStripMenuItem1
        '
        Me.ToevoegenToolStripMenuItem1.Name = "ToevoegenToolStripMenuItem1"
        Me.ToevoegenToolStripMenuItem1.Size = New System.Drawing.Size(210, 34)
        Me.ToevoegenToolStripMenuItem1.Text = "&toevoegen"
        '
        'VerwijderenToolStripMenuItem1
        '
        Me.VerwijderenToolStripMenuItem1.Name = "VerwijderenToolStripMenuItem1"
        Me.VerwijderenToolStripMenuItem1.Size = New System.Drawing.Size(210, 34)
        Me.VerwijderenToolStripMenuItem1.Text = "&verwijderen"
        '
        'WijzigenToolStripMenuItem3
        '
        Me.WijzigenToolStripMenuItem3.Name = "WijzigenToolStripMenuItem3"
        Me.WijzigenToolStripMenuItem3.Size = New System.Drawing.Size(210, 34)
        Me.WijzigenToolStripMenuItem3.Text = "&wijzigen"
        '
        'LijstenToolStripMenuItem
        '
        Me.LijstenToolStripMenuItem.Name = "LijstenToolStripMenuItem"
        Me.LijstenToolStripMenuItem.Size = New System.Drawing.Size(79, 34)
        Me.LijstenToolStripMenuItem.Text = "&lijsten"
        '
        'KoppelingenToolStripMenuItem
        '
        Me.KoppelingenToolStripMenuItem.Name = "KoppelingenToolStripMenuItem"
        Me.KoppelingenToolStripMenuItem.Size = New System.Drawing.Size(139, 34)
        Me.KoppelingenToolStripMenuItem.Text = "koppelingen"
        '
        'HomeToolStripMenuItem
        '
        Me.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
        Me.HomeToolStripMenuItem.Size = New System.Drawing.Size(78, 34)
        Me.HomeToolStripMenuItem.Text = "home"
        '
        'addGerecht
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1333, 421)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.producten)
        Me.Controls.Add(Me.btnAddGerecht)
        Me.Controls.Add(Me.radGeen)
        Me.Controls.Add(Me.radVeganistisch)
        Me.Controls.Add(Me.radVegan)
        Me.Controls.Add(Me.txtUrl)
        Me.Controls.Add(Me.txtNaam)
        Me.Controls.Add(Me.lblImg)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblNaam)
        Me.Controls.Add(Me.lblusername)
        Me.Name = "addGerecht"
        Me.Text = "addGerecht"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNaam As Label
    Friend WithEvents lblusername As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblImg As Label
    Friend WithEvents txtNaam As TextBox
    Friend WithEvents txtUrl As TextBox
    Friend WithEvents radVegan As RadioButton
    Friend WithEvents radVeganistisch As RadioButton
    Friend WithEvents radGeen As RadioButton
    Friend WithEvents btnAddGerecht As Button
    Friend WithEvents producten As ListView
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents EventToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToevoegenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerwijderenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WijzigenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GerechtToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WijzigenToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents WijzigenToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents WijzigenToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents ProductToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToevoegenToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents VerwijderenToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents WijzigenToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents LijstenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KoppelingenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HomeToolStripMenuItem As ToolStripMenuItem
End Class
