using System;
using System.Xml.Schema;

class program
{
    public static void Main()
    {
        calculate(20, 20, out int total, out int product);
        Console.WriteLine(total);
        Console.WriteLine(product);
    }
    public static void calculate(int FN,int SN, out int SUM,out int product)
    {
        SUM = FN+SN;
        product = SN * FN;
    }
}