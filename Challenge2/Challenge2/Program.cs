using Challenge2.Entities;
using Challenge2.Repository;
using System;
using static Challenge2.BL.Calculator;

namespace Challenge2
{
    class Program
    {
        static void Main(string[] args)
        {

            
            var first = GetInput("Give me your first input with the follow formmat: (4,-8)");
            if (!String.IsNullOrEmpty(first))
            {
                var secound = GetInput("Give me your secound input with the follow formmat: (4.20,-8000.10)");
                if (!String.IsNullOrEmpty(secound))
                {
                    Console.WriteLine("Give me the operation that you want realize. Can be + ,  - ,  / or x");
                    IStrategy strategy = GetOperation(Console.ReadLine());
                    if (strategy != null)
                    {
                        var f = isValid(first);
                        var s = isValid(secound);
                        var x = strategy.Process(f, s);                        
                        AllOperationDisplay(f, s, x);
                    }
                    else
                    {
                        Console.WriteLine("No exist operator try again.");
                    }
                }
            }
            Console.WriteLine("Press any key for exit.");
            Console.ReadKey();
        }

        /// <summary>
        /// Method for valid
        /// </summary>
        /// <param name="Prompt">String input</param>
        /// <returns></returns>
        public static string GetInput(string Prompt)
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
                    if (isValid(Result) == null)
                    {
                        Console.WriteLine("Bad format, please try again");
                        Result = "";
                    }
                    else
                    {
                        valid = true;                       
                    }
                }
            } while (!valid);
            return Result;
        }

    }
}
