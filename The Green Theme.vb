'Green Theme by hav0c1995
'Created by hav0c1995 (HackForums.net)
'Give proper credits if you use it anywhere
'Credits goes to me and AeonHack for his theme base

Class GreenTheme
    Inherits ThemeContainer

    Sub New()
        Font = New Font("Verdana", 8, FontStyle.Bold)
        SetColor("BackColor", 33, 33, 33)
        SetColor("LowerLineColor", 24, 24, 24)
        SetColor("LowerLineColor2", 55, 55, 55)
        SetColor("UpperLineColor", 120, 182, 52)
        SetColor("BrushColor", 71, 132, 1)
        SetColor("BrushColor2", 82, 156, 1)
    End Sub

    Protected Overrides Sub ColorHook()
        C1 = GetColor("BackColor")
        C2 = GetColor("BrushColor")
        C3 = GetColor("BrushColor2")
        P1 = New Pen(GetColor("LowerLineColor"))
        P2 = New Pen(GetColor("UpperLineColor"))
        P3 = New Pen(GetColor("LowerLineColor2"))
    End Sub

    Private C1, C2, C3 As Color
    Private P1, P2, P3 As Pen

    Protected Overrides Sub PaintHook()
        G.Clear(C1)
        DrawGradient(C2, C3, 0, 0, Width, 30)
        G.DrawLine(P3, 0, 30, Width, 30)
        G.DrawLine(P1, 0, 31, Width, 31)
        G.DrawLine(P2, 0, 29, Width, 29)
        G.DrawLine(P2, 0, 0, Width, 0)
        G.DrawLine(P2, 0, 0, 0, 29)
        G.DrawLine(P2, Width - 1, 0, Width - 1, 29)
        G.DrawLine(P3, Width - 1, 30, Width - 1, Height)
        G.DrawLine(P3, 0, 30, 0, Height)
        G.DrawLine(P1, 1, 31, 1, Height)
        G.DrawLine(P1, Width - 2, 31, Width - 2, Height)
        G.DrawLine(P3, 0, Height - 1, Width, Height - 1)
        G.DrawLine(P1, 1, Height - 2, Width - 2, Height - 2)
        DrawText(Brushes.Black, HorizontalAlignment.Left, 5, 3)
    End Sub
End Class

Class GreenLabel
    Inherits Label

    Sub New()
        Font = New Font("Verdana", 8, FontStyle.Regular)
        BackColor = Color.FromArgb(33, 33, 33)
        ForeColor = Color.White
    End Sub
End Class

Class GreenButton
    Inherits ThemeControl

    Private Blend As ColorBlend

    Sub New()
        Blend = New ColorBlend
        Blend.Positions = New Single() {0, 0.5, 1}
        SetColor("Blend1", 71, 132, 1)
        SetColor("Blend2", 71, 132, 1)
        SetColor("Blend3", 71, 132, 1)
        SetColor("Shine", 0, 100, 0)
        SetColor("Glow", Color.Green)
        SetColor("Text", Color.White)
        SetColor("Light", 71, 132, 1)
        SetColor("Border", 120, 182, 85)
    End Sub

    Protected Overrides Sub ColorHook()
        B1 = New SolidBrush(GetColor("Shine"))
        B2 = New SolidBrush(GetColor("Glow"))
        B3 = New SolidBrush(GetColor("Text"))
        P1 = New Pen(GetColor("Light"))
        P2 = New Pen(GetColor("Border"))
        Blend.Colors = New Color() {GetColor("Blend1"), GetColor("Blend2"), GetColor("Blend3")}
    End Sub

    Private B1, B2, B3 As SolidBrush
    Private P1, P2 As Pen

    Protected Overrides Sub PaintHook()
        G.Clear(Color.FromArgb(71, 132, 1))
        DrawGradient(Blend, ClientRectangle, 90)
        G.FillRectangle(B2, ClientRectangle)
        DrawText(B3, HorizontalAlignment.Center, 0, 0)
        DrawBorders(P1, 1)
        DrawBorders(P2)
        If State = MouseState.Down Then
            G.FillRectangle(B1, ClientRectangle)
            DrawText(B3, HorizontalAlignment.Center, 0, 0)
            DrawBorders(P2, 1)
            DrawBorders(P2)
        End If
    End Sub
End Class