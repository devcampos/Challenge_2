using Challenge2.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Challenge2.Repository
{
    public class MultiplicationOp
    {
        public Complex Process(Complex a, Complex b)
        {
            var x = (a.Real * b.Real) - (a.Imaginary * b.Imaginary);
            var y = (a.Real * b.Imaginary) + (a.Imaginary * b.Real);

            return new Complex { Real = x, Imaginary = y };
        }
    }
}
