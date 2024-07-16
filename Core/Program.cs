using System;
using Utils;

class Program
{
    static void Main(string[] args)
    {
        int result = MyModule.addNumbers(5, 7);
        Console.WriteLine($"Result from F# function: {result}");
    }
}