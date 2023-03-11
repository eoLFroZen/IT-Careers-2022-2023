using Product_Application_MVC.Data;
using Product_Application_MVC.Service;
using Product_Application_MVC.View;

namespace Product_Application_MVC.Controller
{
    public class ProductController
    {
        private ProductService productService;
        private AppView view;
        private bool isRunning;

        public ProductController(ProductService productService, AppView appView)
        {
            this.productService = productService;
            this.view = appView;
            this.isRunning = true;
        }

        public void Run()
        {
            while (isRunning)
            {
                view.PrintAllCommands();
                ProcessCommand(view.CommandNumber);
            }
        }

        private void ProcessCommand(int command)
        {
            switch (command)
            {
                case 1:
                    this.GetAll();
                    break;
                case 2:
                    this.AddProduct();
                    break;
                case 3:
                    this.UpdateProduct();
                    break;
                case 4:
                    this.GetById();
                    break;
                case 5:
                    this.DeleteById();
                    break;
                case 6:
                    isRunning = false;
                    break;
            }
        }

        private void GetAll()
        {
            List<Product> products = this.productService.GetAll();
            view.PrintAllProducts(products);
        }

        private void GetById()
        {
            int readProductId = view.ReadProductId();
            Product product = productService.GetById(readProductId);
            view.PrintProductById(product);
        }

        private void AddProduct()
        {
            Product product = view.ReadProduct();

            this.productService.Add(product);
        }

        private void UpdateProduct()
        {
            int updateProductId = view.ReadProductId();
            Product product = productService.GetById(updateProductId);
            view.PrintProductById(product);

            Product udpateProduct = view.ReadProduct();
            udpateProduct.Id = updateProductId;
            productService.Update(udpateProduct);
        }
        private void DeleteById()
        {
            int deleteProductId = view.ReadProductId();
            productService.Delete(deleteProductId);
        }
    }
}
