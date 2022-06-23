using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slot04_05_OOP_Interface
{
    public class SomeClass : ISomeInterface
    {
        public string SomeProperty { get; set; }


        public string SomeMethod()
        {
            return "Hello world";
        }

        public void SomethingElse()
        {
            Console.WriteLine(DateTime.Now);
        }
    }
}
