Class SteamEngineTheme
    Inherits ThemeContainer151


    Protected Overrides Sub ColorHook()

    End Sub

    Protected Overrides Sub PaintHook()
        G.Clear(Color.FromArgb(56, 54, 53))
        DrawGradient(Color.Black, Color.FromArgb(76, 108, 139), ClientRectangle, 35S)
        G.FillRectangle(New SolidBrush(Color.FromArgb(56, 54, 53)), New Rectangle(1, 1, Width - 2, Height - 2))
        DrawGradient(Color.FromArgb(71, 68, 66), Color.FromArgb(57, 55, 54), New Rectangle(1, 1, Width - 2, 35), 90S)
        DrawText(New SolidBrush(Color.FromArgb(195, 193, 191)), HorizontalAlignment.Left, 4, 0)
    End Sub
End Class

Class SteamButton
    Inherits ThemeControl151

    Sub New()
        Font = New Font("Verdana", 7.25)
    End Sub

    Protected Overrides Sub ColorHook()

    End Sub

    Protected Overrides Sub PaintHook()
        G.Clear(Color.FromArgb(56, 54, 53))
        DrawBorders(New Pen(New SolidBrush(Color.FromArgb(77, 75, 72))))
        DrawCorners(Color.FromArgb(56, 54, 53))
        Select Case State
            Case 0
                DrawGradient(Color.FromArgb(92, 89, 86), Color.FromArgb(74, 72, 70), ClientRectangle, 90S)
                DrawBorders(New Pen(New SolidBrush(Color.FromArgb(112, 109, 105))))
                DrawCorners(Color.FromArgb(82, 79, 77))
            Case 1
                DrawGradient(Color.FromArgb(112, 109, 106), Color.FromArgb(94, 92, 90), ClientRectangle, 90S)
                DrawBorders(New Pen(New SolidBrush(Color.FromArgb(141, 148, 130))))
                DrawCorners(Color.FromArgb(82, 79, 77))
            Case 2
                DrawGradient(Color.FromArgb(56, 54, 53), Color.FromArgb(73, 71, 69), ClientRectangle, 90S)
                DrawBorders(New Pen(New SolidBrush(Color.FromArgb(112, 109, 105))))
                DrawCorners(Color.FromArgb(82, 79, 77))
        End Select
        DrawText(New SolidBrush(Color.FromArgb(195, 193, 191)), Text.ToUpper, HorizontalAlignment.Left, 4, 0)
    End Sub
End Class


Class SteamSeparator
    Inherits ThemeControl151

    Protected Overrides Sub ColorHook()

    End Sub

    Protected Overrides Sub PaintHook()
        G.FillRectangle(New SolidBrush(Color.FromArgb(56, 54, 53)), ClientRectangle)
        DrawGradient(Color.FromArgb(107, 104, 101), Color.FromArgb(74, 72, 70), New Rectangle(0, Height / 2, Width, 1), 45S)
    End Sub
End Class