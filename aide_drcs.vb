Public Class Boîte_de_dialogue1
    
    'Fonction OK_Button_Click
    Public Sub OK_Button_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.None : Me.Close()
    End Sub
End Class
