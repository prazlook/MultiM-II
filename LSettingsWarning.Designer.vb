<Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>  _
Partial Public Class LSettingsWarning
    Inherits System.Windows.Forms.Form
    
    Public label2 As System.Windows.Forms.Label
    
    Public button1 As System.Windows.Forms.Button
    
    Public button2 As System.Windows.Forms.Button
    
    Public label1 As System.Windows.Forms.Label
    
    Public Sub New()
        MyBase.New
        Me.InitializeComponent
    End Sub
    
    Public Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LSettingsWarning))
        Me.label1 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.button1 = New System.Windows.Forms.Button()
        Me.button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout
        '
        'label1
        '
        Me.label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!)
        Me.label1.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.label1.Location = New System.Drawing.Point(13, 13)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(469, 104)
        Me.label1.TabIndex = 0
        Me.label1.Text = resources.GetString("label1.Text")
        '
        'label2
        '
        Me.label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 19!, System.Drawing.FontStyle.Bold)
        Me.label2.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.label2.Location = New System.Drawing.Point(13, 121)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(469, 41)
        Me.label2.TabIndex = 1
        Me.label2.Text = "Êtes-vous sûr de vouloir continuer?"
        '
        'button1
        '
        Me.button1.Cursor = System.Windows.Forms.Cursors.Default
        Me.button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.button1.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.button1.Location = New System.Drawing.Point(13, 157)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(181, 39)
        Me.button1.TabIndex = 2
        Me.button1.Text = "Oui (déconseillé dans un environnement non sécurisé)"
        Me.button1.UseVisualStyleBackColor = true
        AddHandler Me.button1.Click, AddressOf Me.Button1_Click
        '
        'button2
        '
        Me.button2.Cursor = System.Windows.Forms.Cursors.Default
        Me.button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15!)
        Me.button2.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.button2.Location = New System.Drawing.Point(200, 157)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(325, 41)
        Me.button2.TabIndex = 3
        Me.button2.Text = "Non"
        Me.button2.UseVisualStyleBackColor = true
        AddHandler Me.button2.Click, AddressOf Me.Button2_Click
        '
        'LSettingsWarning
        '
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.ClientSize = New System.Drawing.Size(537, 210)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "LSettingsWarning"
        Me.Text = "DERNIER AVERTISSEMENT"
        Me.ResumeLayout(false)
        AddHandler Me.Load, AddressOf Me.Form_Load
        AddHandler button1.Click, AddressOf Me.button1_Click
        AddHandler button2.Click, AddressOf Me.button2_Click
    End Sub
End Class
