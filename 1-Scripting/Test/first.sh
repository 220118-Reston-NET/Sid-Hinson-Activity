#variables
#store information
msg="Hello World"
echo $msg

#control flow
#tells program HOW to run the code

ten=10
five=5
thirteen=13

#10 > 5 then run thes elines of code

echo "===First IF==="
if [ "$ten" -ge "$five" ]
then
echo "greater!"
echo "$ten > $five"
fi

echo "===Second if==="
if [ "$five" -ge "$ten" ]
then
echo "greater!"
echo "$five > $ten"
fi

echo "===Third if==="
if [ "$five" -ge "$ten" ]
then
echo "lesser!"
echo "$five > $ten"
elif [ "$ten" -ge "$five" ]
then
echo "greater"
echo "$ten > $five"
fi

echo "===For Loop===="
for num in 1 2 3 4 5
do
echo "Repeating!!!"
echo $num 
done

#while loop
#unknown how many times, will repeat code as long as condition is TRUE
#displaying a menu is an example

echo "====While Loop===="
while [ "$ten" -ge "$five" ]
do
echo "Greater"
echo $five
five=$(($five+1))
done

#input and output
#ask user for input

echo "What is your Name?"
read name
echo "Hello $name, Welcome to 12 weeks of awesome!"

#Combine Everything! Here we go - Interface terminal that will ask the user info and process information based on what they want

while [ "$repeat" == "true"]
do
clear # clear terminal
echo "Welcome to Shell scripting"
echo "What do you want to do today?"
echo "enter 1 if you want to add 2 numbers"
echo "enter 2 if you want to exit out of the program"
read ans

if [ "$ans" == "1" ]
then
echo "Give me two numbers"
read num1
read num2
echo "This is your number $(($num1+$num2))"
echo "Press Enter to Continue"
read 
elif [ "$ans" == "2" ]
then
echo "Goodbye!"
repeat="false"
else 
echo "Command not Found!!!"
fi
clear
done
