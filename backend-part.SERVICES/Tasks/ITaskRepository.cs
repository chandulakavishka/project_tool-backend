using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using backend_part.MODELS;

namespace backend_part.SERVICES.Task
{
    public interface ITaskRepository
    {
        public List<UserTasks> AllTasks();

        public UserTasks AllTask(CurrentProgrress CurrentProgrress);
    }
}
