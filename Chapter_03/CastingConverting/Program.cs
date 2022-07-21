using static System.Console;
using static System.Convert;

int a = 10;
double b = a;//an int can be safely cat in to double;
WriteLine("{0} type is {1}", b, b.GetType());

//implicit cast
double c = 9.8;
int d = c; // compiler gives an error for this line


//explicit cast

double c = 9.8;
int d = (int)c; // compiler gives an error for this line
WriteLine("{0} type is {1}", d, d.GetType());


long e = 10;
int f = (int)e;
WriteLine($"e is {e:N0} and f is {f:N0}");
e = long.MaxValue;
f = (int)e;
WriteLine($"e is {e:N0} and f is {f:N0}");


double g = 9.8;
int h = ToInt32(g);// a method of System.Convert
WriteLine($"g is{g} and h is (h)");

double u = 9.8;
int j = (int)u;
WriteLine($"u is{u} and j is (j)");

double[] doubles = new[]
{ 9.49, 9.5, 9.51, 10.49, 10.5, 10.51 };
foreach (double n in doubles)
{
    WriteLine($"ToInt32({n}) is {ToInt32(n)}");
}
double[] doubles = new[] { 9.49, 9.5, 9.51, 10.49, 10.5, 10.51 };
foreach (double n in doubles)
{
    WriteLine($"ToInt32({n}) is {ToInt32(n)}");
}
foreach (double n in doubles)
{
    WriteLine(
    "Math.Round({0}, 0, MidpointRounding.AwayFromZero) is {1}",
    n,
    Math.Round(value: n, digits: 0, mode: MidpointRounding.AwayFromZero));
}