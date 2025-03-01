using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LoopsAndFunctions
{
    public static class DuplicatedElement
    {
       public static void FindDuplicates()
        {
            int[] numbers = { 4, 5, 9, 4,4 ,4, 7, 8, 5, 9, 2, 3, 3, 7 };
            Console.WriteLine("Duplicate elements:");

            for (int i = 0; i < numbers.Length; i++)
            {
                int count = 1; 

                if (numbers[i] == -1) 
                    continue;

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j]) 
                    {
                        count++; 
                        numbers[j] = -1; 
                    }
                }

                if (count > 1) 
                {
                    Console.WriteLine($"{numbers[i]} / {count} times.");
                }
            }
        }
    }
}
