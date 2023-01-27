using System;

public class ParentClass
{
    //method Overriding
    public virtual void Print()
    {
        Console.WriteLine("I am Parent Class");
    }

    //method hidding 
    public virtual void Hidding()
    {
        Console.WriteLine("This is Parent class");
    }
}
public class ChildClass : ParentClass
{
    //method Overriding
    public override void Print()
    {
        Console.WriteLine("I am Child class");
    }
    //method hidding
    public new void Hidding()
    {
        Console.WriteLine("This is Child class");
    }

}

public class Program
{
    public static void Main()
    {
        //method overring 
        ParentClass p = new ChildClass();
        p.Print();

        //method hidding
        ParentClass t = new ChildClass();
        t.Hidding();
        // to invoke childclass method
        ChildClass c = new ChildClass();
        c.Hidding();
    }
}