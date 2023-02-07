using System;
interface ICustomer1
{
  
    void Print();
}
interface ICustomer2:ICustomer1
{
    void Print2();
}
public class Customer: ICustomer2
{
    public void Print2()
    {
        Console.WriteLine("This is print2");
    }
    public void Print()
    {
        Console.WriteLine("This is print");
    }

}


class Program
{
    public static void Main()
    {
        ICustomer2 c1 = new Customer();
        c1.Print();
        c1.Print2();
      
    }
}