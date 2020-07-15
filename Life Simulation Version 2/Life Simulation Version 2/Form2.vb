Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms
Public Class graphform


    Dim s As String
    Public Shared graphleft = 50
    Public Shared graphtop = 10
    Public Shared graphW = 700
    Public Shared graphH = 450
    Public Shared num As Long
    Dim standard As Double
    Dim scal As Double = 1.3
    Public Shared speciesinfo(1, 3) As Long
    Public Shared colorname(1) As Long
    Public Shared colo(1) As Color
    Public Shared holderx(1) As Long
    Public Shared holdercolor(1) As Color
    Public Shared pos(Form1.tim) As Double

    Private Sub graphform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "Current Time: " + Str$(Form1.tim)
        Dim g As Graphics = Me.CreateGraphics
        g.FillRectangle(Brushes.Black, 0, 0, 800, 600)
        g.DrawRectangle(Pens.White, graphleft - 2, graphtop - 2, graphW + 4, graphH + 4)
    End Sub

    Private Sub exitgraph_Click(sender As Object, e As EventArgs) Handles exitgraph.Click
        Me.Hide()
    End Sub

    Public Sub getspecies()
        Dim c As Long = 1
        Dim c2 As Long
        s = My.Computer.FileSystem.ReadAllText("C:\Life\Info\graph.txt")
        For i = 1 To Len(s)
            If Mid$(s, i, 1) = "-" Then
                c = c + 1
            End If
        Next
        ReDim speciesinfo(c, 3)
        num = c
        c = 1
        For i = 1 To Len(s)
            If Mid$(s, i, 1) = ";" Then
                speciesinfo(c2, 1) = Val(Mid$(s, c, (i - c)))
                c = i + 2
            End If
            If Mid$(s, i, 1) = ":" Then
                speciesinfo(c2, 2) = Val(Mid$(s, c, (i - c)))
                c = i + 2
            End If
            If Mid$(s, i, 1) = "-" Then
                speciesinfo(c2, 3) = Val(Mid$(s, c, (i - c)))
                c = i + 2

                c2 = c2 + 1
            End If
        Next
    End Sub

    Private Sub graph_Click(sender As Object, e As System.EventArgs) Handles graph.Click
        If TextBox1.Text <> "" Then scal = Val(TextBox1.Text)
        Dim g As Graphics = Me.CreateGraphics
        ReDim pos(Form1.tim)
        Label1.Text = "Current Time: " + Str$(Form1.tim)
        Label2.Text = "Total Number of Organisms: " + Str$(Form1.oi)
        getspecies()
        findpositions()
        cl(g)
        colorfinder()
        stand()
        graphpoints(g)
    End Sub

    Public Sub findpositions()
        Dim a = graphW / Form1.tim
        Dim c = 1

        For i = a To graphW Step a

            Application.DoEvents()

            pos(c) = graphleft + i
            c = c + 1
        Next
    End Sub

    Public Sub graphpoints(g)
        Dim pointer As Integer = 1
        Dim pn As New Pen(Color.Red)
        Dim w As Integer = graphW + 4
        Dim h As Integer = graphH + 4
        Dim bm As New Bitmap(w, h)
        Dim gr As Graphics = Graphics.FromImage(bm)
        gr.Clear(Color.Black)

        For i = 1 To Form1.tim
            For e = 1 To num
                If speciesinfo(e, 3) = i Then
                    pointer = 1
                    For ie = 1 To colorname.Length - 1
                        If speciesinfo(e, 1) = colorname(ie) Then
                            pointer = ie
                            Exit For
                        End If
                    Next

                    pn = New Pen(colo(pointer))
                    Dim height = (graphtop + graphH) - ((speciesinfo(e, 2) / (standard * scal)) * graphH)
                    Dim pt1 As New Point(pos(i), height)
                    Dim pt2 As New Point(pos(i) + 1, height)
                    g.DrawLine(pn, pt1, pt2)

                    pt1.X = pt1.X - graphleft
                    pt1.Y = pt1.Y - graphleft
                    pt2.X = pt2.X - graphleft
                    pt2.Y = pt2.Y - graphleft
                    gr.DrawLine(pn, pt1, pt2)
                End If
            Next
        Next
        Dim y As String = "C:\Life\Graphs\Graph-" & Strings.Left(Str$(Form1.tim), (Len(Str$(Form1.tim) - 1))) & ".png"
        bm.Save(y, System.Drawing.Imaging.ImageFormat.Png)
    End Sub

    Public Sub cl(g)
        g.fillrectangle(Brushes.Black, 0, 0, 800, 600)
        g.DrawRectangle(Pens.White, graphleft - 2, graphtop - 2, graphW + 4, graphH + 4)
    End Sub

    Public Sub colorfinder()
        Dim find As Integer = 1
        For i = 1 To num
            For e = 1 To colorname.Length - 1
                If speciesinfo(i, 1) = colorname(e) Then
                    find = 1
                    Exit For
                End If
                If speciesinfo(i, 1) <> colorname(e) Then
                    find = 0
                End If
            Next

            If find = 0 Then
                ReDim holderx(colorname.Length)
                ReDim holdercolor(colorname.Length)

                For e = 1 To colorname.Length - 1
                    holderx(e) = colorname(e)
                    holdercolor(e) = colo(e)
                Next

                ReDim colorname(colorname.Length + 1)
                ReDim colo(colorname.Length)

                For e = 1 To holderx.Length - 1
                    colorname(e) = holderx(e)
                    colo(e) = holdercolor(e)
                Next

                colorname(colorname.Length - 1) = speciesinfo(i, 1)
                Randomize()
                Dim alpha As Integer = 255
                Dim red As Integer = Int(Rnd() * 255)
                Randomize()
                Dim green As Integer = Int(Rnd() * 255)
                Randomize()
                Dim blue As Integer = Int(Rnd() * 255)
                colo(colorname.Length - 1) = Color.FromArgb(alpha, red, green, blue)
            End If

        Next
    End Sub

    Public Sub stand()
        For i = 1 To num
            If speciesinfo(i, 2) > standard Then standard = speciesinfo(i, 2)
        Next
    End Sub

End Class