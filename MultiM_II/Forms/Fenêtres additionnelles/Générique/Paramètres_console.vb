Public Class param_console
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            Compistart.AfficherParamConsole = True
        Else
            Compistart.AfficherParamConsole = False
        End If
    End Sub

    Private Sub param_console_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Compistart.AfficherParamConsole Then
            CheckBox1.Checked = True
        Else
            CheckBox1.Checked = False
        End If
    End Sub
End Class