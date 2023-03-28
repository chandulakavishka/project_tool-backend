using backend_part.Models;
using backend_part.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace backend_part.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MeetingNoteController : ControllerBase
    {
        private readonly IMeetingNote repo;

        public MeetingNoteController(IMeetingNote _repo)
        {
            repo = _repo;
        }

        [HttpPost]
        public async Task<ActionResult<MeetingNotes>> AddMeeting(MeetingNotes meetingNote)
        {
            try
            {
                repo.AddMeetingNote(meetingNote);

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
                var product = repo.GetMeetingNotes(id);

                return Ok(product);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}

