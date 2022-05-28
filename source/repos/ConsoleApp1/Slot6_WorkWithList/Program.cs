using System;
using System.Collections.Generic;

namespace Slot6_WorkWithList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>()
            {
                new Person {FirstName = "David", LastName="simpson", Age=50},
                new Person {FirstName ="Marge", LastName="Simpson", Age=19},
                new Person {FirstName = "Lisa", LastName="Simpson", Age=16}
            };

            //Print out # of items in List
            Console.WriteLine("Items in List: {0}", people.Count);
            //Enumerate over list
            foreach (Person p in people)
            {
                Console.WriteLine(p);
            }
            Console.ReadLine();
        }
    }
}
