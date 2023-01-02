using System;
using PATA = ProjectA.TeamA;
using PATB = ProjectA.TeamB;
class program
{
    public static void Main()
    {
        PATA.classA.Print();
        PATB.classA.Print();
    }
}


namespace ProjectA
{
    namespace TeamA
    {
        class classA
        {
            public static void Print()
            {
                Console.WriteLine("Print team A data");
            }
        }
    }
}


    namespace ProjectA
    {
        namespace TeamB
        {
            class classA
            {
                public static void Print()
                {
                    Console.WriteLine("Print team B data");
                }
            }
        }
    }
    

