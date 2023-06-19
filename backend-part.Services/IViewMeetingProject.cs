using backend_part.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backend_part.Services
{
    public interface IViewMeetingProject
    {

        public List<ViewProjectMeeting> GetViewMeetingProject();
    }
}
