using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Interfases
{
    internal interface IPurse
    {
        int Sum { get; set; }
        void AddMoney(int summ);
        int DecMoney(int summ);
    }
}
