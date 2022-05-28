using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slot04_05_OOP_Interface
{
    class MyClass : IFirst, ISecond
    {
        public void Display()
        {
            Console.WriteLine("display method");
        }

        void IFirst.Print()
        {
            Console.WriteLine("IFirst's Print method.");
        }

        void ISecond.Print()
        {
            Console.WriteLine("ISencond's Print method.");
        }
    }
}
