using System;
using System.Diagnostics.Eventing.Reader;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = 5;
            int number2 = 2;

            if (Calculator.Multiply(number1, number2)) == 10)
            {
                Console.WriteLine($"Multiplcation of {number1} and {number2} works as expecte");
            }

            else 
       
            {
                Console.WriteLine($"Error when multiplying {number1} and {number2}!");
            }

            if (Calculator.Multiply(5, 2) == 10)
            {
                Console.WriteLine($"Multiplication of {number1} and {number2}!");
            }

            else 
            
            {
                Console.WriteLine($"Error when multiplying {number1} and {number2}!");
            }
        }

        }
    }
}
