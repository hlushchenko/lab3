using System;

namespace lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            string stas = "(4+-3)     * 67*-45";
            Console.WriteLine(stas);
            string[] stacik = Calculator.FormatString(stas);
            for (int i = 0; i < stacik.Length; i++)
            {
                Console.WriteLine(stacik[i]);
            }
        }
    }
}