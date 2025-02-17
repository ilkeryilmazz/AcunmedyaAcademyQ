using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndConditions
{
    public static class Calculator
    {
        public static void Calculate()
        {
            Console.Write("Enter a number one: ");
            double numberOne = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter a number second: ");
            double numberSecond = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("-----------------------");

            Console.Write("Select your calculating proccess. ( +, -, /, * ): ");
            string proccess = Console.ReadLine();

            switch (proccess)
            {
                case "-":
                    Console.WriteLine("Calculated: " + (numberOne - numberSecond));
                    break;
                case "+":
                    Console.WriteLine("Calculated: " + (numberOne+ numberSecond));
                    break;
                case "*":
                    Console.WriteLine("Calculated: " + (numberOne* numberSecond));
                    break;
                case "/":
                    Console.WriteLine(numberSecond != 0 ? $"Calculated: {numberOne / numberSecond}" : "Invalid Input");
                    break;
                default:
                    Console.WriteLine("Invalid proccess");
                    break;
            }

        }
    }
}
