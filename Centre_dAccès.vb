Public Class centre_acces

    'Fonction SplashScreen_Load
    Public Sub SplashScreen_Load(ByVal sender As Object, ByVal e As System.EventArgs)
        ' Cette fonction se déclenche à l'ouverture de la fenêtre.

    End Sub

    'Fonction pictureBox1_Click
    Public Sub pictureBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs)
    End Sub

    'Fonction button1_Click
    Public Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Accueil.Show()
        Me.DialogResult = System.Windows.Forms.DialogResult.None : Me.Close()
    End Sub

    'Fonction label1_Click
    Public Sub label1_Click(ByVal sender As Object, ByVal e As System.EventArgs)
    End Sub

    'Fonction button4_Click
    Public Sub button4_Click(ByVal sender As Object, ByVal e As System.EventArgs)
    End Sub

    'Fonction button2_Click
    Public Sub button2_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.None : Me.Close()
        SplashScreen.DialogResult = System.Windows.Forms.DialogResult.None : SplashScreen.Close()
    End Sub

    'Fonction button6_Click
    Public Sub button6_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        'Ecran_de_démarrage2.Show
    End Sub
End Class
