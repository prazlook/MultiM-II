Imports System.Collections.Generic

Public Class Database

    ' Événement quand un noeud du TreeView est sélectionné
    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterSelect

        ' ---- Afficher le chemin dans la StatusStrip ----
        Dim path As New List(Of String)
        Dim n As TreeNode = e.Node

        While n IsNot Nothing
            path.Insert(0, n.Text)
            n = n.Parent
        End While

        ToolStripStatusLabel1.Text = String.Join(" > ", path)


        ' ---- Charger l'UserControl correspondant ----
        Dim nodeName As String = e.Node.Name
        Dim ucName As String = nodeName & "UserControl"

        ' Supprimer l'ancien UC
        For i As Integer = Me.Controls.Count - 1 To 0 Step -1
            If TypeOf Me.Controls(i) Is UserControl Then
                Me.Controls.RemoveAt(i)
            End If
        Next

        ' Trouver le type du UserControl
        Dim ucType As Type = Type.GetType(Me.GetType().Namespace & "." & ucName)

        If ucType Is Nothing Then
            MessageBox.Show("UserControl introuvable : " & ucName, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' Instancier l'UC
        Dim uc As UserControl = CType(Activator.CreateInstance(ucType), UserControl)

        ' Positionner en (2,2)
        uc.Location = New Point(2, 2)
        uc.Anchor = AnchorStyles.Top Or AnchorStyles.Left

        ' L'ajouter au Form
        Me.Controls.Add(uc)
        uc.BringToFront()

    End Sub

    Private Sub Database_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
