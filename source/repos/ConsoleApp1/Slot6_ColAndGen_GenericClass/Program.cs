using System;

namespace Slot6_ColAndGen_GenericClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instance of string type
            MyClass<string> name = new MyClass<string> { value = "Jack" };
            Console.WriteLine(name);
            //Instance of float type
            MyClass<float> version = new MyClass<float>() { value = 5.5f };
            Console.WriteLine(version);
            //Instance of dynamic type
            dynamic obj = new { Id = 1, Name = "David" };
            MyClass<dynamic> myClass = new MyClass<dynamic>() { value = obj };
            Console.WriteLine(myClass);
            Console.ReadLine();

        }
    }
}
