using Product_Application_MVC.Data;
using Product_Application_MVC.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Application_MVC.View
{
    public class AppView
    {
        public int CommandNumber { get; private set; }

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

            CommandNumber = int.Parse(Console.ReadLine());
        }

        public Product ReadProduct()
        {
            Console.WriteLine("Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Price:");
            decimal price = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Stock:");
            int stock = int.Parse(Console.ReadLine());

            return new Product(name, price, stock);
        }

        public int ReadProductId()
        {
            Console.WriteLine("Enter udpate product id.");
            return int.Parse(Console.ReadLine());
        }

        public void PrintAllProducts(List<Product> products)
        {
            products.ForEach(p => PrintProductById(p));
        }

        public void PrintProductById(Product product)
        {
            Console.WriteLine(product);
        }
    }
}
