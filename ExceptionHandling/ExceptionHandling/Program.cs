using System;
using System.IO;

class Program
{
    static void Main()
    {
        /*try
        {
            Console.WriteLine("Enter integer number1");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter integer number2");
            int b = int.Parse(Console.ReadLine());
            int ab = a / b;
            Console.WriteLine("Final result = {0}",ab);
        }
        catch(Exception ex)
        {
            Console.WriteLine("Error occured");
        }
        finally
        {
            Console.WriteLine("Finally block is executed");
        }
        Console.WriteLine("End of the program");*/
        try
        {
            StreamReader stream = new StreamReader(@"C: \Users\AL5402\Desktop\C# notes\Hacker rank\textfile");
            Console.WriteLine(stream.ReadToEnd());
            stream.Close();
        }catch(Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
        
    }
}
