using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Application.Data
{
    public class Product
    {
        public Product()
        {

        }

        public Product(string name, decimal price, int stock)
        {
            Name = name;
            Price = price;
            Stock = stock;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public int Stock { get; set; }

        public override string ToString()
        {
            return $"Product: {Id}{Environment.NewLine}" +
                $"{Name} - {Price}{Environment.NewLine}" +
                $"In Stock: {Stock}";
        }

    }
}
