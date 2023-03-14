using System;

public class Program
{
    public static void Main()
    {
        bool Equal = Calculator<int>.AreEqual(10, 10);
        if (Equal)
        {
            Console.WriteLine("Equal");
        }
        else
        {
            Console.WriteLine("Not equal");
        }
    }
}
public class Calculator<T>
{
    public static bool AreEqual(T fn, T sn)
    {
        return fn.Equals(sn);
    }
}