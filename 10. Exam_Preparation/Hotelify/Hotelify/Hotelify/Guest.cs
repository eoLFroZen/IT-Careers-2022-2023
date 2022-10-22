using System.Security.Cryptography;
using System.Text;

namespace Hotelify
{
    public class Guest
    {
        private string name;
        private int budget;

        public Guest(string name, int budget)
        {
            Name = name;
            Budget = budget;
        }

        public string Name
        {
            get { return name; }
            private set
            {
                if (value == null || value.Length == 0 || value.Trim().Length == 0)
                {
                    throw new ArgumentException($"Guest name cannot be null, empty or whitespace.");
                }

                name = value;
            }
        }

        public int Budget
        {
            get { return budget; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Guest budget cannot be zero or negative.");
                }

                budget = value;
            }
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"Guest {name}");
            stringBuilder.AppendLine($"Budget: {budget}");

            return stringBuilder.ToString().Trim();
        }
    }
}
