using System;
using System.Threading;

namespace Slot8_Concurrency
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(() =>
            {
                DemoThread("Thread 1");
            });
            t.Start();

            Thread t2 = new Thread(() =>
            {
                DemoThread("Thread 2");
            });
            t2.Start();

            Thread t3 = new Thread(() =>
            {
                DemoThread("Thread 3");
            });
            t3.Start();

            
        }

        static void DemoThread(string threadIndex)
        {
            for(int i=0; i < 100; i++)
            {
                //Thread.Sleep(TimeSpan.FromSeconds(1));
                Console.WriteLine($"threadIndex {threadIndex} - {i}" );
            }
        }
    }
}
