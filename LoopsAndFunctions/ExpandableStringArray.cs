using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsAndFunctions
{
    public class ExpandableStringArray
    {


        private static string[] words = new string[1]; 
        private static int count = 0; 

        public static void AddWord()
        {
            Console.WriteLine("Enter words (type 'exit' to stop):");

            while (true)
            {
                Console.Write("Enter a word: ");
                string input = Console.ReadLine();

                if (input.ToLower() == "exit")
                    break;

                if (count == words.Length) 
                {
                    ExpandArray();
                }

                words[count] = input;
                count++;
            }
        }

        private static void ExpandArray()
        {
            string[] newArray = new string[words.Length * 2]; 
            for (int i = 0; i < words.Length; i++)
            {
                newArray[i] = words[i]; 
            }
            words = newArray;
        }

        public static void Words()
        {
            Console.WriteLine("Final words array:");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(words[i]);
            }
        }

        public static void Run()
        {
            AddWord();
            Words();
        }
    }

    

}
