using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsAndFunctions
{
   public static class NumberFilter
    {
        public static void Filter()
        {
            List<int> numbers = new List<int> { 5, 12, 3, 20, 8, 15, 2, 11 };

            numbers.RemoveAll(number => number < 10); 

            Console.WriteLine("Number List: ");
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }

        }
    }
}
