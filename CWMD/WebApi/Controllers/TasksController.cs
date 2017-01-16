using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.Models;

namespace WebApi.Controllers
{
    [RoutePrefix("api/tasks")]
    public class TasksController : ApiController
    {
        [HttpGet]
        [Route("")]
        public IHttpActionResult Get()
        {
            return Ok(new List<TaskDto>
            {
                new TaskDto
                {
                    TaskId = 1,
                    Document = "doc1",
                    Flux = "flux1",
                    Answer = new AnswerDto
                    {
                        AnswerId = 1,
                        Name = "answer1"
                    }
                },
                new TaskDto
                {
                    TaskId = 2,
                    Document = "doc2",
                    Flux = "flux2",
                    Answer = new AnswerDto
                    {
                        AnswerId = 2,
                        Name = "answer2"
                    }
                },
            });
        }

        [HttpPut]
        [Route("{taskId}")]
        public IHttpActionResult Get(int taskId, TaskDto task)
        {
            return Ok();
        }
    }
}
