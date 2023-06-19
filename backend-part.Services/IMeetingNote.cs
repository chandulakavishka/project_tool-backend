using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using backend_part.Models;

namespace backend_part.Services
{
    public interface IMeetingNote
    {
        public void AddMeetingNote(MeetingNotes meetingNote);
  //      public List<MeetingNotes> GetMeetingNotes(int projectid, int innovativeid);
    }
}

