Public Class GuideDevSommmaire
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
        GuideP2.Show()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        GuideP5Emulateur.Show()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        GuideP6VELiteIntro.Show()
    End Sub

    Private Sub GuideDevSommmaire_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class