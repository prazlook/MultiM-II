Public NotInheritable Class BootVDTEdit

    'TODO: ce formulaire peut facilement être configuré comme écran de démarrage de l'application en accédant à l'onglet "Application"
    '  du Concepteur de projets ("Propriétés" sous le menu "Projet").
    Private player As System.Media.SoundPlayer



    Private Async Sub DémarrerProgression()
        ' Lance la progression dans une tâche asynchrone
        Await Task.Run(Sub()
                           For i As Integer = 0 To 100
                               ' Utilisation de Invoke pour modifier la barre depuis le thread UI
                               Me.Invoke(Sub()
                                             ProgressBar1.Value = i
                                         End Sub)

                               ' Attendre 50 ms entre chaque étape
                               Threading.Thread.Sleep(80)
                           Next
                       End Sub)

        ' Une fois la progression terminée, fermez l'écran de démarrage et ouvrez VDT Edit
        VDT_Edit.Show()
        Me.Close()
    End Sub


    Private Sub SplashScreen1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        ' Charger le son à partir des ressources
        Dim soundStream As UnmanagedMemoryStream = My.Resources.son_chargement

        ' Créer le lecteur audio
        player = New SoundPlayer(soundStream)

        ' Jouer le son
        player.Play()

        ' Attendre 2 secondes
        Thread.Sleep(2000)

        DémarrerProgression()

    End Sub

End Class
