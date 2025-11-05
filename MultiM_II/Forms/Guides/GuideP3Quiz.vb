Imports System.Linq

Public Class GuideP3Quiz

    Public ReponseQ1 As Boolean = False
    Public ReponseQ2 As Boolean = False
    Public ReponseQ3 As Boolean = False
    Public ReponseQ4 As Boolean = False

    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each RadioButton In Me.Controls.OfType(Of RadioButton)()
            RadioButton.Checked = False
        Next
    End Sub

    Private Sub trackbar1_Scroll(sender As Object, e As EventArgs) Handles trackbar1.Scroll
        label10.Text = trackbar1.Value.ToString()
    End Sub

    Private Sub button34_Click(sender As Object, e As EventArgs) Handles button34.Click
        label10.Text = "50"
    End Sub

    Private Sub button35_Click(sender As Object, e As EventArgs) Handles button35.Click
        label10.Text = "400"
    End Sub

    Private Sub button36_Click(sender As Object, e As EventArgs) Handles button36.Click
        label10.Text = "1200"
    End Sub

    Private Sub button37_Click(sender As Object, e As EventArgs) Handles button37.Click
        label10.Text = "2400"
    End Sub

    Private Sub button38_Click(sender As Object, e As EventArgs) Handles button38.Click
        label10.Text = "4800"
    End Sub

    Private Sub button39_Click(sender As Object, e As EventArgs) Handles button39.Click
        label10.Text = "9600"
    End Sub

    Private Sub button40_Click(sender As Object, e As EventArgs) Handles button40.Click
        label10.Text = "19200"
    End Sub

    Private Sub button41_Click(sender As Object, e As EventArgs) Handles button41.Click
        label10.Text = "38400"
    End Sub

    Private Sub button42_Click(sender As Object, e As EventArgs) Handles button42.Click
        label10.Text = "MAX"
    End Sub


    Private Sub GuideP3Quiz_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    ' Met à jour les variables ReponseQ1..ReponseQ4 à partir des contrôles de la fenêtre.
    Private Sub UpdateResponses()
        ' Question 1 : bonne réponse = Q1R3
        ReponseQ1 = Q1R3.Checked

        ' Question 2 : considérer "1200" comme bonne réponse (ou adapter si nécessaire)
        Dim val As Integer
        If String.Equals(label10.Text, "MAX", StringComparison.OrdinalIgnoreCase) Then
            ReponseQ2 = False
        ElseIf Integer.TryParse(label10.Text, val) Then
            ReponseQ2 = (val = 1200)
        Else
            ReponseQ2 = (trackbar1.Value = 1200)
        End If

        ' Question 3 : bonne réponse = RadioButton10 (d'après le designer)
        ReponseQ3 = RadioButton10.Checked

        ' Question 4 : bonne réponse = RadioButton8 (d'après le designer)
        ReponseQ4 = RadioButton8.Checked
    End Sub

    ' Handler du bouton "Suivant" : transmet les booléens à GuideP4Reponses et affiche la page de réponses
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        UpdateResponses()
        Dim resultsForm As New GuideP4Reponses()
        resultsForm.ReponseQ1 = ReponseQ1
        resultsForm.ReponseQ2 = ReponseQ2
        resultsForm.ReponseQ3 = ReponseQ3
        resultsForm.ReponseQ4 = ReponseQ4
        Me.Hide()
        resultsForm.Show()
    End Sub

End Class