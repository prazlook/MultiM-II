<Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>  _
Partial Public Class Boîte_de_dialogueBarre
    Inherits System.Windows.Forms.Form

    Public WithEvents trackBar1 As System.Windows.Forms.TrackBar

    Public WithEvents numericUpDown1 As System.Windows.Forms.NumericUpDown

    Public Sub New()
        MyBase.New
        Me.InitializeComponent
    End Sub
    
    Public Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Boîte_de_dialogueBarre))
        Me.trackBar1 = New System.Windows.Forms.TrackBar()
        Me.numericUpDown1 = New System.Windows.Forms.NumericUpDown()
        CType(Me.trackBar1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.numericUpDown1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'trackBar1
        '
        Me.trackBar1.Cursor = System.Windows.Forms.Cursors.Default
        Me.trackBar1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.trackBar1.Location = New System.Drawing.Point(13, 13)
        Me.trackBar1.Maximum = 40000
        Me.trackBar1.Name = "trackBar1"
        Me.trackBar1.Size = New System.Drawing.Size(801, 45)
        Me.trackBar1.TabIndex = 1
        '
        'numericUpDown1
        '
        Me.numericUpDown1.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.numericUpDown1.Cursor = System.Windows.Forms.Cursors.Default
        Me.numericUpDown1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.numericUpDown1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.numericUpDown1.Location = New System.Drawing.Point(820, 22)
        Me.numericUpDown1.Maximum = New Decimal(New Integer() {40000, 0, 0, 0})
        Me.numericUpDown1.Name = "numericUpDown1"
        Me.numericUpDown1.Size = New System.Drawing.Size(167, 20)
        Me.numericUpDown1.TabIndex = 2
        '
        'Boîte_de_dialogueBarre
        '
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.ClientSize = New System.Drawing.Size(1000, 53)
        Me.Controls.Add(Me.numericUpDown1)
        Me.Controls.Add(Me.trackBar1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Boîte_de_dialogueBarre"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Débit du serveur"
        CType(Me.trackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
End Class
