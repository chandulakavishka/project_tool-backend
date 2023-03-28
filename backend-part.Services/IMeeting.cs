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
        public List<Meeting> GetMettings();
        public void AddMetting(Meeting meeting);
        public Meeting GetMeeting(int id);
    }
}
