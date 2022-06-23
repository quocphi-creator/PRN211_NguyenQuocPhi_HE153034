using System;

namespace Slot6_GenericInterface
{
    class Program
    {
        
        static void Main(string[] args)
        {
            MyFirstClass firstclass = new MyFirstClass();
            dynamic r = firstclass.Add(10, 20);
            Console.WriteLine(r);
            MySecondClass secondClass = new MySecondClass();
            r = secondClass.Add(10.5, 20.5);
            Console.WriteLine(r);
            Console.ReadLine();
        }
    }
}
