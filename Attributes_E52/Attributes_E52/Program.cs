using System;
using System.Diagnostics.CodeAnalysis;
using System.Collections.Generic;



public class Program
{
    public static void Main()
    {
        Calculator.Add(new List<int>() { 10, 20, 30, 40 });
        Calculator.Add(10, 20); // while usign this method you will get warning
    }

   
}

public class Calculator
{
    [ObsoleteAttribute("Use Add(List<int> numbers) Method")]
    public static int Add(int FirstNumber, int SecondNumber)
    {
        return FirstNumber + SecondNumber;
    }

    public static int Add(List<int> numbers)
    {
        var sum = 0;
        foreach(int item in numbers)
        {
            sum = sum + item;
        }

        return sum;
    }
}

