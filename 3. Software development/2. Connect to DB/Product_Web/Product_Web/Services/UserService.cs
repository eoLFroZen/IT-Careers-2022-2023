using Microsoft.AspNetCore.Identity;
using Product_Web.Data.Entities;
using Product_Web.Data.ViewModels.User;
using Product_Web.Repositories.Interfaces;
using Product_Web.Services.Interfaces;
using Product_Web_App.Data;

namespace Product_Web.Services
{
    public class UserService : IUserService
    {
        private readonly UserManager<User> userManager;
        private readonly IUserRepository userRepository;

        public UserService(
            UserManager<User> userManager,
            IUserRepository userRepository)
        {
            this.userManager = userManager;
            this.userRepository = userRepository;
        }

        public async Task<IEnumerable<UserViewModel>> GetAll()
        {
            var users = userRepository.GetAll();

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
