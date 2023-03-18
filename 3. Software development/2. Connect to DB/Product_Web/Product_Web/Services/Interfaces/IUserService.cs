using Product_Web.Data.ViewModels.User;

namespace Product_Web.Services.Interfaces
{
    public interface IUserService
    {
        /// <summary>
        /// Gets all available users
        /// </summary>
        /// <returns>
        /// A collection of <see cref="UserViewModel">UserViewModel</see>s
        /// </returns>
        Task<IEnumerable<UserViewModel>> GetAll();
    }
}
