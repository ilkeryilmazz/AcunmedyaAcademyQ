using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOriantdProgramming.Entities.Employee
{
   public class Manager:Employee
    {
        public Manager(int id, string name, double salary, string department, int teamSize) : base(id, name, salary, department)
        {
            TeamSize = teamSize;
        }

        public int TeamSize { get; set; }
        override public double CalculateSalary()
        {
            return Salary + Salary * 0.2;
        }
    }
}
