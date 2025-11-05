Public Class GuideP4Reponses
    ' Propriétés publiques pour recevoir les résultats
    Public ReponseQ1 As Boolean = False
    Public ReponseQ2 As Boolean = False
    Public ReponseQ3 As Boolean = False
    Public ReponseQ4 As Boolean = False

    Private Sub GuideP4Reponses_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Masquer/montrer les panels selon les booléens reçus
        Q1True.Visible = ReponseQ1
        Q1False.Visible = Not ReponseQ1

        Q2True.Visible = ReponseQ2
        Q2False.Visible = Not ReponseQ2

        Q3True.Visible = ReponseQ3
        Q3False.Visible = Not ReponseQ3

        Q4True.Visible = ReponseQ4
        Q4False.Visible = Not ReponseQ4
    End Sub

    Private Sub Label22_Click(sender As Object, e As EventArgs) Handles Label22.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        GuideP5Emulateur.Show()
        Me.Close()
    End Sub
End Class