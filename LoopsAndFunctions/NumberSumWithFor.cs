using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsAndFunctions
{
    public static class NumberSumWithFor
    {
        public static void Sum()
        {
            Console.Write("Enter a number: ");
            int sum = 0;



            for (int number = Convert.ToInt32(Console.ReadLine()); number > 0; number /= 10) 
            {
                int digit = number % 10; 
                sum += digit; 
            }

            Console.WriteLine($"The sum of the digits is: "+sum);
        }

    }
}
