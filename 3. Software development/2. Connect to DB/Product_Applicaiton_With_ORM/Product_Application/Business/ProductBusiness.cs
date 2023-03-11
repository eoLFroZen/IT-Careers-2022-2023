using Product_Application.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Application.Business
{
    public class ProductBusiness
    {
        public List<Product> GetAll()
        {
            using (ProductContext context = new ProductContext())
            {

                // open connection
                // create query - Select * From Employees
                // execute query
                // return result
                // return productRepository.GetAll();
                return context.Products.ToList();
            }
        }

        public Product GetById(int id)
        {
            using (ProductContext context = new ProductContext())
            {
                return context.Products.FirstOrDefault(p => p.Id == id);
            }
        }

        public void Add(Product product)
        {
            using (ProductContext context = new ProductContext())
            {
                context.Products.Add(product);
                context.SaveChanges();
            }
        }

        public void Update(Product product)
        {
            using (ProductContext context = new ProductContext())
            {
                Product dbProduct = GetById(product.Id);

                dbProduct.Name = product.Name;
                dbProduct.Price = product.Price;
                dbProduct.Stock = product.Stock;

                context.Products.Update(dbProduct);
                context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (ProductContext context = new ProductContext())
            {
                Product product = GetById(id);

                context.Products.Remove(product);
                context.SaveChanges();
            }
        }
    }
}
