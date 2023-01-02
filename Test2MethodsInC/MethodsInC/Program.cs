using System;
class Program
{
    public static void Main()
    {
        Console.WriteLine("Hi user please enter your target number and get even numbers");
        int userNumber = int.Parse(Console.ReadLine());
        Program.EvenNumber(userNumber);
        
        
        Program P = new Program();
        int sum = P.add(40,60);
        Console.WriteLine("Sum = {0}",sum);
     
    }
    public static void EvenNumber(int target)
    {
        int Start = 0;
        while (Start <= target)
        {
            Console.WriteLine(Start);
            Start = Start + 2;
        }
    }
    public int add(int Fn,int Ln)
    {
        return Fn + Ln;
    }
}
