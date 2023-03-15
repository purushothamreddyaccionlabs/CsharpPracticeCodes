using System;

class Program{ // remove duplicates in string
    public static void Main()
    {
        string str = "Purushotham Reddy siddala";// given input
        string newstr = string.Empty;
     

     
        foreach (char c in str)
        {
         if(newstr.Length == 0)
            {
                newstr += c;
            }
            else
            {
                bool Notmatch = true;
                foreach (char n in newstr)
                {
                    if (c == n)
                    {
                        Notmatch = false;
                    }

                }
                if (Notmatch)
                {
                    newstr += c;
                }
            }
            
            
        }
        Console.WriteLine(newstr);


    }

}