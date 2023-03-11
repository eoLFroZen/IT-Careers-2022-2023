using Product_Web_App.Data;
using Product_Web_App.Data.Entities;

namespace Product_Web_App.Services
{
    public class ProductService
    {
        private ApplicationContext context;

        public ProductService(ApplicationContext context)
        {
            this.context = context;
        }

        public List<Product> GetAll()
        {
            return context.Products.ToList();
        }
        public Product GetById(int id)
        {
            return context.Products.FirstOrDefault(p => p.Id == id);
        }

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
