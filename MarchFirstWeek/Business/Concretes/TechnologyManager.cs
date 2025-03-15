using Business.Abstracts;
using Core.DataAccess.Abstracts;
using DataAccess.Abstracts;
using Entities.Concretes;
using Entities.Concretes.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class TechnologyManager : ITechnologyService
    {
        private readonly ITechnologyDal _technologyDal;
        private readonly IProgrammingLanguageService _languageService;

        public TechnologyManager(ITechnologyDal technologyDal, IProgrammingLanguageService languageService)
        {
            _technologyDal = technologyDal;
            _languageService = languageService;
        }

        public void Add(Technology technology)
        {
            Technology? lastTechnology = _technologyDal.GetAll().LastOrDefault();
            if (lastTechnology != null) 
                technology.Id = lastTechnology.Id + 1;
            _technologyDal.Add(technology);
        }

        public void Delete(Technology technology)
        {
            _technologyDal.Delete(technology);
        }

        public List<Technology> GetAll()
        {
            return _technologyDal.GetAll();
        }

        public List<TechnologyListDto> GetAllWithDetails()
        {
            var technologies = _technologyDal.GetAll();
            var dtos = new List<TechnologyListDto>();

            foreach (var tech in technologies)
            {
                var language = _languageService.GetById(tech.ProgrammingLanguageId);
                dtos.Add(new TechnologyListDto
                {
                    Id = tech.Id,
                    Name = tech.Name,
                   
                    ProgrammingLanguageName = language.Name
                });
            }

            return dtos;
        }

        public Technology GetById(int id)
        {
            return _technologyDal.Get(t => t.Id == id);
        }

        public TechnologyListDto GetByIdWithDetails(int id)
        {
            var tech = _technologyDal.Get(t => t.Id == id);
            if (tech == null) return null;

            var language = _languageService.GetById(tech.ProgrammingLanguageId);
            return new TechnologyListDto
            {
                Id = tech.Id,
                Name = tech.Name,
               
                ProgrammingLanguageName = language.Name
            };
        }

        public void Update(Technology technology)
        {
            _technologyDal.Update(technology);
        }
    }
}
