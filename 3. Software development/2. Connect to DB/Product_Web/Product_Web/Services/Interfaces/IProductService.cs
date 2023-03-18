using Product_Web_App.Data.Entities;

namespace Product_Web.Services.Interfaces
{
    public interface IProductService
    {
        /// <summary>
        /// Gets all available products
        /// </summary>
        /// <returns></returns>
        IEnumerable<Product> GetAll();

        /// <summary>
        /// Gets a product by it's id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Product GetById(int id);

        /// <summary>
        /// Adds a new product. VAT is added to the product's price
        /// </summary>
        /// <param name="product"></param>
        void Add(Product product);

        /// <summary>
        /// Edits an already existing product
        /// </summary>
        /// <param name="product"></param>
        void Edit(Product product);

        /// <summary>
        /// Deletes an already existing product
        /// </summary>
        /// <param name="id"></param>
        void Delete(int id);
    }
}
