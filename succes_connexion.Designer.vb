<Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>  _
Partial Public Class Boîte_de_dialogue7
    Inherits System.Windows.Forms.Form
    
    Public button1 As System.Windows.Forms.Button
    
    Public label1 As System.Windows.Forms.Label
    
    Public Sub New()
        MyBase.New
        Me.InitializeComponent
    End Sub
    
    Public Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Boîte_de_dialogue7))
        Me.button1 = New System.Windows.Forms.Button()
        Me.label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout
        '
        'button1
        '
        Me.button1.Cursor = System.Windows.Forms.Cursors.Default
        Me.button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.button1.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.button1.Location = New System.Drawing.Point(191, 8)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(75, 23)
        Me.button1.TabIndex = 0
        Me.button1.Text = "OK"
        Me.button1.UseVisualStyleBackColor = true
        '
        'label1
        '
        Me.label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.label1.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.label1.Location = New System.Drawing.Point(13, 13)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(172, 14)
        Me.label1.TabIndex = 1
        Me.label1.Text = "Vous êtes connecté avec succès!"
        '
        'Boîte_de_dialogue7
        '
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.ClientSize = New System.Drawing.Size(284, 35)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.button1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "Boîte_de_dialogue7"
        Me.ShowIcon = false
        Me.ShowInTaskbar = false
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Boîte_de_dialogue7"
        Me.ResumeLayout(false)
        '        AddHandler OK_Button.Click, AddressOf Me.OK_Button_Click
        '       AddHandler Cancel_Button.Click, AddressOf Me.Cancel_Button_Click
    End Sub
End Class
