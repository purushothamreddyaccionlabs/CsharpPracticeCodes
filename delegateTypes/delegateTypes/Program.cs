using System;

class Program
{
    public delegate double delegate1(int x, float y, double z);
    public delegate void delegate2(int x, float y, double z);
    public delegate bool delegate3(string str);
  /*  public class Generic
    {
        public static double addnum1(int x,int y,int z)
        {
            return x + y + z;
        }
        public static void addnum2(int x,int y,int z)
        {
            Console.WriteLine(x + y + z);
        }
        public static bool CheckLength(string str)
        {
            if (str.Length > 5)
                return true;
            return false;
        }
    }*/
    static void Main()
    {
        Func<int,float,double,double> obj = (x,y,z) => x+y+z;
        double str = obj.Invoke(1, 2, 3);
        Console.WriteLine(str);

        Action<int, float, double> obj2 = (x, y, z) => Console.WriteLine(x+y+z);
        obj2.Invoke(10, 20, 30);

        Predicate<string> obj3 = (strs) =>
        {
            if (strs.Length > 5)
                return true;
            return false;
        };
        bool status = obj3.Invoke("Hello world");
        Console.WriteLine(status);  


    }
}