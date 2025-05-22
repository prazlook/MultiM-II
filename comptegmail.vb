Public Class comptegmail
    
    'Fonction OK_Button_Click
    Public Sub OK_Button_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        variable_vérification_code = Me.textBox1.Text
        If variable_vérification_code = "197566348295" Then
            System.Windows.Forms.MessageBox.Show("Nous vous souhaitons une" & System.Environment.NewLine & "agréable découverte de " & System.Environment.NewLine & "notre logiciel MultiM II.", "Merci de votre inscription!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.None)
            création_de_compte_valide_ou_pas = "V"
            Me.DialogResult = System.Windows.Forms.DialogResult.None : Me.Close()
        Else
            System.Windows.Forms.MessageBox.Show("Le code d'accès que vous avez" & System.Environment.NewLine & "entré n'est pas valide. Si vous" & System.Environment.NewLine & "n'avez pas reçu de code d'accès," & System.Environment.NewLine & "vous pouvez utiliser une autre" & System.Environment.NewLine & "adresse e-mail. Si vous n'avez " & System.Environment.NewLine & "pas d'adresse e-mail,vous pouvez" & System.Environment.NewLine & "créer un compte sans e-mail ou" & System.Environment.NewLine & "naviguer en tant qu'invité.", "Avertissement", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning)
            création_de_compte_valide_ou_pas = "X"
        End If
    End Sub
    
    'Fonction TextBox1_TextChanged
    Public Sub TextBox1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
    End Sub
End Class
