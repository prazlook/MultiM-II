<Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>  _
Partial Public Class Boîte_de_dialogueBarre
    Inherits System.Windows.Forms.Form
    
    Public trackBar1 As System.Windows.Forms.TrackBar
    
    Public numericUpDown1 As System.Windows.Forms.NumericUpDown
    
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
        Me.trackBar1.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.trackBar1.Location = New System.Drawing.Point(13, 13)
        Me.trackBar1.Maximum = 30000
        Me.trackBar1.Name = "trackBar1"
        Me.trackBar1.Size = New System.Drawing.Size(801, 45)
        Me.trackBar1.TabIndex = 1
        AddHandler Me.trackBar1.Scroll, AddressOf Me.TrackBar1_Scroll
        '
        'numericUpDown1
        '
        Me.numericUpDown1.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.numericUpDown1.Cursor = System.Windows.Forms.Cursors.Default
        Me.numericUpDown1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.numericUpDown1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.numericUpDown1.Location = New System.Drawing.Point(820, 22)
        Me.numericUpDown1.Maximum = New Decimal(New Integer() {30000, 0, 0, 0})
        Me.numericUpDown1.Name = "numericUpDown1"
        Me.numericUpDown1.Size = New System.Drawing.Size(167, 20)
        Me.numericUpDown1.TabIndex = 2
        AddHandler Me.numericUpDown1.ValueChanged, AddressOf Me.NumericUpDown1_ValueChanged
        '
        'Boîte_de_dialogueBarre
        '
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.ClientSize = New System.Drawing.Size(1000, 53)
        Me.Controls.Add(Me.numericUpDown1)
        Me.Controls.Add(Me.trackBar1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "Boîte_de_dialogueBarre"
        Me.ShowIcon = false
        Me.ShowInTaskbar = false
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Débit du serveur"
        AddHandler Load, AddressOf Me.Boîte_de_dialogueBarre_Load
        CType(Me.trackBar1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.numericUpDown1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout
        '        AddHandler OK_Button.Click, AddressOf Me.OK_Button_Click
        '       AddHandler Cancel_Button.Click, AddressOf Me.Cancel_Button_Click
        '      AddHandler Me.Load, AddressOf Me.Boîte_de_dialogueBarre_Load
        '     AddHandler trackBar1.ValueChanged, AddressOf Me.trackBar1_ValueChanged
        '    AddHandler numericUpDown1.ValueChanged, AddressOf Me.numericUpDown1_ValueChanged
        '   AddHandler trackBar1.Scroll, AddressOf Me.trackBar1_Scroll
    End Sub
End Class
