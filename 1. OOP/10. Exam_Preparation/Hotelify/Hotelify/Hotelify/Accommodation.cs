using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelify
{
    public abstract class Accommodation
    {
        private string name;
        private int price;
        private string location;

        protected Accommodation(int refNumber, string name, string description, int price, string location)
        {
            RefNumber = refNumber;
            Name = name;
            Description = description;
            Price = price;
            Location = location;
        }

        public int RefNumber { get; private set; }

        public string Name
        {
            get { return name; }
            private set
            {
                CheckForNullEmptyOrWhitespace(value, nameof(name));

                //if (string.IsNullOrWhiteSpace(value))
                //{
                //    throw new ArgumentException("Accommodation location cannot be null, empty or whitespace.");
                //}

                name = value;
            }
        }

        public string Description { get; private set; }

        public int Price
        {
            get { return price; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Accommodation price cannot be zero or negative.");

                }

                price = value;
            }
        }

        public string Location
        {
            get { return location; }
            private set
            {
                CheckForNullEmptyOrWhitespace(value, nameof(location));
                location = value;
            }
        }

        private void CheckForNullEmptyOrWhitespace(string value, string propertyName)
        {
            if (value == null || value.Length == 0 || value.Trim().Length == 0)
            {
                throw new ArgumentException($"Accommodation {propertyName} cannot be null, empty or whitespace.");
            }
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"Accommodation {RefNumber}: {name}");
            stringBuilder.AppendLine($"Description: {Description}");
            stringBuilder.AppendLine($"Price: {price}");
            stringBuilder.AppendLine($"Location: {location}");

            return stringBuilder.ToString().Trim();
        }
    }
}
