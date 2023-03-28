using backend_part.Data;
using backend_part.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backend_part.Services
{
    public class MeetingService : IMeeting

    {
        private readonly DataContext _dBAccess = new DataContext();


        public List<Meeting> GetMettings()
        {
            var meeting_ = _dBAccess.Meeting.ToList();
            return meeting_;
        }


        public void AddMetting(Meeting meeting)
        {
            try
            {
                _dBAccess.Add(meeting);
                _dBAccess.SaveChanges();
            }
            catch (Exception EX)
            {

            }
        }

        public Meeting GetMeeting(int id)
        {
            Meeting _meeting = _dBAccess.Meeting.Find(id);
            return _meeting;
        }


    }
}
