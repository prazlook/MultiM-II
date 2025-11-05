Imports System.Windows.Forms

Public Class Dialog2

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If TextBox1.Text.StartsWith("+") AndAlso TextBox2.Text.StartsWith("0") Then
            Compistart.addLockedNumber(TextBox1.Text & TextBox2.Text)
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()

        ElseIf TextBox1.Text.StartsWith("+") AndAlso Not TextBox2.Text.StartsWith("0") Then
            Compistart.addLockedNumber(TextBox1.Text & TextBox2.Text)
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
        Else
            MsgBox("Vous devez entrer un numéro de téléphone valide !", MsgBoxStyle.Exclamation, "Erreur")

        End If

    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

End Class
