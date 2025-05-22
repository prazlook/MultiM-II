Public Class Boîte_de_dialogueBarre
    
    'Fonction OK_Button_Click
    Public Sub OK_Button_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        'Cette fonction se délenche après un clic sur le bouton "OK".
        '
        'This function is launched after clic on "OK" button.
    End Sub

    'Fonction Cancel_Button_Click
    Public Sub Cancel_Button_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        'Cette fonction se délenche après un clic sur le bouton "Annuler".
        '
        '
        '
        'This function is launched after clic on "Annuler" button.
    End Sub

    'Fonction Boîte_de_dialogueBarre_Load
    Public Sub Boîte_de_dialogueBarre_Load(ByVal sender As Object, ByVal e As System.EventArgs)
        If Not Compistart Is Nothing AndAlso Compistart.Visible Then
            trackBar1.Value = Compistart.trackBar1.Value
            numericUpDown1.Value = Compistart.trackBar1.Value
        End If

    End Sub

    'Fonction trackBar1_ValueChanged
    Public Sub trackBar1_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        If Not Compistart Is Nothing AndAlso Compistart.Visible Then
            Compistart.trackBar1.Value = trackBar1.Value
            numericUpDown1.Value = trackBar1.Value
        End If

    End Sub

    'Fonction numericUpDown1_ValueChanged
    Public Sub numericUpDown1_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        If Not Compistart Is Nothing AndAlso Compistart.Visible Then
            Compistart.trackBar1.Value = numericUpDown1.Value
            trackBar1.Value = numericUpDown1.Value
        End If

    End Sub
    
    'Fonction trackBar1_Scroll
    Public Sub trackBar1_Scroll(ByVal sender As Object, ByVal e As System.EventArgs)
    End Sub
End Class
