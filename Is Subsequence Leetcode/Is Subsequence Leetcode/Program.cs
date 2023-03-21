using System;

class Program
{
    public static bool IsSubsequence(string s, string t)
    {
        int sIndex = 0;
        int tIndex = 0;
        while (sIndex < s.Length && tIndex < t.Length)
        {
            if (s[sIndex] == t[tIndex])
            {
                sIndex++;
            }
            tIndex++;
        }
        return sIndex == s.Length;
    }
    static void Main()
    {
        Console.WriteLine(IsSubsequence("abc","ahbgdc"));
    }
}