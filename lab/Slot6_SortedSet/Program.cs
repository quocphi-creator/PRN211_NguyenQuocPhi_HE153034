﻿using System;
using System.Collections.Generic;

namespace Slot6_SortedSet
{
    class Program
    {
        static void Main(string[] args)
        {
            //Using collection initializer to initialize sortedSet
            SortedSet<int> mySet = new SortedSet<int>() { 8, 7, 9, 1, 3 };
            //Add the elements in SortedSet using Add method
            mySet.Add(5);
            mySet.Add(4);
            mySet.Add(6);
            mySet.Add(2);
            Console.WriteLine("Elements of mySet:\n");
            //Accessing elements of sortedSet using foreach loop
            foreach (var val in mySet)
            {
                Console.WriteLine($"{val,3}");
            }
            Console.ReadLine();
        }
    }
}
