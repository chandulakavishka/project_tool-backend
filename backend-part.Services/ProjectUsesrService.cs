using backend_part.Data;
using backend_part.Data;
using backend_part.Models;
using System.Collections.Generic;
using System.Linq;

namespace backend_part.Services
{
    public class ProjectUsesrService:IProjectUser
    {
        private readonly DataContext _dBAccess = new DataContext();

        public List<ProjectUser> GetProjectUsers(int id)
        {

            var projectuser_ = _dBAccess.ProjectUsers.Where(ProjectUser => ProjectUser.UserId == id).ToList();
            return projectuser_;
        }

        public List<ProjectUser> GetAllProjectUsers(int id)
        {

            var projectuser_ = _dBAccess.ProjectUsers.Where(ProjectUser => ProjectUser.Id == id).ToList();
            return projectuser_;
        }


    }
}
