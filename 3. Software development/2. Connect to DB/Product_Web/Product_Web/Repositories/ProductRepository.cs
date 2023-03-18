using Product_Web.Repositories.Interfaces;
using Product_Web_App.Data;
using Product_Web_App.Data.Entities;

namespace Product_Web.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private ApplicationContext context;

        public ProductRepository(ApplicationContext context)
        {
            this.context = context;
        }

        public IEnumerable<Product> GetAll()
            => context.Products.ToList();

        public Product GetById(int id)
            => context.Products.FirstOrDefault(p => p.Id == id);

        public void Add(Product product)
        {
            context.Products.Add(product);
            context.SaveChanges();
        }

        public void Edit(Product product)
        {
            context.Products.Update(product);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            context.Products.Remove(GetById(id));
            context.SaveChanges();
        }
    }
}
