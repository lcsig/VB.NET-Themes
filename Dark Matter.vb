Imports System.Drawing.Drawing2D
Imports System.ComponentModel

Class DarkMatterTheme
    Inherits ThemeContainer152

    Sub New()
        TransparencyKey = Color.Cyan
    End Sub

    Dim tGlow, tColor As Color
    Protected Overrides Sub ColorHook()

    End Sub

    Dim T As New HatchBrush(HatchStyle.LightUpwardDiagonal, Color.Black, Color.FromArgb(39, 39, 41))
    Protected Overrides Sub PaintHook()
        G.SmoothingMode = SmoothingMode.HighQuality

        Select Case _ThemeColor
            Case 0 'GammaRay
                tGlow = Color.FromArgb(35, Color.LawnGreen)
                tColor = Color.FromArgb(255, Color.LawnGreen)
            Case 1 'RedShift
                tGlow = Color.FromArgb(35, Color.Red)
                tColor = Color.FromArgb(255, Color.Red)
            Case 2 'SubSpace
                tGlow = Color.FromArgb(35, Color.DodgerBlue)
                tColor = Color.FromArgb(255, Color.DodgerBlue)
            Case 3 'SolarFlare
                tGlow = Color.FromArgb(35, Color.Gold)
                tColor = Color.FromArgb(255, Color.Gold)
        End Select

        G.Clear(Color.FromArgb(39, 41, 41))
        DrawGradient(Color.FromArgb(109, 109, 111), Color.FromArgb(26, 26, 29), ClientRectangle, 45S) 'Border Out
        DrawGradient(Color.FromArgb(58, 58, 60), Color.FromArgb(14, 14, 14), New Rectangle(2, 2, Width - 4, Height - 4), 45S)

        DrawBorders(New Pen(New SolidBrush(Color.Black)))

        DrawText(New SolidBrush(tGlow), HorizontalAlignment.Left, 4, 0)
        DrawText(New SolidBrush(tGlow), HorizontalAlignment.Left, 4, 1)
        DrawText(New SolidBrush(tGlow), HorizontalAlignment.Left, 4, -1)
        DrawText(New SolidBrush(tGlow), HorizontalAlignment.Left, 6, 0)
        DrawText(New SolidBrush(tGlow), HorizontalAlignment.Left, 6, 1)
        DrawText(New SolidBrush(tGlow), HorizontalAlignment.Left, 6, -1)
        DrawText(New SolidBrush(tGlow), HorizontalAlignment.Left, 5, 1)
        DrawText(New SolidBrush(tGlow), HorizontalAlignment.Left, 5, -1)

        DrawText(New SolidBrush(tColor), HorizontalAlignment.Left, 5, 0)
        DrawCorners(Color.Cyan)
    End Sub
    Enum ColorTheme
        GammaRay = 0
        RedShift = 1
        Subspace = 2
        SolarFlare = 3
    End Enum
    Private _ThemeColor As ColorTheme
    Public Property ThemeStyle() As ColorTheme
        Get
            Return _ThemeColor
        End Get
        Set(ByVal v As ColorTheme)
            _ThemeColor = v
            Invalidate()
        End Set
    End Property
End Class
Class DarkMatterAltTheme
    Inherits ThemeContainer152

    Sub New()
        TransparencyKey = Color.Cyan
    End Sub

    Dim tGlow, tColor As Color
    Protected Overrides Sub ColorHook()

    End Sub

    Dim T As New HatchBrush(HatchStyle.LightUpwardDiagonal, Color.Black, Color.FromArgb(39, 39, 41))
    Protected Overrides Sub PaintHook()
        G.SmoothingMode = SmoothingMode.HighQuality

        Select Case _ThemeColor
            Case 0 'GammaRay
                tGlow = Color.FromArgb(35, Color.LawnGreen)
                tColor = Color.FromArgb(255, Color.LawnGreen)
            Case 1 'RedShift
                tGlow = Color.FromArgb(35, Color.Red)
                tColor = Color.FromArgb(255, Color.Red)
            Case 2 'SubSpace
                tGlow = Color.FromArgb(35, Color.DodgerBlue)
                tColor = Color.FromArgb(255, Color.DodgerBlue)
            Case 3 'SolarFlare
                tGlow = Color.FromArgb(35, Color.Gold)
                tColor = Color.FromArgb(255, Color.Gold)
        End Select

        G.Clear(Color.FromArgb(39, 41, 41))
        DrawGradient(Color.FromArgb(100, 100, 100), Color.FromArgb(31, 31, 31), ClientRectangle, 90S)
        DrawGradient(Color.FromArgb(53, 53, 54), Color.FromArgb(54, 54, 56), New Rectangle(2, 2, Width - 6, Height - 4), 90S)
        DrawGradient(Color.FromArgb(31, 31, 31), Color.FromArgb(42, 42, 42), New Rectangle(2, 10, Width - 6, Height - 19), 90S)
        G.FillRectangle(New SolidBrush(Color.FromArgb(15, 15, 17)), New Rectangle(3, 11, Width - 7, Height - 20))
        G.DrawLine(Pens.Black, 3, 11, 3, Height - 10)
        G.DrawLine(Pens.Black, Width - 4, 11, Width - 4, Height - 10)

        'DrawGradient(Color.FromArgb(109, 109, 111), Color.FromArgb(26, 26, 29), ClientRectangle, 45S) 'Border Out
        'DrawGradient(Color.FromArgb(58, 58, 60), Color.FromArgb(14, 14, 14), New Rectangle(2, 2, Width - 4, Height - 4), 45S)

        DrawBorders(New Pen(New SolidBrush(Color.Black)))

        DrawText(New SolidBrush(tGlow), HorizontalAlignment.Left, 4, 0)
        DrawText(New SolidBrush(tGlow), HorizontalAlignment.Left, 4, 1)
        DrawText(New SolidBrush(tGlow), HorizontalAlignment.Left, 4, -1)
        DrawText(New SolidBrush(tGlow), HorizontalAlignment.Left, 6, 0)
        DrawText(New SolidBrush(tGlow), HorizontalAlignment.Left, 6, 1)
        DrawText(New SolidBrush(tGlow), HorizontalAlignment.Left, 6, -1)
        DrawText(New SolidBrush(tGlow), HorizontalAlignment.Left, 5, 1)
        DrawText(New SolidBrush(tGlow), HorizontalAlignment.Left, 5, -1)

        DrawText(New SolidBrush(tColor), HorizontalAlignment.Left, 5, 0)
        DrawCorners(Color.Cyan)
    End Sub
    Enum ColorTheme
        GammaRay = 0
        RedShift = 1
        Subspace = 2
        SolarFlare = 3
    End Enum
    Private _ThemeColor As ColorTheme
    Public Property ThemeStyle() As ColorTheme
        Get
            Return _ThemeColor
        End Get
        Set(ByVal v As ColorTheme)
            _ThemeColor = v
            Invalidate()
        End Set
    End Property
End Class
Class DarkMatterButton
    Inherits ThemeControl152

    Sub New()
        BackColor = Color.FromArgb(59, 59, 61)
    End Sub

    Dim tGlow, tColor, tTheme, tGradA, tGradB, tBordA, tBordB, tBorder As Color
    Dim tAlign As HorizontalAlignment
    Dim tOffX, tOffY As Integer
    Protected Overrides Sub ColorHook()
        tAlign = HorizontalAlignment.Center
        tOffX = -1
        tOffY = -1
        tGlow = Color.FromArgb(35, tTheme)
        tColor = Color.FromArgb(255, tTheme)
    End Sub

    Protected Overrides Sub PaintHook()
        G.Clear(Color.FromArgb(47, 47, 47))

        Select Case _ThemeColor
            Case 0 'GammaRay
                tTheme = Color.LawnGreen
                tGradA = Color.FromArgb(111, 208, 28) 'First Gradient Color
                tGradB = Color.FromArgb(92, 192, 5) 'Second Gradient Color
                tBordA = Color.FromArgb(213, 248, 188) 'First Border Gradient Color
                tBordB = Color.FromArgb(138, 207, 87) 'Second Border Gradient Color
                tBorder = Color.FromArgb(72, 152, 0) 'Outer Border Color
            Case 1 'RedShift
                tTheme = Color.Red
                tGradA = Color.FromArgb(236, 20, 16) 'First Gradient Color
                tGradB = Color.FromArgb(223, 5, 1) 'Second Gradient Color
                tBordA = Color.FromArgb(255, 198, 198) 'First Border Gradient Color
                tBordB = Color.FromArgb(232, 90, 89) 'Second Border Gradient Color
                tBorder = Color.FromArgb(184, 3, 1) 'Outer Border Color
            Case 2 'SubSpace
                tTheme = Color.DodgerBlue
                tGradA = Color.FromArgb(41, 149, 255) 'First Gradient Color
                tGradB = Color.FromArgb(33, 139, 255) 'Second Gradient Color
                tBordA = Color.FromArgb(218, 244, 255) 'First Border Gradient Color
                tBordB = Color.FromArgb(138, 191, 255) 'Second Border Gradient Color
                tBorder = Color.FromArgb(6, 84, 191) 'Outer Border Color
            Case 3 'SolarFlare
                tTheme = Color.Gold
                tGradA = Color.FromArgb(255, 194, 69) 'First Gradient Color
                tGradB = Color.FromArgb(255, 180, 40) 'Second Gradient Color
                tBordA = Color.FromArgb(254, 248, 214) 'First Border Gradient Color
                tBordB = Color.FromArgb(255, 214, 144) 'Second Border Gradient Color
                tBorder = Color.FromArgb(211, 148, 27) 'Outer Border Color
        End Select

        Select Case State
            Case 0
                tGlow = Color.FromArgb(30, tTheme)
                tColor = Color.FromArgb(255, tTheme)

                DrawGradient(Color.FromArgb(109, 109, 111), Color.FromArgb(26, 26, 29), ClientRectangle, 45S)
                DrawGradient(Color.FromArgb(58, 58, 60), Color.Black, New Rectangle(2, 2, Width - 4, Height - 4), 45S)
                DrawBorders(New Pen(New SolidBrush(Color.Black)))
            Case 1
                tGlow = Color.FromArgb(50, tTheme)
                tColor = Color.FromArgb(255, tTheme)

                DrawGradient(Color.FromArgb(109, 109, 111), Color.FromArgb(26, 26, 29), ClientRectangle, 45S)
                DrawGradient(Color.FromArgb(58, 58, 60), Color.Black, New Rectangle(2, 2, Width - 4, Height - 4), 45S)
                DrawBorders(New Pen(New SolidBrush(Color.Black)))
            Case 2
                tGlow = Color.FromArgb(20, Color.Black)
                tColor = Color.FromArgb(255, Color.Black)

                DrawGradient(tBordA, tBordB, ClientRectangle, 45S)
                DrawGradient(tGradA, tGradB, New Rectangle(2, 2, Width - 4, Height - 4), 45S)
                DrawGradient(Color.FromArgb(60, Color.White), Color.FromArgb(30, Color.White), New Rectangle(2, 2, Width - 4, Height / 2 - 4), 90S)
                DrawBorders(New Pen(New SolidBrush(tBorder)))
        End Select

        DrawText(New SolidBrush(tGlow), tAlign, tOffX - 1, tOffY)
        DrawText(New SolidBrush(tGlow), tAlign, tOffX - 1, tOffY + 1)
        DrawText(New SolidBrush(tGlow), tAlign, tOffX - 1, tOffY - 1)
        DrawText(New SolidBrush(tGlow), tAlign, tOffX + 1, tOffY)
        DrawText(New SolidBrush(tGlow), tAlign, tOffX + 1, tOffY + 1)
        DrawText(New SolidBrush(tGlow), tAlign, tOffX + 1, tOffY - 1)
        DrawText(New SolidBrush(tGlow), tAlign, tOffX, tOffY + 1)
        DrawText(New SolidBrush(tGlow), tAlign, tOffX, tOffY - 1)
        DrawText(New SolidBrush(tColor), tAlign, tOffX, tOffY)

        DrawCorners(BackColor)

    End Sub
    Enum ColorTheme
        GammaRay = 0
        RedShift = 1
        Subspace = 2
        SolarFlare = 3
    End Enum
    Private _ThemeColor As ColorTheme
    Public Property ThemeStyle() As ColorTheme
        Get
            Return _ThemeColor
        End Get
        Set(ByVal v As ColorTheme)
            _ThemeColor = v
            Invalidate()
        End Set
    End Property

End Class
Class DarkMatterProgressBar
    Inherits ThemeControl152

#Region " Properties "
    Private _Maximum As Integer
    Public Property Maximum() As Integer
        Get
            Return _Maximum
        End Get
        Set(ByVal v As Integer)
            If v < _Value Then _Value = v
            _Maximum = v
            Invalidate()
        End Set
    End Property
    Private _Value As Integer
    Public Property Value() As Integer
        Get
            Return _Value
        End Get
        Set(ByVal v As Integer)
            If v > Maximum Then v = Maximum
            _Value = v
            Invalidate()
        End Set
    End Property
#End Region

    Sub New()
        'Defaults
        Maximum = 100
        Value = 0
        LockHeight = 20
    End Sub

    Dim tColor, tGlow, tBorder As Color
    Protected Overrides Sub ColorHook()
    End Sub

    Protected Overrides Sub PaintHook()

        Select Case _ThemeColor
            Case 0 'GammaRay
                tColor = Color.FromArgb(200, 255, 82)
                tGlow = Color.FromArgb(123, 221, 42)
                tBorder = Color.FromArgb(31, 91, 31)
            Case 1 'RedShift
                tColor = Color.FromArgb(255, 45, 45)
                tGlow = Color.FromArgb(255, 45, 45)
                tBorder = Color.FromArgb(158, 7, 7)
            Case 2 'Subspace
                tColor = Color.FromArgb(78, 203, 255)
                tGlow = Color.FromArgb(0, 48, 255)
                tBorder = Color.Empty
            Case 3 'SolarFlare
                tColor = Color.FromArgb(255, 238, 142)
                tGlow = Color.FromArgb(255, 188, 74)
                tBorder = Color.FromArgb(110, 61, 37)
        End Select

        G.Clear(Color.FromArgb(31, 31, 31))

        G.FillRectangle(New SolidBrush(Color.FromArgb(12, 12, 12)), New Rectangle(6, Height / 2 - 3, Width - 12, 5))
        G.DrawRectangle(Pens.Black, New Rectangle(6, Height / 2 - 3, Width - 12, 5))

        Select Case _Value
            Case Is > 0
                DrawGradient(tGlow, tGlow, 6, Height / 2 - 3, CInt(_Value / _Maximum * (Width - 11)), 6, 90S)
                DrawGradient(tColor, tColor, 6, Height / 2 - 2, CInt(_Value / _Maximum * (Width - 11)), 3, 90S)
                G.DrawRectangle(New Pen(New SolidBrush(tBorder)), New Rectangle(6, Height / 2 - 3, CInt(_Value / _Maximum * (Width - 11)), 6))
                DrawCorners(Color.FromArgb(31, 31, 31), New Rectangle(6, Height / 2 - 3, CInt(_Value / _Maximum * (Width - 9)), 7))

        End Select
        DrawBorders(New Pen(New SolidBrush(Color.FromArgb(25, 25, 25))))
    End Sub
    Sub Increment(ByVal Ammount As Integer)
        If Value < Maximum - Ammount Then
            Value = Ammount
            Invalidate()
        ElseIf Maximum < Value Then
            Value = Maximum
        ElseIf Ammount > Maximum Then
            Value = Maximum
        End If
    End Sub

    Enum ColorTheme
        GammaRay = 0
        RedShift = 1
        Subspace = 2
        SolarFlare = 3
    End Enum
    Private _ThemeColor As ColorTheme
    Public Property ThemeStyle() As ColorTheme
        Get
            Return _ThemeColor
        End Get
        Set(ByVal v As ColorTheme)
            _ThemeColor = v
            Invalidate()
        End Set
    End Property
End Class