using System;
using System.Diagnostics;

public class SingleVSMultithreadingDiff
{
    public static void Incrementcount1()
    {
        long count = 0;
        for (long i = 0; i <= 1000000000; i++)
            count++;
        Console.WriteLine("IncrementCounter1: " + count);
    }
    public static void Incrementcount2()
    {
        long count2 = 0;
        for (long i = 0; i <= 1000000000; i++)
            count2++;
        Console.WriteLine("IncrementCounter2: " + count2);
    }

    static void Main()
    {
        Stopwatch s1 = new Stopwatch();
        Stopwatch s2 = new Stopwatch();

        Thread t1 = new Thread(Incrementcount1);
        Thread t2 = new Thread(Incrementcount2);

        s1.Start();
        Incrementcount1();
        Incrementcount2();
        s1.Stop();

        s2.Start();
        t1.Start();
        t2.Start();
        s2.Stop();

        t1.Join();
        t2.Join();



        Console.WriteLine("Total time for singleThreading:  " + s1.ElapsedMilliseconds);
        Console.WriteLine("Total time for multiThreading:  " + s2.ElapsedMilliseconds);
    }
}
