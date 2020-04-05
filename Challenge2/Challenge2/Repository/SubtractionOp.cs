using Challenge2.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Challenge2.Repository
{
    public class SubtractionOp
    {
        public Complex Process(Complex a, Complex b)
        {
            var x = a.Real - b.Real;
            var y = a.Imaginary - b.Imaginary;

            return new Complex { Real = x, Imaginary = y };
        }
    }
}
