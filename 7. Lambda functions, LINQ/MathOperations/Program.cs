int ExecuteOperation(int a, int b, Func<int, int, int> operation)
{
    return operation(a, b);
}

//Func<int, int, int> sum = (a, b) => a + b;
//Func<int, int, int> substract = (a, b) => a - b;
//Func<int, int, int> multiply = (a, b) => a * b;

List<Func<int, int, int>> operations = new List<Func<int, int, int>>
{
    (a, b) => a + b,
    (a, b) => a - b,
    (a, b) => a * b
};

foreach (var operation in operations)
{
    int result = ExecuteOperation(5, 6, operation);
    Console.WriteLine(result);
}