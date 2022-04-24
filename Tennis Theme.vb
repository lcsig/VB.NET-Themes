' Created By SoulZeh
'Credit's Perplexity & xZ3R0xPROJECTz
'Date: 4/09/2001
'Name: TennisTheme

Imports System.Drawing.Drawing2D

Class TennisTheme
    Inherits ThemeContainer151
    Private C1, C2, C3 As Color
    Private B1 As SolidBrush
    Private P1, P2 As Pen
    Sub New()
        MoveHeight = 20
        SetColor("BackColor", Color.White)
        TransparencyKey = Color.Fuchsia
    End Sub
    Protected Overrides Sub ColorHook()
        C1 = GetColor("BackColor")
        C2 = Color.FromArgb(60, 60, 60)
        C3 = Color.FromArgb(50, 50, 50)
        B1 = New SolidBrush(Color.FromArgb(70, 70, 70))
        P1 = New Pen(Color.FromArgb(50, 50, 50))
        P2 = New Pen(Color.FromArgb(20, 20, 20))

    End Sub

    Protected Overrides Sub PaintHook()

        G.Clear(C1)
        DrawGradient(Color.FromArgb(255, 255, 255), Color.FromArgb(40, 40, 40), 10, 20, Width, Height, 90S)
        DrawGradient(C2, C3, 0, 0, Width, Height)
        G.DrawLine(P1, 30, 30, 30, 30)
        G.DrawLine(P1, Width - 1, 0, Width - 1, 25)
        G.DrawLine(P2, 0, 0, 0, Height)
        G.DrawLine(P2, Width - 1, 0, Width - 1, Height)
        G.DrawLine(P2, 0, Height - 1, Width, Height - 1)
        Dim T As New HatchBrush(HatchStyle.Trellis, Color.FromArgb(25, 25, 25), Color.FromArgb(35, 35, 35))
        G.FillRectangle(T, 10, 20, Width - 20, Height - 30)
        'G.FillRectangle(New SolidBrush(Color.FromArgb(25, 25, 25)), 10, 20, Width - 20, Height - 30)
        G.DrawLine(P2, 0, 0, Width, 0)
        DrawText(Brushes.White, HorizontalAlignment.Center, 0, 0)
        Dim i As New HatchBrush(HatchStyle.Shingle, Color.FromArgb(25, 25, 25), Color.FromArgb(35, 35, 35))
        G.FillRectangle(i, 10, 20, Width - 20, Height - 30)
    End Sub
End Class
Class TennisButton

    Inherits ThemeControl151
    Private C1 As Color
    Private P1 As Pen
    Sub New()
        SetColor("BackColor", Color.White)
    End Sub
    Protected Overrides Sub ColorHook()
        C1 = GetColor("BackColor")
        P1 = New Pen(Color.FromArgb(50, 50, 50))
    End Sub

    Protected Overrides Sub PaintHook()
        G.Clear(C1)
        If (State = MouseState.Over) Then
            DrawGradient(Color.FromArgb(30, 30, 30), Color.FromArgb(50, 50, 50), 0, 0, Width, Height)
        ElseIf (State = MouseState.Down) Then
            DrawGradient(Color.FromArgb(118, 118, 118), Color.FromArgb(110, 110, 110), 0, 0, Width, Height)
        Else
            DrawGradient(Color.FromArgb(50, 50, 50), Color.FromArgb(30, 30, 30), 0, 0, Width, Height)
        End If
        DrawBorders(P1, ClientRectangle)
        DrawText(Brushes.White, HorizontalAlignment.Center, 0, 0)

    End Sub
End Class
Class TennisButton2

    Inherits ThemeControl151
    Private C1, C2, C3 As Color
    Private P1 As Pen
    Sub New()
        SetColor("BackColor", Color.White)
    End Sub
    Protected Overrides Sub ColorHook()
        C1 = GetColor("BackColor")
        C2 = Color.FromArgb(50, 50, 50)
        C3 = Color.FromArgb(70, 70, 70)
        P1 = New Pen(Color.Black)
    End Sub

    Protected Overrides Sub PaintHook()
        G.Clear(C1)
        If (State = MouseState.Over) Then
            DrawGradient(C2, C3, 0, 0, Width, Height)
        ElseIf (State = MouseState.Down) Then
            DrawGradient(C3, C2, 0, 0, Width, Height)
        Else
            DrawGradient(C3, C2, 0, 0, Width, Height)
        End If
        DrawBorders(P1, ClientRectangle)
        DrawText(Brushes.White, HorizontalAlignment.Center, 0, 0)
    End Sub
End Class