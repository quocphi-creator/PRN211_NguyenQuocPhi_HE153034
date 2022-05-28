using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slot6_GenericMethod
{
    class MyClass
    {
        //Genirics method with to types T and U
        public void Display<T, U>(T msg, U value)
        {
            Console.WriteLine($"{msg} : {value}");
        }
    }
}
