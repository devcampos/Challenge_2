using Challenge2.Entities;
using System;

namespace Challenge2
{
    class Program
    {
        static void Main(string[] args)
        {

            var a = new Complex { Real = 2, Imaginary = -7 };
            var b = new Complex { Real = 4, Imaginary = 3 };

            var s = new SumOp();
            var r = s.Process(a, b);
            Console.WriteLine($"Suma es : ({r.Real},{r.Imaginary})");

            Console.ReadKey();
        }
    }
}
