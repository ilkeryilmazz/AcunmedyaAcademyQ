using Business.Abstracts;
using Core.DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class ProgrammingLanguageManager : IProgrammingLanguageService
    {
        private readonly IProgrammingLanguageDal _languageDal;

        public ProgrammingLanguageManager(IProgrammingLanguageDal languageDal)
        {
            _languageDal = languageDal;
        }

        public void Add(ProgrammingLanguage programmingLanguage)
        {
            ProgrammingLanguage? lastProgrammingLanguage = _languageDal.GetAll().LastOrDefault();
            if (lastProgrammingLanguage!=null)
                programmingLanguage.Id = lastProgrammingLanguage.Id + 1;
            
            
            _languageDal.Add(programmingLanguage);
        }

        public void Delete(ProgrammingLanguage programmingLanguage)
        {
            _languageDal.Delete(programmingLanguage);
        }

        public List<ProgrammingLanguage> GetAll()
        {
            return _languageDal.GetAll();
        }

        public ProgrammingLanguage GetById(int id)
        {
            return _languageDal.Get(l => l.Id == id);
        }

        public void Update(ProgrammingLanguage programmingLanguage)
        {
            _languageDal.Update(programmingLanguage);
        }
    }
}
