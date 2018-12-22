using System;
using System.Collections.Generic;

namespace LeapYear
{
    class Program
    {
        static void Main(string[] args)
        {
            var leap = false;
            var input = new List<int> { 1800, 1900, 2100, 2200, 2300 , 2500, 2000, 2400, 1980 };

            foreach (var i in input)
            {
                if (i % 400 == 0)
                {
                    leap = true;
                    Console.WriteLine($"{i}:{leap}");
                }
                else if (i % 100 == 0)
                {
                    leap = false;
                    Console.WriteLine($"{i}:{leap}");
                }
                else if (i / 4 == 0)
                {
                    leap = true;
                    Console.WriteLine($"{i}:{leap}");
                }
                else
                {
                    leap = false;
                    Console.WriteLine($"{i}:{leap}");
                }
            }
        }
    }
}
