using Mysqlx.Crud;
using Product_Application.Business;
using Product_Application.Data;

namespace Product_Application.Presentation
{
    public class Display
    {
        private ProductBusiness productBusiness;

        public Display(ProductBusiness productBusiness)
        {
            this.productBusiness = productBusiness;
        }

        public void PrintAllCommands()
        {
            Console.WriteLine(new string('-', 40));
            Console.Write(new string(' ', 18));
            Console.Write("MENU");
            Console.WriteLine(new string(' ', 18));
            Console.WriteLine(new string('-', 40));

            Console.WriteLine("1. List all entries.");
            Console.WriteLine("2. Add new entry.");
            Console.WriteLine("3. Update entry.");
            Console.WriteLine("4. Fetch entry by ID.");
            Console.WriteLine("5. Delete entry by ID.");
            Console.WriteLine("6. Exit");

            int command = int.Parse(Console.ReadLine());

            PrrcessCommand(command);
        }

        private void PrrcessCommand(int command)
        {
            bool processCommands = true;

            switch (command)
            {
                case 1:
                    this.productBusiness.GetAll()
                        .ForEach(p => Console.WriteLine(p));
                    break;
                case 2:
                    Product product = ReadProduct();

                    this.productBusiness.Add(product);
                    break;

                case 3:
                    int updateProductId = ReadProductId();
                    PrintProductById(updateProductId);

                    Product udpateProduct = ReadProduct();
                    udpateProduct.Id = updateProductId;
                    productBusiness.Update(udpateProduct);
                    break;
                case 4:
                    int readProductId = ReadProductId();
                    PrintProductById(readProductId);
                    break;
                case 5:
                    int deleteProductId = ReadProductId();
                    productBusiness.Delete(deleteProductId);
                    break;
                case 6:
                    processCommands = false;
                    break;
            }

            if (processCommands)
            {
                PrintAllCommands();
            }
        }

        private Product ReadProduct()
        {
            Console.WriteLine("Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Price:");
            decimal price = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Stock:");
            int stock = int.Parse(Console.ReadLine());

            return new Product(name, price, stock);
        }

        private void PrintProductById(int productId)
        {
            Console.WriteLine(productBusiness.GetById(productId));
        }

        private int ReadProductId()
        {
            Console.WriteLine("Enter udpate product id.");
            return int.Parse(Console.ReadLine());
        }
    }
}
