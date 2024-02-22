using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfases
{
    internal class BankAccount : IPurse , ISafe
    {
        public string Nomer { get; set; }
        public int Sum { get; set; }

        public bool IsLocked { get; set; }

        public BankAccount(string nomer)
        {
            Nomer = nomer;
            Sum = 0;
        }

        public void AddMoney(int summ)
        {
            if (IsLocked)
                Console.WriteLine("счет заблокирован");
            else 
                Sum += summ;
        }

        public int DecMoney(int summ)
        {
            if (summ > Sum && IsLocked)
            {
                Console.WriteLine("недостаточно средств для снятия или счет заблокирован");
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
            return $"{Nomer}: {Sum}";
        }

        public void Lock()
        {
            if (!IsLocked)
                IsLocked = true;
        }

        public void UnLock()
        {
            if(IsLocked) 
                IsLocked = false;
        }
    }
}
