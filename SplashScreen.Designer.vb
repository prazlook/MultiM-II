<Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>  _
Partial Public Class SplashScreen
    Inherits System.Windows.Forms.Form
    
    Public label2 As System.Windows.Forms.Label
    
    Public progressBar1 As System.Windows.Forms.ProgressBar
    
    Public progressTimer As System.Windows.Forms.Timer

    Public Sub New()
        MyBase.New
        Me.InitializeComponent()
    End Sub

    Public Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SplashScreen))
        Me.label2 = New System.Windows.Forms.Label()
        Me.progressBar1 = New System.Windows.Forms.ProgressBar()
        Me.progressTimer = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'label2
        '
        Me.label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.label2.Location = New System.Drawing.Point(12, 38)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(521, 28)
        Me.label2.TabIndex = 3
        Me.label2.Text = "Loading assets..."
        '
        'progressBar1
        '
        Me.progressBar1.Cursor = System.Windows.Forms.Cursors.Default
        Me.progressBar1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.progressBar1.ForeColor = System.Drawing.Color.Ivory
        Me.progressBar1.Location = New System.Drawing.Point(12, 12)
        Me.progressBar1.Name = "progressBar1"
        Me.progressBar1.Size = New System.Drawing.Size(521, 23)
        Me.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.progressBar1.TabIndex = 4
        '
        'SplashScreen
        '
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.ClientSize = New System.Drawing.Size(546, 74)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.progressBar1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SplashScreen"
        Me.Text = "Chargement...(Ne pas fermer cette fenêtre)"
        Me.ResumeLayout(False)

    End Sub

    Private components As System.ComponentModel.IContainer
End Class
