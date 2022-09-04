using EvenNumbers;

List<int> input = Console.ReadLine()
    .Split(' ')
    .Select(numberString => int.Parse(numberString))
    .ToList();

List<EvenNumber> evenNumbers = EvenNumber.GetEvenNumbers(input);

Console.WriteLine(String.Join(", ", evenNumbers));