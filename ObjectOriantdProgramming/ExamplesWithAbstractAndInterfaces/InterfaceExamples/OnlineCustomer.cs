using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOriantdProgramming.ExamplesWithAbstractAndInterfaces.InterfaceExamples
{
    public class RetailCustomer : ICustomer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        
        public void DisplayCustomerInfo()
        {
            Console.WriteLine($"Customer Name: {Name}, Address: {Address}");
        }

    }
}
