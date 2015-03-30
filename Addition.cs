using System;
class Addition
{
static void Main(string[] args)
{
string firstNumber,  //first string entered by user
       secondNumber; //second string entered by user
int number1,     //first number to add
    number 2;    //second number to add
    sum;         //sum of number1 and number2
//prompt for and read first number from user as a string
Console.Write("Please enter the first integer:");
firstNumber=Console.ReadLine();

//read second number from user as a string
Console.Write("\nPlease enter the second integer:");
secondNumber=Console.ReadLine();

//convert the numbers from type string to type int
number1=Int32.Parse(firstNumber);
number2=Int32.Parse(secondNumber);

//addNumbers
sum=number1+number2;

//display results
Console.WriteLine("\nThe sum is {0}", sum);
}//end the method main
}//end class edition
