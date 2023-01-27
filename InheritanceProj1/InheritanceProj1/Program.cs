using System;
using System.Security.Cryptography;

public class Employee
{
    public string _firstName;
    public string _lastName;


     public Employee(string firstName, string lastName)
    {
        this._firstName = firstName;
        this._lastName = lastName;
    }

    public void fullname()
    {
        Console.WriteLine(_firstName + " " + _lastName);
    }
}

public class FulltimeEmployee:Employee
{
    public int _YearlySalary;

    public FulltimeEmployee(string firstName,string lastName,int yearlySalary):base( firstName, lastName)
    {
        this._YearlySalary = yearlySalary;
    }
}

public class PartTimeEmployee:Employee
{
    public int _hourlySalary;

    public PartTimeEmployee(string firstName,string lastName,int hourlySalary) : base(firstName, lastName)
    {
        this._hourlySalary = hourlySalary;
    }
}



class program
{
    public static void Main()
    {
        FulltimeEmployee f1 = new FulltimeEmployee("Hari", "Prasad", 300000);
        f1.fullname();

        PartTimeEmployee p1 = new PartTimeEmployee("Rajesh", "Kumar", 400000);
        p1.fullname();

       
    }
}