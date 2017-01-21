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
        private readonly IMyDbContext context;
        public UserService(IMyDbContext context)
        {
            this.context = context;
        }

        public User FindUser(string userName, string password)
        {
            var user =context.Users.Where(u => u.UserName == userName && u.Password == password)
                .FirstOrDefault();
            return user;
        }
    }
}
