using System;

class Circle
{
    //fields
    static float _PI;
    int _Radius;

    //static constructor
    static Circle()
    {
        Console.WriteLine("Static constructor called");
        Circle._PI = 3.141f;
    }


    //constructor
    public Circle(int radius)
    {
        Console.WriteLine("Instance constructor called");
        _Radius = radius;
    }

    //method

    public float ClaculateArea()
    {
        return Circle._PI * this._Radius * this._Radius;
    }
}


class program
{
    public static void Main()
    {
        Circle c1 = new Circle(8);
        float Area1 = c1.ClaculateArea();
        Console.WriteLine("Area = {0}", Area1);

        Circle c2 = new Circle(9);
        float Area2 = c2.ClaculateArea();
        Console.WriteLine("Area2 = {0}", Area2);
    }
}