Public Class BootCompistart

    'TODO: ce formulaire peut facilement être configuré comme écran de démarrage de l'application en accédant à l'onglet "Application"
    '  du Concepteur de projets ("Propriétés" sous le menu "Projet").

    Private Async Sub DémarrerProgression()
        Dim random As New Random()
        Dim valeur As Integer = 0
        Dim dureeTotaleMs As Integer = random.Next(6000, 8000) ' entre 6 et 8 secondes
        Dim tempsPasseMs As Integer = 0

        ' On va avancer de 0 à 100
        While valeur < 100 AndAlso tempsPasseMs < dureeTotaleMs
            ' Avance aléatoire entre 1 et 5 %
            Dim avance As Integer = random.Next(1, 6)
            valeur = Math.Min(100, valeur + avance)

            ' Mise à jour UI (Invoke car thread différent)
            Me.Invoke(Sub()
                          ProgressBar1.Value = valeur
                      End Sub)

            ' Pause aléatoire entre 20 et 300 ms (pour avoir du fluide et du saccadé)
            Dim pause As Integer = random.Next(20, 301)
            Await Task.Delay(pause)
            tempsPasseMs += pause
        End While

        ' Assurer que la barre arrive bien à 100 %
        Me.Invoke(Sub()
                      ProgressBar1.Value = 100
                  End Sub)

        ' Une fois la progression terminée, fermez l'écran de démarrage et ouvrez VDT Edit
        Compistart.Show()
        Me.Close()
    End Sub

    Private Sub SplashScreen1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        DémarrerProgression()
    End Sub

End Class
