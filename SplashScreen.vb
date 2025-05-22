Public Class SplashScreen

    Private Async Sub DémarrerProgression()
        ' Lance la progression dans une tâche asynchrone
        Await Task.Run(Sub()
                           For i As Integer = 0 To 100
                               ' Utilisation de Invoke pour modifier la barre depuis le thread UI
                               Me.Invoke(Sub()
                                             progressBar1.Value = i
                                         End Sub)

                               ' Attendre 50 ms entre chaque étape
                               Threading.Thread.Sleep(80)
                           Next
                       End Sub)


    End Sub

    ' Déclare le SoundPlayer au niveau de la classe (donc accessible partout dans SplashScreen)
    Public Shared player As System.Media.SoundPlayer

    'Fonction SplashScreen_Load
    Public Sub SplashScreen_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Charge et démarre le son
        Dim soundStream As UnmanagedMemoryStream = My.Resources.son_demarrage
        player = New System.Media.SoundPlayer(soundStream)
        player.Play()



        ' Affiche la fenêtre principale
        centre_acces.Show()
    End Sub
End Class

