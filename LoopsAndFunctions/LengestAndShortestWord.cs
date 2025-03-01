using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsAndFunctions
{
    public static class LongestAndShortestWord
    {
        public static void Find()
        {
            string[] words = { "merhaba", "selam", "ben", "ilker", "yılmaz"};

            string shortest = words[0];
            string longest = words[0];

            foreach (string word in words)
            {
                if (word.Length < shortest.Length)
                    shortest = word;

                if (word.Length > longest.Length)
                    longest = word;
            }

            Console.WriteLine($"Shortest word: {shortest}");
            Console.WriteLine($"Longest word: {longest}");

        }
    }
}
