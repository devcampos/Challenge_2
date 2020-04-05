using Challenge2.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Challenge2.Repository
{
    public class DivisionOp : IStrategy
    {
        /// <summary>
        /// Execute Division Operation
        /// </summary>
        /// <param name="a">Firts Input of Complex Object</param>
        /// <param name="b">Secound Input of Complex Object</param>
        /// <returns>Complex object with result of operation</returns>
        public Complex Process(Complex a, Complex b)
        {
            float aux, x, y;
            if (modulo(a, b) == 0.0)
            {
                throw new ArgumentNullException("The divisor cannot be equal to zero");
            }
            else
            {
                aux = b.Real * b.Real + b.Imaginary * b.Imaginary;
                x = (a.Real * b.Real + a.Imaginary * b.Imaginary) / aux;
                y = (a.Imaginary * b.Real - a.Real * b.Imaginary) / aux;
            }

            return new Complex { Real = x, Imaginary = y };
        }

        private double modulo(Complex a, Complex b)
        {
            return Math.Sqrt(a.Real * b.Real + a.Imaginary * b.Imaginary);
        }

    }
}
