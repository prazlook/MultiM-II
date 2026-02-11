Imports System.Collections.Generic
Imports System.Drawing.Text
Imports System.Linq
Imports Microsoft.VisualBasic.Strings
Imports System.Text
Imports System.Windows.Forms

Public Class VDT_Edit

    Dim PoliceMinitel As FontFamily

    Const LARGEUR_ECRAN As Integer = 80
    Const HAUTEUR_ECRAN As Integer = 75
    Const TAILLE_PIXEL As Integer = 10

    Dim Ecran(LARGEUR_ECRAN - 1, HAUTEUR_ECRAN - 1) As Color

    Private SelectedColor As System.Drawing.Color = System.Drawing.Color.FromArgb(255, 255, 255)
    Private EditionGraphique As Boolean = True
    Private EnCoursDeDessin As Boolean = False
    Private CouleursPixels(LARGEUR_ECRAN - 1, HAUTEUR_ECRAN - 1) As Color
    Private ModeGris As Boolean = False
    Private OutilActif As String = "crayon"
    Private CentreCercle As Point
    Private EnCoursCercle As Boolean = False
    Private RayonCercle As Integer = 0

    Private UndoStack As New Stack(Of Color(,))
    Private RedoStack As New Stack(Of Color(,))

    Private PointsTriangle As New List(Of Point)
    Private TriangleEnCours As Boolean = False
    Private TriangleSommet1 As Point
    Private TriangleSommet2 As Point
    Private TriangleSommet3 As Point
    Private TriangleDragIndex As Integer = -1

    ' Pour l'outil quadrilatère (rectangle modifiable)
    ' --- Quad (4 sommets modifiables) ---
    Private RectangleEnCours As Boolean = False
    Private RectangleDragIndex As Integer = -1
    Private PointsQuad As New List(Of Point)

    ' À placer dans la classe VDT_Edit

    ' Ajoutez ce champ pour mémoriser le dernier point dessiné
    Private DernierPoint As Point = Point.Empty

    ' Nouveaux champs pour la détection OverColor
    ' Chaque "caractère" sur l'écran est un groupe 2x3 pixels (6 pixels)
    Private ReadOnly CELL_WIDTH As Integer = 2
    Private ReadOnly CELL_HEIGHT As Integer = 3
    Private ReadOnly CHAR_COLUMNS As Integer = LARGEUR_ECRAN \ 2
    Private ReadOnly CHAR_ROWS As Integer = HAUTEUR_ECRAN \ 3
    Private OverColorTriggered(CHAR_COLUMNS - 1, CHAR_ROWS - 1) As Boolean

    ' -------------------------------------------------------------------------
    ' STRUCTURES ET CONSTANTES VDT NÉCESSAIRES À L'EXPORTATION
    ' -------------------------------------------------------------------------

    Private Structure CellData
        Dim FgColor As Integer ' Index Minitel (0-7)
        Dim BgColor As Integer ' Index Minitel (0-7)
        Dim CharType As String ' "G0" (Texte) ou "G1" (Mosaïque)
        Dim VDTChar As String  ' Caractère VDT brut (Chr(xx))
    End Structure

    Private ReadOnly VDT_FF As String = Chr(12)      ' Form Feed (Clear Screen)
    Private ReadOnly VDT_SO As String = Chr(14)      ' Shift Out (Mode Mosaïque G1)
    Private ReadOnly VDT_SI As String = Chr(15)      ' Shift In (Mode Texte G0)
    Private ReadOnly VDT_ESC As String = Chr(27)     ' Escape
    Private ReadOnly VDT_CARACTERE_UNI_COULEUR As String = "_" ' Caractère de remplacement pour le cas "une seule couleur"

    ' -------------------------------------------------------------------------
    ' TABLEAU DE CORRESPONDANCE BINAIRE (64 Combinaisons) - MODIFIABLE
    ' L'ordre binaire est P1(Haut/G), P2(Milieu/G), P3(Bas/G), P4(Haut/D), P5(Milieu/D), P6(Bas/D)
    ' Chr(97) à Chr(127) + Chr(159) sont les caractères mosaïques
    ' -------------------------------------------------------------------------

    ' --- Convention de codage binaire Sixel pour ce tableau (Haut-Bas, Colonne Gauche-Droite) ---
    ' Bit 1: Haut Gauche (100000)
    ' Bit 2: Milieu Gauche (010000)
    ' Bit 3: Bas Gauche (001000)
    ' Bit 4: Haut Droit (000100)
    ' Bit 5: Milieu Droit (000010)
    ' Bit 6: Bas Droit (000001)

    ' Ligne 1 (Caractères Chr(32) à Chr(39))
    Private Const Sixel_000000 As String = " "       ' Espace (Chr(32)) - Motif: 000000
    Private Const Sixel_000100 As String = "!"       ' Point d'exclamation (Chr(33)) - Motif: 000100
    Private Const Sixel_000010 As String = """"      ' Guillemets (Chr(34)) - Motif: 000010
    Private Const Sixel_000001 As String = "#"       ' Dièse (Chr(35)) - Motif: 000001
    Private Const Sixel_010000 As String = "$"       ' Dollar (Chr(36)) - Motif: 010000
    Private Const Sixel_000110 As String = "%"       ' Pourcentage (Chr(37)) - Motif: 000110
    Private Const Sixel_000101 As String = "&"       ' Esperluette (Chr(38)) - Motif: 000101
    Private Const Sixel_000011 As String = "'"       ' Apostrophe (Chr(39)) - Motif: 000011

    ' Ligne 2 (Caractères Chr(40) à Chr(47))
    Private Const Sixel_100000 As String = "("       ' Parenthèse ouvrante (Chr(40)) - Motif: 100000
    Private Const Sixel_110000 As String = ")"       ' Parenthèse fermante (Chr(41)) - Motif: 110000
    Private Const Sixel_101000 As String = "*"       ' Astérisque (Chr(42)) - Motif: 101000
    Private Const Sixel_100100 As String = "+"       ' Plus (Chr(43)) - Motif: 100100
    Private Const Sixel_100010 As String = ","       ' Virgule (Chr(44)) - Motif: 100010
    Private Const Sixel_100001 As String = "-"       ' Trait d'union (Chr(45)) - Motif: 100001
    Private Const Sixel_101100 As String = "."       ' Point (Chr(46)) - Motif: 101100
    Private Const Sixel_101010 As String = "/"       ' Barre oblique (Chr(47)) - Motif: 101010

    ' Ligne 3 (Caractères Chr(48) à Chr(55))
    Private Const Sixel_001100 As String = "0"       ' Zéro (Chr(48)) - Motif: 001100
    Private Const Sixel_001010 As String = "1"       ' Un (Chr(49)) - Motif: 001010
    Private Const Sixel_001001 As String = "2"       ' Deux (Chr(50)) - Motif: 001001
    Private Const Sixel_001110 As String = "3"       ' Trois (Chr(51)) - Motif: 001110
    Private Const Sixel_001101 As String = "4"       ' Quatre (Chr(52)) - Motif: 001101
    Private Const Sixel_001011 As String = "5"       ' Cinq (Chr(53)) - Motif: 001011
    Private Const Sixel_001111 As String = "6"       ' Six (Chr(54)) - Motif: 001111
    Private Const Sixel_011000 As String = "7"       ' Sept (Chr(55)) - Motif: 011000

    ' Ligne 4 (Caractères Chr(56) à Chr(63))
    Private Const Sixel_101100_8 As String = "8"     ' Huit (Chr(56)) - Motif: 101100 (Doublon avec .)
    Private Const Sixel_101010_9 As String = "9"     ' Neuf (Chr(57)) - Motif: 101010 (Doublon avec /)
    Private Const Sixel_101001 As String = ":"       ' Deux points (Chr(58)) - Motif: 101001
    Private Const Sixel_101110 As String = ";"       ' Point-virgule (Chr(59)) - Motif: 101110
    Private Const Sixel_101101 As String = "<"       ' Inférieur à (Chr(60)) - Motif: 101101
    Private Const Sixel_101011 As String = "="       ' Égal (Chr(61)) - Motif: 101011
    Private Const Sixel_101111 As String = ">"       ' Supérieur à (Chr(62)) - Motif: 101111
    Private Const Sixel_111000 As String = "?"       ' Point d'interrogation (Chr(63)) - Motif: 111000

    ' Ligne 5 (Caractères Chr(64) à Chr(71))
    Private Const Sixel_011100 As String = "@"       ' Arobase (Chr(64)) - Motif: 011100
    Private Const Sixel_011010 As String = "A"       ' A majuscule (Chr(65)) - Motif: 011010
    Private Const Sixel_011001 As String = "B"       ' B majuscule (Chr(66)) - Motif: 011001
    Private Const Sixel_011110 As String = "C"       ' C majuscule (Chr(67)) - Motif: 011110
    Private Const Sixel_011101 As String = "D"       ' D majuscule (Chr(68)) - Motif: 011101
    Private Const Sixel_011011 As String = "E"       ' E majuscule (Chr(69)) - Motif: 011011
    Private Const Sixel_011111 As String = "F"       ' F majuscule (Chr(70)) - Motif: 011111
    Private Const Sixel_111100 As String = "G"       ' G majuscule (Chr(71)) - Motif: 111100

    ' Ligne 6 (Caractères Chr(72) à Chr(79)) - Beaucoup de doublons de motifs
    Private Const Sixel_111010 As String = "H"       ' H majuscule (Chr(72)) - Motif: 111010
    Private Const Sixel_111001 As String = "I"       ' I majuscule (Chr(73)) - Motif: 111001
    Private Const Sixel_111110 As String = "J"       ' J majuscule (Chr(74)) - Motif: 111110
    Private Const Sixel_111101 As String = "K"       ' K majuscule (Chr(75)) - Motif: 111101
    Private Const Sixel_111011 As String = "L"       ' L majuscule (Chr(76)) - Motif: 111011
    Private Const Sixel_111111 As String = "M"       ' M majuscule (Chr(77)) - Motif: 111111
    Private Const Sixel_000000_N As String = "N"     ' N majuscule (Chr(78)) - Motif: 000000 (Doublon avec Espace)
    Private Const Sixel_000100_O As String = "O"     ' O majuscule (Chr(79)) - Motif: 000100 (Doublon avec !)

    ' Ligne 7 (Caractères Chr(80) à Chr(87)) - Beaucoup de doublons de motifs
    Private Const Sixel_100000_P As String = "P"     ' P majuscule (Chr(80)) - Motif: 100000 (Doublon avec ()
    Private Const Sixel_110000_Q As String = "Q"     ' Q majuscule (Chr(81)) - Motif: 110000 (Doublon avec ))
    Private Const Sixel_101000_R As String = "R"     ' R majuscule (Chr(82)) - Motif: 101000 (Doublon avec *)
    Private Const Sixel_100100_S As String = "S"     ' S majuscule (Chr(83)) - Motif: 100100 (Doublon avec +)
    Private Const Sixel_100010_T As String = "T"     ' T majuscule (Chr(84)) - Motif: 100010 (Doublon avec ,)
    Private Const Sixel_100001_U As String = "U"     ' U majuscule (Chr(85)) - Motif: 100001 (Doublon avec -)
    Private Const Sixel_101100_V As String = "V"     ' V majuscule (Chr(86)) - Motif: 101100 (Doublon avec . et 8)
    Private Const Sixel_101010_W As String = "W"     ' W majuscule (Chr(87)) - Motif: 101010 (Doublon avec / et 9)

    ' Ligne 8 (Caractères Chr(88) à Chr(95)) - Beaucoup de doublons de motifs
    Private Const Sixel_001100_X As String = "X"     ' X majuscule (Chr(88)) - Motif: 001100 (Doublon avec 0)
    Private Const Sixel_001010_Y As String = "Y"     ' Y majuscule (Chr(89)) - Motif: 001010 (Doublon avec 1)
    Private Const Sixel_001001_Z As String = "Z"     ' Z majuscule (Chr(90)) - Motif: 001001 (Doublon avec 2)
    Private Const Sixel_001110_LBracket As String = "["     ' Crochet ouvrant (Chr(91)) - Motif: 001110 (Doublon avec 3)
    Private Const Sixel_001101_BSlash As String = "\"     ' Barre oblique inverse (Chr(92)) - Motif: 001101 (Doublon avec 4)
    Private Const Sixel_001011_RBracket As String = "]"     ' Crochet fermant (Chr(93)) - Motif: 001011 (Doublon avec 5)
    Private Const Sixel_001111_Caret As String = "^"     ' Accent circonflexe (Chr(94)) - Motif: 001111 (Doublon avec 6)
    Private Const Sixel_011000_Underscore As String = "_" ' Tiret bas (Chr(95)) - Motif: 011000 (Doublon avec 7)

    ' Les autres structures et fonctions utilitaires (MinitelColorIndex, Structure CellData)
    ' doivent également être dans la classe VDT_Edit.

    ' Variables pour suivre l'état courant et optimiser le flux
    Private CurrentFgColor As Integer = -1
    Private CurrentBgColor As Integer = -1
    Private CurrentCharType As String = "G0"

    '--------------------------------------------------------
    ' Nouveaux champs pour la création par cliquer-glisser du rectangle
    Private RectangleStart As Point = Point.Empty
    Private RectangleEnd As Point = Point.Empty

    Private Sub VDT_Edit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ChargerPoliceMinitel()
        FaireClignoterBouton()
        If centre_acces.player IsNot Nothing Then
            centre_acces.player.Stop()

        End If
        For x = 0 To LARGEUR_ECRAN - 1
            For y = 0 To HAUTEUR_ECRAN - 1
                Ecran(x, y) = Color.Black
                CouleursPixels(x, y) = Color.Black
            Next
        Next
        ' Active le double-buffering pour la fluidité
        PanelEcran.GetType().GetProperty("DoubleBuffered", Reflection.BindingFlags.Instance Or Reflection.BindingFlags.NonPublic).SetValue(PanelEcran, True, Nothing)
        PanelEcran.Visible = True
        PanelEcran.BringToFront()
        PanelEcran.Invalidate()
    End Sub

    Private Sub ChargerPoliceMinitel()
        Dim pfc As New PrivateFontCollection()
        Dim fontData() As Byte = My.Resources.Minitel
        Dim fontPtr As IntPtr = Marshal.AllocCoTaskMem(fontData.Length)
        Marshal.Copy(fontData, 0, fontPtr, fontData.Length)
        pfc.AddMemoryFont(fontPtr, fontData.Length)
        Marshal.FreeCoTaskMem(fontPtr)
        PoliceMinitel = pfc.Families(0)
    End Sub

    ' Mappage approximatif des couleurs System.Drawing.Color aux index Minitel (0-7)
    Private Function MinitelColorIndex(ByVal color As System.Drawing.Color) As Integer
        If color.ToArgb = System.Drawing.Color.Black.ToArgb Then Return 0
        If color.ToArgb = System.Drawing.Color.Red.ToArgb Then Return 1
        If color.ToArgb = System.Drawing.Color.Lime.ToArgb Then Return 2
        If color.ToArgb = System.Drawing.Color.Yellow.ToArgb Then Return 3
        If color.ToArgb = System.Drawing.Color.Blue.ToArgb Then Return 4
        If color.ToArgb = System.Drawing.Color.Magenta.ToArgb Then Return 5
        If color.ToArgb = System.Drawing.Color.Cyan.ToArgb Then Return 6
        If color.ToArgb = System.Drawing.Color.White.ToArgb Then Return 7
        Return 0 ' Par défaut, Noir
    End Function

    Private Async Sub FaireClignoterBouton()
        While Not Me.IsDisposed AndAlso Me.Visible
            Button49.Text = ""
            Await Task.Delay(700)
            If Me.IsDisposed OrElse Not Me.Visible Then Exit While
            Button49.Text = "Clignotement ON"
            Await Task.Delay(700)
        End While
    End Sub



    ' Analyse la cellule 2x3 et retourne les données VDT brutes
    Private Function ProcessCell(ByVal StartX As Integer, ByVal StartY As Integer, ByVal CouleursPixels(,) As Color) As CellData

        Dim VDTCell As New CellData()
        Dim BinarySixel As String = ""
        Dim ColorCounts As New Dictionary(Of Integer, Integer)
        Dim SixelIsActive As Boolean = False

        ' 1. Identifier toutes les couleurs dans le bloc 2x3
        For r As Integer = 0 To 2.0F
            For c As Integer = 0 To 1
                ' --- CORRECTION POUR ÉVITER BC30521 : Utilisation d'une variable intermédiaire ---
                Dim pixelColor As Color = CouleursPixels(StartX + c, StartY + r)
                Dim colorIndex As Integer = MinitelColorIndex(pixelColor)
                ' ----------------------------------------------------------------------------------

                If Not ColorCounts.ContainsKey(colorIndex) Then ColorCounts.Add(colorIndex, 0)
                ColorCounts(colorIndex) += 1
            Next
        Next

        ' Trier les couleurs par fréquence (décroissante)
        Dim SortedColors = ColorCounts.OrderByDescending(Function(kv) kv.Value).ToList()

        ' Vérifier si la seule couleur présente est le noir (fond)
        Dim OnlyOneColor As Boolean = SortedColors.Count = 1
        Dim IsOnlyBlack As Boolean = OnlyOneColor AndAlso SortedColors(0).Key = 0

        If OnlyOneColor AndAlso Not IsOnlyBlack Then
            ' --- CAS 1 : UNE SEULE COULEUR NON NOIRE ---

            ' Couleur de fond = Noir (0)
            VDTCell.BgColor = 0
            ' Couleur de texte = Couleur unique trouvée
            VDTCell.FgColor = SortedColors(0).Key
            ' Caractère = '_'
            VDTCell.VDTChar = VDT_CARACTERE_UNI_COULEUR
            VDTCell.CharType = "G0" ' Utilise le mode texte pour le caractère '_'

        ElseIf SortedColors.Count >= 2 OrElse IsOnlyBlack Then
            ' --- CAS 2 : DEUX COULEURS OU PLUS, or UNIQUEMENT DU NOIR ---

            ' Si que du noir, Fg=Blanc(7), Bg=Noir(0)
            If IsOnlyBlack Then
                VDTCell.BgColor = 0
                VDTCell.FgColor = 0 ' Noir sur noir = Espace
                VDTCell.CharType = "G0"
                VDTCell.VDTChar = Chr(32)
                Return VDTCell
            End If

            ' Définition des couleurs Fg/Bg selon la demande (couleur la plus/deuxième plus fréquente)
            VDTCell.BgColor = SortedColors(0).Key ' Couleur du premier pixel le plus fréquent = Fond
            VDTCell.FgColor = SortedColors(1).Key ' Couleur du deuxième pixel le plus fréquent = Texte/Graphique
            VDTCell.CharType = "G1" ' Mode Mosaïque

            ' 2. CONSTRUCTION DE LA CHAÎNE BINAIRE (P1P2P3P4P5P6)

            ' Ordre VDT: P1, P2, P3 (colonne G), P4, P5, P6 (colonne D)
            Dim PixelsOrder() As Point = {
                New Point(0, 0), New Point(0, 1), New Point(0, 2), ' P1, P2, P3 (colonne 0)
                New Point(1, 0), New Point(1, 1), New Point(1, 2)  ' P4, P5, P6 (colonne 1)
            }

            For Each p As Point In PixelsOrder
                Dim px As Integer = StartX + p.X
                Dim py As Integer = StartY + p.Y

                ' --- CORRECTION POUR ÉVITER BC30521 : Utilisation d'une variable intermédiaire ---
                Dim pixelColor As Color = CouleursPixels(px, py)
                Dim currentIdx As Integer = MinitelColorIndex(pixelColor)
                ' ----------------------------------------------------------------------------------

                ' Le bit est '1' s'il correspond à la couleur de premier plan (FgColor)
                If currentIdx = VDTCell.FgColor Then
                    BinarySixel &= "1"
                    SixelIsActive = True
                Else
                    BinarySixel &= "0"
                End If
            Next

            ' 3. RECHERCHE DU CARACTÈRE DANS LES VARIABLES PAR RÉFLEXION
            If SixelIsActive Then
                Try
                    ' Le nom de la variable est "Sixel_" + BinarySixel
                    Dim FieldName As String = "Sixel_" & BinarySixel
                    Dim FieldInfo As System.Reflection.FieldInfo = Me.GetType().GetField(FieldName, System.Reflection.BindingFlags.NonPublic Or System.Reflection.BindingFlags.Instance)

                    If FieldInfo IsNot Nothing Then
                        VDTCell.VDTChar = CStr(FieldInfo.GetValue(Me))
                    Else
                        ' Si la variable n'existe pas (Erreur de déclaration), utiliser un caractère par défaut
                        VDTCell.VDTChar = Chr(159)
                    End If
                Catch ex As Exception
                    ' Log d'erreur si la réflexion échoue (ex: erreur de type)
                    System.Diagnostics.Debug.WriteLine("Erreur de réflexion pour sixel " & BinarySixel & ": " & ex.Message)
                    VDTCell.VDTChar = Chr(159)
                End Try
            Else
                VDTCell.CharType = "G0"
                VDTCell.VDTChar = Chr(32) ' Espace si aucun pixel 'actif'
            End If

        End If

        Return VDTCell
    End Function

    ' Fonction principale pour l'exportation VDT
    Sub ExporterVDTComplet(ByVal CouleursPixels(,) As Color)

        Dim VDTStream As String = ""

        'Variables de suivi de coordonnées X et Y
        Dim X As Integer = -1
        Dim Y As Integer = -1

        'Variables de stockage des couleurs du caractère
        Dim BackColor As String = ""
        Dim ForeColor As String = ""

        VDTStream &= "" ' Efface l'écran

        '1.Récupération des couleurs et traitement
        BackColor = LireGroupe(X + 1, Y + 1, "cBg")
        ForeColor = LireGroupe(X + 1, Y + 1, "cFg")

        'Boucle principale de traitement des cellules 2x3
        While X < 40 Or Y < 25
            If BackColor = "Color.Black" Then
                VDTStream = VDTStream & Chr(27) & "@"
            ElseIf BackColor = "Color.Red" Then
                VDTStream = VDTStream & Chr(27) & "D"
            ElseIf BackColor = "Color.Lime" Then
                VDTStream = VDTStream & Chr(27) & "A"
            ElseIf BackColor = "Color.Yellow" Then
                VDTStream = VDTStream & Chr(27) & "E"
            ElseIf BackColor = "Color.Blue" Then
                VDTStream = VDTStream & Chr(27) & "B"
            ElseIf BackColor = "Color.Magenta" Then
                VDTStream = VDTStream & Chr(27) & "F"
            ElseIf BackColor = "Color.Cyan" Then
                VDTStream = VDTStream & Chr(27) & "C"
            ElseIf BackColor = "Color.White" Then
                VDTStream = VDTStream & Chr(27) & "G"
            End If

            If ForeColor = "Color.Black" Then
                VDTStream = VDTStream & Chr(27) & "P"
            ElseIf ForeColor = "Color.Red" Then
                VDTStream = VDTStream & Chr(27) & "T"
            ElseIf ForeColor = "Color.Lime" Then
                VDTStream = VDTStream & Chr(27) & "Q"
            ElseIf ForeColor = "Color.Yellow" Then
                VDTStream = VDTStream & Chr(27) & "U"
            ElseIf ForeColor = "Color.Blue" Then
                VDTStream = VDTStream & Chr(27) & "R"
            ElseIf ForeColor = "Color.Magenta" Then
                VDTStream = VDTStream & Chr(27) & "V"
            ElseIf ForeColor = "Color.Cyan" Then
                VDTStream = VDTStream & Chr(27) & "S"
            ElseIf ForeColor = "Color.White" Then
                VDTStream = VDTStream & Chr(27) & "W"
            End If

            If X < 40 Then
                X = X + 1
            Else
                X = 0
                Y = Y + 1
            End If

            VDTStream = VDTStream & LireGroupe(X, Y, "bits")
        End While

        '2.Récupération de la valeur binaire et traitement


        ' 5. EXPORTATION DU FICHIER (Boîte de dialogue)
        Using saveDialog As New SaveFileDialog()
            saveDialog.Filter = "Fichiers VDT (*.vdt)|*.vdt|Tous les fichiers (*.*)|*.*"
            saveDialog.FileName = "page_miedit_grille.vdt"
            saveDialog.Title = "Enregistrer la page VDT"

            If saveDialog.ShowDialog() = DialogResult.OK Then
                Dim CheminFichier As String = saveDialog.FileName
                Try
                    ' Utilisation de l'encodage 437 pour garantir les octets VDT bruts
                    My.Computer.FileSystem.WriteAllText(
                        CheminFichier,
                        VDTStream,
                        False,
                        System.Text.Encoding.GetEncoding(437)
                    )
                    MsgBox("Exportation VDT réussie.", MsgBoxStyle.Information)
                Catch ex As Exception
                    MsgBox("Erreur d'écriture : " & ex.Message, MsgBoxStyle.Critical)
                End Try
            End If
        End Using

    End Sub

    'Fonction button1_Click
    Public Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) 'Handles button1.Click
        Me.tidgetsTree.Nodes.Add("Barre de texte", "Barre de texte", 0, 0)
    End Sub

    'Fonction button2_Click
    Public Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) 'Handles button2.Click
        Me.tidgetsTree.Nodes.Add("Bloc de texte", "Bloc de texte", 0, 0)
    End Sub

    'Fonction button5_Click
    Public Sub Button5_Click(ByVal sender As Object, ByVal e As System.EventArgs) 'Handles button5.Click
        Me.tidgetsTree.Nodes.Add("Graphiques", "Graphiques", 0, 0)
    End Sub

    'Fonction button3_Click
    Public Sub Button3_Click(ByVal sender As Object, ByVal e As System.EventArgs) 'Handles button3.Click
        Boîte_de_dialogue4.ShowDialog()
    End Sub



    ' --- Événements souris UNIQUEMENT sur PanelEcran ---

    Private Sub PanelEcran_MouseClick(sender As Object, e As MouseEventArgs) Handles PanelEcran.MouseClick
        If EditionGraphique Then
            Dim xPixel As Integer = e.X \ TAILLE_PIXEL
            Dim yPixel As Integer = e.Y \ TAILLE_PIXEL
            If OutilActif = "triangle" AndAlso TriangleEnCours AndAlso TriangleSommetProche(e.Location) >= 0 Then Exit Sub
            If xPixel >= 0 AndAlso xPixel < LARGEUR_ECRAN AndAlso yPixel >= 0 AndAlso yPixel < HAUTEUR_ECRAN Then
                If OutilActif = "pot" Then
                    SauvegarderEtatPourUndo()
                    Dim couleurCible = CouleursPixels(xPixel, yPixel)
                    If couleurCible.ToArgb <> SelectedColor.ToArgb Then
                        RemplirZone(xPixel, yPixel, couleurCible, SelectedColor)
                        PanelEcran.Invalidate()
                    End If
                Else
                    ModifierPixel(xPixel, yPixel, SelectedColor)
                End If
            End If
        End If
    End Sub

    Private Sub PanelEcran_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelEcran.MouseDown
        If OutilActif = "crayon" AndAlso EditionGraphique AndAlso e.Button = MouseButtons.Left Then
            EnCoursDeDessin = True
            DernierPoint = e.Location
            DessinerPixelSousSouris(e)
        ElseIf OutilActif = "cercle" AndAlso e.Button = MouseButtons.Left Then
            CentreCercle = e.Location
            EnCoursCercle = True
        ElseIf OutilActif = "triangle" AndAlso e.Button = MouseButtons.Left Then
            If Not TriangleEnCours Then
                TriangleSommet1 = e.Location
                TriangleSommet2 = e.Location
                TriangleSommet3 = e.Location
                TriangleEnCours = True
                TriangleDragIndex = -1
                PanelValTri.Visible = False
            Else
                Dim idx = TriangleSommetProche(e.Location)
                If idx >= 0 Then TriangleDragIndex = idx
            End If
            PanelEcran.Invalidate()
        ElseIf OutilActif = "rectangle" AndAlso e.Button = MouseButtons.Left Then
            ' Nouvel comportement : clic-glisser pour définir un rectangle (comme Word)
            If Not RectangleEnCours Then
                ' Démarrer un nouveau rectangle
                RectangleStart = e.Location
                RectangleEnd = e.Location
                RectangleEnCours = True
                RectangleDragIndex = -1
                PointsQuad.Clear()
                ' Construire les 4 sommets initiaux (zéro taille)
                Dim tl = RectangleStart
                Dim tr = RectangleStart
                Dim br = RectangleStart
                Dim bl = RectangleStart
                PointsQuad.Add(tl)
                PointsQuad.Add(tr)
                PointsQuad.Add(br)
                PointsQuad.Add(bl)
                PanelValTri.Visible = False
            Else
                ' Si un rectangle est en cours, vérifier si on clique près d'un sommet pour le déplacer
                Dim idx = RectangleSommetProche(e.Location)
                If idx >= 0 Then RectangleDragIndex = idx
            End If
            PanelEcran.Invalidate()
        End If
    End Sub

    Private Sub PanelEcran_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelEcran.MouseMove
        If OutilActif = "crayon" AndAlso EditionGraphique AndAlso EnCoursDeDessin Then
            DessinerLigneEntreDernierPoint(e.Location)
            DernierPoint = e.Location
        ElseIf OutilActif = "cercle" AndAlso EnCoursCercle Then
            RayonCercle = CInt(Math.Sqrt((e.X - CentreCercle.X) ^ 2 + (e.Y - CentreCercle.Y) ^ 2))
            PanelEcran.Invalidate()
        ElseIf OutilActif = "triangle" AndAlso TriangleEnCours Then
            If TriangleSommetProche(e.Location) >= 0 Then
                PanelEcran.Cursor = Cursors.NoMove2D
            Else
                PanelEcran.Cursor = Cursors.Default
            End If
            Dim minX As Integer = 0
            Dim minY As Integer = 0
            Dim maxX As Integer = PanelEcran.Width - 1
            Dim maxY As Integer = PanelEcran.Height - 1
            Dim Clamp As Func(Of Integer, Integer, Integer, Integer) = Function(val, min, max) Math.Max(min, Math.Min(max, val))
            If TriangleDragIndex >= 0 Then
                Dim newPt As New Point(Clamp(e.X, minX, maxX), Clamp(e.Y, minY, maxY))
                If TriangleDragIndex = 0 Then TriangleSommet1 = newPt
                If TriangleDragIndex = 1 Then TriangleSommet2 = newPt
                If TriangleDragIndex = 2 Then TriangleSommet3 = newPt
                AfficherPanelValTri()
                PanelEcran.Invalidate()
            ElseIf Not PanelValTri.Visible Then
                Dim newX = Clamp(e.X, minX, maxX)
                Dim newY = Clamp(e.Y, minY, maxY)
                TriangleSommet2 = New Point(newX, newY)
                Dim dx = TriangleSommet2.X - TriangleSommet1.X
                TriangleSommet3 = New Point(Clamp(TriangleSommet1.X - dx, minX, maxX), newY)
                PanelEcran.Invalidate()
            End If
        ElseIf OutilActif = "rectangle" AndAlso RectangleEnCours Then
            ' Gestion du déplacement d'un sommet existant
            If RectangleSommetProche(e.Location) >= 0 Then
                PanelEcran.Cursor = Cursors.NoMove2D
            Else
                PanelEcran.Cursor = Cursors.Default
            End If
            Dim minX As Integer = 0
            Dim minY As Integer = 0
            Dim maxX As Integer = PanelEcran.Width - 1
            Dim maxY As Integer = PanelEcran.Height - 1
            Dim Clamp As Func(Of Integer, Integer, Integer, Integer) = Function(val, min, max) Math.Max(min, Math.Min(max, val))
            If RectangleDragIndex >= 0 Then
                ' Déplacer un sommet existant
                Dim newPt As New Point(Clamp(e.X, minX, maxX), Clamp(e.Y, minY, maxY))
                PointsQuad(RectangleDragIndex) = newPt
                AfficherPanelValRectangle()
                PanelEcran.Invalidate()
            Else
                ' Mise à jour de la prévisualisation pendant le drag (cliquer-glisser)
                RectangleEnd = New Point(Clamp(e.X, minX, maxX), Clamp(e.Y, minY, maxY))
                ' Calculer les 4 sommets du rectangle à partir de RectangleStart et RectangleEnd
                Dim x1 = Math.Min(RectangleStart.X, RectangleEnd.X)
                Dim x2 = Math.Max(RectangleStart.X, RectangleEnd.X)
                Dim y1 = Math.Min(RectangleStart.Y, RectangleEnd.Y)
                Dim y2 = Math.Max(RectangleStart.Y, RectangleEnd.Y)
                PointsQuad.Clear()
                PointsQuad.Add(New Point(x1, y1)) ' TL
                PointsQuad.Add(New Point(x2, y1)) ' TR
                PointsQuad.Add(New Point(x2, y2)) ' BR
                PointsQuad.Add(New Point(x1, y2)) ' BL
                AfficherPanelValRectangle()
                PanelEcran.Invalidate()
            End If
        End If
    End Sub

    Private Sub PanelEcran_MouseUp(sender As Object, e As MouseEventArgs) Handles PanelEcran.MouseUp
        If OutilActif = "crayon" AndAlso e.Button = MouseButtons.Left Then
            EnCoursDeDessin = False
            DernierPoint = Point.Empty
        ElseIf OutilActif = "cercle" AndAlso EnCoursCercle AndAlso e.Button = MouseButtons.Left Then
            EnCoursCercle = False
            DessinerCerclePixel(CentreCercle, RayonCercle, SelectedColor)
            PanelEcran.Invalidate()
        ElseIf OutilActif = "triangle" AndAlso TriangleEnCours Then
            If TriangleDragIndex >= 0 Then
                TriangleDragIndex = -1
            ElseIf Not PanelValTri.Visible Then
                AfficherPanelValTri()
            End If
            PanelEcran.Invalidate()
        ElseIf OutilActif = "rectangle" AndAlso RectangleEnCours Then
            ' Si on relâche après un déplacement de sommet, simplement arrêter le drag
            If RectangleDragIndex >= 0 Then
                RectangleDragIndex = -1
            Else
                ' Ne pas dessiner immédiatement : laisser la prévisualisation et permettre la modification
                ' Afficher le panneau de validation (comme pour le triangle) pour confirmer ou annuler
                AfficherPanelValRectangle()
                PanelValTri.Visible = True
                ' Ne PAS désactiver PanelEcran ici (cela empêche d'interagir avec PanelValTri si c'est son enfant)
                ' Le dessin réel sera effectué dans ButtonValTri_Click lorsque l'utilisateur validera
            End If
            PanelEcran.Invalidate()
        End If
    End Sub

    Private Sub PanelEcran_Paint(sender As Object, e As PaintEventArgs) Handles PanelEcran.Paint
        RedessinerEcran(sender, e)
        If OutilActif = "cercle" AndAlso EnCoursCercle AndAlso RayonCercle > 0 Then
            Using p As New Pen(Color.Red, 2)
                Dim x = CentreCercle.X - RayonCercle
                Dim y = CentreCercle.Y - RayonCercle
                Dim d = RayonCercle * 2
                e.Graphics.DrawEllipse(p, x, y, d, d)
            End Using
        End If
        If OutilActif = "triangle" AndAlso TriangleEnCours Then
            Using p As New Pen(Color.Red, 2)
                e.Graphics.DrawPolygon(p, {TriangleSommet1, TriangleSommet2, TriangleSommet3})
            End Using
            For Each pt In {TriangleSommet1, TriangleSommet2, TriangleSommet3}
                Using b As New SolidBrush(Color.Yellow)
                    e.Graphics.FillEllipse(b, pt.X - 5, pt.Y - 5, 10, 10)
                End Using
            Next
        ElseIf OutilActif = "rectangle" AndAlso PointsQuad.Count = 4 AndAlso RectangleEnCours Then
            Using p As New Pen(Color.Red, 2)
                e.Graphics.DrawPolygon(p, PointsQuad.ToArray())
            End Using
            For Each pt In PointsQuad
                Using b As New SolidBrush(Color.Yellow)
                    e.Graphics.FillEllipse(b, pt.X - 5, pt.Y - 5, 10, 10)
                End Using
            Next
        End If
    End Sub



    ' Tracé fluide du crayon (Bresenham)
    Private Sub DessinerLigneEntreDernierPoint(pt As Point)
        If DernierPoint = Point.Empty Then
            DernierPoint = pt
        End If
        Dim x0 As Integer = DernierPoint.X \ TAILLE_PIXEL
        Dim y0 As Integer = DernierPoint.Y \ TAILLE_PIXEL
        Dim x1 As Integer = pt.X \ TAILLE_PIXEL
        Dim y1 As Integer = pt.Y \ TAILLE_PIXEL
        Dim dx As Integer = Math.Abs(x1 - x0)
        Dim dy As Integer = Math.Abs(y1 - y0)
        Dim sx As Integer = If(x0 < x1, 1, -1)
        Dim sy As Integer = If(y0 < y1, 1, -1)
        Dim err As Integer = dx - dy
        While True
            ModifierPixel(x0, y0, SelectedColor)
            If x0 = x1 AndAlso y0 = y1 Then Exit While
            Dim e2 As Integer = 2 * err
            If e2 > -dy Then
                err -= dy
                x0 += sx
            End If
            If e2 < dx Then
                err += dx
                y0 += sy
            End If
        End While
    End Sub

    Private Function QuadSommetProche(pt As Point) As Integer
        For i As Integer = 0 To PointsQuad.Count - 1
            If Math.Abs(pt.X - PointsQuad(i).X) < 8 AndAlso Math.Abs(pt.Y - PointsQuad(i).Y) < 8 Then
                Return i
            End If
        Next
        Return -1
    End Function




    Private Sub DessinerQuadPixel(pts() As Point, couleur As Color)
        ' Dessiner les 4 côtés
        For i = 0 To 3
            DessinerLignePixel(pts(i), pts((i + 1) Mod 4), couleur)
        Next
        PanelEcran.Invalidate()
    End Sub


    Sub ModifierPixel(x As Integer, y As Integer, couleur As Color)
        If x >= 0 AndAlso x < LARGEUR_ECRAN AndAlso y >= 0 AndAlso y < HAUTEUR_ECRAN Then
            Ecran(x, y) = couleur
            CouleursPixels(x, y) = couleur
            PanelEcran.Invalidate(New Rectangle(x * TAILLE_PIXEL, y * TAILLE_PIXEL, TAILLE_PIXEL, TAILLE_PIXEL))
            ' Vérifier le groupe 2x3 correspondant à ce pixel
            Try
                Dim cx = x \ CELL_WIDTH
                Dim cy = y \ CELL_HEIGHT
                CheckOverColorForCell(cx, cy)
            Catch ex As Exception
                ' ignore
            End Try
        End If
    End Sub

    Function LirePixel(x As Integer, y As Integer) As Color
        ' Retourne la couleur du pixel à la position donnée en tenant compte du mode gris.
        ' Si hors limites, retourne Noir (cohérent avec l'initialisation de l'écran).
        If x >= 0 AndAlso x < LARGEUR_ECRAN AndAlso y >= 0 AndAlso y < HAUTEUR_ECRAN Then
            Dim couleur As Color = CouleursPixels(x, y)
            If ModeGris Then
                Return ConvertirEnGris(couleur)
            End If
            Return couleur
        Else
            Return Color.Black
        End If
    End Function


    Private Sub DessinerPixelSousSouris(e As MouseEventArgs)
        Dim xPixel As Integer = e.X \ TAILLE_PIXEL
        Dim yPixel As Integer = e.Y \ TAILLE_PIXEL
        If xPixel >= 0 AndAlso xPixel < LARGEUR_ECRAN AndAlso yPixel >= 0 AndAlso yPixel < HAUTEUR_ECRAN Then
            ModifierPixel(xPixel, yPixel, SelectedColor)
        End If
    End Sub

    Private Sub DessinerCerclePixel(centre As Point, rayon As Integer, couleur As Color)
        SauvegarderEtatPourUndo()
        Dim cx As Integer = centre.X \ TAILLE_PIXEL
        Dim cy As Integer = centre.Y \ TAILLE_PIXEL
        Dim r As Integer = Math.Max(1, rayon \ TAILLE_PIXEL)
        For angle As Double = 0 To 2 * Math.PI Step 0.005
            Dim x As Integer = cx + CInt(r * Math.Cos(angle))
            Dim y As Integer = cy + CInt(r * Math.Sin(angle))
            If x >= 0 AndAlso x < LARGEUR_ECRAN AndAlso y >= 0 AndAlso y < HAUTEUR_ECRAN Then
                CouleursPixels(x, y) = couleur
            End If
        Next
        PanelEcran.Invalidate()
    End Sub

    Private Sub DessinerTrianglePixel(p1 As Point, p2 As Point, p3 As Point, couleur As Color)
        Dim pts = {p1, p2, p3}
        For i = 0 To 2
            Dim a = pts(i)
            Dim b = pts((i + 1) Mod 3)
            DessinerLignePixel(a, b, couleur)
        Next
        PanelEcran.Invalidate()
    End Sub

    Private Sub DessinerLignePixel(p1 As Point, p2 As Point, couleur As Color)
        Dim x0 As Integer = p1.X \ TAILLE_PIXEL
        Dim y0 As Integer = p1.Y \ TAILLE_PIXEL
        Dim x1 As Integer = p2.X \ TAILLE_PIXEL
        Dim y1 As Integer = p2.Y \ TAILLE_PIXEL
        Dim dx As Integer = Math.Abs(x1 - x0)
        Dim dy As Integer = Math.Abs(y1 - y0)
        Dim sx As Integer = If(x0 < x1, 1, -1)
        Dim sy As Integer = If(y0 < y1, 1, -1)
        Dim err As Integer = dx - dy
        While True
            If x0 >= 0 AndAlso x0 < LARGEUR_ECRAN AndAlso y0 >= 0 AndAlso y0 < HAUTEUR_ECRAN Then
                CouleursPixels(x0, y0) = couleur
                ' Vérifier cellule correspondante
                Try
                    CheckOverColorForCell(x0 \ CELL_WIDTH, y0 \ CELL_HEIGHT)
                Catch
                End Try
            End If
            If x0 = x1 AndAlso y0 = y1 Then Exit While
            Dim e2 As Integer = 2 * err
            If e2 > -dy Then
                err -= dy
                x0 += sx
            End If
            If e2 < dx Then
                err += dx
                y0 += sy
            End If
        End While
    End Sub

    Private Sub RedessinerEcran(sender As Object, e As PaintEventArgs)
        Dim g As Graphics = e.Graphics
        g.Clear(Color.Black)
        For x = 0 To LARGEUR_ECRAN - 1
            For y = 0 To HAUTEUR_ECRAN - 1
                Dim couleur As Color = CouleursPixels(x, y)
                If ModeGris Then couleur = ConvertirEnGris(couleur)
                Using b As New SolidBrush(couleur)
                    g.FillRectangle(b, x * TAILLE_PIXEL, y * TAILLE_PIXEL, TAILLE_PIXEL, TAILLE_PIXEL)
                End Using
            Next
        Next
        Using p As New Pen(Color.Gray, 1)
            For x = 1 To LARGEUR_ECRAN - 1
                Dim px As Integer = x * TAILLE_PIXEL
                g.DrawLine(p, px, 0, px, HAUTEUR_ECRAN * TAILLE_PIXEL)
            Next
            For y = 1 To HAUTEUR_ECRAN - 1
                Dim py As Integer = y * TAILLE_PIXEL
                g.DrawLine(p, 0, py, LARGEUR_ECRAN * TAILLE_PIXEL, py)
            Next
        End Using
        Using p As New Pen(Color.Yellow, 2)
            For x = 0 To LARGEUR_ECRAN Step 2
                Dim px As Integer = x * TAILLE_PIXEL
                g.DrawLine(p, px, 0, px, HAUTEUR_ECRAN * TAILLE_PIXEL)
            Next
            For y = 0 To HAUTEUR_ECRAN Step 3
                Dim py As Integer = y * TAILLE_PIXEL
                g.DrawLine(p, 0, py, LARGEUR_ECRAN * TAILLE_PIXEL, py)
            Next
        End Using

        ' Surbrillance des cellules détectées en OverColor (semi-transparente)
        Using br As New SolidBrush(Color.FromArgb(120, Color.Red))
            Dim cols = CHAR_COLUMNS
            Dim rows = CHAR_ROWS
            For cy = 0 To rows - 1
                For cx = 0 To cols - 1
                    If OverColorTriggered(cx, cy) Then
                        Dim rx = cx * CELL_WIDTH * TAILLE_PIXEL
                        Dim ry = cy * CELL_HEIGHT * TAILLE_PIXEL
                        Dim rw = CELL_WIDTH * TAILLE_PIXEL
                        Dim rh = CELL_HEIGHT * TAILLE_PIXEL
                        g.FillRectangle(br, rx, ry, rw, rh)
                    End If
                Next
            Next
        End Using

        ' Après le rendu, vérifier les cellules pour déclencher OverColor si nécessaire
        CheckOverColorForAllCells()
    End Sub

    Private Function ConvertirEnGris(couleur As Color) As Color
        Dim niveauGris As Integer = CInt(0.3 * couleur.R + 0.59 * couleur.G + 0.11 * couleur.B)
        Return Color.FromArgb(niveauGris, niveauGris, niveauGris)
    End Function

    Private Function CloneCouleursPixels() As Color(,)
        Dim clone As Color(,) = New Color(LARGEUR_ECRAN - 1, HAUTEUR_ECRAN - 1) {}
        Array.Copy(CouleursPixels, clone, CouleursPixels.Length)
        Return clone
    End Function

    Private Sub SauvegarderEtatPourUndo()
        UndoStack.Push(CloneCouleursPixels())
        RedoStack.Clear()
    End Sub

    Public Sub Annuler()
        If UndoStack.Count > 0 Then
            RedoStack.Push(CloneCouleursPixels())
            CouleursPixels = UndoStack.Pop()
            PanelEcran.Invalidate()
        End If
    End Sub

    Public Sub Refaire()
        If RedoStack.Count > 0 Then
            UndoStack.Push(CloneCouleursPixels())
            CouleursPixels = RedoStack.Pop()
            PanelEcran.Invalidate()
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked Then
            ModeGris = True
            Button2.BackColor = Color.Black
            Button6.BackColor = Color.FromArgb(64, 64, 64)
            Button3.BackColor = Color.FromArgb(96, 96, 96)
            Button8.BackColor = Color.FromArgb(128, 128, 128)
            Button4.BackColor = Color.FromArgb(160, 160, 160)
            Button9.BackColor = Color.FromArgb(192, 192, 192)
            Button5.BackColor = Color.FromArgb(224, 224, 224)
            Button10.BackColor = Color.White
            PanelEcran.Invalidate()
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            ModeGris = False
            Button2.BackColor = Color.Black
            Button6.BackColor = Color.Blue
            Button3.BackColor = Color.Red
            Button8.BackColor = Color.Magenta
            Button4.BackColor = Color.Lime
            Button9.BackColor = Color.Cyan
            Button5.BackColor = Color.Yellow
            Button10.BackColor = Color.White
            PanelEcran.Invalidate()
        End If
    End Sub

    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click
        Dim milieu As Integer = LARGEUR_ECRAN \ 2
        Dim hauteurA As Integer = HAUTEUR_ECRAN - 1
        For y = 0 To hauteurA
            Dim x As Integer = milieu - y * LARGEUR_ECRAN \ (2 * hauteurA)
            ModifierPixel(x, y, Color.White)
        Next
        For y = 0 To hauteurA
            Dim x As Integer = milieu + y * LARGEUR_ECRAN \ (2 * hauteurA)
            ModifierPixel(x, y, Color.White)
        Next
        Dim barreY As Integer = hauteurA \ 2
        Dim debutBarreX As Integer = milieu - (LARGEUR_ECRAN \ 4)
        Dim finBarreX As Integer = milieu + (LARGEUR_ECRAN \ 4)
        For x = debutBarreX To finBarreX
            ModifierPixel(x, barreY, Color.White)
        Next
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        SelectedColor = System.Drawing.Color.Black
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        SelectedColor = System.Drawing.Color.Blue
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        SelectedColor = System.Drawing.Color.Red
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        SelectedColor = System.Drawing.Color.Magenta
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        SelectedColor = System.Drawing.Color.Lime
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        SelectedColor = System.Drawing.Color.Cyan
    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        SelectedColor = System.Drawing.Color.Yellow
    End Sub

    Private Sub Button37_Click(sender As Object, e As EventArgs) Handles Button37.Click
        OutilActif = "cercle"
    End Sub

    Private Sub Button31_Click(sender As Object, e As EventArgs) Handles Button31.Click
        OutilActif = "crayon"
    End Sub

    Private Sub Button32_Click(sender As Object, e As EventArgs) Handles Button32.Click
        OutilActif = "pot"
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Annuler()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Refaire()
    End Sub

    Private Sub Button35_Click(sender As Object, e As EventArgs) Handles Button35.Click
        OutilActif = "triangle"
        TriangleEnCours = False
        TriangleDragIndex = -1
        PanelValTri.Visible = False
        PanelEcran.Invalidate()
    End Sub

    Private Sub AfficherPanelValTri()
        Dim sommets = {TriangleSommet1, TriangleSommet2, TriangleSommet3}
        Dim idxMinY = 0
        For i = 1 To 2
            If sommets(i).Y < sommets(idxMinY).Y Then idxMinY = i
        Next
        PanelValTri.Left = sommets(idxMinY).X + 15
        PanelValTri.Top = sommets(idxMinY).Y - PanelValTri.Height \ 2
        PanelValTri.Visible = True
    End Sub

    Private Function TriangleSommetProche(pt As Point) As Integer
        Dim sommets = {TriangleSommet1, TriangleSommet2, TriangleSommet3}
        For i = 0 To 2
            If (Math.Abs(pt.X - sommets(i).X) < 8) AndAlso (Math.Abs(pt.Y - sommets(i).Y) < 8) Then
                Return i
            End If
        Next
        Return -1
    End Function

    Private Sub ButtonValTri_Click(sender As Object, e As EventArgs) Handles ButtonValTri.Click
        SauvegarderEtatPourUndo()
        If OutilActif = "triangle" AndAlso TriangleEnCours Then
            DessinerTrianglePixel(TriangleSommet1, TriangleSommet2, TriangleSommet3, SelectedColor)
            TriangleEnCours = False
        ElseIf OutilActif = "rectangle" AndAlso PointsQuad.Count = 4 AndAlso RectangleEnCours Then
            DessinerQuadPixel(PointsQuad.ToArray(), SelectedColor)
            PointsQuad.Clear()
            RectangleEnCours = False
            RectangleDragIndex = -1
            PanelValTri.Visible = False
            PanelEcran.Enabled = True
            PanelEcran.Invalidate()
        End If
        PanelValTri.Visible = False
        PanelEcran.Invalidate()
    End Sub

    Private Sub ButtonAnnTri_Click(sender As Object, e As EventArgs) Handles ButtonAnnTri.Click
        PointsQuad.Clear()
        RectangleEnCours = False
        RectangleDragIndex = -1
        PanelValTri.Visible = False
        PanelEcran.Enabled = True
        PanelEcran.Invalidate()
        TriangleEnCours = False
    End Sub

    Private Function RectangleSommetProche(pt As Point) As Integer
        For i As Integer = 0 To PointsQuad.Count - 1
            If Math.Abs(pt.X - PointsQuad(i).X) < 8 AndAlso Math.Abs(pt.Y - PointsQuad(i).Y) < 8 Then
                Return i
            End If
        Next
        Return -1
    End Function

    Private Sub AfficherPanelValRectangle()
        Dim idxMinY = 0
        For i = 1 To 3
            If PointsQuad(i).Y < PointsQuad(idxMinY).Y Then idxMinY = i
        Next
        PanelValTri.Left = PointsQuad(idxMinY).X + 15
        PanelValTri.Top = PointsQuad(idxMinY).Y - PanelValTri.Height \ 2
        PanelValTri.Visible = True
    End Sub

    Private Sub Button34_Click(sender As Object, e As EventArgs)
        OutilActif = "rectangle"
        PointsQuad.Clear()
        RectangleEnCours = False
        RectangleDragIndex = -1
        PanelValTri.Visible = False
        PanelEcran.Invalidate()
    End Sub

    ' --- NOUVELLE LOGIQUE RECTANGLE (analogue au triangle, mais avec 4 points) ---
    ' Toutes les fonctions en double à partir d'ici sont supprimées pour éviter les erreurs BC30269.
    ' Les fonctions OverColor et RemplirZone sont conservées.

    Private Sub CheckOverColorForCell(cx As Integer, cy As Integer)
        If cx < 0 OrElse cx >= CHAR_COLUMNS OrElse cy < 0 OrElse cy >= CHAR_ROWS Then Return
        Dim distinct = CountDistinctColorsInCell(cx, cy)
        If distinct > 2 Then
            If Not OverColorTriggered(cx, cy) Then
                OverColorTriggered(cx, cy) = True
                OverColor(cx, cy)
            End If
        Else
            If OverColorTriggered(cx, cy) Then
                OverColorTriggered(cx, cy) = False
                PanelEcran.Invalidate(New Rectangle(cx * CELL_WIDTH * TAILLE_PIXEL, cy * CELL_HEIGHT * TAILLE_PIXEL, CELL_WIDTH * TAILLE_PIXEL, CELL_HEIGHT * TAILLE_PIXEL))
            End If
        End If
    End Sub

    Private Function CountDistinctColorsInCell(cx As Integer, cy As Integer) As Integer
        Dim setColors As New HashSet(Of Integer)()
        For py = 0 To CELL_HEIGHT - 1
            For px = 0 To CELL_WIDTH - 1
                Dim x = cx * CELL_WIDTH + px
                Dim y = cy * CELL_HEIGHT + py
                If x >= 0 AndAlso x < LARGEUR_ECRAN AndAlso y >= 0 AndAlso y < HAUTEUR_ECRAN Then
                    setColors.Add(CouleursPixels(x, y).ToArgb())
                End If
            Next
        Next
        Return setColors.Count
    End Function

    Private Sub CheckOverColorForAllCells()
        For cy = 0 To CHAR_ROWS - 1
            For cx = 0 To CHAR_COLUMNS - 1
                CheckOverColorForCell(cx, cy)
            Next
        Next
    End Sub

    Private Sub OverColor(cx As Integer, cy As Integer)
        Try
            ToolStripStatusLabel1.Text = "Il est impossible de placer plus de deux couleurs dans une cellule de 2*3 px."
            PanelEcran.Invalidate(New Rectangle(cx * CELL_WIDTH * TAILLE_PIXEL, cy * CELL_HEIGHT * TAILLE_PIXEL, CELL_WIDTH * TAILLE_PIXEL, CELL_HEIGHT * TAILLE_PIXEL))
            Dialog3.Show()
        Catch
        End Try
    End Sub

    Private Sub RemplirZone(x As Integer, y As Integer, couleurCible As Color, couleurRemplissage As Color)
        If x < 0 OrElse x >= LARGEUR_ECRAN OrElse y < 0 OrElse y >= HAUTEUR_ECRAN Then Exit Sub
        If CouleursPixels(x, y).ToArgb = couleurRemplissage.ToArgb Then Exit Sub
        If CouleursPixels(x, y).ToArgb <> couleurCible.ToArgb Then Exit Sub

        Dim stack As New Stack(Of Point)
        stack.Push(New Point(x, y))

        While stack.Count > 0
            Dim pt = stack.Pop()
            Dim px = pt.X
            Dim py = pt.Y

            If px >= 0 AndAlso px < LARGEUR_ECRAN AndAlso py >= 0 AndAlso py < HAUTEUR_ECRAN Then
                If CouleursPixels(px, py).ToArgb = couleurCible.ToArgb Then
                    CouleursPixels(px, py) = couleurRemplissage
                    stack.Push(New Point(px + 1, py))
                    stack.Push(New Point(px - 1, py))
                    stack.Push(New Point(px, py + 1))
                    stack.Push(New Point(px, py - 1))

                    ' Vérifier la cellule correspondante pour OverColor
                    Try
                        CheckOverColorForCell(px \ CELL_WIDTH, py \ CELL_HEIGHT)
                    Catch
                    End Try
                End If
            End If
        End While
    End Sub

    Private Sub tabPage1_Click(sender As Object, e As EventArgs) Handles tabPage1.Click

    End Sub

    Private Sub GroupBox6_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub tabPage2_Click(sender As Object, e As EventArgs) Handles tabPage2.Click

    End Sub

    Private Sub GroupBox21_Enter(sender As Object, e As EventArgs) Handles GroupBox21.Enter

    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        ExporterVDTComplet(CouleursPixels)
    End Sub

    ' Retourne soit la couleur de fond, soit la couleur de premier plan, soit la chaîne binaire des 6 pixels
    ' Exemples d'appels :
    '   LireGroupe(0,0,"cBg")   -> "Color.Black" ou "Color.FromArgb(...)"
    '   LireGroupe(0,0,"cFg")   -> "Color.Lime"
    '   LireGroupe(0,0,"bits")  -> "001101"
    '   LireGroupe(0,0,"all")   -> "Color.Black,Color.Lime,001101"
    Private Function LireGroupe(ByVal StartX As Integer, ByVal StartY As Integer, ByVal part As String) As String
        Dim ColorToLiteral As Func(Of Color, String) = Function(c As Color) As String
                                                           If c.IsNamedColor OrElse c.IsKnownColor OrElse c.IsSystemColor Then
                                                               Return "Color." & c.Name
                                                           Else
                                                               Return String.Format("Color.FromArgb({0},{1},{2},{3})", c.A, c.R, c.G, c.B)
                                                           End If
                                                       End Function

        ' Collecte des couleurs et fréquences dans le bloc 2x3
        Dim counts As New Dictionary(Of Integer, Integer)()
        Dim colorByKey As New Dictionary(Of Integer, Color)()
        For r As Integer = 0 To CELL_HEIGHT - 1
            For c As Integer = 0 To CELL_WIDTH - 1
                Dim x = StartX + c
                Dim y = StartY + r
                Dim col As Color = Color.Black
                If x >= 0 AndAlso x < LARGEUR_ECRAN AndAlso y >= 0 AndAlso y < HAUTEUR_ECRAN Then
                    col = CouleursPixels(x, y)
                End If
                Dim key = col.ToArgb()
                If Not counts.ContainsKey(key) Then
                    counts(key) = 0
                    colorByKey(key) = col
                End If
                counts(key) += 1
            Next
        Next

        If counts.Count = 0 Then
            Dim allEmpty = ColorToLiteral(Color.Black) & "," & ColorToLiteral(Color.Black) & ",000000"
            If String.IsNullOrEmpty(part) Then Return allEmpty
            Select Case part.ToLowerInvariant()
                Case "cbg" : Return ColorToLiteral(Color.Black)
                Case "cfg" : Return ColorToLiteral(Color.Black)
                Case "bits" : Return "000000"
                Case "varname" : Return "Sixel_000000"
                Case "varvalue" : Return Chr(159)
                Case Else : Return allEmpty
            End Select
        End If

        ' Tri par fréquence décroissante
        Dim sorted = counts.OrderByDescending(Function(kv) kv.Value).ToList()

        Dim bgColor As Color = colorByKey(sorted(0).Key)
        Dim fgColor As Color = If(sorted.Count > 1, colorByKey(sorted(1).Key), Color.Black)

        ' Ordre P1..P6 : colonne gauche (haut,milieu,bas) puis colonne droite (haut,milieu,bas)
        Dim pixelsOrder() As Point = {
        New Point(0, 0), New Point(0, 1), New Point(0, 2),
        New Point(1, 0), New Point(1, 1), New Point(1, 2)
    }

        Dim bitsSb As New StringBuilder(6)
        For Each p As Point In pixelsOrder
            Dim px = StartX + p.X
            Dim py = StartY + p.Y
            Dim col As Color = Color.Black
            If px >= 0 AndAlso px < LARGEUR_ECRAN AndAlso py >= 0 AndAlso py < HAUTEUR_ECRAN Then
                col = CouleursPixels(px, py)
            End If
            If col.ToArgb() = fgColor.ToArgb() Then
                bitsSb.Append("1")
            Else
                bitsSb.Append("0")
            End If
        Next

        Dim bitPattern As String = bitsSb.ToString()
        Dim varName As String = "Sixel_" & bitPattern
        Dim varValue As String = Nothing

        ' Récupérer la valeur du champ par réflexion (supporte Shared/Instance)
        Try
            Dim fi As System.Reflection.FieldInfo = Me.GetType().GetField(varName, System.Reflection.BindingFlags.NonPublic Or System.Reflection.BindingFlags.Static Or System.Reflection.BindingFlags.Instance)
            If fi IsNot Nothing Then
                Dim raw = If(fi.IsStatic, fi.GetValue(Nothing), fi.GetValue(Me))
                If raw IsNot Nothing Then varValue = CStr(raw)
            End If
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("LireGroupe réflexion: " & ex.Message)
            varValue = Nothing
        End Try

        Dim fullResult As String = ColorToLiteral(bgColor) & "," & ColorToLiteral(fgColor) & "," & bitPattern

        If String.IsNullOrEmpty(part) Then Return fullResult

        Select Case part.ToLowerInvariant()
            Case "cbg", "bg", "colorbg"
                Return ColorToLiteral(bgColor)
            Case "cfg", "fg", "colorfg"
                Return ColorToLiteral(fgColor)
            Case "varname"
                Return varName
            Case "varvalue", "char", "content"
                If varValue IsNot Nothing Then Return varValue
                Return varName
            Case "bits", "binary", "binaire"
                ' Si vous voulez que "bits" retourne le contenu quand il existe : renvoyer varValue sinon le motif
                If varValue IsNot Nothing Then Return varValue
                Return bitPattern
            Case "all"
                Return fullResult
            Case Else
                Return fullResult
        End Select
    End Function


End Class