using backend_part.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace backend_part.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InnovativeController : ControllerBase
    {
        private readonly DataContext _context;
        public InnovativeController(DataContext context)
        {
            _context = context;
        }

        [HttpPost("add-innovative")]
        public async Task<IActionResult> Innovative(Innovative request)
        {

            var Innovative = new Innovative
            {
                ProjectId= request.ProjectId,
                InnovativeName= request.InnovativeName,
                Status= request.Status,
                Prograss= request.Prograss,
                StartDate = DateTime.Now
        };
           
            _context.Innovatives.Add(Innovative);
            await _context.SaveChangesAsync();

            return Ok("Add Innovatives Sucessful..!");
        }

        [HttpGet]
        public async Task<ActionResult> getInnovative()
        {
            var Innovative = await _context.Innovatives.ToListAsync();


            if (Innovative == null)
            {
                return NotFound("Innovative list is Empty..!");
            }

            return Ok(Innovative);
        }
    }
}
