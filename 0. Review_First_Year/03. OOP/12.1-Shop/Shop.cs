using System.Text;

namespace _12._1_Shop
{
    public static class Shop
    {
        private static List<Product> products;

        static Shop()
        {
            products = new List<Product>();
        }

        public static void Sell(string barcode, double quantity)
        {
            Product product = products.FirstOrDefault(p => p.Barcode == barcode);

            if (product == null)
            {
                throw new Exception("The product does not exist");
            }

            if (product.Quantity < quantity)
            {
                throw new Exception("Not enough quantity");
            }

            product.Sell(quantity);
        }

        public static void Add(string barcode, string name, double price, double quantity)
        {
            Product product = new Product(name, barcode, price, quantity);
            products.Add(product);
        }

        public static void Update(string barcode, double quantity)
        {
            Product product = products.FirstOrDefault(p => p.Barcode == barcode);

            if (product == null)
            {
                throw new Exception("The product does not exist");
            }

            product.UpdateQuantity(quantity);
        }

        public static string AvailableProducts()
        {
            IEnumerable<Product> availableProducts = products.Where(p => p.Quantity > 0);
            return ProductsToString(availableProducts);
        }

        public static string UnavailableProducts()
        {
            IEnumerable<Product> unavailableProducts = products.Where(p => p.Quantity == 0);
            return ProductsToString(unavailableProducts);
        }

        public static string OrderedProducts()
        {
            IEnumerable<Product> orderedProducts = products.OrderByDescending(p => p.Quantity);
            return ProductsToString(orderedProducts);
        }

        public static double Calculate()
        {
            return products.Sum(p => p.Quantity * p.Price);
        }

        private static string ProductsToString(IEnumerable<Product> products)
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var product in products)
            {
                stringBuilder.AppendLine(product.ToString());
            }

            return stringBuilder.ToString().Trim();
        }
    }
}
