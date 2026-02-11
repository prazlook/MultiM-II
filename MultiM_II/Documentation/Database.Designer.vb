<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Database
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Comment tout a commencé")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Suite")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Suite Lite")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Autres")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Développement de MultiM II", New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode3, TreeNode4})
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("VDT Edit")
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("VDT Pics")
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ArboEdit")
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Compistart")
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Emulatel")
        Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Database")
        Dim TreeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Suite", New System.Windows.Forms.TreeNode() {TreeNode6, TreeNode7, TreeNode8, TreeNode9, TreeNode10, TreeNode11})
        Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Conception Serveur")
        Dim TreeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Réalisation Serveur")
        Dim TreeNode15 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Paramètres")
        Dim TreeNode16 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Mises à jour")
        Dim TreeNode17 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Utilitaires", New System.Windows.Forms.TreeNode() {TreeNode13, TreeNode14, TreeNode15, TreeNode16})
        Dim TreeNode18 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Forum")
        Dim TreeNode19 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Histoire")
        Dim TreeNode20 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Autres logiciels", New System.Windows.Forms.TreeNode() {TreeNode18, TreeNode19})
        Dim TreeNode21 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Utilisation de MultiM II", New System.Windows.Forms.TreeNode() {TreeNode12, TreeNode17, TreeNode20})
        Dim TreeNode22 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Logiciel", New System.Windows.Forms.TreeNode() {TreeNode5, TreeNode21})
        Dim TreeNode23 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Minitel")
        Dim TreeNode24 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Serveur")
        Dim TreeNode25 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Modem")
        Dim TreeNode26 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Matériel", New System.Windows.Forms.TreeNode() {TreeNode23, TreeNode24, TreeNode25})
        Dim TreeNode27 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Documentation", New System.Windows.Forms.TreeNode() {TreeNode22, TreeNode26})
        Dim TreeNode28 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("MultiM II", New System.Windows.Forms.TreeNode() {TreeNode27})
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 700)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1604, 22)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(360, 17)
        Me.ToolStripStatusLabel1.Text = "Prêt. Sélectionnez un noeud de l'Arborescence pour commencer."
        '
        'TreeView1
        '
        Me.TreeView1.Location = New System.Drawing.Point(1272, 12)
        Me.TreeView1.Name = "TreeView1"
        TreeNode1.Name = "howItStarted"
        TreeNode1.Text = "Comment tout a commencé"
        TreeNode2.Name = "devSuite"
        TreeNode2.Text = "Suite"
        TreeNode3.Name = "Nœud10"
        TreeNode3.Text = "Suite Lite"
        TreeNode4.Name = "Nœud11"
        TreeNode4.Text = "Autres"
        TreeNode5.Name = "Nœud3"
        TreeNode5.Text = "Développement de MultiM II"
        TreeNode6.Name = "Nœud14"
        TreeNode6.Text = "VDT Edit"
        TreeNode7.Name = "Nœud15"
        TreeNode7.Text = "VDT Pics"
        TreeNode8.Name = "Nœud16"
        TreeNode8.Text = "ArboEdit"
        TreeNode9.Name = "Nœud17"
        TreeNode9.Text = "Compistart"
        TreeNode10.Name = "Nœud18"
        TreeNode10.Text = "Emulatel"
        TreeNode11.Name = "Nœud19"
        TreeNode11.Text = "Database"
        TreeNode12.Name = "Nœud12"
        TreeNode12.Text = "Suite"
        TreeNode13.Name = "Nœud22"
        TreeNode13.Text = "Conception Serveur"
        TreeNode14.Name = "Nœud23"
        TreeNode14.Text = "Réalisation Serveur"
        TreeNode15.Name = "Nœud25"
        TreeNode15.Text = "Paramètres"
        TreeNode16.Name = "Nœud26"
        TreeNode16.Text = "Mises à jour"
        TreeNode17.Name = "Nœud13"
        TreeNode17.Text = "Utilitaires"
        TreeNode18.Name = "Nœud28"
        TreeNode18.Text = "Forum"
        TreeNode19.Name = "Nœud29"
        TreeNode19.Text = "Histoire"
        TreeNode20.Name = "Nœud27"
        TreeNode20.Text = "Autres logiciels"
        TreeNode21.Name = "Nœud5"
        TreeNode21.Text = "Utilisation de MultiM II"
        TreeNode22.Name = "Nœud4"
        TreeNode22.Text = "Logiciel"
        TreeNode23.Name = "Nœud3"
        TreeNode23.Text = "Minitel"
        TreeNode24.Name = "Nœud5"
        TreeNode24.Text = "Serveur"
        TreeNode25.Name = "Nœud6"
        TreeNode25.Text = "Modem"
        TreeNode26.Name = "Nœud1"
        TreeNode26.Text = "Matériel"
        TreeNode27.Name = "Nœud1"
        TreeNode27.Text = "Documentation"
        TreeNode28.Name = "Nœud0"
        TreeNode28.Text = "MultiM II"
        Me.TreeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode28})
        Me.TreeView1.Size = New System.Drawing.Size(320, 676)
        Me.TreeView1.TabIndex = 1
        '
        'Database
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1604, 722)
        Me.Controls.Add(Me.TreeView1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Name = "Database"
        Me.Text = "Database (En développement)"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents TreeView1 As TreeView
End Class
