using System;

class Program
{
    static void Main()
    {
        Test1();
        Test2();
        Test3();
    }

    static void Test1()
    {
        for(int i = 0; i <= 100; i++)
        {
            Console.WriteLine("Test1: " + i);
        }
    }
    static void Test2()
    {
        for (int i = 0; i <= 100; i++)
        {
            Console.WriteLine("Test2: " + i);
            if (i == 50)
            {
                Console.WriteLine("Test2 is stopped 5 Seconds");
                Thread.Sleep(5000);
                Console.WriteLine("Test2 is Started now");
                
            }
        }
    }
    static void Test3()
    {
        for (int i = 0; i <= 100; i++)
        {
            Console.WriteLine("Test3: " + i);
        }
    }
}