using Entities.Concretes;

namespace Business.Abstracts
{
    public interface IProgrammingLanguageService
    {
        List<ProgrammingLanguage> GetAll();
        ProgrammingLanguage GetById(int id);
        void Add(ProgrammingLanguage programmingLanguage);
        void Update(ProgrammingLanguage programmingLanguage);
        void Delete(ProgrammingLanguage programmingLanguage);
    }
}
