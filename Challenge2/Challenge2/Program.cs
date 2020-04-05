using Challenge2.Entities;
using Challenge2.Repository;
using System;

namespace Challenge2
{
    class Program
    {
        static void Main(string[] args)
        {

            var a = new Complex { Real = 2, Imaginary = -7 };
            var b = new Complex { Real = 4, Imaginary = 3 };

            var add = new AdditionOp();
            var r = add.Process(a, b);
            Console.WriteLine($"Addition is : ({r.Real},{r.Imaginary})");


            var sb = new SubtractionOp();
            var r2 = sb.Process(a, b);
            Console.WriteLine($"Subtraction is : ({r2.Real},{r2.Imaginary})");

            var ml = new MultiplicationOp();
            var r3 = ml.Process(a, b);
            Console.WriteLine($"Multiplication is : ({r3.Real},{r3.Imaginary})");

            var dv = new DivisionOp();
            var r4 = dv.Process(a, b);
            Console.WriteLine($"Divition is : ({r4.Real},{r4.Imaginary})");


            Console.ReadKey();
        }
    }
}
