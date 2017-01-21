using Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Contracts.IServices
{
    public interface ITaskService
    {
        IEnumerable<Task> GetAll();

        void AddTask(Task task);

        void UpdateAnswear(int taskId, int answearId);
    }
}
