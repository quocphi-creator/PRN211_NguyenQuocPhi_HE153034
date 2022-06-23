using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slot6_GenericMethod
{
    interface IBasic<T> where T:struct
    {
        T Add(T a, T b);
    }

    
}
