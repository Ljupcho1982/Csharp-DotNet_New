﻿using static System.Console;

WriteLine("Before parsing");
Write("What is your age");

string? input = ReadLine();

try
{
    int age = int.Parse(input);//probuva da go parsira vo int

    WriteLine($"You are: {age} years old.");//
}
catch(Exception ex)
{
    WriteLine($"{ex.GetType()} says {ex.Message}");

}
WriteLine("After parsing");

