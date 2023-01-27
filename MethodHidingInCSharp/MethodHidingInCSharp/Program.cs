using System;

public class Employee
{
    public string FirstName;
    public string LastName;

    public void PrintFullName()
    {
        Console.WriteLine(FirstName + " " + LastName);
    }
}

public class ParttimeEmployee : Employee
{
    public new void PrintFullName()
    {

        //to call hidden base class method using base keyword
       // base.PrintFullName();

       //Console.WriteLine(FirstName + " " + LastName + "- contractor");
    }
}

public class FulltimeEmployee : Employee
{

}

class program
{
    public static void Main()
    {
        FulltimeEmployee f1 = new FulltimeEmployee();
        f1.FirstName = "Fulltime";
        f1.LastName = "Employee";
        f1.PrintFullName();

       //ParttimeEmployee p1 = new ParttimeEmployee();
       //p1.FirstName = "Parttime";
        //p1.LastName = "Employee";

        // p1 object convert to base class using typecast and to call base class hidden method
        //((Employee)p1).PrintFullName();

        // another way to call hidden method from child class
        Employee p1 = new ParttimeEmployee();
        p1.FirstName = "Parttime";
        p1.LastName = "Employee";
        p1.PrintFullName();
    }
}