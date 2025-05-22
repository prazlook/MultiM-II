<Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>  _
Partial Public Class FenêtreAvertissement
    Inherits System.Windows.Forms.Form
    
    Public pictureBox1 As System.Windows.Forms.PictureBox
    
    Public pictureBox2 As System.Windows.Forms.PictureBox
    
    Public label1 As System.Windows.Forms.Label
    
    Public label2 As System.Windows.Forms.Label
    
    Public button1 As System.Windows.Forms.Button
    
    Public button2 As System.Windows.Forms.Button
    
    Public Sub New()
        MyBase.New
        Me.InitializeComponent
    End Sub
    
    Public Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FenêtreAvertissement))
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pictureBox2 = New System.Windows.Forms.PictureBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.button1 = New System.Windows.Forms.Button()
        Me.button2 = New System.Windows.Forms.Button()
        CType(Me.pictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.pictureBox2,System.ComponentModel.ISupportInitialize).BeginInit
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
        Me.pictureBox1.Size = New System.Drawing.Size(153, 121)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox1.TabIndex = 0
        Me.pictureBox1.TabStop = false
        '
        'pictureBox2
        '
        Me.pictureBox2.Cursor = System.Windows.Forms.Cursors.Default
        Me.pictureBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.pictureBox2.Image = CType(resources.GetObject("pictureBox2.Image"),System.Drawing.Image)
        Me.pictureBox2.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.pictureBox2.Location = New System.Drawing.Point(660, 13)
        Me.pictureBox2.Name = "pictureBox2"
        Me.pictureBox2.Size = New System.Drawing.Size(153, 121)
        Me.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox2.TabIndex = 1
        Me.pictureBox2.TabStop = false
        '
        'label1
        '
        Me.label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 35!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(12,Byte))
        Me.label1.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.label1.Location = New System.Drawing.Point(191, 42)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(436, 55)
        Me.label1.TabIndex = 2
        Me.label1.Text = "Attention, danger !!!"
        '
        'label2
        '
        Me.label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15!)
        Me.label2.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.label2.Location = New System.Drawing.Point(13, 141)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(800, 181)
        Me.label2.TabIndex = 3
        Me.label2.Text = resources.GetString("label2.Text")
        '
        'button1
        '
        Me.button1.Cursor = System.Windows.Forms.Cursors.Default
        Me.button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 17!)
        Me.button1.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.button1.Location = New System.Drawing.Point(13, 326)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(800, 62)
        Me.button1.TabIndex = 4
        Me.button1.Text = "Cliquez ici pour fermer cette fenêtre"
        Me.button1.UseVisualStyleBackColor = true
        AddHandler Me.button1.Click, AddressOf Me.Button1_Click
        '
        'button2
        '
        Me.button2.Cursor = System.Windows.Forms.Cursors.Default
        Me.button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.button2.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.button2.Location = New System.Drawing.Point(726, 299)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(76, 21)
        Me.button2.TabIndex = 5
        Me.button2.Text = "Continuer"
        Me.button2.UseVisualStyleBackColor = true
        AddHandler Me.button2.Click, AddressOf Me.Button2_Click
        '
        'FenêtreAvertissement
        '
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.ClientSize = New System.Drawing.Size(839, 403)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.pictureBox1)
        Me.Controls.Add(Me.pictureBox2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "FenêtreAvertissement"
        Me.Text = "Avertissement"
        CType(Me.pictureBox1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.pictureBox2,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        AddHandler Me.Load, AddressOf Me.Form_Load
        AddHandler button1.Click, AddressOf Me.button1_Click
        AddHandler button2.Click, AddressOf Me.button2_Click
    End Sub
End Class
