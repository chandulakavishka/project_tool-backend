using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using backend_part.MODELS;
using backend_part.SERVICES.Task;

namespace backend_part.SERVICES.Tasks
{
    public class TaskSqlService : ITaskRepository
    {
        private readonly DbAccess _context = new DbAccess();

        public List<UserTasks> AllTasks()
        {
            var Tasks = _context.Tasks.ToList();

            return Tasks;
        }
        public UserTasks AllTask(CurrentProgrress CurrentProgrress)
        {
            var Task = _context.Tasks.Find(1);

            return Task;
        }



    }
}
