using System;

class Program
{
    static void Main()
    {
        int[] nums = new int[] { 1, 7, 3, 6, 5, 6 };
        int rightSum = nums.Sum();
        int leftSum = 0;

        for(int i = 0; i < nums.Length; i++)
        {
            rightSum -= nums[i];
            if (leftSum == rightSum)
            {
                Console.WriteLine(i);
            }
            leftSum += nums[i];
           
           
        }
        Console.WriteLine("Not match");
        
    }
}