using System;


class Program
{
    public delegate string PrintDelegate(string Message);

/*    public static string PrintData(string Messages)
    {
             return "Hello "+Messages + "a very good morning";
    }*/
    public static void Main()
    {
        //PrintDelegate subject  = new PrintDelegate(PrintData);
        //string str = subject.Invoke("Purushotham");
        //Console.WriteLine(str);

        //anonymus method

        PrintDelegate subject = delegate (string name)
        {
            return "Hello " + name + "a very good morning";
        };
        string str = subject.Invoke("Hari");
        Console.WriteLine(str); 

    }
}