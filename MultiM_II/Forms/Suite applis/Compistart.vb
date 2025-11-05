Imports System.Collections.Generic
Imports System.Linq
Imports System.IO.Ports
Imports System.IO

Public Class Compistart

    Public FichierCache As String = "" 'Fichier de configuration *.serv en cache
    Public fichier_a_importer As String = "" ' Chemin du fichier à importer    
    Public AfficherParamConsole As Boolean = False ' Variable pour afficher les paramètres dans la console
    Public AppelEnCours As Boolean = False 'Appel en cours?
    Public line1 As String = "actualuser=;phone=;maxflow=1200;M12Msg=true;M12Rep=true;sigIntensity=5;MinitelType=M12;ROM=" 'Variables de ligne téléphonique 1
    Public line2 As String = "actualuser=;phone=;maxflow=1200;M12Msg=true;M12Rep=true;sigIntensity=5;MinitelType=M12;ROM=" 'Variables de ligne téléphonique 2
    Public line3 As String = "actualuser=;phone=;maxflow=1200;M12Msg=true;M12Rep=true;sigIntensity=5;MinitelType=M12;ROM=" 'Variables de ligne téléphonique 3
    Public selectedLine As Integer = 0 'Quelle ligne télép)honique est sélectionnée?

    'Ouverture Compistart
    Public Sub Fenêtre2_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Initialisation des ressources
        'Initialisation de la séquence de boot
        SequenceDemarrage()
        'Initialisation du cache du fichier de configuration *.serv par défaut
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
        "NumBloqués=(0000000000;1111111111;2222222222)" & Chr(13) & Chr(10) &
        "BloquerDeconnectBrut=True" & Chr(13) & Chr(10) &
        "BloquerSpam=True" & Chr(13) & Chr(10) &
        "InitString=ATZ" & Chr(13) & Chr(10) &
        "Timeout=5000" & Chr(13) & Chr(10) &
        "ModeSonnerie=0" & Chr(13) & Chr(10) &
        "Volume=2" & Chr(13) & Chr(10) &
        "Retry=3" & Chr(13) & Chr(10) &
        "AutoHangUpDelay=0" & Chr(13) & Chr(10) &
        "LogLevel=2" & Chr(13) & Chr(10) &
        "PhoneBook=(0123456789;0987654321)" & Chr(13) & Chr(10) &
        "EnableSMS=False" & Chr(13) & Chr(10) &
        "ServiceCenter=+33695001390" & Chr(13) & Chr(10) &
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
        "%[PARAM_ADMIN.END]%" & Chr(13) & Chr(10) &
        "%[FONCTIONS]%" & Chr(13) & Chr(10) &
        "Fonction1=(Quand)[Alors]" & Chr(13) & Chr(10) &
        "Fonction2=(Quand)[Alors]" & Chr(13) & Chr(10) &
        "%[FONCTIONS.END]%"

        refreshTimer.Start()

        If LireParametre("parametres", "Serial") = "COM1" Then
            COM1.Checked = True
            COM2.Checked = False
            COM3.Checked = False
            COM4.Checked = False
            Other.Checked = False
            Automatic.Checked = False
        ElseIf LireParametre("parametres", "Serial") = "COM2" Then
            COM1.Checked = False
            COM2.Checked = True
            COM3.Checked = False
            COM4.Checked = False
            Other.Checked = False
            Automatic.Checked = False
        ElseIf LireParametre("parametres", "Serial") = "COM3" Then
            COM1.Checked = False
            COM2.Checked = False
            COM3.Checked = True
            COM4.Checked = False
            Other.Checked = False
            Automatic.Checked = False
        ElseIf LireParametre("parametres", "Serial") = "COM4" Then
            COM1.Checked = False
            COM2.Checked = False
            COM3.Checked = False
            COM4.Checked = True
            Other.Checked = False
            Automatic.Checked = False
        ElseIf LireParametre("parametres", "Serial") = "Automatic" Then
            COM1.Checked = False
            COM2.Checked = False
            COM3.Checked = False
            COM4.Checked = False
            Other.Checked = False
            Automatic.Checked = True
        Else
            COM1.Checked = False
            COM2.Checked = False
            COM3.Checked = False
            COM4.Checked = False
            Other.Checked = True
            Automatic.Checked = False
        End If

        If LireParametre("parametres", "messagerie") = "ouvert" Then
            Ouvert.Checked = True
            OuvertFermé.Checked = False
            Fermé.Checked = False
        ElseIf LireParametre("parametres", "messagerie") = "OuvertFermé" Then
            Ouvert.Checked = False
            OuvertFermé.Checked = True
            Fermé.Checked = False
        Else
            Ouvert.Checked = False
            OuvertFermé.Checked = False
            Fermé.Checked = True
        End If

        If LireParametre("parametres", "repNumbloqués") = "raccrocher" Then
            variabe_case_oui_cochée_compistart = True
            checkbox6.Checked = True
            raccrocher.Checked = True
            telMsg.Checked = False
            minitelPage.Checked = False
        ElseIf LireParametre("parametres", "repNumbloqués") = "telMsg" Then
            variabe_case_oui_cochée_compistart = False
            checkbox6.Checked = False
            raccrocher.Checked = False
            telMsg.Checked = True
            minitelPage.Checked = False
        ElseIf LireParametre("parametres", "repNumbloqués") = "minitelPage" Then
            variabe_case_oui_cochée_compistart = False
            checkbox6.Checked = False
            raccrocher.Checked = False
            telMsg.Checked = False
            minitelPage.Checked = True

        End If

        ChargerNumerosBloques()
        label10.Text = "Actuel" & LireParametre("parametres", "BPS")
        comboBox1.SelectedItem = LireParametre("parametres", "TypeServ")
        comboBox2.SelectedItem = LireParametre("parametres", "Modem")
    End Sub

    Public Sub Connect()
        If Not AppelEnCours Then
            AjouterALaConsole(">> Impossible de se connecter : aucun appel en cours.")
            Exit Sub
        End If

        Try
            ' Envoie une commande pour établir une connexion de données
            modemPort.WriteLine("ATO" & vbCr)
            AjouterALaConsole(">> Tentative de connexion à l'appareil distant...")

            Threading.Thread.Sleep(2000)
            Dim rep As String = modemPort.ReadExisting()
            AjouterALaConsole(">> Réponse modem: " & rep)

            If rep.Contains("CONNECT") Then
                AjouterALaConsole(">> Connecté à l'appareil distant.")
            Else
                AjouterALaConsole(">> La connexion a échoué ou pas de réponse correcte.")
            End If

        Catch ex As Exception
            AjouterALaConsole(">> Erreur Connect: " & ex.Message)
        End Try
    End Sub

    Public Sub HangUp() 'Raccrocher l'appel en cours
        Try
            If modemPort IsNot Nothing AndAlso modemPort.IsOpen Then
                modemPort.WriteLine("ATH" & vbCr)
                AjouterALaConsole(">> Raccrochage de l'appel en cours.")
                AppelEnCours = False
                modemPort.Close()
            Else
                AjouterALaConsole(">> Aucun port ouvert pour raccrocher.")
            End If
        Catch ex As Exception
            AjouterALaConsole(">> Erreur HangUp: " & ex.Message)
        End Try
    End Sub


    Public Function ModifierParametre(section As String, nomParam As String, nouvelleValeur As String) As Boolean 'Modifier un paramètre de FichierCache
        ' Séparer le fichier en lignes
        Dim lignes() As String = FichierCache.Split({vbCrLf}, StringSplitOptions.None)
        Dim modifié As Boolean = False

        For i As Integer = 0 To lignes.Length - 1
            If lignes(i).Trim().StartsWith(nomParam & "=", StringComparison.OrdinalIgnoreCase) Then
                Dim ancienneValeur As String = lignes(i).Substring(nomParam.Length + 1)
                lignes(i) = nomParam & "=" & nouvelleValeur
                modifié = True
                If AfficherParamConsole = True Then
                    ' Mettre à jour la console
                    AjouterALaConsole(">> Paramètre [" & nomParam & "] modifié : " & ancienneValeur & " → " & nouvelleValeur)
                    Exit For
                End If
            End If
        Next

        ' Mise à jour de FichierCache si le paramètre a été trouvé
        If modifié Then
            FichierCache = String.Join(vbCrLf, lignes)
        Else
            AjouterALaConsole(">> Erreur : paramètre [" & nomParam & "] introuvable.")
        End If
        Return True
    End Function


    Private Sub ImporterFichierCache() 'Importer une configuration depuis un fichier .serv
        ' Ouvre une boîte de sélection de fichier
        Dim dlg As New OpenFileDialog()
        dlg.Filter = "Fichiers de configuration (*.serv)|*.serv"
        dlg.Title = "Sélectionner un fichier .serv à réimporter"

        If dlg.ShowDialog() = DialogResult.OK Then
            Try
                ' Lit le contenu du fichier sélectionné
                Dim contenu As String = File.ReadAllText(dlg.FileName)

                ' Remplace le cache actuel
                FichierCache = contenu

                ' Message de confirmation
                MessageBox.Show("Le fichier a été réimporté avec succès.", "Importation terminée", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception
                MessageBox.Show("Erreur lors de la lecture du fichier : " & ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub


    Sub ExporterFichierCache() 'Exporter la configuration courante dans un fichier .serv
        ' Crée un objet SaveFileDialog
        Dim dlg As New System.Windows.Forms.SaveFileDialog()

        ' Configure la boîte de dialogue
        dlg.Title = "Enregistrer le fichier .serv"
        dlg.Filter = "Fichiers serv (*.serv)|*.serv|Tous les fichiers (*.*)|*.*"
        dlg.DefaultExt = "serv"
        dlg.AddExtension = True

        ' Affiche la boîte de dialogue à l'utilisateur
        If dlg.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Dim cheminFichier As String = dlg.FileName

            ' Enregistrer FichierCache dans le fichier choisi
            Try
                ' Utilise System.IO.File.WriteAllText en nom complet (sans Imports)
                System.IO.File.WriteAllText(cheminFichier, FichierCache, System.Text.Encoding.UTF8)
                MsgBox("Fichier enregistré avec succès : " & cheminFichier)
            Catch ex As Exception
                MsgBox("Erreur lors de l'enregistrement : " & ex.Message)
            End Try
        End If
    End Sub


    Public Sub CallNumber(Number As String) 'Appeler un numéro
        Try
            ' Lecture des paramètres
            Dim portName As String = LireParametre("parametres", "Serial")
            Dim baudRate As Integer = CInt(LireParametre("parametres", "BPS"))
            Dim initString As String = LireParametre("parametres", "InitString")
            Dim timeout As Integer = CInt(LireParametre("parametres", "Timeout"))
            Dim volume As String = LireParametre("parametres", "Volume")
            Dim retry As Integer = CInt(LireParametre("parametres", "Retry"))
            Dim autoHangUp As Integer = CInt(LireParametre("parametres", "AutoHangUpDelay"))

            ' Ouvrir le port
            modemPort = New IO.Ports.SerialPort(portName, baudRate, IO.Ports.Parity.None, 8, IO.Ports.StopBits.One)
            modemPort.ReadTimeout = timeout
            modemPort.WriteTimeout = timeout
            modemPort.Open()

            AjouterALaConsole(">> Port " & portName & " ouvert à " & baudRate & " bps.")

            ' Initialisation modem
            modemPort.WriteLine(initString & vbCr)
            AjouterALaConsole(">> Init modem: " & initString)

            ' Réglage du volume
            modemPort.WriteLine("ATM" & volume & vbCr)
            AjouterALaConsole(">> Volume HP: " & volume)

            ' Tentatives d’appel
            Dim success As Boolean = False
            For i As Integer = 1 To retry
                modemPort.WriteLine("ATD" & Number & ";" & vbCr)
                AjouterALaConsole(">> Tentative d'appel " & i & " vers " & Number)

                Threading.Thread.Sleep(2000) ' Attente réponse
                Dim rep As String = modemPort.ReadExisting()
                AjouterALaConsole(">> Réponse modem: " & rep)

                If rep.Contains("CONNECT") Or rep.Contains("OK") Then
                    success = True
                    Exit For
                End If
            Next

            If success Then
                AppelEnCours = True
                AjouterALaConsole(">> Appel établi avec " & Number)

                ' Auto hangup si demandé
                If autoHangUp > 0 Then
                    Dim t As New Threading.Timer(
                    Sub()
                        HangUp()
                    End Sub,
                    Nothing,
                    autoHangUp * 1000,
                    Threading.Timeout.Infinite
                )
                End If
            Else
                AjouterALaConsole(">> Echec d'appel après " & retry & " tentatives.")
            End If

        Catch ex As Exception
            AjouterALaConsole(">> Erreur CallNumber: " & ex.Message)
        End Try
    End Sub

    Public Sub ChargerNumerosBloques()
        ' Lire la valeur du paramètre NumBloqués
        Dim valeur As String = LireParametre("parametres", "NumBloqués")

        ' On sauvegarde l'item "Afficher la liste complète"
        Dim itemAfficher = AfficherLaListeComplèteToolStripMenuItem

        ' On vide tout sauf cet item
        NumérosBloquésToolStripMenuItem.DropDownItems.Clear()
        NumérosBloquésToolStripMenuItem.DropDownItems.Add(itemAfficher)

        If String.IsNullOrEmpty(valeur) Then
            AjouterALaConsole("Aucun numéro bloqué.")
            Return
        End If

        ' Nettoyer le format "(xxx;yyy)"
        valeur = valeur.Trim("("c, ")"c)

        ' Split sur les ';'
        Dim numeros() As String = valeur.Split(";"c)

        For Each num In numeros
            If String.IsNullOrWhiteSpace(num) Then Continue For

            ' Élément parent = numéro
            Dim item As New ToolStripMenuItem(num)

            ' ---- Débloquer ----
            Dim subDebloquer As New ToolStripMenuItem("Débloquer")
            subDebloquer.Tag = num
            AddHandler subDebloquer.Click, AddressOf DebloquerToolStripMenuItem_Click
            item.DropDownItems.Add(subDebloquer)

            ' ---- Réponse spécifique ----
            Dim subReponse As New ToolStripMenuItem("Définir une réponse spécifique")
            subReponse.Tag = num
            AddHandler subReponse.Click, AddressOf DefineCustomAnsw
            item.DropDownItems.Add(subReponse)

            ' ---- Appeler ----
            Dim subCall As New ToolStripMenuItem("Appeler")
            subCall.Tag = num
            AddHandler subCall.Click, AddressOf CallLockNumber
            item.DropDownItems.Add(subCall)

            ' Ajouter au menu principal
            NumérosBloquésToolStripMenuItem.DropDownItems.Add(item)
        Next

        AjouterALaConsole("Menu des numéros bloqués mis à jour.")
    End Sub



    Private Sub DefineCustomAnsw(sender As Object, e As EventArgs)
        Dim numero As String = CType(sender, ToolStripMenuItem).Tag
        AjouterALaConsole("Définir réponse spécifique pour : " & numero)
    End Sub

    Private Sub CallLockNumber(sender As Object, e As EventArgs)
        Dim numero As String = CType(sender, ToolStripMenuItem).Tag
        AjouterALaConsole("Appel du numéro : " & numero)
    End Sub


    Public Sub addLockedNumber(ByVal nom As String)
        ' Crée l'item principal (numéro)
        Dim item As New ToolStripMenuItem(nom)

        ' ---- Sous-item Débloquer ----
        Dim subDebloquer As New ToolStripMenuItem("Débloquer")
        AddHandler subDebloquer.Click, AddressOf DebloquerToolStripMenuItem_Click
        item.DropDownItems.Add(subDebloquer)

        ' ---- Sous-item Définir une réponse spécifique ----
        item.DropDownItems.Add("Définir une réponse spécifique")

        ' ---- Sous-item Appeler ----
        item.DropDownItems.Add("Appeler")

        ' Ajoute l'item dans "NumérosBloquésToolStripMenuItem"
        NumérosBloquésToolStripMenuItem.DropDownItems.Add(item)

        ' ---- Mise à jour du paramètre NumBloqués ----
        Dim valeurActuelle As String = LireParametre("parametres", "NumBloqués")
        Dim nouvelleValeur As String

        ' Nettoyer l'ancienne valeur (parenthèses enlevées si présentes)
        valeurActuelle = valeurActuelle.Trim("("c, ")"c)

        If String.IsNullOrEmpty(valeurActuelle) Then
            nouvelleValeur = "(" & nom & ")"
        Else
            ' Ajouter avec un point-virgule
            nouvelleValeur = "(" & valeurActuelle & ";" & nom & ")"
        End If

        AjouterALaConsole(">> Nouvelle valeur NumBloqués : " & nouvelleValeur)

        ' Mettre à jour le paramètre
        ModifierParametre("parametres", "NumBloqués", nouvelleValeur)
    End Sub

    Private Sub DebloquerToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Try
            ' Le parent du "Débloquer" est le menu correspondant au numéro
            Dim debloquerItem As ToolStripMenuItem = DirectCast(sender, ToolStripMenuItem)
            Dim numeroItem As ToolStripMenuItem = DirectCast(debloquerItem.OwnerItem, ToolStripMenuItem)
            Dim numero As String = numeroItem.Text

            AjouterALaConsole(">> Déblocage demandé pour : " & numero)

            ' Lire la liste actuelle
            Dim valeurActuelle As String = LireParametre("parametres", "NumBloqués")
            valeurActuelle = valeurActuelle.Trim("("c, ")"c)
            Dim nums As List(Of String) = valeurActuelle.Split(";"c).ToList()

            ' Supprimer le numéro
            If nums.Contains(numero) Then
                nums.Remove(numero)
                AjouterALaConsole(">> Numéro supprimé de la liste : " & numero)
            Else
                AjouterALaConsole(">> Numéro non trouvé dans la liste : " & numero)
            End If

            ' Reconstruire avec parenthèses
            Dim nouvelleValeur As String = "(" & String.Join(";", nums) & ")"
            AjouterALaConsole(">> Nouvelle valeur NumBloqués : " & nouvelleValeur)

            ' Mettre à jour le paramètre
            ModifierParametre("parametres", "NumBloqués", nouvelleValeur)

            ' Supprimer aussi du menu
            NumérosBloquésToolStripMenuItem.DropDownItems.Remove(numeroItem)
            AjouterALaConsole(">> Numéro retiré du menu")

        Catch ex As Exception
            AjouterALaConsole(">> Erreur dans DebloquerToolStripMenuItem_Click : " & ex.Message)
            MessageBox.Show("Erreur lors du déblocage : " & ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    'Fonction button1_Click
    Public Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
    End Sub

    'Fonction button2_Click
    Public Sub button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button2.Click
    End Sub

    Private Sub RedefInc_Click(sender As Object, e As EventArgs) Handles RedefInc.Click
        NumericUpDown8.Increment = TSTB.Text
    End Sub

    Private Sub DFT_Click(sender As Object, e As EventArgs) Handles RedefInc.Click
        NumericUpDown8.Increment = 100
    End Sub

    'Fonction button3_Click
    Public Sub button3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button3.Click
    End Sub

    'Fonction button4_Click
    Public Sub button4_Click(ByVal sender As Object, ByVal e As System.EventArgs)
    End Sub

    'Fonction checkBox1_CheckedChanged
    Public Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkbox1.CheckedChanged
        If Me.checkbox1.Checked Then
            ModifierParametre("parametres", "repondeur", "True[None]")
        Else
            ModifierParametre("parametres", "repondeur", "False[None]")
        End If
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
    Public Sub radioButton12_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles raccrocher.CheckedChanged
        variabe_case_oui_cochée_compistart = Me.checkbox6.Checked
        If variabe_case_oui_cochée_compistart = True Then
            ModifierParametre("parametres", "repNumbloqués", "raccrocher")
        Else
            VelerSoftware_VistaMessageBox.Show(Nothing, "Avertissement", "", "Je crois que vous n'avez pas" & System.Environment.NewLine & "vraiment envie de faire ça.", VelerSoftware.VistaMessageBoxLib.VistaMessageBoxIcon.None, "", False, "", False, New VelerSoftware.VistaMessageBoxLib.VistaMessageBoxButton() {New VelerSoftware.VistaMessageBoxLib.VistaMessageBoxButton(VelerSoftware.VistaMessageBoxLib.VistaMessageBoxResult.Abort)}, VelerSoftware.VistaMessageBoxLib.VistaMessageBoxIcon.SecurityShield, False)
        End If
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
        If checkbox12.Checked Then
            ModifierParametre("parametres", "rewardregularusers", "True")
        Else
            ModifierParametre("parametres", "rewardregularusers", "False")
        End If
    End Sub

    'Fonction checkBox14_CheckedChanged
    Public Sub checkBox14_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkbox14.CheckedChanged
        If checkbox14.Checked Then
            ModifierParametre("parametres", "badges", "True")
        Else
            ModifierParametre("parametres", "badges", "False")
        End If
    End Sub

    'Fonction checkBox13_CheckedChanged
    Public Sub checkBox13_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkbox13.CheckedChanged
        If checkbox13.Checked Then
            ModifierParametre("parametres", "aiusers", "True")
        Else
            ModifierParametre("parametres", "aiusers", "False")
        End If
    End Sub

    'Fonction checkBox15_CheckedChanged
    Public Sub checkBox15_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkbox15.CheckedChanged
        If checkbox13.Checked Then
            ModifierParametre("parametres", "limitPbcMsg", "True")
        Else
            ModifierParametre("parametres", "limitPbcMsg", "False")
        End If
    End Sub

    'Fonction checkBox16_CheckedChanged
    Public Sub checkBox16_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkbox16.CheckedChanged
        If checkbox13.Checked Then
            ModifierParametre("parametres", "limitPrvMsg", "True")
        Else
            ModifierParametre("parametres", "limitPrvMsg", "False")
        End If
    End Sub

    'Fonction checkBox17_CheckedChanged
    Public Sub checkBox17_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkbox17.CheckedChanged
        If checkbox13.Checked Then
            ModifierParametre("parametres", "AdaptFlow", "True")
        Else
            ModifierParametre("parametres", "AdaptFlow", "False")
        End If
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
    Public Sub FnctsAnnuaire(ByVal sender As Object, ByVal e As System.EventArgs) Handles raccrocher.BackgroundImageChanged
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
            If ligne.Trim().Equals(debutTag, StringComparison.OrdinalIgnoreCase) Then
                dansSection = True
            ElseIf ligne.Trim().Equals(finTag, StringComparison.OrdinalIgnoreCase) Then
                Exit For
            ElseIf dansSection Then
                If ligne.StartsWith(nomParam & "=", StringComparison.OrdinalIgnoreCase) Then
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
        ' Supprime toute occurrence de ">>" ou "> " au début du texte
        Dim texteNettoye As String = texte.TrimStart(">"c, " "c)

        ' Ajoute le texte nettoyé avec le préfixe ">> "
        TextBoxConsole.AppendText(">> " & texteNettoye & vbCrLf)

        ' Fait défiler automatiquement jusqu'en bas
        TextBoxConsole.SelectionStart = TextBoxConsole.Text.Length
        TextBoxConsole.ScrollToCaret()
    End Sub

    ' Fonction pour modifier une valeur dans line1, line2 ou line3. Exemple d'utilisation: ModifierValeurLine(numéro de ligne, "clé", "nouvelle valeur")
    Sub ModifierValeurLine(lineNumber As Integer, key As String, nouvelleValeur As String)
        ' Choisir la ligne à modifier
        Dim line As String = ""
        Select Case lineNumber
            Case 1 : line = line1
            Case 2 : line = line2
            Case 3 : line = line3
            Case Else
                AjouterALaConsole($"Erreur : lineNumber invalide ({lineNumber})")
                Exit Sub
        End Select

        ' Log avant modification
        AjouterALaConsole($"Avant modification : {line}")

        ' Séparer la ligne en parties clé=valeur
        Dim parts() As String = line.Split(";"c)
        Dim found As Boolean = False

        For i As Integer = 0 To parts.Length - 1
            If parts(i).StartsWith(key & "=") Then
                parts(i) = key & "=" & nouvelleValeur
                found = True
                Exit For
            End If
        Next

        ' Si la clé n'existe pas, l'ajouter à la fin
        If Not found Then
            ReDim Preserve parts(parts.Length)
            parts(parts.Length - 1) = key & "=" & nouvelleValeur
            AjouterALaConsole($"Clé '{key}' inexistante, ajoutée avec valeur '{nouvelleValeur}'")
        End If

        ' Reconstituer la ligne
        Dim nouvelleLine As String = String.Join(";", parts)

        ' Sauvegarder dans la bonne variable
        Select Case lineNumber
            Case 1 : line1 = nouvelleLine
            Case 2 : line2 = nouvelleLine
            Case 3 : line3 = nouvelleLine
        End Select

        ' Log après modification
        AjouterALaConsole($"Après modification : {nouvelleLine}")
    End Sub

    'Ajouter aux TextBox infos les informations extraites de lineX (lors de la pression sur un bouton ">" à côté des lignes)
    Sub RemplirInfosMinitel(lineX As String, form As Form)
        Dim parts() As String = lineX.Split(";"c)
        Dim dict As New Dictionary(Of String, String)

        ' Parse clé=valeur
        For Each part In parts
            If part.Contains("=") Then
                Dim kv = part.Split("="c)
                Dim key = kv(0)
                Dim value = If(kv.Length > 1 AndAlso kv(1) <> "", kv(1), "N/D")
                dict(key) = value
            End If
        Next

        ' Création des textes formatés dans l'ordre
        Dim infos() As String = New String(7) {}
        infos(0) = $"Utilisateur : {dict("actualuser")}"
        infos(1) = $"Numéro : {dict("phone")}"
        infos(2) = $"Débit maximal : {If(dict("maxflow") <> "N/D", dict("maxflow") & " bps", "N/D")}"
        infos(3) = If(dict("M12Msg").ToLower() = "true", "Compatible messagerie", "Non compatible messagerie")
        infos(4) = If(dict("M12Rep").ToLower() = "true", "Compatible annuaire", "Non compatible annuaire")
        Select Case dict("sigIntensity")
            Case "5" : infos(5) = "Signal : Excellent"
            Case "4" : infos(5) = "Signal : Très bon"
            Case "3" : infos(5) = "Signal : Bon"
            Case "2" : infos(5) = "Signal : Moyen"
            Case "1" : infos(5) = "Signal : Mauvais"
            Case Else : infos(5) = "Signal : N/D"
        End Select
        infos(6) = $"Minitel : {dict("MinitelType")}"
        infos(7) = $"ROM : {dict("ROM")}"

        Me.infoline1.Text = infos(0)
        Me.infoline2.Text = infos(1)
        Me.infoline3.Text = infos(2)
        Me.infoline4.Text = infos(3)
        Me.infoline5.Text = infos(4)
        Me.infoline6.Text = infos(5)
        Me.infoline7.Text = infos(6)
        Me.infoline8.Text = infos(7)
    End Sub

    Private Sub refreshTimer_Tick(sender As Object, e As EventArgs) Handles refreshTimer.Tick
        ' selectedLine = 1, 2 ou 3 selon la ligne sélectionnée
        Dim lineX As String = ""
        Select Case selectedLine
            Case 1 : lineX = line1
            Case 2 : lineX = line2
            Case 3 : lineX = line3
            Case Else : Exit Sub
        End Select

        ' Actualiser les TextBox
        RemplirInfosMinitel(lineX, Me)

        ' Actualiser les utilisateurs connectés
        AfficherUtilisateursConnectes(Me)
    End Sub

    Sub AfficherUtilisateursConnectes(form As Form)
        Dim lignes() As String = {line1, line2, line3}
        Dim utilisateurs As New List(Of String)

        ' Parcours des lignes
        For Each lineX In lignes
            Dim dict As New Dictionary(Of String, String)
            Dim parts() As String = lineX.Split(";"c)
            For Each part In parts
                If part.Contains("=") Then
                    Dim kv = part.Split("="c)
                    Dim key = kv(0)
                    Dim value = If(kv.Length > 1 AndAlso kv(1) <> "", kv(1), "N/D")
                    dict(key) = value
                End If
            Next

            ' Ajouter l'utilisateur si non vide/N/D
            If dict.ContainsKey("actualuser") AndAlso dict("actualuser") <> "" AndAlso dict("actualuser") <> "N/D" Then
                utilisateurs.Add(dict("actualuser"))
            End If
        Next

        ' Affichage du nombre total d'utilisateurs
        Dim lblCount As Label = TryCast(form.Controls("Label25"), Label)
        If lblCount IsNot Nothing Then
            lblCount.Text = $"Utilisateurs connectés: {utilisateurs.Count}"
        End If

        ' Affichage de la liste d'utilisateurs
        Dim lblList As Label = TryCast(form.Controls("Label31"), Label)
        If lblList IsNot Nothing Then
            lblList.Text = String.Join(", ", utilisateurs)
        End If

        AjouterALaConsole("Informations actualisées.")

    End Sub


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
        ExporterFichierCache()
    End Sub

    Private Sub radiobutton6_CheckedChanged(sender As Object, e As EventArgs) Handles COM1.CheckedChanged
        If Me.COM1.Checked Then
            ' Action à effectuer lorsque le bouton radio est coché
            ModifierParametre("parametres", "serial", "COM1")
        End If
    End Sub

    Private Sub radiobutton5_CheckedChanged(sender As Object, e As EventArgs) Handles COM2.CheckedChanged
        If Me.COM2.Checked Then
            ' Action à effectuer lorsque le bouton radio est coché
            ModifierParametre("parametres", "serial", "COM2")
        End If
    End Sub

    Private Sub radiobutton4_CheckedChanged(sender As Object, e As EventArgs) Handles COM3.CheckedChanged
        If Me.COM3.Checked Then
            ' Action à effectuer lorsque le bouton radio est coché
            ModifierParametre("parametres", "serial", "COM3")
        End If
    End Sub

    Private Sub radiobutton3_CheckedChanged(sender As Object, e As EventArgs) Handles COM4.CheckedChanged
        If Me.COM4.Checked Then
            ' Action à effectuer lorsque le bouton radio est coché
            ModifierParametre("parametres", "serial", "COM4")
        End If
    End Sub

    Private Sub radiobutton2_CheckedChanged(sender As Object, e As EventArgs) Handles Other.CheckedChanged
        If Me.Other.Checked Then
            ' Action à effectuer lorsque le bouton radio est coché
            ModifierParametre("parametres", "serial", "Autre")
        End If
    End Sub

    Private Sub radiobutton1_CheckedChanged(sender As Object, e As EventArgs) Handles Automatic.CheckedChanged
        If Me.Automatic.Checked Then
            ' Action à effectuer lorsque le bouton radio est coché
            ModifierParametre("parametres", "serial", "Auto")
        End If
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click

        TextBoxConsole.Clear()

    End Sub

    Private Sub ConsoleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsoleToolStripMenuItem.Click
        param_console.Show()
    End Sub

    Private Sub button34_Click(sender As Object, e As EventArgs) Handles button34.Click
        ModifierParametre("parametres", "BPS", "50")
    End Sub

    Private Sub button35_Click(sender As Object, e As EventArgs) Handles button35.Click
        ModifierParametre("parametres", "BPS", "400")
    End Sub

    Private Sub button36_Click(sender As Object, e As EventArgs) Handles button36.Click
        ModifierParametre("parametres", "BPS", "1200")
    End Sub

    Private Sub button37_Click(sender As Object, e As EventArgs) Handles button37.Click
        ModifierParametre("parametres", "BPS", "2400")
    End Sub

    Private Sub button38_Click(sender As Object, e As EventArgs) Handles button38.Click
        ModifierParametre("parametres", "BPS", "4800")
    End Sub

    Private Sub button39_Click(sender As Object, e As EventArgs) Handles button39.Click
        ModifierParametre("parametres", "BPS", "9600")
    End Sub

    Private Sub button40_Click(sender As Object, e As EventArgs) Handles button40.Click
        ModifierParametre("parametres", "BPS", "19200")
    End Sub

    Private Sub button41_Click(sender As Object, e As EventArgs) Handles button41.Click
        ModifierParametre("parametres", "BPS", "38400")
    End Sub

    Private Sub button42_Click(sender As Object, e As EventArgs) Handles button42.Click
        ModifierParametre("parametres", "BPS", "MAX")
    End Sub

    Private Sub checkbox8_CheckedChanged(sender As Object, e As EventArgs) Handles checkbox8.CheckedChanged
        If Me.checkbox8.Checked Then
            ModifierParametre("parametres", "BloquerDeconnectBrut", "True")
        Else
            ModifierParametre("parametres", "BloquerDeconnecteBrut", "False")
        End If
    End Sub

    Private Sub checkbox9_CheckedChanged(sender As Object, e As EventArgs) Handles checkbox9.CheckedChanged
        If Me.checkbox9.Checked Then
            ModifierParametre("parametres", "BloquerSpam", "True")
        Else
            ModifierParametre("parametres", "BloquerSpam", "False")
        End If
    End Sub

    Private Sub radiobutton10_CheckedChanged(sender As Object, e As EventArgs) Handles telMsg.CheckedChanged
        If Me.telMsg.Checked Then
            ModifierParametre("parametres", "repNumBloqués", "mesTel")
        End If
    End Sub

    Private Sub radiobutton11_CheckedChanged(sender As Object, e As EventArgs) Handles minitelPage.CheckedChanged
        If Me.minitelPage.Checked Then
            ModifierParametre("parametres", "repNumBloqués", "scr")
        End If
    End Sub

    Private Sub radiobutton7_CheckedChanged(sender As Object, e As EventArgs) Handles Ouvert.CheckedChanged
        If Me.Ouvert.Checked Then
            ModifierParametre("parametres", "messagerie", "ouvert")
        End If
    End Sub

    Private Sub radiobutton8_CheckedChanged(sender As Object, e As EventArgs) Handles OuvertFermé.CheckedChanged
        If Me.OuvertFermé.Checked Then
            ModifierParametre("parametres", "messagerie", "ouvert/fermé")
        End If
    End Sub

    Private Sub radiobutton9_CheckedChanged(sender As Object, e As EventArgs) Handles Fermé.CheckedChanged
        If Me.Fermé.Checked Then
            ModifierParametre("parametres", "messagerie", "fermé")
        End If
    End Sub

    Private Sub comboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboBox1.SelectedIndexChanged
        ModifierParametre("parametres", "TypeServ", comboBox1.SelectedItem.ToString())
    End Sub

    Private Sub comboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboBox2.SelectedIndexChanged
        If comboBox2.SelectedItem IsNot Nothing Then
            ModifierParametre("parametres", "Modem", comboBox2.SelectedItem.ToString())
        End If
    End Sub

    Private Sub textBox1_TextChanged(sender As Object, e As EventArgs) Handles textBox1.TextChanged
        ModifierParametre("parametres", "NumServ", textBox1.Text.Trim())
    End Sub

    Private Sub numericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles numericUpDown1.ValueChanged
        ModifierParametre("horaires", "ON", numericUpDown1.Value.ToString() & ":" & numericUpDown2.Value.ToString)
    End Sub

    Private Sub numericUpDown2_ValueChanged(sender As Object, e As EventArgs) Handles numericUpDown2.ValueChanged
        ModifierParametre("horaires", "ON", numericUpDown1.Value.ToString() & ":" & numericUpDown2.Value.ToString)
    End Sub

    Private Sub numericUpDown3_ValueChanged(sender As Object, e As EventArgs) Handles numericUpDown3.ValueChanged
        ModifierParametre("horaires", "OFF", numericUpDown3.Value.ToString() & ":" & numericUpDown4.Value.ToString)
    End Sub

    Private Sub numericUpDown4_ValueChanged(sender As Object, e As EventArgs) Handles numericUpDown4.ValueChanged
        ModifierParametre("horaires", "OFF", numericUpDown3.Value.ToString() & ":" & numericUpDown4.Value.ToString)
    End Sub

    Private Sub button21_Click(sender As Object, e As EventArgs) Handles button21.Click
        BoiteCreationCompte.Show()
    End Sub

    Private Sub arbToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles arbToolStripMenuItem.Click
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

    Private Sub button59_Click(sender As Object, e As EventArgs) Handles button59.Click
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

    Private Sub checkbox11_CheckedChanged(sender As Object, e As EventArgs) Handles checkbox11.CheckedChanged
    End Sub

    Private Sub checkbox18_CheckedChanged(sender As Object, e As EventArgs) Handles checkbox18.CheckedChanged
        ModifierParametre("parametres", "LECAM", "True")
    End Sub

    Private Sub button45_Click(sender As Object, e As EventArgs) Handles button45.Click
        Dialog2.Show()
    End Sub

    Private Sub AfficherLaListeComplèteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AfficherLaListeComplèteToolStripMenuItem.Click
        Try
            ' Étape 1 : lire le paramètre
            Dim listeNumBloques As String
            listeNumBloques = LireParametre("parametres", "NumBloqués")
            AjouterALaConsole(">> Valeur brute de NumBloqués : " & listeNumBloques)

            If String.IsNullOrEmpty(listeNumBloques) Then
                AjouterALaConsole(">> La liste est vide")
                MessageBox.Show("Aucun numéro bloqué.", "Liste des numéros bloqués", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                ' Étape 2 : retirer les parenthèses
                listeNumBloques = listeNumBloques.Trim("("c, ")"c)
                AjouterALaConsole(">> Après suppression des parenthèses : " & listeNumBloques)

                ' Étape 3 : séparer par le point-virgule
                Dim nums() As String = listeNumBloques.Split(";"c)
                AjouterALaConsole(">> Nombre de numéros trouvés : " & nums.Length)

                ' Étape 4 : reconstruire la chaîne avec sauts de ligne
                Dim affichage As String = String.Join(vbCrLf, nums)
                AjouterALaConsole(">> Chaîne finale pour MsgBox : " & vbCrLf & affichage)

                ' Étape 5 : afficher dans MsgBox
                MessageBox.Show(affichage, "Liste des numéros bloqués", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            AjouterALaConsole(">> Erreur détectée : " & ex.Message)
            MessageBox.Show("Erreur lors de la lecture du fichier : " & ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        ModifierParametre("parametres", "InitString", TextBox2.Text)
    End Sub

    Private Sub NumericUpDown8_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown8.ValueChanged
        ModifierParametre("parametres", "Timeout", NumericUpDown8.Value)
    End Sub

    Private Sub NumericUpDown9_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown9.ValueChanged
        ModifierParametre("parametres", "ModeSonnerie", NumericUpDown9.Value)
    End Sub


    Private Sub exporterLeServeurToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles exporterLeServeurToolStripMenuItem.Click
        button63_Click(button63, EventArgs.Empty)
    End Sub

    Private Sub button47_Click(sender As Object, e As EventArgs) Handles button47.Click
        ' Appel de la fonction pour chaque ligne
        selectedLine = 1
        RemplirInfosMinitel(line1, Me)   ' infoline1 à infoline8
    End Sub

    Private Sub button49_Click(sender As Object, e As EventArgs) Handles button49.Click
        selectedLine = 2
        RemplirInfosMinitel(line2, Me)   ' infoline9 à infoline16
    End Sub

    Private Sub button48_Click(sender As Object, e As EventArgs) Handles button48.Click
        selectedLine = 3
        RemplirInfosMinitel(line3, Me)  ' infoline17 à infoline24
    End Sub


End Class