using Challenge2.Entities;
using Challenge2.Repository;
using System;
using static Challenge2.BL.Calculator;
using static Challenge2.Enums;

namespace Challenge2
{
    class Program
    {
        static void Main(string[] args)
        {
            var first = GetInput("Give me your first input with the follow formmat: (4,-8)", TypeValidation.ComplexType);
            if (!String.IsNullOrEmpty(first))
            {
                var secound = GetInput("Give me your secound input with the follow formmat: (4.20,-8000.10)", TypeValidation.ComplexType);
                if (!String.IsNullOrEmpty(secound))
                {                   
                    var op = GetInput("Give me the operation that you want realize. Can be + ,  - ,  / or x", TypeValidation.Operator);                                        
                    if (op != null)
                    {
                        IStrategy strategy = GetOperation(op);
                        var f = TransfomComplex(first);
                        var s = TransfomComplex(secound);
                        var x = strategy.Process(f, s);
                        AllOperationDisplay(f, s, x);
                    }
                }
            }
            var a = new Complex { Real = 0, Imaginary = 0 };
            var b = new Complex { Real = 0, Imaginary = 0 };

            Console.WriteLine("Press any key for exit.");
            Console.ReadKey();
        }

        /// <summary>
        /// Method for valid
        /// </summary>
        /// <param name="Prompt">String input</param>
        /// <returns></returns>
        public static string GetInput(string Prompt, TypeValidation type)
        {
            string Result = "";
            var valid = false;
            do
            {
                Console.Write(Prompt + ": ");
                Result = Console.ReadLine();
                
                if (string.IsNullOrEmpty(Result))
                {                  
                    Console.WriteLine("Empty input, please try again");                    
                }
                else
                {
                    valid = isValid(Result, type);
                    if (!valid)
                    {
                        switch (type)
                        {
                            case TypeValidation.Operator:
                                Console.WriteLine("No exist operator try again.");
                                break;
                            case TypeValidation.ComplexType:
                                Console.WriteLine("Bad format, please try again.");
                                break;
                            default:
                                break;
                        }
                        
                        Result = "";
                    }                    
                }
            } while (!valid);
            return Result;
        }

    }
}
