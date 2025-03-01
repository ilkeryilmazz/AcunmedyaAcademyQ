using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsAndFunctions
{
    public static class AgeDetermine
    {

        public static void Determine()
        {
            List<int> ages = new List<int> { 5, 16, 25, 70, 40, 12, 19, 64, 65 };
            foreach (int age in ages)
            {
                if (age >= 0 && age <= 12)
                    Console.WriteLine("You are a child");
                else if (age >= 13 && age <= 19)
                    Console.WriteLine("You are a teenager");
                else if (age >= 20 && age <= 64)
                    Console.WriteLine("You are an adult");
                else
                    Console.WriteLine("You are an old");
            }
        }
    }
}