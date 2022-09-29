namespace Employees
{
    public class FullTimeEmployee : BaseEmployee
    {
        private string employeePosition;
        private string employeeDepartment;

        public FullTimeEmployee(
            string employeeID, 
            string employeeName, 
            string employeeAddress, 
            string employeePosition, 
            string employeeDepartment)
            : base(employeeID, employeeName, employeeAddress)
        {
            this.employeePosition = employeePosition;
            this.employeeDepartment = employeeDepartment;
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Position: {employeePosition}");
            Console.WriteLine($"Department: {employeeDepartment}");
        }

        public override double CalculateSalary(int workingHours)
        {
            return 250 + workingHours * 10.80;
        }

        public override string GetDepartment()
        {
            return employeeDepartment;
        }

        public void Test()
        {
            Console.WriteLine("Test");
        }
    }
}
