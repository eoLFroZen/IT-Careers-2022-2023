using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingSystem
{
    public class Receipt
    {
        private List<Product> products;
        private string customerName;

        public string CustomerName
        {
            get { return customerName; }
            private set 
            {
                if (value.Length < 2 || value.Length > 40)
                {
                    throw new ArgumentException("Customer Name should be between 2 and 40 characters!");
                }

                customerName = value;
            }
        }

        public Receipt(string customerName)
        {
            CustomerName = customerName;
            products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public override string ToString()
        {
            double sumOfProductPrices = products.Sum(product => product.Price);

            string receipt = $"Receipt of {CustomerName}"
                + Environment.NewLine
                + $"Total Price: {sumOfProductPrices:F2}"
                + Environment.NewLine
                + "Products:";

            foreach (var product in products)
            {
                receipt += Environment.NewLine + product.ToString();
            }

            return receipt;
        }
    }
}
