using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Calculator.Calculate(string.Join("", args)));
        }
    }
}