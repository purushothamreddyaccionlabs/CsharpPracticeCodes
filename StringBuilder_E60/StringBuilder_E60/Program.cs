using System;
using System.Text;

class Program
{
    public static void Main()
    {
        StringBuilder abc = new StringBuilder();
        for(int i =0; i<10000; i++)
        {
            abc.Append(i.ToString()).Append(" ");
        }
        Console.WriteLine(abc);
    }
}
