using Core.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Technology:BaseEntity
    {
        public int ProgrammingLanguageId { get; set; }
        public string Name { get; set; }
        
    }
}
