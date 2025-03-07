using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOriantdProgramming.Entities.Employee
{
    public class Employee
    {
        public Employee(int id, string name, double salary, string department)
        {
            Id = id;
            Name = name;
            Salary = salary;
            Department = department;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public string Department { get; set; }

        

        public virtual double CalculateSalary()
        {
            return Salary;
        }
    }
}
