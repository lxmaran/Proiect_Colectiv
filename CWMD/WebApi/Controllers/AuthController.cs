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
        [Route("")]
        [HttpPost]
        public IHttpActionResult Post(Credentials c)
        {
            if (c.Username == "admin@admin.admin" && c.Password == "admin")
            {
                return Ok();
            }
            return NotFound();
        }
    }

    public class Credentials
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
