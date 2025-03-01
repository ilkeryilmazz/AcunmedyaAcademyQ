using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsAndFunctions
{
    public static class GradeUpdater
    {
        public static void Update()
        {
            List<int> grades = new List<int> { 45, 78, 30, 90, 50, 42, 67, 49 };

            for (int i = 0; i < grades.Count; i++)
            {
                if (grades[i] < 50)
                {
                    grades[i] = 50;
                }
            }
            Console.WriteLine("New grades:");
            foreach (int grade in grades)
            {
                Console.Write(grade + " ");
            }
        }
    }
}
