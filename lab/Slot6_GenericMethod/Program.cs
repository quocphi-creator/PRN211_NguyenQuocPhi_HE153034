using System;

namespace Slot6_GenericMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating object of Myclass
            MyClass obj = new MyClass();
            //Calling Generics methods
            obj.Display<string, int>("Interger", 2500);
            obj.Display<double, char>(155.9, 'a');
            obj.Display<float, double>(35.9F, 255.67);
            Console.ReadLine();
        }
    }
}
