using Microsoft.AspNetCore.Mvc;
using Product_Web.Services.Interfaces;

namespace Product_Web.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService userService;

        public UserController(IUserService userService)
        {
            this.userService = userService;
        }

        public async Task<IActionResult> Index()
        {
            var users = await userService.GetAll();

            return View(users);
        }
    }
}
