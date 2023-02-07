using System;

interface IA
{
    void AMethod();
}
public class A : IA
{
    public void AMethod()
    {
        Console.WriteLine("A");
    }
}
interface IB
{
    void BMethod();
}
public class B : IB
{
    public void BMethod()
    {
        Console.WriteLine("B");
    }
}
public class AB : IA, IB
{
    A a = new A();
    B b = new B();

    public void AMethod() { 
    a.AMethod();
   }
    public void BMethod() {
    b.BMethod();}
}


class Program
{
    public static void Main()
    {
        AB ab = new AB();
        ab.AMethod();
        ab.BMethod();
    }
}