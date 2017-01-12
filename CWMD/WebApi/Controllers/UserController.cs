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
        private IUserService userService { get; }
        private IAuthenticationHelper authenticationHelper { get; }

        public UserController(IUserService userService, IAuthenticationHelper authenticationHelper)
        {
            this.userService = userService;
            this.authenticationHelper = authenticationHelper;
        }

        [HttpPost]
        [EnableCors("*", "*", "*", "*")]
        [Route("signin")]
        public IHttpActionResult SignIn([FromBody] UserDto user)
        {
            var apiBaseUrl = ConfigurationManager.AppSettings[StringConstants.ApiBaseUrl];
            var token = authenticationHelper.GetAuthorizationToken(apiBaseUrl, user.UserName, user.Password);
            return Ok(token);
        }

    }
}
