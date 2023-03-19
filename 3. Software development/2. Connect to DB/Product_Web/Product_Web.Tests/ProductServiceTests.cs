using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using Product_Web.Constants;
using Product_Web.Repositories;
using Product_Web_App.Data;
using Product_Web_App.Data.Entities;
using Product_Web_App.Services;
using System.Xml.Linq;

namespace Product_Web.Tests
{
    public class ProductServiceTests
    {
        private ApplicationContext context;
        private ProductRepository productRepository;
        private ProductService productService;

        [SetUp]
        public void Setup()
        {
            var options = new DbContextOptionsBuilder<ApplicationContext>()
                .UseInMemoryDatabase("TestDb");

            context = new ApplicationContext(options.Options);
            productRepository = new ProductRepository(context);
            productService = new ProductService(productRepository);
        }

        [TearDown]
        public void TearDown()
        {
            context.Database.EnsureDeleted();
        }

        [Test]
        public void GetAllShouldReturnAllProducts()
        {
            Product product = CreateProduct(null, "Product 1", 15, 10);

            productService.Add(product);

            Assert.True(productRepository.GetAll().Count() > 0);
        }

        [Test]
        public void GetByIdShouldReturenCorrectProduct()
        {
            int id = 1;
            string name = "Product";
            decimal price = 15;
            int stock = 10;

            Product product = CreateProduct(id, name, price, stock);
            productRepository.Add(product);
            Assert.NotNull(productRepository.GetById(id));

            VerifyProductProperties(id, name, price, stock);
        }

        [Test]
        public void CreateShouldWorkCorrectly()
        {
            int id = 2;
            string name = "New Product";
            decimal price = 5;
            int stock = 1;
            Product product = CreateProduct(id, name, price, stock);

            productService.Add(product);

            VerifyProductProperties(id, name, price, stock);
        }

        [Test]
        public void EditShouldWorkCorrectly()
        {
            int id = 3;
            Product product = CreateProduct(id, "Product", 12, 2);
            productRepository.Add(product);

            string name = "Edit Product";
            decimal price = 3;
            int stock = 67;

            product.Name = name;
            product.Price = price;
            product.Stock = stock;

            productService.Edit(product);

            VerifyProductProperties(id, name, price, stock);
        }

        [Test]
        public void DeleteShouldRemoveProductCorrectly()
        {
            int productId = 4;
            string name = "Product";
            decimal price = 15;
            int stock = 10;

            Product product = CreateProduct(productId, name, price, stock);
            productRepository.Add(product);

            productService.Delete(productId);

            Product deletedProduct = productRepository.GetById(productId);
            Assert.IsNull(deletedProduct);
        }

        private void VerifyProductProperties(int id, string name, decimal price, int stock)
        {
            Product dbProduct = productRepository.GetById(id);
            Assert.AreEqual(id, dbProduct.Id);
            Assert.AreEqual(name, dbProduct.Name);
            Assert.AreEqual(price, dbProduct.Price);
            Assert.AreEqual(stock, dbProduct.Stock);
        }

        private Product CreateProduct(int? id, string name, decimal price, int stock)
        {
            Product product = new Product();

            if (id != null)
            {
                product.Id = id.Value;
            }

            product.Name = name;
            product.Price = price;
            product.Stock = stock;

            return product;
        }
    }
}