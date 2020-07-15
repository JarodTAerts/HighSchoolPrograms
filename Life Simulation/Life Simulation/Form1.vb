Public Class LifeSim

    Dim orgn As Integer = 1
    Dim traits As Integer = 5
    Dim enviroment As Integer = 67
    Dim lif As Integer
    Dim lifspan As Integer
    Dim reproduce As Integer
    Dim min As Integer
    Dim opt As Integer
    Dim max As Integer
    Dim lifespn As Integer
    Dim organism(orgn, traits, 2)
    Dim holder(orgn, traits, 2) As Integer
    Dim species(1, traits, 2) As Integer
    Dim speciesn(1) As Integer
    Dim snholder(1) As Integer
    Dim speciesholder(1, traits, 2) As Integer
    Dim spn As Integer = 1
    Dim s As String = " "
    Dim evolvefac As Integer
    Dim en As Integer
    Dim diminish As Integer
    Dim n As Integer = 0
    Dim targetval As Integer
    Dim up As Integer
    Dim counter As Integer
    Dim counter2 As Integer




    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If My.Computer.FileSystem.DirectoryExists("C:\Life") = 0 Then
            My.Computer.FileSystem.CreateDirectory("C:\Life")
        End If

        Dim trait(4) As Integer
        Dim pointer(4) As Integer
        pointer(0) = 1
        Dim p As Integer = 1
        Dim n As Integer = list.Items.Count
            orgn = n
            ReDim organism(orgn, traits, 2)
            ReDim holder(orgn, traits, 2)


            For i = 1 To orgn
                For o = 1 To traits
                    For ie = 1 To 2
                        organism(i, o, ie) = 0
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

                For o = 1 To 4
                    organism(i, o, 1) = o
                    organism(i, o, 2) = trait(o)
                Next
                organism(i, 5, 1) = 5
                organism(i, 5, 2) = 0
                p = 1

            Next
            list.Items.Clear()
            enviroment = Val(TextBox1.Text)
            evolvefac = Val(TextBox2.Text)
            runit()
    End Sub

    Public Sub LifeSim_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.FileSystem.WriteAllText("C:\Life\DeadSpecies.txt", "", False)
    End Sub


    Public Sub runit()
        For i = 1 To spn
            For r = 1 To traits
                For u = 1 To 2
                    species(i, r, u) = 0
                Next
            Next
        Next


        '-----------------------------------------------------------Loop that cycles through Time intervals, controls how long the program will run
        For time = 1 To Val(timebox.Text)

            '=================================================================================================
            If orgn > Val(poplimit.Text) And (diminish = 0) Then
                Dim op As Integer
                Dim mn As Integer
                Dim ma As Integer

                For i = 1 To spn
                    If speciesn(i) > n Then n = i
                Next
                For i = 1 To traits
                    If species(n, i, 1) = 2 Then mn = species(n, i, 2)
                    If species(n, i, 1) = 3 Then op = species(n, i, 2)
                    If species(n, i, 1) = 4 Then ma = species(n, i, 2)
                Next

                If enviroment > opt Then
                    targetval = op + ((ma - op) / 2)
                    up = 1
                Else
                    targetval = op - ((op - mn) / 2)
                End If
                diminish = 1
            End If
            '==============================================================================================
            '=============================================================================================
            If diminish = 1 Then
                If counter < 500 Then
                    If up = 1 Then
                        If enviroment < targetval Then enviroment = enviroment + 2
                        counter = counter + 1
                    Else
                        If enviroment > targetval Then enviroment = enviroment - 2
                        counter = counter + 1
                    End If
                End If
                '========================================================================================
                If counter > 500 Then
                    counter2 = counter2 + 1
                    If counter2 > 100 Then
                        If up = 1 Then
                            enviroment = enviroment + 1
                        Else
                            enviroment = enviroment - 1
                        End If
                    End If
                End If
            End If
            '=============================================================================================


            currenttime.Text = time
            Temp.Text = enviroment
            speciesnum.Text = spn
            Application.DoEvents()
            Randomize()
            Dim num As Integer = orgn

            '--------------------------------------------------------Loop that cycles all organism to see if the reproduce or die
            For o = 1 To num

                If o <= orgn Then '***********************************IF that keeps the program from trying to simulate dead organism::: If A!

                    ProgressBar1.Minimum = 1
                    ProgressBar1.Maximum = num
                    ProgressBar1.Value = o
                    timepro.Text = Str$(o) + "/" + Str$(num)
                    Application.DoEvents()

                    Lifespancheck(organism, o) '======================================Sub that checks to see if current organism is at end of lifespan returns Reproduce=1 if they are
                    If reproduce = 1 Then '************************************************************IF that checks to see if reproduce=1 and the current organsim is able to reproduce
                        Dim produce As Integer = thrive(enviroment, o, traits, organism) '#######################Function that checks to see if organisms will reproduce based on temp and genes
                        If produce = 1 Then
                            birth(o)
                        End If
                        If produce = 0 Then
                            Death(o, num, time)
                        End If
                    End If '******************************************End of IF B!
                End If '********************************************** end of IF A!
            Next '------------------------------------------------------------End of Organism cycling loop

            list.Items.Clear()
            For i = 1 To spn
                Dim st As String
                Dim mn As Integer = 0
                Dim op As Integer = 0
                Dim mx As Integer = 0
                Dim lf As Integer = 0
                Dim per As Double = 0
                For e = 1 To traits
                    If species(i, e, 1) = 1 Then lf = species(i, e, 2)
                    If species(i, e, 1) = 2 Then mn = species(i, e, 2)
                    If species(i, e, 1) = 3 Then op = species(i, e, 2)
                    If species(i, e, 1) = 4 Then mx = species(i, e, 2)
                Next
                per = speciesn(i) / orgn * 100
                st = "Species" + Str$(i) + ":" + Str$(lf) + ":" + Str$(mn) + ":" + Str$(op) + ":" + Str$(mx) + ": " + Format(per, "000.00") + "% of Whole Population."
                list.Items.Add(st)
                Application.DoEvents()

            Next

            For o = 1 To orgn
                SpeciesChecker(o)
            Next
            Label1.Text = Str$(orgn)
            Application.DoEvents()

            s = "Current Time:" + Str$(time) & vbCrLf
            s = s + "Current Tempature:" + Str$(enviroment) & vbCrLf
            For p = 1 To spn
                s = s + "Species " + Str$(p) & vbCrLf & "___________________________________________________________________________" & vbCrLf & "LifeSpan:" + Str$(species(p, 1, 2)) & vbCrLf & "Minimum Tempature:" + Str$(species(p, 2, 2)) & vbCrLf & "Optimal Tempature:" + Str$(species(p, 3, 2)) & vbCrLf & "Maximum Tempature:" + Str$(species(p, 4, 2)) & vbCrLf & "Population of Species:" + Str$(speciesn(p)) & vbCrLf & vbCrLf & vbCrLf
            Next
            My.Computer.FileSystem.WriteAllText("C:\Life\species.txt", s, False)
            s = " "
            en = time
        Next '----------------------------------------------------------------End of Time loop

        Label1.Text = Str$(orgn)
        s = "End Time:" + Str$(en) & vbCrLf
        For i = 1 To spn
            s = s + "Species " + Str$(i) & vbCrLf & "___________________________________________________________________________" & vbCrLf & "LifeSpan:" + Str$(species(i, 1, 2)) & vbCrLf & "Minimum Tempature:" + Str$(species(i, 2, 2)) & vbCrLf & "Optimal Tempature:" + Str$(species(i, 3, 2)) & vbCrLf & "Maximum Tempature:" + Str$(species(i, 4, 2)) & vbCrLf & "Population of Species:" + Str$(speciesn(i)) & vbCrLf & vbCrLf & vbCrLf
        Next
        My.Computer.FileSystem.WriteAllText("C:\Life\species.txt", s, False)
        s = " "
    End Sub

    Public Sub Lifespancheck(organism, o)
        For i = 1 To traits
            If organism(o, i, 1) = 5 Then lif = i
            If organism(o, i, 1) = 1 Then lifspan = i

        Next

        If organism(o, lif, 2) < organism(o, lifspan, 2) Then
            organism(o, lif, 2) = organism(o, lif, 2) + 1
            reproduce = 0
        End If


        If organism(o, lif, 2) = organism(o, lifspan, 2) Then
            organism(o, lif, 2) = 0
            reproduce = 1
        End If

    End Sub

    Public Sub Death(o, num, time)
        orgn = orgn - 1
        num = orgn
        Erase holder
        ReDim holder(orgn, traits, 2)
        matchcheckerd(o, time)
        For i = o To orgn
            For e = 1 To traits
                For u = 1 To 2
                    organism(i, e, u) = organism(i + 1, e, u)
                Next
            Next
        Next

        For i = 1 To orgn
            For e = 1 To traits
                For u = 1 To 2
                    holder(i, e, u) = organism(i, e, u)
                Next
            Next
        Next

        ReDim organism(orgn, traits, 2)

        For i = 1 To orgn
            For e = 1 To traits
                For u = 1 To 2
                    organism(i, e, u) = holder(i, e, u)
                Next
            Next
        Next

        Erase holder

    End Sub

    Public Sub birth(o)
        orgn = orgn + 1
        ReDim holder(orgn, traits, 2)
        For i = 1 To orgn - 1
            For e = 1 To traits
                For u = 1 To 2
                    holder(i, e, u) = organism(i, e, u)
                Next
            Next
        Next

        ReDim organism(orgn, traits, 2)

        For i = 1 To orgn - 1
            For e = 1 To traits
                For u = 1 To 2
                    organism(i, e, u) = holder(i, e, u)
                Next
            Next
        Next

        For e = 1 To traits
            For u = 1 To 2
                If u = 1 Then
                    organism(orgn, e, u) = organism(o, e, u)
                End If
                If u = 2 Then
                    organism(orgn, e, u) = evolve(organism(o, e, u), organism(o, e, 1))
                End If
            Next
        Next

        Erase holder
        ReDim holder(orgn, traits, 2)
        matchcheckerb(o)
       
    End Sub


    Public Sub SpeciesChecker(o)
        '--------------------------------Declare variables for species specs holders
        Dim spmin = 0
        Dim spmax = 0
        Dim splife = 0
        Dim spopt = 0
        Dim match = 0
        '-------------------------------Finds traits for organism
        For i = 1 To traits
            If organism(o, i, 1) = 1 Then lifespn = organism(o, i, 2)
            If organism(o, i, 1) = 2 Then min = organism(o, i, 2)
            If organism(o, i, 1) = 3 Then opt = organism(o, i, 2)
            If organism(o, i, 1) = 4 Then max = organism(o, i, 2)
        Next

        '-----------------------------loop cycles through the species and finds a match if one exists
        For i = 1 To spn
            '==========================Finds species traits
            For e = 1 To traits
                If species(i, e, 1) = 1 Then splife = species(i, e, 2)
                If species(i, e, 1) = 2 Then spmin = species(i, e, 2)
                If species(i, e, 1) = 3 Then spopt = species(i, e, 2)
                If species(i, e, 1) = 4 Then spmax = species(i, e, 2)
            Next

            '===========================Compares the species traits and those of the current organism and if they are the same sets match to one and exits loop otherwise continues
            If (splife = lifespn) And (spmin - min < 3) And (spmin - min > -3) And (spopt - opt < 3) And (spopt - opt > -3) And (spmax - max < 3) And (spmax - max > -3) Then
                match = 1
                Exit For
            End If
        Next

        '--------------------------------------If there is no match then it will add new one to the species array
        If match = 0 Then

            '============================Puts info of all the current species into a holder array
            For i = 1 To spn
                For e = 1 To traits
                    For u = 1 To 2
                        speciesholder(i, e, u) = species(i, e, u)
                    Next
                Next
                snholder(i) = speciesn(i)
            Next
            spn = spn + 1 '=========adds one to the number of species
            ReDim species(spn, traits, 2) '==========resizes species array to accomidate for the new species
            ReDim speciesn(spn)

            '==========================Loop puts all info previously in holder array back into resized species array
            For i = 1 To spn - 1
                For e = 1 To traits
                    For u = 1 To 2
                        species(i, e, u) = speciesholder(i, e, u)
                    Next
                Next
                speciesn(i) = snholder(i)
            Next

            '========================Adds the traits of the new species into the open spot in the species array
            For i = 1 To traits
                For e = 1 To 2
                    species(spn, i, e) = organism(o, i, e)
                Next
            Next
            speciesn(spn) = 1

            ReDim speciesholder(spn, traits, 2)
            ReDim snholder(spn)
        End If

    End Sub


    Public Sub matchcheckerb(o)
        '--------------------------------Declare variables for species specs holders
        Dim spmin = 0
        Dim spmax = 0
        Dim splife = 0
        Dim spopt = 0
        Dim match = 0
        '-------------------------------Finds traits for organism
        For i = 1 To traits
            If organism(o, i, 1) = 1 Then lifespn = organism(o, i, 2)
            If organism(o, i, 1) = 2 Then min = organism(o, i, 2)
            If organism(o, i, 1) = 3 Then opt = organism(o, i, 2)
            If organism(o, i, 1) = 4 Then max = organism(o, i, 2)
        Next

        '-----------------------------loop cycles through the species and finds a match if one exists
        For i = 1 To spn
            '==========================Finds species traits
            For e = 1 To traits
                If species(i, e, 1) = 1 Then splife = species(i, e, 2)
                If species(i, e, 1) = 2 Then spmin = species(i, e, 2)
                If species(i, e, 1) = 3 Then spopt = species(i, e, 2)
                If species(i, e, 1) = 4 Then spmax = species(i, e, 2)
            Next

            '===========================Compares the species traits and those of the current organism and if they are the same sets match to one and exits loop otherwise continues
            If (splife = lifespn) And (spmin - min < 3) And (spmin - min > -3) And (spopt - opt < 3) And (spopt - opt > -3) And (spmax - max < 3) And (spmax - max > -3) Then
                match = 1
                speciesn(i) = speciesn(i) + 1
                Exit For
            End If
        Next

    End Sub

    Public Sub matchcheckerd(o, time)
        '--------------------------------Declare variables for species specs holders
        Dim spmin = 0
        Dim spmax = 0
        Dim splife = 0
        Dim spopt = 0
        Dim match = 0
        '-------------------------------Finds traits for organism
        For i = 1 To traits
            If organism(o, i, 1) = 1 Then lifespn = organism(o, i, 2)
            If organism(o, i, 1) = 2 Then min = organism(o, i, 2)
            If organism(o, i, 1) = 3 Then opt = organism(o, i, 2)
            If organism(o, i, 1) = 4 Then max = organism(o, i, 2)
        Next

        '-----------------------------loop cycles through the species and finds a match if one exists
        For i = 1 To spn
            '==========================Finds species traits
            For e = 1 To traits
                If species(i, e, 1) = 1 Then splife = species(i, e, 2)
                If species(i, e, 1) = 2 Then spmin = species(i, e, 2)
                If species(i, e, 1) = 3 Then spopt = species(i, e, 2)
                If species(i, e, 1) = 4 Then spmax = species(i, e, 2)
            Next

            '===========================Compares the species traits and those of the current organism and if they are the same sets match to one and exits loop otherwise continues
            If (splife = lifespn) And (spmin - min < 3) And (spmin - min > -3) And (spopt - opt < 3) And (spopt - opt > -3) And (spmax - max < 3) And (spmax - max > -3) Then
                match = 1
                speciesn(i) = speciesn(i) - 1
                If speciesn(i) <= 0 Then dspecies(i, time)
                Exit For
            End If
        Next

    End Sub

    Public Sub dspecies(i, time)

        s = "_____________________________________________________________________________________________" & vbCrLf & "Species Traits" & vbCrLf & "_____________________________________________________________________________________________" & vbCrLf
        s = s + "Lifespan:" + Str$(species(i, 1, 2)) & vbCrLf
        s = s + "Minnimum Tempature:" + Str$(species(i, 2, 2)) & vbCrLf
        s = s + "Optimal Tempature:" + Str$(species(i, 3, 2)) & vbCrLf
        s = s + "Maximum Tempature:" + Str$(species(i, 4, 2)) & vbCrLf
        s = s + "Time of Extinction:" + Str$(time) & vbCrLf & vbCrLf
        My.Computer.FileSystem.WriteAllText("C:\Life\DeadSpecies.txt", s, True)

        For ie = i To spn - 1
            For u = 1 To traits - 1
                For w = 1 To 2
                    species(ie, u, w) = species(ie + 1, u, w)
                Next
            Next
            speciesn(ie) = speciesn(ie + 1)
        Next
        spn = spn - 1
        For ie = 1 To spn
            For u = 1 To traits - 1
                For w = 1 To 2
                    speciesholder(ie, u, w) = species(ie, u, w)
                Next
            Next
            snholder(ie) = speciesn(ie)
        Next
        ReDim species(spn, traits, 2)
        ReDim speciesn(spn)

        For ie = 1 To spn
            For u = 1 To traits - 1
                For w = 1 To 2
                    species(ie, u, w) = speciesholder(ie, u, w)
                Next
            Next
            speciesn(ie) = snholder(ie)
        Next


        ReDim speciesholder(spn, traits, 2)
        ReDim snholder(spn)

    End Sub


    Function thrive(enviroment, o, traits, organism)
        Dim xslope
        Dim yslope
        Dim xslope2
        Dim reproduceval
        Dim pro


        For i = 1 To traits
            If organism(o, i, 1) = 2 Then min = organism(o, i, 2)
            If organism(o, i, 1) = 3 Then opt = organism(o, i, 2)
            If organism(o, i, 1) = 4 Then max = organism(o, i, 2)
        Next
        reproduceval = 0



        If enviroment > opt Then
            xslope = max - opt
            yslope = 100
            xslope2 = enviroment - opt
            reproduceval = yslope * (xslope2 / xslope)
        End If

        If enviroment < opt Then
            xslope = opt - min
            yslope = 100
            xslope2 = opt - enviroment
            reproduceval = yslope * (xslope2 / xslope)
        End If
        Randomize()
        pro = Rnd(1) * 100

        If pro < reproduceval Then
            thrive = 0
        Else
            thrive = 1
        End If
    End Function

    Function evolve(trait, type)
        If type <> 1 Then
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
        End If

        If type = 1 Then
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
        End If

        If (type = 1) And (trait < 1) Then
            trait = 1
        End If
        evolve = trait
    End Function

    Function tempchange(temp)
        Dim n As Double = Rnd()
        If n < 0.5 Then
            Dim p As Double = Rnd()
            If p < 0.5 Then
                temp = temp + 1
            Else
                temp = temp - 1
            End If
        End If
        tempchange = temp
    End Function


    Private Sub addSpecies_Click(sender As Object, e As EventArgs) Handles addSpecies.Click
        If SpeciesAdder.Text <> "" Then
            list.Items.Add(SpeciesAdder.Text)
            SpeciesAdder.Text = ""
        End If
    End Sub

    Private Sub deleteSpecies_Click(sender As Object, e As EventArgs) Handles deleteSpecies.Click
        list.Items.Remove(list.SelectedItem)
    End Sub

    Private Sub Help_Click(sender As Object, e As EventArgs) Handles Help.Click
        MsgBox("This is a Program with the aim to simulate the life, reproduction, and evolution of simple single celled organisms called Tempites. These oranisms are only sensitive to tempature. They will evolve by changing either the length they live in time, the minnimum tempature they can survive, or the maxiumum tempature they can survive." & vbCrLf & "If you choose to imput more species of organisms you MUST do it in this format:: 'LifeSpan;MinimmumTemp;OptimalTemp;MaximumTemp;' Failure to imput new species in this way will casue application to crash. Other changable options are on the right side they are all pretty self explanitory except for evolution factor which changes how often organisms will evolve, higher is less often, lower is more often.")
    End Sub
End Class
