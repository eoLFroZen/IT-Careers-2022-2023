using Microsoft.AspNetCore.Identity;

namespace Product_Web.Data.Entities
{
    public class User : IdentityUser
    {
        public string Name { get; set; }

        public string? Address { get; set; }
    }
}
