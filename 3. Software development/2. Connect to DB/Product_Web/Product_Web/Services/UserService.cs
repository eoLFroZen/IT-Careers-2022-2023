using Microsoft.AspNetCore.Identity;
using Product_Web.Data.Entities;
using Product_Web.Data.ViewModels.User;
using Product_Web_App.Data;

namespace Product_Web.Services
{
    public class UserService
    {
        private readonly ApplicationContext context;
        private readonly UserManager<User> userManager;

        public UserService(
            ApplicationContext context,
            UserManager<User> userManager)
        {
            this.context = context;
            this.userManager = userManager;
        }

        public async Task<IEnumerable<UserViewModel>> GetAll()
        {
            var users = context.Users.ToList();

            var userViewModels = new List<UserViewModel>();
            foreach (var user in users)
            {
                var isAdmin = await userManager.IsInRoleAsync(user, "admin");
                userViewModels.Add(new UserViewModel(user.Id, user.UserName, isAdmin));
            }

            return userViewModels;
        }
    }
}
