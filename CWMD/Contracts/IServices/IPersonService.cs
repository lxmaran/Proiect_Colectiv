using System.Collections.Generic;
using Contracts.Dtos;

namespace Contracts.IServices
{
    public interface IPersonService
    {
        IEnumerable<PersonDto> GetAll();
    }
}
