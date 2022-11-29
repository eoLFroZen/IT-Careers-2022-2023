using Employees;

FullTimeEmployee fullTimeEmployee = new FullTimeEmployee("12345", "Maria Ivanova", "Sofia", "intern", "it");
fullTimeEmployee.Show();
Console.WriteLine(fullTimeEmployee.CalculateSalary(20));
Console.WriteLine(fullTimeEmployee.GetDepartment());
fullTimeEmployee.Test();

ContractEmployee contractEmployee = new ContractEmployee("52341", "Georgi Vasilev", "Sofia", "Custom github", "it");
contractEmployee.Show();
Console.WriteLine(contractEmployee.CalculateSalary(20));
Console.WriteLine(contractEmployee.GetDepartment());