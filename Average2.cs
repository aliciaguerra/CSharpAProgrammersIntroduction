using System;
class Average2
{
static void Main(string[] args)
{
int total;
gradeCounter;
gradeValue;

double average;

//initialization phase
total=0;//clear total
gradeCounter=0;//prepare to loop

//processing phase
//prompt for input and convert to integer
Console.Write("Enter Integer Grade, -1 to Quit:");
gradeValue=Int32.Parse(Console.ReadLine());

//loop until a -1 is entered by the user
while(gradeValue != -1)
{
//add gradeValue to total
total=total+gradeValue;

//add 1 to the gradecounter
gradeCounter=gradeCounter+1;

//prompt from input and read grade from user
//convert grade from string to integer
Console.Write("Enter Integer Grade, -1 to Quit:");
gradeValue=Int32.Parse(Console.ReadLine());
}//end while

//termination phase
if(gradeCounter != 0)
{
average = (double) total/gradeCounter;

//display average of exam grades
Console.WriteLine("/nClass average is {0}", average);
}
else
{
Console.WriteLine("No grades were entered.");
}
}//end method Main
}//end class Average2
