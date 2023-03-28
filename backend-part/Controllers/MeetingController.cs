using backend_part.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace backend_part.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MeetingController : ControllerBase
    {
        private readonly IMeeting repo;
        public MeetingController(IMeeting _repo)
        {
            repo = _repo;
        }

        [HttpPost]
        public IActionResult AddMeeting(Meeting meeting)
        {
            try
            {
                repo.AddMetting(meeting);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("id")]
        public ActionResult<Meeting> GetMeetingDetails(int id)
        {
            try
            {
                var product = repo.GetMeeting(id);

                return Ok(product);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
