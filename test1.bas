REM Start of BASIC! Program

! Open the acclerometer sensor
SENSORS.OPEN 1

! Open Graphics
GR.OPEN 255,100,100,100
GR.ORIENTATION 0


! Get screen size paramters
GR.SCREEN w,hi
gr.text.size hi/10
gr.color 255,255,0,0,1
gr.text.draw n,w/3,hi/2,"Loading........"
gr.render

! Calculate screen center x, y
cx = w/2
cy = hi/2

playerattack=5
playerarmor=1
playermoney=50
playerhealth=35

dim inv[21]
dim invenobj[21]
dim weapon[5]
dim weaponattack[5]
dim equip[2]
dim equipobj[3]
inventoryn=13
inven=inventoryn/4
inventoryr=inventoryn
print inventoryn
print inven

for i=1 to inventoryn
random=rnd()*15
if 3<random<6 then invenobj[i]=2
if random<3 then invenobj[i]=1
if random<9 then 
if random>6 then
invenobj[i]=3
end if
end if
if random<12 then
if random>9 then
 invenobj[i]=4
end if
end if
if random<16 then
if random>12 then
 invenobj[i]=5
end if
end if
print "rnd:";random
print invenobj[i]
next i


!-------------------------------LOads and scales the bitmaps that are used-------

gr.bitmap.load ma, "map.BMp"
gr.bitmap.scale map,ma,hi*4,hi*2.5
gr.bitmap.load hor, "horse.png"
gr.bitmap.scale horse,hor, hi/10,hi/10
gr.bitmap.load hor2, "horse2.png"
gr.bitmap.scale horse2,hor2, hi/10,hi/10
gr.bitmap.load cit, "city.png"
gr.bitmap.scale cite,cit, w, hi
gr.bitmap.load cas, "castle.png"
gr.bitmap.scale castl,cas, w, hi
gr.bitmap.load par, "party.png"
gr.bitmap.scale party,par, w, hi
gr.bitmap.load but, "button.bmp"
gr.bitmap.scale button,but, hi/5,hi/10 
gr.bitmap.load in, "inventory.png"
gr.bitmap.scale inventori,in,w,hi
gr.bitmap.load vill, "village.png"
gr.bitmap.scale village,vill,w,hi
gr.bitmap.load a, "2axe.png"
gr.bitmap.scale weapon[1],a,hi*0.19,hi*0.19
weaponattack[1]=12
gr.bitmap.load d, "dagger.png"
gr.bitmap.scale weapon[2],d,hi*0.19,hi*0.19
weaponattack[2]=5
gr.bitmap.load l, "longsword.png"
gr.bitmap.scale weapon[3],l,hi*0.19,hi*0.19
weaponattack[3]=11
gr.bitmap.load s, "shortsword.png"
gr.bitmap.scale weapon[4],s,hi*0.19,hi*0.19
weaponattack[4]=9
gr.bitmap.load x, "axe.png"
gr.bitmap.scale weapon[5],x,hi*0.19,hi*0.19
weaponattack[5]=7





!--------------------Sets variable values that will be used in the program
xx=0
yy=0
sx=cx
sy=cy
tx=cx
ty=cy
cityl=1.025*hi
cityt=0.56*hi
cityr=1.28*hi
cityb=0.675*hi
dim leave [4]
leave[1]=0.35625*w
leave[2]=0.83*hi
leave[3]=0.63125*w
leave[4]=0.93*hi
dim market [4]
market[1]=0.325*w
market[2]=0.67*hi
market[3]=0.6625*w
market[4]=0.73*hi
dim tavern [4]
tavern[1]=0.35625*w
tavern[2]=0.76*hi
tavern[3]=0.625*w
tavern[4]=0.83*hi

dim castle [4]
castle[1]=2.485*hi
castle[2]=1.415*hi
castle[3]=2.665*hi
castle[4]=1.525*hi

dim Pexit [4]
Pexit[1]=0
Pexit[2]=hi-hi/8
Pexit[3]=hi/2.5
Pexit[4]=hi
dim Pinventory [4]
Pinventory[1]=w-hi*0.75
Pinventory[2]=hi-hi/8
Pinventory[3]=w
Pinventory[4]=hi
 dim Iexit [4]
 Iexit[1]=w/2-hi/3
 Iexit[2]=hi-hi/5.5
 Iexit[3]=w/2-hi/15
 Iexit[4]=hi-hi/9.5
 dim Iquit [4]
 Iquit[1]=w/2-hi/3
 Iquit[2]=hi-hi/11
 Iquit[3]=w/2-hi/15
 Iquit[4]=hi-hi/40

dim village [4]
village[1]=3.035*hi
village[2]=1.01*hi
village[3]=3.16*hi
village[4]=1.055*hi


!-------------Displays message on the scree until you touch the screen--------
do
 gr.touch t,x,y
 gr.text.draw n,0,cy,"Touch the screen to begin."
 gr.render
 gr.cls
until t=1

input "Name:",playername$

!---------------------sets the oritenataion of the screen to landscape
gr.orientation 0

!----------------------position that the program goes to when you exit a screen
leave:

!------------------------------------Draws bitmaps and objects and hides some
gr.bitmap.draw maps,map,xx,yy
gr.color 255,0,0,0,1
gr.circle travelp,tx,ty,20
gr.hide travelp
gr.bitmap.draw h,horse,xx+sx,yy+sy
gr.bitmap.draw ho2,horse2,xx+sx,yy+sy
gr.hide ho2
gr.bitmap.draw bu,button,w-hi/5+1,0
gr.color 255,255,0,0,1
gr.rect k,0,0,cy/5,cy/5
gr.color 255,0,0,255,0
gr.rect h2,xx+sx,yy+sy, xx+sx+cy/5, yy+sy+cy/15
gr.color 255,0,0,0,1
gr.rect k2,0,0,cy/5,cy/5
gr.text.size hi/20
gr.text.draw pname,xx+sx,yy+sy,playername$

gr.text.size hi/10
! The main program loop
DO

!------------------------------modifies the positons of some of the objects
gr.modify maps,"x", xx
gr.modify maps,"y", yy
gr.modify h,"x", xx+sx 
gr.modify h,"y", yy+sy 
gr.modify ho2,"x", xx+sx 
gr.modify ho2,"y", yy+sy 
gr.modify h2,"left", xx+sx 
gr.modify h2,"top", yy+sy 
gr.modify h2,"right", xx+sx+cy/5 
gr.modify h2,"bottom", yy+sy+cy/5 
gr.modify pname,"x",xx+sx
gr.modify pname, "y",yy+sy
gr.modify travelp, "x", xx+tx-xx
gr.modify travelp, "y", yy+ty-yy

!-------------------------reads your touch for maps movemenet and character selection
gr.touch t,tx,ty
gr.bounded.touch t2,sx+xx,sy+yy,(sx+cy/5)+xx,(sy+cy/5)+yy
gr.bounded.touch partybutton,w-hi/5,0,w,hi/10
gr.bounded.touch t3,0,0,cy/5,cy/5

!----------checks to see if you touched a button area or otherwise
if t then
 if selet=1 then
  travel=1
  gr.show travelp
 end if
end if

if t2 then
  if selet=0 then
    selet=1
    pause 200
    goto after
  end if
  if selet=1 then
    selet=0 
    tx=sx
    ty=sy
    pause 200
    goto after
  end if
end if

if t3 then
 if selet=0 then
   selet=1
   pause 200
   goto after
   end if
 if selet=1 then
   selet=0 
   tx=sx
   ty=sy
   pause 200
   goto after
 end if
end if

!------------------if you selected the party button then sends you to the party screen
if partybutton then
 gr.color 255,255,0,0,1
 gr.bitmap.draw part,party,0,0
 gr.text.size hi/10
 if equipobj[1]<>0 then
 Totalattack=playerattack+weaponattack[equipobj[1]]
 print "equip:";equipobj[1]
 gr.text.draw pattack,0.09*w,hi*0.26,format$("##",Totalattack)
 end if
 if equipobj[1]=0 then
 gr.text.draw pattack,0.09*w,hi*0.26,format$("##",playerattack)
 end if
 gr.text.draw parmor,0.09*w,hi*0.4,format$("##",playerarmor)
 gr.text.draw pmoney,0.09*w,hi*0.58,format$("###",playermoney)
 gr.text.draw phealth,0.09*w,hi*0.76,format$("###",playerhealth)
 pause 250
 goto party
end if

!--------------------after goto, im sure it does something
after:

!------------shows and hides a blue rectangle around your character if you have
!him selected and a red rectagle in the upper left corner

if selet=1 then
  gr.show h2
  gr.hide k2
  gr.show k
 else
  gr.hide h2
  gr.hide k
  gr.show k2
 travel=0
end if

!--------------------moves the variables that control your character position in !movement
if travel=1 then
gr.show travelp
  if tx-cy/10-xx>sx then
   sx=sx+cy/100
   gr.hide ho2
   gr.show h
  end if

  if tx-cy/10-xx<sx then
   gr.hide h
   gr.show ho2
   sx=sx-cy/100
  end if

  if ty-cy/10-yy>sy then
   sy=sy+cy/100
  end if

  if ty-cy/10-yy<sy then
   sy=sy-cy/100
  end if 

  if sx=tx-cy/10 then
   if sy=ty-cy/10 then
    travel=0
    gr.hide travelp
   end if
  end if
end if


!-------------------things that happen when you are traveling
if travel=1 then

!----------------------------Checks to see if you are moving into the city
if xx+tx-xx>xx+cityl then
 if yy+ty-yy>yy+cityt then
  if xx+tx-xx<xx+cityr then
   if yy+ty-yy<yy+cityb then
    if xx+sx+cy/10>xx+cityl then
     if yy+sy+cy/10>yy+cityt then
      if xx+sx+cy/10<xx+cityr then
       if yy+sy+cy/10<yy+cityb then
        pause 250
        gr.bitmap.draw city,cite,0,0
        gr.color 255,255,0,0,1 
        gr.text.size cy/10
        gr.text.draw text,w/4,hi/2+cy/5,"You Have Entered the City, Where will you go?"
        goto citye
       end if
      end if
     end if
    end if
   end if
  end if
 end if
end if

!----------------------------------checks to see if you are moving into the castle
if xx+tx-xx>xx+castle[1] then
 if yy+ty-yy>yy+castle[2] then
  if xx+tx-xx<xx+castle[3] then
   if yy+ty-yy<yy+castle[4] then
    if xx+sx+cy/10>xx+castle[1] then
     if yy+sy+cy/10>yy+castle[2] then
      if xx+sx+cy/10<xx+castle[3] then
       if yy+sy+cy/10<yy+castle[4] then
        pause 250
        gr.bitmap.draw castl,castl,0,0
        gr.color 255,255,0,0,1 
        gr.text.size cy/10
        gr.text.draw text,w/4,hi/2+cy/5,"You Have Entered the Castle, Where will you go?"
        goto castle
       end if
      end if
     end if
    end if
   end if
  end if
 end if
end if

!----------------------------------checks to see if you are moving into the village
if xx+tx-xx>xx+village[1] then
 if yy+ty-yy>yy+village[2] then
  if xx+tx-xx<xx+village[3] then
   if yy+ty-yy<yy+village[4] then
    if xx+sx+cy/10>xx+village[1] then
     if yy+sy+cy/10>yy+village[2] then
      if xx+sx+cy/10<xx+village[3] then
       if yy+sy+cy/10<yy+village[4] then
        pause 250
        gr.bitmap.draw villa,village,0,0
        gr.color 255,255,0,0,1 
        gr.text.size cy/10
        gr.text.draw text,w/4,hi/2+cy/5,"You Have Entered the Village, What will you do?"
        goto villag
       end if
      end if
     end if
    end if
   end if
  end if
 end if
end if

!----------checks to see if you are at the edge of the map and wish to move it
 if t then
  if sx+xx>w-cy/2 then xx=xx-cy/80
  if sx+xx<cy/2 then xx=xx+cy/80
  if sy+yy>cy*2-cy/2 then yy=yy-cy/80
  if sy+yy<cy/2 then yy=yy+cy/80
 end if

end if  %End if of the if travel=1 statement

!------------------if your character not selected then youu can move the map
if selet=0 then
gr.hide travelp
 gr.touch touch,toux,touy
  if touch
   if f=0 then
    diffx=toux-xx
    diffy=touy-yy
    f=1
   end if

    xx=toux-diffx
    yy=touy-diffy

   end if
  end if

if xx<-hi*4+hi then xx=xx+cy/5
if xx>hi/4 then xx=xx-cy/5
if yy<-hi*2.5+hi/2 then yy=yy+cy/5
if yy>hi/4 then yy=yy-cy/5


!-----------------------if you are not moveing the map if resets the move positions
if touch=0 then f=0

!--------------------renders the graphics window, refreshes it---------------
gr.render

until 0


!---------------------------------City Screen---------------------------
citye:

!------------------Sets the touch buttons---------------------------
gr.bounded.touch leavet,leave[1],leave[2],leave[3],leave[4]
gr.bounded.touch markett,market[1],market[2],market[3],market[4]
gr.bounded.touch tavernt,tavern[1],tavern[2],tavern[3],tavern[4]

if markett then
 print "Market"
end if

if tavernt then
 print "Tavern"
end if

if leavet=1 then
pause 350
gr.cls
cleave=1
selet=0
goto leave
end if
gr.render
goto citye

!--------------------------------Castle Screen-------------------------------------
castle:

gr.bounded.touch leavet,leave[1],leave[2],leave[3],leave[4]
gr.bounded.touch Lhallt,market[1],market[2],market[3],market[4]
gr.bounded.touch barrackst,tavern[1],tavern[2],tavern[3],tavern[4]

if Lhallt then
 print "Lords Hall"
end if

if barrackst then
 print "Barracks"
end if

if leavet=1 then
pause 350
gr.cls
selet=0
goto leave
end if
gr.render
goto castle

!--------------------------------village Screen-------------------------------------
villag:

gr.bounded.touch leavet,leave[1],leave[2],leave[3],leave[4]
gr.bounded.touch Recuitt,market[1],market[2],market[3],market[4]
gr.bounded.touch buyt,tavern[1],tavern[2],tavern[3],tavern[4]

if Recruitt then
 print "Lords Hall"
end if

if buyt then
 print "Barracks"
end if

if leavet=1 then
pause 350
gr.cls
selet=0
goto leave
end if
gr.render
goto villag

!------------------------------Party Screen-----------------------------------
party:

gr.bounded.touch exitt,Pexit[1],Pexit[2],Pexit[3],Pexit[4]
gr.bounded.touch inventoryt,Pinventory[1],Pinventory[2],Pinventory[3],Pinventory[4]


if inventoryt then
 pause 250
 
 gr.bitmap.draw inv,inventori,0,0
 gr.color 255,0,0,0,1

 goto inventorydraw
end if

if exitt=1 then
pause 350
gr.cls
selet=0
goto leave
end if
gr.render
goto party


!---------------------------------------inventory Screen------------------
inventorydraw:
gr.text.size hi/20
 gr.text.draw plname,w*0.03125,hi*0.05,playername$
n=1
invn=4
print inventoryn
if inventoryn>0 then
for ie=hi*0.01 to inven*(hi*0.2) step hi*0.2 
if inventoryn<4 then invn=inventoryn
for i=w*0.50625 to w*0.50625+(invn*(hi*0.2)) step w*0.125

gr.bitmap.draw inv[n],weapon[invenobj[n]],i,ie
n=n+1
next i
inventoryn=inventoryn-invn
next ie
end if

if equipobj[1]>0 then
gr.bitmap.draw equip[1],weapon[equipobj[1]], w*0.31875,0
end if
if equipobj[2]>0 then
gr.bitmap.draw equip[2],weapon[equipobj[2]], w*0.31875,hi*0.2
end if




inventoryn=inventoryr

inventory:

gr.touch touch,mx,my
gr.bounded.touch exitt,Iexit[1],Iexit[2],Iexit[3],Iexit[4]
gr.bounded.touch quitt,Iquit[1],Iquit[2],Iquit[3],Iquit[4]


if touch then
n=1
for ie=hi*0.01 to hi*0.81 step hi*0.2 
for i=w*0.50625 to w*0.88125 step w*0.125

 if mx<i+w*0.125 then
  if mx>i then
   if my<ie+hi*0.2 then
    if my>ie then
     o=n
     recoveryx=i
     recoveryy=ie
     if n<inventoryn+1 then drag=1
    end if
   end if
  end if
 end if

n=n+1
next i 
next ie

n=1
for i=0 to hi*0.2 step hi*0.2
if mx<w*0.31875+hi*0.2 then
  if mx>w*0.31875 then
   if my<i+hi*0.2 then
    if my>i then
     o=n
     recoveryx=w*0.31875
     recoveryy=i
     print "equip:"; equip[o]
     if equip[o]<>0 then
      equipdrag=1
     end if
    end if
   end if
  end if
 end if
n=n+1
if n>2 then n=2
next i

end if

if drag=1 then
dx=0
dy=0
do
gr.touch touch,dx,dy
gr.modify inv[o],"x", dx-(hi*0.19)/2
gr.modify inv[o],"y", dy-(hi*0.19)/2
gr.render
until touch=0 


n=1
for i=0 to hi*0.2 step hi*0.2
if dx>w*0.31875 then
 if dx<w*0.31875+hi*0.2 then
  if dy>i then
   if dy<i+hi*0.2 then
    if equipobj[n]=0 then
     equipobj[n]=invenobj[o]
       for i=o to inventoryn-1 
        invenobj[i]=invenobj[i+1]
       next i
       inventoryn=inventoryn-1
       inventoryr=inventoryr-1
       inven=inventoryn/4
       gr.cls
       gr.bitmap.draw inv,inventori,0,0
       drag=0
       goto inventorydraw
      end if
     end if
    end if
   end if 
  end if
n=n+1
next i


gr.modify inv[o],"x",recoveryx 
gr.modify inv[o],"y",recoveryy
drag=0
end if



if equipdrag=1 then
if equipobj[o]<>0 then
dx=0
dy=0
print "o:";o
do
gr.touch touch,dx,dy
gr.modify equip[o],"x", dx-(hi*0.19)/2
gr.modify equip[o],"y", dy-(hi*0.19)/2
gr.render
until touch=0 


if dx>w*0.50625 then
 if dx<w then
  if dy>0 then
   if dy<hi then
    invenobj[inventoryn+1]=equipobj[o]
    equipobj[o]=0
    inventoryn=inventoryn+1
    inventoryr=inventoryr+1
    inven=inventoryn/4
    gr.cls
    gr.bitmap.draw inv,inventori,0,0
    equipdrag=0
    goto inventorydraw
   end if
  end if
 end if 
 end if

gr.modify equip[o],"x",recoveryx 
gr.modify equip[o],"y",recoveryy
equipdrag=0
end if
end if

if exitt=1 then
 gr.color 255,255,0,0,1
 gr.bitmap.draw part,party,0,0
 gr.text.size hi/10
 if equipobj[1]<>0 then
 Totalattack=playerattack+weaponattack[equipobj[1]]
 print "equip:";equipobj[1]
 gr.text.draw pattack,0.09*w,hi*0.26,format$("##",Totalattack)
 end if
 if equipobj[1]=0 then
 gr.text.draw pattack,0.09*w,hi*0.26,format$("#",playerattack)
 end if
 gr.text.draw parmor,0.09*w,hi*0.4,format$("##",playerarmor)
 gr.text.draw pmoney,0.09*w,hi*0.58,format$("###",playermoney)
 gr.text.draw phealth,0.09*w,hi*0.76,format$("###",playerhealth)
 pause 250
 goto party
end if
gr.render
goto inventory

