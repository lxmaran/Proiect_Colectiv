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

        void AddTask(int documentId, int flowTypeId);

        void UpdateAnswear(int taskId, int answearId);
    }
}
