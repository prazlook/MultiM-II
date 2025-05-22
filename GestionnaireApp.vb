Public Class Gestionnaire

    'Fonction Form_Load
    Public Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Cette fonction se déclenche à l'ouverture de la fenêtre.
        '
        'This function is launched during opening.
        SplashScreen.Show()
        centre_acces.Show()
    End Sub
End Class
