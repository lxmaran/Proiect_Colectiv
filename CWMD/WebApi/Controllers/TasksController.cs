using Contracts.IServices;
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
        private ITaskService TaskService { get; }

        public TasksController(ITaskService taskService)
        {
            TaskService = taskService;
        }

        [HttpGet]
        [Route("")]
        public IHttpActionResult Get()
        {
            var tasks = TaskService.GetAll().Select(
                t => new TaskDto
                {
                    TaskId = t.Id,
                    Answer = (t.Answare != null) ? new AnswerDto { AnswerId = t.Answare.Id, Name = t.Answare.Name} : null,
                    Document = t.Document.Name,
                    Flux = t.FlowType.Type
                    }).ToList();
            return Ok(tasks);
        }

        [HttpPut]
        [Route("{taskId}")]
        public IHttpActionResult Get(int taskId, TaskDto task)
        {
            TaskService.UpdateAnswear(taskId, task.Answer.AnswerId);
            return Ok();
        }
    }
}
