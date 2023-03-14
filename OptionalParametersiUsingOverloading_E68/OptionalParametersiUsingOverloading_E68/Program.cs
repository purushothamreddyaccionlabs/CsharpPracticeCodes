using System;
using System.Runtime.InteropServices;

class Program
{
    public static void Main()
    {
        Console.WriteLine("Method parameters optional using method overloading");
        AddNumbers(10, 20);
        AddNumbers(10, 100,new int[]{ 10,10,20});

        //Making method parameters optional by specifying parameter defaults
        Console.WriteLine("Method parameters optional by specifying parameter defaults");
        addNumbersUsingDefaultparameters(10, 20);
        addNumbersUsingDefaultparameters(10, 100, new int[] { 200, 300 });

        //Making method parameters optional by using optionalAttribute
        Console.WriteLine("Method parameters optional by using optionalAttribute");
        SumNumbers(10, 20);
        SumNumbers(20, 100, new int[] { 100, 200, 300, 400 });

    }
    public static void AddNumbers(int firstnumber, int secondnumber)
    {
        /*AddNumbers(firstnumber,secondnumber,null);*/
        //or
        AddNumbers(firstnumber, secondnumber, new int[] { });
    }
    public static void AddNumbers(int firstnumber,int secondnumber,int[] numbers)
    {
        int result = firstnumber + secondnumber;
        if (numbers != null)
        {
            foreach(int i in numbers)
            {
                result += i;
            }
        }
        Console.WriteLine("Total sum = {0}",result.ToString());
    }

    //Making method parameters optional by specifying parameter defaults
    public static void addNumbersUsingDefaultparameters(int fn, int sn, int[] numbers = null)
    {
        int total = fn + sn;
        if(numbers != null)
        {
            foreach(int j in numbers)
            {
                total+= j;
            }
        }
        Console.WriteLine("Total ={0}",total.ToString());
    }

    //Making method parameters optional by using optionalAttribute
    public static void SumNumbers(int firstnumber,int secondnumber, [Optional] int[] numbers)
    {
        int total = firstnumber + secondnumber;
        if(numbers != null)
        {
            foreach(int i in numbers)
            {
                total+=i;
            }
        }
        Console.WriteLine("Total sumof numbers = {0}",total.ToString());

    }


}