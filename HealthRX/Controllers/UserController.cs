using HealthRX.EF;
using HealthRX.Models;
using HealthRX.Models.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace HealthRX.Controllers
{
    public class UserController : Controller
    {
        private readonly ILogger<UserController> _logger;
        private readonly DataContext db;
        public UserController(ILogger<UserController> logger, DataContext data) 
        {
            _logger = logger;
            db = data;
        }

        [HttpGet]
        [Route("user/register")]
        public IActionResult Register()
        {
            
            return View();
        }
        [HttpPost]
        [Route("user/register")]
        public IActionResult Register(UserDTO userDTO)
        {
            var Status = "Active";
            var Role = "Customer";

            userDTO.Status = Status;
            userDTO.Role = Role;

            if(ModelState.IsValid )
            {
                var user = new User()
                {
                    Name = userDTO.Name,
                    Email = userDTO.Email,
                    Password = userDTO.Password,
                    UserName = userDTO.UserName,
                    Status = userDTO.Status,
                    Role = userDTO.Role
                };
                db.Users.Add(user);
                db.SaveChanges();
                return RedirectToAction("Login");
            }
            return View();
        }
    }
}
