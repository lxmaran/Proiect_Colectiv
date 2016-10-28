using System.Collections.Generic;
using System.Linq;
using Contracts.Dtos;
using Contracts.IServices;
using Dal;

namespace Services.Services
{
    public class PersonService : IPersonService
    {
        public IMyDbContext context { get; set; }
        public PersonService()
        {
            context = new MyDbContext();
        }

        public IEnumerable<PersonDto> GetAll()
        {
            return context.People.Select(x => new PersonDto() { Id = x.Id, Name = x.Name }).ToList();
        }
    }
}
