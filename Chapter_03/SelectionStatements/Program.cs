using static System.Console;

Console.BackgroundColor = ConsoleColor.Blue;

string password = "ninja";
if (password.Length < 8)
{
    WriteLine("Your password is to short use at least 8 characters");

}
else
{
    WriteLine("Your password is stong");

};
// add and remove the "" to change behavior

object o = 3;
int j = 4;
if(o is int i)
{

    WriteLine($"{i}*{j}={i * j}");
}
else
{

    WriteLine("o is not int so o is can not multiply!");

}

int number = (new Random()).Next(1, 7);


WriteLine($"My random number is {number}");

switch (number)
{

    case 1:
        WriteLine("one");
        break;
    case 2:
        WriteLine("two");
        goto case 1;
    case 3://multiple case section
        
    case 4:
        WriteLine("Three or four");
        goto case 1;
    case 5:
        goto A_label;
    default:
        WriteLine("Default");
        break;
}

WriteLine("After end of switch");
A_label:
WriteLine($"After A_label");

string path = @"C:\FullStackDevelopment\CSharpCodeAcademy\Csharp-DotNet_New\Chapter_03";

Write("Press R for read-only or W for writeable: ");
ConsoleKeyInfo key = ReadKey(); //
WriteLine();
Stream? s;
if (key.Key == ConsoleKey.R)
{
    s = File.Open(
        Path.Combine(path, "file.txt"),
        FileMode.OpenOrCreate,
        FileAccess.Read);

}
else
{
    s = File.Open(

        Path.Combine(path, "file.txt"),
        FileMode.OpenOrCreate,
        FileAccess.Write);

}

string message;

//switch (s)
//{

//    //case FileStream writeableFile when s.CanWrite:
//    //    message = "The stream is a file that I can write to ";
//    //    break;
//    //case FileStream readOnlyFile:
//    //    message = "The stream is read-only file.";
//    //    break;
//    //case MemoryStream ms:
//    //    message = "The stream is memory address.";
//    //    break;
//    //default: //always evaluated last desite its current possition

//    //    message = "The stream is some other type";
//    //    break;
//    //case null:
//    //    message = "The stream is null.";
//    //    break;
//}

message = s switch
{
    FileStream writeableFile when s.CanWrite => "The stream is a file that I can write to.",
    FileStream readonlyFile => "The stream is a read-only file.",
    MemoryStream ms => "The stream is a memory address",
   _ null => "The stream is null.",
 => "The stream is some other type"


};
WriteLine(message);

