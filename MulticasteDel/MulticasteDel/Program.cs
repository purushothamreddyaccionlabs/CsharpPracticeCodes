using System;


public delegate void simpleDelegate();
class Program
{
    static void Main()
    {
        simpleDelegate del1, del2, del3, del4,del5;
        del1 = new simpleDelegate(sampleDelegate1);
        del2 = new simpleDelegate(sampleDelegate2);
        del3 = new simpleDelegate(sampleDelegate3);
        del4 = new simpleDelegate(sampleDelegate4);

        del5 = del1 + del2 + del3 + del4 - del2;

        del5.Invoke();
        //another way
        simpleDelegate delgate = new simpleDelegate(sampleDelegate1);
        delgate += sampleDelegate2;
        delgate += sampleDelegate3;
        delgate += sampleDelegate4;
        delgate -= sampleDelegate2;
        delgate.Invoke();
    }

    public static void sampleDelegate1()
    {
        Console.WriteLine("sampleDelegate1");
    }
    public static void sampleDelegate2()
    {
        Console.WriteLine("sampleDelegate2");
    }
    public static void sampleDelegate3()
    {
        Console.WriteLine("sampleDelegate3");
    }
    public static void sampleDelegate4()
    {
        Console.WriteLine("sampleDelegate4");
    }
}