using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsAndFunctions
{
   public static class ReverseWordList
    {
        public static void Reverse()
        {
            List<string> words = new List<string>();
            Console.WriteLine("Enter words (type 'exit' to stop):");
            while (true)
            {
                Console.Write("Enter a word: ");
                string input = Console.ReadLine();

                if (input.ToLower() == "exit") 
                    break;

                words.Add(input); 
            }
            Console.WriteLine("Reversed words: ");

            for (int i = words.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(words[i]);
            }
        }
    }
}
