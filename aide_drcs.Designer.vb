<Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>  _
Partial Public Class Boîte_de_dialogue1
    Inherits System.Windows.Forms.Form
    
    Public label1 As System.Windows.Forms.Label
    
    Public OK_Button As System.Windows.Forms.Button
    
    Public Sub New()
        MyBase.New
        Me.InitializeComponent
    End Sub
    
    Public Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Boîte_de_dialogue1))
        Me.label1 = New System.Windows.Forms.Label()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.SuspendLayout
        '
        'label1
        '
        Me.label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11!)
        Me.label1.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.label1.Location = New System.Drawing.Point(12, 9)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(260, 93)
        Me.label1.TabIndex = 1
        Me.label1.Text = "Une image convertie en caractère DRCS a une résolution très élevée pour un Minite"& _ 
            "l,mais cette image sera exclusivement en noir et blanc."
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Cursor = System.Windows.Forms.Cursors.Default
        Me.OK_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.OK_Button.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.OK_Button.Location = New System.Drawing.Point(205, 88)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Boîte_de_dialogue1
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.ClientSize = New System.Drawing.Size(288, 114)
        Me.Controls.Add(Me.OK_Button)
        Me.Controls.Add(Me.label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "Boîte_de_dialogue1"
        Me.ShowIcon = false
        Me.ShowInTaskbar = false
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Aide - Les caractères DRCS"
        Me.ResumeLayout(false)
        AddHandler OK_Button.Click, AddressOf Me.OK_Button_Click
    End Sub
End Class
