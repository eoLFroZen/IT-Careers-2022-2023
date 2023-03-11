using Microsoft.EntityFrameworkCore;
using Product_Web_App.Data.Entities;

namespace Product_Web_App.Data
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {

        }
    }
}
