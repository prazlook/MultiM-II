Public Class Form1

    ' Taille logique de l'écran
    Const LARGEUR_ECRAN As Integer = 80
    Const HAUTEUR_ECRAN As Integer = 75

    ' Taille visuelle de chaque "pixel"
    Const TAILLE_PIXEL As Integer = 10

    ' Tableau de couleurs représentant l'écran
    Dim Ecran(LARGEUR_ECRAN - 1, HAUTEUR_ECRAN - 1) As Color

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialisation à noir
        For x = 0 To LARGEUR_ECRAN - 1
            For y = 0 To HAUTEUR_ECRAN - 1
                Ecran(x, y) = Color.Black
            Next
        Next

        ' Redessine à chaque changement
        AddHandler PanelEcran.Paint, AddressOf RedessinerEcran
        PanelEcran.Invalidate()
    End Sub

    Private Sub RedessinerEcran(sender As Object, e As PaintEventArgs)
        Dim g As Graphics = e.Graphics
        g.Clear(Color.Black)

        ' Affiche les pixels
        For x = 0 To LARGEUR_ECRAN - 1
            For y = 0 To HAUTEUR_ECRAN - 1
                Using b As New SolidBrush(Ecran(x, y))
                    g.FillRectangle(b, x * TAILLE_PIXEL, y * TAILLE_PIXEL, TAILLE_PIXEL, TAILLE_PIXEL)
                End Using
            Next
        Next

        ' Dessine la grille jaune (tous les 2×3 pixels)
        Using p As New Pen(Color.Yellow)
            ' Lignes verticales tous les 2 pixels
            For x = 0 To LARGEUR_ECRAN Step 2
                Dim px As Integer = x * TAILLE_PIXEL
                g.DrawLine(p, px, 0, px, HAUTEUR_ECRAN * TAILLE_PIXEL)
            Next

            ' Lignes horizontales tous les 3 pixels
            For y = 0 To HAUTEUR_ECRAN Step 3
                Dim py As Integer = y * TAILLE_PIXEL
                g.DrawLine(p, 0, py, LARGEUR_ECRAN * TAILLE_PIXEL, py)
            Next
        End Using
    End Sub


    ' Fonction pour changer la couleur d’un pixel
    Sub ModifierPixel(x As Integer, y As Integer, couleur As Color)
        If x >= 0 AndAlso x < LARGEUR_ECRAN AndAlso y >= 0 AndAlso y < HAUTEUR_ECRAN Then
            Ecran(x, y) = couleur
            PanelEcran.Invalidate(New Rectangle(x * TAILLE_PIXEL, y * TAILLE_PIXEL, TAILLE_PIXEL, TAILLE_PIXEL))
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Exemple : afficher un grand "A" en blanc
        Dim milieu As Integer = LARGEUR_ECRAN \ 2
        Dim hauteurA As Integer = HAUTEUR_ECRAN - 1

        ' Trace la jambe gauche du A
        For y = 0 To hauteurA
            Dim x As Integer = milieu - y * LARGEUR_ECRAN \ (2 * hauteurA)
            ModifierPixel(x, y, Color.White)
        Next

        ' Trace la jambe droite du A
        For y = 0 To hauteurA
            Dim x As Integer = milieu + y * LARGEUR_ECRAN \ (2 * hauteurA)
            ModifierPixel(x, y, Color.White)
        Next

        ' Trace la barre horizontale du A (au milieu vertical)
        Dim barreY As Integer = hauteurA \ 2
        Dim debutBarreX As Integer = milieu - (LARGEUR_ECRAN \ 4)
        Dim finBarreX As Integer = milieu + (LARGEUR_ECRAN \ 4)

        For x = debutBarreX To finBarreX
            ModifierPixel(x, barreY, Color.White)
        Next

    End Sub

    Private Sub PanelEcran_Paint(sender As Object, e As PaintEventArgs) Handles PanelEcran.Paint

    End Sub
End Class