using ShoppingSystem;
using System;
using System.Collections.Generic;
using System.Linq;

public class Controller
{
    private List<Product> products;
    private List<Receipt> receipts;

    public Controller()
    {
        products = new List<Product>();
        receipts = new List<Receipt>();
    }

    public string ProcessProductCommand(List<string> args)
    {
        string name = args[0];
        double price = double.Parse(args[1]);
        double weight = double.Parse(args[2]);

        var product = new PhysicalProduct(name, price, weight);
        products.Add(product);

        return $"The current customer has bought {name}.";
    }

    public string ProcessServiceCommand(List<string> args)
    {
        string name = args[0];
        double price = double.Parse(args[1]);
        double time = double.Parse(args[2]);

        var product = new ServiceProduct(name, price, time);
        products.Add(product);

        return $"The current customer has applied for {name} service.";
    }

    public string ProcessCheckoutCommand(List<string> args)
    {
        string customerName = args[0];

        var receipt = new Receipt(customerName);
        products.ForEach(product => receipt.AddProduct(product));
        receipts.Add(receipt);

        double sumOfProductPrices = products.Sum(product => product.Price);

        products.Clear();

        return $"Customer checked out for a total of ${sumOfProductPrices:F2}.";
    }

    public string ProcessInfoCommand(List<string> args)
    {
        string info = args[0];

        if (info == "Customer")
        {
            double sumOfProductPrices = products.Sum(product => product.Price);
            string customerString = "Current customer has:"
                + Environment.NewLine
                + $"Products: {products.Count}"
                + Environment.NewLine
                + $"Total Bill: {sumOfProductPrices:F2}";

            return customerString;
        }
        else if (info == "Shop")
        {
            if (receipts.Count == 0)
            {
                return "Receipts: No receipts";
            }

            string shopString = "Receipts:";
            foreach (var receipt in receipts)
            {
                shopString += Environment.NewLine + receipt.ToString();
            }

            return shopString;
        }

        return "";
    }

    public string ProcessEndCommand()
    {
        return $"Total customers today: {receipts.Count}";
    }
}
