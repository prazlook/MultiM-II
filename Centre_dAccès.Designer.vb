<Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>  _
Partial Public Class centre_acces
    Inherits System.Windows.Forms.Form
    
    Public pictureBox1 As System.Windows.Forms.PictureBox
    
    Public label1 As System.Windows.Forms.Label
    
    Public label2 As System.Windows.Forms.Label
    
    Public label3 As System.Windows.Forms.Label
    
    Public label4 As System.Windows.Forms.Label
    
    Public button1 As System.Windows.Forms.Button
    
    Public button2 As System.Windows.Forms.Button
    
    Public button3 As System.Windows.Forms.Button
    
    Public button4 As System.Windows.Forms.Button
    
    Public button6 As System.Windows.Forms.Button
    
    Public button5 As System.Windows.Forms.Button
    
    Public Sub New()
        MyBase.New
        Me.InitializeComponent
    End Sub
    
    Public Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(centre_acces))
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.button1 = New System.Windows.Forms.Button()
        Me.button2 = New System.Windows.Forms.Button()
        Me.button3 = New System.Windows.Forms.Button()
        Me.button4 = New System.Windows.Forms.Button()
        Me.button5 = New System.Windows.Forms.Button()
        Me.button6 = New System.Windows.Forms.Button()
        CType(Me.pictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'pictureBox1
        '
        Me.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default
        Me.pictureBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"),System.Drawing.Image)
        Me.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.pictureBox1.Location = New System.Drawing.Point(13, 13)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(266, 196)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox1.TabIndex = 0
        Me.pictureBox1.TabStop = false
        AddHandler Me.pictureBox1.Click, AddressOf Me.PictureBox1_Click
        '
        'label1
        '
        Me.label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 50!)
        Me.label1.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.label1.Location = New System.Drawing.Point(13, 221)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(344, 110)
        Me.label1.TabIndex = 1
        Me.label1.Text = "MultiM II"
        AddHandler Me.label1.Click, AddressOf Me.Label1_Click
        '
        'label2
        '
        Me.label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold)
        Me.label2.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.label2.Location = New System.Drawing.Point(286, 13)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(294, 26)
        Me.label2.TabIndex = 2
        Me.label2.Text = "Bienvenue dans le Centre d'Accès."
        '
        'label3
        '
        Me.label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.label3.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.label3.Location = New System.Drawing.Point(286, 34)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(281, 67)
        Me.label3.TabIndex = 3
        Me.label3.Text = resources.GetString("label3.Text")
        '
        'label4
        '
        Me.label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.label4.Font = New System.Drawing.Font("Consolas", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.label4.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.label4.Location = New System.Drawing.Point(286, 265)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(100, 23)
        Me.label4.TabIndex = 4
        Me.label4.Text = "v0.2.5.7"
        '
        'button1
        '
        Me.button1.Cursor = System.Windows.Forms.Cursors.Default
        Me.button1.Font = New System.Drawing.Font("Consolas", 15!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.button1.ForeColor = System.Drawing.Color.Lime
        Me.button1.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.button1.Location = New System.Drawing.Point(286, 104)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(291, 32)
        Me.button1.TabIndex = 5
        Me.button1.Text = "Lancer le logiciel"
        Me.button1.UseVisualStyleBackColor = true
        AddHandler Me.button1.Click, AddressOf Me.Button1_Click
        '
        'button2
        '
        Me.button2.Cursor = System.Windows.Forms.Cursors.Default
        Me.button2.Font = New System.Drawing.Font("Consolas", 15!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.button2.ForeColor = System.Drawing.Color.Red
        Me.button2.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.button2.Location = New System.Drawing.Point(286, 142)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(291, 32)
        Me.button2.TabIndex = 6
        Me.button2.Text = "Fermer le logiciel"
        Me.button2.UseVisualStyleBackColor = true
        AddHandler Me.button2.Click, AddressOf Me.Button2_Click
        '
        'button3
        '
        Me.button3.Cursor = System.Windows.Forms.Cursors.Default
        Me.button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.button3.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.button3.Location = New System.Drawing.Point(286, 181)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(100, 23)
        Me.button3.TabIndex = 7
        Me.button3.Text = "Nouveau"
        Me.button3.UseVisualStyleBackColor = true
        '
        'button4
        '
        Me.button4.Cursor = System.Windows.Forms.Cursors.Default
        Me.button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.button4.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.button4.Location = New System.Drawing.Point(392, 181)
        Me.button4.Name = "button4"
        Me.button4.Size = New System.Drawing.Size(87, 23)
        Me.button4.TabIndex = 8
        Me.button4.Text = "Ouvrir"
        Me.button4.UseVisualStyleBackColor = true
        AddHandler Me.button4.Click, AddressOf Me.Button4_Click
        '
        'button5
        '
        Me.button5.Cursor = System.Windows.Forms.Cursors.Default
        Me.button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.button5.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.button5.Location = New System.Drawing.Point(485, 181)
        Me.button5.Name = "button5"
        Me.button5.Size = New System.Drawing.Size(92, 23)
        Me.button5.TabIndex = 9
        Me.button5.Text = "Récents"
        Me.button5.UseVisualStyleBackColor = true
        '
        'button6
        '
        Me.button6.Cursor = System.Windows.Forms.Cursors.Default
        Me.button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.button6.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.button6.Location = New System.Drawing.Point(286, 210)
        Me.button6.Name = "button6"
        Me.button6.Size = New System.Drawing.Size(178, 33)
        Me.button6.TabIndex = 10
        Me.button6.Text = "Activer la Barre d'Outils"
        Me.button6.UseVisualStyleBackColor = true
        '
        'centre_acces
        '
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.BackColor = System.Drawing.SystemColors.MenuBar
        Me.ClientSize = New System.Drawing.Size(589, 303)
        Me.ControlBox = false
        Me.Controls.Add(Me.button6)
        Me.Controls.Add(Me.button3)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.pictureBox1)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.button4)
        Me.Controls.Add(Me.button5)
        Me.DoubleBuffered = true
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "centre_acces"
        Me.ShowIcon = false
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.pictureBox1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        AddHandler Me.Load, AddressOf Me.SplashScreen_Load
        AddHandler pictureBox1.Click, AddressOf Me.pictureBox1_Click
        AddHandler button1.Click, AddressOf Me.button1_Click
        AddHandler label1.Click, AddressOf Me.label1_Click
        AddHandler button4.Click, AddressOf Me.button4_Click
        AddHandler button2.Click, AddressOf Me.button2_Click
        AddHandler button6.Click, AddressOf Me.button6_Click
    End Sub
End Class
