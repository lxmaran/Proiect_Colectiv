using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class UserRepository : BaseEntityRepository<User>, IUserRepository
    {
        public UserRepository(IMyDbContext context) : base(context)
        {
        }

        public Role GetUserRole(int userId)
        {
            var userRole = (from p in DbContext.People
                            join r in DbContext.Roles on p.RoleId equals r.Id
                            where p.Id == userId
                            select r).FirstOrDefault();

            return userRole;
        }
    }
}
