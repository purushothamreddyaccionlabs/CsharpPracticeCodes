using System;
class Program
{
    public static void Main()
    {
        AddNumbers(10, 20);
        AddNumbers(10, 20, 30, 40, 50, 60);
        AddNumbers(10, 20, new int[] { 1,2,2,34,674,3456,3456,2376,876,876,3});
    }

    public static void AddNumbers(int firstnumber,int secondnumber, params int[] numbers)
    {
        int result = firstnumber + secondnumber;
        if(numbers!= null)
        {
            foreach (int i in numbers)
            {
                result += i; 
            }
        }
        
        Console.WriteLine("Total sum = {0}",result.ToString());
    }
}