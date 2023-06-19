using backend_part.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using backend_part.Data;
using System.Threading.Tasks;

namespace backend_part.Services
{
    public class MeetingService : IMeeting

    {
        private readonly DataContext _dBAccess = new DataContext();


        public List<Meeting> GetMeetings()
        {
            var meeting_ = _dBAccess.Meeting.ToList();
            return meeting_;
        }


        public void AddMeeting(Meeting meeting)
        {
            try
            {
                _dBAccess.Add(meeting);
                _dBAccess.SaveChanges();
            }
            catch (Exception EX)
            {
                EX.ToString();
            }
        }

        public Meeting GetMeeting(int id)
        {
            Meeting _meeting = _dBAccess.Meeting.Find(id);
            return _meeting;
        }

        public void UpdateMeeting(Meeting meeting)
        {
            
            var meeting_ = _dBAccess.Meeting.First(a => a.Id == meeting.Id);
            meeting_.date = meeting.date;
            meeting_.Description = meeting.Description;
            meeting_.Title = meeting.Title;
            meeting_.Link = meeting.Link;
            _dBAccess.SaveChanges();
        }
    }
}
