using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndConditions
{
    public static class NumberDetermining
    {
        public static void NumberDetermine()
        {

            Console.Write("Enter a number: ");
            double number = Convert.ToDouble(Console.ReadLine());

            if (number > 0)
            {
                Console.WriteLine("Number is positive");
            }
            else if (number < 0)
            {
                Console.WriteLine("Number is negative");
            }
            else
            {
                Console.WriteLine("Number is zero");
            }
        }

        public static void NumberDetermine(bool useTenraryOperator)
        {
            Console.Write("Enter a number: ");
            double number = Convert.ToDouble(Console.ReadLine());


            string result = number > 0 ? "Number is positive" : number < 0 ? "Number is negative" : "Number is zero";

            Console.WriteLine(result);
        }

        public static void FindBiggestNumber()
        {
            Console.Write("Enter a number one: ");
            double numberOne = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter a number second: ");
            double numberSecond = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter a number Third: ");
            double numberThird = Convert.ToDouble(Console.ReadLine());

            if (numberOne >= numberSecond && numberOne >= numberThird)
            {
                Console.WriteLine("The Biggest Number Is: " + numberOne);
            }
            else if (numberSecond >= numberOne && numberSecond >= numberThird)
            {
                Console.WriteLine("The Biggest Number Is: " + numberSecond);
            }
            else
            {
                Console.WriteLine("The Biggest Number Is: " + numberThird);
            }

        }
    }
}
