using System;

class Program
{
    static void Test1()
    {
        for(int i = 1; i <= 20; i++)
        {
            Console.WriteLine("Test1:  "+i);
        }
        Console.WriteLine("Test1 is exiting..");
    }
    static void Test2()
    {
        for (int i = 1; i <= 20; i++)
        {
            Console.WriteLine("Test2:  " + i);
            if(i == 10)
            {
                Console.WriteLine("Test2 is stopped 5 seconds");
                Thread.Sleep(5000);
                Console.WriteLine("Test2 is Started again");
            }
        }
        Console.WriteLine("Test2 is exiting..");
    }
    static void Test3()
    {
        for (int i = 1; i <= 20; i++)
        {
            Console.WriteLine("Test3:  " + i);
        }
        Console.WriteLine("Test3 is exiting..");
    }

    static void Main()
    {
        Thread t1 = new Thread(Test1);
        Thread t2 = new Thread(Test2);
        Thread t3 = new Thread(Test3);

        t1.Start();
        t2.Start();
        t3.Start();
        Console.WriteLine("Main Thread exiting..");
    }
}