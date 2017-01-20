using Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public abstract class BaseEntityService
    {
        protected readonly IBaseEntityRepository<Log> _logger;
    }
}
