using Entities.Concretes;
using Entities.Concretes.Dtos;

namespace Business.Abstracts
{
    public interface ITechnologyService
    {
        List<Technology> GetAll();
        List<TechnologyListDto> GetAllWithDetails();
        Technology GetById(int id);
        TechnologyListDto GetByIdWithDetails(int id);
        void Add(Technology technology);
        void Update(Technology technology);
        void Delete(Technology technology);
    }
}
