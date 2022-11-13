using System.Text;

namespace Static_Demo
{
    public class Person
    {
        private static int peopleCount;

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

        public static int PeopleCount => Person.peopleCount;

        static Person()
        {
            Person.peopleCount = 0;
        }

        public Person(string firstName, string lastName, int age, double salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Salary = salary;

            Person.peopleCount++;
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
