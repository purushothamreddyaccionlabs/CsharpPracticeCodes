using System;

class Program
{
    public void Display()
    {
        lock (this)
        {
            Console.Write("[ Csharp is an");
            Thread.Sleep(5000);
            Console.WriteLine(" Object oriented programing Language ]");
        }
    }

    static void Main()
    {
        Program obj = new Program();

        Thread t1 = new Thread(obj.Display);
        Thread t2 = new Thread(obj.Display);
        Thread t3 = new Thread(obj.Display);

        t1.Start();
        t2.Start();
        t3.Start();
    }
}