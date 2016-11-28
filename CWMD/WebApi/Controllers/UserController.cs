using Contracts.AuthenticationHelpers;
using Contracts.Constants;
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
        private readonly Lazy<IUserService> userServiceLazy;
        private readonly Lazy<IAuthenticationHelper> authenticationHelperLazy;
        private IUserService UserService { get { return userServiceLazy.Value; } }
        private IAuthenticationHelper AuthenticationHelper { get { return authenticationHelperLazy.Value; } }

        public UserController(Lazy<IUserService> userServiceLazy, Lazy<IAuthenticationHelper> authenticationHelperLazy)
        {
            this.userServiceLazy = userServiceLazy;
            this.authenticationHelperLazy = authenticationHelperLazy;
        }

        [HttpPost]
        [EnableCors("*", "*", "*", "*")]
        [Route("signin")]
        public async Task<string> SignIn([FromBody] UserDto user)
        {
            var apiBaseUrl = ConfigurationManager.AppSettings[StringConstants.ApiBaseUrl];
            var token = await AuthenticationHelper.GetAuthorizationToken(apiBaseUrl, user.UserName, user.Password);
            return token;
        }

    }
}
