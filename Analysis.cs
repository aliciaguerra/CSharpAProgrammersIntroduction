//Analysis of examination results
using System;
class Analysis
{
static void Main(string[] args)
{
int passes=0;
failures=0;
student=1;
result;

//processes 10 students, counter-controlled loop
while(student<=10)
{
Console.Write("Enter result: (1 pass, 2=fail):");
result=Int32.Parse(Console.ReadLine());

if(result==1)
{
passes=passes+1;
student=student+1;
}

else if(result==2)
{ 
failures=failures+1;
