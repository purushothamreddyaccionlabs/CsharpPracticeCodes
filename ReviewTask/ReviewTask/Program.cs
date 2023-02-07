using System;

class program
{
    public static void Main()
    {
        Console.WriteLine("Enter Number");
        int uservalue = Convert.ToInt32(Console.ReadLine());

        int a = 2;
        int count = 0;
        while (a <= uservalue && count <= 1)
        {
            if (uservalue % a ==0)
            {
                count++;
            }
            a++;
        }
        if(count == 1)

        {
            Console.WriteLine("It's a prime number");
        }
        else
        {
            Console.WriteLine("It's not a prime number");
        }
    }
}