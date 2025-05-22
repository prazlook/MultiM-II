Public Class ArboEdit
    
    'Fonction Fenêtre3_Load
    Public Sub Fenêtre3_Load(ByVal sender As Object, ByVal e As System.EventArgs)
        'Cette fonction se déclenche à l'ouverture de la fenêtre.
        '
        'This function is launched during opening.
    End Sub

    'Fonction label2_Click
    Public Sub label2_Click(ByVal sender As Object, ByVal e As System.EventArgs)
    End Sub

    'Fonction label3_Click
    Public Sub label3_Click(ByVal sender As Object, ByVal e As System.EventArgs)
    End Sub

    'Fonction label7_Click
    Public Sub label7_Click(ByVal sender As Object, ByVal e As System.EventArgs)
    End Sub

    'Fonction button4_Click
    Public Sub button4_Click(ByVal sender As Object, ByVal e As System.EventArgs)
    End Sub

    'Fonction modifprops_Click
    Public Sub modifprops_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        If Me.colorDialog1.ShowDialog() = DialogResult.OK Then
            If Me.treeView1.SelectedNode IsNot Nothing Then
                Me.treeView1.SelectedNode.BackColor = Me.colorDialog1.Color
            End If
        End If
        Me.label9.Text = Me.treeView1.SelectedNode.BackColor.Name

    End Sub

    'Fonction ajouterpage_Click
    Public Sub ajouterpage_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        ' Vérifier que NoeudSelectionne contient bien un nœud valide avant d'ajouter un enfant
        If NoeudSelectionne IsNot Nothing Then
            ' Créer un nouveau nœud enfant avec le nom défini dans la variable NomNoeud
            Dim nouveauNoeud As New TreeNode(NomNoeud)

            ' Ajouter le nœud enfant sous le nœud parent sélectionné (NoeudSelectionne)
            NoeudSelectionne.Nodes.Add(nouveauNoeud)

            ' Déployer le nœud parent pour voir le nouvel enfant immédiatement
            NoeudSelectionne.Expand()
        Else
            MessageBox.Show("Erreur : NoeudSelectionne est nul.")
        End If

        If Me.treeView1.SelectedNode IsNot Nothing Then
            NoeudSelectionne = Me.treeView1.SelectedNode.Text
        Else
            NoeudSelectionne = "" ' Réinitialise si aucun nœud sélectionné
        End If


    End Sub

    'Fonction groupBox5_Enter
    Public Sub groupBox5_Enter(ByVal sender As Object, ByVal e As System.EventArgs)
    End Sub

    'Fonction groupBox2_Enter
    Public Sub groupBox2_Enter(ByVal sender As Object, ByVal e As System.EventArgs)
    End Sub

    'Fonction button6_Click
    Public Sub button6_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        If treeView1.SelectedNode IsNot Nothing Then
            ' Ouvrir le dialogue de fichier
            openFileDialog1.Filter = "Fichiers VDT (*.VDT)|*.VDT|Tous les fichiers (*.*)|*.*"
            openFileDialog1.FilterIndex = 1 ' Par défaut, afficher uniquement les fichiers VDT

            If openFileDialog1.ShowDialog() = DialogResult.OK Then
                ' Vérifier si le fichier sélectionné a l'extension .VDT
                If openFileDialog1.FileName.EndsWith(".VDT", StringComparison.OrdinalIgnoreCase) Then

                    ' Récupérer l'ancienne info (si elle existe déjà dans le Tag)
                    Dim ancienneInfo As String = ""
                    If treeView1.SelectedNode.Tag IsNot Nothing Then
                        Dim parties() As String = Split(treeView1.SelectedNode.Tag.ToString(), "[]")
                        If parties.Length > 1 Then
                            ancienneInfo = parties(1) ' Récupérer la deuxième partie du Tag
                        End If
                    End If

                    ' Construire le nouveau Tag avec le nouveau chemin + l'ancienne info
                    treeView1.SelectedNode.Tag = openFileDialog1.FileName & "[]" & ancienneInfo

                    ' Mettre à jour le texte du Label10 avec le chemin d'accès du fichier
                    label10.Text = "Fichier sélectionné : " & openFileDialog1.FileName
                Else
                    MessageBox.Show("Veuillez sélectionner un fichier avec l'extension .VDT.", "Erreur de fichier", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If
        Else
            MessageBox.Show("Veuillez sélectionner un noeud dans l'Arborescence.", "Erreur de fichier", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub

    'Fonction button7_Click
    Public Sub button7_Click(ByVal sender As Object, ByVal e As System.EventArgs)
    End Sub

    'Fonction button1_Click
    Public Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        NomNoeud = "" & Me.textBox1.Text & ""
        Try
            ' Vérifier si un noeud est sélectionné dans TreeView1
            If treeView1.SelectedNode IsNot Nothing Then
                ' Créer un nouveau noeud enfant avec le texte du TextBox1
                Dim newNode As New TreeNode(textBox1.Text)

                ' Définir le Tag du noeud enfant
                newNode.Tag = "Aucune page sélctionnée@Une page"

                ' Ajouter le nouveau noeud enfant au noeud sélectionné
                treeView1.SelectedNode.Nodes.Add(newNode)

                ' Si un doublon est créé, on supprime un des doublons
                Dim duplicateNode As TreeNode = Nothing
                For Each childNode As TreeNode In treeView1.SelectedNode.Nodes
                    If childNode.Text = textBox1.Text AndAlso childNode IsNot newNode Then
                        duplicateNode = childNode
                        Exit For
                    End If
                Next

                ' Si un doublon est trouvé, supprimer ce nœud
                If duplicateNode IsNot Nothing Then
                    treeView1.SelectedNode.Nodes.Remove(duplicateNode)
                End If
            Else
                MessageBox.Show("Veuillez sélectionner un noeud parent.")
            End If
        Catch ex As Exception
            ' Gestion des erreurs
            MessageBox.Show("Erreur lors de l'ajout du noeud : " & ex.Message)
        End Try

    End Sub

    'Fonction treeView1_AfterSelect
    Public Sub treeView1_AfterSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs)
        ' Vérifie si un nœud est sélectionné avant d'essayer de l'utiliser
        If treeView1.SelectedNode IsNot Nothing Then
            ' Vérifie si le Tag du nœud est défini
            If treeView1.SelectedNode.Tag IsNot Nothing Then
                ' Votre logique ici
                ' Par exemple, obtenir le chemin et l'afficher
                Dim chemin As String = treeView1.SelectedNode.Tag.ToString().Split("@")(0)
                label10.Text = "Chemin : " & chemin
                ' Ajouter d'autres opérations ici si nécessaire
            Else
                MessageBox.Show("Le Tag du nœud sélectionné n'est pas défini.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
            NoeudSelectionne = treeView1.SelectedNode
            textBox2.Text = treeView1.SelectedNode.Text
            If treeView1.SelectedNode IsNot Nothing AndAlso treeView1.SelectedNode.Tag IsNot Nothing Then
                ' Récupérer le Tag du noeud sélectionné et le diviser
                Dim parties() As String = Split(treeView1.SelectedNode.Tag.ToString(), "@")

                ' Vérifier s'il y a une deuxième partie dans le Tag
                If parties.Length > 1 Then
                    ' Assigner la deuxième partie du Tag à TextBox3
                    textBox3.Text = parties(1)
                End If
            End If

        Else
            MessageBox.Show("Veuillez sélectionner un nœud dans l'arborescence.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub

    'Fonction ImporterUneArborescenceToolStripMenuItem_Click
    Public Sub ImporterUneArborescenceToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        ' Boîte de sélection de fichier
        Dim ouvrir As New OpenFileDialog()
        ouvrir.Filter = "Fichiers ARB (*.arb)|*.arb"
        ouvrir.Title = "Importer une arborescence"

        If ouvrir.ShowDialog() = DialogResult.OK Then

            Dim contenu As String = System.IO.File.ReadAllText(ouvrir.FileName)
            treeView1.Nodes.Clear()

            ' Utilisation explicite de System.Collections.Generic.Stack
            Dim pileParents As New System.Collections.Generic.Stack(Of TreeNode)()
            Dim i As Integer = 0
            Dim nom As String = ""

            While i < contenu.Length
                Dim c As Char = contenu(i)

                If Char.IsLetterOrDigit(c) OrElse c = "_" OrElse c = "-" OrElse c = " " Then
                    nom &= c
                ElseIf c = "("c Then
                    Dim nouveau As New TreeNode(nom.Trim())
                    nom = ""

                    If pileParents.Count > 0 Then
                        pileParents.Peek().Nodes.Add(nouveau)
                    Else
                        treeView1.Nodes.Add(nouveau)
                    End If

                    pileParents.Push(nouveau)
                ElseIf c = "["c Then
                    i += 1
                    Dim meta As String = ""
                    While i < contenu.Length AndAlso contenu(i) <> "]"c
                        meta &= contenu(i)
                        i += 1
                    End While

                    Dim morceaux() As String = meta.Split(";"c)
                    Dim tag As String = If(morceaux.Length > 0, morceaux(0), "")
                    Dim fond As Integer = If(morceaux.Length > 1, CInt(morceaux(1)), 0)
                    Dim texte As Integer = If(morceaux.Length > 2, CInt(morceaux(2)), 0)

                    Dim cible As TreeNode = Nothing
                    If nom.Trim() <> "" Then
                        cible = New TreeNode(nom.Trim())
                        If pileParents.Count > 0 Then
                            pileParents.Peek().Nodes.Add(cible)
                        Else
                            treeView1.Nodes.Add(cible)
                        End If
                        nom = ""
                    ElseIf pileParents.Count > 0 Then
                        cible = pileParents.Peek()
                    End If

                    If cible IsNot Nothing Then
                        cible.Tag = tag
                        If fond <> -1 Then
                            cible.BackColor = System.Drawing.Color.FromArgb(fond)
                        End If

                        If texte <> -1 Then
                            cible.ForeColor = System.Drawing.Color.FromArgb(texte)
                        End If

                    End If
                ElseIf c = ";"c Then
                    If nom.Trim() <> "" Then
                        Dim nouveau As New TreeNode(nom.Trim())
                        If pileParents.Count > 0 Then
                            pileParents.Peek().Nodes.Add(nouveau)
                        Else
                            treeView1.Nodes.Add(nouveau)
                        End If
                        nom = ""
                    End If
                ElseIf c = ")"c Then
                    If nom.Trim() <> "" Then
                        Dim nouveau As New TreeNode(nom.Trim())
                        If pileParents.Count > 0 Then
                            pileParents.Peek().Nodes.Add(nouveau)
                        Else
                            treeView1.Nodes.Add(nouveau)
                        End If
                        nom = ""
                    End If
                    If pileParents.Count > 0 Then pileParents.Pop()
                End If

                i += 1
            End While

            ' Dernier nœud éventuel hors parenthèses
            If nom.Trim() <> "" Then
                Dim dernier As New TreeNode(nom.Trim())
                treeView1.Nodes.Add(dernier)
            End If

        End If

    End Sub

    'Fonction ExporterLarborescenceToolStripMenuItem_Click
    Public Sub ExporterLarborescenceToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        ' --- EXPORT ---

        ' Boîte de dialogue pour sélectionner le fichier de destination
        Dim dlgExport As New SaveFileDialog()
        dlgExport.Filter = "Fichiers ARB (*.arb)|*.arb"
        dlgExport.Title = "Exporter l'arborescence"
        dlgExport.DefaultExt = "arb"

        If dlgExport.ShowDialog() = DialogResult.OK Then
            Dim constructeur As New System.Text.StringBuilder()
            Dim pileNœuds As New System.Collections.Generic.Stack(Of TreeNode)()
            Dim pileFermetures As New System.Collections.Generic.Stack(Of Boolean)()

            ' Empiler racines en ordre inverse pour traitement correct
            For i As Integer = treeView1.Nodes.Count - 1 To 0 Step -1
                pileNœuds.Push(treeView1.Nodes(i))
                pileFermetures.Push(False) ' Faux = pas encore fermé
            Next

            While pileNœuds.Count > 0
                Dim nœud As TreeNode = pileNœuds.Pop()
                Dim fermer As Boolean = pileFermetures.Pop()

                ' Nettoyer et corriger couleurs quasi-blanc si blanc ou vide
                Dim couleurFond As Color = If(nœud.BackColor = Color.Empty OrElse nœud.BackColor.ToArgb() = Color.White.ToArgb(), Color.FromArgb(254, 254, 254), nœud.BackColor)
                Dim couleurTexte As Color = If(nœud.ForeColor = Color.Empty OrElse nœud.ForeColor.ToArgb() = Color.White.ToArgb(), Color.FromArgb(254, 254, 254), nœud.ForeColor)

                ' Ajouter nom
                constructeur.Append(nœud.Text)

                ' Si nœud a enfants, ouvrir parenthèse et empiler enfants
                If nœud.Nodes.Count > 0 Then
                    constructeur.Append("(")

                    For i As Integer = nœud.Nodes.Count - 1 To 0 Step -1
                        pileNœuds.Push(nœud.Nodes(i))
                        ' Le dernier enfant aura fermeture parenthèse à la sortie
                        pileFermetures.Push(i = 0)
                    Next
                End If

                ' Ajouter bloc [Tag;BackColor;ForeColor]
                Dim tagTxt As String = If(nœud.Tag IsNot Nothing, nœud.Tag.ToString(), "")
                Dim fondStr As String = couleurFond.ToArgb().ToString()
                Dim texteStr As String = couleurTexte.ToArgb().ToString()

                constructeur.Append("[" & tagTxt & ";" & fondStr & ";" & texteStr & "]")

                ' Ajouter point-virgule si nœud suivant même niveau existe
                Dim prochainNœudMemeParent As Boolean = False
                If pileNœuds.Count > 0 Then
                    Dim prochain As TreeNode = pileNœuds.Peek()
                    prochainNœudMemeParent = (prochain.Parent Is nœud.Parent)
                End If
                If prochainNœudMemeParent Then
                    constructeur.Append(";")
                End If

                ' Fermer parenthèse si demandé
                If fermer Then
                    constructeur.Append(")")
                End If
            End While

            ' Écriture dans fichier
            System.IO.File.WriteAllText(dlgExport.FileName, constructeur.ToString(), System.Text.Encoding.UTF8)
        End If
    End Sub

    'Fonction button5_Click
    Public Sub button5_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        If colorDialog1.ShowDialog() = DialogResult.OK Then
            If treeView1.SelectedNode IsNot Nothing Then
                ' Si le noeud sélectionné existe, modifie sa couleur de fond
                treeView1.SelectedNode.BackColor = colorDialog1.Color
                treeView1.Invalidate() ' Forcer le rafraîchissement de l'élément
            Else
                System.Windows.Forms.MessageBox.Show("Veuillez sélectionner un nœud.", "Information", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information)
            End If
        End If

        ' Deselect the selected node after modifying it
        treeView1.SelectedNode = Nothing
        Me.Refresh()

    End Sub

    'Fonction button8_Click
    Public Sub button8_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        If colorDialog1.ShowDialog() = DialogResult.OK Then
            If treeView1.SelectedNode IsNot Nothing Then
                ' Si le noeud sélectionné existe, modifie la couleur du texte (ForeColor)
                treeView1.SelectedNode.ForeColor = colorDialog1.Color
                treeView1.Invalidate() ' Forcer le rafraîchissement de l'élément
            Else
                System.Windows.Forms.MessageBox.Show("Veuillez sélectionner un nœud.", "Information", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information)
            End If
        End If

        ' Deselect the selected node after modifying it
        treeView1.SelectedNode = Nothing
        Me.Refresh()

    End Sub
    
    'Fonction label11_Click
    Public Sub label11_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Boîte_de_dialogue3.ShowDialog()
    End Sub
End Class
