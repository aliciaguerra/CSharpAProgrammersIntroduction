using System;
class Comparison
{
static void Main(string[] args)
{
int number1,
number2;

//read in first number from user
Console.Write("Please enter the first integer");
number1=Int32.Parse(Console.ReadLine());

//read in second number from user
Console.Write("\nPlease enter second integer");
number2=Int32.Parse(Console.ReadLine());

if(number1==number2)
Console.WriteLine(number1+"=="+number2);

if(number1!=number2)
Console.WriteLine(number1 + "!=" + number2);

if(number1<number2)
Console.WriteLine(number1 + "<" + number2);

if(number1>number2)
Console.WriteLine("number1+ ">" + number2);

if(number1<=number2)
Console.WriteLine(number1+"<=" + number2);

if(number1>=number2)
Console.WriteLine(number1 + ">=" + number2);
}//end method main
}//end class compariosn
