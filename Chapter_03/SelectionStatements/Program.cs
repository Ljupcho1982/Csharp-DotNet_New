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
