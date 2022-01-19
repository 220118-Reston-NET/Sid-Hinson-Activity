#Sid Hinson
#Wine Pairing Program

clear
condition="true"
gb="Thanks for using this program / Press Enter to Continue"
pe="Goodbye!"
f="Look for more great applications in the coming weeks"

while [ "$condition" == true ]
do
echo "******************************************************"
echo "* Welcome to the Wine Pairing Optimizer Application  *"
echo "*----------------------------------------------------*"
echo "*  We will find what wine is best with your dinner!  *"
echo "*    Enter 1 if you are having steak for dinner!     *"
echo "*   Enter 2 if you are having chicken for dinner!    *"
echo "*    Enter 3 if you are having pork for dinner!      *"
echo "*   Enter 4 if you are having seafood for dinner!    *"
echo "*    Enter 5 if you are vegetarian for dinner!       *"
echo "*         Enter 6 to exit this program!              *"
echo "******************************************************"

read choice

if [ "$choice" == "1" ]
then
echo "Enter 1 for Cabernet or 2 for Merlot"
read choice2
 if [ "$choice2" == "1" ]
 then
 echo "We recommend one glass of Intrinsic Cabernet"
 echo $gb
 echo $pe
 echo $f
 read finalinput
 elif [ "$choice2" == "2" ]
 then
 echo "We recommend one glass of JLohr Merlot"
 echo $gb
 echo $pe
 echo $f
 read finalinput
 else
 echo "Command Not Found / Try Again"
 echo $gb
 echo $pe
 read finalinput
 condition="false"
 fi


elif [ "$choice" == "2" ]
then
echo "Enter 1 for Chardonnay or 2 for Sauvignon?"
read choice2
 if [ "$choice2" == "1" ]
 then
 echo "We recommend one glass of La Crema Chardonnay"
 echo $gb
 echo $pe
 echo $f
 read finalinput
 elif [ "$choice2" == "2" ]
 then
 echo "We recommend one glass of Alphonse Sauvignon"
 echo $gb
 echo $pe
 echo $f
 read finalinput
 else
 echo "Command Not Found / Try Again"
 echo $gb
 echo $pe
 read finalinput
 condition="false"
 fi


elif [ "$choice" == "3" ]
then
echo "Enter 1 for Chardonnay or 2 for Sauvignon?"
read choice2
 if [ "$choice2" == "1" ]
 then
 echo "We recommend one glass of La Crema Chardonnay"
 echo $gb
 echo $pe
 echo $f
 read finalinput
 elif [ "$choice2" == "2" ]
 then
 echo "We recommend one glass of Alphonse Sauvignon"
 echo $gb
 echo $pe
 echo $f
 read finalinput
 else
 echo "Command Not Found / Try Again"
 echo $gb
 echo $pe
 read finalinput
 condition="false"
 fi 

elif [ "$choice" == "4" ]
then
echo "Enter 1 for Chardonnay or 2 for Sauvignon?"
read choice2
 if [ "$choice2" == "1" ]
 then
 echo "We recommend one glass of La Crema Chardonnay"
 echo $gb
 echo $pe
 echo $f
 read finalinput
 elif [ "$choice2" == "2" ]
 then
 echo "We recommend one glass of Alphonse Sauvignon"
 echo $gb
 echo $pe
 echo $f
 read finalinput
 else
 echo $gb
 echo $pe
 read finalinput
 condition="false"
 fi
 
elif [ "$choice" == "5" ]
then
echo "Enter 1 for Riesling or 2 for Pinot Grigio?"
read choice2
 if [ "$choice2" == "1" ]
 then
 echo "We recommend one glass of St.Michelle Riesling"
 echo $gb
 echo $pe
 echo $f
 read finalinput
 elif [ "$choice2" == "2" ]
 then
 echo "We recommend one glass of King Estate Pinot Grigio"
 echo $gb
 echo $pe
 echo $f
 read finalinput
 else
 echo $gb
 echo $pe
 read finalinput
 condition="false"
 fi


elif [ "$choice" == "6" ]
then
echo $gb
echo $pe
read finalinput
condition="false"

else
echo "Command Not Found / Try Again"
echo "You will need to restart this program"
echo "Press Enter to Continue"
read finalinput
fi


clear
done
