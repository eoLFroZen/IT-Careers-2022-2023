using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenNumbers
{
    public class EvenNumber
    {
        private int num;

        public int Num
        {
            get { return num; }
            set { num = value; }
        }

        public EvenNumber(int num)
        {
            Num = num;
        }

        public static List<EvenNumber> GetEvenNumbers(List<int> numbers)
        {
            List<EvenNumber> evenNumbers = new List<EvenNumber>();
            foreach (var number in numbers)
            {
                if (number % 2 == 0)
                {
                    evenNumbers.Add(new EvenNumber(number));
                }
            }

            return evenNumbers;
        }

        public override string ToString()
        {
            return $"{num}";
        }
    }
}
