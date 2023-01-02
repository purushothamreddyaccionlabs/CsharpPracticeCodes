using System;
class Program
{
    public static void Main()
    {
        int[] Numbers = new int[3];

        Numbers[0] = 100;
        Numbers[1] = 102;
        Numbers[2] = 103;

        paramsMethod(1,3,6,8,4);
    }
    public static void paramsMethod(params int[] numbers)
    {
        Console.WriteLine("There are {0} elements", numbers.Length);

        foreach(int i in numbers)
        {
            Console.WriteLine(i);
        }
    }
}