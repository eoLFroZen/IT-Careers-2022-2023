using Telephony;

Smartphone smartphone = new Smartphone();

IEnumerable<string> phoneNumbers = Console.ReadLine().Split(' ');
foreach (var phoneNumber in phoneNumbers)
{
    smartphone.Call(phoneNumber);
}

IEnumerable<string> urls = Console.ReadLine().Split(' ');
foreach (var url in urls)
{
    smartphone.Browse(url);
}