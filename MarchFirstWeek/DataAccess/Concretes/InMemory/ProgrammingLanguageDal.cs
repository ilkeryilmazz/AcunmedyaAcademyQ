using Core.DataAccess.Abstracts;
using Core.DataAccess.Concretes.InMemory;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes.InMemory
{
    public class ProgrammingLanguageDal : InMemoryRepositoryBase<ProgrammingLanguage>, IProgrammingLanguageDal
    {
    }
}
