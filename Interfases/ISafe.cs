using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfases
{
    internal interface ISafe : IPurse
    {
        bool IsLocked { get; }
        void Lock();
        void UnLock();

    }
}
