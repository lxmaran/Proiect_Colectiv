using Contracts.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.DtoConverter;
using WebApi.Models;

namespace WebApi.Controllers
{
    [RoutePrefix("api/answers")]
    public class AnswersController : ApiController
    {
        IAnswerService AnswerService { get; }

        public AnswersController(IAnswerService _answerService)
        {
            this.AnswerService = _answerService;
        }

        [HttpGet]
        [Route("")]
        public IHttpActionResult Get()
        {
            var answers = new List<AnswerDto>();
            var ans = AnswerService.GetAll();
            answers = ans.Select(a => a.ToAnswerDto()).ToList();
            return Ok(answers);
        }

        public IHttpActionResult Get(int id)
        {
            var answear = AnswerService.GetAnswer(id);
            return Ok(answear);
        }
    }
}
