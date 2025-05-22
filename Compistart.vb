Public Class Compistart

    Public FichierCache As String = ""
    Public fichier_a_importer As String = "" ' Chemin du fichier à importer    


    'Fonction Fenêtre2_Load
    Public Sub Fenêtre2_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Cette fonction se déclenche à l'ouverture de la fenêtre.
        '
        'This function is launched during opening.
        SequenceDemarrage()


        FichierCache =
        "%[COMPTES]%" & Chr(13) & Chr(10) &
        "admin %10%/[bloqué=false]/{actif=true}/¤admin¤/()" & Chr(13) & Chr(10) &
        "%[COMPTES.END]%" & Chr(13) & Chr(10) &
        "%[HORAIRES]%" & Chr(13) & Chr(10) &
        "ON=00:00" & Chr(13) & Chr(10) &
        "OFF=00:00" & Chr(13) & Chr(10) &
        "%[HORAIRES.END]%" & Chr(13) & Chr(10) &
        "%[PARAMETRES]%" & Chr(13) & Chr(10) &
        "badges=True" & Chr(13) & Chr(10) &
        "rewardregularusers=True" & Chr(13) & Chr(10) &
        "aiusers=False" & Chr(13) & Chr(10) &
        "limitPrvMsg=False" & Chr(13) & Chr(10) &
        "limitPbcMsg=False" & Chr(13) & Chr(10) &
        "messagerie=ouvert" & Chr(13) & Chr(10) &
        "repNumBloqués=raccrocher" & Chr(13) & Chr(10) &
        "NumBloqués=(0xxxxxxxxx;0xxxxxxxxx;0xxxxxxxxx)" & Chr(13) & Chr(10) &
        "BloquerDeconnectBrut=True" & Chr(13) & Chr(10) &
        "BloquerSpam=True" & Chr(13) & Chr(10) &
        "BPS=1200" & Chr(13) & Chr(10) &
        "NumServ=0xxxxxxxxx" & Chr(13) & Chr(10) &
        "TypeServ=Local" & Chr(13) & Chr(10) &
        "Modem=Local" & Chr(13) & Chr(10) &
        "Serial=COM3" & Chr(13) & Chr(10) &
        "Repondeur=False[None]" & Chr(13) & Chr(10) &
        "AdaptFlow=False" & Chr(13) & Chr(10) &
        "LECAM=false" & Chr(13) & Chr(10) &
        "%[PARAMETRES.END]%" & Chr(13) & Chr(10) &
        "%[PARAM_ADMIN]%" & Chr(13) & Chr(10) &
        "activé=True" & Chr(13) & Chr(10) &
        "CFZadmin=True" & Chr(13) & Chr(10) &
        "AdminPerm=True" & Chr(13) & Chr(10) &
        "AdminDelay=None" & Chr(13) & Chr(10) &
        "Prix=0(en€)" & Chr(13) & Chr(10) &
        "USERS=(pseudo;pseudo;pseudo)" & Chr(13) & Chr(10) &
        "ServOwner=(pseudo)" & Chr(13) & Chr(10) &
        "%[PARAM_ADMIN.END]%"

    End Sub

    'Fonction button1_Click
    Public Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
    End Sub

    'Fonction button2_Click
    Public Sub button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button2.Click
    End Sub

    'Fonction button3_Click
    Public Sub button3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button3.Click
    End Sub

    'Fonction button4_Click
    Public Sub button4_Click(ByVal sender As Object, ByVal e As System.EventArgs)
    End Sub

    'Fonction checkBox1_CheckedChanged
    Public Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkbox1.CheckedChanged
    End Sub


    'Fonction button19_Click
    Public Sub button19_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button19.Click
    End Sub



    'Fonction button18_Click
    Public Sub button18_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button18.Click
        Me._numericUpDown5.Value = "0"
    End Sub

    'Fonction button20_Click
    Public Sub button20_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button20.Click
    End Sub

    'Fonction button6_Click
    Public Sub button6_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button6.Click
    End Sub

    'Fonction button8_Click
    Public Sub button8_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button8.Click
    End Sub

    'Fonction button9_Click
    Public Sub button9_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button9.Click
    End Sub

    'Fonction button10_Click
    Public Sub button10_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button10.Click
    End Sub

    'Fonction button11_Click
    Public Sub button11_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button11.Click
    End Sub

    'Fonction button13_Click
    Public Sub button13_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button13.Click
    End Sub

    'Fonction button12_Click
    Public Sub button12_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button12.Click
    End Sub

    'Fonction button14_Click
    Public Sub button14_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button14.Click
    End Sub

    'Fonction button15_Click
    Public Sub button15_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button15.Click
    End Sub

    'Fonction button17_Click
    Public Sub button17_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button17.Click
        Dim dlg As New OpenFileDialog()
        dlg.Title = "Sélectionnez le fichier d'arborescence"
        dlg.Filter = "Fichiers ARB (*.arb)|*.arb|Tous les fichiers (*.*)|*.*"
        dlg.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)

        Dim chemin As String = ""

        If dlg.ShowDialog() = DialogResult.OK Then
            chemin = dlg.FileName
            If ImporterArborescenceDepuisFichier(chemin, treeView1) = False Then
                AjouterALaConsole(">> Erreur lors de l'importation du fichier : " & chemin)
            Else
                fichier_a_importer = chemin
                AjouterALaConsole("Succès de l'importation" & fichier_a_importer)
            End If
        End If


    End Sub

    'Fonction button31_Click
    Public Sub button31_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button31.Click
        Boîte_de_dialogue6.Show()
    End Sub

    'Fonction radioButton12_CheckedChanged
    Public Sub radioButton12_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles radiobutton12.CheckedChanged
        variabe_case_oui_cochée_compistart = Me.checkbox6.Checked
        If variabe_case_oui_cochée_compistart = True Then
        Else
            VelerSoftware_VistaMessageBox.Show(Nothing, "Avertissement", "", "Je crois que vous n'avez pas" & System.Environment.NewLine & "vraiment envie de faire ça.", VelerSoftware.VistaMessageBoxLib.VistaMessageBoxIcon.None, "", False, "", False, New VelerSoftware.VistaMessageBoxLib.VistaMessageBoxButton() {New VelerSoftware.VistaMessageBoxLib.VistaMessageBoxButton(VelerSoftware.VistaMessageBoxLib.VistaMessageBoxResult.Abort)}, VelerSoftware.VistaMessageBoxLib.VistaMessageBoxIcon.SecurityShield, False)
        End If
    End Sub

    'Fonction button47_Click
    Public Sub button47_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button47.Click
        Me.colorDialog1.ShowDialog().ToString()
    End Sub

    'Fonction button50_Click
    Public Sub button50_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button50.Click
    End Sub

    'Fonction button51_Click
    Public Sub button51_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button51.Click
        FenêtreAvertissement.Show()
    End Sub

    'Fonction démarrerLeServeurToolStripMenuItem_Click
    Public Sub démarrerLeServeurToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles démarrerLeServeurToolStripMenuItem.Click
        Me.arrêterLeServeurToolStripMenuItem.Visible = True
        Me.démarrerLeServeurToolStripMenuItem.Visible = False
    End Sub

    'Fonction arrêterLeServeurToolStripMenuItem_Click
    Public Sub arrêterLeServeurToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles arrêterLeServeurToolStripMenuItem.Click
        Me.démarrerLeServeurToolStripMenuItem.Visible = True
        Me.arrêterLeServeurToolStripMenuItem.Visible = False
    End Sub

    'Fonction siToolStripMenuItem_Click
    Public Sub siToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles siToolStripMenuItem.Click
    End Sub

    'Fonction button44_Click
    Public Sub button44_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button44.Click
        Compiler()
        panel2.Visible = True
    End Sub

    'Fonction button58_Click
    Public Sub button58_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button58.Click
        Boîte_de_dialogueBarre.ShowDialog()
    End Sub

    'Fonction trackBar1_Scroll
    Public Sub trackBar1_Scroll(ByVal sender As Object, ByVal e As System.EventArgs) Handles trackbar1.Scroll
        label10.Text = "Actuel : " & trackbar1.Value.ToString()

    End Sub

    'Fonction trackBar1_ValueChanged
    Public Sub trackBar1_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles trackbar1.ValueChanged
        label10.Text = "Actuel : " & trackbar1.Value.ToString()

    End Sub

    'Fonction checkBox12_CheckedChanged
    Public Sub checkBox12_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkbox12.CheckedChanged
    End Sub

    'Fonction checkBox14_CheckedChanged
    Public Sub checkBox14_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkbox14.CheckedChanged
    End Sub

    'Fonction checkBox13_CheckedChanged
    Public Sub checkBox13_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkbox13.CheckedChanged
    End Sub

    'Fonction checkBox15_CheckedChanged
    Public Sub checkBox15_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkbox15.CheckedChanged
    End Sub

    'Fonction checkBox16_CheckedChanged
    Public Sub checkBox16_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkbox16.CheckedChanged
    End Sub

    'Fonction checkBox17_CheckedChanged
    Public Sub checkBox17_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkbox17.CheckedChanged
    End Sub


    'Fonction checkBox6_CheckedChanged
    Public Sub checkBox6_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkbox6.CheckedChanged
    End Sub

    'Fonction button61_Click
    Public Sub button61_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button61.Click
        Dim fenetreArboEdit As ArboEdit = Nothing

        ' Rechercher si une instance d'ArboEdit est déjà ouverte
        For Each frm As Form In Application.OpenForms
            If TypeOf frm Is ArboEdit Then
                fenetreArboEdit = CType(frm, ArboEdit)
                Exit For
            End If
        Next

        ' Si la fenêtre n'existe pas, on la crée
        If fenetreArboEdit Is Nothing Then
            fenetreArboEdit = New ArboEdit()
            ArboEdit = fenetreArboEdit ' 🔴 Affectation à la variable globale
            fenetreArboEdit.Show()
        Else
            fenetreArboEdit.BringToFront()
            ArboEdit = fenetreArboEdit ' 🔴 Affectation aussi ici
        End If

        ' Attendre que la fenêtre soit affichée avant d'exécuter la fonction
        Do Until fenetreArboEdit.Visible
            Application.DoEvents()
        Loop

        ' Exécuter la fonction une fois que la fenêtre est visible
        ImporterArborescenceDepuisFichier(fichier_a_importer, ArboEdit.treeView1)
        Application.DoEvents()

    End Sub

    'Fonction button62_Click
    Public Sub button62_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button62.Click
        panel2.Visible = False
    End Sub

    'Fonction FnctsAnnuaire
    Public Sub FnctsAnnuaire(ByVal sender As Object, ByVal e As System.EventArgs) Handles radiobutton12.BackgroundImageChanged
    End Sub
    'Mettez vos fonctions ici
    'Pas de End Sub à la
    'fin de la TOUTE dernière fonction

    Function AjouterParametre(section As String, nomParam As String, valeur As String) As Boolean
        Dim debutTag As String = "%[" & section & "]%"
        Dim finTag As String = "%[" & section & ".END]%"
        Dim lignes() As String = FichierCache.Split({vbCrLf}, StringSplitOptions.None)

        Dim debutIndex As Integer = Array.IndexOf(lignes, debutTag)
        Dim finIndex As Integer = Array.IndexOf(lignes, finTag)

        If debutIndex = -1 Or finIndex = -1 Or debutIndex >= finIndex Then
            Return False ' Section non trouvée ou mal formée
        End If

        ' Insère le paramètre juste avant la balise de fin
        Dim nouvelleListe As New System.Collections.Generic.List(Of String)(lignes)
        nouvelleListe.Insert(finIndex, nomParam & "=" & valeur)

        FichierCache = String.Join(vbCrLf, nouvelleListe)
        Return True
    End Function


    Function LireParametre(section As String, nomParam As String) As String
        Dim debutTag As String = "%[" & section & "]%"
        Dim finTag As String = "%[" & section & ".END]%"
        Dim lignes() As String = FichierCache.Split(New String() {vbCrLf}, StringSplitOptions.None)

        Dim dansSection As Boolean = False
        For Each ligne As String In lignes
            If ligne = debutTag Then
                dansSection = True
            ElseIf ligne = finTag Then
                Exit For
            ElseIf dansSection Then
                ' Ligne dans la section
                If ligne.StartsWith(nomParam & "=") Then
                    ' Retourne la partie après le signe égal
                    Return ligne.Substring(nomParam.Length + 1)
                End If
            End If
        Next

        Return "" ' Paramètre non trouvé
    End Function



    'Sub ModifierParametre(nom As String, valeur As String)
    'If FichierCache.Parametres.ContainsKey(nom) Then
    'FichierCache.Parametres(nom) = valeur
    'Else
    '         FichierCache.Parametres.Add(nom, valeur)
    'End If
    ' End Sub


    Public Function ImporterArborescenceDepuisFichier(cheminFichier As String, TreeView1 As TreeView) As Boolean
        Dim succes As Boolean = False

        If Not System.IO.File.Exists(cheminFichier) Then
            succes = False ' Le fichier n'existe pas
        Else
            Try
                Dim contenu As String = System.IO.File.ReadAllText(cheminFichier)
                TreeView1.Nodes.Clear()

                Dim pileParents As New System.Collections.Generic.Stack(Of TreeNode)()
                Dim i As Integer = 0
                Dim nom As String = ""

                While i < contenu.Length
                    Dim c As Char = contenu(i)

                    If Char.IsLetterOrDigit(c) OrElse c = "_"c OrElse c = "-"c OrElse c = " "c Then
                        nom &= c

                    ElseIf c = "("c Then
                        Dim nouveau As New TreeNode(nom.Trim())
                        nom = ""

                        If pileParents.Count > 0 Then
                            pileParents.Peek().Nodes.Add(nouveau)
                        Else
                            TreeView1.Nodes.Add(nouveau)
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
                        Dim fond As Integer = If(morceaux.Length > 1, CInt(morceaux(1)), -1)
                        Dim texte As Integer = If(morceaux.Length > 2, CInt(morceaux(2)), -1)

                        Dim cible As TreeNode = Nothing
                        If nom.Trim() <> "" Then
                            cible = New TreeNode(nom.Trim())
                            If pileParents.Count > 0 Then
                                pileParents.Peek().Nodes.Add(cible)
                            Else
                                TreeView1.Nodes.Add(cible)
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
                                TreeView1.Nodes.Add(nouveau)
                            End If
                            nom = ""
                        End If

                    ElseIf c = ")"c Then
                        If nom.Trim() <> "" Then
                            Dim nouveau As New TreeNode(nom.Trim())
                            If pileParents.Count > 0 Then
                                pileParents.Peek().Nodes.Add(nouveau)
                            Else
                                TreeView1.Nodes.Add(nouveau)
                            End If
                            nom = ""
                        End If
                        If pileParents.Count > 0 Then pileParents.Pop()
                    End If

                    i += 1
                End While

                If nom.Trim() <> "" Then
                    Dim dernier As New TreeNode(nom.Trim())
                    TreeView1.Nodes.Add(dernier)
                End If

                succes = True ' Importation réussie

            Catch ex As Exception
                ' Gérer les erreurs si nécessaire (affichage, log...)
                succes = False
            End Try
        End If

        ImporterArborescenceDepuisFichier = succes
    End Function


    Private Async Sub SequenceDemarrage()
        ' Délai initial de 500 ms (non bloquant)
        Await System.Threading.Tasks.Task.Delay(700)

        ' Message 1
        AjouterALaConsole("Démarrage en cours...")

        ' Délai de 1000 ms
        Await System.Threading.Tasks.Task.Delay(1900)

        ' Message 2
        AjouterALaConsole("Prêt")
    End Sub

    Sub AjouterALaConsole(texte As String)
        Dim lignes() As String = TextBoxConsole.Lines
        Dim nouvellesLignes As New System.Collections.Generic.List(Of String)
        Dim textesDéjàAjoutés As New System.Collections.Generic.HashSet(Of String)

        ' Ajout des lignes existantes (en supprimant la flèche si présente) sans doublons
        For Each ligne As String In lignes
            Dim texteNettoye As String = ligne.TrimStart(">"c, " "c) ' Supprime "> " au début si présent
            If Not textesDéjàAjoutés.Contains(texteNettoye) Then
                nouvellesLignes.Add(">> " & texteNettoye)
                textesDéjàAjoutés.Add(texteNettoye)
            End If
        Next

        ' Ajout du nouveau texte s'il n'existe pas déjà
        Dim nouveauTexteNettoye As String = texte.TrimStart(">"c, " "c)
        If Not textesDéjàAjoutés.Contains(nouveauTexteNettoye) Then
            nouvellesLignes.Add(">> " & nouveauTexteNettoye)
        End If

        TextBoxConsole.Lines = nouvellesLignes.ToArray()

        TextBoxConsole.SelectionStart = TextBoxConsole.Text.Length
        TextBoxConsole.ScrollToCaret()
    End Sub

    'STOP!!!! ZONE DE DANGER,
    'NE PLUS AJOUTER DE FONCTIONS CI-DESSOUS

    Sub Compiler()
        While Me.progressBar1.Value < 100
            Me.progressBar1.Value += 1
            Me.progressBar2.Value = Me.progressBar1.Value ' Synchronisation
            Me.progressbar3.Value = Me.progressBar1.Value ' Synchronisation

            Me.label16.Text = CStr(Me.progressBar1.Value) & "%"
            Me.toolStripProgressBar1.Value += 1
            Me.toolStripStatusLabel1.Text = "Compilation " & CStr(Me.toolStripProgressBar1.Value) & "%"

            Application.DoEvents() ' Permet à l'interface graphique de se mettre à jour
            Threading.Thread.Sleep(50) ' Pause pour une progression visible
        End While

        Compilation = True
        AjouterALaConsole("Compilation terminée !")

        Me.progressBar1.Value = 0
        Me.progressBar2.Value = 0
        Me.progressbar3.Value = 0
        Me.toolStripProgressBar1.Value = 0

        Me.label16.Text = "Prêt"
        Me.toolStripStatusLabel1.Text = "Prêt"
    End Sub

    'Fonction button63_Click
    Public Sub button63_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button63.Click
    End Sub
End Class
