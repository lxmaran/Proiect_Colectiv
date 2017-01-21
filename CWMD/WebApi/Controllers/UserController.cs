using Contracts.Dtos;
using Contracts.IServices;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Script.Serialization;

namespace WebApi.Controllers
{
    [RoutePrefix("api/users")]
    public class UserController : ApiController
    {
        private IUserService UserService { get; }

        public UserController(IUserService userService)
        {
            UserService = userService;
        }

        [HttpPost]
        [Route("sign-in")]
        public IHttpActionResult SignIn(UserDto user)
        {
            var u = UserService.FindUser(user.UserName, user.Password);
            return Ok();
        }

    }
}
