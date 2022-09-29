using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Family
{
    public class Family
    {
        private List<Person> members;

        public Family()
        {
            members = new List<Person>();
        }

        public void AddMember(Person person)
        {
            members.Add(person);
        }

        public void Print()
        {
            List<Person> ordered = members.OrderBy(person => person.Name).ToList();
            for (int i = 0; i < ordered.Count(); i++)
            {
                Console.WriteLine(ordered[i].Name + " " + ordered[i].Age);
            }
        }
    }
}
