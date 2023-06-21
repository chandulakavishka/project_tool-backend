using backend_part.DataAccess;
using backend_part.Models;
using backend_part.Services.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace backend_part.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : Controller
    {
        private readonly DataContext _context;
        public TaskController(DataContext context)
        {
            _context = context;
        }

        [HttpPost("task")]
        public async Task<List<UserTask>> AddTask(AddTask request)
        {
            var Task = new UserTask
            {
                InnovativeId = request.InnovativeId,
                TaskName = request.TaskName,
                DueDate = request.DueDate,
                Prograss = request.Prograss
            };
            _context.Tasks.Add(Task);
            await _context.SaveChangesAsync();
            var newTask = await _context.Tasks
                          .Where(t => t.InnovativeId == request.InnovativeId).ToListAsync();

            return newTask;
        }

        [HttpPost("edit")]
        public async Task<ActionResult<List<UserTask>>> EditTask(EditTask request)
        {

            var task = await _context.Tasks.FirstOrDefaultAsync(t => t.id == request.id);

            if (task == null)
            {
                return NotFound(); // Return appropriate status code if the task is not found
            }

            task.DueDate = request.DueDate;

            await _context.SaveChangesAsync();

            var updatedTasks = await _context.Tasks.ToListAsync();

            return updatedTasks;
        }

        [HttpPost("editPrograss")]
        public async Task<List<UserTask>> EditProgress(EditProgress request)
        {
            var Task = await _context.Tasks.FirstOrDefaultAsync(u => u.id == request.id);


            Task.Prograss = request.Prograss;

            await _context.SaveChangesAsync();

            var newTask = await _context.Tasks.ToListAsync();

            return newTask;
        }

        /*[HttpGet]
        public async Task<ActionResult> getTask()
        {
            var Task = await _context.Tasks.ToListAsync();


            if (Task == null)
            {
                return NotFound("Comment list is Empty..!");
            }

            return Ok(Task);
        }*/
        [HttpGet]
        public async Task<ActionResult> GetTask(int innovativeId)
        {
            var tasks = await _context.Tasks.Where(t => t.InnovativeId == innovativeId).ToListAsync();

            if (tasks == null || tasks.Count == 0)
            {
                return NotFound("No tasks found for the provided innovative ID.");
            }

            return Ok(tasks);
        }

        [HttpDelete("{id}")]
        public async Task<List<UserTask>> deleteTask(int id)
        {

            var Task = await _context.Tasks.FindAsync(id);


            _context.Tasks.Remove(Task);
            await _context.SaveChangesAsync();

            var newTask = await _context.Tasks.ToListAsync();

            return newTask;

        }




        [HttpGet("{taskId}")]
        public IActionResult GetUsernamesAndIdsByTaskId(int taskId)
        {
            var usernamesAndIds = _context.TaskUser
                .Where(ut => ut.TaskId == taskId)
                .Select(ut => new { ut.UserName, ut.UserId })
                .ToList();

            return Ok(usernamesAndIds);
        }


        // POST: api/tasks/{taskId}/user
        [HttpPost]
        public IActionResult AddUserToTask(int taskId, [FromBody] AddUserTask addUserTask)
        {
            if (!ModelState.IsValid)
                return BadRequest("Invalid model data");

            addUserTask.TaskId = taskId;

            _context.TaskUser.Add(addUserTask);
            _context.SaveChanges();

            return CreatedAtAction("GetUsernamesByTaskId", new { taskId = addUserTask.TaskId }, addUserTask);
        }


    }
}
