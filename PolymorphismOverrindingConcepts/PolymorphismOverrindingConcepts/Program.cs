using System;

public class Employee
{
    public string firstName = "FirstName";
    public string lastName = "LastName";

    public virtual void PrintFullName()
    {
        Console.WriteLine(firstName + " " + lastName);
    }
}

public class FulltimeEmployee: Employee
{
    public override void PrintFullName()
    {
        Console.WriteLine(firstName + " " + lastName + " FullTime Employee");
    }

}
public class ParttimeEmployee: Employee
{
    public override void PrintFullName()
    {
        Console.WriteLine(firstName + " " + lastName + " parttime Employee");
    }
}
public class TemporaryEmployee: Employee
{
    public override void PrintFullName()
    {
        Console.WriteLine(firstName + " " + lastName + " Temporary Employee");
    }
}

// Another example

public class Dog
{
    public virtual void woof()
    {
        Console.WriteLine("Woof");
    }
}
public class BigDog : Dog
{
    public override void woof()
    {
        Console.WriteLine("Woof woof woof wooooooof woooooooooo");
    }
}
class Program
{
    public static void Main()
    {
        Employee[] employees = new Employee[4];
        employees[0] = new Employee();
        employees[1] = new FulltimeEmployee();
        employees[2] = new ParttimeEmployee();
        employees[3] = new TemporaryEmployee();

        foreach(Employee i in employees)
        {
            i.PrintFullName();
        }

        Dog smalldog = new Dog();
        BigDog big = new BigDog();

        smalldog.woof();
        big.woof();
    }
}