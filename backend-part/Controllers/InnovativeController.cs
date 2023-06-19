using backend_part.Models;
using backend_part.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using backend_part.DataAccess;
using backend_part.Data;


namespace backend_part.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InnovativeController : ControllerBase
    {
        private readonly IInnovative repo;

        public InnovativeController(IInnovative _repo)
        {

            repo = _repo;
        }


        [HttpGet]
        [Route("id")]
        public ActionResult<Innovative> GetInnovative(int id)
        {
            try
            {
                var innovative_ = repo.GetInnovative(id);
                

                return Ok(innovative_);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }

        }

    }
}
