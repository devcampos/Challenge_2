using Challenge2.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Challenge2.Repository
{
    public class MultiplicationOp : IStrategy
    {
        public Complex Process(Complex a, Complex b)
        {
            var x = (a.Real * b.Real) - (a.Imaginary * b.Imaginary);
            var y = (a.Real * b.Imaginary) + (a.Imaginary * b.Real);

            return new Complex { Real = x, Imaginary = y };
        }

        public string Display(Complex e)
        {
            if (e.Imaginary == 0)
            {
                return e.Real.ToString();
            }

            if (e.Real == 0)
            {
                return $"{e.Imaginary} i";
            }
            if (e.Imaginary < 0)
            {
                return $"{e.Real}{e.Imaginary}i";
            }

            return $"{e.Real} + {e.Imaginary}i";
        }
    }
}
