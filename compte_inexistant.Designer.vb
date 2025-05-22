<Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>  _
Partial Public Class Boîte_de_dialogue8
    Inherits System.Windows.Forms.Form
    
    Public label1 As System.Windows.Forms.Label
    
    Public button1 As System.Windows.Forms.Button
    
    Public Sub New()
        MyBase.New
        Me.InitializeComponent
    End Sub
    
    Public Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Boîte_de_dialogue8))
        Me.label1 = New System.Windows.Forms.Label()
        Me.button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout
        '
        'label1
        '
        Me.label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.label1.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.label1.Location = New System.Drawing.Point(13, 13)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(155, 17)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Erreur.Ce compte n'existe pas."
        '
        'button1
        '
        Me.button1.Cursor = System.Windows.Forms.Cursors.Default
        Me.button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.button1.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.button1.Location = New System.Drawing.Point(174, 10)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(75, 23)
        Me.button1.TabIndex = 1
        Me.button1.Text = "OK"
        Me.button1.UseVisualStyleBackColor = true
        '
        'Boîte_de_dialogue8
        '
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.ClientSize = New System.Drawing.Size(260, 45)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "Boîte_de_dialogue8"
        Me.ShowIcon = false
        Me.ShowInTaskbar = false
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Boîte_de_dialogue8"
        Me.ResumeLayout(false)
    End Sub
End Class
