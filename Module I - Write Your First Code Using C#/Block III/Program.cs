//To Encode Unicode
Console.OutputEncoding = System.Text.Encoding.Unicode;



//Unit 2 of 8 Combine strings using character escape sequences

/*
Character escape sequences

An escape character sequence is an instruction to the runtime to insert a special character that 
will affect the output of your string. In C#, 
the escape character sequence begins with a backslash \ followed by the character you're escaping. 
For example, the \n sequence will add a new line, and a \t sequence will add a tab.
*/


Console.WriteLine("Hello\nWorld");
Console.WriteLine("Hello\tWorld");

//use the \" escape sequence
Console.WriteLine("Hello \"World\"");

//What if you need to use the backslash for other purposes, like to display a file path?
Console.WriteLine("c:\\source\\repos");

//Format output using character escape sequences
Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ... \n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.WriteLine("\nOutput Directory:\t");


/*
Verbatim string literal
A verbatim string literal will keep all whitespace and characters without the need to escape the backslash. 
To create a verbatim string, use the @ directive before the literal string.
*/

Console.WriteLine(@"    c:\source\repos    
        (this is where your code goes)");

/*
Unicode escape characters
You can also add encoded characters in literal strings using the \u escape sequence, 
then a four-character code representing some character in Unicode (UTF-16).
*/
Console.WriteLine("\u006e\u0069\u0067\u0067\u0061");

//Unit 3 of 8 Combine strings using string concatenation

/*
Concatenate a literal string and a variable
To concatenate two strings together, you use the string concatenation operator, which is the plus symbol +
*/

string firstName = "Omar";
string message = "Hello " + firstName;
Console.WriteLine(message);

/*
Concatenate multiple variables and literal strings
You can perform several concatenation operations in the same line of code.
*/

string secondName = "Mazen";
string greetings = "Hello";
string msg = greetings + " " + secondName + "!";
Console.WriteLine(msg);

//Unit 4 of 8 Combine strings using string interpolation

/*
What is string interpolation?
String interpolation combines multiple values into a single literal string by using a "template" 
and one or more interpolation expressions.
An interpolation expression is indicated by an opening and closing curly brace symbol { }. 
You can put any C# expression that returns a value inside the braces. 
The literal string becomes a template when it's prefixed by the $ character.
*/

string thirdName = "Youssef";
string updateMessage = "Update to Windows 11";
Console.WriteLine($"{thirdName} {updateMessage}");

//Quick note you can put interpolation and Verbatim string together

Console.WriteLine($@"{thirdName} \ {updateMessage}");

//Unit 5 of 8 Complete the challenge

string projectName = "ACME";

string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
string englishMessage = "View English output:";

Console.WriteLine($@"{englishMessage}
c:\Exercise\{projectName}\data.txt");

Console.WriteLine($@"{russianMessage}:
c:\Exercise\{projectName}\ru-RU\data.txt");