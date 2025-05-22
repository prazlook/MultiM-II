Public Class VDT_Edit

    'Fonction Form_Load
    Public Sub VDTEditClose(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        'Cette fonction se déclenche à l'ouverture de la fenêtre.
        SplashScreen.player.Play()
        'This function is launched during opening.
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
End Class
