' Assurez-vous que ces Imports sont présents en haut de votre fichier .vb
Imports Microsoft.VisualBasic.Strings
Imports System.Text
Imports System.Windows.Forms
Public Class VDTEDITTESTS
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        GenererLigneRougeVDT()
        ExporterFichierVDT()
    End Sub


    ' Constantes ReadOnly (pour éviter l'erreur BC30059)
    Private ReadOnly VDT_FF As String = Chr(12)
    Private ReadOnly VDT_SO As String = Chr(14)
    Private ReadOnly VDT_FG_ROUGE As String = Chr(27) & "A"

    ' CORRECTION FINALE STRICTE : Le code VDT brut est littéralement Chr(35) ('#')
    Private ReadOnly VDT_CARACTERE_LIGNE As String = Chr(35)

    Function GenererLigneRougeVDT() As String

        Dim LigneVDT As String

        ' 1. Effacement de l'écran 
        LigneVDT = VDT_FF

        ' 2. Définition de la couleur (Rouge) 
        LigneVDT = LigneVDT & VDT_FG_ROUGE

        ' 3. Passage en mode Mosaïque (G1). **Ce code est maintenu car c'est le contexte**
        LigneVDT = LigneVDT & VDT_SO

        ' 4. Répétition du caractère '#' 40 fois
        LigneVDT = LigneVDT & StrDup(40, VDT_CARACTERE_LIGNE)

        GenererLigneRougeVDT = LigneVDT

    End Function

    ' --------------------------------------------------------------------------
    ' FONCTION D'EXPORTATION AVEC BOÎTE DE DIALOGUE
    ' --------------------------------------------------------------------------
    Sub ExporterFichierVDT()

        Using saveDialog As New SaveFileDialog()

            saveDialog.Filter = "Fichiers VDT (*.vdt)|*.vdt|Tous les fichiers (*.*)|*.*"
            saveDialog.FileName = "lignerouge_vdt_final.vdt"
            saveDialog.Title = "Enregistrer la page VDT"

            If saveDialog.ShowDialog() = DialogResult.OK Then

                Dim CheminFichier As String = saveDialog.FileName
                Dim ContenuVDT As String = GenererLigneRougeVDT()

                Try
                    ' On utilise l'encodage Code Page 437 pour s'assurer que les octets bruts
                    ' (Chr(12), Chr(14), Chr(35)) sont écrits correctement.
                    My.Computer.FileSystem.WriteAllText(
                    CheminFichier,
                    ContenuVDT,
                    False,
                    System.Text.Encoding.GetEncoding(437)
                )

                    MsgBox("Exportation réussie vers : " & CheminFichier, MsgBoxStyle.Information)

                Catch ex As Exception
                    MsgBox("Erreur d'écriture : " & ex.Message, MsgBoxStyle.Critical)
                End Try

            End If

        End Using

    End Sub

End Class