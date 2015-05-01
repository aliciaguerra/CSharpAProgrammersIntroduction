1. What is C#? 
C# is an object-oriented, type-safe, and managed that is compiled by .NET framework to generate Microsoft Intermmediate
Language.

2. What are some types of comments in C# with examples? 
single line 
```
This is a single line comment
```
multiple line
```
/*
This is a multiple line comment
We are in line 2
last line of comment
*/
```
XML 
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

5. What is an object?
An object is an instance of a class through which we access the methods of that class. "New" keyword is used to create an
object. A class that creates an object in memory will contain the information about the method, variables, and behavior of
that class.

6. Define constructors.
A constructor is a member fuction in a class that has the same name as its class. The constructor is automatically
invoked whenever an object class is created. It constructs the values of data members while initializing the class.

7. What are jagged arrays?
The array which has elements of type array is called jagged array. The elements can be of different dimensions and sizes.
We can call jagged array as Array of arrays.

8. What is the difference between ref and out parameters?
An argument passed as ref must be initialized before passing to the method whereas out parameter needs not to be initialized
before passing through a method.

9. What is the use of using statement in C#?
The using block is used to obtain a resource and use it and then automatically dispose of when the execution of block is completed.

10. What is serialization?
When we transport an object through a network then we have to convert the object into a stream of bytes. The process of
converting an object into a stream of bytes is called serialization. For an object to be serializable, it should inherit the
serializable interface. De-serialization is the reverse process of creating an object from a stream of bytes.

11. Can "this" be used within a static method?
We can use "this" in a static method because we only use static variables/methods in a static method?

12. What is the difference between constants and read-only?
Constant variables are declared and initialized at compile-time. The value can' be changed afterwards.
