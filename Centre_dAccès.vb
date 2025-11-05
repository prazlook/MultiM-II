Public Class centre_acces

    'Fonction SplashScreen_Load
    Public Sub SplashScreen_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Cette fonction se déclenche à l'ouverture de la fenêtre.

        BlinkButton7()

        ' Charge et démarre le son
        Dim soundStream As UnmanagedMemoryStream = My.Resources.son_demarrage
        player = New System.Media.SoundPlayer(soundStream)
        player.Play()

    End Sub

    ' Déclare le SoundPlayer au niveau de la classe (donc accessible partout dans SplashScreen)
    Public Shared player As System.Media.SoundPlayer

    Dim color1 As Color = Color.White
    Dim color2 As Color = Color.FromArgb(255, 255, 192)
    Private blinking As Boolean = False

    Public Async Sub BlinkButton7()
        blinking = True

        While blinking
            Button7.BackColor = color2
            Button7.Text = "Je suis nouveau ici, aidez-moi"
            Await Task.Delay(500)

            If Not blinking Then Exit While

            Button7.BackColor = color1
            Button7.Text = ""
            Await Task.Delay(500)
        End While
    End Sub



    'Fonction button1_Click
    Public Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
        Accueil.Show()
        Me.Hide()
    End Sub

    'Fonction label1_Click
    Public Sub label1_Click(ByVal sender As Object, ByVal e As System.EventArgs)
    End Sub

    'Fonction button4_Click
    Public Sub button4_Click(ByVal sender As Object, ByVal e As System.EventArgs)
    End Sub

    'Fonction button2_Click
    Public Sub button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button2.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.None : Me.Close()
    End Sub

    'Fonction button6_Click
    Public Sub button6_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button6.Click
        'Ecran_de_démarrage2.Show
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        GuideP1Accueil.Show()
        Button7.BackColor = color2
        Button7.Text = "Vous inquiétez pas, on arrive"
        blinking = False
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Button7_Click(sender, e)
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
