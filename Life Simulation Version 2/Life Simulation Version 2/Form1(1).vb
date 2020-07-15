Public Class Form1
    Dim orgn As Integer = 0
    Dim spn As Integer = 1
    Dim traits As Integer = 7
    Dim tempature As Double
    Dim evolvefac As Integer
    Dim species(spn, traits + 1, 2)
    Dim speciesholder(spn, traits + 1, 2)
    Dim timer As Integer = 1


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Computer.FileSystem.DirectoryExists("C:\Life") = 0 Then
            My.Computer.FileSystem.CreateDirectory("C:\Life")
        End If
        If My.Computer.FileSystem.DirectoryExists("C:\Life\Summaries") = 0 Then
            My.Computer.FileSystem.CreateDirectory("C:\Life\Summaries")
        End If

        My.Computer.FileSystem.WriteAllText("C:\Life\DeadSpecies.txt", "", False)
    End Sub


    Private Sub AddS_Click(sender As Object, e As EventArgs) Handles AddS.Click
        If SAB.Text <> "" Then
            list.Items.Add(SAB.Text)
            SAB.Text = ""
        End If
    End Sub

    Private Sub RS_Click(sender As Object, e As EventArgs) Handles RS.Click
        list.Items.Remove(list.SelectedItem)
    End Sub

    Private Sub start_Click(sender As Object, e As EventArgs) Handles start.Click
        Dim trait(traits) As Integer
        Dim pointer(traits) As Integer
        pointer(0) = 1
        Dim p As Integer = 1
        Dim n As Integer = list.Items.Count
        spn = n
        ReDim species(spn, traits, 2)
        ReDim species(spn, traits, 2)


        For i = 1 To orgn
            For o = 1 To traits
                For ie = 1 To 2
                    species(i, o, ie) = 0
                Next
            Next
        Next


        For i = 1 To n
            Dim attribute As String = list.Items(i - 1)
            For o = 1 To Len(attribute)
                If Mid$(attribute, o, 1) = ";" Then
                    trait(p) = Mid$(attribute, pointer(p - 1), o - pointer(p - 1))
                    pointer(p) = o + 1
                    p = p + 1
                End If
            Next

            For o = 1 To traits - 2
                species(i, o, 1) = o
                species(i, o, 2) = trait(o)
            Next
            species(i, 6, 1) = 6
            species(i, 6, 2) = 0
            species(i, 7, 1) = 7
            species(i, 7, 2) = 100 + Rnd() * 50 + Rnd() * 50
            p = 1

        Next

        For i = 1 To spn
            For ie = 1 To traits
                If species(i, ie, 1) = 5 Then orgn = orgn + species(i, ie, 2)
            Next
        Next

        list.Items.Clear()
        tempature = Val(TextBox2.Text)
        evolvefac = Val(TextBox3.Text)
        runit()
    End Sub


    Public Sub runit()
        Dim produce As Integer
        NOO.Text = orgn
        speciestolist()


        For time = 1 To Val(TextBox1.Text)
            Ti.Text = time
            T.Text = tempature
            NOO.Text = orgn
            speciestolist()
            NOS.Text = spn
            Application.DoEvents()
            Randomize()
            Dim num As Integer = spn
            tempature = tempaturechange(tempature)
            For sp = 1 To num


                Dim mature = Lifespancheck(sp)

                If mature = 1 Then
                    produce = 0
                    If speciesnumber(sp) < 100 Then
                        For i = 1 To speciesnumber(sp)
                            produce = produce + thriveind(tempature, sp, traits)
                        Next
                    Else
                        produce = thrive(tempature, sp, traits)
                    End If

                    birth(produce, sp)
                    If produce > 0 Then
                        For o = 1 To produce
                            ProgressBar1.Minimum = 1
                            ProgressBar1.Maximum = produce
                            ProgressBar1.Value = o
                            Application.DoEvents()

                            Dim traitp(traits) As Integer
                            Dim trait(4) As Integer
                            For ie = 1 To traits
                                If species(sp, ie, 1) = 1 Then traitp(1) = ie
                                If species(sp, ie, 1) = 2 Then traitp(2) = ie
                                If species(sp, ie, 1) = 3 Then traitp(3) = ie
                                If species(sp, ie, 1) = 4 Then traitp(4) = ie
                                If species(sp, ie, 1) = 5 Then traitp(5) = ie
                                If species(sp, ie, 1) = 6 Then traitp(6) = ie
                                If species(sp, ie, 1) = 7 Then traitp(7) = ie
                            Next
                            For i = 1 To 4
                                trait(i) = species(sp, traitp(i), 2)
                            Next
                            trait(1) = evolvelife(trait(1))
                            For i = 2 To 4
                                trait(i) = evolvetemp(trait(i))
                            Next

                            If (trait(1) <> species(sp, traitp(1), 2)) Or (trait(2) <> species(sp, traitp(2), 2)) Or (trait(3) <> species(sp, traitp(3), 2)) Or (trait(4) <> species(sp, traitp(4), 2)) Then
                                species(sp, traitp(5), 2) = species(sp, traitp(5), 2) - 2
                                If speciescheck(trait, sp) = 0 Then
                                    NewSpecies(trait, traitp, sp)
                                End If
                            End If
                        Next
                    End If
                End If

            Next

            orgn = 0
            For i = 1 To spn
                For u = 1 To traits
                    If species(i, u, 1) = 5 Then orgn = orgn + species(i, u, 2)
                Next
            Next
            Currentsummary(time, tempature)
            timesummary(time, tempature)
            Deadspecies(time)



        Next '-----------------------------------------------------------------------------------------------End of Time loop
    End Sub

    Public Sub speciestolist()
        list.Items.Clear()
        Dim trait(traits) As Integer
        Dim s As String = ""

        For i = 1 To spn
            For ie = 1 To traits
                If species(i, ie, 1) = 1 Then trait(1) = species(i, ie, 2)
                If species(i, ie, 1) = 2 Then trait(2) = species(i, ie, 2)
                If species(i, ie, 1) = 3 Then trait(3) = species(i, ie, 2)
                If species(i, ie, 1) = 4 Then trait(4) = species(i, ie, 2)
                If species(i, ie, 1) = 5 Then trait(5) = species(i, ie, 2)
                If species(i, ie, 1) = 6 Then trait(6) = species(i, ie, 2)
                If species(i, ie, 1) = 7 Then trait(7) = species(i, ie, 2)
            Next


            s = s + "Species" + Str$(trait(7)) + " |" + Str$(trait(1)) + ";" + Str$(trait(2)) + ";" + Str$(trait(3)) + ";" + Str$(trait(4)) + " |" + Str$(100 * (trait(5) / orgn)) + "% of Population"

            list.Items.Add(s)
            s = ""
        Next
    End Sub

    Public Sub birth(produce, sp)
        For i = 1 To traits
            If species(sp, i, 1) = 5 Then species(sp, i, 2) = produce * 2
        Next
    End Sub

    Public Sub NewSpecies(trait, traitp, sp)
        ReDim speciesholder(spn, traits, 2)
        For i = 1 To spn
            For u = 1 To traits
                For ie = 1 To 2
                    speciesholder(i, u, ie) = species(i, u, ie)
                Next
            Next
        Next
        spn = spn + 1
        ReDim species(spn, traits, 2)
        For i = 1 To spn - 1
            For u = 1 To traits
                For ie = 1 To 2
                    species(i, u, ie) = speciesholder(i, u, ie)
                Next
            Next
        Next

        For i = 1 To 4
            species(spn, i, 1) = i
            species(spn, i, 2) = trait(i)
        Next
        species(spn, 5, 1) = 5
        species(spn, 5, 2) = 2
        species(spn, 6, 1) = 6
        species(spn, 6, 2) = 0
        species(spn, 7, 1) = 7
        species(spn, 7, 2) = 100 + Rnd() * 50 + Rnd() * 50


    End Sub

    Public Sub Currentsummary(time, tempature)
        My.Computer.FileSystem.WriteAllText("C:\Life\CurrentSummary.txt", " ", False)
        Dim trait(traits)
        Dim s As String = " "
        s = "Current Time:" + Str$(time) & vbCrLf
        s = s + "Total Population:" + Str$(orgn) & vbCrLf
        s = s + "Current Tempature:" + Str$(tempature) & vbCrLf & vbCrLf
        For i = 1 To spn
            For ie = 1 To traits
                If species(i, ie, 1) = 1 Then trait(1) = ie
                If species(i, ie, 1) = 2 Then trait(2) = ie
                If species(i, ie, 1) = 3 Then trait(3) = ie
                If species(i, ie, 1) = 4 Then trait(4) = ie
                If species(i, ie, 1) = 5 Then trait(5) = ie
                If species(i, ie, 1) = 6 Then trait(6) = ie
                If species(i, ie, 1) = 7 Then trait(7) = ie
            Next

            s = s + "------------------------------------------------------------------------" & vbCrLf
            s = s + "Species Name:" + Str$(species(i, trait(7), 2)) & vbCrLf
            s = s + "Lifespan:" + Str$(species(i, trait(1), 2)) & vbCrLf
            s = s + "Minimum Tempature:" + Str$(species(i, trait(2), 2)) & vbCrLf
            s = s + "Optimal Tempature:" + Str$(species(i, trait(3), 2)) & vbCrLf
            s = s + "Maximum Temparure:" + Str$(species(i, trait(4), 2)) & vbCrLf
            s = s + "Number in Species:" + Str$(species(i, trait(5), 2)) & vbCrLf
            s = s + "Percent of Total Population:" + Str$(100 * (species(i, trait(5), 2) / orgn)) & vbCrLf
            s = s + "------------------------------------------------------------------------" & vbCrLf & vbCrLf
        Next
        My.Computer.FileSystem.WriteAllText("C:\Life\CurrentSummary.txt", s, True)
    End Sub

    Public Sub timesummary(time, tempature)
        My.Computer.FileSystem.WriteAllText("C:\Life\Summaries\Summary" + Str$(time) + ".txt", " ", False)
        Dim trait(traits)
        Dim s As String = " "
        s = "Current Time:" + Str$(time) & vbCrLf
        s = s + "Total Population:" + Str$(orgn) & vbCrLf
        s = s + "Current Tempature:" + Str$(tempature) & vbCrLf & vbCrLf
        For i = 1 To spn
            For ie = 1 To traits
                If species(i, ie, 1) = 1 Then trait(1) = ie
                If species(i, ie, 1) = 2 Then trait(2) = ie
                If species(i, ie, 1) = 3 Then trait(3) = ie
                If species(i, ie, 1) = 4 Then trait(4) = ie
                If species(i, ie, 1) = 5 Then trait(5) = ie
                If species(i, ie, 1) = 6 Then trait(6) = ie
                If species(i, ie, 1) = 7 Then trait(7) = ie
            Next

            s = s + "------------------------------------------------------------------------" & vbCrLf
            s = s + "Species Name:" + Str$(species(i, trait(7), 2)) & vbCrLf
            s = s + "Lifespan:" + Str$(species(i, trait(1), 2)) & vbCrLf
            s = s + "Minimum Tempature:" + Str$(species(i, trait(2), 2)) & vbCrLf
            s = s + "Optimal Tempature:" + Str$(species(i, trait(3), 2)) & vbCrLf
            s = s + "Maximum Temparure:" + Str$(species(i, trait(4), 2)) & vbCrLf
            s = s + "Number in Species:" + Str$(species(i, trait(5), 2)) & vbCrLf
            s = s + "Percent of Total Population:" + Str$(100 * (species(i, trait(5), 2) / orgn)) & vbCrLf
            s = s + "------------------------------------------------------------------------" & vbCrLf & vbCrLf
        Next
        My.Computer.FileSystem.WriteAllText("C:\Life\Summaries\Summary" + Str$(time) + ".txt", s, True)
    End Sub

    Public Sub Deadspecies(time)
        For i = 1 To spn
            If speciesnumber(i) <= 0 Then
                Deadfile(i, time)

                For u = i To spn - 1
                    For ie = 1 To traits
                        For ue = 1 To 2
                            species(u, ie, ue) = species(u + 1, ie, ue)
                        Next
                    Next
                Next
                spn = spn - 1
                ReDim speciesholder(spn, traits, 2)

                For u = 1 To spn
                    For ie = 1 To traits
                        For ue = 1 To 2
                            speciesholder(u, ie, ue) = species(u, ie, ue)
                        Next
                    Next
                Next

                ReDim species(spn, traits, 2)

                For u = 1 To spn
                    For ie = 1 To traits
                        For ue = 1 To 2
                            species(u, ie, ue) = speciesholder(u, ie, ue)
                        Next
                    Next
                Next

            End If
        Next
    End Sub

    Public Sub Deadfile(i, time)
        Dim trait(traits)
        Dim s As String = " "
  

        For ie = 1 To traits
            If species(i, ie, 1) = 1 Then trait(1) = ie
            If species(i, ie, 1) = 2 Then trait(2) = ie
            If species(i, ie, 1) = 3 Then trait(3) = ie
            If species(i, ie, 1) = 4 Then trait(4) = ie
            If species(i, ie, 1) = 5 Then trait(5) = ie
            If species(i, ie, 1) = 6 Then trait(6) = ie
            If species(i, ie, 1) = 7 Then trait(7) = ie
        Next

        s = s + "------------------------------------------------------------------------" & vbCrLf
        s = s + "Species Name:" + Str$(species(i, trait(7), 2)) & vbCrLf
        s = s + "Lifespan:" + Str$(species(i, trait(1), 2)) & vbCrLf
        s = s + "Minimum Tempature:" + Str$(species(i, trait(2), 2)) & vbCrLf
        s = s + "Optimal Tempature:" + Str$(species(i, trait(3), 2)) & vbCrLf
        s = s + "Maximum Temparure:" + Str$(species(i, trait(4), 2)) & vbCrLf
        s = s + "Time of Extinction:" + Str$(time) & vbCrLf
        s = s + "------------------------------------------------------------------------" & vbCrLf & vbCrLf

        My.Computer.FileSystem.WriteAllText("C:\Life\DeadSpecies.txt", s, True)
    End Sub


    Function Lifespancheck(sp)
        Lifespancheck = 0
        Dim lif As Integer
        Dim lifspan As Integer
        For i = 1 To traits
            If species(sp, i, 1) = 1 Then lifspan = i
            If species(sp, i, 1) = 6 Then lif = i
        Next

        If species(sp, lif, 2) < species(sp, lifspan, 2) Then
            species(sp, lif, 2) = species(sp, lif, 2) + 1
            Lifespancheck = 0
        End If
        If species(sp, lif, 2) = species(sp, lifspan, 2) Then
            species(sp, lif, 2) = 0
            Lifespancheck = 1
        End If
    End Function

    Function thrive(tempature, sp, traits)
        Dim min As Integer
        Dim opt As Integer
        Dim max As Integer
        Dim no As Integer
        Dim xslope As Integer
        Dim yslope As Integer
        Dim xslope2 As Integer
        Dim reproduceval As Double

        thrive = 0
        For i = 1 To traits
            If species(sp, i, 1) = 2 Then min = species(sp, i, 2)
            If species(sp, i, 1) = 3 Then opt = species(sp, i, 2)
            If species(sp, i, 1) = 4 Then max = species(sp, i, 2)
            If species(sp, i, 1) = 5 Then no = species(sp, i, 2)
        Next
        reproduceval = 1
        thrive = Math.Round(no)
        If tempature > opt Then
            xslope = max - opt
            yslope = 100
            xslope2 = tempature - opt
            reproduceval = (xslope2 / xslope)
            thrive = Math.Round(no * (1 - reproduceval))
        End If

        If tempature < opt Then
            xslope = opt - min
            yslope = 100
            xslope2 = opt - tempature
            reproduceval = (xslope2 / xslope)
            thrive = Math.Round(no * (1 - reproduceval))
        End If

    End Function

    Function thriveind(tempature, sp, traits)
        Dim min As Integer
        Dim opt As Integer
        Dim max As Integer
        Dim xslope As Integer
        Dim yslope As Integer
        Dim xslope2 As Integer
        Dim pro As Double
        Dim reproduceval As Double

        thriveind = 0
        For i = 1 To traits
            If species(sp, i, 1) = 2 Then min = species(sp, i, 2)
            If species(sp, i, 1) = 3 Then opt = species(sp, i, 2)
            If species(sp, i, 1) = 4 Then max = species(sp, i, 2)
        Next
        reproduceval = 0

        If tempature > opt Then
            xslope = max - opt
            yslope = 100
            xslope2 = tempature - opt
            reproduceval = yslope * (xslope2 / xslope)
        End If

        If tempature < opt Then
            xslope = opt - min
            yslope = 100
            xslope2 = opt - tempature
            reproduceval = yslope * (xslope2 / xslope)
        End If
        Randomize()
        pro = Rnd(1) * 100
        If pro < reproduceval Then
            thriveind = 0
        Else
            thriveind = 1
        End If

    End Function

    Function evolvetemp(trait)
        Dim n As Double = Rnd() * evolvefac * 10000
        If n < (evolvefac * 10000) / evolvefac Then
            Dim p As Double = Rnd()
            If p < 0.5 Then
                trait = trait + 1
            Else
                trait = trait - 1
            End If
        End If

        If n < (evolvefac * 10000) / (evolvefac * 100) Then
            Dim p As Double = Rnd()
            If p < 0.5 Then
                trait = trait + 5
            Else
                trait = trait - 5
            End If
        End If

        If n < (evolvefac * 10000) / (evolvefac * 10000) Then
            Dim p As Double = Rnd()
            If p < 0.5 Then
                trait = trait + 10
            Else
                trait = trait - 10
            End If
        End If

        evolvetemp = trait
    End Function

    Function evolvelife(trait)
        Dim n As Double = Rnd() * evolvefac * 10000
        If n < (evolvefac * 10000) / (evolvefac * 1000) Then
            Dim p As Double = Rnd()
            If p < 0.5 Then
                trait = trait + 1
            Else
                trait = trait - 1
            End If
        End If

        If n < (evolvefac * 10000) / (evolvefac * 10000) Then
            Dim p As Double = Rnd()
            If p < 0.5 Then
                trait = trait + 3
            Else
                trait = trait - 3
            End If
        End If
        If trait < 1 Then trait = 1

        evolvelife = trait
    End Function

    Function speciescheck(trait, sp)

        Dim traitp(traits)
        speciescheck = 0
        For i = 1 To spn
            For ie = 1 To traits
                If species(i, ie, 1) = 1 Then traitp(1) = ie
                If species(i, ie, 1) = 2 Then traitp(2) = ie
                If species(i, ie, 1) = 3 Then traitp(3) = ie
                If species(i, ie, 1) = 4 Then traitp(4) = ie
                If species(i, ie, 1) = 5 Then traitp(5) = ie
                If species(i, ie, 1) = 6 Then traitp(6) = ie
                If species(i, ie, 1) = 7 Then traitp(7) = ie
            Next

            If (trait(1) = species(i, traitp(1), 2)) And (trait(2) = species(i, traitp(2), 2)) And (trait(3) = species(i, traitp(3), 2)) And (trait(4) = species(i, traitp(4), 2)) Then
                speciescheck = 1
                species(i, traitp(5), 2) = species(i, traitp(5), 2) + 2
            End If
        Next
    End Function

    Function speciesnumber(sp)
        speciesnumber = 0
        For i = 1 To traits
            If species(sp, i, 1) = 5 Then speciesnumber = species(sp, i, 2)
        Next
    End Function
    Function tempaturechange(tempature)
        tempaturechange = tempature
        If timer >= Val(tempchange.Text) Then
            timer = 0
            If raise.Checked Then tempaturechange = tempaturechange + 1
            If lower.Checked Then tempaturechange = tempaturechange - 1
        End If
        If timer < Val(tempchange.Text) Then timer = timer + 1
    End Function

End Class
