Public Class Classe1
    
    'Fonction Afficher_Message
    Public Shared Function Afficher_Message(ByVal Message As Object, ByVal Titre As Object) As Object
        'Cette fonction a été créée manuellement. En ouvrant les
        'paramètres de celle-ci, vous découvrirez les arguments
        '(paramètres) de la fonction et pourrez les modifier.
        'Ces paramètres sont utilisables comme de simples variables
        'à l'intérieur même de la fonction en question.
        Résultat = System.Windows.Forms.MessageBox.Show("" & Message & "", "" & Titre & "", System.Windows.Forms.MessageBoxButtons.AbortRetryIgnore, System.Windows.Forms.MessageBoxIcon.None).ToString
        'L'action ci-dessous renvoie une valeur à l'action qui
        'a demandé à ce que cette fonction soit exécuté. C'est
        'le "résultat de la fonction".
        Return "Vous avez cliqué sur le bouton " & Microsoft.VisualBasic.ChrW(34) & "" & Résultat & "" & Microsoft.VisualBasic.ChrW(34) & ""
    End Function
End Class
