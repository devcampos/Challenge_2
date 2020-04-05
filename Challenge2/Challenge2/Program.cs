using Challenge2.Entities;
using Challenge2.Repository;
using System;
using static Challenge2.BL.Calculator;

namespace Challenge2
{
    class Program
    {
        static void Main(string[] args)
        {

            var a = new Complex { Real = 2, Imaginary = -7 };
            var b = new Complex { Real = 4, Imaginary = 3 };

            var i = "-";
            IStrategy strategy = GetOperation(i);
            if (strategy != null)
            {
                var x = strategy.Process(a, b);
             
                Console.WriteLine(strategy.Display(x));
            }

            Console.ReadKey();
        }
    }
}
