using static System.Console;
using static System.Convert;

//int a = 10;
//double b = a;//an int can be safely cat in to double;
//WriteLine("{0} type is {1}", b, b.GetType());

////implicit cast
//double c = 9.8;
//int d = c; // compiler gives an error for this line


////explicit cast

//double c = 9.8;
//int d = (int)c; // compiler gives an error for this line
//WriteLine("{0} type is {1}", d, d.GetType());


//long e = 10;
//int f = (int)e;
//WriteLine($"e is {e:N0} and f is {f:N0}");
//e = long.MaxValue;
//f = (int)e;
//WriteLine($"e is {e:N0} and f is {f:N0}");


//double g = 9.8;
//int h = ToInt32(g);// a method of System.Convert
//WriteLine($"g is{g} and h is (h)");

//double u = 9.8;
//int j = (int)u;
//WriteLine($"u is{u} and j is (j)");

//double[] doubles = new[]
//{ 9.49, 9.5, 9.51, 10.49, 10.5, 10.51 };
//foreach (double n in doubles)
//{
//    WriteLine($"ToInt32({n}) is {ToInt32(n)}");
//}

//    WriteLine($"ToInt32({n}) is {ToInt32(n)}");
//}
//foreach (double n in doubles)
//{
//    WriteLine(
//    "Math.Round({0}, 0, MidpointRounding.AwayFromZero) is {1}",
//    n,
//    Math.Round(value: n, digits: 0, mode: MidpointRounding.AwayFromZero));
//}

int number = 12;
WriteLine(number.ToString());

bool boolean = true;
WriteLine(boolean.ToString());

DateTime now = DateTime.Now;
WriteLine(now.ToString());
object me = new { name="Ljupcho"};
WriteLine(me.ToString());

//allocate array of 128 bytes
byte[] binaryObject = new byte[128];
//populate array with random bytes
(new Random()).NextBytes(binaryObject);
WriteLine("Binary Object as bytes:");

for(int index = 0; index < binaryObject.Length; index++)
{

    Write($"{binaryObject[index]:X}");
}
WriteLine();

//convert to Base string and output as text

string encoded =ToBase64String(binaryObject);
WriteLine($"Binary Object as Base: {encoded}");

int age = int.Parse("27");

DateTime birthday = DateTime.Parse("4 July 1980");

WriteLine($"I was born {age} years ago");
WriteLine($"My birthday is {birthday}.");
WriteLine($"My birthday is {birthday:D}.");

WriteLine();

Write("How many eggs are there?");
string? input = ReadLine();

if(int.TryParse(input, out int count))
{

    WriteLine($"There are {count} eggs");
}
else
{
    WriteLine("I could not parse the input.");

}



