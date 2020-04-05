using Challenge2.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Challenge2.Repository
{
    public class MultiplicationOp : IStrategy
    {
        /// <summary>
        /// Execute Multiplication Operation
        /// </summary>
        /// <param name="a">Firts Input of Complex Object</param>
        /// <param name="b">Secound Input of Complex Object</param>
        /// <returns>Complex object with result of operation</returns>
        public Complex Process(Complex a, Complex b)
        {
            var x = (a.Real * b.Real) - (a.Imaginary * b.Imaginary);
            var y = (a.Real * b.Imaginary) + (a.Imaginary * b.Real);

            return new Complex { Real = x, Imaginary = y };
        }

    }
}
