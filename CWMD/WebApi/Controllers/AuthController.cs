using Contracts.IServices;
using Newtonsoft.Json;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Web.ClientServices.Providers;
using System.Web.Http;
using System.Web.Http.Results;

namespace WebApi.Controllers
{
    [RoutePrefix("api/auth")]
    public class AuthController : ApiController
    {
        private IUserService UserService { get; }

        public AuthController(IUserService userService)
        {
            UserService = userService;
        }

        [Route("")]
        [HttpPost]
        public IHttpActionResult Post(Credentials c)
        {
            var user = UserService.FindUser(c.Username, c.Password);
            if (user != null)
            {
                return Ok();
            }
            return NotFound();
        }
    }

    public class Credentials
    {
        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }
    }
}
