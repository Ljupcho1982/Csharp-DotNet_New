﻿using static System.Console;

int a = 3;
int b = a++;
WriteLine($"\"a\" is {a}, \"b\" is {b}");

int c = 3;
int d = ++c;
WriteLine($"\"c\" is {c}, \"d\" is {d}");

int e = 11;
int f = 3;
Console.WriteLine($"e is {e}, f is{f}");
Console.WriteLine($"e+f={e+f}");
Console.WriteLine($"e-f={e-f}");
Console.WriteLine($"e*f={e*f}");
Console.WriteLine($"e/f={e/f}");
Console.WriteLine($"e%f={e % f}");
double g = 11.0;
WriteLine($"g is{g:N1},f is{f}");
WriteLine($"g/f={g / f}");
