using System;
using System.Web.Http;
using Contracts.IServices;

namespace WebApi.Controllers
{
    [RoutePrefix("api/persons")]
    public class PersonsController : ApiController
    {
        private IPersonService service;

        public PersonsController(IPersonService service)
        {
            this.service = service;
        }

        [HttpGet]
        [Route("")]
        public IHttpActionResult Get()
        {
            try
            {
                return Ok(service.GetAll());
            }
            catch (Exception e)
            {
                return InternalServerError(e.InnerException);
            }
        }
    }
}