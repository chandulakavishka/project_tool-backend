using backend_part.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    
namespace backend_part.Services
{
    public interface IProjectUser
    {
        public List<ProjectUser> GetProjectUsers(int id);
        public List<ProjectUser> GetAllProjectUsers(int id);
        
    }
}
