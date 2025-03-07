using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOriantdProgramming.ExamplesWithAbstractAndInterfaces.AbstractExamples
{
    public class RetailCustomer : Customer
    {
        public override string GetCustomerType()
        {
            return "Retail Customer";
        }
    }
}
