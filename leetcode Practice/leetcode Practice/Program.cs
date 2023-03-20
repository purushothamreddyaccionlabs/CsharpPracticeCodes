using System;
using System.Xml.XPath;

class Program
{
    static void Main()
    {
        int[] num = new int[] { 1, 2, 3, 4 };
        int numLength = num.Length;

        /*int[] newValues = num.Select(x => x + x).ToArray();
        foreach(int nu in newValues)
        {
            Console.WriteLine(nu);
        }*/

        int[] newarr = new int[numLength];
        for (int i = 0; i < numLength; i++)
        {
            int result = 0;
            for (int j = 0; j <= i; j++)
            {
                result += num[j];
            }
            newarr[i] = result;
        }
        foreach (int i in newarr)
        {
            Console.WriteLine(i);
        }
    }
}
