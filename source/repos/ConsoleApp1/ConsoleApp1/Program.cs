using Slot4_5_OOP_RecordType;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer { Name = "Jack", Age = 25 };
            customer1.Print();
            Customer customer2 = customer1 with { Name = "John" };
            customer2.Print();
            Customer customer3 = new();
            customer3.Print();
            Console.ReadLine();
        }
    }
}
