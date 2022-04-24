'This theme has been created by hav0c1995 (www.hackforums.net)
'Credits goes to me for coding it, AeonHack for his themebase and xZ3ROxPROJ3CTx for the idea of the top button
'Give proper credits wherever you use it

Class BlueTheme
    Inherits ThemeContainer151

    Sub New()
        Font = New Font("Tahoma", 10, FontStyle.Bold)
        SetColor("BackColor", 255, 255, 255)
        SetColor("HeaderColor", 109, 132, 180)
        SetColor("UpperColor", 59, 89, 152)
        SetColor("SideColor", 85, 85, 85)
        SetColor("DownColor", 242, 242, 242)
        SetColor("DownColor2", 204, 204, 204)
    End Sub

    Protected Overrides Sub ColorHook()
        C1 = GetColor("BackColor")
        B1 = New SolidBrush(GetColor("HeaderColor"))
        B2 = New SolidBrush(GetColor("DownColor"))
        P1 = New Pen(GetColor("UpperColor"))
        P2 = New Pen(GetColor("SideColor"))
        P3 = New Pen(GetColor("DownColor2"))
    End Sub

    Private C1 As Color
    Private B1, B2 As SolidBrush
    Private P1, P2, P3 As Pen

    Protected Overrides Sub PaintHook()
        G.Clear(C1)
        G.FillRectangle(B1, 0, 0, Width, 30)
        G.FillRectangle(B2, 1, Height - 31, Width - 1, 30)
        G.DrawLine(P1, 0, 0, Width, 0)
        G.DrawLine(P1, 0, 0, 0, 29)
        G.DrawLine(P1, 0, 29, Width, 29)
        G.DrawLine(P1, Width - 1, 0, Width - 1, 29)
        G.DrawLine(P2, 0, 30, 0, Height)
        G.DrawLine(P2, Width - 1, 30, Width - 1, Height)
        G.DrawLine(P2, 0, Height - 1, Width, Height - 1)
        G.DrawLine(P3, 1, Height - 32, Width - 2, Height - 32)
        DrawText(Brushes.White, HorizontalAlignment.Left, 5, 3)
    End Sub
End Class

Class BlueButtonA
    Inherits ThemeControl151

    Sub New()
        Font = New Font("Tahoma", 10, FontStyle.Bold)
        SetColor("BackColor", 99, 123, 173)
        SetColor("BackColor2", 79, 106, 163)
        SetColor("SideColor", 41, 68, 126)
        SetColor("DownColor", 217, 217, 217)
        SetColor("UpperColor", 138, 156, 194)
    End Sub

    Protected Overrides Sub ColorHook()
        C1 = GetColor("BackColor")
        C2 = GetColor("BackColor2")
        P1 = New Pen(GetColor("SideColor"))
        P2 = New Pen(GetColor("DownColor"))
        P3 = New Pen(GetColor("UpperColor"))
    End Sub

    Private C1, C2 As Color
    Private P1, P2, P3 As Pen

    Protected Overrides Sub PaintHook()
        G.Clear(C1)
        If State = MouseState.Down Then
            G.Clear(C2)
            DrawText(Brushes.White, HorizontalAlignment.Center, 0, 0)
        Else
            G.DrawLine(P3, 1, 1, Width, 1)
            DrawText(Brushes.White, HorizontalAlignment.Center, 0, 0)
        End If
        G.DrawLine(P1, 0, 0, Width, 0)
        G.DrawLine(P1, 0, 0, 0, Height - 2)
        G.DrawLine(P1, 0, Height - 2, Width, Height - 2)
        G.DrawLine(P1, Width - 1, 0, Width - 1, Height - 2)
        G.DrawLine(P2, 0, Height - 1, Width, Height - 1)
    End Sub
End Class

Class BlueButtonB
    Inherits ThemeControl151

    Sub New()
        Font = New Font("Tahoma", 10, FontStyle.Bold)
        SetColor("BackColor", 236, 236, 236)
        SetColor("BackColor2", 221, 221, 221)
        SetColor("SideColor", 153, 153, 153)
        SetColor("DownColor", 217, 217, 217)
        SetColor("UpperColor", 255, 255, 255)
        SetColor("TextColor", 51, 51, 51)
    End Sub

    Protected Overrides Sub ColorHook()
        C1 = GetColor("BackColor")
        C2 = GetColor("BackColor2")
        P1 = New Pen(GetColor("SideColor"))
        P2 = New Pen(GetColor("DownColor"))
        P3 = New Pen(GetColor("UpperColor"))
        B1 = New SolidBrush(GetColor("TextColor"))
    End Sub

    Private C1, C2 As Color
    Private P1, P2, P3 As Pen
    Private B1 As SolidBrush

    Protected Overrides Sub PaintHook()
        G.Clear(C1)
        If State = MouseState.Down Then
            G.Clear(C2)
            DrawText(B1, HorizontalAlignment.Center, 0, 0)
        Else
            G.DrawLine(P3, 1, 1, Width, 1)
            DrawText(B1, HorizontalAlignment.Center, 0, 0)
        End If
        G.DrawLine(P1, 0, 0, Width, 0)
        G.DrawLine(P1, 0, 0, 0, Height - 2)
        G.DrawLine(P1, 0, Height - 2, Width, Height - 2)
        G.DrawLine(P1, Width - 1, 0, Width - 1, Height - 2)
        G.DrawLine(P2, 0, Height - 1, Width, Height - 1)
    End Sub
End Class

Class BlueButtonC
    Inherits ThemeControl151

    Sub New()
        Font = New Font("Tahoma", 10, FontStyle.Bold)
        SetColor("BackColor", 98, 122, 173)
        SetColor("BackColor2", 109, 134, 183)
        SetColor("BorderColor", 29, 64, 136)
        SetColor("CornerColor", 109, 132, 180)
    End Sub

    Protected Overrides Sub ColorHook()
        C1 = GetColor("BackColor")
        C2 = GetColor("BackColor2")
        P1 = New Pen(GetColor("BorderColor"))
    End Sub

    Private C1, C2 As Color
    Private P1 As Pen

    Protected Overrides Sub PaintHook()
        G.Clear(C2)
        If State = MouseState.Down Then
            G.Clear(C1)
        End If
        DrawBorders(P1, 0, 0, Width, Height)
        DrawText(Brushes.White, HorizontalAlignment.Center, 0, 0)
    End Sub

End Class

Class BlueTopButton
    Inherits ThemeControl151

    Sub New()
        Size = New Size(14, 7)
        SetColor("BackColor", 98, 122, 173)
        SetColor("BackColor2", 109, 134, 183)
        SetColor("BorderColor", 29, 64, 136)
        SetColor("CornerColor", 109, 132, 180)
    End Sub

    Protected Overrides Sub ColorHook()
        C1 = GetColor("BackColor")
        C2 = GetColor("CornerColor")
        C3 = GetColor("BackColor2")
        P1 = New Pen(GetColor("BorderColor"))
    End Sub

    Private C1, C2, C3 As Color
    Private P1 As Pen

    Protected Overrides Sub PaintHook()
        G.Clear(C1)
        If State = MouseState.Down Then
            G.Clear(C3)
        End If
        DrawBorders(P1, 0, 0, Width, Height)
        DrawCorners(C2)
    End Sub
End Class

Class BlueLabel
    Inherits Label

    Sub New()
        Font = New Font("Tahoma", 8, FontStyle.Regular)
        ForeColor = Color.FromArgb(51, 51, 51)
        BackColor = Color.Transparent
    End Sub
End Class