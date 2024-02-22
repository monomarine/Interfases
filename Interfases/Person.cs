using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfases
{
    internal class Person : IPurse
    {
        public string Name { get; set; }
        public int Sum { get; set; }

        public Person(string name)
        {
            Name = name;
            Sum = 0;
        }

        public void AddMoney(int summ)
        {
            Sum += summ;
        }

        public int DecMoney(int summ)
        {
            if (summ > Sum)
            {
                Console.WriteLine("недостаточно средств для снятия");
                return Sum;
            }
            else
            {
                Sum -= summ;
                return Sum;
            }
        }

        public override string ToString()
        {
            return $"{Name}: {Sum}";
        }
    }
}
