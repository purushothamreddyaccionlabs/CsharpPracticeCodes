using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    public static void Main()
    {


        List<int> numbers = new List<int>() { 1, 5, 73, 83, 8, 2, 9, 10 };
        numbers.Sort();
       foreach(int num in numbers)
        {
            Console.WriteLine(num);
        }

        numbers.Reverse();
        Console.WriteLine("numbers in descending order");
        foreach(int num in numbers)
        {
            Console.WriteLine(num);
        }



        List<string> alphabets = new List<string>() { "A", "Z", "F", "J","Y","H" };
        alphabets.Sort();
        foreach(string alph in alphabets)
        {
            Console.WriteLine(alph);
        }

        alphabets.Reverse();
        foreach (string alphs in alphabets)
        {
            Console.WriteLine(alphs);
        }

        Customer customer1 = new Customer()
        {
            Id = 101,
            Name = "Rajesh",
            Salary = 25000,
            Type = "Retail Customer"
        };
        Customer customer2 = new Customer()
        {
            Id = 102,
            Name = "Vinod",
            Salary = 7690,
            Type = "Retail Customer"
        };
        Customer customer3 = new Customer()
        {
            Id = 156,
            Name = "Mahesh",
            Salary = 5000,
            Type = "Corporate Customer"
        };
        Customer customer4 = new Customer()
        {
            Id = 145,
            Name = "Prasad",
            Salary = 7910,
            Type = "Corporate Customer"
        };
        Customer customer5 = new Customer()
        {
            Id = 196,
            Name = "Kishore",
            Salary = 9000,
            Type = "Corporate Customer"
        };

        List<Customer> listcustomer = new List<Customer>();
        listcustomer.Add(customer1);
        listcustomer.Add(customer2);
        listcustomer.Add(customer3);


        /*        List<Customer> listcorporate = new List<Customer>();
                listcorporate.Add(customer3);
                listcorporate.Add(customer4);
                listcorporate.Add(customer5);

                listcustomer.AddRange(listcorporate);*/
        /*
                foreach(Customer c in listcustomer)
                {
                    Console.WriteLine("Id = {0}, Name = {1}, Salary = {2}, Type = {3}",c.Id,c.Name,c.Salary,c.Type);
                }*/

        /*List<Customer> customers = listcustomer.GetRange(0, 3);
        foreach (Customer c in customers)
        {
            Console.WriteLine("Id = {0}, Name = {1}, Salary = {2}, Type = {3}", c.Id, c.Name, c.Salary, c.Type);
        }*/

        



        Console.WriteLine("Before sorting");
        foreach(Customer c in listcustomer)
        {
            Console.WriteLine(c.Name);
        }
        SortbyName sortbyname = new SortbyName();
        listcustomer.Sort(sortbyname);

        Console.WriteLine("After sorting");
        foreach(Customer c in listcustomer)
        {
            Console.WriteLine(c.Name); 
        }


    }
    public class SortbyName : IComparer<Customer>
    {
       public int Compare(Customer x, Customer y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }
}
public class Customer/*:IComparable<Customer>*/
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Salary { get; set; }
    public string Type { get; set; }

 /*  public  int CompareTo(Customer other)
    {
        *//* if (this.Salary > other.Salary)
             return 1;
         else if (this.Salary < other.Salary)
             return -1;
         else
             return 0;*/

        /*        return this.Salary.CompareTo(other.Salary);*//*
        return this.Name.CompareTo(other.Name);
    }*/
}
