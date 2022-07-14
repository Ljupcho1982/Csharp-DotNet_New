// See https://aka.ms/new-console-template for more information


using System.Globalization;

uint naturalNumber = 23;

int integerNumber = -23;

float realNumber = 2.3F;

double anotherRealNumbe = 2.3;

Console.WriteLine($"{nameof(naturalNumber)}:{naturalNumber}" + $"{nameof(integerNumber)}:{integerNumber} \r\n" + $"{realNumber}:{realNumber} \r\n" + $"{nameof(realNumber)}:{realNumber}");

int decimalNotation = 2_000_000;
int binaryNotation = 0b_0001_1110_1000_0100_1000_0000;
int hexadecimalNotation = 0x_001E_8480;
Console.WriteLine(decimalNotation);
Console.WriteLine(binaryNotation);
Console.WriteLine(hexadecimalNotation);


string s = "7.6";
float f = float.Parse(s, CultureInfo.InvariantCulture);

Console.WriteLine(f);

double i = 100.900,00;
// Set the CurrentCulture to French in France.
Thread.CurrentThread.CurrentCulture = new CultureInfo("fr-FR");
// Display i formatted as default currency for the CurrentCulture.
// On a version of Windows prior to Windows XP, where the user
// has not changed the default currency to euro through
// Control Panel, this will default to "F".
Console.WriteLine(i.ToString("c"));
// Set the CurrentCulture to French in France, using the
// CultureInfo constructor that takes a useUserOverride parameter.
// Set the useUserOverride value to false.
Thread.CurrentThread.CurrentCulture = new CultureInfo("fr-FR", false);
// Display formatted as default currency for the CurrentCulture.
// On a version of Windows prior to Windows XP, this will override
// an incorrect default setting of "F" and display the euro symbol.
Console.WriteLine(i.ToString("c"));

Console.WriteLine($"int usues {sizeof(int)} bytes " + $" and can store numbers " +
    $"in the range {int.MinValue:N0} to {int.MinValue:N0}");

Console.WriteLine($"int uses {sizeof(double)} bytes" + $" and can store numberd"+
    $"in the range{sizeof(double)}");

Console.WriteLine("Using doubles:");

double a = 0.1;

double b = 0.2;
if (a + b == 0.3)
{

    Console.WriteLine($"{a}+{b} equals {0.3}");

}
else
{

    Console.WriteLine($"{a}+{b} does NOT equal {0.3}");


}
decimal c = 0.1M;

decimal d = 0.2M;
if (c + d == 0.3M)
{

    Console.WriteLine($"{c}+{d} equals {0.3}");

}
else
{

    Console.WriteLine( $"{c}+{d} does NOT equal {0.3}");