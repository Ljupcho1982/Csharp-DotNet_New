
using System.Globalization;

using static System.Console;


Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("ru");

Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("ru-RU");

int numberOfApples = 12;
decimal pricePerApple = 0.35M;
WriteLine(format:"{0} apples costs {1:C}", arg0:numberOfApples, arg1:pricePerApple*numberOfApples);


string formatted = string.Format(
format: "{0} apples costs {1:C}", arg0: numberOfApples, arg1: pricePerApple * numberOfApples
    );

WritetoFile(formatted);//writes the string into file

void WritetoFile(string formatted)
{
    Console.WriteLine(format:"The next text was written in the file:\r\n {0}",arg0:formatted);
}

string applesText = "Apples";
int applesCount = 1234;
string bannaText = "Bananas";
int bannasCount = 56789;

WriteLine(format:"{0,-10}{1,6:N0}",arg0:"Name",arg1:"Count");

WriteLine(format:"{0,-10}{1,6:N0}",arg0:applesText,arg1:applesCount);

WriteLine(format:"{0,-10}{1,6:N0}",arg0:bannaText,arg1:bannasCount);
WriteLine(pricePerApple.ToString("c"));

WriteLine("Type your first name and press ENTER");

string? firstName = Console.ReadLine();

WriteLine("Type your age and press ENTER");

string? age = Console.ReadLine();

WriteLine($"Your first name is : {firstName} and your age is:{age}");

Write("Press any key combination:");

ConsoleKeyInfo key = ReadKey();
WriteLine();
WriteLine("Key: {0}, Char: {1}, Modifiers: {2}" , arg0: key.Key, arg1: key.KeyChar.ToString()=="*", arg2: key.Modifiers);