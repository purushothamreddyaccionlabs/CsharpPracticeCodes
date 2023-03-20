using System;

class Program
{
    static void Test1()
    {
        for(int i = 1; i <= 50; i++)
            Console.WriteLine("test1: " + i);
        Thread.Sleep(5000);
        Console.WriteLine("Test1 Exiting...");
    }
    static void Test2()
    {
        for (int i = 1; i <= 50; i++)
            Console.WriteLine("test2: " + i);
        Console.WriteLine("Test2 Exiting...");
    }
    static void Test3()
    {
        for (int i = 1; i <= 50; i++)
            Console.WriteLine("test3: " + i);
        Console.WriteLine("Test3 Exiting....");
    }


    static void Main()
    {

        Console.WriteLine("Main thread started");
        Thread t1 = new Thread(Test1);
        Thread t2 = new Thread(Test2);
        Thread t3 = new Thread(Test3);
        t1.Start();
        t2.Start();
        t3.Start();
        t1.Join(3000);
        t2.Join();
        t3.Join();

        Console.WriteLine("Main thread exiting..");

    }
}