using Challenge2.Entities;
using Challenge2.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using static Challenge2.Enums;

namespace Challenge2.BL
{
    public static class Calculator
    {
        public static string Operator { get; private set; }

        /// <summary>
        /// Get instance from operation
        /// </summary>
        /// <param name="op">Sign input ("+", "-", "/", "x")</param>
        /// <returns>Instance Operation</returns>
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

        /// <summary>
        /// Method for display result of operation
        /// </summary>
        /// <param name="e">Complex Objext with result  after of execute Process method</param>
        /// <returns>String formmated</returns>
        public static string DisplayResultOperation(Complex e)
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

        /// <summary>
        /// Display input operation with it result .
        /// </summary>
        /// <param name="r">Complex object with result  after of  execute Process Method.</param>
        /// <param name="im">Complex object from first input</param>
        /// <param name="rOp">Complex object from secound input</param>
        public static void AllOperationDisplay(Complex r, Complex im, Complex rOp)
        {
            var result = DisplayResultOperation(rOp);
            switch (Operator)
            {
                case "+":
                    Console.WriteLine($"({r.Real},{r.Imaginary}i) + ({im.Real},{im.Imaginary}i) = ({result})");
                    break;
                case "-":
                    Console.WriteLine($"({r.Real},{r.Imaginary}i) - ({im.Real},{im.Imaginary}i) = ({result})");
                    break;
                case "x":
                    Console.WriteLine($"({r.Real},{r.Imaginary}i) * ({im.Real},{im.Imaginary}i) = ({result})");
                    break;
                case "/":
                    Console.WriteLine($"({r.Real},{r.Imaginary}i) / ({im.Real},{im.Imaginary}i) = ({result})");
                    break;
                default:
                    Console.WriteLine($"No Existe esa operacion {Operator}");
                    break;
            }
        }


        /// <summary>
        /// Method for valid input string
        /// </summary>
        /// <param name="s">String to Valid</param>
        /// <returns>Valid Complex object</returns>
        public static bool isValid(string s, TypeValidation type)
        {
            var result = false;
            switch (type)
            {
                case TypeValidation.Operator:
                    
                    string[] validOp = { "+", "-", "/", "x" };
                    if (Array.Exists(validOp, element => element == s))
                    {
                        result = true;
                    }
                    break;
                case TypeValidation.ComplexType:
                    Regex pattern = new Regex(@"^\(-?[0-9]\d*(\.\d+)?([*\,]-?[0-9]\d*(\.\d+)?)\)$");
                    var r = Regex.Replace(s, @"\s +", "");
                    Match match = pattern.Match(r);
                    if (match.Success)
                    {
                        result = true;
                    }
                    break;
                default:
                    break;
            }
            return result;
        }

        /// <summary>
        /// Transform string to Complex Object
        /// </summary>
        /// <param name="s">String with correct format.</param>
        /// <returns>Complex Object</returns>
        public static Complex TransfomComplex(string s)
        {
            Regex pattern = new Regex(@"^\(-?[0-9]\d*(\.\d+)?([*\,]-?[0-9]\d*(\.\d+)?)\)$");
            var r = Regex.Replace(s, @"\s +", "");
            Match match = pattern.Match(r);
            if (match.Success)
            {
                var value = match.Captures[0].Value;
                var x = float.Parse(value.Substring(value.IndexOf('(') + 1, value.LastIndexOf(',') - 1));
                var y = float.Parse(value.Substring(value.IndexOf(',') + 1, value.IndexOf(')') - value.IndexOf(',') - 1));

                return new Complex { Real = x, Imaginary = y };
            }

            return null;
        }


    }
}
