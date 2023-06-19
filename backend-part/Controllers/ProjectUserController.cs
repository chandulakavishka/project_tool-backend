using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace backend_part.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectUserController : ControllerBase
    {
        private readonly IProjectUser repo;

        public ProjectUserController(IProjectUser _repo)
        {

            repo = _repo;
        }


        [HttpGet]
        [Route("userId")]
        public ActionResult<ProjectUser> GetProjectUsers(int userId)
        {
            try
            {
                var Projectuser_ = repo.GetProjectUsers(userId);

                return Ok(Projectuser_);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }

        }

        [HttpGet]
        [Route("Id")]
        public ActionResult<ProjectUser> GetAllProjectUsers(int Id)
        {
            try
            {
                var Projectuser_ = repo.GetAllProjectUsers(Id);

                return Ok(Projectuser_);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }

        }

    }
}
