using Microsoft.AspNetCore.Mvc;
using Product_Web.Services;

namespace Product_Web.Controllers
{
    public class UserController : Controller
    {
        private readonly UserService userService;

        public UserController(UserService userService)
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
