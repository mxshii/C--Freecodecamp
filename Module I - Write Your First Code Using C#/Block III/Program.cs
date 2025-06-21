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