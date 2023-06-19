using backend_part.Data;
using backend_part.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using backend_part.DataAccess;

namespace backend_part.Services

{
    public class ViewMeetingProjectService : IViewMeetingProject

    {
        private readonly DataContext _dBAccess = new DataContext();


        public List<ViewProjectMeeting> GetViewMeetingProject()
        {
            var projectmeeting_ = _dBAccess.ViewProjects.ToList();
            return projectmeeting_;
        }

    }
}
