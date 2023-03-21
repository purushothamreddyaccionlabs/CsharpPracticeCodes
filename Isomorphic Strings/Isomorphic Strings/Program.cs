using System;

class Program
{
    static void Main()
    {
        string s = "egg";
        string t = "add";
        char[] str1 = s.ToCharArray();
        char[] str2 = t.ToCharArray();
        Dictionary<char, char> charCount = new Dictionary<char, char>();
        char c = 'a';
        // if(str1.Length != str2.Length) return false;
        for (int i = 0; i < str1.Length; i++)
        {
            if (charCount.ContainsKey(str1[i]))
            {
                charCount.TryGetValue(str1[i], out c);
                if (c != str2[i])
                    Console.WriteLine(false); 
            }
            else if (!charCount.ContainsValue(str2[i]))
            {
                charCount.Add(str1[i], str2[i]);
            }
            else
            {
                Console.WriteLine(false);
            }
        }
        Console.WriteLine(true);

    }
}