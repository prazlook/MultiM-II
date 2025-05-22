<Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>  _
Partial Public Class Boîte_de_dialogue6
    Inherits System.Windows.Forms.Form
    
    Public label1 As System.Windows.Forms.Label
    
    Public label2 As System.Windows.Forms.Label
    
    Public label3 As System.Windows.Forms.Label
    
    Public Sub New()
        MyBase.New
        Me.InitializeComponent
    End Sub
    
    Public Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Boîte_de_dialogue6))
        Me.label1 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout
        '
        'label1
        '
        Me.label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.label1.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.label1.Location = New System.Drawing.Point(13, 13)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(259, 43)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Messagerie ouverte : Toute personne se connectant au serveur peut créer un compte"& _ 
            ", et utiliser la messagerie sans restrictions."
        '
        'label2
        '
        Me.label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.label2.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.label2.Location = New System.Drawing.Point(13, 60)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(259, 147)
        Me.label2.TabIndex = 1
        Me.label2.Text = resources.GetString("label2.Text")
        '
        'label3
        '
        Me.label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.label3.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.label3.Location = New System.Drawing.Point(13, 211)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(259, 89)
        Me.label3.TabIndex = 2
        Me.label3.Text = resources.GetString("label3.Text")
        '
        'Boîte_de_dialogue6
        '
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.ClientSize = New System.Drawing.Size(284, 309)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "Boîte_de_dialogue6"
        Me.ShowIcon = false
        Me.ShowInTaskbar = false
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Boîte_de_dialogue6"
        Me.ResumeLayout(false)
        '        AddHandler OK_Button.Click, AddressOf Me.OK_Button_Click
        '        AddHandler Cancel_Button.Click, AddressOf Me.Cancel_Button_Click
    End Sub
End Class
