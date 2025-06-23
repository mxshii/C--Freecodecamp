//Unit 2 of 8 Perform addition with implicit data conversion

/*
Add two numeric values
To add two numbers together, you'll use the addition operator, which is the plus symbol +
same plus symbol + that you use for string concatenation is also used for addition
reuse of one symbol for multiple purposes is sometimes called "overloading the operator"
*/
int firstNumber = 5;
int secondNumber = 6;
Console.WriteLine(firstNumber + secondNumber);

/*
Mix data types to force implicit type conversions
What happens if you try to use the + symbol with both string and int values?
*/
string firstName = "Bob";
int widgetsSold = 7;
Console.WriteLine(firstName + " sold " + widgetsSold + " widgets.");

//Attempt a more advanced case of adding numbers and concatenating strings

Console.WriteLine(firstName + " sold " + widgetsSold + 7 + " widgets.");

//Add parentheses to clarify your intention to the compiler

Console.WriteLine(firstName + " sold " + (widgetsSold + 7) + " widgets.");

/*
Quick Note from Omar
This is called PEMDAS
Prantheses, Exponents, Multiplication, Division, Addition, Subtraction
any coding language treats anything like maths problem so it always solve from right to left
and using prantheses will put it in better position
*/

//Unit 3 of 8 Perform math operations

//Write code to perform addition, subtraction, multiplication, and division with integers

int sum = 7 + 5;
int difference = 7 - 5;
int product = 7 * 5;
int division = 7 / 5;

Console.WriteLine($@"Sum: {sum}
Difference: {difference}
Product: {product}
Division: {division}");

/*
Add code to perform division using literal decimal data

To see division working properly, you need to use a data type that supports 
fractional digits after the decimal point like decimal.
*/

decimal decimalQuotient = 7.0m / 5;
Console.WriteLine(decimalQuotient);

//Add code to cast results of integer division

/*
what if you need to divide two variables of type int but do not want the result truncated? 
In that case, you must perform a data type cast from int to decimal. 
Casting is one type of data conversion that instructs the compiler to temporarily treat a 
value as if it were a different data type.

To cast int to decimal, 
you add the cast operator before the value. 
You use the name of the data type surrounded by parentheses in front of the value to cast it. 
In this case, you would add (decimal) before the variables first and second.
*/

int first = 8;
int second = 5;
decimal quotient = (decimal)first / (decimal)second;
Console.WriteLine(quotient);