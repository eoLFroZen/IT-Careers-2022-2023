List<double> prices = Console.ReadLine()
    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
    .Select(x => double.Parse(x))
    .Select(x => x * 1.2)
    .ToList();

Console.WriteLine("Цени с ДДС (VAT):");

prices.ForEach(price => Console.WriteLine($"{price:F2}"));