using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using backend_part.MODELS;
using backend_part.SERVICES.Task;
using backend_part.SERVICES.Users;

namespace backend_part.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        private ITaskRepository _TaskService;

        public TasksController(ITaskRepository UserRepo)
        {
            _TaskService = UserRepo;                                                                                                                                                                           
        }
        [HttpGet]
        public IActionResult GetUserTasks()
        {
            var Task = _TaskService.AllTasks();

            Task = Task.ToList();

            return Ok(Task);
        }
        [HttpGet("{TaskId?}")]
        public IActionResult GetUsers(int? TaskId)
        {
            var Task = _TaskService.AllTasks();

            if (Task == null) return Ok(Task);

            Task = Task.Where(t => t.TaskId == TaskId).ToList();

            return Ok(User);
        }

    }
}
