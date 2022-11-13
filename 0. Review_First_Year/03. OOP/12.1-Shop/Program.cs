using _12._1_Shop;

string command;
do
{
    command = Console.ReadLine();
    List<string> splittedCoomand = command.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();

    try
    {
        switch (splittedCoomand[0])
        {
            case "Sell":
                {
                    string barcode = splittedCoomand[1];
                    double quantity = double.Parse(splittedCoomand[2]);
                    Shop.Sell(barcode, quantity);
                    break;
                }
            case "Add":
                {
                    string barcode = splittedCoomand[1];
                    string name = splittedCoomand[2];
                    double price = double.Parse(splittedCoomand[3]);
                    double quantity = double.Parse(splittedCoomand[4]);
                    Shop.Add(barcode, name, price, quantity);
                    break;
                }
            case "Update":
                {
                    string barcode = splittedCoomand[1];
                    double quantity = double.Parse(splittedCoomand[2]);
                    Shop.Update(barcode, quantity);
                    break;
                }
            case "PrintA":
                {
                    string products = Shop.AvailableProducts();
                    if (products != "")
                    {
                        Console.WriteLine(products);
                    }
                    break;
                }
            case "PrintU":
                {
                    string products = Shop.UnavailableProducts();
                    if (products != "")
                    {
                        Console.WriteLine(products);
                    }
                    break;
                }
            case "PrintD":
                {
                    string products = Shop.OrderedProducts();
                    if (products != "")
                    {
                        Console.WriteLine(products);
                    }
                    break;
                }
            case "Calculate":
                {
                    Console.WriteLine($"{Shop.Calculate():f2}");
                    break;
                }

        }
    }
    catch (Exception exception)
    {
        Console.WriteLine(exception.Message);
    }
}
while (command != "Close");