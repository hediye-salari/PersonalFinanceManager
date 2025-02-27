using Microsoft.AspNetCore.Mvc;
using UserService.Models;

namespace UserService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly List<User> _users = new();
        //ثبت نام کاربر (Register)
        [HttpPost("register")]
        public IActionResult Register(User user)
        {
            _users.Add(user);
            return Ok();
        }
        //ورود کاربر (Login)
        [HttpPost("login")]
        public IActionResult Login(User user)
        {
            var existingUser = _users.FirstOrDefault(u => u.Username == user.Username);
            if (existingUser == null || existingUser.PasswordHash != user.PasswordHash)
                return Unauthorized();

            return Ok();
        }
    }
}
