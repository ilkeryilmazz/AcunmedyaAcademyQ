using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsAndFunctions
{
    public static class SentenceToArrayAndSort
    {
        public static void ConvertAndShort()
        {
            Console.WriteLine("Enter a sentence: ");
            string sentence = Console.ReadLine();
            string[] words = sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            Array.Sort(words);

            Console.WriteLine("Sorted array: ");
            foreach (string word in words)
            {
                Console.Write(word + " ");
            }
        }
    }
}
