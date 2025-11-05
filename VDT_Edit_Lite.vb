Imports System.Collections.Generic
Imports System.Drawing.Text

Public Class VDT_Edit_Lite

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

    Private selectedBPS As Integer = 1200

    ' À placer dans la classe VDT_Edit

    ' Ajoutez ce champ pour mémoriser le dernier point dessiné
    Private DernierPoint As Point = Point.Empty

    Private Sub ChargerPoliceMinitel()
        Dim pfc As New PrivateFontCollection()
        Dim fontData() As Byte = My.Resources.Minitel
        Dim fontPtr As IntPtr = Marshal.AllocCoTaskMem(fontData.Length)
        Marshal.Copy(fontData, 0, fontPtr, fontData.Length)
        pfc.AddMemoryFont(fontPtr, fontData.Length)
        Marshal.FreeCoTaskMem(fontPtr)
        PoliceMinitel = pfc.Families(0)
    End Sub

    'Fonction button1_Click
    Public Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) 'Handles button1.Click
        Me.treeView1.Nodes.Add("Barre de texte", "Barre de texte", 0, 0)
    End Sub

    'Fonction button2_Click
    Public Sub button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) 'Handles button2.Click
        Me.treeView1.Nodes.Add("Bloc de texte", "Bloc de texte", 0, 0)
    End Sub

    'Fonction button5_Click
    Public Sub button5_Click(ByVal sender As Object, ByVal e As System.EventArgs) 'Handles button5.Click
        Me.treeView1.Nodes.Add("Graphiques", "Graphiques", 0, 0)
    End Sub

    'Fonction button3_Click
    Public Sub button3_Click(ByVal sender As Object, ByVal e As System.EventArgs) 'Handles button3.Click
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
        Else
            PanelEcran.Cursor = Cursors.Default
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
        End If
    End Sub

    Private Sub PanelEcran_Paint(sender As Object, e As PaintEventArgs) Handles PanelEcran.Paint
        RedessinerEcran(sender, e)
        ' Cercle interactif (aperçu)
        If OutilActif = "cercle" AndAlso EnCoursCercle AndAlso RayonCercle > 0 Then
            Using p As New Pen(Color.Red, 2)
                Dim x = CentreCercle.X - RayonCercle
                Dim y = CentreCercle.Y - RayonCercle
                Dim d = RayonCercle * 2
                e.Graphics.DrawEllipse(p, x, y, d, d)
            End Using
        End If
        ' Triangle interactif
        If OutilActif = "triangle" AndAlso TriangleEnCours Then
            Using p As New Pen(Color.Red, 2)
                e.Graphics.DrawPolygon(p, {TriangleSommet1, TriangleSommet2, TriangleSommet3})
            End Using
            For Each pt In {TriangleSommet1, TriangleSommet2, TriangleSommet3}
                Using b As New SolidBrush(Color.Yellow)
                    e.Graphics.FillEllipse(b, pt.X - 5, pt.Y - 5, 10, 10)
                End Using
            Next
        End If
    End Sub

    Private Sub VDT_Edit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ChargerPoliceMinitel()
        Accueil.player.Stop()
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

    Sub ModifierPixel(x As Integer, y As Integer, couleur As Color)
        If x >= 0 AndAlso x < LARGEUR_ECRAN AndAlso y >= 0 AndAlso y < HAUTEUR_ECRAN Then
            Ecran(x, y) = couleur
            CouleursPixels(x, y) = couleur
            PanelEcran.Invalidate(New Rectangle(x * TAILLE_PIXEL, y * TAILLE_PIXEL, TAILLE_PIXEL, TAILLE_PIXEL))
        End If
    End Sub

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

    Private Sub Button30_Click(sender As Object, e As EventArgs)
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
        SelectedColor = System.Drawing.Color.FromArgb(0, 0, 0)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        SelectedColor = System.Drawing.Color.FromArgb(0, 0, 255)
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        SelectedColor = System.Drawing.Color.FromArgb(255, 0, 0)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        SelectedColor = System.Drawing.Color.FromArgb(255, 0, 255)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        SelectedColor = System.Drawing.Color.FromArgb(0, 255, 0)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        SelectedColor = System.Drawing.Color.FromArgb(0, 255, 255)
    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        SelectedColor = System.Drawing.Color.FromArgb(255, 255, 0)
    End Sub

    Private Sub Button37_Click(sender As Object, e As EventArgs)
        OutilActif = "cercle"
    End Sub

    Private Sub Button31_Click(sender As Object, e As EventArgs) Handles Button31.Click
        OutilActif = "crayon"
    End Sub

    Private Sub Button32_Click(sender As Object, e As EventArgs)
        OutilActif = "pot"
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Annuler()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Refaire()
    End Sub

    Private Sub Button35_Click(sender As Object, e As EventArgs)
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
        DessinerTrianglePixel(TriangleSommet1, TriangleSommet2, TriangleSommet3, SelectedColor)
        TriangleEnCours = False
        PanelValTri.Visible = False
        PanelEcran.Invalidate()
    End Sub

    Private Sub ButtonAnnTri_Click(sender As Object, e As EventArgs) Handles ButtonAnnTri.Click
        TriangleEnCours = False
        PanelValTri.Visible = False
        PanelEcran.Invalidate()
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
                End If
            End If
        End While
    End Sub



    Public Sub ExporterEcranVidetotex(fichier As String)
        Dim largeurCar As Integer = LARGEUR_ECRAN \ 2
        Dim hauteurCar As Integer = HAUTEUR_ECRAN \ 3
        Dim octets(largeurCar * hauteurCar - 1) As Byte
        For cy = 0 To hauteurCar - 1
            For cx = 0 To largeurCar - 1
                Dim bits As Integer = 0
                For py = 0 To 2
                    For px = 0 To 1
                        Dim x = cx * 2 + px
                        Dim y = cy * 3 + py
                        Dim bitIndex = py * 2 + px
                        Dim mapping() As Integer = {0, 2, 4, 1, 3, 5}
                        Dim bitPos = mapping(bitIndex)
                        If x < LARGEUR_ECRAN AndAlso y < HAUTEUR_ECRAN Then
                            Dim couleur = CouleursPixels(x, y)
                            If couleur.ToArgb <> Color.Black.ToArgb Then
                                bits = bits Or (1 << bitPos)
                            End If
                        End If
                    Next
                Next
                octets(cy * largeurCar + cx) = CByte(&H40 Or (bits And &H3F))
            Next
        Next
        System.IO.File.WriteAllBytes(fichier, octets)
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        Using dlg As New SaveFileDialog()
            dlg.Title = "Exporter l'écran au format Vidéotex"
            dlg.Filter = "Fichier Vidéotex (*.vdt)|*.vdt"
            If dlg.ShowDialog() = DialogResult.OK Then
                ExporterEcranVidetotex(dlg.FileName)
            End If
        End Using
    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs)

    End Sub
End Class

