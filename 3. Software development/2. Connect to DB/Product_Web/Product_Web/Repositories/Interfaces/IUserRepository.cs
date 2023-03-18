using Product_Web.Data.Entities;

namespace Product_Web.Repositories.Interfaces
{
    public interface IUserRepository
    {
        /// <summary>
        /// Gets all available users
        /// </summary>
        /// <returns></returns>
        IEnumerable<User> GetAll();
    }
}
