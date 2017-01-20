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
        private IUserRepository _userRepository;
        private IBaseEntityRepository<Person> _personRepo;

        public UserService(IUserRepository userRepository, IBaseEntityRepository<Person> personRepo)
        {
            _userRepository = userRepository;
            _personRepo = personRepo;
        }

        public User FindUser(string userName, string password)
        {
            var user = _userRepository.FindBy(u => u.UserName == userName && u.Password == password)
                .FirstOrDefault();

            var role = _userRepository.GetUserRole(user.Id);
            return user;
        }
    }
}
