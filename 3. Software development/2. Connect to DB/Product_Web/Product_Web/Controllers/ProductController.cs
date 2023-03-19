using Microsoft.AspNetCore.Mvc;
using Product_Web.Services.Interfaces;
using System.Security.Claims;
using Product_Web_App.Data.Entities;

namespace Product_Web_App.Controllers
{
    public class ProductController : Controller
    {

        private IProductService productService;

        public ProductController(IProductService productService)
        {
            this.productService = productService;
        }

        public IActionResult Index()
        {
            var products = productService.GetAll();

            return View(products);
        }

        public IActionResult Create()
        {
            
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            // Get User email
            //string email = User.Identity.Name;
            productService.Add(product);

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(int id)
        {
            var product = productService.GetById(id);

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
            var product = productService.GetById(id);

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
