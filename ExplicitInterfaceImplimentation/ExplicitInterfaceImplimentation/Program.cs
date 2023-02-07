using System;

interface IF1
{
    void PrintData();
}
interface IF2
{
    void PrintData();
}
public class Program:IF1,IF2
{

    void IF1.PrintData()
    {
        Console.WriteLine("Hi this from IF1");
    }
    void IF2.PrintData()
    {
        Console.WriteLine("Hi this from IF2");
    }
    public static void Main()
    {
        //Program c1 = new Program();
        //((IF1)c1).PrintData();
        //((IF2)c1).PrintData();

        IF1 f1 = new Program();
        IF2 f2 = new Program();

        f1.PrintData();
        f2.PrintData();
    }
}