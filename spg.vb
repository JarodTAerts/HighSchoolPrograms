
a=4
x=2
k=1

Print " "
Print " A" ;a
Print " S" ;x
Print " T" ;k
print "Your city is A"
50 INput "select your city.." ;n$
 if n$="a" then
  goto 100
 end if
If n$="S" then
 print "That isnt your city yet."
 goto 50
end if
If n$="T" then
 Print "That isnt your city yet."
 goto 50
end if


100 cls

Print " "
Print " (A)" ;a
Print " S" ;x
Print " T" ;k
print "What would you like to do."
Print "T=Train troops, you may only train 1 unit per turn."
Print "X= Attack or move"
INput "what will you do?" ;n$
 if n$="T" then
  a=a+1
  goto 100
 end if
 if n$="X" then
  175 Input "What city will you attack?" ;s$
   if s$="S" then
    300 INput "How many armies will you send?" ;e
     if e>a then
      Print "You dont have that many armies."
      goto 300
     end if
     end if
     If s$="T" then
      Print "You can only attack cities adjacent to you."
      goto 175
      end if
     end if

     G=RND(1)*e
     B=RND(1)*x
     if G>B then
      a=a-e
      goto 200
     end if
     if G<B then
      a=a-e
      goto 100
      a=a-e
     end if

200 cls

 Print " "
Print " A" ;a
Print " 'S" ;e
Print " T" ;k
print "You have conquered City S, Conquered cities will have ' before them."
Print "You can now select city S and train units there."
Input "Select your city." ;n$
 if n$="A" then
  goto 475
 end if
 if n$="S" then
  goto 575
 end if
 if n$="T" then
  Print "You dont own that city yet."
  goto 200
 end if

  print "That isnt an option."
  goto 200

 400 cls
   a=a-i
    e=e+i
 475 cls
 Print " "
Print " (A)" ;a
Print " 'S" ;e
Print " T" ;k
print "What would you like to do."
Print "T=Train troops, you may only train 1 unit per turn."
Print "X= Attack or move"
Print "C= Return to City selection"
INput "what will you do?" ;n$
 if n$="T" then
  a=a+1
  goto 475
 end if
 if n$="X" then
  450 Input "Which city?" ;d$
   If d$="S" then
    input "How many armies?" ;i
     goto 400
  end if
  end if
  if n$="C" then
   goto 200
   a=a
   e=e
   end if

   if d$="T" then
   print "you can only send or attack to cities adjacent to you."
   goto 450
  end if
  goto 400



500 cls
 e=e-i
  a=a+i
  575 cls
  Print " "
Print " A" ;a
Print " ('S)" ;e
Print " T" ;k
print "What would you like to do."
Print "T=Train troops, you may only train 1 unit per turn."
Print "X= Attack or move"
Print "C= Return to City Selection"
INput "what will you do?" ;n$
 if n$="T" then
  e=e+1
  goto 575
 end if
 if n$="X" then
  550 Input "Which city?" ;d$
   If d$="A" then
    input "How many armies?" ;i
     goto 500
  end if
  end if

  if n$="C" then
   goto 200
   a=a
   e=e
   end if

  if d$="T" then
 600 INput "How many armies will you send?" ;j
     if j>e then
      Print "You dont have that many armies."
      goto 600
     end if
     end if

     G=RND(1)*e
     B=RND(1)*x
     if G>B then
      goto 700
     end if
     if G<B then
      goto 500
      a=a-e
     end if

     goto 500


700 cls
e=e-j
Print " A" ;a
Print " 'S" ;e
Print " 'T" ;j
 Print " You have conquered all the enemies on the map."
 Print "Congradulations!"


