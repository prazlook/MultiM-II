Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms ' <-- Ajoute ceci pour WinForms.Timer

Public Class Interrupteur
    Inherits Control

    Public Enum FormeInterrupteur
        Rond
        Carre
    End Enum

    Private _checked As Boolean = False
    Private _forme As FormeInterrupteur = FormeInterrupteur.Rond

    Private animationTimer As System.Windows.Forms.Timer
    Private knobPos As Single ' 0 = OFF, 1 = ON
    Private animationTarget As Single
    Private Const ANIMATION_STEP As Single = 0.15F

    <Category("Comportement")>
    Public Property Checked As Boolean
        Get
            Return _checked
        End Get
        Set(value As Boolean)
            If _checked <> value Then
                _checked = value
                animationTarget = If(_checked, 1.0F, 0.0F)
                animationTimer.Start()
                RaiseEvent CheckedChanged(Me, EventArgs.Empty)
            End If
        End Set
    End Property

    <Category("Apparence")>
    Public Property Forme As FormeInterrupteur
        Get
            Return _forme
        End Get
        Set(value As FormeInterrupteur)
            If _forme <> value Then
                _forme = value
                Invalidate()
            End If
        End Set
    End Property

    <Category("Comportement")>
    Public Event CheckedChanged As EventHandler

    Public Sub New()
        Me.DoubleBuffered = True
        Me.Size = New Size(50, 25)
        Me.Cursor = Cursors.Hand
        animationTimer = New System.Windows.Forms.Timer()
        animationTimer.Interval = 15
        AddHandler animationTimer.Tick, AddressOf AnimationStep
        knobPos = If(_checked, 1.0F, 0.0F)
        animationTarget = knobPos
    End Sub

    Private Sub AnimationStep(sender As Object, e As EventArgs)
        If Math.Abs(knobPos - animationTarget) < ANIMATION_STEP Then
            knobPos = animationTarget
            animationTimer.Stop()
        ElseIf knobPos < animationTarget Then
            knobPos += ANIMATION_STEP
            If knobPos > 1.0F Then knobPos = 1.0F
        ElseIf knobPos > animationTarget Then
            knobPos -= ANIMATION_STEP
            If knobPos < 0.0F Then knobPos = 0.0F
        End If
        Invalidate()
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)
        Dim g = e.Graphics
        g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias

        ' Couleurs rétro fixes
        Dim fond As Color = Color.FromArgb(212, 208, 200) ' gris Win 3.1/XP
        Dim bord As Color = Color.FromArgb(128, 128, 128)
        Dim shadow As Color = Color.FromArgb(160, 160, 160)
        Dim light As Color = Color.White
        Dim bouton As Color = Color.FromArgb(192, 192, 192)

        Dim knobX As Integer = CInt(2 + (Width - Height) * knobPos)
        Dim knobSize As Integer = Height - 4

        ' Fond rétro avec bordure 3D
        Using b As New SolidBrush(fond)
            If _forme = FormeInterrupteur.Rond Then
                g.FillRectangle(b, Height \ 2, 4, Width - Height, Height - 8)
                g.FillEllipse(b, 2, 2, Height - 4, Height - 4)
                g.FillEllipse(b, Width - Height + 2, 2, Height - 4, Height - 4)
            Else
                g.FillRectangle(b, 2, 2, Width - 4, Height - 4)
            End If
        End Using

        ' Bordure 3D rétro
        If _forme = FormeInterrupteur.Rond Then
            Using p As New Pen(bord, 1)
                g.DrawEllipse(p, 2, 2, Height - 4, Height - 4)
                g.DrawEllipse(p, Width - Height + 2, 2, Height - 4, Height - 4)
                g.DrawRectangle(p, Height \ 2, 4, Width - Height, Height - 8)
            End Using
            Using p As New Pen(light, 1)
                g.DrawLine(p, Height \ 2, 4, Width - Height \ 2, 4)
                g.DrawArc(p, 2, 2, Height - 4, Height - 4, 120, 120)
                g.DrawArc(p, Width - Height + 2, 2, Height - 4, Height - 4, 300, 120)
            End Using
            Using p As New Pen(shadow, 1)
                g.DrawLine(p, Height \ 2, Height - 4, Width - Height \ 2, Height - 4)
                g.DrawArc(p, 2, 2, Height - 4, Height - 4, 240, 120)
                g.DrawArc(p, Width - Height + 2, 2, Height - 4, Height - 4, 60, 120)
            End Using
        Else
            Using p As New Pen(bord, 1)
                g.DrawRectangle(p, 2, 2, Width - 4, Height - 4)
            End Using
            Using p As New Pen(light, 1)
                g.DrawLine(p, 2, 2, Width - 2, 2)
                g.DrawLine(p, 2, 2, 2, Height - 2)
            End Using
            Using p As New Pen(shadow, 1)
                g.DrawLine(p, 2, Height - 2, Width - 2, Height - 2)
                g.DrawLine(p, Width - 2, 2, Width - 2, Height - 2)
            End Using
        End If

        ' Curseur rétro (toujours même couleur)
        If _forme = FormeInterrupteur.Rond Then
            Using s As New SolidBrush(Color.FromArgb(80, 0, 0, 0))
                g.FillEllipse(s, knobX + 2, 4 + knobSize \ 2, knobSize, knobSize \ 2)
            End Using
            Using b As New SolidBrush(bouton)
                g.FillEllipse(b, knobX, 2, knobSize, knobSize)
            End Using
            Using p As New Pen(bord, 1)
                g.DrawEllipse(p, knobX, 2, knobSize, knobSize)
            End Using
            Using p As New Pen(light, 1)
                g.DrawArc(p, knobX + 2, 4, knobSize - 4, knobSize - 4, 120, 100)
            End Using
        Else
            Using s As New SolidBrush(Color.FromArgb(80, 0, 0, 0))
                g.FillRectangle(s, knobX + 2, 4 + knobSize \ 2, knobSize, knobSize \ 2)
            End Using
            Using b As New SolidBrush(bouton)
                g.FillRectangle(b, knobX, 2, knobSize, knobSize)
            End Using
            Using p As New Pen(bord, 1)
                g.DrawRectangle(p, knobX, 2, knobSize, knobSize)
            End Using
            Using p As New Pen(light, 1)
                g.DrawLine(p, knobX + 1, 3, knobX + knobSize - 2, 3)
                g.DrawLine(p, knobX + 1, 3, knobX + 1, knobX + knobSize - 2)
            End Using
        End If
    End Sub

    Protected Overrides Sub OnClick(e As EventArgs)
        Checked = Not Checked
        MyBase.OnClick(e)
    End Sub
End Class