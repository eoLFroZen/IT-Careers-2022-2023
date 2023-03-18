using Product_Web.Data.Entities;
using Product_Web.Repositories.Interfaces;
using Product_Web_App.Data;

namespace Product_Web.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationContext context;

        public UserRepository(ApplicationContext context)
        {
            this.context = context;
        }

        public IEnumerable<User> GetAll()
            => context.Users.ToList();
    }
}
