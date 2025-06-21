// Unit 2 of 9 Print literal values
//A literal value is a constant value that never changes

/*
Use character literals

If you only wanted a single alphanumeric character printed to screen,
you could create a char literal by surrounding one alphanumeric character in single quotes. 
The term char is short for character
*/

Console.WriteLine('b');

/*
Use integer literals

If you want to display a numeric whole number (no fractions) value in the output console, 
you can use an int literal. The term int is short for integer
*/

Console.WriteLine(1233);

/*
Use floating-point literals

A floating-point number is a number that contains a decimal
float, double, and decimal

Float Type    Precision
----------------------------
float         ~6-9 digits
double        ~15-17 digits
decimal        28-29 digits

*/

Console.WriteLine(0.25F);

/*
To create a float literal, append the letter F after the number.
In this context, the F is called a literal suffix. 
The literal suffix tells the compiler you wish to work with a value of float type. 
You can use either a lower-case f or upper-case F as the literal suffix for a float
*/

/*
To create a double literal, just enter a decimal number. 
The compiler defaults to a double literal
*/
Console.WriteLine(2.562);

//To create a decimal literal, append the letter m after the number

Console.WriteLine(0.2224m);


/*Use Boolean literals

If you wanted to print a value representing either true or false, you could use a bool literal.
*/
Console.WriteLine(true);
Console.WriteLine(false);

//Unit 3 of 9 Declare variables

/*
What is a variable?

A variable is a container for storing a type of value. 
Variables are important because their values can change, or vary, throughout the execution of a program. 
Variables can be assigned, read, and changed. You use variables to store values that you intend to use in your code
*/

// Declare a variable

//To create a new variable, you must first declare the data type of the variable, and then give it a name.

string firstName;

char userOption;
int gameScore;
decimal particles;
bool processedCustomer;

//Unit 4 of 9 Setting and getting values from variables
/*
To declare a variable, you enter the data type you want to use followed by a name for the variable. 
To assign a value to a variable, you use the assignment operator, which is a single equals character =.
*/

firstName = "Bob";

/*
Retrieve a value you stored in the variable

To retrieve a value from a variable, you just use the name of the variable. 
This example will set a variable's value, then retrieve that value and display it in the console.
*/

Console.WriteLine(firstName);

/*
Reassign the value of a variable

You can reuse and reassign the variable as many times as you want. This example illustrates that idea
*/

firstName = "Liem";
Console.WriteLine(firstName);
firstName = "Isabella";
Console.WriteLine(firstName);
firstName = "Yasmin";
Console.WriteLine(firstName);

//Unit 5 of 9 Declare implicitly typed local variables

/*
What are implicitly typed local variables?

An implicitly typed local variable is created by using the var keyword followed by a variable initialization.
*/

var message = "Hello, World!";

//Variables using the var keyword must be initialized

//Unit 6 of 9 Challenge

string name = "Bob";
int messages = 3;
var temp = 34.4;

Console.Write("Hello, ");
Console.Write(name);
Console.Write("!");
Console.Write(" You Have ");
Console.Write(messages);
Console.Write(" messages in your inbox. ");
Console.Write("The temperature is ");
Console.Write(temp);
Console.Write(" celsius.");


