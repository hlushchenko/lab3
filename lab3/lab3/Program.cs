using System;

namespace lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Result: {Calculator.Calculate( string.Join("", args))}");
        }
    }
}