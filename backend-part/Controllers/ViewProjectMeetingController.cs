using backend_part.Services;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace backend_part.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ViewProjectMeetingController : ControllerBase
    {
        private readonly IViewMeetingProject repo;

        public ViewProjectMeetingController(IViewMeetingProject _repo)
        {

            repo = _repo;
        }



        [HttpGet]
        public ActionResult<ViewProjectMeeting> GetViewMeetingProject()
        {
            try
            {
                var product = repo.GetViewMeetingProject();

                return Ok(product);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }

        }
    }
}
