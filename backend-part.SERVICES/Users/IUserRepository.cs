
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using backend_part.MODELS;

namespace backend_part.SERVICES.Users
{
    public interface IUserRepository 
    {
        public List<User> AllUsers();
        User GetUserById(int id);
        void UpdateUser(User user);

    }
}
