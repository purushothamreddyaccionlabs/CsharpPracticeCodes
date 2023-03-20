using System;

class Program
{

    ////With out parameter
    //static void Test()
    //{
    //    for(int i = 1; i <= 100; i++)
    //    {
    //        Console.WriteLine("Test1: "+ i);
    //    }
    //}

    static void Test(Object Max)
    {
        int num = Convert.ToInt32(Max);
        for(int i = 1; i <= num; i++)
        {
            Console.WriteLine("Test: "+i);
        }
    }

    static void Main()
    {
        /*//With out parameter
        ThreadStart obj = new ThreadStart(Test);
        Thread t = new Thread(obj);
        t.Start();*/


        ParameterizedThreadStart obj = new ParameterizedThreadStart(Test);
        Thread t = new Thread(obj);
        t.Start(25);
    }
}