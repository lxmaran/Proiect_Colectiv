using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.Models;

namespace WebApi.Controllers
{
    [RoutePrefix("api/answers")]
    public class AnswersController : ApiController
    {
        [HttpGet]
        [Route("")]
        public IHttpActionResult Get()
        {
            return Ok(new List<AnswerDto>
            {
                new AnswerDto(){ AnswerId = 1, Name = "answer1"},
                new AnswerDto(){ AnswerId = 2, Name = "answer2"},
                new AnswerDto(){ AnswerId = 3, Name = "answer3"},
            });
        }

        // GET: api/Answers/5
        public string Get(int id)
        {
            return "value";
        }
    }
}
