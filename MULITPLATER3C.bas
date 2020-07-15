5 cls
a=2
b=2
c=4
100 cls
Print " "
Print " 'A" ;a
PRINT "     C" ;c
print "       *B" ;b
print " "
 Input "Player A it is your turn. Press A to Start turn." ;n$
  If n$="A" then
   Goto 200
 end if
 goto 100

  200 Cls
   t=0
  205 cls
  Print " "
  Print "   ('A)" ;a
  print "       C" ;c
   Print "       *B" ;b
  Print " "
 Print "    T= Train Army. (note only one army may be trained per city per turn)"
 Print "    X= Attack/Move troops."
 Print "    E= End Turn."
 230 Input "What will you do?> " ;n$
  if n$="T" then
   if t=0 then
    a=a+1
    t=1
    goto 205
   end if
   if t=1 Then
    print "You have already Trained an army in this city this turn."
    goto 230
   end if
end if
 if n$="X" then
  Input "What City?> " ;g$
   IF g$="B" then
    print "You can only attack or send troops to cities adjacent to you."
    goto 230
    end if
    if g$="C" then
     1250 Input "How many armies will you send?> " ;r
      if r>a then
      Print "You don't have that many armies."
      goto 1250
      end if

      g=RND ((1)+1*r)
     d=RND ((1)+1*c)
      If g>d then
       a=a-r
       r=r*.75
       goto 1300
       end if
      if g<=d then
       a=a-r*.50
       c=c*.50
       goto 205
       end if
       end if

end if

if n$="E" then
 goto 300
 end if
GOTO 205
300
t=0

400 cls
Print " "
Print " 'A" ;a
print "     C" ;c
print "       *B" ;b
print " "
 Input "Player B it is your turn. Press B to Start turn." ;n$
  If n$="B" then
   Goto 500
 end if
 goto 400

 500 cls
 v=0
 505 cls
 print " "
 Print " 'A" ;a
 print "    C" ;c
print "      (*B)" ;b
print ""
 Print "    T= Train Army. (note only one army may be trained per city per turn)"
 Print "    X= Attack/Move troops."
 Print "    E= End Turn."
530 Input "What will you do?> " ;n$
  if n$="T" then
   if t=0 then
    b=b+1
    t=1
    goto 505
   end if
   if t=1 Then
    print "You have already Trained an army in this city this turn."
    goto 530
   end if
end if
 if n$="X" then
  520 Input "What City?> " ;g$
   IF g$="A" then
    Print "You can only attack or move troops to cities adjacent to you."
    goto 520
    END IF
       IF g$="C" then
        GOTO 1400
        1400 Input "How many armies?> " ;y
         if r>b then
          print "You dont have that many armies."
          goto 1400
          end if
     g=RND ((1)+1*y)
     d=RND ((1)+1*c)
      If g>d then
       b=b-y
       y=y*.75
       goto 1805
       end if
      if g<=d then
       b=b-y*.50
       c=c*.50
       goto 505
       end if
       end if
       end if


if n$="E" then
 goto 100
 end if
 GOTO 505


1000 CLS
print " "
 Print " 'A" ;a
print "     'C" ;r
print "       'B" ;v
print ""
Input " Congradulations Player 'A, You have won. Press 1 to restart." ;a
 If a=1 then
  goto 5
 end if

 1100 CLS
print " "
 Print " *A" ;w
PRINT "     *C" ;y
print "       *B" ;b
print ""
Input " Congradulations Player *B, You have won. Press 1 to restart." ;a
 If a=1 then
  goto 5
 end if



1300 cls

Print " 'A" ;a
print "     {'C}" ;r
print "       *B" ;b
print " "
print "You have conquered city C"
Print "It will be in {civil unrest} for 1 turn, then u may select it."
Input "Press 1 to return to city A." ;s
 if s =1 then
 goto 900
 end if


900 CLS

Print " ('A)" ;a
print "     {'C}" ;r
print "       *B" ;b
print " "
 Print "    T= Train Army. (note only one army may be trained per city per turn)"
 Print "    X= Attack/Move troops."
 Print "    E= End Turn."
 930 Input "What will you do?> " ;n$
  if n$="E" then
   goto 1500
   end if
   if n$="T" then
   if t=0 then
    a=a+1
    t=1
    goto 905
   end if
   if t=1 Then
    print "You have already Trained an army in this city this turn."
    goto 930
   end if
end if
 if n$="X" then
  Input "What City?> " ;g$
   IF g$= "C" then
    Input " How many armies will you send? > " ;v
     a=a-v
     r=r+v
     goto 900
  end if
  if g$= "B" then
   Print "  You can only attack or move to cities adjacent to you."
   goto 930
end if

  end if

 1500 cls
Print " "
Print " 'A" ;a
print "     {'C}" ;r
print "       *B" ;b
print " "
 Input "Player B it is your turn. Press B to Start turn." ;n$
  If n$="B" then
   Goto 1550
 end if
 goto 1500

 1550 cls
 t=0
 1555 CLS
 print " "
 Print " 'A" ;a
 print "    {'C}" ;r
print "      (*B)" ;b
print ""
 Print "    T= Train Army. (note only one army may be trained per city per turn)"
 Print "    X= Attack/Move troops."
 Print "    E= End Turn."
1530 Input "What will you do?> " ;n$
  if n$="T" then
   if t=0 then
    b=b+1
    t=1
    goto 1555
   end if
   if t=1 Then
    print "You have already Trained an army in this city this turn."
    goto 1530
   end if
end if
 if n$="X" then
  Input "What City?> " ;g$
   IF g$="C" then
   1559 Input "How many armies will you send?> " ;y
     if r>b then
      Print "You don't have that many armies."
      goto 1530
      end if
      goto 1575

    1575 g=RND ((1)+1*y)
     d=RND ((1)+1*r)
      If g>d then
       b=b-y
       y=y*.75
       goto 1555
       end if
      if g<=d then
       b=b-y*.50
       r=r*.50
       goto 1555
       end if
       end if
end if

if n$="E" then
 goto 1600
 end if
 goto 1555

1600 cls
 Print " 'A" ;a
print "     'C" ;r
print "       *B" ;b
print " "
Input "Player A it is your turn, Select your City. > " ;n$
 if n$="A" then
  goto 1700
 end if
 if n$="C" then
 goto 5000
 end if
 goto 1600


 1700 CLS
 t=0
 1705 cls
 Print " ('A)" ;a
print "     'C" ;r
print "       *B" ;b
print " "
 Print "    T= Train Army. (note only one army may be trained per city per turn)"
 Print "    X= Attack/Move troops."
 Print "    E= End Turn."
 print "    C= Return to City selection."
 1730 Input "What will you do?> " ;n$
  if n$="E" then
   goto 2000
   end if
   if n$="T" then
   if t=0 then
    a=a+1
    t=1
    goto 1705
   end if
   if t=1 Then
    print "You have already Trained an army in this city this turn."
    goto 1730
   end if
end if
 if n$="X" then
  Input "What City?> " ;g$
   IF g$= "C" then
    Input " How many armies will you send? > " ;v
     a=a-v
     r=r+v
     goto 1705
  end if
  if g$= "B" then
   Print "  You can only attack or move to cities adjacent to you."
   goto 1730
end if

  end if
  if n$="C" then
   goto 1600
   end if

5000 CLS
t=0
5005 cls

Print " 'A" ;a
print "    ('C)" ;r
print "       *B" ;b
print " "
 Print "    T= Train Army. (note only one army may be trained per city per turn)"
 Print "    X= Attack/Move troops."
 Print "    E= End Turn."
 print "    C= Return to City selection."
 5030 Input "What will you do?> " ;n$
  if n$="E" then
   goto 2000
   end if
   if n$="T" then
   if t=0 then
    r=r+1
    t=1
    goto 5005
   end if
   if t=1 Then
    print "You have already Trained an army in this city this turn."
    goto 5030
   end if
end if
 if n$="X" then
  Input "What City?> " ;g$
   IF g$= "A" then
    Input " How many armies will you send? > " ;v
     a=a+v
     r=r-v
     goto 5005
  end if
  if g$= "B" then
    5075 Input "How many armies will you send?> " ;v
      if v>r then
      Print "You don't have that many armies."
      goto 5075
      end if
      GOTO 5100
    5100  g=RND ((1)+1*v)
     d=RND ((1)+1*b)
      If g>d then
       r=r-v
       v=v*.75
       goto 1000
       end if
      if g<=d then
       r=r-v*.50
       b=b*.50
       goto 5005
       end if
       end if

  end if
  if n$="C" then
   goto 1600
   end if

   goto 5005


1805 cls

Print " 'A" ;a
print "    {*C}" ;y
print "       *B" ;b
print " "
print "You have conquered city C"
Print "It will be in {civil unrest} for 1 turn, then u may select it."
Input "Press 1 to return to city B." ;s
 if s =1 then
 goto 1900
 end if

r=5
b=10
1900 CLS

print " "
 Print " 'A" ;a
 print "    {*C}" ;y
print "      (*B)" ;b
print ""
 Print "    T= Train Army. (note only one army may be trained per city per turn)"
 Print "    X= Attack/Move troops."
 Print "    E= End Turn."
1930 Input "What will you do?> " ;n$
  if n$="T" then
   if t=0 then
    b=b+1
    t=1
    goto 1900
   end if
   if t=1 Then
    print "You have already Trained an army in this city this turn."
    goto 1930
   end if
end if
 if n$="X" then
  Input "What City?> " ;g$
   IF g$="C" then
   1959 Input "How many armies will you send?> " ;w
     if Y>b then
      Print "You don't have that many armies."
      goto 1930
      end if
    y=y+w
    b=b-w
    goto 1900
    end if
end if
  IF n$="A" then
   Print "You can only attack or move troops to cities adjacent to you."
   goto 1930
   end if

if n$="E" then
 goto 3000
 end if


 3000 cls

print " "
 Print " 'A" ;a
 print "    {*C}" ;y
print "      *B" ;b
print ""
input "Player A it is your turn, Press A to start." ;n$
 if n$="A" then
  goto 3021
 end if
 goto 3000

3021 cls
t=0
3025 CLS

Print " "
  Print "   ('A)" ;a
  print "       {*C}" ;y
   Print "       *B" ;b
  Print " "
 Print "    T= Train Army. (note only one army may be trained per city per turn)"
 Print "    X= Attack/Move troops."
 Print "    E= End Turn."
 3030 Input "What will you do?> " ;n$
  if n$="T" then
   if t=0 then
    a=a+1
    t=1
    goto 3025
   end if
   if t=1 Then
    print "You have already Trained an army in this city this turn."
    goto 3030
   end if
end if
 if n$="X" then
  Input "What City?> " ;g$
   IF g$="B" then
    print "You can only attack or send troops to cities adjacent to you."
    goto 3030
    end if
    if g$="C" then
     3035 Input "How many armies will you send?> " ;r
      if r>a then
      Print "You don't have that many armies."
      goto 3035
      end if

      g=RND((1)+1*r)
      d=RND((1)+1*y)
      If g>d then
       a=a-r
       r=r*.75
       goto 1300
       end if
      if g<=d then
       a=a-r*.50
       Y=Y*.50
       goto 3025
       end if
       end if

end if

if n$="E" then
 goto 4000
 end if

2000 CLS
t=0
 Print " 'A" ;a
print "     'C" ;r
print "       *B" ;b
print " "
input "Player B it is your turn, Press B to start." ;n$
 if n$="B" then
  goto 2005
  end if
  goto 2000

2005 cls

 Print " 'A" ;a
print "     'C" ;r
print "       *B" ;b
print " "
 Print "    T= Train Army. (note only one army may be trained per city per turn)"
 Print "    X= Attack/Move troops."
 Print "    E= End Turn."
 2030 Input "What will you do?> " ;n$
  if n$="E" then
   goto 1700
   end if
   if n$="T" then
   if t=0 then
    b=b+1
    t=1
    goto 2005
   end if
   if t=1 Then
    print "You have already Trained an army in this city this turn."
    goto 1730
   end if
end if
 if n$="X" then
  Input "What City?> " ;g$
   IF g$= "C" then
    Input " How many armies will you send? > " ;y
      if y>b then
      Print "You don't have that many armies."
      goto 2030
      end if

      g=RND((1)+1*y)
     d=RND((1)+1*r)
      If g>d then
       b=b-y
       y=y*.75
       goto 1805
       end if
      if g<=d then
       b=b-y*.50
       r=r*.50
       goto 3025
       end if
       end if
  end if
  if g$= "A" then
   Print "  You can only attack or move to cities adjacent to you."
   goto 2030
end if


4000 CLS

Print " "
  Print "   'A" ;a
  print "       *C" ;y
   Print "       *B" ;b
  Print " "
input "Player B it is your turn, Select your city." ;n$
 if n$="B" then
  goto 4100
  end if

 if n$="C" then
  goto 4200
 end if

 4100 cls
  t=0

 4105 cls

print " "
 Print " 'A" ;a
 print "    *C" ;y
print "      (*B)" ;b
print ""
 Print "    T= Train Army. (note only one army may be trained per city per turn)"
 Print "    X= Attack/Move troops."
 Print "    E= End Turn."
 print "    C= Return to city selection."
4130 Input "What will you do?> " ;n$
  if n$="C" then
   goto 4000
   end if
   if n$="T" then
   if t=0 then
    b=b+1
    t=1
    goto 4105
   end if
   if t=1 Then
    print "You have already Trained an army in this city this turn."
    goto 4130
   end if
end if
 if n$="X" then
  Input "What City?> " ;g$
   IF g$="C" then
   4159 Input "How many armies will you send?> " ;w
     if w>b then
      Print "You don't have that many armies."
      goto 4130
      end if
      GOTO 4167
   4167 y=y+w
    b=b-w
    goto 4105
    end if
end if
  IF n$="A" then
   Print "You can only attack or move troops to cities adjacent to you."
   goto 4130
   end if

if n$="E" then
 goto 4300
 end if

GOTO 4105


4200 CLS
t=0
4205 cls


print " "
 Print " 'A" ;a
 print "    (*C)" ;y
print "      *B" ;b
print ""
 Print "    T= Train Army. (note only one army may be trained per city per turn)"
 Print "    X= Attack/Move troops."
 Print "    E= End Turn."
 print "    C= Return to city selection."
4230 Input "What will you do?> " ;n$
  IF n$="C" then
   goto 4000
   end if
  if n$="T" then
   if t=0 then
    y=y+1
    t=1
    goto 4205
   end if
   if t=1 Then
    print "You have already Trained an army in this city this turn."
    goto 4230
   end if
end if
 if n$="X" then
  Input "What City?> " ;g$
   IF g$="B" then
   4259 Input "How many armies will you send?> " ;w
     if w>y then
      Print "You don't have that many armies."
      goto 4230
      end if
    y=y-w
    b=b+w
    goto 4205
    end if
end if
 4240 IF g$="A" then
     Input " How many armies will you send? > " ;w
      if w>y then
      Print "You don't have that many armies."
      goto 4240
      end if
      GOTO 4275

     4275 g=RND((1)+1*w)
     d=RND((1)+1*a)
      If g>d then
       y=y-w
       w=w*.75
       goto 1100
       end if
      if g<=d then
       y=y-w*.50
       a=a*.50
       goto 4205
       end if
       end if
if n$="E" then
 goto 4300
 end if
GOTO 4205

4300 CLS
t=0
Print " "
  Print "   'A" ;a
  print "       *C" ;y
   Print "       *B" ;b
  Print " "
input "Player A it is your turn, Press A to start." ;n$
 if n$="A" then
  goto 4305
  end if
goto 4300

4305 cls


print " "
 Print " ('A)" ;a
 print "    *C" ;y
print "      *B" ;b
print ""
 Print "    T= Train Army. (note only one army may be trained per city per turn)"
 Print "    X= Attack/Move troops."
 Print "    E= End Turn."
 print "    C= Return to city selection."
4330 Input "What will you do?> " ;n$
  if n$="T" then
   if t=0 then
    a=a+1
    t=1
    goto 4305
   end if
   if t=1 Then
    print "You have already Trained an army in this city this turn."
    goto 4330
   end if
end if
 if n$="X" then
  Input "What City?> " ;g$
   IF g$="B" then
    Print "You can only attack or move troops to cities adjacent to yours."
    goto 4330
    end if
 4340 IF g$="C" then
     Input " How many armies will you send? > " ;r
      if r>a then
      Print "You don't have that many armies."
      goto 4340
      end if

      g=RND((1)+1*r)
     d=RND((1)+1*y)
      If g>d then
       a=a-v
       r=r*.75
       goto 1300
       end if
      if g<=d then
       a=a-r*.50
       y=y*.50
       goto 4305
       end if
       end if
       end if
if n$="E" then
 goto 4000
 end if
GOTO 4305
