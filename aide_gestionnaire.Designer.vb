<Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>  _
Partial Public Class Boîte_de_dialogue5
    Inherits System.Windows.Forms.Form
    
    Public label1 As System.Windows.Forms.Label
    
    Public Sub New()
        MyBase.New
        Me.InitializeComponent
    End Sub
    
    Public Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Boîte_de_dialogue5))
        Me.label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout
        '
        'label1
        '
        Me.label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.label1.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.label1.Location = New System.Drawing.Point(2, 9)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(259, 62)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Le Gestionnaire est un process qui supporte le logiciel MultiM II."&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Le fermer aur"& _ 
            "a pour effet de fermer le logiciel et terminer le progamme!"
        '
        'Boîte_de_dialogue5
        '
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.ClientSize = New System.Drawing.Size(228, 77)
        Me.Controls.Add(Me.label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "Boîte_de_dialogue5"
        Me.ShowIcon = false
        Me.ShowInTaskbar = false
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Qu'est-ce que le Gestionnaire?"
        Me.ResumeLayout(false)
        '        AddHandler OK_Button.Click, AddressOf Me.OK_Button_Click
        '       AddHandler Cancel_Button.Click, AddressOf Me.Cancel_Button_Click
    End Sub
End Class
