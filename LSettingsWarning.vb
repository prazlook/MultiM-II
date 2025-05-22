Public Class LSettingsWarning
    
    'Fonction Form_Load
    Public Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs)
        'Cette fonction se déclenche à l'ouverture de la fenêtre.
        '
        'This function is launched during opening.
    End Sub
    
    'Fonction button1_Click
    Public Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        LECAMSettings.Show()
        Me.DialogResult = System.Windows.Forms.DialogResult.None : Me.Close()
    End Sub
    
    'Fonction button2_Click
    Public Sub button2_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.None : Me.Close()
    End Sub
End Class
