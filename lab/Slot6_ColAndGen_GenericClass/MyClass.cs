using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slot6_ColAndGen_GenericClass
{
    class MyClass<T>
    {
        private T data;
        public T value
        {
            get => data;
            set => data = value;
        }
        public override string ToString() => $"Value:{data}";
    }
}
