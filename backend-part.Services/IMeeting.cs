using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using backend_part.Models;

namespace backend_part.Services
{
    public interface IMeeting
    {
        public List<Meeting> GetMeetings();
        public void AddMeeting(Meeting meeting);
        public Meeting GetMeeting(int id);
        public void UpdateMeeting(Meeting meeting);
    }
}
