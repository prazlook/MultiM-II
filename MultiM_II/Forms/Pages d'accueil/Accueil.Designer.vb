<Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class Accueil
    Inherits System.Windows.Forms.Form

    Public label1 As System.Windows.Forms.Label

    Public WithEvents button5 As System.Windows.Forms.Button

    Public WithEvents button6 As System.Windows.Forms.Button

    Public WithEvents button7 As System.Windows.Forms.Button

    Public WithEvents button8 As System.Windows.Forms.Button

    Public WithEvents button9 As System.Windows.Forms.Button

    Public WithEvents button10 As System.Windows.Forms.Button

    Public WithEvents button11 As System.Windows.Forms.Button

    Public WithEvents button12 As System.Windows.Forms.Button

    Public WithEvents button15 As System.Windows.Forms.Button

    Public WithEvents button16 As System.Windows.Forms.Button

    Public toolTip1 As System.Windows.Forms.ToolTip

    Public toolTip4 As System.Windows.Forms.ToolTip

    Public toolTip2 As System.Windows.Forms.ToolTip

    Public toolTip5 As System.Windows.Forms.ToolTip

    Public toolTip3 As System.Windows.Forms.ToolTip

    Public WithEvents button14 As System.Windows.Forms.Button

    Public WithEvents button17 As System.Windows.Forms.Button

    Public WithEvents button18 As System.Windows.Forms.Button

    Public toolTip7 As System.Windows.Forms.ToolTip

    Public toolTip6 As System.Windows.Forms.ToolTip

    Public WithEvents button19 As System.Windows.Forms.Button

    Public label2 As System.Windows.Forms.Label

    Public Sub New()
        MyBase.New
        Me.InitializeComponent()
        ' Ajout des gestionnaires d'événements pour les boutons les plus importants
        AddHandler button1.Click, AddressOf button1_Click
        AddHandler button2.Click, AddressOf button2_Click
        AddHandler button3.Click, AddressOf button3_Click
        AddHandler button4.Click, AddressOf button4_Click
        AddHandler button5.Click, AddressOf button5_Click
        AddHandler button14.Click, AddressOf button14_Click

    End Sub

    Public Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Accueil))
        Me.label1 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.button5 = New System.Windows.Forms.Button()
        Me.button6 = New System.Windows.Forms.Button()
        Me.button7 = New System.Windows.Forms.Button()
        Me.button8 = New System.Windows.Forms.Button()
        Me.button9 = New System.Windows.Forms.Button()
        Me.button10 = New System.Windows.Forms.Button()
        Me.button11 = New System.Windows.Forms.Button()
        Me.button12 = New System.Windows.Forms.Button()
        Me.button15 = New System.Windows.Forms.Button()
        Me.button16 = New System.Windows.Forms.Button()
        Me.toolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.button1 = New Krypton.Toolkit.KryptonButton()
        Me.button2 = New Krypton.Toolkit.KryptonButton()
        Me.button3 = New Krypton.Toolkit.KryptonButton()
        Me.button4 = New Krypton.Toolkit.KryptonButton()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Button20 = New System.Windows.Forms.Button()
        Me.toolTip2 = New System.Windows.Forms.ToolTip(Me.components)
        Me.toolTip3 = New System.Windows.Forms.ToolTip(Me.components)
        Me.toolTip4 = New System.Windows.Forms.ToolTip(Me.components)
        Me.toolTip5 = New System.Windows.Forms.ToolTip(Me.components)
        Me.button14 = New System.Windows.Forms.Button()
        Me.button17 = New System.Windows.Forms.Button()
        Me.button18 = New System.Windows.Forms.Button()
        Me.toolTip6 = New System.Windows.Forms.ToolTip(Me.components)
        Me.toolTip7 = New System.Windows.Forms.ToolTip(Me.components)
        Me.button19 = New System.Windows.Forms.Button()
        Me.KryptonPalette1 = New ComponentFactory.Krypton.Toolkit.KryptonPalette(Me.components)
        Me.Button21 = New System.Windows.Forms.Button()
        Me.Button22 = New System.Windows.Forms.Button()
        Me.Button23 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'label1
        '
        Me.label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Underline)
        Me.label1.Location = New System.Drawing.Point(12, 9)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(318, 42)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Bienvenue dans MultiM II"
        '
        'label2
        '
        Me.label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.label2.Font = New System.Drawing.Font("Consolas", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(12, 51)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(304, 49)
        Me.label2.TabIndex = 1
        Me.label2.Text = "Faites votre choix parmi les nombreuses options proposées"
        '
        'button5
        '
        Me.button5.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.button5.Location = New System.Drawing.Point(208, 322)
        Me.button5.Name = "button5"
        Me.button5.Size = New System.Drawing.Size(190, 50)
        Me.button5.TabIndex = 6
        Me.button5.Text = "Aide"
        Me.toolTip4.SetToolTip(Me.button5, "Désolé,pas encore disponible")
        Me.button5.UseVisualStyleBackColor = False
        '
        'button6
        '
        Me.button6.BackColor = System.Drawing.Color.RosyBrown
        Me.button6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.button6.Location = New System.Drawing.Point(12, 546)
        Me.button6.Name = "button6"
        Me.button6.Size = New System.Drawing.Size(190, 50)
        Me.button6.TabIndex = 7
        Me.button6.Text = "Paramètres"
        Me.toolTip3.SetToolTip(Me.button6, "Désolé,pas encore disponible")
        Me.button6.UseVisualStyleBackColor = False
        '
        'button7
        '
        Me.button7.BackColor = System.Drawing.Color.RosyBrown
        Me.button7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.button7.Location = New System.Drawing.Point(12, 490)
        Me.button7.Name = "button7"
        Me.button7.Size = New System.Drawing.Size(190, 50)
        Me.button7.TabIndex = 8
        Me.button7.Text = "Mises à Jour"
        Me.toolTip3.SetToolTip(Me.button7, "Désolé,pas encore disponible")
        Me.button7.UseVisualStyleBackColor = False
        '
        'button8
        '
        Me.button8.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.button8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.button8.Location = New System.Drawing.Point(210, 434)
        Me.button8.Name = "button8"
        Me.button8.Size = New System.Drawing.Size(190, 50)
        Me.button8.TabIndex = 9
        Me.button8.Text = "Réclamations"
        Me.toolTip4.SetToolTip(Me.button8, "Désolé,pas encore disponible")
        Me.button8.UseVisualStyleBackColor = False
        '
        'button9
        '
        Me.button9.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.button9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.button9.Location = New System.Drawing.Point(208, 210)
        Me.button9.Name = "button9"
        Me.button9.Size = New System.Drawing.Size(190, 50)
        Me.button9.TabIndex = 10
        Me.button9.Text = "Histoire"
        Me.toolTip4.SetToolTip(Me.button9, "Désolé,pas encore disponible")
        Me.button9.UseVisualStyleBackColor = False
        '
        'button10
        '
        Me.button10.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.button10.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.button10.Location = New System.Drawing.Point(208, 266)
        Me.button10.Name = "button10"
        Me.button10.Size = New System.Drawing.Size(190, 50)
        Me.button10.TabIndex = 11
        Me.button10.Text = "Crédits"
        Me.toolTip4.SetToolTip(Me.button10, "Désolé,pas encore disponible")
        Me.button10.UseVisualStyleBackColor = False
        '
        'button11
        '
        Me.button11.BackColor = System.Drawing.SystemColors.HotTrack
        Me.button11.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.button11.Location = New System.Drawing.Point(12, 378)
        Me.button11.Name = "button11"
        Me.button11.Size = New System.Drawing.Size(190, 50)
        Me.button11.TabIndex = 12
        Me.button11.Text = "Emulatel"
        Me.toolTip1.SetToolTip(Me.button11, "Émulateur de MultiM II, le plus performant et proche d'un véritable Minitel car n" &
        "i plus ni moins basé sur le programme original inclus dans un Minitel")
        Me.button11.UseVisualStyleBackColor = False
        '
        'button12
        '
        Me.button12.BackColor = System.Drawing.SystemColors.HotTrack
        Me.button12.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.button12.Location = New System.Drawing.Point(12, 434)
        Me.button12.Name = "button12"
        Me.button12.Size = New System.Drawing.Size(190, 50)
        Me.button12.TabIndex = 13
        Me.button12.Text = "Database"
        Me.toolTip1.SetToolTip(Me.button12, "Base de données contenant une précieuse documentation sur le Minitel, le développ" &
        "ement de MultiM II, etc.")
        Me.button12.UseVisualStyleBackColor = False
        '
        'button15
        '
        Me.button15.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.button15.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.button15.Location = New System.Drawing.Point(208, 378)
        Me.button15.Name = "button15"
        Me.button15.Size = New System.Drawing.Size(190, 50)
        Me.button15.TabIndex = 17
        Me.button15.Text = "Contact"
        Me.toolTip4.SetToolTip(Me.button15, "Désolé,pas encore disponible")
        Me.button15.UseVisualStyleBackColor = False
        '
        'button16
        '
        Me.button16.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.button16.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.button16.Location = New System.Drawing.Point(208, 154)
        Me.button16.Name = "button16"
        Me.button16.Size = New System.Drawing.Size(190, 50)
        Me.button16.TabIndex = 18
        Me.button16.Text = "Forum"
        Me.toolTip4.SetToolTip(Me.button16, "Désolé,pas encore disponible")
        Me.button16.UseVisualStyleBackColor = False
        '
        'toolTip1
        '
        Me.toolTip1.AutoPopDelay = 5000
        Me.toolTip1.BackColor = System.Drawing.SystemColors.Highlight
        Me.toolTip1.InitialDelay = 0
        Me.toolTip1.ReshowDelay = 100
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(12, 154)
        Me.button1.Name = "button1"
        Me.button1.PaletteMode = Krypton.Toolkit.PaletteMode.VisualStudio2010Render2007
        Me.button1.Size = New System.Drawing.Size(190, 50)
        Me.button1.StateCommon.Back.Color1 = System.Drawing.SystemColors.Highlight
        Me.button1.StateCommon.Back.Color2 = System.Drawing.SystemColors.Highlight
        Me.button1.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button1.TabIndex = 24
        Me.toolTip1.SetToolTip(Me.button1, "VDT Edit est un éditeur de pages vidéotex vous permettant de créer de pages Minit" &
        "el")
        Me.button1.Values.DropDownArrowColor = System.Drawing.Color.Empty
        Me.button1.Values.Text = "VDT Edit"
        '
        'button2
        '
        Me.button2.Location = New System.Drawing.Point(12, 210)
        Me.button2.Name = "button2"
        Me.button2.PaletteMode = Krypton.Toolkit.PaletteMode.VisualStudio2010Render2007
        Me.button2.Size = New System.Drawing.Size(190, 50)
        Me.button2.StateCommon.Back.Color1 = System.Drawing.SystemColors.Highlight
        Me.button2.StateCommon.Back.Color2 = System.Drawing.SystemColors.Highlight
        Me.button2.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button2.TabIndex = 25
        Me.toolTip1.SetToolTip(Me.button2, "VDT Pics vous permet de convertir une image en page vidéotex")
        Me.button2.Values.DropDownArrowColor = System.Drawing.Color.Empty
        Me.button2.Values.Text = "VDT Pics"
        '
        'button3
        '
        Me.button3.Location = New System.Drawing.Point(12, 266)
        Me.button3.Name = "button3"
        Me.button3.PaletteMode = Krypton.Toolkit.PaletteMode.VisualStudio2010Render2007
        Me.button3.Size = New System.Drawing.Size(190, 50)
        Me.button3.StateCommon.Back.Color1 = System.Drawing.SystemColors.Highlight
        Me.button3.StateCommon.Back.Color2 = System.Drawing.SystemColors.Highlight
        Me.button3.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button3.TabIndex = 26
        Me.toolTip1.SetToolTip(Me.button3, "ArboEdit est l'éditeur d'arborescence qui sert à concevoir")
        Me.button3.Values.DropDownArrowColor = System.Drawing.Color.Empty
        Me.button3.Values.Text = "ArboEdit"
        '
        'button4
        '
        Me.button4.Location = New System.Drawing.Point(12, 322)
        Me.button4.Name = "button4"
        Me.button4.PaletteMode = Krypton.Toolkit.PaletteMode.VisualStudio2010Render2007
        Me.button4.Size = New System.Drawing.Size(190, 50)
        Me.button4.StateCommon.Back.Color1 = System.Drawing.SystemColors.Highlight
        Me.button4.StateCommon.Back.Color2 = System.Drawing.SystemColors.Highlight
        Me.button4.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button4.TabIndex = 27
        Me.toolTip1.SetToolTip(Me.button4, "Pupitre de commande de votre serveur et compileur")
        Me.button4.Values.DropDownArrowColor = System.Drawing.Color.Empty
        Me.button4.Values.Text = "Compistart"
        '
        'Button13
        '
        Me.Button13.BackColor = System.Drawing.Color.ForestGreen
        Me.Button13.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Button13.Location = New System.Drawing.Point(208, 546)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(190, 50)
        Me.Button13.TabIndex = 28
        Me.Button13.Text = "Réalisation Serveur"
        Me.toolTip2.SetToolTip(Me.Button13, "Désolé,pas encore disponible")
        Me.Button13.UseVisualStyleBackColor = False
        '
        'Button20
        '
        Me.Button20.BackColor = System.Drawing.Color.ForestGreen
        Me.Button20.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button20.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Button20.Location = New System.Drawing.Point(208, 490)
        Me.Button20.Name = "Button20"
        Me.Button20.Size = New System.Drawing.Size(190, 50)
        Me.Button20.TabIndex = 29
        Me.Button20.Text = "Conception Serveur"
        Me.toolTip2.SetToolTip(Me.Button20, "Désolé,pas encore disponible")
        Me.Button20.UseVisualStyleBackColor = False
        '
        'toolTip2
        '
        Me.toolTip2.AutoPopDelay = 5000
        Me.toolTip2.BackColor = System.Drawing.Color.ForestGreen
        Me.toolTip2.InitialDelay = 0
        Me.toolTip2.ReshowDelay = 100
        '
        'toolTip3
        '
        Me.toolTip3.AutoPopDelay = 5000
        Me.toolTip3.BackColor = System.Drawing.Color.RosyBrown
        Me.toolTip3.InitialDelay = 0
        Me.toolTip3.ReshowDelay = 100
        '
        'toolTip4
        '
        Me.toolTip4.AutoPopDelay = 5000
        Me.toolTip4.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.toolTip4.InitialDelay = 0
        Me.toolTip4.ReshowDelay = 100
        '
        'toolTip5
        '
        Me.toolTip5.AutoPopDelay = 5000
        Me.toolTip5.BackColor = System.Drawing.Color.Lime
        Me.toolTip5.InitialDelay = 0
        Me.toolTip5.IsBalloon = True
        Me.toolTip5.ReshowDelay = 100
        Me.toolTip5.ToolTipTitle = "Revenir à l'accueil"
        '
        'button14
        '
        Me.button14.BackgroundImage = CType(resources.GetObject("button14.BackgroundImage"), System.Drawing.Image)
        Me.button14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.button14.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.button14.Location = New System.Drawing.Point(132, 103)
        Me.button14.Name = "button14"
        Me.button14.Size = New System.Drawing.Size(46, 45)
        Me.button14.TabIndex = 20
        Me.toolTip7.SetToolTip(Me.button14, "Fermer le logiciel")
        Me.button14.UseVisualStyleBackColor = True
        '
        'button17
        '
        Me.button17.BackgroundImage = CType(resources.GetObject("button17.BackgroundImage"), System.Drawing.Image)
        Me.button17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.button17.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.button17.Location = New System.Drawing.Point(24, 102)
        Me.button17.Name = "button17"
        Me.button17.Size = New System.Drawing.Size(50, 45)
        Me.button17.TabIndex = 21
        Me.toolTip6.SetToolTip(Me.button17, "Se connecter")
        Me.button17.UseVisualStyleBackColor = True
        '
        'button18
        '
        Me.button18.BackgroundImage = CType(resources.GetObject("button18.BackgroundImage"), System.Drawing.Image)
        Me.button18.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.button18.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.button18.Location = New System.Drawing.Point(80, 103)
        Me.button18.Name = "button18"
        Me.button18.Size = New System.Drawing.Size(46, 45)
        Me.button18.TabIndex = 22
        Me.toolTip6.SetToolTip(Me.button18, "Créer un compte")
        Me.button18.UseVisualStyleBackColor = True
        '
        'toolTip6
        '
        Me.toolTip6.AutoPopDelay = 5000
        Me.toolTip6.BackColor = System.Drawing.Color.Lime
        Me.toolTip6.InitialDelay = 0
        Me.toolTip6.ReshowDelay = 100
        '
        'toolTip7
        '
        Me.toolTip7.AutoPopDelay = 5000
        Me.toolTip7.BackColor = System.Drawing.Color.Red
        Me.toolTip7.InitialDelay = 0
        Me.toolTip7.ReshowDelay = 100
        '
        'button19
        '
        Me.button19.BackgroundImage = CType(resources.GetObject("button19.BackgroundImage"), System.Drawing.Image)
        Me.button19.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.button19.Cursor = System.Windows.Forms.Cursors.Default
        Me.button19.Enabled = False
        Me.button19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.button19.Location = New System.Drawing.Point(24, 103)
        Me.button19.Name = "button19"
        Me.button19.Size = New System.Drawing.Size(50, 44)
        Me.button19.TabIndex = 23
        Me.toolTip7.SetToolTip(Me.button19, "Se déconnecter")
        Me.button19.UseVisualStyleBackColor = True
        Me.button19.Visible = False
        '
        'Button21
        '
        Me.Button21.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button21.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Button21.Location = New System.Drawing.Point(256, 602)
        Me.Button21.Name = "Button21"
        Me.Button21.Size = New System.Drawing.Size(92, 23)
        Me.Button21.TabIndex = 32
        Me.Button21.Text = "Récents"
        Me.toolTip1.SetToolTip(Me.Button21, "Désolé, pas encore disponible")
        Me.Button21.UseVisualStyleBackColor = False
        '
        'Button22
        '
        Me.Button22.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button22.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Button22.Location = New System.Drawing.Point(163, 602)
        Me.Button22.Name = "Button22"
        Me.Button22.Size = New System.Drawing.Size(87, 23)
        Me.Button22.TabIndex = 31
        Me.Button22.Text = "Ouvrir"
        Me.toolTip1.SetToolTip(Me.Button22, "Désolé, pas encore disponible")
        Me.Button22.UseVisualStyleBackColor = False
        '
        'Button23
        '
        Me.Button23.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button23.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Button23.Location = New System.Drawing.Point(57, 602)
        Me.Button23.Name = "Button23"
        Me.Button23.Size = New System.Drawing.Size(100, 23)
        Me.Button23.TabIndex = 30
        Me.Button23.Text = "Nouveau"
        Me.toolTip1.SetToolTip(Me.Button23, "Désolé, pas encore disponible")
        Me.Button23.UseVisualStyleBackColor = False
        '
        'Accueil
        '
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(412, 646)
        Me.Controls.Add(Me.Button21)
        Me.Controls.Add(Me.Button22)
        Me.Controls.Add(Me.Button23)
        Me.Controls.Add(Me.Button20)
        Me.Controls.Add(Me.Button13)
        Me.Controls.Add(Me.button4)
        Me.Controls.Add(Me.button3)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.button18)
        Me.Controls.Add(Me.button17)
        Me.Controls.Add(Me.button14)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.button5)
        Me.Controls.Add(Me.button6)
        Me.Controls.Add(Me.button7)
        Me.Controls.Add(Me.button8)
        Me.Controls.Add(Me.button9)
        Me.Controls.Add(Me.button10)
        Me.Controls.Add(Me.button11)
        Me.Controls.Add(Me.button12)
        Me.Controls.Add(Me.button15)
        Me.Controls.Add(Me.button16)
        Me.Controls.Add(Me.button19)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Accueil"
        Me.Text = "MultiM II V0.2.6.0 (En développement)"
        Me.ResumeLayout(False)

    End Sub

    Private components As ComponentModel.IContainer
    Friend WithEvents button1 As Krypton.Toolkit.KryptonButton
    Friend WithEvents KryptonPalette1 As ComponentFactory.Krypton.Toolkit.KryptonPalette
    Friend WithEvents button2 As Krypton.Toolkit.KryptonButton
    Friend WithEvents button3 As Krypton.Toolkit.KryptonButton
    Friend WithEvents button4 As Krypton.Toolkit.KryptonButton
    Public WithEvents Button13 As Button
    Public WithEvents Button20 As Button
    Public WithEvents Button21 As Button
    Public WithEvents Button22 As Button
    Public WithEvents Button23 As Button
End Class
