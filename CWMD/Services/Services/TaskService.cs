using Contracts.IServices;
using Dal;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace Services.Services
{
    public class TaskService : ITaskService
    {
        private IMyDbContext context;

        public TaskService()
        {
            context = new MyDbContext();
        }

        public void AddTask(int documentId, int flowTypeId)
        {
            var task = new Task { PrincipalDocumentId = documentId, FlowTypeId = flowTypeId };
            context.Tasks.Add(task);
            context.SaveChanges();
        }

        public IEnumerable<Task> GetAll()
        {
            var tasks = context.Tasks
                .Include("Document")
                .Include("Answare")
                .Include("FlowType")
                .ToList();
            return tasks;
        }

        public void UpdateAnswear(int taskId, int answearId)
        {
            var taskToUpdate = context.Tasks.FirstOrDefault(t => t.Id == taskId);
            taskToUpdate.AnswareId = answearId;
            context.SaveChanges();
        }
    }
}
