using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using Contracts.Dtos;

namespace Contracts.IServices
{
    public interface IPersonService
    {
        IEnumerable<PersonDto> GetAll();
    }
}
