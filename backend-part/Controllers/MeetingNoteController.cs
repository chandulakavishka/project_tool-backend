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
        public ActionResult<MeetingNotes> AddMeeting(MeetingNotes meetingNote)
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


        //[HttpGet("{projectid}/{innovativeid}")]
        //public ActionResult<MeetingNotes> GetMeetingNotes(int projectid, int innovativeid)
        //{
        //    try
        //    {
        //        var note_ = repo.GetMeetingNotes(projectid, innovativeid);

        //        return Ok(note_);
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(ex.ToString());
        //    }
        //}
    }
}

