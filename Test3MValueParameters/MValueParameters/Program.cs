using System;
using System.Diagnostics.CodeAnalysis;

class program
{
    public static void Main()
    {
        int TotalSum = 0;
        int TotalMul = 0;
        int subtration = 0;
        CalculationPart(10, 20, out TotalSum,out TotalMul,out subtration);
        Console.WriteLine("Sum total = {0} && Multiplication = {1} && Subtration Value = {2}",TotalSum,TotalMul,subtration);
        
   
    }
    public static void CalculationPart(int FN, int SN, out int Sum,out int mul,out int subtr)
    {
        Sum = FN + SN;
        mul = FN * SN;
        subtr = FN - SN;
    }
   
}
