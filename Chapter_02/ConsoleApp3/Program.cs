// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
System.Type type = typeof(int);
Console.WriteLine(type);

int i = 100;
Console.WriteLine(i.GetType().FullName);
Type tp = typeof(int);
Console.WriteLine($"typeof {tp}");
Console.WriteLine(typeof(String));
Console.WriteLine(typeof(Double));
Console.WriteLine(sizeof(sbyte));
Console.WriteLine(int.MaxValue);