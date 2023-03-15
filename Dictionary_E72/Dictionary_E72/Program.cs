using System;
class Program
{
    public static void Main()
    {
        Customer customer1 = new Customer()
        {
            Id = 101,
            Name = "Raju",
            Salary = 7600
        };
        Customer customer2 = new Customer()
        {
            Id = 120,
            Name = "Krishna",
            Salary = 9800
        };
        Customer customer3 = new Customer()
        {
            Id = 119,
            Name = "Praveen",
            Salary = 6500
        };

        Dictionary<int, Customer> dictionary1 = new Dictionary<int, Customer>();

        dictionary1.Add(customer1.Id, customer1);
        dictionary1.Add(customer2.Id, customer2);
        dictionary1.Add(customer3.Id, customer3);

        Customer dictionaryitem =dictionary1[120];

        /*Console.WriteLine("Id = {0}, Name = {1}, Salary = {2}",dictionaryitem.Id,dictionaryitem.Name,dictionaryitem.Salary);*/

        foreach (KeyValuePair<int,Customer> Pairs in dictionary1)
        {
            Console.WriteLine("Key = {0}",Pairs.Key);
            Customer curt = Pairs.Value;
            Console.WriteLine("Id = {0}, Name = {1}, Salary = {2}", curt.Id, curt.Name, curt.Salary);
            Console.WriteLine("------------------------------------------------------------------------");
        }

        //If you want to print keys only
        foreach(int keys in dictionary1.Keys)
        {
            Console.WriteLine(keys);
        }
        //If you want to print values only
        foreach(Customer cust in dictionary1.Values)
        {
            Console.WriteLine("Id = {0}, Name = {1}, Salary = {2}", cust.Id, cust.Name, cust.Salary);
        }



        //TryGetValue
        Console.WriteLine("==================================TryGetValue===========================================================");
        Customer findcust;
        dictionary1.TryGetValue(1278, out findcust);
        if(findcust != null)
        {
            Console.WriteLine("Id = {0}, Name = {1}, Salary = {2}", findcust.Id, findcust.Name, findcust.Salary);
        }

        //Count
        Console.WriteLine("==================================Count=================================================================");
        Console.WriteLine("Total items = {0}",dictionary1.Count());
        Console.WriteLine("Total items whose salary greater than 5000 = {0}", dictionary1.Count(keyvaluepair => keyvaluepair.Value.Salary > 8000));

        //Remove 
        //dictionary1.Remove(101);

        //Clear
        //dictionary1.Clear();

        //Converting an Array to dictionary
        Console.WriteLine("==================================Array to Dictionary===================================================");
        Customer[] customers = new Customer[3];
        customers[0] = customer1;
        customers[1] = customer2;
        customers[2] = customer3;
        Dictionary<int,Customer> dict = customers.ToDictionary(Item => Item.Id, Item => Item);
        foreach (KeyValuePair<int, Customer> Pairs in dict)
        {
            Console.WriteLine("Key = {0}", Pairs.Key);
            Customer curt = Pairs.Value;
            Console.WriteLine("Id = {0}, Name = {1}, Salary = {2}", curt.Id, curt.Name, curt.Salary);
            Console.WriteLine("------------------------------------------------------------------------");
        }
    }
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
}