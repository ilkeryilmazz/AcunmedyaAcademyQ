using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOriantdProgramming.Entities.Employee
{
  public class Developer:Employee
    {
        public Developer(int id, string name, double salary, string department, string about) : base(id, name, salary, department)
        {
            About = about;
        }

        public string About { get; set; }
        public override double CalculateSalary()
        {
            return Salary + Salary * 0.1;
        }
    }

}
