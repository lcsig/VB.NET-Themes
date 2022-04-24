Imports System.Drawing
Imports System.Windows.Forms
Imports System.Drawing.Drawing2D
'------------------
'Creator: Immortal
'ThemeName: RedDwagon
'Site: http://www.hackforums.net/member.php?action=profile&uid=503372
'Created: 8/11/2011
'Changed: 8/11/2011
'Version: 1.5.0
'------------------

Class RedDwagonTheme
  
    Inherits ThemeContainer

    Sub New()
    End Sub

    Protected Overrides Sub ColorHook()

    End Sub

    Protected Overrides Sub PaintHook()
        G.Clear(Color.Black)

        DrawGradient(Color.FromArgb(153, 0, 0), Color.FromArgb(255, 0, 0), 0, 0, Width, 55, 180S) ' Top Top
        DrawGradient(Color.FromArgb(255, 0, 0), Color.FromArgb(153, 0, 0), 0, 0, Width, 55, 90S) ' Top Top
        DrawGradient(Color.FromArgb(34, 34, 34), Color.FromArgb(34, 34, 34), 0, 56, Width, Height - 55, 90S) ' Middel Bottom
        DrawGradient(Color.FromArgb(34, 34, 34), Color.FromArgb(34, 34, 34), 0, 84, Width, 35, 90S) ' Midel Top
        G.DrawLine(Pens.Black, 0, 28, Width, 28)
        G.DrawLine(New Pen(New SolidBrush(Color.FromArgb(1, 0, 0, 0))), 0, 29, Width, 29)

        Dim p4 As Pen = New Pen(Color.FromArgb(34, 34, 34))
        Dim ClientPtA, ClientPtB As Int32
        ClientPtA = 55
        ClientPtB = 30
        DrawImage(HorizontalAlignment.Left, 5, 0)
        DrawText(Brushes.Black, 35, 7)

        G.DrawLine(p4, 0, ClientPtB, Width, ClientPtB)
        ' Damn SlantedLines Where a BITCH to get in proper spot!

        For I As Integer = 0 To Width + 17 Step 4
            G.DrawLine(p4, I, 30, I - 17, ClientPtA)
            G.DrawLine(p4, I - 1, 30, I - 18, ClientPtA)
        Next

        DrawCorners(TransparencyKey)
    End Sub
End Class

Class RedDwagonButton
    Inherits ThemeControl


    Private P1, P2 As Pen
    Private C1, C2 As Color

    Sub New()
        C1 = Color.FromArgb(153, 0, 0) ' 41 41 41 Down up gradient
        C2 = Color.FromArgb(255, 0, 0) ' Up down gradiet
    End Sub

    Protected Overrides Sub PaintHook()

        If State = MouseState.Down Then
            DrawGradient(C1, C2, 0, 0, Width, Height, 90S)
        Else
            DrawGradient(C2, C1, 0, 0, Width, Height, 90S)
        End If

        DrawText(Brushes.Black, HorizontalAlignment.Center, 0, 0)
        DrawBorders(Pens.Transparent, ClientRectangle)

        DrawCorners(Color.FromArgb(34, 34, 34), ClientRectangle)
    End Sub

    Protected Overrides Sub ColorHook()

    End Sub
End Class

Class RedDwagonPanel
    Inherits ContainerControl

    Sub New()
        BackColor = Color.FromArgb(34, 34, 34)
        SetStyle(DirectCast(139270, ControlStyles), True)
    End Sub

    Private G As Graphics
    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        G = e.Graphics

        G.Clear(BackColor)
        G.DrawRectangle(Pens.DimGray, 0, 0, Width - 1, Height - 1)
    End Sub
End Class

Class RedDwagonLine
    Inherits Control
    Sub New()
        If TypeOf Parent Is RedDwagonTheme Then
            With DirectCast(Parent, RedDwagonTheme)
                BackgroundImage = .BackgroundImage
            End With
        End If
    End Sub
    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        Using b As New Bitmap(Width, Height)
            Using g As Graphics = Graphics.FromImage(b)
                g.Clear(BackColor)

                Dim P1 As Color = Color.FromArgb(255, 0, 0)
                Dim P2 As Color = Color.FromArgb(153, 0, 0)
                g.FillRectangle(New SolidBrush(Color.FromArgb(34, 34, 34)), New Rectangle(0, 0, Width, Height))
                Dim GRec As New Rectangle(0, Height / 2, Width / 5, 2)
                Using GBrush As LinearGradientBrush = New LinearGradientBrush(GRec, Color.Transparent, P2, LinearGradientMode.Horizontal)
                    g.FillRectangle(GBrush, GRec)
                End Using
                g.DrawLine(New Pen(P2, 2), New Point(GRec.Width, GRec.Y + 1), New Point(Width - GRec.Width + 1, GRec.Y + 1))

                GRec = New Rectangle(Width - (Width / 5), Height / 2, Width / 5, 2)
                Using GBrush As LinearGradientBrush = New LinearGradientBrush(GRec, P2, Color.Transparent, LinearGradientMode.Horizontal)
                    g.FillRectangle(GBrush, GRec)
                End Using
                e.Graphics.DrawImage(b, 0, 0)
            End Using
        End Using
        MyBase.OnPaint(e)
    End Sub
End Class

Class RedDwagonProgress
    Inherits ThemeControl
    Private _Maximum As Integer
    Public Property Maximum() As Integer
        Get
            Return _Maximum
        End Get
        Set(ByVal v As Integer)
            Select Case v
                Case Is < _Value
                    _Value = v
            End Select
            _Maximum = v
            Invalidate()
        End Set
    End Property
    Private _Value As Integer
    Public Property Value() As Integer
        Get
            Select Case _Value
                Case 0
                    Return 1
                Case Else
                    Return _Value
            End Select
        End Get
        Set(ByVal v As Integer)
            Select Case v
                Case Is > _Maximum
                    v = _Maximum
            End Select
            _Value = v
            Invalidate()
        End Set
    End Property
    Protected Overrides Sub ColorHook()

    End Sub
    Protected Overrides Sub PaintHook()
        G.Clear(Color.FromArgb(34, 34, 34))
        Select Case _Value
            Case Is > 1
                DrawGradient(Color.FromArgb(255, 0, 0), Color.FromArgb(153, 0, 0), 3, 3, CInt(_Value / _Maximum * Width) - 6, Height - 6, 90S)
                DrawGradient(Color.FromArgb(153, 0, 0), Color.FromArgb(255, 0, 0), 4, 4, CInt(_Value / _Maximum * Width) - 8, Height - 8, 90S)
                G.DrawRectangle(Pens.Black, 0, 0, Width - 1, Height - 1)
                G.DrawRectangle(Pens.Gray, 1, 1, Width - 3, Height - 3)
            Case Is > 0
                DrawGradient(Color.FromArgb(255, 0, 0), Color.FromArgb(153, 0, 0), 3, 3, CInt(_Value / _Maximum * Width) - 6, Height - 6, 90S)
                DrawGradient(Color.FromArgb(153, 0, 0), Color.FromArgb(255, 0, 0), 4, 4, CInt(_Value / _Maximum * Width) - 8, Height - 8, 90S)
                G.DrawRectangle(Pens.Black, 0, 0, Width - 1, Height - 1)
                G.DrawRectangle(Pens.Gray, 1, 1, Width - 3, Height - 3)
        End Select

       
    End Sub
End Class

Class RedDwagonCheckBox
    Inherits ThemeControl
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
        Size = New Size(158, 16)
        MinimumSize = New Size(16, 16)
        MaximumSize = New Size(600, 16)
        CheckedState = False
    End Sub
    Protected Overrides Sub ColorHook()

    End Sub
    Protected Overrides Sub PaintHook()

        Dim FontColor As Color
        FontColor = Color.Red

        G.Clear(Color.FromArgb(34, 34, 34))
        Select Case CheckedState
            Case True
                DrawGradient(Color.FromArgb(255, 0, 0), Color.FromArgb(153, 0, 0), 3, 3, 9, 9, 90S)
                DrawGradient(Color.FromArgb(255, 0, 0), Color.FromArgb(153, 0, 0), 4, 4, 7, 7, 90S)
            Case False
                DrawGradient(Color.FromArgb(34, 34, 34), Color.FromArgb(34, 34, 34), 0, 0, 15, 15, 90S)
        End Select
        G.DrawRectangle(Pens.Black, 0, 0, 14, 14)
        G.DrawRectangle(Pens.Red, 1, 1, 12, 12)
        DrawText(Brushes.Red, HorizontalAlignment.Left, 17, 0)
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