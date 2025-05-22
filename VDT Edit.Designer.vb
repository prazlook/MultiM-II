<Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>  _
Partial Public Class VDT_Edit
    Inherits System.Windows.Forms.Form

    Public treeView1 As System.Windows.Forms.TreeView

    Public pictureBox1 As System.Windows.Forms.PictureBox

    Public toolTip1 As System.Windows.Forms.ToolTip

    Public label1 As System.Windows.Forms.Label

    Public Sub New()
        MyBase.New
        Me.InitializeComponent()
    End Sub

    Public Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VDT_Edit))
        Me.treeView1 = New System.Windows.Forms.TreeView()
        Me.label1 = New System.Windows.Forms.Label()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.toolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.button7 = New System.Windows.Forms.Button()
        Me.button13 = New System.Windows.Forms.Button()
        Me.button14 = New System.Windows.Forms.Button()
        Me.button15 = New System.Windows.Forms.Button()
        Me.button16 = New System.Windows.Forms.Button()
        Me.button17 = New System.Windows.Forms.Button()
        Me.button18 = New System.Windows.Forms.Button()
        Me.button19 = New System.Windows.Forms.Button()
        Me.tabPage2 = New System.Windows.Forms.TabPage()
        Me.tabPage1 = New System.Windows.Forms.TabPage()
        Me.KryptonColorButton1 = New Krypton.Toolkit.KryptonColorButton()
        Me.tabControl1 = New System.Windows.Forms.TabControl()
        Me.KryptonContextMenu1 = New Krypton.Toolkit.KryptonContextMenu()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPage2.SuspendLayout()
        Me.tabPage1.SuspendLayout()
        Me.tabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'treeView1
        '
        Me.treeView1.Cursor = System.Windows.Forms.Cursors.Default
        Me.treeView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.treeView1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.treeView1.Location = New System.Drawing.Point(793, 272)
        Me.treeView1.Name = "treeView1"
        Me.treeView1.Size = New System.Drawing.Size(255, 459)
        Me.treeView1.TabIndex = 1
        '
        'label1
        '
        Me.label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.label1.Location = New System.Drawing.Point(808, 245)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(235, 24)
        Me.label1.TabIndex = 2
        Me.label1.Text = "Scénario de chargement"
        Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pictureBox1
        '
        Me.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default
        Me.pictureBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.pictureBox1.Location = New System.Drawing.Point(291, 248)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(485, 485)
        Me.pictureBox1.TabIndex = 3
        Me.pictureBox1.TabStop = False
        '
        'button7
        '
        Me.button7.Cursor = System.Windows.Forms.Cursors.Default
        Me.button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.button7.Location = New System.Drawing.Point(736, 94)
        Me.button7.Name = "button7"
        Me.button7.Size = New System.Drawing.Size(153, 23)
        Me.button7.TabIndex = 7
        Me.button7.Text = "Notification"
        Me.toolTip1.SetToolTip(Me.button7, "Affiche une notification")
        Me.button7.UseVisualStyleBackColor = True
        '
        'button13
        '
        Me.button13.BackgroundImage = CType(resources.GetObject("button13.BackgroundImage"), System.Drawing.Image)
        Me.button13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.button13.Cursor = System.Windows.Forms.Cursors.Default
        Me.button13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.button13.Location = New System.Drawing.Point(556, 6)
        Me.button13.Name = "button13"
        Me.button13.Size = New System.Drawing.Size(153, 23)
        Me.button13.TabIndex = 0
        Me.button13.Text = "Arc-en-ciel"
        Me.toolTip1.SetToolTip(Me.button13, "Génère un arc-en-ciel sur l'écran du Minitel")
        Me.button13.UseVisualStyleBackColor = True
        '
        'button14
        '
        Me.button14.BackgroundImage = CType(resources.GetObject("button14.BackgroundImage"), System.Drawing.Image)
        Me.button14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.button14.Cursor = System.Windows.Forms.Cursors.Default
        Me.button14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.button14.Location = New System.Drawing.Point(556, 36)
        Me.button14.Name = "button14"
        Me.button14.Size = New System.Drawing.Size(153, 23)
        Me.button14.TabIndex = 1
        Me.button14.Text = "Arc-en-ciel avec mouvement"
        Me.toolTip1.SetToolTip(Me.button14, "Génère sur l'écran du Minitel un arc-en-ciel avec du mouvement")
        Me.button14.UseVisualStyleBackColor = True
        '
        'button15
        '
        Me.button15.Cursor = System.Windows.Forms.Cursors.Default
        Me.button15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.button15.Location = New System.Drawing.Point(556, 65)
        Me.button15.Name = "button15"
        Me.button15.Size = New System.Drawing.Size(153, 23)
        Me.button15.TabIndex = 2
        Me.button15.Text = "Défilement"
        Me.toolTip1.SetToolTip(Me.button15, "Fait défiler la page vers le haut ou le bas d'une hauteur définie")
        Me.button15.UseVisualStyleBackColor = True
        '
        'button16
        '
        Me.button16.Cursor = System.Windows.Forms.Cursors.Default
        Me.button16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.button16.Location = New System.Drawing.Point(556, 95)
        Me.button16.Name = "button16"
        Me.button16.Size = New System.Drawing.Size(153, 23)
        Me.button16.TabIndex = 3
        Me.button16.Text = "Carré"
        Me.toolTip1.SetToolTip(Me.button16, "Génère un carré de caractères graphiques qui seront chargés en suivant la forme d" &
        "'un carré")
        Me.button16.UseVisualStyleBackColor = True
        '
        'button17
        '
        Me.button17.Cursor = System.Windows.Forms.Cursors.Default
        Me.button17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.button17.Location = New System.Drawing.Point(556, 125)
        Me.button17.Name = "button17"
        Me.button17.Size = New System.Drawing.Size(153, 23)
        Me.button17.TabIndex = 4
        Me.button17.Text = "Rond"
        Me.toolTip1.SetToolTip(Me.button17, "Génère un rond de caractères graphiques qui seront chargés en suivant la forme d'" &
        "un rond")
        Me.button17.UseVisualStyleBackColor = True
        '
        'button18
        '
        Me.button18.Cursor = System.Windows.Forms.Cursors.Default
        Me.button18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.button18.Location = New System.Drawing.Point(556, 155)
        Me.button18.Name = "button18"
        Me.button18.Size = New System.Drawing.Size(153, 23)
        Me.button18.TabIndex = 5
        Me.button18.Text = "Triangle"
        Me.toolTip1.SetToolTip(Me.button18, "Génère un triangle de caractères graphiques qui seront chargés en suivant la form" &
        "e d'un triangle")
        Me.button18.UseVisualStyleBackColor = True
        '
        'button19
        '
        Me.button19.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.button19.Cursor = System.Windows.Forms.Cursors.Default
        Me.button19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.button19.Location = New System.Drawing.Point(760, 65)
        Me.button19.Name = "button19"
        Me.button19.Size = New System.Drawing.Size(153, 23)
        Me.button19.TabIndex = 6
        Me.button19.Text = "Générer un thème"
        Me.toolTip1.SetToolTip(Me.button19, "Génère des couleurs,des tailles et des formes automatiquement")
        Me.button19.UseVisualStyleBackColor = True
        '
        'tabPage2
        '
        Me.tabPage2.Controls.Add(Me.button18)
        Me.tabPage2.Controls.Add(Me.button19)
        Me.tabPage2.Controls.Add(Me.button17)
        Me.tabPage2.Controls.Add(Me.button16)
        Me.tabPage2.Controls.Add(Me.button7)
        Me.tabPage2.Controls.Add(Me.button15)
        Me.tabPage2.Controls.Add(Me.button13)
        Me.tabPage2.Controls.Add(Me.button14)
        Me.tabPage2.Cursor = System.Windows.Forms.Cursors.Default
        Me.tabPage2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tabPage2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.tabPage2.Location = New System.Drawing.Point(4, 22)
        Me.tabPage2.Name = "tabPage2"
        Me.tabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage2.Size = New System.Drawing.Size(1027, 204)
        Me.tabPage2.TabIndex = 1
        Me.tabPage2.Text = "Effets"
        Me.tabPage2.UseVisualStyleBackColor = True
        '
        'tabPage1
        '
        Me.tabPage1.Controls.Add(Me.GroupBox1)
        Me.tabPage1.Controls.Add(Me.KryptonColorButton1)
        Me.tabPage1.Cursor = System.Windows.Forms.Cursors.Default
        Me.tabPage1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tabPage1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.tabPage1.Location = New System.Drawing.Point(4, 22)
        Me.tabPage1.Name = "tabPage1"
        Me.tabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage1.Size = New System.Drawing.Size(1027, 204)
        Me.tabPage1.TabIndex = 0
        Me.tabPage1.Text = "Contenu"
        Me.tabPage1.UseVisualStyleBackColor = True
        '
        'KryptonColorButton1
        '
        Me.KryptonColorButton1.Location = New System.Drawing.Point(306, 85)
        Me.KryptonColorButton1.Name = "KryptonColorButton1"
        Me.KryptonColorButton1.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010White
        Me.KryptonColorButton1.Size = New System.Drawing.Size(90, 25)
        Me.KryptonColorButton1.TabIndex = 0
        Me.KryptonColorButton1.Values.Image = CType(resources.GetObject("KryptonColorButton1.Values.Image"), System.Drawing.Image)
        Me.KryptonColorButton1.Values.Text = "KryptonColorButton1"
        '
        'tabControl1
        '
        Me.tabControl1.Controls.Add(Me.tabPage1)
        Me.tabControl1.Controls.Add(Me.tabPage2)
        Me.tabControl1.Cursor = System.Windows.Forms.Cursors.Default
        Me.tabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tabControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.tabControl1.Location = New System.Drawing.Point(12, 12)
        Me.tabControl1.Multiline = True
        Me.tabControl1.Name = "tabControl1"
        Me.tabControl1.SelectedIndex = 0
        Me.tabControl1.Size = New System.Drawing.Size(1035, 230)
        Me.tabControl1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(7, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(197, 130)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'VDT_Edit
        '
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.ClientSize = New System.Drawing.Size(1059, 740)
        Me.Controls.Add(Me.pictureBox1)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.treeView1)
        Me.Controls.Add(Me.tabControl1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "VDT_Edit"
        Me.Text = "VDT Edit"
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPage2.ResumeLayout(False)
        Me.tabPage1.ResumeLayout(False)
        Me.tabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Private components As System.ComponentModel.IContainer
    Public WithEvents tabPage2 As TabPage
    Public WithEvents button18 As Button
    Public WithEvents button19 As Button
    Public WithEvents button17 As Button
    Public WithEvents button16 As Button
    Public WithEvents button7 As Button
    Public WithEvents button15 As Button
    Public WithEvents button13 As Button
    Public WithEvents button14 As Button
    Public WithEvents tabPage1 As TabPage
    Public WithEvents tabControl1 As TabControl
    Friend WithEvents KryptonColorButton1 As Krypton.Toolkit.KryptonColorButton
    Friend WithEvents KryptonContextMenu1 As Krypton.Toolkit.KryptonContextMenu
    Friend WithEvents GroupBox1 As GroupBox
End Class
