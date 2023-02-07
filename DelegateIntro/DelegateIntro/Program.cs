using System;

public delegate void helloFunction(string message);
class Program
{
    public static void Main()
    {
        helloFunction delgate = new helloFunction(Hello);
        delgate("This Hello message from delegae function");
    }

    public static void Hello(string strMessage)
    {
        Console.WriteLine(strMessage);
    }
}