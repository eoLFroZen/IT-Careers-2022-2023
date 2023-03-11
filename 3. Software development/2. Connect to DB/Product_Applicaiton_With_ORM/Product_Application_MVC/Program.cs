// See https://aka.ms/new-console-template for more information

using Product_Application_MVC.Controller;
using Product_Application_MVC.Service;
using Product_Application_MVC.View;

ProductService productService = new ProductService();
AppView view = new AppView();

ProductController productController = new ProductController(productService, view);

productController.Run();
