using System;

namespace lab3
{
    class Program
    {
        static void Main(string[] args)
        {

            string str = "-2 +-5";
            Console.WriteLine(str);
            Calculator.FormatString(ref str);
            Console.WriteLine(str);
        }
    }
}