using System;
using System.Collections.Specialized;

class Program
{
    static long Count1, Count2;

    static void Test1()
    {
        while(true)
        {
            Count1 += 1;
        }
    }
    static void Test2()
    {
        while(true)
        {
            Count2 += 1;
        }
    }

    static void Main()
    {
        Thread t1 = new Thread(Test1);
        Thread t2 = new Thread(Test2);

        t1.Priority = ThreadPriority.Lowest;
        t2.Priority = ThreadPriority.Highest;

        t1.Start();
        t2.Start();

        Console.WriteLine("Main thread is going to sleep");
        Thread.Sleep(5000);
        Console.WriteLine("Main thread woke up");

        t1.Abort();
        t2.Abort();

        t1.Join();
        t2.Join();

        Console.WriteLine("Test1:  " + Count1);
        Console.WriteLine("Test2:  " + Count2);
    }
}