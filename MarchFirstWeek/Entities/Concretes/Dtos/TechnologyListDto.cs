using Core.Entities.Abstracts;

namespace Entities.Concretes.Dtos
{
    public class TechnologyListDto : IDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
    
        public string ProgrammingLanguageName { get; set; }
    }
} 