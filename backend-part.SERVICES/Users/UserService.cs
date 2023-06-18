using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using backend_part.MODELS;

namespace backend_part.SERVICES.Users
{
    public class UserService : IUserRepository
    {
        public List<User> AllUsers()
        {
            var users = new List<User>();

            var user1 = new User
            {
                UId = 1,
                LastName = "Test1",
                Email = "Chiransooriya1@gmail.com",
                Role = UserRole.User

            };
            users.Add(user1);

            var user2 = new User
            {
                UId = 2,
                LastName = "Test2",
                Email = "Chiransooriya12@gmail.com",
                Role = UserRole.Initial_Lead

            };
            users.Add(user2);

            var user3 = new User
            {
                UId = 3,
                LastName = "Test3",
                Email = "Chiransooriya123@gmail.com",
                Role = UserRole.Initial_Evaluator

            };
            users.Add(user3);

            return users;
        }

        public User GetUserById(int id)
        {
            return AllUsers().FirstOrDefault(u => u.UId == id);
        }

        public void UpdateUser(User user)
        {
            // Implement the logic to update the user data in the data source (e.g., database).
            // This can involve executing SQL queries or using an ORM (Object-Relational Mapping) framework.

            // For example:
            // 1. Retrieve the existing user from the data source based on user.UId.
            // 2. Update the user's properties with the new values from the provided user object.
            // 3. Save the changes to the data source.

            // Note: This is a placeholder method, and you should implement the actual logic based on your data storage and update requirements.
        }

    }
}
