namespace Employees
{
    public abstract class BaseEmployee
    {
        protected string employeeID;
        protected string employeeName;
        protected string employeeAddress;

        public BaseEmployee(string employeeID, string employeeName, string employeeAddress)
        {
            this.employeeID = employeeID;
            this.employeeName = employeeName;
            this.employeeAddress = employeeAddress;
        }

        public virtual void Show()
        {
            Console.WriteLine("--- Employee ---");
            Console.WriteLine($"ID: {employeeID}");
            Console.WriteLine($"Name: {employeeName}");
            Console.WriteLine($"Address: {employeeAddress}");
        }

        public abstract double CalculateSalary(int workingHours);

        public abstract string GetDepartment();
    }
}
