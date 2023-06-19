using backend_part.Services;
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
        public ActionResult AddMeeting(Meeting meeting)
        {
            try
            {
                repo.AddMeeting(meeting);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        public ActionResult<Meeting> GetAllMeeting()
        {
            try
            {
                var product = repo.GetMeetings();

                return Ok(product);
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

        [HttpPut]
        public ActionResult<Meeting> UpdateMeeting(Meeting meeting)
        {
            try
            {
                repo.UpdateMeeting(meeting);
                return Ok();

            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
