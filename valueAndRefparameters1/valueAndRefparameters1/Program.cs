using System;
class program
{
    public static void Main()
    {
        int i = 12;
        int a = 0;
        
        // value parameters
        method(i);
        Console.WriteLine(i);

        // Reference parameters
        reference(ref a);
        Console.WriteLine(a);


        // out parameters

        int total = 0;
        int product = 0;
        calculation(10, 20, out total, out product);

        Console.WriteLine(total);
        Console.WriteLine(product);


        //Parameter Arrays

        int[] noArray = new int [3];

        noArray[0] = 1;
        noArray[1] = 2;
        noArray[2] = 3;



        //paramsMethod();

         paramsMethod(noArray);

        paramsMethod(1,9,3,7,36,9836,7);

    }

    // value parameters method
    public static int method( int i)
    {
       return i = 123;
    }

    // Reference parameters method
    public static void reference(ref int j)
    {
        j = 987;
    }

    //Out parameters method
    public static void calculation( int fn,int sn, out int sum,out int product)
    {
        sum = fn + sn;
        product = fn * sn;
    }


    //Params
    public static void paramsMethod(params int[] numbers)
    {
        Console.WriteLine("length of the array {0}",numbers.Length);    

        foreach(int i in numbers)
        {
            Console.WriteLine(i);
        }
    }
}