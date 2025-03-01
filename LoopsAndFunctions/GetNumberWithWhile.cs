using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsAndFunctions
{
   public static class GetNumberWithWhile
    {
        public static void Get()
        {
            int number;

            Console.Write("Enter a number 10-100: ");
            number = Convert.ToInt32(Console.ReadLine()); 

            while (number < 10 || number > 100) 
            {
                Console.Write("Invalid Input: ");
                number = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Valid Input: " + number);
        }
    }
}
