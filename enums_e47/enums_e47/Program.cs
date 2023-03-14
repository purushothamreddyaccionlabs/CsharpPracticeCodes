using System;

class Program
{
    public static void Main()
    {
        short[] values = (short[])Enum.GetValues(typeof(Gender));

        foreach(int item in values)
        {
            Console.WriteLine(item);
        }

        string[] names = Enum.GetNames(typeof(Gender));

        foreach(string name in names)
        {
            Console.WriteLine(name);
        }
    }
}

public enum Gender:short
{
    Unknown = 3,
    Male=56,
    Female=7876
}