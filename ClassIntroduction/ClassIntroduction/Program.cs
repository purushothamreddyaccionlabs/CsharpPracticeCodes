using System;



class customer
{
    // class fields
    string _firstName;
    string _lastName;


    //constructior with out parameters provided
    public customer()
        : this ("No First name provided","No lastName provided")
    {

    }

    // constructor
    public customer(string FirstName,string LastName) {
        this._firstName = FirstName;
        this._lastName = LastName;
    }


    // Method
    public void PrintFullName()
    {
        Console.WriteLine("Full Name = {0}", this._firstName +" "+ this._lastName);
    }

    //Destrutor
    ~customer() { }
}
class Program
{
    public static void Main()
    {
        // Creating instance of the class 
        customer one = new customer("Hari","Prased");

        one.PrintFullName();

        // Creating instance of the class 
        customer c2 = new customer();

        c2.PrintFullName();

       
    }
}