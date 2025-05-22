<Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>  _
Partial Public Class ajouter_page_arboedit
    Inherits System.Windows.Forms.Form
    
    Public label2 As System.Windows.Forms.Label
    
    Public Nom As System.Windows.Forms.TextBox
    
    Public Ouverture As System.Windows.Forms.ComboBox
    
    Public label3 As System.Windows.Forms.Label
    
    Public Définition As System.Windows.Forms.ComboBox
    
    Public label4 As System.Windows.Forms.Label
    
    Public label5 As System.Windows.Forms.Label
    
    Public Cancel_Button As System.Windows.Forms.Button
    
    Public OK_Button As System.Windows.Forms.Button
    
    Public TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    
    Public label1 As System.Windows.Forms.Label
    
    Public Sub New()
        MyBase.New
        Me.InitializeComponent
    End Sub
    
    Public Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ajouter_page_arboedit))
        Me.label1 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.Nom = New System.Windows.Forms.TextBox()
        Me.Ouverture = New System.Windows.Forms.ComboBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.Définition = New System.Windows.Forms.ComboBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel1.SuspendLayout
        Me.SuspendLayout
        '
        'label1
        '
        Me.label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!)
        Me.label1.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.label1.Location = New System.Drawing.Point(12, 13)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(52, 23)
        Me.label1.TabIndex = 1
        Me.label1.Text = "Nom"
        '
        'label2
        '
        Me.label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!)
        Me.label2.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.label2.Location = New System.Drawing.Point(12, 45)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(192, 23)
        Me.label2.TabIndex = 2
        Me.label2.Text = "Ouverture possible depuis"
        '
        'Nom
        '
        Me.Nom.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Nom.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Nom.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Nom.Location = New System.Drawing.Point(59, 15)
        Me.Nom.Name = "Nom"
        Me.Nom.Size = New System.Drawing.Size(308, 20)
        Me.Nom.TabIndex = 3
        '
        'Ouverture
        '
        Me.Ouverture.Cursor = System.Windows.Forms.Cursors.Default
        Me.Ouverture.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Ouverture.FormattingEnabled = true
        Me.Ouverture.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Ouverture.Items.AddRange(New Object() {"Tutti quanti", "Sommaire", "Messagerie", "Jeux", "Horoscope", "Divers", "Personnalisé 1", "Personnalisé 2", "Personnalisé 3", "Personnalisé 4", "Personnalisé 5", "Personnalisé 6", "Personnalisé 7", "Personnalisé 8", "Personnalisé 9", "Personnalisé 10", "Personnalisé 11", "Personnalisé 12", "Personnalisé 13", "Personnalisé 14", "Personnalisé 15", "Personnalisé 16", "Personnalisé 17", "Personnalisé 18", "Personnalisé 19", "Personnalisé 20", "Personnalisé 21", "Personnalisé 22"})
        Me.Ouverture.Location = New System.Drawing.Point(211, 46)
        Me.Ouverture.Name = "Ouverture"
        Me.Ouverture.Size = New System.Drawing.Size(153, 21)
        Me.Ouverture.TabIndex = 4
        '
        'label3
        '
        Me.label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.label3.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.label3.Location = New System.Drawing.Point(49, 70)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(232, 15)
        Me.label3.TabIndex = 5
        Me.label3.Text = "(Nécessite une définition, par défaut tutti quanti)"
        '
        'Définition
        '
        Me.Définition.Cursor = System.Windows.Forms.Cursors.Default
        Me.Définition.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Définition.FormattingEnabled = true
        Me.Définition.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Définition.Items.AddRange(New Object() {"Tutti quanti", "Sommaire", "Messagerie", "Jeux", "Horoscope", "Divers", "Personnalisé 1", "Personnalisé 2", "Personnalisé 3", "Personnalisé 4", "Personnalisé 5", "Personnalisé 6", "Personnalisé 7", "Personnalisé 8", "Personnalisé 9", "Personnalisé 10", "Personnalisé 11", "Personnalisé 12", "Personnalisé 13", "Personnalisé 14", "Personnalisé 15", "Personnalisé 16", "Personnalisé 17", "Personnalisé 18", "Personnalisé 19", "Personnalisé 20", "Personnalisé 21", "Personnalisé 22"})
        Me.Définition.Location = New System.Drawing.Point(179, 98)
        Me.Définition.Name = "Définition"
        Me.Définition.Size = New System.Drawing.Size(153, 21)
        Me.Définition.TabIndex = 6
        '
        'label4
        '
        Me.label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15!)
        Me.label4.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.label4.Location = New System.Drawing.Point(13, 92)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(160, 23)
        Me.label4.TabIndex = 7
        Me.label4.Text = "Définir comme..."
        '
        'label5
        '
        Me.label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.label5.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.label5.Location = New System.Drawing.Point(59, 122)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(251, 15)
        Me.label5.TabIndex = 8
        Me.label5.Text = "Attention:les éléments déjà définis seront redéfinis!"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Cancel_Button.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Annuler"
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Cursor = System.Windows.Forms.Cursors.Default
        Me.OK_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.OK_Button.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(221, 151)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'ajouter_page_arboedit
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(379, 192)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.Ouverture)
        Me.Controls.Add(Me.Nom)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.Définition)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "ajouter_page_arboedit"
        Me.ShowIcon = false
        Me.ShowInTaskbar = false
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Ajouter une page Minitel"
        Me.TableLayoutPanel1.ResumeLayout(false)
        Me.ResumeLayout(false)
        Me.PerformLayout
        AddHandler OK_Button.Click, AddressOf Me.OK_Button_Click
        AddHandler Cancel_Button.Click, AddressOf Me.Cancel_Button_Click
    End Sub
End Class
