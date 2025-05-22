Imports System.Collections.Generic

Public Class Accueil

    'Fonction Accueil_Load
    Public Sub Accueil_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub

    Public Sub Accueil_Close(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        centre_acces.Show()
    End Sub

    'Fonction button1_Click
    Public Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
        BootVDTEdit.Show()
        SplashScreen.player.Stop()

    End Sub

    'Fonction button2_Click
    Public Sub button2_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Fenêtre4.Show()
    End Sub

    'Fonction button3_Click
    Public Sub button3_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        ArboEdit.Show()
    End Sub

    'Fonction button4_Click
    Public Sub button4_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Compistart.Show()
    End Sub

    'Fonction button5_Click
    Public Sub button5_Click(ByVal sender As Object, ByVal e As System.EventArgs)
    End Sub

    'Fonction button6_Click
    Public Sub button6_Click(ByVal sender As Object, ByVal e As System.EventArgs)
    End Sub

    'Fonction button9_Click
    Public Sub button9_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        VelerSoftware_VistaMessageBox.Show(Nothing, "Une petite histoire de ce logiciel", "(stoire)", "C'est l'histoire d'un gars, Apollo12 qui s'était amusé à rédiger un cahier des charges pour" & System.Environment.NewLine & "développement logiciel. Et d'un autre gars, prazbid3, qui s'est dit que c'était une très bonne idée " & System.Environment.NewLine & "et qu'il allait mener son projet à bien.Et voilà!", VelerSoftware.VistaMessageBoxLib.VistaMessageBoxIcon.SecurityWarning, "Votre compte n'est pas sécurisé.", False, "Appuyer ici pour fermer.>", False, New VelerSoftware.VistaMessageBoxLib.VistaMessageBoxButton() {New VelerSoftware.VistaMessageBoxLib.VistaMessageBoxButton(VelerSoftware.VistaMessageBoxLib.VistaMessageBoxResult.Close)}, VelerSoftware.VistaMessageBoxLib.VistaMessageBoxIcon.Information, False)
    End Sub

    'Fonction button10_Click
    Public Sub button10_Click(ByVal sender As Object, ByVal e As System.EventArgs)
    End Sub

    'Fonction button12_Click
    Public Sub button12_Click(ByVal sender As Object, ByVal e As System.EventArgs)
    End Sub

    'Fonction button11_Click
    Public Sub button11_Click(ByVal sender As Object, ByVal e As System.EventArgs)
    End Sub

    'Fonction button7_Click
    Public Sub button7_Click(ByVal sender As Object, ByVal e As System.EventArgs)
    End Sub

    Public Sub button14_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        If SplashScreen IsNot Nothing Then
            SplashScreen.Close()
        End If
    End Sub


    'Fonction button8_Click
    Public Sub button8_Click(ByVal sender As Object, ByVal e As System.EventArgs)
    End Sub

    'Fonction button15_Click
    Public Sub button15_Click(ByVal sender As Object, ByVal e As System.EventArgs)
    End Sub

    'Fonction button16_Click
    Public Sub button16_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Accès_forum.Show()
    End Sub

    'Fonction Accueil_Closed
    Public Sub Accueil_Closed(ByVal sender As Object, ByVal e As System.EventArgs)
        centre_acces.Show()
    End Sub

    'Fonction button13_Click
    Public Sub button13_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.None : Me.Close()
        Ecran_de_démarrage1.Show
    End Sub

    'Fonction Button17_Click
    Public Sub Button17_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.button19.Enabled = True
        Me.button19.Visible = True
        Me.button17.Enabled = False
        Me.button17.Visible = False

    End Sub

    'Fonction button19_Click
    Public Sub button19_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.button17.Enabled = True
        Me.button17.Visible = True
        Me.button19.Enabled = False
        Me.button19.Visible = False
    End Sub

    Private Sub button4_Click_1(sender As Object, e As EventArgs) Handles button4.Click

    End Sub
End Class
