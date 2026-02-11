Imports System.Reflection.Emit

Public Class VDTPics

    'Fonction Form_Load
    Public Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Cette fonction se déclenche à l'ouverture de la fenêtre.
        '
        'This function is launched during opening.
    End Sub

    'Fonction button1_Click
    Public Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
        Boîte_de_dialogue1.Show()
    End Sub

    'Fonction radioButton1_CheckedChanged
    Public Sub radioButton1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles radioButton1.CheckedChanged
        Format_image_vdtpics = "JPG"
    End Sub

    'Fonction Label5_Click
    Public Sub Label5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles label5.Click
    End Sub

    'Fonction Button2_Click
    Public Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button2.Click
    End Sub

    'Fonction button5_Click
    Public Sub button5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button5.Click
    End Sub

    'Fonction RadioButton2_CheckedChanged
    Public Sub RadioButton2_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles radioButton2.CheckedChanged
    End Sub

    Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles pictureBox1.MouseMove
        ' Met à jour la valeur des progressbars en fonction de la position de la souris
        KryptonProgressBar1.Value = Math.Min(Math.Max(e.X, KryptonProgressBar1.Minimum), KryptonProgressBar1.Maximum)
        KryptonProgressBar2.Value = Math.Min(Math.Max(e.Y, KryptonProgressBar2.Minimum), KryptonProgressBar2.Maximum)

        ' Mise à jour des labels
        LabelX.Text = "Position horizontale : " & e.X.ToString()
        LabelY.Text = "Position verticale : " & e.Y.ToString()
    End Sub


End Class
