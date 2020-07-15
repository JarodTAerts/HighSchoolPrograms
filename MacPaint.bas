'****************************************************Start of MacPaint*********************************************************** 
w=750
cc=10
 on error goto (start)
 
 filen$= "/Applications/Macpaint/data/number.inf"
 filesaves$= "/Applications/Macpaint/data/saves.inf"
start:
cls
graphics 0

macfunction("wintitle", "MacPaint")

graphics window 875,500

'******************************Draw Gray Back round*******************************
500 if saved=1 then
graphics PICT 0,76, file$
saved=0
file$=" "
end if
graphics color 75,75,75
graphics fillrect 0,0,1000,75
graphics fillrect 751,75,1000,500

' ***************************Draws White bacround for small circle pen box************
graphics color 100,100,100
graphics fillrect 51,11,99,59
' ************************** Draws rectangle around small circle pen box********************
graphics color 0,0,0
graphics rect 50,10,100,60

'***************************** draws small circle pen inside box***************************
for v=1 to 10
moveto 75,35
graphics circle v
next v

' ****************************** Draws white backrounds for all the other boxes that are not color filled****************
graphics color 100,100,100
graphics fillrect 151,11,199,59
graphics fillrect 101,11,149,59
graphics fillrect 201,11,249,59
graphics fillrect 651,11,699,59
graphics fillrect 701,11,749,59
graphics fillrect 750,101,800,149
graphics fillrect 750,151,800,199
graphics fillrect 800,100,850,150
graphics fillrect 800,150,850,200
graphics fillrect 750,50,850,100
graphics fillrect 775,0,825,50
graphics rect 4,14,46,56

'******************************** Draws outlining rectangle for large circle pen box and other boxes also***************************
graphics color 0,0,0
graphics rect 150,10,200,60
graphics rect 700,10,750,60
graphics rect 800,100,850,150
graphics rect 805,115,845,135
graphics rect 800,150,850,200
moveto 825,155
lineto 805,195
lineto 845,195
lineto 825,155
graphics rect 750,50,850,100
graphics rect 775,0,825,50
moveto 775,50: lineto 775,100
moveto 825,50: lineto 825,100
graphics textsetup 1,25,1
moveto 757,82
graphics drawtext "-"
moveto 830,82
graphics drawtext "+"
moveto 780,85
graphics drawtext str$(cc)
moveto 800,25
 
for v=1 to cc
graphics circle v
next v

'******************************** draws large circle pen in its box*******************
for v=1 to 25
moveto 175,35
graphics circle v
next v

'********************************* Draws black rectangle for color selection**************************
graphics fillrect 250,10,300,60
graphics color 0,0,0

'********************************** Draws Dividing lines for the right boundry of the screen*****************
moveto 750,75
lineto 750,500
'*************************************************** Draws Boxes for line and circle selection****************************
graphics rect 750,100,800,150
'******************************************************Draws line inside of line button box*************************************
moveto 755,105
lineto 795,145
graphics rect 750,150,800,200
moveto 775,175
'*******************************************************Draws circle inside of circle button box*******************************
graphics circle 35

'************************************************** Draws rectangles for custom color selection***********************

'*********************************************Red +1 *************************************************
graphics color 100,0,0
graphics fillrect 750+1,250,750+(100/3),250+(100/3)                                                   
'*********************************************Green +1 *************************************************
graphics color 0,100,0
graphics fillrect 750+(100/3)+6,250,750+(100/3*2)+6,250+(100/3)                                         
'**********************************************Blue +1 *************************************************
graphics color 0,0,100
graphics fillrect 750+(100/3*2)+11,250,750+(100/3*3)+11,250+(100/3)                                     
'********************************************Just a random color statement.....**************************************
graphics color cr,cg,cb                                                                                              
'**********************************************Red -1 *******************************************************
graphics color 100,0,0
graphics fillrect 750+1,375,750+(100/3),375+(100/3)                                                          
'***********************************************Green -1 ****************************************************
graphics color 0,100,0
graphics fillrect 750+(100/3)+6,375,750+(100/3*2)+6,375+(100/3)                                              
'*************************************************Blue -1 ****************************************************
graphics color 0,0,100
graphics fillrect 750+(100/3*2)+11,375,750+(100/3*3)+11,375+(100/3)                                           
'**************************************************Draws Big rectangle in the middle with the custom color, will be black since cr,cg,and cb all =0***********************************************************
graphics color cr,cg,cb
Graphics fillrect 775+6,300,825+6,350


'**************************************************Draws rectangles for preset color selection***********************************

'*****************************************************Black***************************************
graphics color 0,0,0
graphics rect 300,10,350,60
'****************************************************White***************************************************************
graphics color 100,100,100
graphics fillrect 301,11,349,59
'***************************************************Red******************************************************************
graphics color 100,0,0
graphics fillrect 350,10,400,60
'**************************************************Green**************************************************************
graphics color 0,100,0
graphics fillrect 450,10,500,60
'****************************************************Blue************************************************************
graphics color 0,0,100
graphics fillrect 550,10,600,60
'****************************************************Yellow************************************************************
graphics color 100,100,0
graphics fillrect 400,10,450,60                                                                                        
'*****************************************************Purple/pinkish****************************************************
graphics color 100,0,100
graphics fillrect 500,10,550,60
'*****************************************************Pinkish*************************************************************
graphics color 100,30,0
graphics fillrect 600,10,650,60

'************************************************** draws rectangle pens in their buttons******************************
graphics color 0,0,0
graphics rect 100,10,150,60
graphics fillrect 115,25,135,45
graphics rect 200,10,250,60
graphics fillrect 210,20,240,50

'************************************************* Draws text for CLS and Custom color and Fill buttons******************************
graphics rect 650,10,700,60
graphics textsetup 1,30,1
moveto 665,45
graphics drawtext "C"
moveto 755,245
graphics drawtext "Custom"
moveto 715,45
graphics drawtext "F"
graphics textsetup 1,50,1


'************************************************************Draws the +s and -s in the boxes which control how much of each color is in the custom color*****************************************
moveto 750+8,405
graphics drawtext "-"
moveto 750+(100/3)+13,405
graphics drawtext "-"
moveto 750+(100/3*2)+18,405
graphics drawtext "-"
moveto 750,280
graphics drawtext "+"
moveto 750+(100/3)+5,280
graphics drawtext "+"
moveto 750+(100/3*2)+10,280
graphics drawtext "+"
moveto 0,75
lineto 750,75

'***********************************************************Designates the small circle pen as the default drawing pen********************************



graphics textsetup 1,30,1


'graphics 0

graphics fillrect 0,10,50,60
graphics color red,blue,g
if custom=1 then graphics color cr,cg,cb
graphics fillrect 5,15,45,55
graphics rect 4,14,46,56
'*********************************************************Checks to see if fill=1 or 0****************************************************
'********************************************************If fill=1 then it will make the fill button black with a white "F"*****************
'*********************************************************If fill=0 then it will make the fill button white with a Black "F"*****************

 if fill=0 then
 graphics color 100,100,100
 graphics fillrect 701,11,749,59
 moveto 715,45
 graphics color 0,0,0
 graphics drawtext "F"
 else
 graphics color 0,0,0
 graphics fillrect 701,11,749,59
 moveto 715,45
 graphics color 100,100,100
 graphics drawtext "F"
 end if




'***********************************************************Draws a rectangle with the custom color in the position fo the custom color button****************** 
graphics color cr,cg,cb
graphics fillrect 775+6,300,825+6,350


'**********************************************************Checks mouse cordinates for selctions beyond the 750 x cordinate*************************
if (mouse(1)>750) then

'***********************************************************************Button for +1 red in custom color*************************************
 if (mouse(1)>750+1) and (mouse(1)<750+(100/3)) and (mouse(2)>250) and (mouse(2)<250+(100/3)) and (mouse(0)=1) then
   custom=0
   print "red"
   cr=cr+1
   cg=cg
   cb=cb
    if cr=100 then
     cr=cr-1
    end if
   end if

'**********************************************************Button for +1 green in custom color**************************************************
    if (mouse(1)>750+1+(100/3)) and (mouse(1)<750+(100/3*2)) and (mouse(2)>250) and (mouse(2)<250+(100/3)) and (mouse(0)=1) then
   custom=0
   print "Green"
   cr=cr
   cg=cg+1
   cb=cb
    if cg=100 then
     cg=cg-1
    end if
   end if

'***************************************************************Button for +1 blue in custom color*****************************************
    if (mouse(1)>750+1+(100/3*2)) and (mouse(1)<750+(100/3*2*3)) and (mouse(2)>250) and (mouse(2)<250+(100/3)) and (mouse(0)=1) then
   custom=0
   print "Blue"
   cr=cr
   cg=cg
   cb=cb+1
    if cb=100 then
     cb=cb-1
    end if
   end if
    
'**********************************************************Button for -1 red in custom color*************************************************
    if (mouse(1)>750+1) and (mouse(1)<750+(100/3)) and (mouse(2)>375) and (mouse(2)<375+(100/3)) and (mouse(0)=1) then
   custom=0
   print "red"
   cr=cr-1
   cg=cg
   cb=cb
    if cr=-1 then
     cr=cr+1
    end if
   end if

'**************************************************Button for -1 green in custom color***************************************************
    if (mouse(1)>750+1+(100/3)) and (mouse(1)<750+(100/3*2)) and (mouse(2)>375) and (mouse(2)<375+(100/3)) and (mouse(0)=1) then
   custom=0
   print "Green"
   cr=cr
   cg=cg-1
   cb=cb
    if cg=-1 then
     cg=cg+1
    end if
   end if

'****************************************************Button for -1 Blue in custom color**************************************************
    if (mouse(1)>750+1+(100/3*2)) and (mouse(1)<750+(100/3*2*3)) and (mouse(2)>375) and (mouse(2)<375+(100/3)) and (mouse(0)=1) then
   custom=0
   print "Blue"
   cr=cr
   cg=cg
   cb=cb-1
    if cb=-1 then
     cb=cb+1
    end if
   end if


'***************************************************Button selection that selects the custom color you may or may not have made******************
   if (mouse(1)>775+6) and (mouse(1)<825+6) and (mouse(2)>300) and (mouse(2)<350) and (mouse(0)=1) then
   custom=1
   end if

'*************************************************************Button selection for drawinf circles******************************************
   if (mouse(1)>750) and (mouse(1)<800) and (mouse(2)>150) and (mouse(2)<200) and (mouse(0)=1) then
   circle =1
   print "circle"
   c=0
   s=0
   l=0
   for i=1 to 100
   print i
   next i
   end if
   
   '***************************************************Line selection button**************************************************************

   if (mouse(1)>750) and (mouse(1)<800) and (mouse(2)>100) and (mouse(2)<150) and (mouse(0)=1) then
   l=1
   c=0
   s=0
   line3=0
   h=0
   for d=1 to 100
    print d
   next d
   end if


'*****************************************************************Button selction for drawing rectangles*********************************
    if (mouse(1)>800) and (mouse(1)<850) and (mouse(2)>100) and (mouse(2)<150) and (mouse(0)=1) then
   rectangle =1
   c=0
   s=0
   print "rect"
   for i=1 to 100
    print i
   next i
   end if
   
'***************************************************************Button selection for drawing Triangles*************************************
 if (mouse(1)>800) and (mouse(1)<850) and (mouse(2)>150) and (mouse(2)<200) and (mouse(0)=1) then
   triangle =1
   c=0
   s=0
   print "triangle"
   for i=1 to 100
    print i
   next i
   end if
   
'*************************************************************Custom pen stuff*********************************************
  if (mouse(1)>750) and (mouse(1)<775) and (mouse(2)>50) and (mouse(2)<100) and (mouse(0)=1) then
   cc=cc-1
   for v=1 to 1000000:next v
   end if
   
  if (mouse(1)>825) and (mouse(1)<850) and (mouse(2)>50) and (mouse(2)<100) and (mouse(0)=1) then
   cc=cc+1
   for v=1 to 1000000:next v
   end if
   
  if (mouse(1)>775) and (mouse(1)<825) and (mouse(2)>0) and (mouse(2)<50) and (mouse(0)=1) then
   cpen=1
   end if 
   

  if cc=0 then cc=cc+1
  if cc=51 then cc=cc-1
   

end if



'******************************************************************Checks mouse position and selection for buttons under the 75Y line**************************************************************



'****************************************************************** Button for small square pen******************************************

   if (mouse(1)>100) and (mouse(1)<150) and (mouse(2)>0) and (mouse(2)<60) and (mouse(0)=1) then
   r=10
   s=1
   c=0
   l=0
   cpen=0
   end if


'************************************************************ Button for Large square pen***************************************************

   if (mouse(1)>200) and (mouse(1)<250) and (mouse(2)>0) and (mouse(2)<60) and (mouse(0)=1) then
   r=15
   s=1
   c=0
   l=0
   cpen=0
   end if
   
   '**********************************************************Button for large Circle pen********************************************

    if (mouse(1)>150) and (mouse(1)<200) and (mouse(2)>0) and (mouse(2)<60) and (mouse(0)=1) then
   r=25
   c=1
   s=0
   l=0
   cpen=0
   end if
   
   '*********************************************************Button for small circle pen************************************************

    if (mouse(1)>50) and (mouse(1)<100) and (mouse(2)>0) and (mouse(2)<60) and (mouse(0)=1) then
   r=10
   c=1
   s=0
   l=0
   cpen=0
   end if
   
   '***********************************************************Fill button, i wouldnt mess with this if i was you***********************************

     if (mouse(1)>700) and (mouse(1)<750) and (mouse(2)>0) and (mouse(2)<60) and (mouse(0)=1) or (macfunction ("keydown",55)) and (macfunction ("keydown",3)=1) then
      if fill=0 then
      fill=1
      for e=1 to 75
      print e
      next e
      goto fill1
      else
      fill=0
      for e=1 to 75
      print e
      next e
      goto fill1
      end if
   end if
   
   

   fill1:
   
   
   '*****************************************************************End of fill button code***********************************************

'*****************************************************************Cls button, clears the painting****************************************

    if (mouse(1)>650) and (mouse(1)<700) and (mouse(2)>0) and (mouse(2)<60) and (mouse(0)=1) or (macfunction ("keydown", 55)) and (macfunction ("keydown",8)) then
    goto start
    l=0
    end if
    
 
    '*****************************************************Attempted save**************************************
    
  if (macfunction ("keydown",55)) and (macfunction ("keydown",1)) then
     for i=1 to 100 
     print i 
     next i 
     
    name$=inputbox( "What would you like to save it as?", "Save")
     print name$ 
     file$= "/Applications/Macpaint/"+name$+".pai" '3
         
        print "file=";file$
        '-----------------------------------------
         open filen$ for input as #1
         input #1, number
         dim saves$[number]
         close #1
         
         open filesaves$ for input as #1
         for i=1 to number
         input #1, saves$[i]
         next i
         close #1
         
         for i=1 to number 
          if name$= saves$[i] then
           same$=saves$[i]
          end if
          next i
        
      
        
        if same$<>name$ then
         open filesaves$ for append as #1
         print #1, name$
         close #1
         
         open filen$ for output as #1
         number=number+1
         print #1, number
         close #1
        end if
        
        '----------------------------------------- 
        
     graphics 0 
     macfunction ( "savepicture", file$ )
    
     1400 cls
     print "file=";file$
     graphics window 750,425
     graphics PICT 0,-76, file$
     graphics 0
     macfunction ( "savepicture", file$ )
    
     saved=1
     goto start
    end if
    
    '***********************************************Attempted load*****************************
      if (macfunction ("keydown",55)) and (macfunction ("keydown",37)) then
      for i=1 to 100
      print i
      next i
      filen$="/Applications/Macpaint/data/number.inf"
      filesaves$="/Applications/Macpaint/data/saves.inf"
      
      
      '-----------------------------------------------
      open filen$ for input as #1
      input #1, i
      close #1
      open filesaves$ for input as #1
      Print "------Files in Directory-------"
      for saves=1 to i 
      input #1, save$
      print save$
      next saves
      close #1
      '-----------------------------------------------
      
     name$=inputbox( "Which file would you like to load?", "Load")
      
      file$="/Applications/Macpaint/"+name$+".pai"
      saved=1
      goto start
      end if
'******************************************************************Preset black selection***************************************************

    if (mouse(1)>250) and (mouse(1)<300) and (mouse(2)>0) and (mouse(2)<60) and (mouse(0)=1) then
   red=0
   blue=0
   g=0
   custom=0
   end if



'************************************************************************Preset Red selection***********************************************

   if (mouse(1)>350) and (mouse(1)<400) and (mouse(2)>0) and (mouse(2)<60) and (mouse(0)=1) then
   red=100
   blue=0
   g=0
   custom=0
   end if

'************************************************************Preset Blue Button*******************************************************

   if (mouse(1)>450) and (mouse(1)<500) and (mouse(2)>0) and (mouse(2)<60) and (mouse(0)=1) then
   red=0
   blue=100
   g=0
   custom=0
   end if


'**************************************************************Preset green button*************************************************

   if (mouse(1)>550) and (mouse(1)<600) and (mouse(2)>0) and (mouse(2)<60) and (mouse(0)=1) then
   red=0
   blue=0
   g=100
   custom=0
   end if
   
   '**********************************************************Preset white selection***********************************************

 if (mouse(1)>300) and (mouse(1)<350) and (mouse(2)>0) and (mouse(2)<60) and (mouse(0)=1) then
   red=100
   blue=100
   g=100
   custom=0
   end if
   
   '**********************************************************Preset Purple/pink selection*******************************************

  if (mouse(1)>400) and (mouse(1)<450) and (mouse(2)>0) and (mouse(2)<60) and (mouse(0)=1) then
   red=100
   blue=100
   g=0
   custom=0
   end if
   
   '*******************************************************************Preset Yellow Selection****************************************

   if (mouse(1)>500) and (mouse(1)<550) and (mouse(2)>0) and (mouse(2)<60) and (mouse(0)=1) then
   red=100
   blue=0
   g=100
    custom=0
   end if
   
   '*****************************************************************Preset Pink selection***********************************************

   if (mouse(1)>600) and (mouse(1)<650) and (mouse(2)>0) and (mouse(2)<60) and (mouse(0)=1) then
   red=100
   blue=30
   g=0
    custom=0
   end if





'********************************************Changes the color for drawing to the one you have selected********************************************
 graphics color red,blue,g
 '*****************************************If you have chosen a custom made color it will now change the draw color to that******************************
  if custom=1 then
   graphics color cr,cg,cb
  end if
  
  


'********************************************************Start of Drawing portion of the program********************************************
'***********************************************From here down it read variables and draws shapes acording to your selections*****************

'**************************************************Reads if mouse is out of selection areas********************************************

'**************************************************reads if mouse is pressed or not***************************************************
 if mouse(0)=1 then
 '******************************************************Moves to the x,y position of the mouse to be ready to draw*****************************
 
 moveto mouse(1), mouse(2)
 
 


  ' ******************************************************** Circle creation, Rather complex will not go over every step***************************************************
  if circle =1 then
  while x1=0
  for i=1 to 100: next i
  if mouse(0)=1 then
  x1=mouse(1)
  y1=mouse(2)
  pset x1,y1
  end if
  wend
  for  h=1 to 100
  print h
  next h
  while x2=0
  print 2
  for i=1 to 1000:next i
  if mouse(0)=1 then
  x2=mouse(1)
  y2=mouse(2)
  pset x2,y2
  end if
  wend
  if x1>x2 then
  a=x1-x2
  else
  a=x2-x1
  end if
  if y1>y2 then
  b=y1-y2
  else
  b=y2-y1
  end  if
  o= 2*(sqr(a^2+b^2))

  if fill=0 then
  moveto x1,y1
  graphics circle o
  graphics color 100,100,100
  pset x1,y1
  graphics color red,blue,g
  end if
  if fill=1 then
  moveto x1,y1
  for diameter=1 to o
   graphics circle diameter
  next diameter
  end if
  x1=0
  x2=0
  y1=0
  y2=0
  circle=0
  c=10
  print o
   
    
   
  end if
  fill=fill
  '****************************************************Rectangle creation, also rather complex*******************************************

   if rectangle =1 then
  while x1=0
  for i=1 to 100: next i
  if mouse(0)=1 then
  x1=mouse(1)
  y1=mouse(2)
  pset x1,y1
  end if
  wend
  for  h=1 to 100
  print h
  next h
  while x2=0
  print 2
  for i=1 to 1000:next i
  if mouse(0)=1 then
  x2=mouse(1)
  y2=mouse(2)
  pset x2,y2
  end if
  wend

  print x1,y1,x2,y2

'*****************************************************Really complex part of recetangle creation*******************************************
  if fill=0 then
   if (x1<x2) and (y1<y2) then
   graphics rect x1,y1,x2,y2
   end if
   if (x2<x1) and (y1<y2) then
   graphics rect x2,y1,x1,y2
   end if
   if (x1<x2) and (y2<y1) then
   graphics rect x1,y2,x2,y1
   end if
   if (x2<x1) and (y2<y1) then
   graphics rect x2,y2,x1,y1
   end if
  end if
  if fill=1 then

   if (x1<x2) and (y1<y2) then
   graphics fillrect x1,y1,x2,y2
   end if
   if (x2<x1) and (y1<y2) then
   graphics fillrect x2,y1,x1,y2
   end if
   if (x1<x2) and (y2<y1) then
   graphics fillrect x1,y2,x2,y1
   end if
   if (x2<x1) and (y2<y1) then
   graphics fillrect x2,y2,x1,y1
   end if
  end if

  x1=0
  x2=0
  y1=0
  y2=0
  rectangle=0
  end if


  '***************************************************Line Creation*********************************************
  2000 if l=1 then

'**************************************************Checks to see if mouse is down and if it is makes that the first x,y position of the line*********************************************

   if (mouse(0)=1) and (h=0) then
    line1=mouse(1)
    line2=mouse(2)
    '****************************************Moves to the first line position and makes a small circle that so you know what where the line begins*************************************
    moveto line1,line2
    graphics circle 1
    '********************************************Prints the x,y coordinates of the first point of the line*********************************
    print line1,line2
   end if

'*************************************************Does some for next to make sure that it doesnt read your current mouse position as point 2 and draw a 1 pixel line********************************
   for h=1 to 100
    print h
    if h=100 then
    
    '**************************************************Does a while loop to wait for you to press at the secon point of the line************************
    while line3=0
     if mouse(0)=1  then
      line3=mouse(1)
      line4=mouse(2)
      '*****************************************************Finally draws the line from point line1,line2 to point line3,line4****************************************
      moveto line1,line2
      lineto line3,line4
      '*************************************************Says li=0 im not for sure if it is important so leave it alone**************************
      li=1
     end if
     '************************************************Ends the While loop***************************************
    wend
    end if

   next h
   '*****************************************************************Puts the variable that designates line drawing to 0 so things dont go crazy*******************************************
    l=0
 end if
 
 
  '***************************************************triangle Creation*********************************************
  10000 if triangle=1 then
 
'**************************************************Checks to see if mouse is down and if it is makes that the first x,y position of the line*********************************************

   if mouse(0)=1 then
    line1=mouse(1)
    line2=mouse(2)
    '****************************************Moves to the first line position and makes a small circle that so you know what where the line begins*************************************
    moveto line1,line2
    graphics circle 1
    '********************************************Prints the x,y coordinates of the first point of the line*********************************
    print line1,line2
   end if

'*************************************************Does some for next to make sure that it doesnt read your current mouse position as point 2 and draw a 1 pixel line********************************
   for h=1 to 100
    print h
    if h=100 then
    
    '**************************************************Does a while loop to wait for you to press at the second point of the line************************
    while line3=0
     if mouse(0)=1  then
      line3=mouse(1)
      line4=mouse(2)
      '*****************************************************Finally draws the line from point line1,line2 to point line3,line4****************************************
      moveto line1,line2
      lineto line3,line4
  
    
     end if
     '************************************************Ends the While loop***************************************
    wend
    end if

   next h
   
   
      for h=1 to 100
    print h
    if h=100 then
    print line3,line4
    '**************************************************Does a while loop to wait for you to press at the secon point of the line************************
    while line5=0
     if mouse(0)=1  then
      line5=mouse(1)
      line6=mouse(2)
      '*****************************************************Finally draws the line from point line1,line2 to point line3,line4****************************************
      moveto line3,line4
      lineto line5,line6
      lineto line1,line2
      
      
      
     end if
     '************************************************Ends the While loop***************************************
     wend
    end if

   next h
   
   if fill=1 then
   graphics triangle line1,line2,line3,line4,line5,line6
   end if
   
   '*****************************************************************Puts the variable that designates line drawing to 0 so things dont go crazy*******************************************
    triangle=0
    h=0
    line1=0
    line2=0
    line3=0
    line4=0
    line5=0
    line6=0
    
 end if


  '****************************************************circle and square pen creation*****************************************************
  '****************************************************Circle Creation*****************************************************
  
  if cpen=1 then r=cc
  
  if c=1 then
  for n=1 to r
  graphics circle n
  next n
  end if
  
  '*****************************************************Square Creation********************************************************
  if s=1 then
   graphics fillrect mouse(1)-r,Mouse(2)-r,mouse(1)+r,mouse(2)+r
   end if
 end if



goto 500
