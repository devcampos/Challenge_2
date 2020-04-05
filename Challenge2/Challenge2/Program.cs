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
            var r1 = add.Process(a, b);
            Console.WriteLine($"Addition is: {add.Display(r1)}");


            var sb = new SubtractionOp();
            var r2 = sb.Process(a, b);
            Console.WriteLine($"Subtraction is: {sb.Display(r2)}");

            var ml = new MultiplicationOp();
            var r3 = ml.Process(a, b);
            Console.WriteLine($"Multiplication is: {ml.Display(r3)}");

            var dv = new DivisionOp();
            var r4 = dv.Process(a, b);
            Console.WriteLine($"Divition is: {dv.Display(r4)}");


            Console.ReadKey();
        }
    }
}
