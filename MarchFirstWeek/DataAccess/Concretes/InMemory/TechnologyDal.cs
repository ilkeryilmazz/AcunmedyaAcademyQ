using Core.DataAccess.Concretes.InMemory;
using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes.InMemory
{
    public class TechnologyDal:InMemoryRepositoryBase<Technology>, ITechnologyDal
    {
    }
}
