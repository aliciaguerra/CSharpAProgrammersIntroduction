1. What is C#? <br>
C# is an object-oriented, type-safe, and managed that is compiled by .NET framework to generate Microsoft Intermmediate
Language.

2. What are some types of comments in C# with examples? 
single line <br>
`//This is a single line comment` <br>
- multiple line
```
/*
This is a multiple line comment
We are in line 2
last line of comment
*/
```
- XML 
```
///summary;
///Set error message for multilingual language
///summary
```
3. Can multiple catch blocks be executed? 
No. Multiple catch blocks cannot be executed. Once the proper catch code executed, the control is transferred to the finally
block and then the code that follows the finally block gets executed.

4. What is the differentce between public, static, and void? <br>
Public declared variables or methods are accessible anywhere in the application. Static declared variables or methods are
globally accessible without creating an instance of the class. The compiler stores the address of the method as the entry point
and uses this information to begin execution before any objects are created. And void is a type modifier that states that the 
method or variable does not return any value.
