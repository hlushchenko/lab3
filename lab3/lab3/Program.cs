using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Calculator.Calculate( string.Join("", args)));

        }
    }
}