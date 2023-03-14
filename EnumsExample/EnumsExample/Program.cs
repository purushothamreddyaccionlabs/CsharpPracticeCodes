using System;

class Program
{
    static void Main()
    {
        Customer[] customers = new Customer[3];
        customers[0] = new Customer
        {
            name = "Randeep",
            gender = Gender.Male
    };
        customers[1] = new Customer
        {
            name = "Latha",
            gender = Gender.Female
        };
        customers[2] = new Customer
        {
            name = "Sam",
            gender = Gender.Unknown
        };
        foreach(Customer customer in customers)
        {
            Console.WriteLine("Name = {0} && Gender = {1}",customer.name,GetGender(customer.gender));
        }
    }

    public static string GetGender(Gender gender)
    {
        switch(gender)
        {
            case Gender.Unknown:
                return "Unknown";
            case Gender.Male:
                return "Male";
            case Gender.Female:
                return "Female";
            default:
                return "Invalid data detected";
        }
    }
}

public enum Gender
{
    Unknown,
    Male,
    Female
}


//0 - Unknown
//1 - Male
//2 - Female
public class Customer
{
    public string name { get; set; }
    public Gender gender { get; set; }
}