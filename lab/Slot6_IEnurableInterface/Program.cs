using System;

namespace Slot6_IEnurableInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            MyCollection<Person> collection = new MyCollection<Person>();
            var p1 = new Person { FirstName = "David", LastName = "simpson", Age = 50 };
            var p2 = new Person { FirstName = "Marge", LastName = "simpson", Age = 45 };
            var p3 = new Person { FirstName = "Lisa", LastName = "simpson", Age = 16 };
            var p4 = new Person { FirstName = "Jack", LastName = "simpson", Age = 16 };
            collection.AddItem(p1, p2, p3, p4);
            foreach (var p in collection)
            {
                Console.WriteLine(p);
            }
        }
        
    }
}
