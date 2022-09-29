using IndivisibleFractions;

int[] input = Console.ReadLine()
    .Split(' ')
    .Select(numberString => int.Parse(numberString))
    .ToArray();

List<RacionalNumber> racionalNumbers = new List<RacionalNumber>();
for (int i = 0; i + 1 < input.Length; i += 2)
{
    RacionalNumber number = new RacionalNumber(input[i], input[i + 1]);
    racionalNumbers.Add(number);
}

List<RacionalNumber> normalizedRacionalNumbers = new List<RacionalNumber>();
foreach (var rationalNumber in racionalNumbers)
{
    normalizedRacionalNumbers.Add(RacionalNumber.Normalize(rationalNumber));
}

Console.WriteLine(String.Join("; ", normalizedRacionalNumbers));