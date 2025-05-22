<Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>  _
Partial Public Class Gestionnaire
    Inherits System.Windows.Forms.Form
    
    Public Sub New()
        MyBase.New
        Me.InitializeComponent
    End Sub
    
    Public Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Gestionnaire))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(332, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Gestionnaire d'application gérant les différentes fenêtres d'application"
        '
        'Gestionnaire
        '
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.ClientSize = New System.Drawing.Size(367, 28)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Gestionnaire"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Gestionnaire"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    <System.STAThreadAttribute()>  _
    Public Shared Sub Main()
        _manager.Run(System.Environment.GetCommandLineArgs())
    End Sub

    Friend WithEvents Label1 As Label
End Class
