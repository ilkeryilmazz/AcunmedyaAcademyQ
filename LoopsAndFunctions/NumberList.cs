using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsAndFunctions
{
   public static class NumberList
    {
        public static void NumberSortAndGetAvarege()
        {
            List<int> numbers = new List<int>(); 

            Console.WriteLine("Enter numbers (type '0' to stop):");

            while (true)
            {
                Console.Write("Enter a number: ");
                string input = Console.ReadLine();

                if (input == "0") 
                    break;

                int number = Convert.ToInt32(input); 
                numbers.Add(number); 
            }

            if (numbers.Count == 0) 
            {
                Console.WriteLine("No numbers were entered.");
                return;
            }

            numbers.Sort(); 

            int sum = 0;
            foreach (int num in numbers) 
            {
                sum += num;
            }

            double average = (double)sum / numbers.Count;

            Console.WriteLine("Sorted numbers:");
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine("Average of numbers: " + average);
        }
    }

    
}
