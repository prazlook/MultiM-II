Public Class VelerSoftware_VistaMessageBox

	Shared Function Show(ByVal Owner As System.Windows.Forms.IWin32Window, ByVal WindowTitle As String, ByVal MainInstruction As String, ByVal Content As String, ByVal FooterIcon As VelerSoftware.VistaMessageBoxLib.VistaMessageBoxIcon, ByVal FooterText As String, ByVal ExpandFooterArea As Boolean, ByVal ExpandedInformation As String, ByVal ExpandedByDefault As Boolean, ByVal Buttons() As VelerSoftware.VistaMessageBoxLib.VistaMessageBoxButton, ByVal MainIcon As VelerSoftware.VistaMessageBoxLib.VistaMessageBoxIcon, ByVal LockSystem As Boolean) As String
		Dim resultat As VelerSoftware.VistaMessageBoxLib.VistaMessageBoxResult
		Dim vd As New VelerSoftware.VistaMessageBoxLib.VistaMessageBox()
		With vd
			.Owner = Owner
			.WindowTitle = WindowTitle
			.MainInstruction = MainInstruction
			.Content = Content
			.FooterIcon = FooterIcon
			.FooterText = FooterText
			.ExpandedInformation = ExpandedInformation
			.ExpandFooterArea = ExpandFooterArea
			.ExpandedByDefault = ExpandedByDefault
			.MainIcon = MainIcon
			.Buttons = Buttons
			.LockSystem = LockSystem
		End With
		resultat = vd.Show()
		Return resultat.ToString()
	End Function

End Class
