using Dal;
using System.Collections.Generic;

namespace Contracts.IServices
{
    public interface IPersonService
    {
        IEnumerable<Person> GetAll();
    }
}
