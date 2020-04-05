using Challenge2.Entities;
using Challenge2.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Challenge2.BL
{
    public static class Calculator
    {
        public static string Operator { get; private set; }

        public static IStrategy GetOperation(String op)
        {
            Operator = op;
            switch (op)
            {
                case "+":
                    return new AdditionOp();
                case "-":
                    return new SubtractionOp();
                case "x":
                    return new MultiplicationOp();
                case "/":
                    return new DivisionOp();
                default:
                    return null;
            }
        }


        


    }
}
