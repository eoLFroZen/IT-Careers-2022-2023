using Product_Web.Constants;
using Product_Web.Repositories.Interfaces;
using Product_Web.Services.Interfaces;
using Product_Web_App.Data.Entities;

namespace Product_Web_App.Services
{
    public class ProductService : IProductService
    {
        private IProductRepository productRepository;

        public ProductService(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public IEnumerable<Product> GetAll()
            => productRepository.GetAll();

        public Product GetById(int id)
            => productRepository.GetById(id);

        public void Add(Product product)
        {
            // TODO
            //product.Price += product.Price * ProductConstants.VAT;

            productRepository.Add(product);
        }

        public void Edit(Product product)
            => productRepository.Edit(product);

        public void Delete(int id)
            => productRepository.Delete(id);
    }
}
