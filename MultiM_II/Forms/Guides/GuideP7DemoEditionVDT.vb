Public Class GuideP7DemoEditionVDT
    Private Sub GuideP7DemoEditionVDT_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    ' Variables globales correspondant aux placeholders
    Dim Code1 As String = 1
    Dim Code2 As String = 2
    Dim Code3 As String = 3
    Dim Code4 As String = 4
    Dim Code5 As String = 5
    Dim Code6 As String = 6
    Dim Code7 As String = 7
    Dim Code8 As String = 8

    Dim Texte1 As String = 9
    Dim Texte2 As String = 10
    Dim Texte3 As String = 11
    Dim Texte4 As String = 12
    Dim Texte5 As String = 13
    Dim Texte6 As String = 14
    Dim Texte7 As String = 15
    Dim Texte8 As String = 16

    'Variable contenant le fichier VDT à exporter. Ne pas modifier les différents placeholders #CODE1#~, #TEXTE1#~, etc. Utiliser la fonction d'export.
    Dim ExportVDT As String = "
    B] BER~P__R}CE_
    RoP__R}	~_}	~tx}	~tx}	~_}	s	~_}	~_}EH_	R_	_	_""!_	_""!_	_p_	_	_pw	_,
    				
    oP__R?	o_?	_		_	_		_	_	_	_	o	_	o_?QBWB] E~#CODE1#~PB ~#TEXTE1#~	W E~#CODE2#~PB ~#TEXTE2#~
    	
    
    W E~#CODE3#~PB ~#TEXTE3#~			W E~#CODE4#~PB ~#TEXTE4#~ 
    	
    
    W E~#CODE5#~PB ~#TEXTE5#~	W E~#CODE6#~PB ~#TEXTE6#~
    	
    
    W E~#CODE7#~PB ~#TEXTE7#~	W E~#CODE8#~PB ~#TEXTE8#~
    	
    
    _e	}
    W {}
    _ {}
    _ {}
    _ {}
    _ {}
    _ {}
    _ {}
    _ {}
    _ {_ ~e	_ _e	_ {
    
    P {W {
    
    P { ~e
    "

    Sub ExportCode()
        ' Boîte de dialogue pour sauvegarder le fichier
        Using sfd As New SaveFileDialog()
            sfd.Filter = "Fichier VDT|*.vdt"
            sfd.Title = "Exporter le fichier VDT"
            sfd.FileName = "Export.vdt"

            If sfd.ShowDialog() = DialogResult.OK Then
                ' Copie de la variable pour remplacement
                Dim contenu As String = ExportVDT

                ' Remplacement des placeholders par les valeurs des variables
                contenu = contenu.Replace("~#CODE1#~", Code1).Replace("~#TEXTE1#~", Texte1)
                contenu = contenu.Replace("~#CODE2#~", Code2).Replace("~#TEXTE2#~", Texte2)
                contenu = contenu.Replace("~#CODE3#~", Code3).Replace("~#TEXTE3#~", Texte3)
                contenu = contenu.Replace("~#CODE4#~", Code4).Replace("~#TEXTE4#~", Texte4)
                contenu = contenu.Replace("~#CODE5#~", Code5).Replace("~#TEXTE5#~", Texte5)
                contenu = contenu.Replace("~#CODE6#~", Code6).Replace("~#TEXTE6#~", Texte6)
                contenu = contenu.Replace("~#CODE7#~", Code7).Replace("~#TEXTE7#~", Texte7)
                contenu = contenu.Replace("~#CODE8#~", Code8).Replace("~#TEXTE8#~", Texte8)

                ' Écriture dans le fichier
                File.WriteAllText(sfd.FileName, contenu)

                MessageBox.Show("Fichier exporté avec succès : " & sfd.FileName)
            End If
        End Using
    End Sub


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged

    End Sub

    Private Sub RichTextBox2_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox2.TextChanged

    End Sub

    Private Sub RichTextBox3_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox3.TextChanged

    End Sub

    Private Sub RichTextBox4_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox4.TextChanged

    End Sub

    Private Sub RichTextBox5_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox5.TextChanged

    End Sub

    Private Sub RichTextBox6_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox6.TextChanged

    End Sub

    Private Sub RichTextBox7_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox7.TextChanged

    End Sub

    Private Sub RichTextBox8_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox8.TextChanged

    End Sub

    Private Sub RichTextBox9_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox9.TextChanged

    End Sub

    Private Sub RichTextBox10_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox10.TextChanged

    End Sub

    Private Sub RichTextBox11_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox11.TextChanged

    End Sub

    Private Sub RichTextBox12_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox12.TextChanged

    End Sub

    Private Sub RichTextBox13_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox13.TextChanged

    End Sub

    Private Sub RichTextBox14_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox14.TextChanged

    End Sub

    Private Sub RichTextBox15_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox15.TextChanged

    End Sub

    Private Sub RichTextBox16_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox16.TextChanged

    End Sub

    Private Sub Interrupteur1_Click(sender As Object, e As EventArgs) Handles Interrupteur1.Click

        If Interrupteur1.Checked Then
            Label4.Text = "Page *.vdt"
        Else
            Label4.Text = "Écran *.scm"
        End If

    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        ExportCode()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        GuideP8IntroVELite.Show()
        Me.Close()
    End Sub
End Class