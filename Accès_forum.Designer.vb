<Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>  _
Partial Public Class Accès_forum
    Inherits System.Windows.Forms.Form
    
    Public webBrowser1 As System.Windows.Forms.WebBrowser
    
    Public Sub New()
        MyBase.New
        Me.InitializeComponent
    End Sub
    
    Public Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Accès_forum))
        Me.webBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.SuspendLayout
        '
        'webBrowser1
        '
        Me.webBrowser1.Location = New System.Drawing.Point(13, 13)
        Me.webBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.webBrowser1.Name = "webBrowser1"
        Me.webBrowser1.Size = New System.Drawing.Size(721, 561)
        Me.webBrowser1.TabIndex = 0
        Me.webBrowser1.Url = New System.Uri("https://www.forum.museeminitel.fr", System.UriKind.Absolute)
        '
        'Accès_forum
        '
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.ClientSize = New System.Drawing.Size(986, 777)
        Me.Controls.Add(Me.webBrowser1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "Accès_forum"
        Me.Text = "Accès_forum"
        Me.ResumeLayout(false)
        AddHandler Me.Load, AddressOf Me.Form_Load
    End Sub
End Class
