using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOriantdProgramming.ExamplesWithAbstractAndInterfaces.InterfaceExamples
{
    public interface ICustomer
    {
        int Id { get; set; }
        string Name { get; set; }
        string Address { get; set; }

        void DisplayCustomerInfo();

    }
}
