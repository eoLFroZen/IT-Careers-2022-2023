using System.Text;

namespace _09._1_Person
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        private double salary;

        public string FirstName 
        {
            get
            {
                return firstName;
            }

            private set
            {
                if (!IsNameValid(value))
                {
                    throw new ArgumentException("First name must have at least 3 characters.");
                }

                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }

            private set
            {
                if (!IsNameValid(value))
                {
                    throw new ArgumentException("Last name must have at least 3 characters.");
                }

                lastName = value;
            }
        }


        public int Age
        {
            get
            {
                return age;
            }

            private set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Age must be 1 or more.");
                }

                age = value;
            }
        }

        public double Salary
        {
            get
            {
                return salary;
            }

            private set
            {
                if (value < 460)
                {
                    throw new ArgumentException("The salary must be at least 460.");
                }

                salary = value;
            }
        }

        public Person(string firstName, string lastName, int age, double salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Salary = salary;
        }

        public void IncreaseSalary(int percentage)
        {
            if (age < 30)
            {
                percentage /= 2;
            }

            Salary = salary + salary * percentage / 100;
        }

        public void DecreaseSalary(int percentage)
        {
            if (age < 30)
            {
                percentage /= 2;
            }

            Salary = salary - salary * percentage / 100;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Name: {FirstName} {LastName}");
            stringBuilder.AppendLine($"Age: {Age}");
            stringBuilder.AppendLine($"Salary: {Salary}");

            return stringBuilder.ToString();
        }

        private bool IsNameValid(string name)
        {
            return name.Length >= 3;
        }
    }
}
