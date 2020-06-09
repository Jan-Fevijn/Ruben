<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class changeEvent
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
        Me.txtUrl = New System.Windows.Forms.TextBox()
        Me.txtTot = New System.Windows.Forms.TextBox()
        Me.txtVan = New System.Windows.Forms.TextBox()
        Me.btnAddEvent = New System.Windows.Forms.Button()
        Me.lblUrl = New System.Windows.Forms.Label()
        Me.txtNaam = New System.Windows.Forms.TextBox()
        Me.lblTot = New System.Windows.Forms.Label()
        Me.lblVan = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.eventen = New System.Windows.Forms.ListView()
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
        Me.lblNaam.Location = New System.Drawing.Point(630, 68)
        Me.lblNaam.Name = "lblNaam"
        Me.lblNaam.Size = New System.Drawing.Size(158, 25)
        Me.lblNaam.TabIndex = 28
        Me.lblNaam.Text = "voornaam  naam"
        '
        'lblusername
        '
        Me.lblusername.AutoSize = True
        Me.lblusername.Location = New System.Drawing.Point(23, 68)
        Me.lblusername.Name = "lblusername"
        Me.lblusername.Size = New System.Drawing.Size(99, 25)
        Me.lblusername.TabIndex = 27
        Me.lblusername.Text = "username"
        '
        'txtUrl
        '
        Me.txtUrl.Location = New System.Drawing.Point(995, 278)
        Me.txtUrl.Name = "txtUrl"
        Me.txtUrl.Size = New System.Drawing.Size(158, 29)
        Me.txtUrl.TabIndex = 74
        '
        'txtTot
        '
        Me.txtTot.Location = New System.Drawing.Point(995, 232)
        Me.txtTot.Name = "txtTot"
        Me.txtTot.Size = New System.Drawing.Size(158, 29)
        Me.txtTot.TabIndex = 73
        '
        'txtVan
        '
        Me.txtVan.Location = New System.Drawing.Point(995, 178)
        Me.txtVan.Name = "txtVan"
        Me.txtVan.Size = New System.Drawing.Size(158, 29)
        Me.txtVan.TabIndex = 72
        '
        'btnAddEvent
        '
        Me.btnAddEvent.Location = New System.Drawing.Point(886, 340)
        Me.btnAddEvent.Name = "btnAddEvent"
        Me.btnAddEvent.Size = New System.Drawing.Size(186, 71)
        Me.btnAddEvent.TabIndex = 71
        Me.btnAddEvent.Text = "add event"
        Me.btnAddEvent.UseVisualStyleBackColor = True
        '
        'lblUrl
        '
        Me.lblUrl.AutoSize = True
        Me.lblUrl.Location = New System.Drawing.Point(809, 281)
        Me.lblUrl.Name = "lblUrl"
        Me.lblUrl.Size = New System.Drawing.Size(128, 25)
        Me.lblUrl.TabIndex = 70
        Me.lblUrl.Text = "afbeelding url"
        '
        'txtNaam
        '
        Me.txtNaam.Location = New System.Drawing.Point(995, 132)
        Me.txtNaam.Name = "txtNaam"
        Me.txtNaam.Size = New System.Drawing.Size(158, 29)
        Me.txtNaam.TabIndex = 69
        '
        'lblTot
        '
        Me.lblTot.AutoSize = True
        Me.lblTot.Location = New System.Drawing.Point(809, 236)
        Me.lblTot.Name = "lblTot"
        Me.lblTot.Size = New System.Drawing.Size(33, 25)
        Me.lblTot.TabIndex = 68
        Me.lblTot.Text = "tot"
        '
        'lblVan
        '
        Me.lblVan.AutoSize = True
        Me.lblVan.Location = New System.Drawing.Point(809, 182)
        Me.lblVan.Name = "lblVan"
        Me.lblVan.Size = New System.Drawing.Size(44, 25)
        Me.lblVan.TabIndex = 67
        Me.lblVan.Text = "van"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(809, 132)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(61, 25)
        Me.lblName.TabIndex = 66
        Me.lblName.Text = "naam"
        '
        'eventen
        '
        Me.eventen.HideSelection = False
        Me.eventen.Location = New System.Drawing.Point(45, 111)
        Me.eventen.Name = "eventen"
        Me.eventen.Size = New System.Drawing.Size(743, 324)
        Me.eventen.TabIndex = 65
        Me.eventen.UseCompatibleStateImageBehavior = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(28, 28)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EventToolStripMenuItem, Me.GerechtToolStripMenuItem, Me.ProductToolStripMenuItem, Me.LijstenToolStripMenuItem, Me.KoppelingenToolStripMenuItem, Me.HomeToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1216, 38)
        Me.MenuStrip1.TabIndex = 75
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
        'changeEvent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1216, 481)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.txtUrl)
        Me.Controls.Add(Me.txtTot)
        Me.Controls.Add(Me.txtVan)
        Me.Controls.Add(Me.btnAddEvent)
        Me.Controls.Add(Me.lblUrl)
        Me.Controls.Add(Me.txtNaam)
        Me.Controls.Add(Me.lblTot)
        Me.Controls.Add(Me.lblVan)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.eventen)
        Me.Controls.Add(Me.lblNaam)
        Me.Controls.Add(Me.lblusername)
        Me.Name = "changeEvent"
        Me.Text = "changeEvent"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNaam As Label
    Friend WithEvents lblusername As Label
    Friend WithEvents txtUrl As TextBox
    Friend WithEvents txtTot As TextBox
    Friend WithEvents txtVan As TextBox
    Friend WithEvents btnAddEvent As Button
    Friend WithEvents lblUrl As Label
    Friend WithEvents txtNaam As TextBox
    Friend WithEvents lblTot As Label
    Friend WithEvents lblVan As Label
    Friend WithEvents lblName As Label
    Friend WithEvents eventen As ListView
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
