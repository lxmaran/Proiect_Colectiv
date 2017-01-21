using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public interface IUserRepository: IBaseEntityRepository<User>
    {
        Role GetUserRole(int userId);
        User getCurrentUser();
    }
}
