using Contracts.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;

namespace Services.Services
{
    public class UserService : IUserService
    {
        private IBaseEntityRepository<User> _userRepository;

        public UserService(IBaseEntityRepository<User> userRepository)
        {
            _userRepository = userRepository;
        }

        public User FindUser(string userName, string password)
        {
            using (var context = new MyDbContext())
            {
                var user = context.Users
                    .Where(u => (u.UserName == userName && u.Password == password))
                    .FirstOrDefault();

                return user;
            }
        }

        public IList<int> GetUserRoles(int userId)
        {
            using (var context = new MyDbContext())
            {
                var roles = context.People
                    .Where(p => p.Id == userId)
                    .Select(p => p.RoleId)
                    .ToList();

                return roles;
            }
        }
    }
}
