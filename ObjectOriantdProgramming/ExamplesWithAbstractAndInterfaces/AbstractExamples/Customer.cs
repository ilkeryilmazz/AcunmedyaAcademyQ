using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOriantdProgramming.ExamplesWithAbstractAndInterfaces.AbstractExamples
{
    public abstract class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public abstract string GetCustomerType();

    }
}
