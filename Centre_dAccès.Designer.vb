<Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class centre_acces
    Inherits System.Windows.Forms.Form

    Public WithEvents label2 As System.Windows.Forms.Label

    Public WithEvents label3 As System.Windows.Forms.Label

    Public WithEvents label4 As System.Windows.Forms.Label

    Public WithEvents button1 As System.Windows.Forms.Button

    Public WithEvents button2 As System.Windows.Forms.Button

    Public WithEvents button6 As System.Windows.Forms.Button

    Public Sub New()
        MyBase.New
        Me.InitializeComponent()
    End Sub

    Public Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(centre_acces))
        Me.label2 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.button1 = New System.Windows.Forms.Button()
        Me.button2 = New System.Windows.Forms.Button()
        Me.button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'label2
        '
        Me.label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.label2.Location = New System.Drawing.Point(276, 3)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(294, 21)
        Me.label2.TabIndex = 2
        Me.label2.Text = "Bienvenue dans le Centre d'Accès."
        '
        'label3
        '
        Me.label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.label3.Location = New System.Drawing.Point(276, 24)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(310, 102)
        Me.label3.TabIndex = 3
        Me.label3.Text = resources.GetString("label3.Text")
        '
        'label4
        '
        Me.label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.label4.Font = New System.Drawing.Font("Consolas", 35.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.Location = New System.Drawing.Point(6, 209)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(267, 64)
        Me.label4.TabIndex = 4
        Me.label4.Text = "v0.2.6.2"
        '
        'button1
        '
        Me.button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button1.Font = New System.Drawing.Font("Consolas", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button1.ForeColor = System.Drawing.Color.Lime
        Me.button1.Location = New System.Drawing.Point(276, 138)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(291, 32)
        Me.button1.TabIndex = 5
        Me.button1.Text = "MultiM II Pro"
        Me.button1.UseVisualStyleBackColor = False
        '
        'button2
        '
        Me.button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button2.Font = New System.Drawing.Font("Consolas", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button2.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.button2.Location = New System.Drawing.Point(276, 215)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(291, 32)
        Me.button2.TabIndex = 6
        Me.button2.Text = "Quitter le logiciel"
        Me.button2.UseVisualStyleBackColor = False
        '
        'button6
        '
        Me.button6.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.button6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button6.Font = New System.Drawing.Font("Consolas", 15.0!)
        Me.button6.Location = New System.Drawing.Point(280, 176)
        Me.button6.Name = "button6"
        Me.button6.Size = New System.Drawing.Size(291, 33)
        Me.button6.TabIndex = 10
        Me.button6.Text = "MultiM II Lite"
        Me.button6.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Button7.ForeColor = System.Drawing.Color.Red
        Me.Button7.Location = New System.Drawing.Point(276, 253)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(294, 47)
        Me.Button7.TabIndex = 11
        Me.Button7.Text = "Assistant de configuration (Recommandé pour les débutants. Si vous êtes nouveau, " &
    "cliquez ici.)"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.label4)
        Me.Panel1.Controls.Add(Me.Button7)
        Me.Panel1.Controls.Add(Me.button6)
        Me.Panel1.Controls.Add(Me.button2)
        Me.Panel1.Controls.Add(Me.button1)
        Me.Panel1.Controls.Add(Me.label2)
        Me.Panel1.Controls.Add(Me.label3)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(589, 303)
        Me.Panel1.TabIndex = 12
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Location = New System.Drawing.Point(571, 270)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(386, 231)
        Me.Panel2.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Underline)
        Me.Label7.ForeColor = System.Drawing.Color.Lime
        Me.Label7.Location = New System.Drawing.Point(3, 211)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(380, 20)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = ">Découvrez l'Assistant"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Label6.Location = New System.Drawing.Point(3, 90)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(380, 127)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = resources.GetString("Label6.Text")
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.Label5.Location = New System.Drawing.Point(205, 3)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(178, 84)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Découvrez le nouveau mode Assistant de Configuration"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(196, 84)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(267, 126)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(6, 132)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(267, 74)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 13
        Me.PictureBox3.TabStop = False
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(280, 109)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(287, 23)
        Me.Button3.TabIndex = 14
        Me.Button3.Text = "Voir toutes les notes de mises à jour"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'centre_acces
        '
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(976, 516)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "centre_acces"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Public WithEvents Button7 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button3 As Button
End Class
