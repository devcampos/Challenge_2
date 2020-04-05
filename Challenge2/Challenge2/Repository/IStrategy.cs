using Challenge2.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Challenge2.Repository
{
    public interface IStrategy
    {
        Complex Process(Complex a, Complex b);  
    }
}
