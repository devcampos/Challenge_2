using Challenge2.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Challenge2.Repository
{
    public class AdditionOp : IStrategy
    {
        /// <summary>
        /// Execute Additon Operation
        /// </summary>
        /// <param name="a">Firts Input of Complex Object</param>
        /// <param name="b">Secound Input of Complex Object</param>
        /// <returns>Complex object with result of operation</returns>
        public Complex Process(Complex a, Complex b)
        {
            var x = a.Real + b.Real;
            var y = a.Imaginary + b.Imaginary;

            return new Complex { Real = x, Imaginary = y };
        }
    }
}
