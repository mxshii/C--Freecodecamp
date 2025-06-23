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

/*
Write code to determine the remainder after integer division

The modulus operator % tells you the remainder of int division. 
What you really learn from this is whether one number is divisible by another. 
This can be useful during long processing operations when looping through hundreds or thousands of data records 
and you want to provide feedback to the end user after every 100 data records have been processed.
*/

//When the modulus is 0, that means the dividend is divisible by the divisor.

Console.WriteLine($"Modulus of 200 / 5 : {200 % 5}");
Console.WriteLine($"Modulus of 7 / 5 : {7 % 5}");

//Unit 4 of 8 Increment and decrement values

/*
The += operator adds and assigns the value on the right of the operator to the value on the left of the operator. 
So, lines two and three in the following code snippet are the same
*/

int value = 0;     // value is now 0.
Console.WriteLine(value);
value = value + 5; // value is now 5.
Console.WriteLine(value);
value += 5;        // value is now 10.
Console.WriteLine(value);

/*
The ++ operator increments the value of the variable by 1. 
So, lines two and three in the following code snippet are the same
*/

value++;           // value is now 11.
Console.WriteLine(value);

//Write code to increment and decrement a value
int val = 1;

val = val + 1;
Console.WriteLine("First increment: " + val);

val += 1;
Console.WriteLine("Second increment: " + val);

val++;
Console.WriteLine("Third increment: " + val);

val = val - 1;
Console.WriteLine("First decrement: " + val);

val -= 1;
Console.WriteLine("Second decrement: " + val);

val--;
Console.WriteLine("Third decrement: " + val);


/*
Position the increment and decrement operators

Both the increment and decrement operators have an interesting quality — depending on their position, 
they perform their operation before or after they retrieve their value. In other words, 
if you use the operator before the value as in ++value, 
then the increment will happen before the value is retrieved. 
Likewise, value++ will increment the value after the value has been retrieved.
*/

int valu = 1;
valu++;
Console.WriteLine("First: " + valu);
Console.WriteLine($"Second: {valu++}");
/*
There's two steps to this line:

Retrieve the current value of the variable value and use that in the string interpolation operation.
Increment the value.
*/

Console.WriteLine("Third: " + valu);
Console.WriteLine("Fourth: " + (++valu));
/*
Here, the order of operations is switched because the ++ operator is placed before the operand value.

Increment the value.
Retrieve the new incremented value of the variable value and use that in the string operation.
*/

//Unit 5 of 8 Complete Challenge
int fahrenheit = 94;
decimal celsius = ((decimal)fahrenheit - 32) * 5.0m / 9;
Console.WriteLine($"The temperature is {celsius} Celsius.");