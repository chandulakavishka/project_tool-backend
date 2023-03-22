﻿using backend_part.Services.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;

namespace backend_part.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
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
            };
            _context.Tasks.Add(Task);
            await _context.SaveChangesAsync();
            var newTask = await _context.Tasks.ToListAsync();

            return newTask;
        }

        [HttpPost("edit")]
        public async Task<List<UserTask>> EditTask(EditTask request)
        {
            var Task = await _context.Tasks.FirstOrDefaultAsync(u => u.id == request.id);

            Task.TaskName = request.TaskName;
            Task.DueDate = request.DueDate;

            await _context.SaveChangesAsync();

            var newTask = await _context.Tasks.ToListAsync();

            return newTask;
        }

        [HttpGet]
        public async Task<ActionResult> getTask()
        {
            var Task = await _context.Tasks.ToListAsync();


            if (Task == null)
            {
                return NotFound("Comment list is Empty..!");
            }

            return Ok(Task);
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
    }
}