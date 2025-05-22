<Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>  _
Partial Public Class Réalisation_Serveur
    Inherits System.Windows.Forms.Form
    
    Public Sub New()
        MyBase.New
        Me.InitializeComponent
    End Sub
    
    Public Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VDT_Edit))
        Me.SuspendLayout
        '
        'Fenêtre1
        '
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "Fenêtre1"
        Me.Text = "Fenêtre1"
        Me.ResumeLayout(false)
        AddHandler Me.Load, AddressOf Me.Form_Load
    End Sub
End Class
