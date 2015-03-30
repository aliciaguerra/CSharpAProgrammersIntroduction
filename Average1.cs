using System;
class Average1
{
static void Main(string[] args)
{
int total; //sum of grades
gradeCounter; //number of grades entered
gradeValue; //grade value
average; //average of all the grades

//initialization phase
total=0; //clear totoal
gradeCounter=1; //prepare to loop

//processing phase
while(gradeCounter<=10)//loop 10 entries
{
//prompt for input and read grade from user
Console.Write("Enter integer grade:");

//read input and convert to integer
gradeValue=Int32.Parse(Console.ReadLine());
//add gradeValue to total
total=total+gradeValue;

//add 1 to gradeCounter
gradeCounter=gradeCounter+1;
}

//termination phase
average=total/10; //integer division

//display average of exam grades 
Console.WriteLine("\nClass average is {0}", average);
}//end main
}//end class Average1
