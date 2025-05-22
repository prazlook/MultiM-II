Public Class Fenêtre4
    
    'Fonction Form_Load
    Public Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs)
        'Cette fonction se déclenche à l'ouverture de la fenêtre.
        '
        'This function is launched during opening.
    End Sub

    'Fonction button1_Click
    Public Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Boîte_de_dialogue1.Show()
    End Sub
    
    'Fonction radioButton1_CheckedChanged
    Public Sub radioButton1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Format_image_vdtpics = "JPG"
    End Sub
    
    'Fonction Label5_Click
    Public Sub Label5_Click(ByVal sender As Object, ByVal e As System.EventArgs)
    End Sub
    
    'Fonction Button2_Click
    Public Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs)
    End Sub
    
    'Fonction button5_Click
    Public Sub button5_Click(ByVal sender As Object, ByVal e As System.EventArgs)
    End Sub
    
    'Fonction RadioButton2_CheckedChanged
    Public Sub RadioButton2_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
    End Sub
End Class
