using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Product_Web_App.Data.Entities;
using Product_Web_App.Services;

namespace Product_Web_App.Controllers
{
    public class ProductController : Controller
    {

        private ProductService productService;

        public ProductController(ProductService productService)
        {
            this.productService = productService;
        }

        public IActionResult Index()
        {
            List<Product> products = productService.GetAll();

            return View(products);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            productService.Add(product);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(int id)
        {
            Product product = productService.GetById(id);
            return View(product);
        }

        [HttpPost]
        public IActionResult Edit(Product product)
        {
            productService.Edit(product);
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Delete(int id)
        {
            Product product = productService.GetById(id);
            return View(product);
        }

        [HttpPost]
        public IActionResult DeleteConfirm(int id)
        {
            productService.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
