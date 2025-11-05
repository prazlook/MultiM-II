Partial Public Class VDT_Edit_Lite
    Inherits System.Windows.Forms.Form

    Public treeView1 As System.Windows.Forms.TreeView

    Public toolTip1 As System.Windows.Forms.ToolTip

    Public label2a As System.Windows.Forms.Label

    Public Sub New()
        MyBase.New
        Me.InitializeComponent()
    End Sub

    Public Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VDT_Edit_Lite))
        Me.treeView1 = New System.Windows.Forms.TreeView()
        Me.label2a = New System.Windows.Forms.Label()
        Me.toolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button31 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip2 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip3 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip4 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip5 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip6 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip7 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip8 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip9 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button26 = New System.Windows.Forms.Button()
        Me.PanelEcran = New System.Windows.Forms.Panel()
        Me.PanelValTri = New System.Windows.Forms.Panel()
        Me.ButtonAnnTri = New System.Windows.Forms.Button()
        Me.ButtonValTri = New System.Windows.Forms.Button()
        Me.Button20 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Button21 = New System.Windows.Forms.Button()
        Me.Button22 = New System.Windows.Forms.Button()
        Me.Button23 = New System.Windows.Forms.Button()
        Me.Button24 = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.PanelEcran.SuspendLayout()
        Me.PanelValTri.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'treeView1
        '
        Me.treeView1.Cursor = System.Windows.Forms.Cursors.Default
        Me.treeView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.treeView1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.treeView1.Location = New System.Drawing.Point(827, 261)
        Me.treeView1.Name = "treeView1"
        Me.treeView1.Size = New System.Drawing.Size(293, 622)
        Me.treeView1.TabIndex = 1
        Me.ToolTip9.SetToolTip(Me.treeView1, "Ici,s'affiche l'ordre dans lequel les éléments de l'écran vont s'afficher")
        '
        'label2a
        '
        Me.label2a.Cursor = System.Windows.Forms.Cursors.Default
        Me.label2a.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.label2a.Location = New System.Drawing.Point(826, 229)
        Me.label2a.Name = "label2a"
        Me.label2a.Size = New System.Drawing.Size(300, 29)
        Me.label2a.TabIndex = 2
        Me.label2a.Text = "Scénario de chargement"
        Me.label2a.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'toolTip1
        '
        Me.toolTip1.AutoPopDelay = 1000000000
        Me.toolTip1.BackColor = System.Drawing.Color.Black
        Me.toolTip1.ForeColor = System.Drawing.Color.White
        Me.toolTip1.InitialDelay = 500
        Me.toolTip1.ReshowDelay = 100
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Black
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(11, 22)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(81, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Noir,0%"
        Me.toolTip1.SetToolTip(Me.Button2, "Affichera une couleur noire")
        Me.Button2.UseVisualStyleBackColor = False
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.GroupBox2)
        Me.GroupBox7.Controls.Add(Me.Button10)
        Me.GroupBox7.Controls.Add(Me.Button2)
        Me.GroupBox7.Controls.Add(Me.Button8)
        Me.GroupBox7.Controls.Add(Me.Button4)
        Me.GroupBox7.Controls.Add(Me.Button3)
        Me.GroupBox7.Controls.Add(Me.Button6)
        Me.GroupBox7.Controls.Add(Me.Button5)
        Me.GroupBox7.Controls.Add(Me.Button9)
        Me.GroupBox7.Location = New System.Drawing.Point(371, 12)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(189, 211)
        Me.GroupBox7.TabIndex = 4
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Couleur"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RadioButton2)
        Me.GroupBox2.Controls.Add(Me.RadioButton1)
        Me.GroupBox2.Location = New System.Drawing.Point(11, 136)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(168, 49)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Mode"
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(73, 19)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(85, 17)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.Text = "Noir et blanc"
        Me.ToolTip9.SetToolTip(Me.RadioButton2, "Affichera les couleurs comme sur un Minitel noir et blanc classique")
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(6, 19)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(61, 17)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Couleur"
        Me.ToolTip9.SetToolTip(Me.RadioButton1, "Affiche les couleurs comme sur un Minitel couleur,par exemple" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "le CFZ de chez la " &
        "Radiotechnique,un émulateur,un chauffe-plat" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ou encore un Minitel 2 couleur Phil" &
        "ips")
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.Color.White
        Me.Button10.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button10.Location = New System.Drawing.Point(98, 109)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(81, 23)
        Me.Button10.TabIndex = 8
        Me.Button10.Text = "Blanc,100%"
        Me.ToolTip8.SetToolTip(Me.Button10, "Sur un écran noir et blanc,affichera 100% de l'échelle de noir et blanc.Sur un éc" &
        "ran couleur,affichera du blanc.")
        Me.Button10.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.Fuchsia
        Me.Button8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.Button8.Location = New System.Drawing.Point(98, 51)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(81, 23)
        Me.Button8.TabIndex = 6
        Me.Button8.Text = "Magenta,60%"
        Me.ToolTip4.SetToolTip(Me.Button8, "Sur un écran noir et blanc,affichera 60% de l'échelle de noir et blanc.Sur un écr" &
        "an couleur,affichera du magenta.")
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Lime
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.Location = New System.Drawing.Point(11, 80)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(81, 23)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Vert,70%"
        Me.ToolTip5.SetToolTip(Me.Button4, "Sur un écran noir et blanc,affichera 70% de l'échelle de noir et blanc.Sur un écr" &
        "an couleur,affichera du vert.")
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Red
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.Location = New System.Drawing.Point(11, 51)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(81, 23)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Rouge,50%"
        Me.ToolTip3.SetToolTip(Me.Button3, "Sur un écran noir et blanc,affichera 50% de l'échelle de noir et blanc.Sur un écr" &
        "an couleur,affichera du rouge.")
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Blue
        Me.Button6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button6.ForeColor = System.Drawing.Color.White
        Me.Button6.Location = New System.Drawing.Point(98, 22)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(81, 23)
        Me.Button6.TabIndex = 5
        Me.Button6.Text = "Bleu,40%"
        Me.ToolTip2.SetToolTip(Me.Button6, "Sur un écran noir et blanc,affichera 40% de l'échelle de noir et blanc.Sur un écr" &
        "an couleur,affichera du bleu.")
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Yellow
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.Location = New System.Drawing.Point(11, 109)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(81, 23)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Jaune,90%"
        Me.ToolTip7.SetToolTip(Me.Button5, "Sur un écran noir et blanc,affichera 90% de l'échelle de noir et blanc.Sur un écr" &
        "an couleur,affichera du jaune.")
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.Cyan
        Me.Button9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button9.Location = New System.Drawing.Point(98, 80)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(81, 23)
        Me.Button9.TabIndex = 7
        Me.Button9.Text = "Cyan,80%"
        Me.ToolTip6.SetToolTip(Me.Button9, "Sur un écran noir et blanc,affichera 80% de l'échelle de noir et blanc.Sur un écr" &
        "an couleur,affichera du cyan.")
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Button31
        '
        Me.Button31.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button31.Location = New System.Drawing.Point(7, 50)
        Me.Button31.Name = "Button31"
        Me.Button31.Size = New System.Drawing.Size(75, 23)
        Me.Button31.TabIndex = 0
        Me.Button31.Text = "Crayon"
        Me.Button31.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox11)
        Me.GroupBox1.Controls.Add(Me.Button20)
        Me.GroupBox1.Controls.Add(Me.Button31)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Button11)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Button12)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(19, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(346, 211)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Édition"
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Location = New System.Drawing.Point(7, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(98, 25)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Ajouter du texte"
        Me.ToolTip9.SetToolTip(Me.Button1, "Ajoute une barre de texte")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 897)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1132, 22)
        Me.StatusStrip1.TabIndex = 4
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(28, 17)
        Me.ToolStripStatusLabel1.Text = "Prêt"
        '
        'ToolTip2
        '
        Me.ToolTip2.AutoPopDelay = 1000000000
        Me.ToolTip2.BackColor = System.Drawing.Color.Blue
        Me.ToolTip2.ForeColor = System.Drawing.Color.White
        Me.ToolTip2.InitialDelay = 500
        Me.ToolTip2.ReshowDelay = 100
        '
        'ToolTip3
        '
        Me.ToolTip3.AutoPopDelay = 1000000000
        Me.ToolTip3.BackColor = System.Drawing.Color.Red
        Me.ToolTip3.InitialDelay = 500
        Me.ToolTip3.ReshowDelay = 100
        '
        'ToolTip4
        '
        Me.ToolTip4.AutoPopDelay = 1000000000
        Me.ToolTip4.BackColor = System.Drawing.Color.Magenta
        Me.ToolTip4.InitialDelay = 500
        Me.ToolTip4.ReshowDelay = 100
        '
        'ToolTip5
        '
        Me.ToolTip5.AutoPopDelay = 1000000000
        Me.ToolTip5.BackColor = System.Drawing.Color.Lime
        Me.ToolTip5.InitialDelay = 500
        Me.ToolTip5.ReshowDelay = 100
        '
        'ToolTip6
        '
        Me.ToolTip6.AutoPopDelay = 1000000000
        Me.ToolTip6.BackColor = System.Drawing.Color.Aqua
        Me.ToolTip6.InitialDelay = 500
        Me.ToolTip6.ReshowDelay = 100
        '
        'ToolTip7
        '
        Me.ToolTip7.AutoPopDelay = 1000000000
        Me.ToolTip7.BackColor = System.Drawing.Color.Yellow
        Me.ToolTip7.InitialDelay = 500
        Me.ToolTip7.ReshowDelay = 100
        '
        'ToolTip8
        '
        Me.ToolTip8.AutoPopDelay = 1000000000
        Me.ToolTip8.BackColor = System.Drawing.Color.White
        Me.ToolTip8.InitialDelay = 500
        Me.ToolTip8.ReshowDelay = 100
        '
        'Button26
        '
        Me.Button26.BackgroundImage = CType(resources.GetObject("Button26.BackgroundImage"), System.Drawing.Image)
        Me.Button26.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button26.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button26.Location = New System.Drawing.Point(9, 25)
        Me.Button26.Name = "Button26"
        Me.Button26.Size = New System.Drawing.Size(35, 57)
        Me.Button26.TabIndex = 0
        Me.ToolTip9.SetToolTip(Me.Button26, "Lire")
        Me.Button26.UseVisualStyleBackColor = True
        '
        'PanelEcran
        '
        Me.PanelEcran.BackColor = System.Drawing.Color.Black
        Me.PanelEcran.Controls.Add(Me.PanelValTri)
        Me.PanelEcran.Cursor = System.Windows.Forms.Cursors.Cross
        Me.PanelEcran.Location = New System.Drawing.Point(19, 229)
        Me.PanelEcran.Name = "PanelEcran"
        Me.PanelEcran.Size = New System.Drawing.Size(801, 655)
        Me.PanelEcran.TabIndex = 10
        '
        'PanelValTri
        '
        Me.PanelValTri.BackColor = System.Drawing.SystemColors.Control
        Me.PanelValTri.Controls.Add(Me.ButtonAnnTri)
        Me.PanelValTri.Controls.Add(Me.ButtonValTri)
        Me.PanelValTri.Location = New System.Drawing.Point(6, 576)
        Me.PanelValTri.Name = "PanelValTri"
        Me.PanelValTri.Size = New System.Drawing.Size(134, 67)
        Me.PanelValTri.TabIndex = 13
        Me.PanelValTri.Visible = False
        '
        'ButtonAnnTri
        '
        Me.ButtonAnnTri.BackColor = System.Drawing.SystemColors.Control
        Me.ButtonAnnTri.BackgroundImage = CType(resources.GetObject("ButtonAnnTri.BackgroundImage"), System.Drawing.Image)
        Me.ButtonAnnTri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonAnnTri.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonAnnTri.Location = New System.Drawing.Point(69, 3)
        Me.ButtonAnnTri.Name = "ButtonAnnTri"
        Me.ButtonAnnTri.Size = New System.Drawing.Size(60, 60)
        Me.ButtonAnnTri.TabIndex = 5
        Me.ButtonAnnTri.UseVisualStyleBackColor = False
        '
        'ButtonValTri
        '
        Me.ButtonValTri.BackColor = System.Drawing.SystemColors.Control
        Me.ButtonValTri.BackgroundImage = CType(resources.GetObject("ButtonValTri.BackgroundImage"), System.Drawing.Image)
        Me.ButtonValTri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonValTri.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonValTri.Location = New System.Drawing.Point(3, 3)
        Me.ButtonValTri.Name = "ButtonValTri"
        Me.ButtonValTri.Size = New System.Drawing.Size(60, 60)
        Me.ButtonValTri.TabIndex = 4
        Me.ButtonValTri.UseVisualStyleBackColor = False
        '
        'Button20
        '
        Me.Button20.Location = New System.Drawing.Point(9, 82)
        Me.Button20.Name = "Button20"
        Me.Button20.Size = New System.Drawing.Size(156, 23)
        Me.Button20.TabIndex = 6
        Me.Button20.Text = "Exporter l'écran en page VDT"
        Me.Button20.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(266, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Refaire"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(205, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Annuler"
        '
        'Button12
        '
        Me.Button12.BackgroundImage = CType(resources.GetObject("Button12.BackgroundImage"), System.Drawing.Image)
        Me.Button12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button12.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button12.Location = New System.Drawing.Point(260, 19)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(59, 60)
        Me.Button12.TabIndex = 1
        Me.Button12.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.BackgroundImage = CType(resources.GetObject("Button11.BackgroundImage"), System.Drawing.Image)
        Me.Button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button11.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button11.Location = New System.Drawing.Point(195, 19)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(59, 60)
        Me.Button11.TabIndex = 0
        Me.Button11.UseVisualStyleBackColor = True
        '
        'GroupBox11
        '
        Me.GroupBox11.Controls.Add(Me.Button26)
        Me.GroupBox11.Controls.Add(Me.GroupBox5)
        Me.GroupBox11.Location = New System.Drawing.Point(9, 111)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(254, 91)
        Me.GroupBox11.TabIndex = 15
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = "Prévisualisation de la page"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Button21)
        Me.GroupBox5.Controls.Add(Me.Button22)
        Me.GroupBox5.Controls.Add(Me.Button23)
        Me.GroupBox5.Controls.Add(Me.Button24)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(50, 19)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(187, 63)
        Me.GroupBox5.TabIndex = 10
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Vitesse de transmission en BPS"
        '
        'Button21
        '
        Me.Button21.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button21.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Button21.Location = New System.Drawing.Point(6, 19)
        Me.Button21.Name = "Button21"
        Me.Button21.Size = New System.Drawing.Size(36, 34)
        Me.Button21.TabIndex = 10
        Me.Button21.Text = "50"
        Me.Button21.UseVisualStyleBackColor = True
        '
        'Button22
        '
        Me.Button22.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Button22.Location = New System.Drawing.Point(48, 19)
        Me.Button22.Name = "Button22"
        Me.Button22.Size = New System.Drawing.Size(36, 34)
        Me.Button22.TabIndex = 11
        Me.Button22.Text = "400"
        Me.Button22.UseVisualStyleBackColor = True
        '
        'Button23
        '
        Me.Button23.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button23.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!)
        Me.Button23.Location = New System.Drawing.Point(90, 19)
        Me.Button23.Name = "Button23"
        Me.Button23.Size = New System.Drawing.Size(36, 34)
        Me.Button23.TabIndex = 12
        Me.Button23.Text = "1200"
        Me.Button23.UseVisualStyleBackColor = True
        '
        'Button24
        '
        Me.Button24.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button24.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!)
        Me.Button24.Location = New System.Drawing.Point(132, 19)
        Me.Button24.Name = "Button24"
        Me.Button24.Size = New System.Drawing.Size(36, 34)
        Me.Button24.TabIndex = 13
        Me.Button24.Text = "2400"
        Me.Button24.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Location = New System.Drawing.Point(567, 13)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(553, 210)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Aide - Survolez une ccommande pour obtenir de l'aide"
        '
        'VDT_Edit_Lite
        '
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.ClientSize = New System.Drawing.Size(1132, 919)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PanelEcran)
        Me.Controls.Add(Me.label2a)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.treeView1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "VDT_Edit_Lite"
        Me.Text = "VDT Edit Lite"
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.PanelEcran.ResumeLayout(False)
        Me.PanelValTri.ResumeLayout(False)
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private components As System.ComponentModel.IContainer
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Public WithEvents ToolTip2 As ToolTip
    Public WithEvents ToolTip3 As ToolTip
    Public WithEvents ToolTip4 As ToolTip
    Public WithEvents ToolTip5 As ToolTip
    Public WithEvents ToolTip6 As ToolTip
    Public WithEvents ToolTip7 As ToolTip
    Public WithEvents ToolTip8 As ToolTip
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents ToolTip9 As ToolTip
    Friend WithEvents PanelEcran As Panel
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents Button31 As Button
    Friend WithEvents Button26 As Button
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents GroupBox11 As GroupBox
    Friend WithEvents Button11 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button12 As Button
    Friend WithEvents PanelValTri As Panel
    Friend WithEvents ButtonAnnTri As Button
    Friend WithEvents ButtonValTri As Button
    Friend WithEvents Button20 As Button
    Public WithEvents Button21 As Button
    Public WithEvents Button22 As Button
    Public WithEvents Button23 As Button
    Public WithEvents Button24 As Button
    Friend WithEvents GroupBox3 As GroupBox
End Class
