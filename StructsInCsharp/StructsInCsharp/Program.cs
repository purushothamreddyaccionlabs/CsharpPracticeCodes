using System;

//structures or structs
public struct Customer
{
    //fields
    private int _id;
    private string _name;


    //properties
    public int Id
    {
        get { return _id; }
        set { _id = value; }
    }

    public string Name { get  =>_name; set => _name = value; }

    //constuctor
    public Customer(int Id,string Name)
    {
        this._id = Id;
        this._name = Name;
    }

    //Method
    public void PrintDetails()
    {
        Console.WriteLine("Id = {0} && Name = {1}", this._id, this._name);
;    }
}

public class program
{
    public static void Main()
    {

        //create instance of customer
        Customer c1 = new Customer(101, "Purushotham");
        c1.PrintDetails();

        // another way to create instance using default constructor
        Customer c2 = new Customer();
        c2.Id = 123;
        c2.Name = "Rahul";
        c2.PrintDetails();

        // new way to create instance of a class object initializer syntax
        Customer c3 = new Customer()
        {
            Id = 209,
            Name = "Ramesh"
        };
        c3.PrintDetails();


    }

}