Imports System.Drawing.Drawing2D

'Theme
Class AdvantiumTheme
    Inherits ThemeContainer151

    Sub New()
        TransparencyKey = Color.Fuchsia
        MoveHeight = 35

        SetColor("BackColor", Color.FromArgb(40, 40, 40))
        SetColor("BorderInner", Color.FromArgb(65, 65, 65))
        SetColor("BorderColor", Color.Black)
        SetColor("TextColor", Color.LawnGreen)
    End Sub


    Dim C1, BC, BA, T1 As Color
    Protected Overrides Sub ColorHook()
        C1 = GetColor("BackColor")
        BC = GetColor("BorderColor")
        BA = GetColor("BorderInner")
        T1 = GetColor("TextColor")
    End Sub


    Protected Overrides Sub PaintHook()
        G.Clear(C1)
        DrawGradient(Color.FromArgb(20, 20, 20), Color.FromArgb(40, 40, 40), New Rectangle(0, 0, Width, 35), 90S)

        Dim T As New HatchBrush(HatchStyle.Percent10, Color.FromArgb(25, 25, 25), Color.FromArgb(35, 35, 35))
        G.FillRectangle(T, New Rectangle(11, 25, Width - 23, Height - 36))

        G.DrawRectangle(New Pen(New SolidBrush(Color.FromArgb(22, 22, 22))), New Rectangle(11, 25, Width - 23, Height - 36))
        G.DrawRectangle(New Pen(New SolidBrush(Color.FromArgb(40, 40, 40))), New Rectangle(12, 26, Width - 25, Height - 38))
        DrawCorners(Color.FromArgb(40, 40, 40), New Rectangle(11, 25, Width - 22, Height - 35))

        DrawBorders(New Pen(New SolidBrush(BA)), 1)
        DrawBorders(New Pen(New SolidBrush(BC)))
        DrawCorners(TransparencyKey)
        DrawText(New SolidBrush(T1), HorizontalAlignment.Left, 15, -3)
    End Sub
End Class

'Button
Class AdvantiumButton
    Inherits ThemeControl151

    Sub New()
        SetColor("BackColor", Color.FromArgb(40, 40, 40))
        SetColor("TextColor", Color.LawnGreen)
    End Sub


    Dim C1, T1 As Color
    Protected Overrides Sub ColorHook()
        C1 = GetColor("BackColor")
        T1 = GetColor("TextColor")
    End Sub


    Protected Overrides Sub PaintHook()
        G.Clear(C1)
        Select Case State
            Case 0 'None
                DrawGradient(Color.FromArgb(50, 50, 50), Color.FromArgb(42, 42, 42), ClientRectangle, 90S)
                Cursor = Cursors.Arrow
            Case 1 'Down
                DrawGradient(Color.FromArgb(50, 50, 50), Color.FromArgb(42, 42, 42), ClientRectangle, 90S)
                Cursor = Cursors.Hand
            Case 2 'Over
                DrawGradient(Color.FromArgb(42, 42, 42), Color.FromArgb(50, 50, 50), ClientRectangle, 90S)
                Cursor = Cursors.Hand
        End Select
        DrawBorders(New Pen(New SolidBrush(Color.FromArgb(59, 59, 59))), 1)
        DrawBorders(New Pen(New SolidBrush(Color.FromArgb(25, 25, 25))))
        DrawCorners(Color.FromArgb(35, 35, 35))
        DrawText(New SolidBrush(T1), HorizontalAlignment.Center, 0, 0)
    End Sub
End Class

'Top Button
Class AdvantiumTopButton
    Inherits ThemeControl151

    Sub New()
        SetColor("BackColor", Color.FromArgb(40, 40, 40))
        SetColor("TextColor", Color.LawnGreen)
        Size = New Size(28, 26)
    End Sub


    Dim C1, T1 As Color
    Protected Overrides Sub ColorHook()
        C1 = GetColor("BackColor")
        T1 = GetColor("TextColor")
    End Sub


    Protected Overrides Sub PaintHook()
        G.Clear(C1)
        Select Case State
            Case 0 'None
                DrawGradient(Color.FromArgb(38, 38, 38), Color.FromArgb(30, 30, 30), ClientRectangle, 90S)
                Cursor = Cursors.Arrow
            Case 1 'Down
                DrawGradient(Color.FromArgb(50, 50, 50), Color.FromArgb(42, 42, 42), ClientRectangle, 90S)
                Cursor = Cursors.Hand
            Case 2 'Over
                DrawGradient(Color.FromArgb(42, 42, 42), Color.FromArgb(50, 50, 50), ClientRectangle, 90S)
                Cursor = Cursors.Hand
        End Select
        DrawBorders(New Pen(New SolidBrush(Color.FromArgb(65, 65, 65))), New Rectangle(1, 0, Width - 2, Height))
        DrawBorders(New Pen(New SolidBrush(Color.FromArgb(22, 22, 22))))
        G.DrawLine(New Pen(New SolidBrush(Color.FromArgb(22, 22, 22))), 2, Height - 1, Width - 3, Height - 1)
        G.DrawLine(New Pen(New SolidBrush(Color.FromArgb(65, 65, 65))), 0, 1, Width - 1, 1)
        G.DrawLine(New Pen(New SolidBrush(Color.Black)), 0, 0, Width, 0)
    End Sub
End Class

'CheckBox
Class AdvantiumCheck
    Inherits ThemeControl151
    Private _CheckedState As Boolean
    Public Property CheckedState() As Boolean
        Get
            Return _CheckedState
        End Get
        Set(ByVal v As Boolean)
            _CheckedState = v
            Invalidate()
        End Set
    End Property
    Sub New()
        Size = New Size(100, 15)
        MinimumSize = New Size(16, 16)
        MaximumSize = New Size(600, 16)
        CheckedState = False
        SetColor("CheckBorderOut", Color.FromArgb(25, 25, 25))
        SetColor("CheckBorderIn", Color.FromArgb(59, 59, 59))
        SetColor("TextColor", Color.LawnGreen)
        SetColor("CheckBack1", Color.FromArgb(132, 192, 240))
        SetColor("CheckBack2", Color.LawnGreen)
        SetColor("CheckFore1", Color.LawnGreen)
        SetColor("CheckFore2", Color.FromArgb(42, 242, 77))
        SetColor("ColorUncheck", Color.FromArgb(35, 35, 35))
        SetColor("BackColor", Color.FromArgb(35, 35, 35))
    End Sub
    Dim C1, C2, C3, C4, C5, C6, P1, P2, B1 As Color
    Protected Overrides Sub ColorHook()
        C1 = GetColor("CheckBack1")
        C2 = GetColor("CheckBack2")
        C3 = GetColor("CheckFore1")
        C4 = GetColor("CheckFore2")
        C5 = GetColor("ColorUncheck")
        C6 = GetColor("BackColor")
        P1 = GetColor("CheckBorderOut")
        P2 = GetColor("CheckBorderIn")
        B1 = GetColor("TextColor")
    End Sub
    Protected Overrides Sub PaintHook()
        G.Clear(C6)
        Select Case CheckedState
            Case True
                DrawGradient(C1, C2, 3, 3, 9, 9, 90S)
                DrawGradient(C3, C4, 4, 4, 7, 7, 90S)
            Case False
                DrawGradient(C5, C5, 0, 0, 15, 15, 90S)
        End Select
        G.DrawRectangle(New Pen(New SolidBrush(P1)), 0, 0, 14, 14)
        G.DrawRectangle(New Pen(New SolidBrush(P2)), 1, 1, 12, 12)
        DrawText(New SolidBrush(B1), 17, 0)
        DrawCorners(C6, New Rectangle(0, 0, 13, 13))
    End Sub
    Sub changeCheck() Handles Me.Click
        Select Case CheckedState
            Case True
                CheckedState = False
            Case False
                CheckedState = True
        End Select
    End Sub
End Class