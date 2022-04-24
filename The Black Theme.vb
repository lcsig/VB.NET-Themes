'This theme has been created by hav0c1995 (www.hackforums.net)
'Credits goes to me for coding it, Aeonhack for his themebase and xZ3ROxPROJ3CTx for the top-button
'Give proper credits wherever you use it

Class v2BlackTheme
    Inherits ThemeContainer151

    Sub New()
        Font = New Font("Verdana", 8, FontStyle.Regular)
        SetColor("BackColor", 71, 71, 71)
        SetColor("BorderColor", 44, 44, 44)
        SetColor("PanelBorder", 26, 26, 26)
        SetColor("PanelBackColor", 50, 51, 51)
        SetColor("SecondBorderColor", 90, 90, 90)
        SetColor("TextColor", 255, 255, 255)
    End Sub

    Protected Overrides Sub ColorHook()
        C1 = GetColor("BackColor")
        P1 = New Pen(GetColor("BorderColor"))
        P2 = New Pen(GetColor("PanelBorder"))
        P3 = New Pen(GetColor("SecondBorderColor"))
        SB1 = New SolidBrush(GetColor("PanelBackColor"))
        SB2 = New SolidBrush(GetColor("TextColor"))
    End Sub

    Private C1 As Color
    Private P1, P2, P3 As Pen
    Private SB1, SB2 As SolidBrush

    Protected Overrides Sub PaintHook()
        G.Clear(C1)
        G.FillRectangle(SB1, 10, 30, Width - 21, Height - 41)
        G.DrawRectangle(P2, 10, 30, Width - 21, Height - 41)
        DrawText(SB2, HorizontalAlignment.Left, 8, 5)
        DrawBorders(P1)
        DrawBorders(P3, 1, 1, Width - 2, Height - 2)
    End Sub
End Class

Class v2BlackButton
    Inherits ThemeControl151

    Sub New()
        Blend.Positions = New Single() {0, 1}
        Blend2.Positions = New Single() {0, 1}
        SetColor("Blend1", 85, 83, 83)
        SetColor("Blend2", 62, 64, 62)
        SetColor("Border1", 120, 120, 120)
        SetColor("Border2", 0, 0, 0)
        SetColor("ButtonText", 240, 240, 240)
    End Sub

    Protected Overrides Sub ColorHook()
        P1 = New Pen(GetColor("Border1"))
        P2 = New Pen(GetColor("Border2"))
        SB1 = New SolidBrush(GetColor("ButtonText"))
        Blend.Colors = New Color() {GetColor("Blend1"), GetColor("Blend2")}
        Blend2.Colors = New Color() {GetColor("Blend2"), GetColor("Blend1")}
    End Sub

    Private Blend, Blend2 As New ColorBlend
    Private P1, P2 As Pen
    Private SB1 As SolidBrush

    Protected Overrides Sub PaintHook()
        DrawGradient(Blend, 2, 2, Width - 4, Height - 4)
        If State = MouseState.Down Then
            DrawGradient(Blend2, 2, 2, Width - 4, Height - 4)
        End If
        DrawText(SB1, HorizontalAlignment.Center, 0, 0)
        DrawBorders(P2)
        DrawBorders(P1, 1, 1, Width - 2, Height - 2)
    End Sub
End Class

Class v2BlackTopButton
    Inherits ThemeControl151

    Sub New()
        SetColor("BackColor", 71, 71, 71)
        SetColor("BackColor2", 50, 51, 51)
        SetColor("BorderColor", 150, 150, 150)
        Size = New Size(14, 7)
    End Sub

    Protected Overrides Sub ColorHook()
        C1 = GetColor("BackColor")
        C2 = GetColor("BackColor2")
        P1 = New Pen(GetColor("BorderColor"))
    End Sub

    Private C1, C2 As Color
    Private P1 As Pen

    Protected Overrides Sub PaintHook()
        DrawGradient(C1, C2, 0, 0, Width, Height)
        If State = MouseState.Down Then
            DrawGradient(C2, C1, 0, 0, Width, Height)
        End If
        DrawBorders(P1)
        DrawCorners(C1)
    End Sub
End Class

Class v2BlackLabel
    Inherits Label

    Sub New()
        Font = New Font("Verdana", 8, FontStyle.Regular)
        ForeColor = Color.FromArgb(220, 220, 220)
        BackColor = Color.Transparent
    End Sub
End Class