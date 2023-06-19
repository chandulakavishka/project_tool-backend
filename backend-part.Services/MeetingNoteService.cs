using backend_part.Data;
using backend_part.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backend_part.Services
{
    public class MeetingNoteService : IMeetingNote
    {
        private readonly DataContext _dBAccess = new DataContext();

        public void AddMeetingNote(MeetingNotes meetingNote)
        
        {
            try
            {
                _dBAccess.Add(meetingNote);
                _dBAccess.SaveChanges();
            }
            catch (Exception EX)
            {

            }
        }
        //public List<MeetingNotes> GetMeetingNotes(int projectid, int innovativeid)
        //{
        //    var _meetingNote = _dBAccess.MeetingNotes.FirstOrDefault(meetingNote => meetingNote.ProjectId == projectid && meetingNote.InnovativeId == innovativeid);
        //    re
            
        //}

    }
}


