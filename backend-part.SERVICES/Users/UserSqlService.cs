using backend_part.MODELS;
using System.Linq;

namespace backend_part.SERVICES.Users
{
    public class UserSqlService : IUserRepository
    {
        private readonly DbAccess _context = new DbAccess();

        
        public List<User> AllUsers()
        {
            var users = _context.Users.ToList();
            return users;
        }

        public User GetUserById(int id)
        {
            var user = _context.Users.FirstOrDefault(u => u.UId == id);
            return user;
        }

        public void UpdateUser(User user)
        {
            _context.SaveChanges();
        }

    }
}
