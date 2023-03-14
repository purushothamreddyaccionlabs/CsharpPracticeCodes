using System;

public class Program
{
    public delegate string GreetingsDelegate(string name);
    class lambdaex
    {
        
        public static string Greetings(string name)
        {
            return "Hello" + name + "a very good morning";
        }
    }
    public static void Main()
    {
        GreetingsDelegate obj = delegate (string name)   
        {
            return "Hello" + name + "a very good morning";
        };


        //lambda expression is used to simplify the anonymus method
        GreetingsDelegate lamd = (name) =>
        {
            return "hello " + name + "a very good morning from lambda expression";
        };


        string str = obj.Invoke("Purushotham");
        Console.WriteLine(str);

        string abc = lamd.Invoke("Purushotham");
        Console.WriteLine(abc);
    }
}