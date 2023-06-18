using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using backend_part.MODELS;
using backend_part.SERVICES.Innovatives;
using backend_part.SERVICES.Users;

namespace backend_part.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private IUserRepository _userService;

        public UsersController(IUserRepository UserRepo)
        {
            _userService = UserRepo;
        }

        [HttpGet("{UId?}")]
        public IActionResult GetUser(int? UId)
        {
            var User = _userService.AllUsers();

            if (User == null) return Ok(User);

            User = User.Where(u => u.UId == UId).ToList();

            return Ok(User);
        }

        [HttpGet]
        public IActionResult GetUsers()
        {
            var User = _userService.AllUsers();

            User = User.ToList();

            return Ok(User);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateUser(int id,User updatedUser)
        {
            var user = _userService.GetUserById(id);

            if (user == null)
            { 
                return NotFound();
            }

            user.PhoneNo = updatedUser.PhoneNo;
            user.City = updatedUser.City;
            user.Description = updatedUser.Description;

            _userService.UpdateUser(user);

            return Ok(user);
        }



    }
}
