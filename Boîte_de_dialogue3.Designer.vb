<Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>  _
Partial Public Class Boîte_de_dialogue3
    Inherits System.Windows.Forms.Form
    
    Public TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    
    Public OK_Button As System.Windows.Forms.Button
    
    Public label1 As System.Windows.Forms.Label
    
    Public Cancel_Button As System.Windows.Forms.Button
    
    Public Sub New()
        MyBase.New
        Me.InitializeComponent
    End Sub
    
    Public Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Boîte_de_dialogue3))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout
        Me.SuspendLayout
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Cursor = System.Windows.Forms.Cursors.Default
        Me.TableLayoutPanel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TableLayoutPanel1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(264, 53)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.OK_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.OK_Button.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Cancel_Button.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Annuler"
        '
        'label1
        '
        Me.label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11!)
        Me.label1.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.label1.Location = New System.Drawing.Point(13, 13)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(470, 79)
        Me.label1.TabIndex = 1
        Me.label1.Text = "Vous êtes sur le point de supprimer toutes les options de personnalisation appliq"& _ 
            "uées aux noeuds."&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Votre Arborescence sera conservée."&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Êtres-vous sûr de vouloir "& _ 
            "continuer?"
        '
        'Boîte_de_dialogue3
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(422, 94)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "Boîte_de_dialogue3"
        Me.ShowIcon = false
        Me.ShowInTaskbar = false
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Attention"
        Me.TableLayoutPanel1.ResumeLayout(false)
        Me.ResumeLayout(false)
        AddHandler OK_Button.Click, AddressOf Me.OK_Button_Click
        AddHandler Cancel_Button.Click, AddressOf Me.Cancel_Button_Click
    End Sub
End Class
